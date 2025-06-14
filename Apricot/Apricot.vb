﻿Imports System.IO
Imports System.Text

Public Module Apricot
    Public template_cache As New Dictionary(Of String, String)()
    Public encodingType As Encoding = New UTF8Encoding(False)
    Public knownExtensions() As String = {"txt", "md", "css", "ts", "js", "html", "htm", "php", "phtml", "xml", "json", "csv", "lass", "sass", "gophermap"}
    Private warnedExtensions = False

    'https://stackoverflow.com/a/3448307
    Public Function ReadAllText(ByVal path As String)
        Dim inStream = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim streamReader = New StreamReader(inStream)
        Dim text As String = streamReader.ReadToEnd()
        streamReader.Dispose()
        inStream.Dispose()
        Return text
    End Function

    'https://bytes.com/topic/visual-basic-net/answers/370586-replace-first-occurrance-substring#post1428786
    Public Function ReplaceFirst(ByVal expression As String, ByVal find As String, ByVal replacement As String) As String
        Dim index As Integer = expression.IndexOf(find)
        If index < 0 Then
            Return expression
        End If
        Return expression.Remove(index, find.Length).Insert(index, replacement)
    End Function

    'https://stackoverflow.com/questions/22268373/vb-c-replace-string
    Public Function ReplaceLast(ByVal str As String, ByVal search As String, ByVal newText As String) As String
        Dim ind As Integer = str.LastIndexOf(search)

        If ind < 0 Then
            Return str
        End If

        Return str.Substring(0, ind) & newText & str.Substring(ind + search.Length)
    End Function

    'https://stackoverflow.com/questions/5193893/count-specific-character-occurrences-in-a-string
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    'https://social.msdn.microsoft.com/forums/windows/en-us/07e63494-9ee0-412e-8a8d-cfc9b91f456a/string-function-for-repeating-character-string
    Public Function FillString(ByVal ch As String, ByVal count As Integer) As String
        Dim sb As StringBuilder = New StringBuilder(count)

        For ix As Integer = 0 To count - 1
            sb.Append(ch)
        Next

        Return sb.ToString()
    End Function

    Public Class ApricotOutput
        Private _html As String

        Public Property HTML() As String
            Get
                Return _html
            End Get
            Set(ByVal value As String)
                _html = value
            End Set
        End Property

        Private _attribs As New Dictionary(Of String, String)

        Public Property Attributes() As Dictionary(Of String, String)
            Get
                Return _attribs
            End Get
            Set(ByVal value As Dictionary(Of String, String))
                _attribs = value
            End Set
        End Property

    End Class

    Public Class TNode
        Private _relPath As String

        Public Property relPath() As String
            Get
                Return _relPath
            End Get
            Set(ByVal value As String)
                _relPath = value
            End Set
        End Property

        Private _Attribute As String

        Public Property Attribute() As String
            Get
                Return _Attribute
            End Get
            Set(ByVal value As String)
                _Attribute = value
            End Set
        End Property

        Private _Value As String

        Public Property Value() As String
            Get
                Return _Value
            End Get
            Set(ByVal value As String)
                _Value = value
            End Set
        End Property

    End Class

    Private Sub doLog(ByVal msg As String, Optional ByVal worker As Object = Nothing, Optional ByVal progress As Integer = 0)
        Console.WriteLine(msg)
        If Not worker Is Nothing Then
            worker.ReportProgress(progress, msg)
        End If
    End Sub

    Public Function Compile(ByVal pageHtml As String, ByVal inputFilename As String, ByVal siteRoot As String, ByVal local As Boolean, Optional ByVal modifiedDate As Date = Nothing, Optional ByVal worker As Object = Nothing)
        Dim filename = inputFilename

        If local Then ' clear cache for previews
            template_cache.Clear()
        End If

        If filename.Contains(".") And (Not filename.StartsWith(".")) Then ' if contains an extension and is not a dotfile
            Dim ext As String() = filename.Split(".")
            Dim extension = ext(ext.Length - 1)
            Dim pass = False
            For Each ex In knownExtensions
                If extension = ex Then
                    pass = True
                End If
            Next
            If Not pass Then
                If Not worker Is Nothing Then
                    ' bypassing this
                    'If MsgBox("The type of file " & filename & " is unknown. If this is an image or asset other than a Page, choose Cancel to skip processing it.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Unknown Extension") = MsgBoxResult.Cancel Then
                    'Return False
                    'End If
                End If
                doLog("WARN: The type " & extension & " is unknown. If this is an image or asset other than a page, place it in Includes. Further warnings will be suppressed.", worker, 40)
            End If
        End If

        Dim log As String = ""
        Dim templates = Path.Combine(siteRoot, "templates\")
        Dim content = ""
        Dim attribs As New Dictionary(Of String, String)()
        attribs.Item("template") = "default"
        If Not modifiedDate = Nothing Then
            Try
                attribs.Item("modified") = modifiedDate.ToString.Split(" ")(0)
            Catch ex As Exception
            End Try
            Try
                'attribs.Item("mod_time") = modifiedDate.ToString.Split(" ")(1).Split(":")(0) & ":" & modifiedDate.ToString.Split(" ")(1).Split(":")(1)
            Catch ex As Exception
            End Try
            Try
                If modifiedDate.ToString.Split(" ").Length > 2 Then
                    'attribs.Item("mod_time") &= " " & modifiedDate.ToString.Split(" ")(2)
                End If
            Catch ex As Exception
            End Try
        End If
        While filename.StartsWith("\")
            filename = ReplaceFirst(filename, "\", "")
        End While
        While filename.StartsWith("/")
            filename = ReplaceFirst(filename, "/", "")
        End While
        attribs.Item("path") = filename.Replace("\", "/")
        Dim reader As New StringReader(pageHtml)
        Dim line As String
        Do
            line = reader.ReadLine
            ' Quick rundown of the syntax:
            ' As of current builds whitespace is handled VERY flexibly. So these are valid, but semantically equivalent:
            ' <!-- attrib bagel: cream cheese -->
            ' <!--attrib bagel cream cheese -->
            ' <!--attrib bagel: cream cheese  -->
            ' <!-- attrib bagel: cream cheese -->
            ' <!--attrib bagel: cream cheese -->
            ' <!--   attrib     bagel  :  cream cheese      -->
            ' This purposefully doesn't match: <!-- attribbagel: cream cheese -->
            ' Group 1 (value): "bagel"
            ' Group 2 (key): "cream cheese"
            ' Implementation note: Attributes are read anywhere in the file, i.e., don't stop after a line doesn't match.
            ' (Possibly too generous, and Attribute declarations being at the top of the file might be enforced later.)
            ' Flexible handling of whitespace in this way fixes automated programs that might not support the old, rigid style (as in this regex:)
            ' <!-- attrib (.*): (.*) -->
            ' If it was desired to support omitting the attrib keyword one can just change {1} to {0,1} but this might take
            ' in any comment with a colon in it so I'm avoiding it for now. Rationale to enforce attributes in the top so body
            ' comments don't get accidentally picked up.
            ' BTW words are allowed in keys just like values, please don't do this though(?)
            Dim regex As RegularExpressions.Regex = New RegularExpressions.Regex("<!--\s*(?:attrib\s){1}\s*(.*?)\s*:\s*(.*?)\s*-->")
            If Not line Is Nothing Then
                Dim match As RegularExpressions.Match = regex.Match(line)
                If match.Success Then
                    attribs.Item(match.Groups(1).Value) = match.Groups(2).Value
                Else
                    content = content & Environment.NewLine & line
                End If
            End If
        Loop Until line Is Nothing
        reader.Close()
        reader.Dispose()
        If Not My.Computer.FileSystem.FileExists(templates & "\" & attribs.Item("template") & ".html") Then
            If My.Computer.FileSystem.FileExists(templates & "\default.html") Then
                doLog("WARN: Template " & attribs.Item("template") + ".html does not exist, using template default.html", worker, 40)
                attribs.Item("template") = "default"
            Else
                doLog("WARN: Template " & attribs.Item("template") + ".html does not exist, using basic internal template", worker, 40)
                attribs.Item("template") = "<b>AS</b>internal"
                If Not template_cache.ContainsKey("<b>AS</b>internal") Then
                    template_cache.Add("<b>AS</b>internal", "<!doctype html>" & Environment.NewLine & "<html>" & Environment.NewLine & "  <head>" & Environment.NewLine & "    <title>[#title#]</title>" & Environment.NewLine & "  </head>" & Environment.NewLine & "  <body>" & Environment.NewLine & "    <h1>[#title#]</h1>" & Environment.NewLine & "    <p>" & Environment.NewLine & "    [#content#]" & Environment.NewLine & "    </p>" & "  </body>" & Environment.NewLine & "</html>")
                End If
            End If
        End If
        If Not template_cache.ContainsKey(attribs.Item("template")) Then
            template_cache.Item(attribs.Item("template")) = ReadAllText(Path.Combine(templates, attribs.Item("template") & ".html"))
        End If
        Dim newHtml = template_cache.Item(attribs.Item("template"))
        ' Attribute Process 1 (Content)
        For Each kvp As KeyValuePair(Of String, String) In attribs
            newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
            doLog(" " & kvp.Key & ": " & kvp.Value, worker, 60)
        Next
        ' End Attribute Process 1
        If local Then
            newHtml = newHtml.Replace("[#root#]", ("file:///" & siteRoot.Replace("\", "/") & "/includes/").Replace(" ", "%20"))
            content = content.Replace("[#root#]", ("file:///" & siteRoot.Replace("\", "/") & "/includes/").Replace(" ", "%20"))
        Else
            Dim root = FillString("../", CountCharacter(filename, "\"))
            newHtml = newHtml.Replace("[#root#]", root)
            content = content.Replace("[#root#]", root)
        End If
        If filename.EndsWith(".md") Then
            doLog("Converting Markdown", worker, 70)
            content = CommonMark.CommonMarkConverter.Convert(content)
            filename = ReplaceLast(filename, ".md", ".html")
        End If
        newHtml = newHtml.Replace("[#content#]", content)
        'newHtml = newHtml.Replace("[#root#]", Form1.FillString("../", Form1.CountCharacter(filename, "\")))
        Dim conditionalRegex = "\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]"
        Dim matches = RegularExpressions.Regex.Matches(newHtml, conditionalRegex)
        For Each m As RegularExpressions.Match In matches
            Dim fullStr = m.Groups(0).Value
            Dim key = m.Groups(1).Value
            Dim value = m.Groups(2).Value
            Dim html = m.Groups(3).Value
            Dim equality = (Not key.EndsWith("!")) ' whether the conditional is checking for equality (true) or inequality (false)
            If equality = False Then
                key = ReplaceLast(key, "!", "")
            End If
            Dim pass = False

            If attribs.ContainsKey(key) Then
                If attribs.Item(key) = value Then
                    pass = True
                Else
                    pass = False
                End If
            End If

            If Not equality Then  ' if checking for inequality invert
                pass = Not pass
            End If

            ' separate emptiness checks
            If fullStr.StartsWith("[" & key & "=]") Then ' Check if attribute is empty
                If attribs.ContainsKey(key) Then    ' Attribute exists
                    If attribs.Item(key) = "" Then  ' Attribute exists and is empty
                        pass = True
                    Else
                        pass = False
                    End If
                Else
                    pass = True ' Attribute does not exist, is empty
                End If
            End If
            If fullStr.StartsWith("[" & key & "!=]") Then ' Check if attribute is NOT empty
                If attribs.ContainsKey(key) Then ' Attribute exists
                    If attribs.Item(key) = "" Then ' Attribute defined, and it is empty
                        pass = False
                    Else                           ' Attribute defined, and it is NOT empty
                        pass = True
                    End If
                Else                              ' Attribute does NOT exist
                    pass = False
                End If
            End If

            'doLog(fullStr, worker)
            'doLog(pass, worker)

            If pass Then
                    newHtml = newHtml.Replace(fullStr, html)
            Else
                newHtml = newHtml.Replace(fullStr, "")
            End If
        Next
        ' Attribute Process 2 (Whole Page)
        For Each kvp As KeyValuePair(Of String, String) In attribs
            newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
        Next
        ' End Attribute Process 2
        newHtml = RegularExpressions.Regex.Replace(newHtml, "\[#.*?#\]", "")

        If Not worker Is Nothing Then
            For Each attrib In attribs
                Dim tn As New TNode With {
                    .relPath = inputFilename,
                    .Attribute = attrib.Key,
                    .Value = attrib.Value
                }
                worker.ReportProgress(20, tn)
            Next
        End If

        Dim output As New ApricotOutput With {
            .HTML = newHtml,
            .Attributes = attribs
        }
        Return output
    End Function

    Sub walkInputs(ByVal subdir As IO.DirectoryInfo, ByVal pattern As String, ByVal siteRoot As String, Optional ByVal worker As ComponentModel.BackgroundWorker = Nothing)
        Dim input = Path.Combine(siteRoot, "pages\")
        Dim templates = Path.Combine(siteRoot, "templates\")
        Dim includes = Path.Combine(siteRoot, "includes\")
        Dim out = Path.Combine(siteRoot, "out\")

        warnedExtensions = False

        For Each file In subdir.GetFiles(pattern, SearchOption.AllDirectories)
            Dim modifiedDate = file.LastWriteTime
            Dim rel = ReplaceFirst(file.FullName, input, "")

            While rel.StartsWith("\")
                rel = ReplaceFirst(rel, "\", "")
            End While
            While rel.StartsWith("/")
                rel = ReplaceFirst(rel, "/", "")
            End While
            doLog("Rendering " & rel.Replace("\", "/"), worker, 0)

            Try
                Dim output As ApricotOutput = Compile(ReadAllText(file.FullName), rel, ReplaceLast(templates, "\templates", ""), False, modifiedDate, worker)
                Dim html = output.HTML
                Dim attribs = output.Attributes

                If rel.EndsWith(".md") Then
                    rel = ReplaceLast(rel, ".md", ".html")
                End If

                doLog("Saving file", worker, 100)
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(out & rel))
                My.Computer.FileSystem.WriteAllText(Path.Combine(out, rel), html, False, encodingType)
                Dim info As FileInfo = New FileInfo(Path.Combine(out, rel)) With {
                    .LastWriteTime = modifiedDate
                }
            Catch ex As InvalidCastException
                doLog("Skipped", worker, 100)
            End Try

        Next
        'For Each sdir In subdir.GetDirectories
        'walkInputs(sdir, pattern, siteRoot, worker)
        'Next
    End Sub

    Public Sub buildSite(ByVal folder As String, Optional ByVal worker As Object = Nothing, Optional ByVal removeStrays As Boolean = False)
        template_cache.Clear()

        Dim pages = Path.Combine(folder, "pages\")
        Dim templates = Path.Combine(folder, "templates\")
        Dim includes = Path.Combine(folder, "includes\")
        Dim out = Path.Combine(folder, "out\")

        doLog("Apricot building " & folder, worker, 0)
        Dim startTime As Date = Now()
        doLog("Started " & My.Computer.Clock.LocalTime, worker, 0)

        If Not My.Computer.FileSystem.DirectoryExists(pages) Then
            If My.Computer.FileSystem.DirectoryExists("in\") Then
                doLog("Converting in\ to pages\", worker, 10)
                My.Computer.FileSystem.RenameDirectory("in\", "pages")
            End If
            doLog("Creating pages\ folder", worker, 10)
            My.Computer.FileSystem.CreateDirectory(pages)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(templates) Then
            doLog("Creating templates\ folder", worker, 10)
            My.Computer.FileSystem.CreateDirectory(templates)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(includes) Then
            doLog("Creating includes\ folder", worker, 10)
            My.Computer.FileSystem.CreateDirectory(includes)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(out) Then
            doLog("Creating out\ folder", worker, 10)
            My.Computer.FileSystem.CreateDirectory(out)
        End If

        If (removeStrays) Then
            doLog("Removing stray output files if present")

            Dim keepFiles As New System.Collections.Specialized.StringCollection
            For Each f As String In My.Computer.FileSystem.GetFiles(pages)
                keepFiles.Add(ReplaceLast(f.Replace(pages, out), ".md", ".html"))
            Next
            For Each f As String In My.Computer.FileSystem.GetFiles(includes)
                keepFiles.Add(f.Replace(includes, out))
            Next

            For Each f As String In My.Computer.FileSystem.GetFiles(out)
                If Not keepFiles.Contains(f) Then
                    My.Computer.FileSystem.DeleteFile(f, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                    doLog("- " & f)
                End If
            Next
        End If

        doLog("Syncing includes", worker, 20)

        Dim s As New doSync(includes, out)
        Dim t = s.BeginSynchronization()
        If t = doSync.SyncResults.Unsuccessful Then
            doLog("Copying includes\ folder to out\", worker, 30)
            My.Computer.FileSystem.CopyDirectory(includes, out, True)
        End If

        doLog("Processing input files", worker, 50)
        walkInputs(My.Computer.FileSystem.GetDirectoryInfo(pages), "*.*", folder, worker)

        Dim plugins = Path.Combine(folder, "plugins\")
        If My.Computer.FileSystem.DirectoryExists(plugins) Then
            doLog("Post-run scripts are enabled", worker, 80)
            For Each plugin As String In My.Computer.FileSystem.GetFiles(plugins)
                doLog("Running script " & plugin.Substring(plugins.Length), worker, 80)
            Next
        End If
        'TODO: implement

        doLog("Finished in " & Math.Round(Now.Subtract(startTime).TotalSeconds, 3) & " seconds.", worker, 100)
    End Sub

End Module
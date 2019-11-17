Imports System.IO
Imports System.Text

Public Module Apricot
    Public template_cache As New Dictionary(Of String, String)()
    Public encodingType As Encoding = New UTF8Encoding(False)

    'https://stackoverflow.com/a/3448307
    Public Function ReadAllText(ByVal path As String)
        Dim text = ""
        Dim inStream = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim streamReader = New StreamReader(inStream)
        text = streamReader.ReadToEnd()
        streamReader.Dispose()
        inStream.Dispose()
        Return text
    End Function

    'https://bytes.com/topic/visual-basic-net/answers/370586-replace-first-occurrance-substring#post1428786
    Public Function ReplaceFirst(ByVal expression As String, ByVal find As String, ByVal replacement As String) As String
        Dim index As Integer = expression.IndexOf(find)
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

    Private Sub doLog(ByVal msg As String, Optional ByVal worker As System.ComponentModel.BackgroundWorker = Nothing, Optional ByVal progress As Integer = 0)
        Console.WriteLine(msg)
        If Not worker Is Nothing Then
            worker.ReportProgress(progress, msg)
        End If
    End Sub

    Public Function Compile(ByVal pageHtml As String, ByVal filename As String, ByVal siteRoot As String, ByVal local As Boolean, Optional ByVal worker As System.ComponentModel.BackgroundWorker = Nothing)
        Dim log As String = ""
        Dim templates = Path.Combine(siteRoot, "templates\")
        Dim content = ""
        Dim attribs As New Dictionary(Of String, String)()
        attribs.Add("template", "default")
        attribs.Add("path", filename.Replace("\", "/"))
        Dim reader As New StringReader(pageHtml)
        Dim line As String
        doLog("Reading attributes", worker, 40)
        Do
            line = reader.ReadLine
            Dim regex As RegularExpressions.Regex = New RegularExpressions.Regex("^<!-- attrib (.*): (.*) -->")
            If Not line Is Nothing Then
                Dim match As RegularExpressions.Match = regex.Match(line)
                If match.Success Then
                    attribs.Item(match.Groups(1).Value) = match.Groups(2).Value
                Else
                    content = content & vbNewLine & line
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
                    template_cache.Add("<b>AS</b>internal", "<!doctype html>" & vbNewLine & "<html>" & vbNewLine & "  <head>" & vbNewLine & "    <title>[#title#]</title>" & vbNewLine & "  </head>" & vbNewLine & "  <body>" & vbNewLine & "    <h1>[#title#]</h1>" & vbNewLine & "    <p>" & vbNewLine & "      [path=index.md]You are on the index.[/path=]" & vbNewLine & "    </p>" & vbNewLine & "    [#content#]" & vbNewLine & "  </body>" & vbNewLine & "</html>")
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
        Next
        ' End Attribute Process 1
        If filename.EndsWith(".md") Then
            content = CommonMark.CommonMarkConverter.Convert(content)
            filename = ReplaceLast(filename, ".md", ".html")
        End If
        newHtml = newHtml.Replace("[#content#]", content)
        'newHtml = newHtml.Replace("[#root#]", Form1.FillString("../", Form1.CountCharacter(filename, "\")))
        If local Then
            newHtml = newHtml.Replace("[#root#]", siteRoot & "\includes\")
        Else
            newHtml = newHtml.Replace("[#root#]", FillString("../", CountCharacter(filename, "\")))
        End If
        Dim conditionalRegex = "\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]"
        Dim matches = RegularExpressions.Regex.Matches(newHtml, conditionalRegex)
        For Each m As RegularExpressions.Match In matches
            Dim fullStr = m.Groups(0).Value
            Dim key = m.Groups(1).Value
            Dim value = m.Groups(2).Value
            Dim html = m.Groups(3).Value
            Dim equality = (Not key.EndsWith("!"))
            If equality = False Then
                key = ReplaceLast(key, "!", "")
            End If
            Dim pass = False
            If attribs.ContainsKey(key) Then
                If attribs.Item(key) = value Then
                    pass = True
                End If
            End If

            ' check emptiness
            If fullStr.StartsWith("[" & key & "=]") Then
                If attribs.ContainsKey(key) Then
                    If attribs.Item(key) = "" Then
                        pass = True
                    End If
                Else
                    pass = True
                End If
            End If
            If fullStr.StartsWith("[" & key & "!=]") Then
                If attribs.ContainsKey(key) Then
                    If attribs.Item(key) = "" Then
                        pass = True
                    End If
                Else
                    pass = True
                End If
            End If

            If pass Then
                If equality = True Then
                    newHtml = newHtml.Replace(fullStr, html)
                Else
                    newHtml = newHtml.Replace(fullStr, "")
                End If
            Else
                If equality = True Then
                    newHtml = newHtml.Replace(fullStr, "")
                Else
                    newHtml = newHtml.Replace(fullStr, html)
                End If
            End If
        Next
        ' Attribute Process 2 (Whole Page)
        For Each kvp As KeyValuePair(Of String, String) In attribs
            newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
        Next
        ' End Attribute Process 2
        newHtml = RegularExpressions.Regex.Replace(newHtml, "\[#.*?#\]", "")

        If filename.EndsWith(".md") Then
            filename = ReplaceLast(filename, ".md", ".html")
        End If

        Dim output As New ApricotOutput
        output.HTML = newHtml
        output.Attributes = attribs
        Return output
    End Function

    ' These are used for Core (synchronous workloads)
    Sub walkInputs(ByVal directory As IO.DirectoryInfo, ByVal pattern As String, ByVal input As String, ByVal templates As String, ByVal out As String)
        For Each file In directory.GetFiles(pattern)
            Dim rel = ReplaceFirst(file.FullName, input, "")
            Console.WriteLine("Rendering " & rel.Replace("\", "/"))

            Dim output = Compile(ReadAllText(file.FullName), file.Name, ReplaceLast(templates, "\templates", ""), False)
            Dim html = output.HTML
            Dim attribs = output.Attributes

            Console.Write(output.Log)

            Console.WriteLine("  Saving file")
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(out & rel))
            My.Computer.FileSystem.WriteAllText(out & rel, html, False, encodingType)
        Next
        For Each subDir In directory.GetDirectories
            walkInputs(subDir, pattern, input, templates, out)
        Next
    End Sub
    Public Sub buildSite(ByVal folder As String)
        Dim input = Path.Combine(folder, "in\")
        Dim templates = Path.Combine(folder, "templates\")
        Dim includes = Path.Combine(folder, "includes\")
        Dim out = Path.Combine(folder, "out\")

        Console.WriteLine("Apricot building " & folder)

        If Not My.Computer.FileSystem.DirectoryExists(input) Then
            Console.WriteLine("Creating in\ folder")
            My.Computer.FileSystem.CreateDirectory(input)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(templates) Then
            Console.WriteLine("Creating templates\ folder")
            My.Computer.FileSystem.CreateDirectory(templates)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(includes) Then
            Console.WriteLine("Creating includes\ folder")
            My.Computer.FileSystem.CreateDirectory(includes)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(out) Then
            Console.WriteLine("Creating out\ folder")
            My.Computer.FileSystem.CreateDirectory(out)
        End If

        Console.WriteLine("Syncing includes")

        Dim s As New doSync(includes, out)
        Dim t = s.BeginSynchronization()
        If t = doSync.SyncResults.Unsuccessful Then
            Console.WriteLine("  Copying includes\ folder to out\")
            My.Computer.FileSystem.CopyDirectory(includes, out, True)
        End If

        Console.WriteLine("Processing input files")
        walkInputs(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*", input, templates, out)

        Console.WriteLine("Finished!")
    End Sub
End Module

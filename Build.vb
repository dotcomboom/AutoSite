Imports System.IO
Imports System.Text

Public Class Build

    Public bld = Form1.SiteTree.Nodes(0).Text

    Public input = Path.Combine(bld, "in\")
    Public templates = Path.Combine(bld, "templates\")
    Public includes = Path.Combine(bld, "includes\")
    Public out = Path.Combine(bld, "out\")

    Public template_cache As New Dictionary(Of String, String)()

    Private Sub aLog(ByVal text As String)
        Log.AppendText(vbNewLine & text)
    End Sub

    'https://bytes.com/topic/visual-basic-net/answers/370586-replace-first-occurrance-substring#post1428786
    Public Shared Function ReplaceFirst(ByVal expression As String, ByVal find As String, ByVal replacement As String) As String
        Dim index As Integer = expression.IndexOf(find)
        Return expression.Remove(index, find.Length).Insert(index, replacement)
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
    Public Shared Function FillString(ByVal ch As String, ByVal count As Integer) As String
        Dim sb As StringBuilder = New StringBuilder(count)

        For ix As Integer = 0 To count - 1
            sb.Append(ch)
        Next

        Return sb.ToString()
    End Function

    Sub walkInputs(ByVal directory As IO.DirectoryInfo, ByVal pattern As String)
        For Each file In directory.GetFiles(pattern)
            BackgroundWorker1.ReportProgress(0, "Rendering " & file.FullName)
            Dim rel = ReplaceFirst(file.FullName, input, "")
            'Dim contents = My.Computer.FileSystem.ReadAllText(file.FullName)
            Dim content = ""
            Dim attribs As New Dictionary(Of String, String)()
            attribs.Add("template", "default")
            Dim reader As New StreamReader(file.FullName, Encoding.Default)
            Dim line As String
            BackgroundWorker1.ReportProgress(20, "Reading attributes")
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
            If Not template_cache.ContainsKey(attribs.Item("template")) Then
                BackgroundWorker1.ReportProgress(30, "Loading template " & attribs.Item("template"))
                template_cache.Item(attribs.Item("template")) = My.Computer.FileSystem.ReadAllText(Path.Combine(templates, attribs.Item("template") & ".html"))
            End If
            Dim newHtml = template_cache.Item(attribs.Item("template"))
            BackgroundWorker1.ReportProgress(50, "Slotting into template " & attribs.Item("template"))
            newHtml = newHtml.Replace("[#content#]", content)
            'MsgBox(rel)
            newHtml = newHtml.Replace("[#root#]", FillString("../", CountCharacter(rel, "\")))
            For Each kvp As KeyValuePair(Of String, String) In attribs
                BackgroundWorker1.ReportProgress(20, "  " & kvp.Key & ": " & kvp.Value)
                newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
            Next
            BackgroundWorker1.ReportProgress(90, "Saving file")
            My.Computer.FileSystem.WriteAllText(out & rel, newHtml, False)
            BackgroundWorker1.ReportProgress(100, "Done with file")
        Next
        For Each subDir In directory.GetDirectories
            walkInputs(subDir, pattern)
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.ReportProgress(0, "Starting!")
        BackgroundWorker1.ReportProgress(0, bld)

        If Not My.Computer.FileSystem.DirectoryExists(input) Then
            BackgroundWorker1.ReportProgress(10, "Creating in/ folder")
            My.Computer.FileSystem.CreateDirectory(input)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(templates) Then
            BackgroundWorker1.ReportProgress(10, "Creating templates/ folder")
            My.Computer.FileSystem.CreateDirectory(templates)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(includes) Then
            BackgroundWorker1.ReportProgress(10, "Creating includes/ folder")
            My.Computer.FileSystem.CreateDirectory(includes)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(out) Then
            BackgroundWorker1.ReportProgress(10, "Creating out/ folder")
            My.Computer.FileSystem.CreateDirectory(out)
        End If

        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*")
        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(templates), "*.*")
        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(includes), "*.*")
        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(out), "*.*")

        BackgroundWorker1.ReportProgress(20, "Syncing includes")

        My.Computer.FileSystem.CopyDirectory(includes, out, True)

        BackgroundWorker1.ReportProgress(25, "Rendering input files")
        walkInputs(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*")

        BackgroundWorker1.ReportProgress(100, "Finished!")
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Progress.Value = e.ProgressPercentage
        Status.Text = e.UserState
        aLog(e.UserState)
        Status.Refresh()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Close()
    End Sub

    Private Sub Build_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class
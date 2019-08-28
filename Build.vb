Imports System.IO
Imports System.Text

Public Class Build

    Public bld = Form1.SiteTree.Nodes(0).Text

    Public input = Path.Combine(bld, "in\")
    Public templates = Path.Combine(bld, "templates\")
    Public includes = Path.Combine(bld, "includes\")
    Public out = Path.Combine(bld, "out\")

    Private Sub aLog(ByVal text As String)
        Log.AppendText(vbNewLine & text)
    End Sub

    Sub walkInputs(ByVal directory As IO.DirectoryInfo, ByVal pattern As String)
        For Each file In directory.GetFiles(pattern)
            BackgroundWorker1.ReportProgress(20, "Rendering " & file.FullName)
            'Dim contents = My.Computer.FileSystem.ReadAllText(file.FullName)
            Dim attribs As New Dictionary(Of String, String)()
            attribs.Add("template", "default")
            Dim reader As New StreamReader(file.FullName, Encoding.Default)
            Dim line As String
            Do
                line = reader.ReadLine
                Dim regex As RegularExpressions.Regex = New RegularExpressions.Regex("<!-- attrib (.*): (.*) -->")
                If Not line Is Nothing Then
                    Dim match As RegularExpressions.Match = regex.Match(line)
                    If match.Success Then
                        attribs.Item(match.Groups(1).Value) = match.Groups(2).Value
                    End If
                End If
            Loop Until line Is Nothing
            For Each kvp As KeyValuePair(Of String, String) In attribs
                BackgroundWorker1.ReportProgress(20, kvp.Key & ": " & kvp.Value)
            Next
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
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Progress.Value = e.ProgressPercentage
        Status.Text = e.UserState
        aLog(e.UserState)
        Status.Refresh()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Me.BackColor = Color.Aqua
    End Sub

    Private Sub Build_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class
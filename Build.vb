Imports System.IO

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
            aLog(file.FullName)
        Next
        For Each subDir In directory.GetDirectories
            walkInputs(subDir, pattern)
        Next
    End Sub

    Sub walkLog(ByVal directory As IO.DirectoryInfo, ByVal pattern As String)
        For Each file In directory.GetFiles(pattern)
            aLog(file.FullName)
        Next
        For Each subDir In directory.GetDirectories
            walkLog(subDir, pattern)
        Next
    End Sub

    Private Sub Build_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        aLog("Starting!")
        aLog(bld)

        If Not My.Computer.FileSystem.DirectoryExists(input) Then
            aLog("Creating in\ folder")
            My.Computer.FileSystem.CreateDirectory(input)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(templates) Then
            aLog("Creating templates\ folder")
            My.Computer.FileSystem.CreateDirectory(templates)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(includes) Then
            aLog("Creating includes\ folder")
            My.Computer.FileSystem.CreateDirectory(includes)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(out) Then
            aLog("Creating out\ folder")
            My.Computer.FileSystem.CreateDirectory(out)
        End If

        walkLog(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*")
        walkLog(My.Computer.FileSystem.GetDirectoryInfo(templates), "*.*")
        walkLog(My.Computer.FileSystem.GetDirectoryInfo(includes), "*.*")
        walkLog(My.Computer.FileSystem.GetDirectoryInfo(out), "*.*")

        aLog("Syncing includes folder to out folder")

        My.Computer.FileSystem.CopyDirectory(includes, out, True)

        aLog("Done!")

        aLog("Rendering input files...")
    End Sub
End Class
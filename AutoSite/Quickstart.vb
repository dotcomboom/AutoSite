Public Class Quickstart
    Public usite As String = Main.SiteTree.Nodes(0).Tag

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddConditional_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://tesserae.somnolescent.net")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://commonmark.org/help/")
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build.Click
        Main.doBuild()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SanitaryBuild.Click
        Main.doSanitaryBuild()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim path = usite & "\includes\" & relpath.Text.Replace("/", "\")
        If Not path.EndsWith("\") Then
            path &= "\"
        End If
        If Not My.Computer.FileSystem.DirectoryExists(path) Then
            Try
                My.Computer.FileSystem.CreateDirectory(path)
            Catch ex As Exception
                MsgBox("AutoSite was not able to create the given subdirectory for some reason." & Environment.NewLine & Environment.NewLine & ex.ToString, MsgBoxStyle.Critical, "Unable to copy files")
                Exit Sub
            End Try
        End If
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        If My.Computer.FileSystem.DirectoryExists(dir) Then
            Main.AddFilesDialog.Title = "Add Files to " & dir
            If Main.AddFilesDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                For Each file In Main.AddFilesDialog.FileNames
                    Try
                        My.Computer.FileSystem.CopyFile(file, System.IO.Path.Combine(dir, System.IO.Path.GetFileName(file)))
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next
                'refreshTree(siteTree.Nodes(0))
            End If
        End If

    End Sub

    Private Sub Quickstart_Load() Handles MyBase.Load
        If My.Computer.Info.OSPlatform = "Win32Windows" Then   ' Detect non-NT Windows (98)
            Main.refreshTree(Main.SiteTree.Nodes(0))
        End If

        If My.Computer.FileSystem.FileExists(usite & "\templates\default.html") Then
            CreateTemplate.Text = "Created"
            CreateTemplate.Enabled = False
        Else
            CreateTemplate.Enabled = True
        End If
        indexmd.Enabled = Not (My.Computer.FileSystem.FileExists(usite & "\pages\index.md"))
        indexhtml.Enabled = Not (My.Computer.FileSystem.FileExists(usite & "\pages\index.html"))
        If Not (indexmd.Enabled And indexhtml.Enabled) Then
            Label4.Text = "As the index page has already been created, you can change formats here."
        End If

        If Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled Then
            Me.BackColor = SystemColors.Control
        End If

        Me.Font = Main.getFont()
    End Sub

    Private Sub CreateTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTemplate.Click
        My.Computer.FileSystem.WriteAllText(usite & "\templates\default.html", "<!DOCTYPE html>" & Environment.NewLine & "<html>" & Environment.NewLine & "  <head>" & Environment.NewLine & "    <title>[#title#]</title>" & Environment.NewLine & "  </head>" & Environment.NewLine & "  <body>" & Environment.NewLine & "    <h1>[#title#]</h1>" & Environment.NewLine & "    [#content#]" & Environment.NewLine & "  </body>" & Environment.NewLine & "</html>", False)
        Quickstart_Load()
        Main.openEditor(usite & "\templates\default.html")
    End Sub

    Private Sub indexmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indexmd.Click
        If (Not My.Computer.FileSystem.FileExists(usite & "\pages\index.md")) And (Not My.Computer.FileSystem.FileExists(usite & "\pages\index.html")) Then
            Dim page = "<!-- attrib template: default -->" & Environment.NewLine & "<!-- attrib title: Home -->" & Environment.NewLine
            My.Computer.FileSystem.WriteAllText(usite & "\pages\index.md", page, False)
            Quickstart_Load()
        ElseIf My.Computer.FileSystem.FileExists(usite & "\pages\index.html") Then
            If MsgBox("index.html will be renamed to index.md. The path will be changed.", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Switch to Markdown?") = MsgBoxResult.Ok Then
                My.Computer.FileSystem.RenameFile(usite & "\pages\index.html", "index.md")
                Quickstart_Load()
            End If
        End If
    End Sub

    Private Sub indexhtml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indexhtml.Click
        If (Not My.Computer.FileSystem.FileExists(usite & "\pages\index.md")) And (Not My.Computer.FileSystem.FileExists(usite & "\pages\index.html")) Then
            Dim page = "<!-- attrib template: default -->" & Environment.NewLine & "<!-- attrib title: Home -->" & Environment.NewLine
            My.Computer.FileSystem.WriteAllText(usite & "\pages\index.html", page, False)
            Quickstart_Load()
        ElseIf My.Computer.FileSystem.FileExists(usite & "\pages\index.md") Then
            If MsgBox("index.md will be renamed to index.html. The path will be changed.", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Switch to HTML?") = MsgBoxResult.Ok Then
                My.Computer.FileSystem.RenameFile(usite & "\pages\index.md", "index.html")
                Quickstart_Load()
            End If
        End If
    End Sub

End Class
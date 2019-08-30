Imports System.IO

Public Class Editor

    Public openFile As String
    Public siteRoot As String
    Public Snapshot As String

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click, MenuItem1.Click
        Code.Undo()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, MenuItem2.Click
        Code.Redo()
    End Sub

    Private Sub Code_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Code.Load
        Code.WordWrap = My.Settings.WordWrap
        Code.VirtualSpace = My.Settings.VirtualSpace
        Code.WideCaret = My.Settings.WideCaret
    End Sub

    Private Sub Code_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Code.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenu1.Show(Code, e.Location)
        End If
    End Sub

    Public Sub Save() Handles ToolStripButton3.Click
        If Not openFile Is Nothing Then
            Code.SaveToFile(openFile, System.Text.Encoding.Unicode)
            Snapshot = Code.Text
            Me.Parent.Text = openFile.Replace(siteRoot & "\", "")
        End If
    End Sub

    Private Sub Editor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code.TextChanged
        If (Not Code.Text = snapshot) And (Not openFile Is Nothing) Then
            Me.Parent.Text = openFile.Replace(siteRoot & "\", "") & "*"
        End If
    End Sub

    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Code.KeyDown
        If e.Control And e.KeyCode = Keys.W Then
            If Not Code.Text = Snapshot Then
                Dim d As DialogResult = MsgBox("Save changes to " & openFile.Replace(siteRoot & "\", "") & "?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "AutoSite XL")

                If d = DialogResult.Yes Then
                    Save()
                End If
                If d = DialogResult.Cancel Then
                    Exit Sub
                End If
            End If
            Form1.openFiles.Remove(openFile)
            Me.Parent.Dispose()
        ElseIf e.Control And e.KeyCode = Keys.S Then
            Save()
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Code.Cut()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Code.Copy()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Code.Paste()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click

    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Code.SelectAll()
    End Sub
End Class

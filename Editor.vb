Public Class Editor

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click, MenuItem1.Click
        Code.Undo()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, MenuItem2.Click
        Code.Redo()
    End Sub

    Private Sub Code_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Code.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenu1.Show(Code, e.Location)
        End If
    End Sub
End Class

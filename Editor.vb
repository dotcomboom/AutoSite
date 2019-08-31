Imports System.IO
Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS

Public Class Editor

    Public openFile As String
    Public siteRoot As String
    Public Snapshot As String

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoBtn.Click, Undo.Click
        Code.Undo()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoBtn.Click, Redo.Click
        Code.Redo()
    End Sub

    Private Sub Code_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Code.Load
        Code.WordWrap = My.Settings.WordWrap
        Code.VirtualSpace = My.Settings.VirtualSpace
        Code.WideCaret = My.Settings.WideCaret
    End Sub

    Private Sub Code_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Code.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Cut.Enabled = Code.SelectionLength > 0
            Copy.Enabled = Code.SelectionLength > 0
            Paste.Enabled = My.Computer.Clipboard.ContainsText
            Context.Show(Code, e.Location)
        End If
    End Sub

    Private Sub Editor_TextChanged(ByVal sender As System.Object, ByVal e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Code.TextChanged
        If (Not Code.Text = Snapshot) And (Not openFile Is Nothing) Then
            Me.Parent.Text = openFile.Replace(siteRoot & "\", "") & "*"
            SaveBtn.Enabled = True
        End If
        If My.Settings.SyntaxHighlight Then
            Dim GreenStyle As New TextStyle(Brushes.Green, Nothing, FontStyle.Regular)
            Dim TurqStyle As New TextStyle(Brushes.Turquoise, Nothing, FontStyle.Regular)
            'clear style of changed range
            'Code.Range.ClearStyle(TurqStyle)
            'Code.Range.ClearStyle(GreenStyle)
            'comment highlighting
            Code.Range.SetStyle(TurqStyle, "\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]", RegexOptions.Singleline)
            Code.Range.SetStyle(GreenStyle, "\[#.*?#\]", RegexOptions.Singleline)
            'for atteql, value, text in re.findall(r'\[(.*)=(.*?)\](.*)\[\/\1.*\]', template):
        End If
        If My.Settings.LivePreview Then
            If Me.Parent.Text.EndsWith(".md") Then
                Form1.Preview.DocumentText = CommonMark.CommonMarkConverter.Convert(Code.Text)
            Else
                Form1.Preview.DocumentText = Code.Text
            End If
        End If
    End Sub

    Public Sub Save() Handles SaveBtn.ButtonClick, SaveToolStripMenuItem.Click
        If Not openFile Is Nothing Then
            Code.SaveToFile(openFile, System.Text.Encoding.Unicode)
            Snapshot = Code.Text
            Me.Parent.Text = openFile.Replace(siteRoot & "\", "")
            SaveBtn.Enabled = False
        End If
    End Sub

    Public Sub Close() Handles CloseBtn.Click
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
    End Sub

    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Code.KeyDown
        If e.Control And e.KeyCode = Keys.W Then
            Close()
        ElseIf e.Control And e.KeyCode = Keys.S Then
            Save()
        End If
    End Sub

    Private Sub Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cut.Click
        Code.Cut()
    End Sub

    Private Sub Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy.Click
        Code.Copy()
    End Sub

    Private Sub Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste.Click
        Code.Paste()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click

    End Sub

    Private Sub SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAll.Click
        Code.SelectAll()
    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAllToolStripMenuItem.Click
        Form1.DoSaveAll()
    End Sub

    Private Sub Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find.Click
        Code.ShowFindDialog()
    End Sub

    Private Sub GTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GTo.Click
        Code.ShowGoToDialog()
    End Sub

    Private Sub Replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Replace.Click
        Code.ShowReplaceDialog()
    End Sub

    Private Sub Preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Preview.ButtonClick
        If Me.Parent.Text.EndsWith(".md") Then
            Form1.Preview.DocumentText = CommonMark.CommonMarkConverter.Convert(Code.Text)
        Else
            Form1.Preview.DocumentText = Code.Text
        End If
    End Sub

    Private Sub Preview_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Preview.DropDownOpening
        LivePreview.Checked = My.Settings.LivePreview
    End Sub

    Private Sub LivePreview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivePreview.CheckedChanged
        My.Settings.LivePreview = LivePreview.Checked
        Form1.LivePreview.Checked = My.Settings.LivePreview
        Form1.panelUpdate()
    End Sub
End Class

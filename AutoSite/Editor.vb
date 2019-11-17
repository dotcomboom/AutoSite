Imports System.IO
Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS
Imports System.Text

Public Class Editor

    Public template_cache As New ArrayList

    Public openFile As String
    Public siteRoot As String
    Public Snapshot As String

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

    Sub WriteAllText(ByVal path As String)
        Try
            Code.SaveToFile(path, Main.encodingType)
        Catch
            Try
                Dim unlocker = New FileStream(path, FileMode.Open)
                unlocker.Unlock(1, unlocker.Length)
                unlocker.Close()
                Code.SaveToFile(path, Main.encodingType)
            Catch ex As Exception
                MsgBox("The file could not be saved.", MsgBoxStyle.Critical, "AutoSite XL")
            End Try
        End Try
    End Sub

    Public Sub doUndo() Handles UndoBtn.Click, Undo.Click
        Code.Undo()
    End Sub

    Public Sub doRedo() Handles RedoBtn.Click, Redo.Click
        Code.Redo()
    End Sub

    Private Sub Code_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Code.Load
        Code.WordWrap = My.Settings.WordWrap
        Code.VirtualSpace = My.Settings.VirtualSpace
        Code.WideCaret = My.Settings.WideCaret
        Code.Font = My.Settings.editorFont
        If Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled Then
            Me.BackColor = SystemColors.Control
            Strip.BackColor = SystemColors.Control
        End If
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
        Try
            If My.Settings.LivePreview Then
                If Me.Parent.Text.Replace("*", "").EndsWith(".md") Then
                    Main.Preview.DocumentText = CommonMark.CommonMarkConverter.Convert(Code.Text)
                Else
                    Main.Preview.DocumentText = Code.Text
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Save() Handles SaveBtn.ButtonClick, SaveToolStripMenuItem.Click
        If Not openFile Is Nothing Then
            WriteAllText(openFile)
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
        Main.openFiles.Remove(openFile)
        Me.Parent.Dispose()
    End Sub

    Public Sub doCut() Handles Cut.Click, CutBtn.Click
        Code.Cut()
    End Sub

    Public Sub doCopy() Handles Copy.Click, CopyBtn.Click
        Code.Copy()
    End Sub

    Public Sub doPaste() Handles Paste.Click, PasteBtn.Click
        Code.Paste()
    End Sub

    Public Sub doSelectAll() Handles SelectAll.Click
        Code.SelectAll()
    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAllToolStripMenuItem.Click
        Main.DoSaveAll()
    End Sub

    Public Sub doFind() Handles Find.Click
        Code.ShowFindDialog()
    End Sub

    Public Sub doGoto() Handles GTo.Click
        Code.ShowGoToDialog()
    End Sub

    Public Sub doReplace() Handles Replace.Click
        Code.ShowReplaceDialog()
    End Sub

    Public Sub doPreview() Handles Preview.ButtonClick
        Dim rel = openFile.Replace(siteRoot & "\in\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If Not Me.Parent.Text.StartsWith("in\") Then
            Main.Preview.Navigate(Path.Combine(Main.SiteTree.Nodes(0).Text, "out\"))
            Main.Preview.DocumentText = Code.Text
        Else
            template_cache.Clear()
            Main.Preview.Navigate(siteRoot & "out\" & rel)
            Main.Preview.DocumentText = Apricot.Compile(Code.Text, rel, siteRoot, True, Nothing).HTML
        End If
    End Sub

    Private Sub Preview_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Preview.DropDownOpening
        LivePreview.Checked = My.Settings.LivePreview
    End Sub

    Private Sub LivePreview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivePreview.CheckedChanged
        My.Settings.LivePreview = LivePreview.Checked
        Main.LivePreview.Checked = My.Settings.LivePreview
        Main.panelUpdate()
    End Sub

    ' https://www.codeproject.com/articles/8995/introduction-to-treeview-drag-and-drop-vb-net
    Public Sub Code_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Code.DragEnter
        e.Effect = DragDropEffects.Link
    End Sub

    Private Sub Code_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Code.DragOver
        e.Effect = DragDropEffects.Link
    End Sub

    Public Sub doInsertConditional() Handles InsertConditional.Click
        Dim conditionals = New AddConditional
        If conditionals.ShowDialog() = DialogResult.OK Then
            Code.InsertText(conditionals.output)
        End If
    End Sub

    Public Sub doViewOutput() Handles ViewOutput.Click
        Dim rel = openFile.Replace(siteRoot & "\in\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")
        If rel.EndsWith(".md") Then
            rel = Apricot.ReplaceLast(rel, ".md", ".html")
        End If
        Main.Preview.Navigate(siteRoot & "\out\" & rel)
    End Sub

    Private Sub Build_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build.Click
        Main.doBuild()
    End Sub
End Class

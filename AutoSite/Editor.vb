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
        Dim inStream = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim streamReader = New StreamReader(inStream)
        Dim text As String = streamReader.ReadToEnd()
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
                MsgBox(My.Resources.Error_CouldNotSaveFile, MsgBoxStyle.Critical)
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
        'If My.Settings.SyntaxHighlight Then
        '    Dim GreenStyle As New TextStyle(Brushes.Green, Nothing, FontStyle.Regular)
        '    Dim TurqStyle As New TextStyle(Brushes.Turquoise, Nothing, FontStyle.Regular)
        '    'clear style of changed range
        '    'Code.Range.ClearStyle(TurqStyle)
        '    'Code.Range.ClearStyle(GreenStyle)
        '    'comment highlighting
        '    Code.Range.SetStyle(TurqStyle, "\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]", RegexOptions.Singleline)
        '    Code.Range.SetStyle(GreenStyle, "\[#.*?#\]", RegexOptions.Singleline)
        '    'for atteql, value, text in re.findall(r'\[(.*)=(.*?)\](.*)\[\/\1.*\]', template):
        'End If
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
            Dim refreshTree = False
            If My.Computer.Info.OSPlatform = "Win32Windows" Then   ' Detect non-NT Windows (98)
                If Not My.Computer.FileSystem.FileExists(openFile) Then
                    refreshTree = True
                End If
            End If
            WriteAllText(openFile)
            If refreshTree Then
                Main.refreshTree(Main.SiteTree.Nodes(0))
            End If
            Snapshot = Code.Text
            Me.Parent.Text = openFile.Replace(siteRoot & "\", "")
            SaveBtn.Enabled = False
        End If
    End Sub

    Public Sub Close() Handles CloseBtn.Click
        If Not Code.Text = Snapshot Then
            Dim d As DialogResult = MsgBox(String.Format(My.Resources.Prompt_SaveChangesToFile, openFile.Replace(siteRoot & "\", "")), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel)
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
        Dim rel = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If Not Main.PreviewPanel.Checked Then
            Main.PreviewPanel.Checked = True
            Main.panelUpdate()
        End If

        If Not Me.Parent.Text.StartsWith("pages\") Then
            Main.Preview.Navigate(Path.Combine(Main.SiteTree.Nodes(0).Text, "out\"))
            Main.Preview.DocumentText = Code.Text
        Else
            Main.Preview.Navigate(siteRoot & "out\" & rel)
            Preview.Enabled = False
            ViewOutput.Enabled = False
            template_cache.Clear()
            PreviewWorker.RunWorkerAsync({Code.Text, rel})
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

    Public Sub doViewOutput() Handles ViewOutput.ButtonClick
        Dim url As String = siteRoot & "\out\" & _rel()
        If Not My.Computer.FileSystem.FileExists(url) Then
            If Build.Enabled Then
                Main.afterBuildNavigatePreview = url
                Main.doBuild()
            End If
            Exit Sub
        End If

        Main.Preview_Navigate(url)

    End Sub

    Private Sub ViewinDefaultBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewinDefaultBrowser.Click
        Dim url As String = siteRoot & "\out\" & _rel()
        Try
            Process.Start(url)
        Catch ex As Exception
            If Build.Enabled Then
                Main.afterBuildLaunch = url
                Main.doBuild()
            End If
        End Try
    End Sub

    Private Sub Build_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build.Click
        Main.doBuild()
    End Sub

    Private Sub Autocomplete_Selecting(ByVal sender As System.Object, ByVal e As AutocompleteMenuNS.SelectingEventArgs) Handles Autocomplete.Selecting
        If Autocomplete.Items.Length = 1 Then  ' AutoCompleteMenu automatically selects the one option instead of displaying the menu
            e.Cancel = True                    ' Fine in other cases but doesn't work so great here, unfortunately
            Exit Sub
        End If
        If e.Item.ImageIndex = 3 Then      ' Build option
            e.Cancel = True
            Autocomplete.Close()
            Main.doBuild()
        ElseIf e.Item.ImageIndex = 1 Or e.Item.ImageIndex = 5 Then  ' Define attribute
            e.Cancel = True

            If Code.GetLineText(Code.LineNumberStartValue - 1) = "" Then
                Code.InsertText(e.Item.Text)
            Else
                Code.Selection.Start = New Place(0, 0)
                Code.Selection.End = New Place(0, 0)
                Code.ProcessKey(Keys.End)
                Code.InsertText(Environment.NewLine & e.Item.Text)
                If e.Item.Text.Contains("...") Then
                    Code.Selection.Start = New Place(e.Item.Text.IndexOf("..."), Code.Selection.FromLine)
                    Code.Selection.End = New Place(e.Item.Text.IndexOf("...") + 3, Code.Selection.FromLine)
                End If
            End If
            Autocomplete.Close()
        ElseIf e.Item.ImageIndex = 4 Then  ' Insert conditional
            e.Cancel = True
            Autocomplete.Close()
            doInsertConditional()
        End If
    End Sub

    Private Sub prepMenu()
        Dim items As New List(Of AutocompleteMenuNS.AutocompleteItem)

        Dim internal As New List(Of String)
        internal.Add("root")
        internal.Add("path")
        internal.Add("modified")
        internal.Add("template")

        If (Not Me.Parent.Text.StartsWith("includes\")) And Not Code.GetLineText(Code.Selection.FromLine).StartsWith("<!-- attrib") Then
            ' Internal
            If Me.Parent.Text.StartsWith("templates\") And Not Code.Text.Contains("[#content#]") Then
                items.Add(New AutocompleteMenuNS.AutocompleteItem("[#content#]", 2, "content", My.Resources.QuickInsert_content_Tip, My.Resources.QuickInsert_content_TipText))
            End If
            items.Add(New AutocompleteMenuNS.AutocompleteItem("[#root#]", 2, "root", My.Resources.QuickInsert_root_Tip, My.Resources.QuickInsert_root_TipText & Environment.NewLine & Environment.NewLine & rootCalc()))
            items.Add(New AutocompleteMenuNS.AutocompleteItem("[#modified#]", 2, "modified", My.Resources.QuickInsert_modified_Tip, My.Resources.QuickInsert_modified_TipText & Environment.NewLine & Environment.NewLine & String.Format(My.Resources.QuickInsert__Example, Date.Now.ToString.Split(" ")(0))))
            items.Add(New AutocompleteMenuNS.AutocompleteItem("[#path#]", 2, "path", My.Resources.QuickInsert_path_Tip, My.Resources.QuickInsert_path_TipText & Environment.NewLine & Environment.NewLine & pathCalc()))
            For Each Attribute As TreeNode In Main.AttributeTree.Nodes
                If Not internal.Contains(Attribute.Text) Then
                    If Code.Text.Contains("<!-- attrib " & Attribute.Text & ":") Or Me.Parent.Text.StartsWith("templates\") Then
                        items.Add(New AutocompleteMenuNS.AutocompleteItem("[#" & Attribute.Text & "#]", 0, Attribute.Text, Attribute.Text, String.Format(My.Resources.QuickInsert_Generic_TipText, Attribute.Text)))
                    End If
                End If
            Next
        End If

        ' Internal define option
        If Me.Parent.Text.StartsWith("pages\") Then
            If Not Code.Text.Contains("<!-- attrib template:") Then
                items.Insert(0, New AutocompleteMenuNS.AutocompleteItem("<!-- attrib template: default -->", 1, String.Format(My.Resources.QuickInsert_DefineGeneric_Tip, "template"), String.Format(My.Resources.QuickInsert_DefineGeneric_Tip, "template"), String.Format(My.Resources.QuickInsert_DefineTemplate_TipText, "default", "default.html")))
            End If

            For Each Attribute As TreeNode In Main.AttributeTree.Nodes
                If Not internal.Contains(Attribute.Text) Then
                    If Not Code.Text.Contains("<!-- attrib " & Attribute.Text & ":") Then
                        items.Add(New AutocompleteMenuNS.AutocompleteItem("<!-- attrib " & Attribute.Text & ": ... -->", 1, String.Format(My.Resources.QuickInsert_DefineGeneric_Tip, Attribute.Text), String.Format(My.Resources.QuickInsert_DefineGeneric_Tip, Attribute.Text), String.Format(My.Resources.QuickInsert_DefineGeneric_TipText, Attribute.Text) & Environment.NewLine & Environment.NewLine & String.Format(My.Resources.QuickInsert_DefineGeneric_TipText, "<!-- attrib " & Attribute.Text & ": ... -->")))
                    End If
                End If
                'items.Add(New AutocompleteMenuNS.AutocompleteItem(Attribute.Text))
            Next

            items.Add(New AutocompleteMenuNS.AutocompleteItem("<!-- attrib ...: ... -->", 5, My.Resources.QuickInsert_DefineNew_Tip, My.Resources.QuickInsert_DefineNew_Tip, My.Resources.QuickInsert_DefineNew_TipText & Environment.NewLine & Environment.NewLine & String.Format(My.Resources.QuickInsert__Example, "<!-- attrib ...: ... -->")))
        End If

        If Not Me.Parent.Text.StartsWith("includes\") Then
            If Not Code.GetLineText(Code.Selection.FromLine).StartsWith("<!-- attrib") Then
                items.Add(New AutocompleteMenuNS.AutocompleteItem(My.Resources.QuickInsert_InsertConditional_Tip, 4, My.Resources.QuickInsert_InsertConditional_Tip, My.Resources.QuickInsert_InsertConditional_Tip, My.Resources.QuickInsert_InsertConditional_TipText))
            End If
            items.Add(New AutocompleteMenuNS.AutocompleteItem(My.Resources.QuickInsert_Build, 3, My.Resources.QuickInsert_Build, My.Resources.QuickInsert_Build_Tip, My.Resources.QuickInsert_Build_TipText))
        End If

        Autocomplete.SetAutocompleteItems(items)
    End Sub

    Private Sub Code_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles Code.KeyDown
        If e.Control Then
            prepMenu()
        End If
    End Sub

    Private Function rootCalc() As String
        ' Estimates [#root#] attribute output
        Dim toreturn = String.Format(My.Resources.QuickInsert__Example, "../")

        If Not Me.Parent.Text.StartsWith("templates\") Then
            Dim rel As String = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

            toreturn = ""

            For Each e In rel.Split("\")
                toreturn &= "../"
            Next

            toreturn = toreturn.Substring(3) ' clip off first ../

            toreturn = String.Format(My.Resources.QuickInsert__Output, toreturn)
        End If

        Return toreturn
    End Function

    Private Function pathCalc() As String
        ' Estimates [#path#] attribute output
        Dim toreturn = String.Format(My.Resources.QuickInsert__Example, "about/index.md")

        If Not Me.Parent.Text.StartsWith("templates\") Then
            Dim rel As String = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

            toreturn = String.Format(My.Resources.QuickInsert__Output, rel)

            Return toreturn
        End If
        Return toreturn
    End Function

    Public Sub doQuickInsert() Handles QuickInsert.Click
        Code.Focus()
        prepMenu()
        Autocomplete.Show(Code, True)
    End Sub

    Private Sub PreviewWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles PreviewWorker.DoWork
        e.Result = Apricot.Compile(e.Argument(0), e.Argument(1), siteRoot, True, Now, Nothing).HTML()
    End Sub

    Private Sub PreviewWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PreviewWorker.RunWorkerCompleted
        Main.Preview.DocumentText = e.Result
        Preview.Enabled = True
        ViewOutput.Enabled = True
    End Sub

    Private Function _rel()
        Dim rel As String = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If rel.EndsWith(".md") Then
            rel = rel.Substring(0, rel.Length - 3) & ".html"
        End If

        Return rel
    End Function
End Class
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

    Public Sub doUndo() Handles UndoBtn.Click ', Undo.Click
        Code.Undo()
    End Sub

    Public Sub doRedo() Handles RedoBtn.Click ', Redo.Click
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

    Private AttributeStyle As New TextStyle(Nothing, Nothing, FontStyle.Italic)
    Private ConditionalStyle As New TextStyle(Brushes.ForestGreen, Nothing, FontStyle.Italic)

    Private rc As String

    Private Sub prepLivePreview()
        doPreview(True)
    End Sub

    Friend Sub doLivePreview()
        rc = Code.Text.Replace("[#root#]", "file://" & Main.SiteTree.Nodes(0).Tag.Replace("\", "/") & "/out/")
        If My.Settings.LivePreviewAttributes Then
            rc = rc.Replace("<!-- attrib", "    <!-- attrib")
        End If
        If openFile.EndsWith(".md") Then
            rc = CommonMark.CommonMarkConverter.Convert(rc)
        End If

        'Main.Preview.SuspendLayout()

        'Main.Preview.DocumentText = "<FONT FACE=""" & My.Settings.previewFont.Name & """>" & _
        '         rc & "</FONT>"

        'Main.Preview.Document.Body.InnerHtml = "<FONT FACE=""" & My.Settings.previewFont.Name & """>" & _
        '         rc & "</FONT>"

        If Not Main.livePreviewHolder = OutRel() Then
            Main.livePreviewHolder = OutRel()
            prepLivePreview()
        End If

        If (Main.Preview.Document.GetElementsByTagName("autosite").Count >= 1) Then
            Main.Preview.Document.GetElementsByTagName("autosite").Item(0).InnerHtml = rc
        End If
        'Main.Preview.Document.Window.ScrollTo(0, Main.Preview.Document.Window.Size.Height * (Code.Selection.FromLine / Code.LinesCount))

    End Sub
    
    Private Sub Editor_TextChanged(ByVal sender As System.Object, ByVal e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Code.TextChanged
        If (Not Code.Text = Snapshot) And (Not openFile Is Nothing) Then
            If Not Me.Parent.Text.EndsWith("*") Then
                Me.Parent.Text = KindRel() & "*"
            End If
            SaveBtn.Enabled = True
        End If
        If My.Settings.SyntaxHighlight Then
            '    'clear style of changed range
            'Code.Range.ClearStyle(ItalicStyle)
            Code.Range.ClearStyle()

            Code.Range.SetStyle(AttributeStyle, "\[#\S*?#\]", RegexOptions.Singleline)
            'Code.Range.SetStyle(ItalicStyle, "\[(\S*?)=(\S*?)\](.*?)\[\/\1(.{1,2})\]", RegexOptions.Singleline)
            Code.Range.SetStyle(ConditionalStyle, "\[(\S*?)=([^\<\s]*?)\]", RegexOptions.Singleline)
            Code.Range.SetStyle(ConditionalStyle, "\[(\S*?)=\]", RegexOptions.Singleline)
            '\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]
            'for atteql, value, text in re.findall(r'\[(.*)=(.*?)\](.*)\[\/\1.*\]', template):
        End If
        Try
            If My.Settings.LivePreview And Main.PreviewPanel.Checked Then
                doLivePreview()
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
            Me.Parent.Text = KindRel()
            SaveBtn.Enabled = False

                If Snapshot.Contains("<!-- attrib title: ") And Snapshot.Contains("-->") Then
                ' Get the title of the page thru apricot or regex todo tk
                ' Main.updateExplorerFileTitle(title, openFile)
            End If
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
    Private attributes As String = ""

    Public Sub doPreview(Optional ByVal livePreviewPrep = False)
        Dim rel = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If Not Main.PreviewPanel.Checked Then
            Main.PreviewPanel.Checked = True
            Main.panelUpdate()
        End If

        If Not fromRoot().StartsWith("pages\") Then
            Main.Preview.Navigate(Path.Combine(Main.SiteTree.Nodes(0).Text, "out\"))
            Main.Preview.DocumentText = Code.Text
        Else
            Main.Preview.Navigate(siteRoot & "out\" & rel)
            Preview.Enabled = False
            ViewOutput.Enabled = False
            template_cache.Clear()
            If livePreviewPrep Then
                'Dim attributes As String = "<!-- attrib title: <span title=""This is a limited preview. Live Preview uses the default template, and does not include attribute or conditional processing."">Live Preview</span> -->" & Environment.NewLine
                attributes = ""
                Dim regex As RegularExpressions.Regex = New RegularExpressions.Regex("<!--\s*(?:attrib\s){1}\s*(.*?)\s*:\s*(.*?)\s*-->")
                For Each Match As Match In regex.Matches(Code.Text)
                    attributes &= Match.ToString & Environment.NewLine
                Next

                activLivePreviewOnFinishLoad = True
                PreviewWorker.RunWorkerAsync({attributes & "<autosite></autosite>", rel})
            Else
                Main.livePreviewHolder = ""
                PreviewWorker.RunWorkerAsync({Code.Text, rel})
            End If
        End If
    End Sub

    Private activLivePreviewOnFinishLoad As Boolean = False

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
        conditionals.Display.Text = Code.SelectedText
        If conditionals.ShowDialog() = DialogResult.OK Then
            Code.InsertText(conditionals.output)
        End If
    End Sub

    Public Sub doViewOutput() Handles ViewOutput.ButtonClick
        Dim url As String = siteRoot & "\out\" & OutRel()
        If Not My.Computer.FileSystem.FileExists(url) Then
            If Build.Enabled Then
                Main.afterBuildNavigatePreview = url
                Main.doBuild()
            End If
            Exit Sub
        End If

        Main.Preview_Navigate(url)

    End Sub

    Public Sub doViewinDefaultBrowser() Handles ViewinDefaultBrowser.Click
        Dim url As String = siteRoot & "\out\" & OutRel()
        If Not My.Computer.FileSystem.FileExists(url) Then
            If Build.Enabled Then
                Main.afterBuildLaunch = url
                Main.doBuild()
            End If
            Exit Sub
        End If

        Process.Start(url)
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

            If e.Item.Text = "<!-- attrib template: default -->" Then
                Code.Selection.Start = New Place(0, 0)
                Code.Selection.End = New Place(0, 0)
                Code.ProcessKey(Keys.Home)
                Code.InsertText(e.Item.Text & Environment.NewLine)
            ElseIf Code.GetLineText(Code.LineNumberStartValue - 1) = "" Then
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

        If (Not fromRoot().StartsWith("includes\")) And Not Code.GetLineText(Code.Selection.FromLine).StartsWith("<!-- attrib") Then
            ' Internal
            If fromRoot().StartsWith("templates\") And Not Code.Text.Contains("[#content#]") Then
                items.Add(New AutocompleteMenuNS.AutocompleteItem("[#content#]", 2, "content", My.Resources.QuickInsert_content_Tip, My.Resources.QuickInsert_content_TipText))
            End If
            items.Add(New AutocompleteMenuNS.AutocompleteItem("[#root#]", 2, "root", My.Resources.QuickInsert_root_Tip, My.Resources.QuickInsert_root_TipText & Environment.NewLine & Environment.NewLine & rootCalc()))
            items.Add(New AutocompleteMenuNS.AutocompleteItem("[#modified#]", 2, "modified", My.Resources.QuickInsert_modified_Tip, My.Resources.QuickInsert_modified_TipText & Environment.NewLine & Environment.NewLine & String.Format(My.Resources.QuickInsert__Example, Date.Now.ToString.Split(" ")(0))))
            items.Add(New AutocompleteMenuNS.AutocompleteItem("[#path#]", 2, "path", My.Resources.QuickInsert_path_Tip, My.Resources.QuickInsert_path_TipText & Environment.NewLine & Environment.NewLine & pathCalc()))
            For Each Attribute As TreeNode In Main.AttributeTree.Nodes
                If Not internal.Contains(Attribute.Text) Then
                    If Code.Text.Contains("<!-- attrib " & Attribute.Text & ":") Or fromRoot().StartsWith("templates\") Then
                        items.Add(New AutocompleteMenuNS.AutocompleteItem("[#" & Attribute.Text & "#]", 0, Attribute.Text, Attribute.Text, String.Format(My.Resources.QuickInsert_Generic_TipText, Attribute.Text)))
                    End If
                End If
            Next
        End If

        ' Internal define option
        If fromRoot().StartsWith("pages\") Then
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

        If Not fromRoot().StartsWith("includes\") Then
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

        If Not fromRoot().StartsWith("templates\") Then
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

        If Not fromRoot().StartsWith("templates\") Then
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
        If activLivePreviewOnFinishLoad Then
            doLivePreview()
            activLivePreviewOnFinishLoad = False
            Main.haveBrowserCallForLivePreview = True
        End If
    End Sub

    Public Function fromRoot()
        ' replace Me.Parent.Text to keep pages\, includes\, templates\
        Return openFile.Replace(siteRoot & "\", "")
    End Function
    
    Public Function KindRel()
        ' replace Me.Parent.Text to keep pages\, includes\, templates\
        Return openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")
    End Function
    
    Private Function OutRel()
        Dim rel As String = KindRel()

        If rel.EndsWith(".md") Then
            rel = rel.Substring(0, rel.Length - 3) & ".html"
        End If

        Return rel
    End Function

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertMnu.Click
        doQuickInsert()
    End Sub

    Private Sub plopAttributeToken(sender As System.Object, e As System.EventArgs)
        Code.InsertText(sender.text)
    End Sub

    'Private Sub Context_Popup(sender As System.Object, e As System.EventArgs) Handles Context.Opening
    '    InsertAttribute.DropDownItems.Clear()
    '    InsertAttribute.DropDownItems.Add("[#content#]")
    '    InsertAttribute.DropDownItems.Add("[#root#]")
    '    For Each att As TreeNode In Main.AttributeTree.Nodes
    '        InsertAttribute.DropDownItems.Add("[#" & att.Text & "#]")
    '    Next
    'End Sub

    Private Sub doUndo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoBtn.Click

    End Sub

    Public Sub doOpenFileLocation()
        Dim url As String = siteRoot & "\out\" & OutRel()

        url = Path.GetDirectoryName(url)
        If Not My.Computer.FileSystem.DirectoryExists(url) Then
            If Build.Enabled Then
                Main.afterBuildLaunch = url
                Main.doBuild()
            End If
            Exit Sub
        End If

        Try
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

End Class
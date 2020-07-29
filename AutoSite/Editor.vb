Imports System.IO
Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS

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
        Dim rel = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If Not Main.PreviewPanel.Checked Then
            Main.PreviewPanel.Checked = True
            Main.panelUpdate()
        End If

        If Not Me.Parent.Text.StartsWith("pages\") Then
            Main.Preview.Navigate(Path.Combine(Main.SiteTree.Nodes(0).Text, "out\"))
            Main.Preview.DocumentText = Code.Text
        Else
            template_cache.Clear()
            Main.Preview.Navigate(siteRoot & "out\" & rel)
            Main.Preview.DocumentText = Apricot.Compile(Code.Text, rel, siteRoot, True, Now, Nothing).HTML
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
        Dim rel = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If Not Main.PreviewPanel.Checked Then
            Main.PreviewPanel.Checked = True
            Main.panelUpdate()
        End If

        If rel.EndsWith(".md") Then
            rel = Apricot.ReplaceLast(rel, ".md", ".html")
        End If

        Main.Preview.Navigate(siteRoot & "\out\" & rel)
    End Sub

    Private Sub Build_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build.Click
        Main.doBuild()
    End Sub

    Private Sub ViewinDefaultBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewinDefaultBrowser.Click
        Dim rel = openFile.Replace(siteRoot & "\pages\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")
        If rel.EndsWith(".md") Then
            rel = Apricot.ReplaceLast(rel, ".md", ".html")
        End If
        Process.Start(siteRoot & "\out\" & rel)
    End Sub

    Private Sub Autocomplete_Selecting(ByVal sender As System.Object, ByVal e As AutocompleteMenuNS.SelectingEventArgs) Handles Autocomplete.Selecting
        If e.Item.ImageIndex = 3 Then      ' Build option
            e.Cancel = True
            Autocomplete.Close()
            Main.doBuild()
        ElseIf e.Item.ImageIndex = 1 Then  ' Define attribute
            e.Cancel = True

            If Code.GetLineText(Code.LineNumberStartValue - 1) = "" Then
                Code.InsertText(e.Item.Text)
            Else
                Code.Selection.Start = New Place(0, 0)
                Code.Selection.End = New Place(0, 0)
                Code.ProcessKey(Keys.End)
                Code.InsertText(vbNewLine & e.Item.Text)
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

    Private Sub Code_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles Code.KeyDown
        If e.Control Then
            Dim items As New List(Of AutocompleteMenuNS.AutocompleteItem)

            Dim internal As New List(Of String)
            internal.Add("root")
            internal.Add("path")
            internal.Add("modified")
            internal.Add("template")

            If Not Me.Parent.Text.StartsWith("includes\") Then
                ' Internal
                items.Add(New AutocompleteMenuNS.AutocompleteItem("[#root#]", 2, "[#root#]", "Reference root", "Outputs the page's relative path to root." & vbNewLine & "Useful for paths to stylesheets, images, and other pages." & vbNewLine & vbNewLine & "Example: ../"))
                'items.Add(New AutocompleteMenuNS.AutocompleteItem("[#template#]", 2, "[#template#]", "Reference template", "Outputs the page's used template." & vbNewLine & vbNewLine & "Example: default"))
                '  I mean referencing this is neat but pretty worthless imho
                items.Add(New AutocompleteMenuNS.AutocompleteItem("[#modified#]", 2, "[#modified#]", "Reference modified", "Outputs the page's last modified date." & vbNewLine & vbNewLine & "Example: " & Date.Now.ToString.Split(" ")(0)))
                items.Add(New AutocompleteMenuNS.AutocompleteItem("[#path#]", 2, "[#path#]", "Reference path", "Outputs the page's path, relative from root." & vbNewLine & vbNewLine & "Example: about/index.md"))
            End If

            For Each Attribute As TreeNode In Main.AttributeTree.Nodes
                If Not internal.Contains(Attribute.Text) Then
                    If Code.Text.Contains("<!-- attrib " & Attribute.Text & ":") Or Me.Parent.Text.StartsWith("templates\") Then
                        items.Add(New AutocompleteMenuNS.AutocompleteItem("[#" & Attribute.Text & "#]", 0, "[#" & Attribute.Text & "#]", "Reference " & Attribute.Text, "Outputs the page's value for the " & Attribute.Text & " attribute."))
                    End If
                End If
                'items.Add(New AutocompleteMenuNS.AutocompleteItem(Attribute.Text))
            Next

            ' Internal define option
            If Me.Parent.Text.StartsWith("pages\") Then
                If Not Code.Text.Contains("<!-- attrib template:") Then
                    items.Insert(0, New AutocompleteMenuNS.AutocompleteItem("<!-- attrib template: default -->", 1, "Define template", "Define template", "Defines the template used by the current page." & vbNewLine & vbNewLine & "Default is default, which tells AutoSite to use default.html in the templates folder."))
                End If

                For Each Attribute As TreeNode In Main.AttributeTree.Nodes
                    If Not internal.Contains(Attribute.Text) Then
                        If Not Code.Text.Contains("<!-- attrib " & Attribute.Text & ":") Then
                            items.Add(New AutocompleteMenuNS.AutocompleteItem("<!-- attrib " & Attribute.Text & ": ... -->", 1, "Define " & Attribute.Text, "Define " & Attribute.Text, "Defines the " & Attribute.Text & " attribute for this page." & vbNewLine & vbNewLine & "Example: <!-- attrib " & Attribute.Text & ": ... -->"))
                        End If
                    End If
                    'items.Add(New AutocompleteMenuNS.AutocompleteItem(Attribute.Text))
                Next
        End If

        If Main.AttributeTree.Nodes.Count = 0 Then
                items.Add(New AutocompleteMenuNS.AutocompleteItem("Build", 3, "Build to show more options", "Build", "AutoSite can give you more suggestions when you build" & vbNewLine & " your site and the Attribute Map is populated."))
            ElseIf Not Me.Parent.Text.StartsWith("includes\") Then
                items.Add(New AutocompleteMenuNS.AutocompleteItem("Insert Conditional...", 4, "Insert Conditional...", "Insert Conditional", "Open the Insert Conditional dialog." & vbNewLine & "Conditionals allow you to output text if an attribute has a certain value."))
        End If

        Autocomplete.SetAutocompleteItems(items)
        End If
    End Sub
End Class
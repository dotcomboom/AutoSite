Imports System.IO
Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS
Imports System.Text

Public Class Editor

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
        'broken pls fix
        'Dim outStream = New FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        'Using streamWriter As New StreamWriter(outStream)
        '    streamWriter.Flush()
        '    For Each line In Code.Lines
        '        streamWriter.WriteLine(text)
        '    Next
        '    streamWriter.Close()
        '    streamWriter.Dispose()
        'End Using
        'outStream.Dispose()
        Try
            Code.SaveToFile(path, System.Text.Encoding.UTF8)
        Catch
            Try
                Dim unlocker = New FileStream(path, FileMode.Open)
                unlocker.Unlock(1, unlocker.Length)
                unlocker.Close()
                Code.SaveToFile(path, System.Text.Encoding.UTF8)
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

    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Code.KeyDown
        If e.Control And e.KeyCode = Keys.W Then
            Close()
        ElseIf e.Control And e.KeyCode = Keys.S Then
            Save()
        ElseIf e.Control And e.KeyCode = Keys.P Then
            doPreview()
        ElseIf e.Control And e.KeyCode = Keys.F Then
            doFind()
        ElseIf e.Control And e.KeyCode = Keys.H Then
            doReplace()
        ElseIf e.Control And e.KeyCode = Keys.G Then
            doGoto()
        End If
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

    Public template_cache As New Dictionary(Of String, String)()

    Public Sub doPreview() Handles Preview.ButtonClick
        Dim page = ""
        If Me.Parent.Text.EndsWith(".md") Then
            page = CommonMark.CommonMarkConverter.Convert(Code.Text)
        Else
            page = Code.Text
        End If

        Dim rel = openFile.Replace(siteRoot & "\in\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")

        If Not Me.Parent.Text.StartsWith("in\") Then
            Main.Preview.Navigate(Path.Combine(Main.SiteTree.Nodes(0).Text, "out\"))
            Main.Preview.DocumentText = page
        Else
            Dim templates = Path.Combine(Main.SiteTree.Nodes(0).Text, "templates\")
            template_cache.Clear()

            Dim content = ""
            Dim attribs As New Dictionary(Of String, String)()
            attribs.Add("template", "default")
            attribs.Add("path", rel.Replace("\", "/"))
            Dim reader As New StringReader(page)
            Dim line As String
            Do
                line = reader.ReadLine
                Dim regex As RegularExpressions.Regex = New RegularExpressions.Regex("^<!-- attrib (.*): (.*) -->")
                If Not line Is Nothing Then
                    Dim match As RegularExpressions.Match = regex.Match(line)
                    If match.Success Then
                        attribs.Item(match.Groups(1).Value) = match.Groups(2).Value
                    Else
                        content = content & vbNewLine & line
                    End If
                End If
            Loop Until line Is Nothing
            reader.Close()
            reader.Dispose()
            For Each attrib In attribs
                Dim tn As New Main.TNode
                tn.relPath = rel
                tn.Attribute = attrib.Key
                tn.Value = attrib.Value
            Next
            If Not My.Computer.FileSystem.FileExists(templates & "\" & attribs.Item("template") & ".html") Then
                If My.Computer.FileSystem.FileExists(templates & "\default.html") Then
                    attribs.Item("template") = "default"
                Else
                    attribs.Item("template") = "<b>AS</b>internal"
                    If Not template_cache.ContainsKey("<b>AS</b>internal") Then
                        template_cache.Add("<b>AS</b>internal", "<!doctype html>" & vbNewLine & "<html>" & vbNewLine & "  <head>" & vbNewLine & "    <title>[#title#]</title>" & vbNewLine & "  </head>" & vbNewLine & "  <body>" & vbNewLine & "    <h1>[#title#]</h1>" & vbNewLine & "    <p>" & vbNewLine & "      [path=index.md]You are on the index.[/path=]" & vbNewLine & "    </p>" & vbNewLine & "    [#content#]" & vbNewLine & "  </body>" & vbNewLine & "</html>")
                    End If
                End If
            End If
            If Not template_cache.ContainsKey(attribs.Item("template")) Then
                template_cache.Item(attribs.Item("template")) = ReadAllText(Path.Combine(templates, attribs.Item("template") & ".html"))
            End If
            Dim newHtml = template_cache.Item(attribs.Item("template"))
            ' Attribute Process 1 (Content)
            For Each kvp As KeyValuePair(Of String, String) In attribs
                newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
            Next
            ' End Attribute Process 1
            If rel.EndsWith(".md") Then
                content = CommonMark.CommonMarkConverter.Convert(content)
                rel = Main.ReplaceLast(rel, ".md", ".html")
            End If
            newHtml = newHtml.Replace("[#content#]", content)
            'newHtml = newHtml.Replace("[#root#]", Form1.FillString("../", Form1.CountCharacter(rel, "\")))
            newHtml = newHtml.Replace("[#root#]", siteRoot & "\includes\")
            Dim conditionalRegex = "\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]"
            Dim matches = Regex.Matches(newHtml, conditionalRegex)
            For Each m As Match In matches
                Dim fullStr = m.Groups(0).Value
                Dim key = m.Groups(1).Value
                Dim value = m.Groups(2).Value
                Dim html = m.Groups(3).Value
                Dim equality = (Not key.EndsWith("!"))
                If equality = False Then
                    key = Main.ReplaceLast(key, "!", "")
                End If
                Dim pass = False
                If attribs.ContainsKey(key) Then
                    If attribs.Item(key) = value Then
                        pass = True
                    End If
                End If

                If pass Then
                    If equality = True Then
                        newHtml = newHtml.Replace(fullStr, html)
                    Else
                        newHtml = newHtml.Replace(fullStr, "")
                    End If
                Else
                    If equality = True Then
                        newHtml = newHtml.Replace(fullStr, "")
                    Else
                        newHtml = newHtml.Replace(fullStr, html)
                    End If
                End If
            Next
            ' Attribute Process 2 (Whole Page)
            For Each kvp As KeyValuePair(Of String, String) In attribs
                newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
            Next
            ' End Attribute Process 2
            newHtml = Regex.Replace(newHtml, "\[#.*?#\]", "")

            If rel.EndsWith(".md") Then
                rel = Main.ReplaceLast(rel, ".md", ".html")
            End If
            Main.Preview.Navigate(siteRoot & "out\" & rel)
            Main.Preview.DocumentText = newHtml
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

    Public Sub ViewOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOutput.Click
        Dim rel = openFile.Replace(siteRoot & "\in\", "").Replace(siteRoot & "\includes\", "").Replace(siteRoot & "\templates\", "")
        If rel.EndsWith(".md") Then
            rel = Main.ReplaceLast(rel, ".md", ".html")
        End If
        Main.Preview.Navigate(siteRoot & "\out\" & rel)
    End Sub

    Private Sub Build_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build.Click
        Main.doBuild()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        ' NYI
    End Sub
End Class

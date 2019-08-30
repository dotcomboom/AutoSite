Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS
Imports System.IO
Imports System.Text

Public Class Form1

    Public openFiles As New ArrayList

    ' https://stackoverflow.com/a/8182507
    Sub walkTree(ByVal directory As IO.DirectoryInfo, ByVal pattern As String, ByVal parentNode As TreeNode, ByVal key As String, ByVal incRoot As Boolean)
        Dim dirnode = parentNode
        If incRoot Then
            dirnode = parentNode.Nodes.Add(directory.Name)
            dirnode.Tag = directory.FullName
        End If
        For Each file In directory.GetFiles(pattern)
            Dim node = dirnode.Nodes.Add(file.Name)
            node.Tag = file.FullName
            node.ImageKey = key
            node.SelectedImageKey = key
        Next
        For Each subDir In directory.GetDirectories
            walkTree(subDir, pattern, dirnode, key, True)
        Next
    End Sub

    Private Sub checkOpen()
        Panel1.Visible = (SiteTree.Nodes.Count < 1)
        CloseSite.Enabled = (SiteTree.Nodes.Count > 0)
        BuildSite.Enabled = (SiteTree.Nodes.Count > 0)
    End Sub

    Private Sub iconTheme()
        If My.Settings.iconTheme = "xp" Then
            XPitem.Checked = True
            SiteTree.ImageList = XP
        ElseIf My.Settings.iconTheme = "vs2017" Then
            VS2017item.Checked = True
            SiteTree.ImageList = VS2017
        End If
    End Sub

    Private Sub refreshTree(ByVal root As TreeNode)
        Dim templatePath = root.Text & "\templates"
        Dim inPath = root.Text & "\in"
        Dim includePath = root.Text & "\includes"

        root.Nodes.Clear()

        Dim pages = root.Nodes.Add("Pages")
        pages.ImageKey = "Page"
        pages.SelectedImageKey = "Page"

        Dim templates = root.Nodes.Add("Templates")
        templates.ImageKey = "Template"
        templates.SelectedImageKey = "Template"

        Dim includes = root.Nodes.Add("Includes")
        includes.ImageKey = "Include"
        includes.SelectedImageKey = "Include"

        walkTree(My.Computer.FileSystem.GetDirectoryInfo(inPath), "*", pages, "Page", False)
        walkTree(My.Computer.FileSystem.GetDirectoryInfo(templatePath), "*", templates, "Template", False)
        walkTree(My.Computer.FileSystem.GetDirectoryInfo(includePath), "*", includes, "Include", False)

        root.Expand()
        pages.Expand()
        templates.Expand()
        includes.Expand()
    End Sub

    Private Sub openSite(ByVal path As String, ByVal autoload As Boolean)
        checkOpen()
        If My.Computer.FileSystem.DirectoryExists(path) Then
            Dim templatePath = path & "\templates"
            Dim inPath = path & "\in"
            Dim includePath = path & "\includes"

            If Not (My.Computer.FileSystem.DirectoryExists(templatePath) And My.Computer.FileSystem.DirectoryExists(inPath) And My.Computer.FileSystem.DirectoryExists(includePath)) Then
                If autoload = False Then
                    If MsgBox("AutoSite will create a site in the folder located at " & path & ". Is this OK?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If
            If Not My.Computer.FileSystem.DirectoryExists(templatePath) Then
                My.Computer.FileSystem.CreateDirectory(templatePath)
            End If
            If Not My.Computer.FileSystem.DirectoryExists(inPath) Then
                My.Computer.FileSystem.CreateDirectory(inPath)
            End If
            If Not My.Computer.FileSystem.DirectoryExists(includePath) Then
                My.Computer.FileSystem.CreateDirectory(includePath)
            End If

            SiteTree.Nodes.Clear()

            Dim root = SiteTree.Nodes.Add(path)
            root.ImageKey = "Folder"
            root.SelectedImageKey = "Folder"

            refreshTree(root)
        End If
        checkOpen()
        My.Settings.openProject = path
    End Sub

    Sub panelUpdate()
        EdSplit.Panel2Collapsed = Not (PreviewPanel.Checked)
        CoreSplit.Panel1Collapsed = (ExplorerPanel.Checked = False) And (BuildPanel.Checked = False)
        EdSplit.Panel1Collapsed = Not (EditorPanel.Checked)
        CoreSplit.Panel2Collapsed = (EditorPanel.Checked = False) And (PreviewPanel.Checked = False)

        ExSplit.Panel1Collapsed = Not (ExplorerPanel.Checked)
        ExSplit.Panel2Collapsed = Not (BuildPanel.Checked)

        My.Settings.explorerOpen = ExplorerPanel.Checked
        My.Settings.editorOpen = EditorPanel.Checked
        My.Settings.browserOpen = PreviewPanel.Checked
        My.Settings.buildOpen = BuildPanel.Checked

        My.Settings.WordWrap = WordWrap.Checked
        My.Settings.VirtualSpace = VirtualSpace.Checked
        My.Settings.WideCaret = WideCaret.Checked

        For Each page As TabPage In EditTabs.TabPages
            Dim point As New Point
            point.X = 0
            point.Y = 0
            Dim child = page.GetChildAtPoint(point, GetChildAtPointSkip.None)
            If TypeOf child Is Editor Then
                Dim edit As Editor = child
                edit.Code.WordWrap = My.Settings.WordWrap
                edit.Code.VirtualSpace = My.Settings.VirtualSpace
                edit.Code.WideCaret = My.Settings.WideCaret
            End If

        Next
    End Sub

    Private Sub OpenFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenFolder.Click, OpenLink.LinkClicked
        If FolderBrowser.ShowDialog() = DialogResult.OK Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowser.SelectedPath) Then
                openSite(FolderBrowser.SelectedPath, False)
            End If
        End If
    End Sub

    Private Sub AboutItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutItem.Click
        About.ShowDialog()
    End Sub

    Private Sub CloseSite_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseSite.Click
        SiteTree.Nodes.Clear()
        EditTabs.TabPages.Clear()
        checkOpen()
    End Sub

    Private Sub VirtualSpace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VirtualSpace.Click
        If VirtualSpace.Checked Then
            VirtualSpace.Checked = False
        Else
            VirtualSpace.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub WideCaret_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WideCaret.Click
        If WideCaret.Checked Then
            WideCaret.Checked = False
        Else
            WideCaret.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub WordWrap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WordWrap.Click
        If WordWrap.Checked Then
            WordWrap.Checked = False
        Else
            WordWrap.Checked = True
        End If
        panelUpdate()
        'FastColoredTextBox1.WordWrap = WordWrap.Checked
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If My.Settings.explorerOpen Then
            ExplorerPanel.Checked = True
            CoreSplit.Panel1Collapsed = False
        Else
            ExplorerPanel.Checked = False
            CoreSplit.Panel1Collapsed = True
        End If

        If My.Settings.editorOpen Then
            EditorPanel.Checked = True
            EdSplit.Panel1Collapsed = False
        Else
            EditorPanel.Checked = False
            EdSplit.Panel1Collapsed = True
        End If

        If My.Settings.browserOpen Then
            PreviewPanel.Checked = True
            EdSplit.Panel2Collapsed = False
        Else
            PreviewPanel.Checked = False
            EdSplit.Panel2Collapsed = True
        End If

        If (EdSplit.Panel1Collapsed = True) And (EdSplit.Panel2Collapsed = True) Then
            CoreSplit.Panel2Collapsed = True
        Else
            CoreSplit.Panel2Collapsed = False
        End If

        If My.Settings.iconTheme = "auto" Then
            If My.Computer.Info.OSFullName.Contains("XP") Then
                My.Settings.iconTheme = "xp"
            Else
                My.Settings.iconTheme = "vs2017"
            End If
        End If

        iconTheme()

        If My.Settings.engine = "python" Then
            EnginePython.Checked = True
            EngineApricot.Checked = False
        Else
            EnginePython.Checked = False
            EngineApricot.Checked = True
        End If

        If My.Computer.FileSystem.DirectoryExists(My.Settings.openProject) Then
            openSite(My.Settings.openProject, True)
        End If
    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles SiteTree.NodeMouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim box As FastColoredTextBox
            If My.Computer.FileSystem.FileExists(e.Node.Tag) Then
                Try
                    If Not openFiles.Contains(e.Node.Tag) Then
                        Dim tab As New TabPage
                        tab.Tag = e.Node.Tag
                        tab.Text = e.Node.Tag.Replace(SiteTree.Nodes.Item(0).Text & "\", "")
                        EditTabs.TabPages.Add(tab)
                        EditTabs.SelectedTab = tab
                        Dim editor As New Editor
                        editor.Parent = tab
                        editor.Dock = DockStyle.Fill
                        editor.Code.OpenFile(tab.Tag)
                        editor.Snapshot = editor.Code.Text
                        editor.siteRoot = SiteTree.Nodes.Item(0).Text
                        editor.openFile = tab.Tag
                        box = editor.Code
                        openFiles.Add(e.Node.Tag)
                    End If
                    'FastColoredTextBox1.Text = My.Computer.FileSystem.ReadAllText(e.Node.Tag)
                Catch ex As Exception

                End Try
            End If
            Try
                If Not e.Node.Tag.EndsWith(".md") Then
                    WebBrowser1.Navigate(e.Node.Tag)
                Else
                    WebBrowser1.DocumentText = CommonMark.CommonMarkConverter.Convert(box.Text)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ExplorerPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExplorerPanel.Click
        If ExplorerPanel.Checked Then
            ExplorerPanel.Checked = False
        Else
            ExplorerPanel.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub BuildPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BuildPanel.Click
        If BuildPanel.Checked Then
            BuildPanel.Checked = False
        Else
            BuildPanel.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub EditorPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditorPanel.Click
        If EditorPanel.Checked Then
            EditorPanel.Checked = False
        Else
            EditorPanel.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub PreviewPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PreviewPanel.Click
        If PreviewPanel.Checked Then
            PreviewPanel.Checked = False
        Else
            PreviewPanel.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub SiteTree_Layout(ByVal sender As Object, ByVal e As LayoutEventArgs)
        checkOpen()
    End Sub

    Private Sub VS2017item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VS2017item.Click
        If Not VS2017item.Checked Then
            VS2017item.Checked = True
            XPitem.Checked = False
            My.Settings.iconTheme = "vs2017"
        End If
        iconTheme()
    End Sub

    Private Sub XPitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XPitem.Click
        If Not XPitem.Checked Then
            VS2017item.Checked = False
            XPitem.Checked = True
            My.Settings.iconTheme = "xp"
        End If
        iconTheme()
    End Sub

    Private Sub SiteTree_BeforeLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs)
        If e.Node.Tag = "" Then
            e.CancelEdit = True
        End If
    End Sub

    Private Sub SiteTree_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs)
        Try
            Dim newpath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(e.Node.Tag), e.Label)
            Try
                My.Computer.FileSystem.MoveFile(e.Node.Tag, newpath)
                e.Node.Tag = newpath
            Catch exx As Exception
                Try
                    My.Computer.FileSystem.MoveDirectory(e.Node.Tag, newpath)
                    e.Node.Tag = newpath
                Catch exxx As Exception
                    e.CancelEdit = True
                End Try
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EdSplit_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles EdSplit.Layout
        CoreSplit.Panel2Collapsed = (PreviewPanel.Checked = False And EditorPanel.Checked = False)
    End Sub

    Private Sub ExitItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitItem.Click
        Me.Close()
    End Sub

    Private Sub BuildSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildSite.Click, ToolStripButton1.Click
        If EnginePython.Checked Then
            If My.Computer.FileSystem.FileExists("AutoSitePy.exe") Then
                If Not My.Computer.FileSystem.DirectoryExists(SiteTree.Nodes(0).Text & "\out") Then
                    My.Computer.FileSystem.CreateDirectory(SiteTree.Nodes(0).Text & "\out")
                End If
                Try
                    Dim startinfo As New ProcessStartInfo
                    startinfo.FileName = "AutoSitePy.exe"
                    startinfo.Arguments = "--auto --dir """ & SiteTree.Nodes(0).Text & """"
                    Process.Start(startinfo)
                    WebBrowser1.Navigate(SiteTree.Nodes(0).Text & "\out")
                Catch ex As Exception
                    MsgBox("The Python 3-based build engine was unable to launch for some reason. This may be because of your operating system or the executable. Error:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Build fail")
                End Try
            Else
                MsgBox("Python 3-based build engine wasn't found. Put AutoSitePy.exe in the same folder as AutoSite XL.exe.", MsgBoxStyle.Exclamation, "Engine not found")
            End If
        Else
            'Build.Show()
            bld = SiteTree.Nodes(0).Text
            Apricot.RunWorkerAsync()
        End If
    End Sub

    Private Sub OpenInDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInDefault.Click
        Try
            Process.Start(SiteTree.SelectedNode.Tag)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SiteTree_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Context.Tag = e.Node.Tag
            If Context.Tag = "" Then
                OpenInDefault.Enabled = False
                CopyCon.Enabled = False
                PasteCon.Enabled = False
                DeleteCon.Enabled = False
                AddFilesCon.Enabled = False
                NewCon.Enabled = False
            Else
                OpenInDefault.Enabled = True
                CopyCon.Enabled = True
                If Clipboard.ContainsFileDropList Then
                    PasteCon.Enabled = True
                Else
                    PasteCon.Enabled = False
                End If
                DeleteCon.Enabled = True
                AddFilesCon.Enabled = True
                NewCon.Enabled = True
            End If
            Context.Show(SiteTree, e.Location)
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshItem.Click
        If SiteTree.Nodes.Count > 0 Then
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyCon.Click
        Dim path = Context.Tag
        If Not path = "" Then
            Dim f() As String = {path}
            Dim d As New DataObject(DataFormats.FileDrop, f)
            Clipboard.SetDataObject(d, True)
        End If
    End Sub

    Private Sub PasteCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteCon.Click
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        ' https://stackoverflow.com/questions/10450447/how-to-paste-a-file-from-clipboard-to-specific-path
        Try
            Dim data As IDataObject = Clipboard.GetDataObject
            If data.GetDataPresent(DataFormats.FileDrop) Then
                For Each s As String In data.GetData(DataFormats.FileDrop)
                    Dim newFile As String = System.IO.Path.Combine(dir, System.IO.Path.GetFileName(s))
                    Dim number = 0
                    Dim oldnewFile = newFile
                    While My.Computer.FileSystem.FileExists(newFile)
                        number += 1
                        newFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(oldnewFile), System.IO.Path.GetFileNameWithoutExtension(oldnewFile) & " (" & number & ")" & System.IO.Path.GetExtension(oldnewFile))
                    End While
                    My.Computer.FileSystem.CopyFile(s, newFile, False)
                Next
            End If
            refreshTree(SiteTree.Nodes(0))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCon.Click
        Dim path = Context.Tag
        If My.Computer.FileSystem.DirectoryExists(path) Then
            Try
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                refreshTree(SiteTree.Nodes(0))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            Try
                My.Computer.FileSystem.DeleteFile(path, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                refreshTree(SiteTree.Nodes(0))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub NewFolderCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFolderCon.Click
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        If My.Computer.FileSystem.DirectoryExists(dir) Then
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.Combine(dir, "New Folder"))
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub NewHTMLCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewHTMLCon.Click
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "New Page.html"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New HTML Page -->" & vbNewLine, False)
        refreshTree(SiteTree.Nodes(0))
    End Sub

    Private Sub NewMDCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMDCon.Click
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "New Page.md"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New Markdown Page -->" & vbNewLine, False)
        refreshTree(SiteTree.Nodes(0))
    End Sub

    Private Sub NewPHPCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPHPCon.Click
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "New Page.php"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New PHP Page -->" & vbNewLine & "<?php" & vbNewLine & vbTab & "echo ""This will be interpreted by the server. Hello universe!"";" & vbNewLine & "?>", False)
        refreshTree(SiteTree.Nodes(0))
    End Sub

    Private Sub AddFilesCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFilesCon.Click
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        If My.Computer.FileSystem.DirectoryExists(dir) Then
            AddFilesDialog.Title = "Add Files to " & dir
            If AddFilesDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                For Each file In AddFilesDialog.FileNames
                    Try
                        My.Computer.FileSystem.CopyFile(file, System.IO.Path.Combine(dir, file), True, FileIO.UICancelOption.DoNothing)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next
                refreshTree(SiteTree.Nodes(0))
            End If
        End If
        refreshTree(SiteTree.Nodes(0))
    End Sub

    Private Sub EngineApricot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngineApricot.Click
        EnginePython.Checked = False
        EngineApricot.Checked = True
        My.Settings.engine = "apricot"
    End Sub

    Private Sub EnginePython_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnginePython.Click
        EnginePython.Checked = True
        EngineApricot.Checked = False
        My.Settings.engine = "python"
    End Sub

    Public bld = ""
    Public template_cache As New Dictionary(Of String, String)()

    Private Sub aLog(ByVal text As String)
        Log.AppendText(vbNewLine & text)
    End Sub

    'https://bytes.com/topic/visual-basic-net/answers/370586-replace-first-occurrance-substring#post1428786
    Public Shared Function ReplaceFirst(ByVal expression As String, ByVal find As String, ByVal replacement As String) As String
        Dim index As Integer = expression.IndexOf(find)
        Return expression.Remove(index, find.Length).Insert(index, replacement)
    End Function

    'https://stackoverflow.com/questions/22268373/vb-c-replace-string
    Public Shared Function ReplaceLast(ByVal str As String, ByVal search As String, ByVal newText As String) As String
        Dim ind As Integer = str.LastIndexOf(search)

        If ind < 0 Then
            Return str
        End If

        Return str.Substring(0, ind) & newText & str.Substring(ind + search.Length)
    End Function

    'https://stackoverflow.com/questions/5193893/count-specific-character-occurrences-in-a-string
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    'https://social.msdn.microsoft.com/forums/windows/en-us/07e63494-9ee0-412e-8a8d-cfc9b91f456a/string-function-for-repeating-character-string
    Public Shared Function FillString(ByVal ch As String, ByVal count As Integer) As String
        Dim sb As StringBuilder = New StringBuilder(count)

        For ix As Integer = 0 To count - 1
            sb.Append(ch)
        Next

        Return sb.ToString()
    End Function

    Sub walkInputs(ByVal directory As IO.DirectoryInfo, ByVal pattern As String, ByVal input As String, ByVal templates As String, ByVal out As String)
        For Each file In directory.GetFiles(pattern)
            Apricot.ReportProgress(0, "Rendering " & file.FullName)
            Dim rel = ReplaceFirst(file.FullName, input, "")
            'Dim contents = My.Computer.FileSystem.ReadAllText(file.FullName)
            Dim content = ""
            Dim attribs As New Dictionary(Of String, String)()
            attribs.Add("template", "default")
            Dim reader As New StreamReader(file.FullName, Encoding.Default)
            Dim line As String
            Apricot.ReportProgress(20, "Reading attributes")
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
            If Not template_cache.ContainsKey(attribs.Item("template")) Then
                Apricot.ReportProgress(30, "Loading template " & attribs.Item("template"))
                template_cache.Item(attribs.Item("template")) = My.Computer.FileSystem.ReadAllText(Path.Combine(templates, attribs.Item("template") & ".html"))
            End If
            Dim newHtml = template_cache.Item(attribs.Item("template"))
            Apricot.ReportProgress(50, "Slotting into template " & attribs.Item("template"))
            If rel.EndsWith(".md") Then
                content = CommonMark.CommonMarkConverter.Convert(content)
                rel = ReplaceLast(rel, ".md", ".html")
            End If
            newHtml = newHtml.Replace("[#content#]", content)
            'MsgBox(rel)
            newHtml = newHtml.Replace("[#root#]", FillString("../", CountCharacter(rel, "\")))
            For Each kvp As KeyValuePair(Of String, String) In attribs
                Apricot.ReportProgress(50, "  " & kvp.Key & ": " & kvp.Value)
                newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
            Next
            Apricot.ReportProgress(90, "Saving file")
            My.Computer.FileSystem.WriteAllText(out & rel, newHtml, False)
            Apricot.ReportProgress(100, "Done with file")
        Next
        For Each subDir In directory.GetDirectories
            walkInputs(subDir, pattern, input, templates, out)
        Next
    End Sub

    Private Sub Apricot_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Apricot.DoWork
        Dim input = Path.Combine(bld, "in\")
        Dim templates = Path.Combine(bld, "templates\")
        Dim includes = Path.Combine(bld, "includes\")
        Dim out = Path.Combine(bld, "out\")

        Apricot.ReportProgress(0, "Starting!")
        Apricot.ReportProgress(0, bld)

        If Not My.Computer.FileSystem.DirectoryExists(input) Then
            Apricot.ReportProgress(10, "Creating in/ folder")
            My.Computer.FileSystem.CreateDirectory(input)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(templates) Then
            Apricot.ReportProgress(10, "Creating templates/ folder")
            My.Computer.FileSystem.CreateDirectory(templates)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(includes) Then
            Apricot.ReportProgress(10, "Creating includes/ folder")
            My.Computer.FileSystem.CreateDirectory(includes)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(out) Then
            Apricot.ReportProgress(10, "Creating out/ folder")
            My.Computer.FileSystem.CreateDirectory(out)
        End If

        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*")
        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(templates), "*.*")
        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(includes), "*.*")
        'walkLog(My.Computer.FileSystem.GetDirectoryInfo(out), "*.*")

        Apricot.ReportProgress(20, "Syncing includes")

        My.Computer.FileSystem.CopyDirectory(includes, out, True)

        Apricot.ReportProgress(25, "Rendering input files")
        walkInputs(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*", input, templates, out)

        Apricot.ReportProgress(100, "Finished!")
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Apricot.ProgressChanged
        BuildProgress.Visible = True
        BuildProgress.Value = e.ProgressPercentage
        Me.Text = e.UserState
        aLog(e.UserState)
    End Sub

    Private Sub Apricot_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Apricot.RunWorkerCompleted
        Me.Text = "AutoSite XL"
        BuildProgress.Visible = False
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim saved = True
        For Each page As TabPage In EditTabs.TabPages
            If page.Text.Contains("*") Then
                saved = False
            End If
        Next
        If Not saved Then
            Dim d As DialogResult = MsgBox("One or more files have unsaved changes that will be lost. Close anyway?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "AutoSite XL")
            If d = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class

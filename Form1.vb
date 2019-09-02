Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS
Imports System.IO
Imports System.Text
Imports Microsoft.Synchronization.Data

Public Class Form1

    Public openFiles As New ArrayList
    Public wTitle = "AutoSite XL"

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
        OpenPrompt.Visible = (SiteTree.Nodes.Count < 1)
        OpenLink.Visible = (SiteTree.Nodes.Count < 1)

        CloseSite.Enabled = (SiteTree.Nodes.Count > 0)
        SaveAll.Enabled = (SiteTree.Nodes.Count > 0)
        BuildSite.Enabled = (SiteTree.Nodes.Count > 0)
        Build.Enabled = (SiteTree.Nodes.Count > 0)
        OpenOutput.Enabled = (SiteTree.Nodes.Count > 0)
        Build.Enabled = (SiteTree.Nodes.Count > 0)
        BrowseOutput.Enabled = (SiteTree.Nodes.Count > 0)
        BrowseOutputExt.Enabled = (SiteTree.Nodes.Count > 0)
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
        Dim inPath = root.Text & "\in"
        Dim templatePath = root.Text & "\templates"
        Dim includePath = root.Text & "\includes"

        root.Nodes.Clear()

        Dim pages = root.Nodes.Add("Pages")
        pages.ImageKey = "Page"
        pages.SelectedImageKey = "Page"
        pages.Tag = inPath

        Dim templates = root.Nodes.Add("Templates")
        templates.ImageKey = "Template"
        templates.SelectedImageKey = "Template"
        templates.Tag = templatePath

        Dim includes = root.Nodes.Add("Includes")
        includes.ImageKey = "Include"
        includes.SelectedImageKey = "Include"
        includes.Tag = includePath

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
            root.Tag = path

            refreshTree(root)
        End If
        checkOpen()
        My.Settings.openProject = path
        Watcher.Path = path
        Watcher.Filter = "*.*"
    End Sub

    Public Sub panelUpdate()
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
        My.Settings.SyntaxHighlight = SyntaxHighlight.Checked
        My.Settings.LivePreview = LivePreview.Checked

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
                edit.LivePreview.Checked = My.Settings.LivePreview
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
        Dim saved = True
        For Each page As TabPage In EditTabs.TabPages
            If page.Text.Contains("*") Then
                saved = False
            End If
        Next
        If Not saved Then
            Dim d As DialogResult = MsgBox("Some files have unsaved changes. Save them?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "AutoSite XL")

            If d = DialogResult.Yes Then
                DoSaveAll()
            End If
            If d = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
        openFiles.Clear()
        SiteTree.Nodes.Clear()
        EditTabs.TabPages.Clear()
        AttributeTree.Nodes.Clear()
        Preview.DocumentText = ""
        My.Settings.openProject = ""
        Watcher.Filter = "NFIDNI#N()Dxn)(@Nqinnxisabub@IZWNQIONCIWENiN@Nd0N@()@()OPQNOPMNXONNW(ENND@#(ONCPENQOPNNNSANOI" ' can't disable it so /shrug
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
        wTitle &= " v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Revision > 0 Then
            wTitle &= "." & My.Application.Info.Version.Revision
        End If
        If My.Application.Info.Version.Build > 0 Then
            wTitle &= "." & My.Application.Info.Version.Build
        End If
        Me.Text = wTitle

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
        checkOpen()

        If My.Settings.engine = "python" Then
            EnginePython.Checked = True
            EngineApricot.Checked = False
        Else
            EnginePython.Checked = False
            EngineApricot.Checked = True
        End If

        WordWrap.Checked = My.Settings.WordWrap
        VirtualSpace.Checked = My.Settings.VirtualSpace
        WideCaret.Checked = My.Settings.WideCaret
        SyntaxHighlight.Checked = My.Settings.SyntaxHighlight
        LivePreview.Checked = My.Settings.LivePreview

        If My.Computer.FileSystem.DirectoryExists(My.Settings.openProject) Then
            openSite(My.Settings.openProject, True)
        End If
    End Sub

    Private foundNode As TreeNode = Nothing

    'https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-iterate-through-all-nodes-of-a-windows-forms-treeview-control
    Private Sub FindNodeTag(ByVal treeNode As TreeNode, ByVal tag As String)
        If treeNode.Tag = tag Then
            foundNode = treeNode
        End If

        If foundNode Is Nothing Then
            For Each tn As TreeNode In treeNode.Nodes
                FindNodeTag(tn, tag)
            Next
        End If
    End Sub

    Private Sub SiteTree_NodeMouseDoubleClick(ByVal sender As TreeView, ByVal e As TreeNodeMouseClickEventArgs) Handles SiteTree.NodeMouseDoubleClick, AttributeTree.NodeMouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If sender.Name = "AttributeTree" Then
                FindNodeTag(SiteTree.Nodes(0), e.Node.Tag)
                If Not foundNode Is Nothing Then
                    foundNode.TreeView.SelectedNode = foundNode
                End If
            End If
            Dim box As FastColoredTextBox
            If My.Computer.FileSystem.FileExists(e.Node.Tag) Then
                Try
                    If openFiles.Contains(e.Node.Tag) Then
                        For Each page As TabPage In EditTabs.TabPages
                            If page.Tag = e.Node.Tag Then
                                EditTabs.SelectedTab = page
                            End If
                        Next
                    Else
                        Dim tab As New TabPage
                        tab.Tag = e.Node.Tag
                        tab.ToolTipText = tab.Tag
                        tab.Text = tab.Tag.Replace(SiteTree.Nodes.Item(0).Text & "\", "")
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
                Catch ex As Exception
                End Try
            End If
            Try
                If e.Node.Tag.EndsWith(".md") Then
                    Preview.DocumentText = CommonMark.CommonMarkConverter.Convert(box.Text)
                Else
                    If Not e.Node.Tag.EndsWith(".css") And Not e.Node.Tag.EndsWith(".js") Then
                        Preview.Navigate(e.Node.Tag)
                    End If
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

    Private Sub SiteTree_BeforeLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles SiteTree.BeforeLabelEdit
        If e.Node.Tag = "" Then
            e.CancelEdit = True
        End If
    End Sub

    Private Sub SiteTree_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles SiteTree.AfterLabelEdit
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

    Private Sub ExitItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitItem.Click
        Me.Close()
    End Sub

    Private Sub BuildSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildSite.Click, Build.Click
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
                    Preview.Navigate(SiteTree.Nodes(0).Text & "\out")
                Catch ex As Exception
                    MsgBox("The Python 3-based build engine was unable to launch for some reason. This may be because of your operating system or the executable. Error:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Build fail")
                End Try
            Else
                MsgBox("Python 3-based build engine wasn't found. Put AutoSitePy.exe in the same folder as AutoSite XL.exe.", MsgBoxStyle.Exclamation, "Engine not found")
            End If
        Else
            'Build.Show()
            bld = SiteTree.Nodes(0).Text
            Log.Clear()
            AttributeTree.Nodes.Clear()
            template_cache.Clear()
            Apricot.RunWorkerAsync()
        End If
    End Sub

    Private Sub OpenInDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInDefault.Click
        Try
            Process.Start(SiteTree.SelectedNode.Tag)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SiteTree_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles SiteTree.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Context.Tag = e.Node.Tag
            If Context.Tag = "" Then
                OpenInDefault.Enabled = False
                CopyCon.Enabled = False
                PasteCon.Enabled = False
                DeleteCon.Enabled = False
                RenameCon.Enabled = False
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
                DeleteCon.Enabled = Context.Tag.EndsWith(e.Node.Text)
                RenameCon.Enabled = Context.Tag.EndsWith(e.Node.Text)
                AddFilesCon.Enabled = True
                NewCon.Enabled = True
            End If
            If Context.Tag = SiteTree.Nodes(0).Tag Then
                OpenInDefault.Enabled = True
                CopyCon.Enabled = False
                PasteCon.Enabled = False
                DeleteCon.Enabled = False
                RenameCon.Enabled = False
                AddFilesCon.Enabled = False
                NewCon.Enabled = False
            End If
            Try
                If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(0).Tag) Then
                    NewFolderCon.Enabled = True
                    NewHTMLCon.Enabled = True
                    NewMDCon.Enabled = True
                    NewPHPCon.Enabled = True
                    NewCSSCon.Enabled = False
                    NewJSCon.Enabled = False
                End If
                If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(1).Tag) Then
                    NewFolderCon.Enabled = False
                    NewHTMLCon.Enabled = True
                    NewMDCon.Enabled = False
                    NewPHPCon.Enabled = False
                    NewCSSCon.Enabled = False
                    NewJSCon.Enabled = False
                End If
                If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(2).Tag) Then
                    NewFolderCon.Enabled = True
                    NewHTMLCon.Enabled = True
                    NewMDCon.Enabled = True
                    NewPHPCon.Enabled = True
                    NewCSSCon.Enabled = True
                    NewJSCon.Enabled = True
                End If
            Catch ex As Exception
            End Try
            Context.Show(SiteTree, e.Location)
        End If
    End Sub

    Private Sub RefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshItem.Click
        If SiteTree.Nodes.Count > 0 Then
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub CopyCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyCon.Click
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
            'refreshTree(SiteTree.Nodes(0))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCon.Click
        Dim path = Context.Tag
        If My.Computer.FileSystem.DirectoryExists(path) Then
            Try
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                'refreshTree(SiteTree.Nodes(0))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            Try
                My.Computer.FileSystem.DeleteFile(path, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                'refreshTree(SiteTree.Nodes(0))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private fileAddContext As String = ""

    Private Sub NewFolderCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFolderCon.Click
        fileAddContext = "rename"
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        If My.Computer.FileSystem.DirectoryExists(dir) Then
            Dim num = 0
            Dim add = ""
            While My.Computer.FileSystem.DirectoryExists(System.IO.Path.Combine(dir, "new_folder" & add))
                num += 1
                add = " (" & num & ")"
            End While
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.Combine(dir, "new_folder" & add))
            'refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub NewHTMLCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewHTMLCon.Click
        fileAddContext = "rename"
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        Dim html = "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New HTML Page -->" & vbNewLine
        If dir = SiteTree.Nodes(0).Nodes(1).Tag Then
            html = "<!doctype html>" & vbNewLine & "<html>" & vbNewLine & "  <head>" & vbNewLine & "    <title>[#title#]</title>" & vbNewLine & "  </head>" & vbNewLine & "  <body>" & vbNewLine & "    <h1>[#title#]</h1>" & vbNewLine & "    <p>" & vbNewLine & "      [path=index.md]You are on the index.[/path=]" & vbNewLine & "      [path!=index.md]You are not on the index.[/path!=]" & vbNewLine & "    </p>" & vbNewLine & "    [#content#]" & vbNewLine & "  </body>" & vbNewLine & "</html>"
        ElseIf dir = SiteTree.Nodes(0).Nodes(2).Tag Then
            html = "<!doctype html>" & vbNewLine & "<html>" & vbNewLine & "  <head>" & vbNewLine & "    <title>New HTML Page</title>" & vbNewLine & "  </head>" & vbNewLine & "  <body>" & vbNewLine & "    <h1>Include Page</h1>" & vbNewLine & "  </body>" & vbNewLine & "</html>"
        End If
        Dim num = 0
        Dim add = ""
        While My.Computer.FileSystem.FileExists(System.IO.Path.Combine(dir, "new-page" & add & ".html"))
            num += 1
            add = " (" & num & ")"
        End While
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "new-page" & add & ".html"), html, False)
    End Sub

    Private Sub NewMDCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMDCon.Click
        fileAddContext = "rename"
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        Dim num = 0
        Dim add = ""
        While My.Computer.FileSystem.FileExists(System.IO.Path.Combine(dir, "new-page" & add & ".html"))
            num += 1
            add = " (" & num & ")"
        End While
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "new-page" & add & ".md"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New Markdown Page -->" & vbNewLine, False)
    End Sub

    Private Sub NewPHPCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPHPCon.Click
        fileAddContext = "rename"
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        Dim num = 0
        Dim add = ""
        While My.Computer.FileSystem.FileExists(System.IO.Path.Combine(dir, "new-page" & add & ".html"))
            num += 1
            add = " (" & num & ")"
        End While
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "new-page" & add & ".php"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New PHP Page -->" & vbNewLine & "<?php" & vbNewLine & vbTab & "  echo ""This will be interpreted by the server. Hello universe!"";" & vbNewLine & "?>", False)
    End Sub

    Private Sub NewCSSCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCSSCon.Click
        fileAddContext = "rename"
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        Dim num = 0
        Dim add = ""
        While My.Computer.FileSystem.FileExists(System.IO.Path.Combine(dir, "new-page" & add & ".html"))
            num += 1
            add = " (" & num & ")"
        End While
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "new-style" & add & ".css"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New PHP Page -->" & vbNewLine & "<?php" & vbNewLine & vbTab & "  echo ""This will be interpreted by the server. Hello universe!"";" & vbNewLine & "?>", False)
    End Sub

    Private Sub NewJSCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewJSCon.Click
        fileAddContext = "rename"
        Dim path = Context.Tag
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(path) Then
            dir = path
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            dir = My.Computer.FileSystem.GetFileInfo(path).DirectoryName
        End If
        Dim num = 0
        Dim add = ""
        While My.Computer.FileSystem.FileExists(System.IO.Path.Combine(dir, "new-page" & add & ".html"))
            num += 1
            add = " (" & num & ")"
        End While
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, "new-script" & add & ".js"), "<!-- attrib template: default -->" & vbNewLine & "<!-- attrib title: New PHP Page -->" & vbNewLine & "<?php" & vbNewLine & vbTab & "  echo ""This will be interpreted by the server. Hello universe!"";" & vbNewLine & "?>", False)
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
                        My.Computer.FileSystem.CopyFile(file, System.IO.Path.Combine(dir, System.IO.Path.GetFileName(file)))
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next
                'refreshTree(SiteTree.Nodes(0))
            End If
        End If
        'refreshTree(SiteTree.Nodes(0))
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

    Public Class TNode
        Private _relPath As String
        Public Property relPath() As String
            Get
                Return _relPath
            End Get
            Set(ByVal value As String)
                _relPath = value
            End Set
        End Property

        Private _Attribute As String
        Public Property Attribute() As String
            Get
                Return _Attribute
            End Get
            Set(ByVal value As String)
                _Attribute = value
            End Set
        End Property

        Private _Value As String
        Public Property Value() As String
            Get
                Return _Value
            End Get
            Set(ByVal value As String)
                _Value = value
            End Set
        End Property
    End Class

    Sub walkInputs(ByVal directory As IO.DirectoryInfo, ByVal pattern As String, ByVal input As String, ByVal templates As String, ByVal out As String)
        For Each file In directory.GetFiles(pattern)
            Dim rel = ReplaceFirst(file.FullName, input, "")
            Apricot.ReportProgress(0, "  Rendering " & rel.Replace("\", "/"))
            Dim content = ""
            Dim attribs As New Dictionary(Of String, String)()
            attribs.Add("template", "default")
            attribs.Add("path", rel.Replace("\", "/"))
            Dim reader As New StreamReader(file.FullName, Encoding.Default)
            Dim line As String
            Apricot.ReportProgress(20, "    Reading attributes")
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
            For Each attrib In attribs
                Dim tn As New TNode
                tn.relPath = rel
                tn.Attribute = attrib.Key
                tn.Value = attrib.Value
                Apricot.ReportProgress(20, tn)
            Next
            If Not template_cache.ContainsKey(attribs.Item("template")) Then
                Apricot.ReportProgress(30, "    Loading template " & attribs.Item("template"))
                template_cache.Item(attribs.Item("template")) = My.Computer.FileSystem.ReadAllText(Path.Combine(templates, attribs.Item("template") & ".html"))
            End If
            Dim newHtml = template_cache.Item(attribs.Item("template"))
            Apricot.ReportProgress(50, "    Slotting into template " & attribs.Item("template"))
            newHtml = newHtml.Replace("[#content#]", content)
            newHtml = newHtml.Replace("[#root#]", FillString("../", CountCharacter(rel, "\")))
            Dim conditionalRegex = "\[(.*?)=(.*?)\](.*?)\[\/\1(.{1,2})\]"
            Dim matches = Regex.Matches(newHtml, conditionalRegex)
            For Each m As Match In matches
                Dim fullStr = m.Groups(0).Value
                ' Apricot.ReportProgress(50, "  " & fullStr)
                Dim key = m.Groups(1).Value
                Dim value = m.Groups(2).Value
                Dim html = m.Groups(3).Value
                Dim equality = (Not key.EndsWith("!"))
                If equality = False Then
                    key = ReplaceLast(key, "!", "")
                End If
                Dim pass = False
                If attribs.ContainsKey(key) Then
                    If attribs.Item(key) = value Then
                        pass = True
                    End If
                End If

                If pass Then
                    If equality = True Then
                        MsgBox(equality & pass & key)
                        newHtml = newHtml.Replace(fullStr, html)
                    Else
                        newHtml = newHtml.Replace(fullStr, "")
                    End If
                Else
                    If equality = True Then
                        newHtml = newHtml.Replace(fullStr, "")
                    Else
                        MsgBox(equality & pass & key)
                        newHtml = newHtml.Replace(fullStr, html)
                    End If
                End If
            Next
            If rel.EndsWith(".md") Then
                content = CommonMark.CommonMarkConverter.Convert(content)
                rel = ReplaceLast(rel, ".md", ".html")
            End If
            For Each kvp As KeyValuePair(Of String, String) In attribs
                If Not kvp.Key = "path" Then
                    Apricot.ReportProgress(50, "      " & kvp.Key & ": " & kvp.Value)
                End If
                newHtml = newHtml.Replace("[#" & kvp.Key & "#]", kvp.Value)
            Next
            newHtml = Regex.Replace(newHtml, "\[#.*?#\]", "")
            Apricot.ReportProgress(90, "    Saving file")
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(out & rel))
            My.Computer.FileSystem.WriteAllText(out & rel, newHtml, False)
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

        Apricot.ReportProgress(0, "Apricot building " & bld)

        If Not My.Computer.FileSystem.DirectoryExists(input) Then
            Apricot.ReportProgress(10, "Creating in\ folder")
            My.Computer.FileSystem.CreateDirectory(input)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(templates) Then
            Apricot.ReportProgress(10, "Creating templates\ folder")
            My.Computer.FileSystem.CreateDirectory(templates)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(includes) Then
            Apricot.ReportProgress(10, "Creating includes\ folder")
            My.Computer.FileSystem.CreateDirectory(includes)
        End If
        If Not My.Computer.FileSystem.DirectoryExists(out) Then
            Apricot.ReportProgress(10, "Creating out\ folder")
            My.Computer.FileSystem.CreateDirectory(out)
        End If

        Apricot.ReportProgress(20, "Syncing includes")

        Dim s As New doSync(includes, out)
        Dim t = s.BeginSynchronization()
        If t = doSync.SyncResults.Unsuccessful Then
            Apricot.ReportProgress(20, "  Copying includes\ folder to out\")
            My.Computer.FileSystem.CopyDirectory(includes, out, True)
        End If

        Apricot.ReportProgress(50, "Rendering input files")
        walkInputs(My.Computer.FileSystem.GetDirectoryInfo(input), "*.*", input, templates, out)

        Apricot.ReportProgress(100, "Finished!")
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Apricot.ProgressChanged
        If e.UserState.GetType() Is GetType(System.String) Then
            BuildProgress.Visible = True
            BuildProgress.Value = e.ProgressPercentage
            Me.Text = e.UserState
            Log.AppendText(e.UserState & vbNewLine)
        ElseIf e.UserState.GetType() Is GetType(TNode) Then
            Dim tn As TNode = e.UserState

            Dim aNode As New TreeNode
            Dim exists As Boolean = False
            For Each node As TreeNode In AttributeTree.Nodes
                If node.Text = tn.Attribute Then
                    aNode = node
                    exists = True
                End If
            Next

            If Not exists Then
                aNode = New TreeNode
                aNode.Text = tn.Attribute
                aNode.ImageKey = "Attribute"
                aNode.SelectedImageKey = "Attribute"
                AttributeTree.Nodes.Add(aNode)
            End If

            Dim vNode As New TreeNode
            Dim txt = tn.Value
            If txt.Length > 20 Then
                txt = txt.Substring(0, 20) & ".."
            End If

            exists = False
            For Each node As TreeNode In aNode.Nodes
                If node.Text = txt Then
                    vNode = node
                    exists = True
                End If
            Next

            If Not exists Then
                vNode = New TreeNode
                vNode.Text = txt
                vNode.ImageKey = "Value"
                vNode.SelectedImageKey = "Value"
                aNode.Nodes.Add(vNode)
            End If

            Dim pNode = vNode
            Dim rPath = tn.relPath
            While rPath.Contains("\")
                Dim folderName = rPath.Split("\")(0)
                Dim npExists = False
                Dim npNode As New TreeNode
                For Each node As TreeNode In pNode.Nodes
                    If node.Text = folderName Then
                        npNode = node
                        npExists = True
                    End If
                Next
                If Not npExists Then
                    npNode.Text = folderName
                    npNode.ImageKey = "Folder"
                    npNode.SelectedImageKey = "Folder"
                    pNode.Nodes.Add(npNode)
                End If
                pNode = npNode
                rPath = ReplaceFirst(rPath, folderName & "\", "")
            End While

            Dim fNode As New TreeNode
            fNode.Text = rPath
            fNode.ImageKey = "Page"
            fNode.SelectedImageKey = "Page"
            fNode.Tag = Path.Combine(SiteTree.Nodes(0).Text, "in\" & tn.relPath)
            pNode.Nodes.Add(fNode)
        End If
    End Sub

    Private Sub Apricot_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Apricot.RunWorkerCompleted
        Me.Text = wTitle
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
            Dim d As DialogResult = MsgBox("Some files have unsaved changes. Save them?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "AutoSite XL")

            If d = DialogResult.Yes Then
                DoSaveAll()
            End If
            If d = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SyntaxHighlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SyntaxHighlight.Click
        If SyntaxHighlight.Checked Then
            SyntaxHighlight.Checked = False
        Else
            SyntaxHighlight.Checked = True
        End If
        panelUpdate()
    End Sub

    Public Sub LivePreview_Toggle() Handles LivePreview.Click
        If LivePreview.Checked Then
            LivePreview.Checked = False
        Else
            LivePreview.Checked = True
        End If
        panelUpdate()
    End Sub

    Public Sub DoSaveAll() Handles SaveAll.Click
        For Each page As TabPage In EditTabs.TabPages
            Dim point As New Point
            point.X = 0
            point.Y = 0
            Dim child = page.GetChildAtPoint(point, GetChildAtPointSkip.None)
            If TypeOf child Is Editor Then
                Dim edit As Editor = child
                edit.Save()
            End If
        Next
    End Sub

    Private Sub OpenDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOutput.Click
        Process.Start(SiteTree.Nodes(0).Text & "\out\")
    End Sub

    Private Sub BrowseOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseOutput.Click
        If My.Computer.FileSystem.FileExists(SiteTree.Nodes(0).Text & "\out\index.html") Then
            Preview.Navigate(SiteTree.Nodes(0).Text & "\out\index.html")
        Else
            Preview.Navigate(SiteTree.Nodes(0).Text & "\out\")
        End If
    End Sub

    Private Sub Preview_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles Preview.Navigating
        If My.Computer.FileSystem.FileExists(e.Url.AbsolutePath & "\index.html") Then
            e.Cancel = True
            Preview.Navigate(e.Url.AbsolutePath & "\index.html")
        End If
    End Sub

    Private Sub Watcher_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles Watcher.Created
        Dim root = SiteTree.Nodes(0)
        Dim pages = root.Nodes(0)
        Dim templates = root.Nodes(1)
        Dim includes = root.Nodes(2)
        Dim node As New TreeNode
        Dim arr As Array = e.Name.Split("\")
        node.Text = arr(arr.Length - 1)
        node.Tag = e.FullPath
        node.ImageKey = "Folder"
        node.SelectedImageKey = "Folder"
        If e.Name.StartsWith("in\") Then
            Dim f = ReplaceFirst(e.Name, "in\", "")
            Dim pnode As TreeNode = pages
            While f.Contains("\")
                Dim pdir = f.Split("\")(0)
                f = ReplaceFirst(f, pdir & "\", "")
                For Each nod As TreeNode In pnode.Nodes()
                    If nod.Text = pdir Then
                        pnode = nod
                    End If
                Next
            End While
            If f.Contains(".") Then
                node.ImageKey = "Page"
                node.SelectedImageKey = "Page"
            End If
            pnode.Nodes.Add(node)
            If fileAddContext = "rename" Then
                fileAddContext = ""
                node.BeginEdit()
            End If
        ElseIf e.Name.StartsWith("templates\") Then
            Dim f = ReplaceFirst(e.Name, "templates\", "")
            Dim pnode As TreeNode = templates
            While f.Contains("\")
                Dim pdir = f.Split("\")(0)
                f = ReplaceFirst(f, pdir & "\", "")
                For Each nod As TreeNode In pnode.Nodes()
                    If nod.Text = pdir Then
                        pnode = nod
                    End If
                Next
            End While
            If f.Contains(".") Then
                node.ImageKey = "Template"
                node.SelectedImageKey = "Template"
            End If
            pnode.Nodes.Add(node)
            If fileAddContext = "rename" Then
                fileAddContext = ""
                node.BeginEdit()
            End If
        ElseIf e.Name.StartsWith("includes\") Then
            Dim f = ReplaceFirst(e.Name, "includes\", "")
            Dim pnode As TreeNode = includes
            While f.Contains("\")
                Dim pdir = f.Split("\")(0)
                f = ReplaceFirst(f, pdir & "\", "")
                For Each nod As TreeNode In pnode.Nodes()
                    If nod.Text = pdir Then
                        pnode = nod
                    End If
                Next
            End While
            If f.Contains(".") Then
                node.ImageKey = "Include"
                node.SelectedImageKey = "Include"
            End If
            pnode.Nodes.Add(node)
            If fileAddContext = "rename" Then
                fileAddContext = ""
                node.BeginEdit()
            End If
        End If
    End Sub

    Private Sub Watcher_Deleted(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles Watcher.Deleted
        foundNode = Nothing
        FindNodeTag(SiteTree.Nodes(0), e.FullPath)
        If Not foundNode Is Nothing Then
            foundNode.Remove()
        End If
    End Sub

    Private Sub Watcher_Renamed(ByVal sender As System.Object, ByVal e As System.IO.RenamedEventArgs) Handles Watcher.Renamed
        foundNode = Nothing
        FindNodeTag(SiteTree.Nodes(0), e.OldFullPath)
        If Not foundNode Is Nothing Then
            Dim arr As Array = e.Name.Split("\")
            foundNode.Text = arr(arr.Length - 1)
            foundNode.Tag = e.FullPath
        End If
    End Sub

    Private Sub Rename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameCon.Click
        foundNode = Nothing
        FindNodeTag(SiteTree.Nodes(0), Context.Tag)
        If Not foundNode Is Nothing Then
            foundNode.BeginEdit()
        End If
    End Sub

    Private Sub BrowseOutputExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseOutputExt.Click
        If My.Computer.FileSystem.FileExists(SiteTree.Nodes(0).Text & "\out\index.html") Then
            Process.Start(SiteTree.Nodes(0).Text & "\out\index.html")
        Else
            Process.Start("iexplore " & SiteTree.Nodes(0).Text & "\out\")
        End If
    End Sub
End Class

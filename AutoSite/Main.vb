Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports System.Globalization

Public Class Main

    Public openFiles As New ArrayList
    Public wTitle = Application.ProductName
    Public editExtensions() As String = Apricot.knownExtensions
    Public encodingType As Encoding = New UTF8Encoding(False)
    Public args As String() = Environment.GetCommandLineArgs()
    Friend afterBuildNavigatePreview As String = ""
    Friend afterBuildLaunch As String = ""

    Public Sub New()

        If My.Settings.language.Length > 0 Then
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(My.Settings.language)
        End If

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

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
            If My.Settings.systemIcons Then
                Try
                    Dim splt = node.Text.Split(".")
                    Dim ext = splt(splt.Length - 1)
                    If Not VS2017.Images.ContainsKey(ext) Then
                        Dim icon As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName)
                        Dim bitmap As System.Drawing.Bitmap = icon.ToBitmap
                        VS2017.Images.Add(ext, icon)
                        XP.Images.Add(ext, icon)
                    End If
                    node.ImageKey = ext
                    node.SelectedImageKey = ext
                Catch ex As Exception
                End Try
            End If
        Next
        For Each subDir In directory.GetDirectories
            walkTree(subDir, pattern, dirnode, key, True)
        Next
    End Sub

    'https://stackoverflow.com/a/3448307
    Function ReadAllText(ByVal path As String)
        Dim inStream = New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim streamReader = New StreamReader(inStream, True)
        Dim text As String = streamReader.ReadToEnd()
        streamReader.Dispose()
        inStream.Dispose()
        Return text
    End Function

    Private Sub checkOpen()
        CloseSite.Enabled = (SiteTree.Nodes.Count > 0)
        SaveAll.Enabled = (SiteTree.Nodes.Count > 0)
        BuildSite.Enabled = (SiteTree.Nodes.Count > 0)
        Build.Enabled = (SiteTree.Nodes.Count > 0)
        SanitaryBuild.Enabled = (SiteTree.Nodes.Count > 0)
        SanitaryBuildBtn.Enabled = (SiteTree.Nodes.Count > 0)
        'InstallPackMnu.Enabled = (SiteTree.Nodes.Count > 0)
        QuickstartMnu.Enabled = (SiteTree.Nodes.Count > 0)

        OpenOutput.Enabled = (SiteTree.Nodes.Count > 0)
        BrowseSitePreview.Enabled = (SiteTree.Nodes.Count > 0)
        BrowseSite.Enabled = (SiteTree.Nodes.Count > 0)

        OpenOutputMnu.Enabled = (SiteTree.Nodes.Count > 0)
        BrowseSitePreviewMnu.Enabled = (SiteTree.Nodes.Count > 0)
        BrowseSitePreviewMnu.Enabled = (SiteTree.Nodes.Count > 0)

        AttributeExplanation.Visible = (AttributeTree.Nodes.Count < 1)

        If SiteTree.Nodes.Count > 0 Then
            'Me.Text = wTitle & " - " & SiteTree.Nodes(0).Text
            Me.Text = SiteTree.Nodes(0).Text & " - " & wTitle
        Else
            Me.Text = wTitle
        End If
    End Sub

    Private Sub loadIconTheme()
        VS2017item.Checked = False
        XPitem.Checked = False
        If My.Settings.iconTheme = "xp" Then
            XPitem.Checked = True
            SiteTree.ImageList = XP
        ElseIf My.Settings.iconTheme = "vs2017" Then
            VS2017item.Checked = True
            SiteTree.ImageList = VS2017
        End If
    End Sub

    Public Sub refreshTree(ByVal root As TreeNode)
        Dim inPath = root.Text & "\pages"
        Dim templatePath = root.Text & "\templates"
        Dim includePath = root.Text & "\includes"

        root.Nodes.Clear()

        Dim pages = root.Nodes.Add(My.Resources.Explorer_Pages)
        pages.ImageKey = "Page"
        pages.SelectedImageKey = "Page"
        pages.Tag = inPath

        Dim templates = root.Nodes.Add(My.Resources.Explorer_Templates)
        templates.ImageKey = "Template"
        templates.SelectedImageKey = "Template"
        templates.Tag = templatePath

        Dim includes = root.Nodes.Add(My.Resources.Explorer_Includes)
        includes.ImageKey = "Include"
        includes.SelectedImageKey = "Include"
        includes.Tag = includePath

        'Dim settings = root.Nodes.Add("Locale")
        'settings.ImageKey = "Build"
        'settings.SelectedImageKey = "Build"
        'settings.Tag = root.Text & "\apricot.xml

        SiteTree.BeginUpdate()
        walkTree(My.Computer.FileSystem.GetDirectoryInfo(inPath), "*", pages, "Page", False)
        walkTree(My.Computer.FileSystem.GetDirectoryInfo(templatePath), "*", templates, "Template", False)
        walkTree(My.Computer.FileSystem.GetDirectoryInfo(includePath), "*", includes, "Include", False)
        SiteTree.EndUpdate()

        root.Expand()
        pages.Expand()
        templates.Expand()
        includes.Expand()
    End Sub

    Public Sub openSite(ByVal path As String, ByVal autoload As Boolean)
        checkOpen()
        If My.Computer.FileSystem.DirectoryExists(path) Then
            If doClose() Then
                EditTabs.TabPages.Clear()
                Dim templatePath = path & "\templates"
                Dim inPath = path & "\pages"
                Dim includePath = path & "\includes"

                If Not My.Computer.FileSystem.DirectoryExists(inPath) And My.Computer.FileSystem.DirectoryExists(path & "\in") Then
                    If MsgBox(My.Resources.Prompt_ProjectUpgrade, MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, My.Resources.Prompt_ProjectUpgrade_Title) = MsgBoxResult.Ok Then
                        Try
                            My.Computer.FileSystem.RenameDirectory(path & "\in", "pages")
                        Catch ex As Exception
                            MsgBox(My.Resources.Error_UpgradeFail, MsgBoxStyle.Exclamation, My.Resources.Error_UpgradeFail_Title)
                            doClose()
                            Exit Sub
                        End Try
                    Else
                        doClose()
                        Exit Sub
                    End If
                End If

                If Not (My.Computer.FileSystem.DirectoryExists(templatePath) And My.Computer.FileSystem.DirectoryExists(inPath) And My.Computer.FileSystem.DirectoryExists(includePath)) Then
                    If autoload = False Then
                        If MsgBox(String.Format(My.Resources.Prompt_CreateSite, path), MsgBoxStyle.Question + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
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

                checkOpen()

                Dim root = SiteTree.Nodes.Add(path)
                root.ImageKey = "Folder"
                root.SelectedImageKey = "Folder"
                root.Tag = path

                ' Clear system icon cache
                While VS2017.Images.Count > 7
                    VS2017.Images.RemoveAt(7)
                    XP.Images.RemoveAt(7)
                End While

                refreshTree(root)
            End If
        End If
        checkOpen()

        My.Settings.openProject = path

        Dim recents = My.Settings.recents
        Try
            If recents.Contains(path) Then
                recents.Remove(path)
            End If
        Catch ex As Exception
            recents = New System.Collections.Specialized.StringCollection
        End Try
        recents.Insert(0, path)
        If recents.Count > 5 Then
            While recents.Count > 5
                recents.RemoveAt(5)
            End While
        End If
        My.Settings.recents = recents

        updateRecents()

        If Not My.Computer.Info.OSPlatform = "Win32Windows" Then   ' Detect non-NT Windows (98)
            Watcher.Path = path
            Watcher.EnableRaisingEvents = True
            Watcher.Filter = "*.*"
        End If
    End Sub

    Public Sub panelUpdate()
        EdSplit.Panel2Collapsed = Not (PreviewPanel.Checked)
        CoreSplit.Panel1Collapsed = (ExplorerPanel.Checked = False) And (BuildPanel.Checked = False)
        EdSplit.Panel1Collapsed = Not (EditorPanel.Checked)
        CoreSplit.Panel2Collapsed = (EditorPanel.Checked = False) And (PreviewPanel.Checked = False)

        ExSplit.Panel1Collapsed = Not (ExplorerPanel.Checked)
        ExSplit.Panel2Collapsed = Not (BuildPanel.Checked)


            EditMenu.Visible = EditorPanel.Checked
            CutBtn.Visible = EditorPanel.Checked
            CopyBtn.Visible = EditorPanel.Checked
            PasteBtn.Visible = EditorPanel.Checked
            FindBtn.Visible = EditorPanel.Checked
            ReplaceBtn.Visible = EditorPanel.Checked
            GotoBtn.Visible = EditorPanel.Checked
            InsertBtn.Visible = EditorPanel.Checked
            UndoBtn.Visible = EditorPanel.Checked
            RedoBtn.Visible = EditorPanel.Checked
        PreviewBtn.Visible = EditorPanel.Checked
        ViewOutBtn.Visible = EditorPanel.Checked
            Sep2.Visible = EditorPanel.Checked
        Sep3.Visible = EditorPanel.Checked
        Sep4.Visible = EditorPanel.Checked
        Sep5.Visible = EditorPanel.Checked
            SaveBtn.Visible = EditorPanel.Checked
            CloseBtn.Visible = EditorPanel.Checked

            FormatMenu.Visible = EditorPanel.Checked

            StatusBar.Visible = StatusBarMnu.Checked

            My.Settings.explorerOpen = ExplorerPanel.Checked
            My.Settings.editorOpen = EditorPanel.Checked
            My.Settings.browserOpen = PreviewPanel.Checked
            My.Settings.buildOpen = BuildPanel.Checked
            My.Settings.statusBar = StatusBarMnu.Checked

            My.Settings.WordWrap = WordWrap.Checked
            My.Settings.VirtualSpace = VirtualSpace.Checked
            My.Settings.WideCaret = WideCaret.Checked
            My.Settings.SyntaxHighlight = SyntaxHighlight.Checked
            My.Settings.LivePreview = LivePreview.Checked

            For Each page As TabPage In EditTabs.TabPages
                Dim point As New Point With {
                    .X = 0,
                    .Y = 0
                }
                Dim child = page.GetChildAtPoint(point, GetChildAtPointSkip.None)
                If TypeOf child Is Editor Then
                    Dim edit As Editor = child
                    edit.Code.WordWrap = My.Settings.WordWrap
                    edit.Code.VirtualSpace = My.Settings.VirtualSpace
                    edit.Code.WideCaret = My.Settings.WideCaret
                    edit.Code.Font = My.Settings.editorFont
                    edit.LivePreview.Checked = My.Settings.LivePreview
                End If
            Next
    End Sub
    Public Sub openEditor(ByVal path As String)
        EditTabs.SuspendLayout()

        Dim tab As New TabPage With {
            .Tag = path,
            .BackColor = Color.White,
            .ToolTipText = path,
            .Text = path.Replace(SiteTree.Nodes.Item(0).Text & "\", "")
        }
        EditTabs.TabPages.Add(tab)
        EditTabs.SelectedTab = tab
        Dim game As Boolean = False
        For Each species In EverySpeciesofNeopet
            If tab.Text.EndsWith("\" & species & ".ts") Then
                game = True
                Exit For
            End If
        Next
        If game Then
            Dim cheat As New CheatGame With {
                .Parent = tab,
                .Dock = DockStyle.Fill
            }
        Else
            ' Actual editor code is here
            Dim editor As New Editor With {
                .Parent = tab,
                .Dock = DockStyle.Fill
            }
            editor.Code.Text = editor.ReadAllText(tab.Tag)
            editor.Code.ClearUndo()
            editor.Snapshot = editor.Code.Text
            editor.siteRoot = SiteTree.Nodes.Item(0).Text
            editor.openFile = tab.Tag
            If tab.Text.StartsWith("templates\") Then
                editor.ViewOutput.Visible = False
                editor.Preview.Text = My.Resources.UI_Editor_ViewFile
            End If
            If tab.Text.StartsWith("includes\") Then
                editor.InsertConditional.Enabled = False
                editor.Preview.Text = My.Resources.UI_Editor_ViewFile
            End If
            openFiles.Add(path)
        End If

        EditTabs.ResumeLayout()
    End Sub

    Public Sub browseForSite(ByVal n As Boolean)
        If FolderBrowser.ShowDialog(Me) = DialogResult.OK Then
            If My.Computer.FileSystem.DirectoryExists(FolderBrowser.SelectedPath) Then
                openSite(FolderBrowser.SelectedPath, False)
            End If
            If n Then
                If QuickstartMnu.Enabled Then
                    Dim q As New Quickstart
                    q.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Sub NewSite_Click(sender As Object, e As EventArgs) Handles NewSite.Click, NewSiteBtn.Click
        browseForSite(True)
    End Sub

    Private Sub OpenFolder_Click(sender As Object, e As EventArgs) Handles OpenFolder.Click, OpenSiteBtn.Click
        browseForSite(False)
    End Sub

    Private Sub AboutItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutItem.Click
        Dim abt As New About
        abt.ShowDialog(Me)
    End Sub

    Private Function doClose() Handles CloseSite.Click
        Dim saved = True
        For Each page As TabPage In EditTabs.TabPages
            If page.Text.Contains("*") Then
                saved = False
            End If
        Next
        If Not saved Then
            Dim d As DialogResult = MsgBox(My.Resources.Prompt_SaveFilesBeforeClosing, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel)

            If d = DialogResult.Yes Then
                DoSaveAll()
            End If
            If d = DialogResult.Cancel Then
                Return False
            End If
        End If
        openFiles.Clear()
        SiteTree.Nodes.Clear()
        Me.Text = wTitle
        EditTabs.TabPages.Clear()
        AttributeTree.Nodes.Clear()
        Preview.DocumentText = ""
        My.Settings.openProject = ""
        Watcher.EnableRaisingEvents = False
        Watcher.Filter = ""

        Dim tab As New TabPage With {
            .Text = My.Resources.UI_StartPage_Title
        }
        Dim start As New StartPage With {
            .Parent = tab,
            .Dock = DockStyle.Fill
        }
        tab.Parent = EditTabs
        checkOpen()
        Return True
    End Function

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
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LanguageMenu.Text = "🌐 " & Threading.Thread.CurrentThread.CurrentUICulture.Name
        loadTheme()

        If System.Environment.Version.Major < 4 Then
            WelshLang.Enabled = False
            WelshLang.Text &= " (.NET 4.0)"
        End If

        Try
            ' https://www.codeproject.com/Tips/543631/Save-and-restore-your-form-size-and-location
            Dim initLocation As String = My.Settings.windowLocation
            Dim il As Point = New Point(0, 0)
            Dim sz As Size = Size

            If Not initLocation Is Nothing Then
                Dim parts As String() = initLocation.Split(",")

                If parts.Length >= 2 Then
                    il = New Point(Integer.Parse(parts(0)), Integer.Parse(parts(1)))
                End If

                If parts.Length >= 4 Then
                    sz = New Size(Integer.Parse(parts(2)), Integer.Parse(parts(3)))
                End If

                Me.Size = sz

                If My.Computer.Screen.Bounds.Contains(il) Then
                    Me.Location = il
                End If
            End If
        Catch ex As Exception
        End Try

        If My.Settings.maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If

        ExSplit.SplitterDistance = My.Settings.exSplitterDistance
        EdSplit.SplitterDistance = My.Settings.edSplitterDistance
        CoreSplit.SplitterDistance = My.Settings.coreSplitterDistance

        Try
            Dim key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", True)
            key.SetValue(Path.GetFileName(Application.ExecutablePath), 11001, Microsoft.Win32.RegistryValueKind.DWord)
            key.Close()
        Catch ex As Exception
        End Try

        Me.Font = getFont()

        updatewTitle()

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

        If ((EdSplit.Panel1Collapsed = True) And (EdSplit.Panel2Collapsed = True)) Or (Not My.Settings.browserOpen And Not My.Settings.editorOpen) Then
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

        ' prep icons
        XP.Images.Clear()
        VS2017.Images.Clear()

        XP.Images.Add("Folder", My.Resources.XP_Folder)
        XP.Images.Add("Template", My.Resources.XP_Template)
        XP.Images.Add("Page", My.Resources.XP_Page)
        XP.Images.Add("Include", My.Resources.XP_Include)
        XP.Images.Add("Build", My.Resources.Build)
        XP.Images.Add("Attribute", My.Resources.Tag)
        XP.Images.Add("Value", My.Resources.Value)

        VS2017.Images.Add("Folder", My.Resources.Folder)
        VS2017.Images.Add("Template", My.Resources.Template)
        VS2017.Images.Add("Page", My.Resources.Page)
        VS2017.Images.Add("Include", My.Resources.Include)
        VS2017.Images.Add("Build", My.Resources.Build)
        VS2017.Images.Add("Attribute", My.Resources.Tag)
        VS2017.Images.Add("Value", My.Resources.Value)

        loadIconTheme()
        checkOpen()

        WordWrap.Checked = My.Settings.WordWrap
        VirtualSpace.Checked = My.Settings.VirtualSpace
        WideCaret.Checked = My.Settings.WideCaret
        SyntaxHighlight.Checked = My.Settings.SyntaxHighlight
        LivePreview.Checked = My.Settings.LivePreview
        SystemIcons.Checked = My.Settings.systemIcons

        If args.Length > 1 Then
            My.Settings.openProject = args(1)
        End If
        If My.Computer.FileSystem.DirectoryExists(My.Settings.openProject) Then
            openSite(My.Settings.openProject, True)
        Else
            Dim tab As New TabPage With {
                .Text = My.Resources.UI_StartPage_Title
            }
            Dim start As New StartPage With {
                .Dock = DockStyle.Fill,
                .Parent = tab
            }
            tab.Parent = EditTabs
        End If

        BuildStrip.Renderer = New OverrideControls.ToolStripOverride()

        updateRecents()
        panelUpdate()
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
            Try
                If sender.Name = "AttributeTree" Then
                    FindNodeTag(SiteTree.Nodes(0), e.Node.Tag)
                    If Not foundNode Is Nothing Then
                        foundNode.TreeView.SelectedNode = foundNode
                    End If
                End If
            Catch ex As Exception
            End Try
            If My.Computer.FileSystem.FileExists(e.Node.Tag) Then
                If Not EditorPanel.Checked Then
                    Process.Start(e.Node.Tag)
                    Exit Sub
                End If
                Try
                    If openFiles.Contains(e.Node.Tag) Then
                        For Each page As TabPage In EditTabs.TabPages
                            If page.Tag = e.Node.Tag Then
                                EditTabs.SelectedTab = page
                            End If
                        Next
                    Else
                        Dim edit = False
                        If e.Node.Text.StartsWith(".") Then
                            edit = True
                        Else
                            For Each extension In editExtensions
                                If e.Node.Text.EndsWith(extension) Or e.Node.Text = extension Then
                                    edit = True
                                    Exit For
                                End If
                            Next
                        End If
                        If EditorPanel.Enabled = False Then
                            edit = False
                        End If
                        If edit Then
                            openEditor(e.Node.Tag)
                        Else
                            Process.Start(e.Node.Tag)
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
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

    Private Sub StatusBarMnu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarMnu.Click
        If StatusBarMnu.Checked Then
            StatusBarMnu.Checked = False
        Else
            StatusBarMnu.Checked = True
        End If
        panelUpdate()
    End Sub

    Private Sub VS2017item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VS2017item.Click
        If Not VS2017item.Checked Then
            My.Settings.iconTheme = "vs2017"
        End If
        loadIconTheme()
    End Sub

    Private Sub XPitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XPitem.Click
        If Not XPitem.Checked Then
            My.Settings.iconTheme = "xp"
        End If
        loadIconTheme()
    End Sub

    Private Sub SiteTree_BeforeLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles SiteTree.BeforeLabelEdit
        If e.Node.Tag = "" Then
            e.CancelEdit = True
        End If
        If e.Node.Level < 2 Then    ' don't edit root nodes
            e.CancelEdit = True
        End If
    End Sub

    Private Sub SiteTree_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles SiteTree.AfterLabelEdit
        Try
            Dim oldpath = e.Node.Tag
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

            If Not e.CancelEdit Then
                iterateUpdateNodePaths(e.Node, oldpath, newpath)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub iterateUpdateNodePaths(node As TreeNode, oldpath As String, newpath As String)
        node.Tag = Apricot.ReplaceFirst(node.Tag, oldpath, newpath) 'update path/tag
        node.Text = node.Tag.Split("\")(UBound(node.Tag.Split("\"))) 'update text

        'update editors
        For Each t As TabPage In EditTabs.TabPages
            For Each c In t.Controls
                If c.GetType() Is GetType(Editor) Then
                    Dim edit As Editor = c
                    If edit.openFile.Contains(oldpath) Then
                        openFiles.Remove(edit.openFile)
                        edit.openFile = Apricot.ReplaceFirst(edit.openFile, oldpath, newpath)
                        t.Tag = edit.openFile
                        openFiles.Add(edit.openFile)

                        If t.Text.Contains("*") Then
                            t.Text = edit.openFile.Replace(SiteTree.Nodes(0).Text & "\", "") & "*"
                        Else
                            t.Text = edit.openFile.Replace(SiteTree.Nodes(0).Text & "\", "")
                        End If
                    End If
                End If
            Next
        Next

        'iterate for children nodes
        For Each subnode As TreeNode In node.Nodes
            iterateUpdateNodePaths(subnode, oldpath, newpath)
        Next
    End Sub

    Private Sub ExitItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitItem.Click
        Me.Close()
    End Sub

    Public Sub doBuild() Handles BuildSite.Click, Build.Click, BuildBtn.ButtonClick
        Log.Clear()
        AttributeTree.Nodes.Clear()
        AttributeTree.BeginUpdate()
        Try
            ApricotWorker.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(String.Format(My.Resources.Error_BuildFailed, ex.ToString), MsgBoxStyle.Exclamation, My.Resources.Error_BuildFailed_Title)
        End Try
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
                    NewTXTCon.Enabled = True
                End If
                If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(1).Tag) Then
                    NewFolderCon.Enabled = False
                    NewHTMLCon.Enabled = True
                    NewMDCon.Enabled = False
                    NewPHPCon.Enabled = False
                    NewCSSCon.Enabled = False
                    NewJSCon.Enabled = False
                    NewTXTCon.Enabled = False
                End If
                If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(2).Tag) Then
                    NewFolderCon.Enabled = True
                    NewHTMLCon.Enabled = True
                    NewMDCon.Enabled = True
                    NewPHPCon.Enabled = True
                    NewCSSCon.Enabled = True
                    NewJSCon.Enabled = True
                    NewTXTCon.Enabled = True
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
                    If Watcher.EnableRaisingEvents = False Then
                        refreshTree(SiteTree.Nodes(0))
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MarkDeletedAsUnsaved()
        For Each t As TabPage In EditTabs.TabPages
            For Each c In t.Controls
                If c.GetType() Is GetType(Editor) Then
                    Dim edit As Editor = c
                    If Not My.Computer.FileSystem.FileExists(edit.openFile) Then
                        If Not t.Text.Contains("*") Then
                            t.Text &= "*"
                            edit.SaveBtn.Enabled = True
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub deleteFile(ByVal path As String)
        If My.Computer.FileSystem.DirectoryExists(path) Then
            Try
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf My.Computer.FileSystem.FileExists(path) Then
            Try
                My.Computer.FileSystem.DeleteFile(path, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Catch ex As Exception
            End Try
        End If
        MarkDeletedAsUnsaved()
        If Watcher.EnableRaisingEvents = False Then
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub DeleteCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCon.Click
        deleteFile(Context.Tag)
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
        End If
        If Watcher.EnableRaisingEvents = False Then  ' Refresh tree if FilesystemWatcher is not active
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub NewFile(ByVal base As String, ByVal ext As String, ByVal contents As String)
        fileAddContext = "rename"
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(Context.Tag) Then
            dir = Context.Tag
        ElseIf My.Computer.FileSystem.FileExists(Context.Tag) Then
            dir = My.Computer.FileSystem.GetFileInfo(Context.Tag).DirectoryName
        End If
        Dim num = 0
        Dim add = ""
        While My.Computer.FileSystem.FileExists(System.IO.Path.Combine(dir, base & add & ext))
            num += 1
            add = " (" & num & ")"
        End While
        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(dir, base & add & ext), contents, False)
        If Watcher.EnableRaisingEvents = False Then  ' Refresh tree if FilesystemWatcher is not active
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub NewHTMLCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewHTMLCon.Click, NewPageToolStripMenuItem.Click
        Dim dir = ""
        If My.Computer.FileSystem.DirectoryExists(Context.Tag) Then
            dir = Context.Tag
        ElseIf My.Computer.FileSystem.FileExists(Context.Tag) Then
            dir = My.Computer.FileSystem.GetFileInfo(Context.Tag).DirectoryName
        End If

        Dim html = My.Resources.Defaults_NewHtmlPage_Contents ' Page

        If dir.Contains(SiteTree.Nodes(0).Nodes(1).Tag) Then ' Template

            html = My.Resources.Defaults_NewHtmlTemplate_Contents

        ElseIf dir.Contains(SiteTree.Nodes(0).Nodes(2).Tag) Then ' Include

            html = My.Resources.Defaults_NewHtmlInclude_Contents

        End If

        If dir.Contains(SiteTree.Nodes(0).Nodes(1).Tag) And Not My.Computer.FileSystem.FileExists(SiteTree.Nodes(0).Nodes(1).Tag & "\default.html") Then ' Template
            NewFile("default", ".html", html)
        Else
            NewFile(My.Resources.Defaults_NewHtml, ".html", html)
        End If
    End Sub

    Private Sub NewMDCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMDCon.Click, NewMarkdownPageToolStripMenuItem.Click
        If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(0).Tag) Then ' check if page, otherwise empty
            NewFile(My.Resources.Defaults_NewMd, ".md", My.Resources.Defaults_NewMdPage_Contents)
        Else
            NewFile(My.Resources.Defaults_NewMd, ".md", "")
        End If
    End Sub

    Private Sub NewPHPCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPHPCon.Click
        If Context.Tag.Contains(SiteTree.Nodes(0).Nodes(0).Tag) Then ' check if page, otherwise other default
            NewFile(My.Resources.Defaults_NewMd, ".php", My.Resources.Defaults_NewPhpPage_Contents)
        Else
            NewFile(My.Resources.Defaults_NewMd, ".php", My.Resources.Defaults_NewPhpOther_Contents)
        End If
    End Sub

    Private Sub NewCSSCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCSSCon.Click, NewStylesheetToolStripMenuItem.Click
        NewFile(My.Resources.Defaults_NewCss, ".css", "")
    End Sub

    Private Sub NewJSCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewJSCon.Click, NewJavaScriptToolStripMenuItem.Click
        NewFile(My.Resources.Defaults_NewJs, ".js", "")
    End Sub

    Private Sub NewTXTCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTXTCon.Click, NewTextFileToolStripMenuItem.Click
        NewFile(My.Resources.Defaults_NewFile, ".txt", "")
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
            AddFilesDialog.Title = String.Format(My.Resources.UI_AddFilesDialog_Title, dir)
            If AddFilesDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                For Each file In AddFilesDialog.FileNames
                    Try
                        My.Computer.FileSystem.CopyFile(file, System.IO.Path.Combine(dir, System.IO.Path.GetFileName(file)))
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next
                If Watcher.EnableRaisingEvents = False Then
                    refreshTree(SiteTree.Nodes(0))
                End If
            End If
        End If
    End Sub

    Private Sub Apricot_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ApricotWorker.DoWork
        Apricot.buildSite(SiteTree.Nodes(0).Text, ApricotWorker)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ApricotWorker.ProgressChanged
        AttributeExplanation.Visible = (AttributeTree.Nodes.Count < 1)
        If e.UserState.GetType() Is GetType(System.String) Then
            'ToolStripProgressBar1.Value = e.ProgressPercentage
            BuildProgress.Visible = True
            BuildSite.Enabled = False
            Build.Enabled = False
            SanitaryBuild.Enabled = False
            SanitaryBuildBtn.Enabled = False
            BuildProgress.Value = e.ProgressPercentage
            Dim s As String = e.UserState
            Dim start = Log.TextLength
            Log.AppendText(e.UserState & Environment.NewLine)
            Dim length = Log.TextLength - start
            Log.Select(start, length)
            If s.StartsWith("Rendering") Then
                Log.SelectionFont = New Font(Log.Font, FontStyle.Italic + FontStyle.Underline)
            End If
            If s.Contains(":") Then
                Log.SelectionColor = Color.Green
            Else
                ApriStatus.Text = e.UserState
            End If
            If s.Contains("WARN:") Then
                Log.SelectionColor = Color.OrangeRed
            End If
            If s.StartsWith("Apricot") Or s.StartsWith("Finished") Or s.StartsWith("Started") Then
                Log.SelectionFont = New Font(Log.Font, FontStyle.Bold)
                Log.SelectionColor = Color.Blue
            End If
            Log.DeselectAll()
        ElseIf e.UserState.GetType() Is GetType(Apricot.TNode) Then
            Dim tn As Apricot.TNode = e.UserState

            Dim aNode As New TreeNode
            Dim exists As Boolean = False
            For Each node As TreeNode In AttributeTree.Nodes
                If node.Text = tn.Attribute Then
                    aNode = node
                    exists = True
                End If
            Next

            If Not exists Then
                aNode = New TreeNode With {
                    .Text = tn.Attribute,
                    .ImageKey = "Attribute",
                    .SelectedImageKey = "Attribute"
                }
                AttributeTree.Nodes.Add(aNode)
            End If

            Dim vNode As New TreeNode
            Dim txt = tn.Value

            exists = False
            For Each node As TreeNode In aNode.Nodes
                If node.Text = txt Then
                    vNode = node
                    exists = True
                End If
            Next

            If Not exists Then
                vNode = New TreeNode With {
                    .Text = txt,
                    .ImageKey = "Value",
                    .SelectedImageKey = "Value"
                }
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
                rPath = Apricot.ReplaceFirst(rPath, folderName & "\", "")
            End While

            Dim fNode As New TreeNode With {
                .Text = rPath,
                .ImageKey = "Page",
                .SelectedImageKey = "Page",
                .Tag = Path.Combine(SiteTree.Nodes(0).Text, "pages\" & tn.relPath)
            }

            Dim add = True
            For Each node As TreeNode In pNode.Nodes
                If node.Tag = fNode.Tag Then
                    add = False
                End If
            Next
            If add Then
                pNode.Nodes.Add(fNode)
            End If
        End If
    End Sub

    Private Sub Apricot_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ApricotWorker.RunWorkerCompleted
        AttributeTree.EndUpdate()
        BuildProgress.Visible = False
        Build.Enabled = True
        BuildSite.Enabled = True
        SanitaryBuild.Enabled = True
        SanitaryBuildBtn.Enabled = True

        If afterBuildNavigatePreview.Length > 0 Then
            Preview.Navigate(afterBuildNavigatePreview)
        ElseIf afterBuildLaunch.Length > 0 Then
            Process.Start(afterBuildLaunch)
        End If
        afterBuildLaunch = ""
        afterBuildNavigatePreview = ""
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim saved = True
        For Each page As TabPage In EditTabs.TabPages
            If page.Text.Contains("*") Then
                saved = False
            End If
        Next
        If Not saved Then
            Dim d As DialogResult = MsgBox(My.Resources.Prompt_SaveFilesBeforeClosing, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel)

            If d = DialogResult.Yes Then
                DoSaveAll()
            End If
            If d = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If

        ' https://www.codeproject.com/Tips/543631/Save-and-restore-your-form-size-and-location
        If Not e.Cancel Then
            Try
                Dim location As Point = Me.Location
                Dim size As Size = Me.Size
                Dim state As Windows.Forms.FormWindowState = Me.WindowState

                If Not state = FormWindowState.Normal Then
                    location = RestoreBounds.Location
                    size = RestoreBounds.Size
                End If

                My.Settings.windowLocation = location.X & "," & location.Y & "," & size.Width & "," & size.Height
                My.Settings.maximized = (state = FormWindowState.Maximized)
                My.Settings.edSplitterDistance = EdSplit.SplitterDistance
                My.Settings.exSplitterDistance = ExSplit.SplitterDistance
                My.Settings.coreSplitterDistance = CoreSplit.SplitterDistance

                My.Settings.Save()
            Catch ex As Exception
            End Try
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

    Public Sub DoSaveAll() Handles SaveAll.Click, SaveAllBtn.Click
        For Each page As TabPage In EditTabs.TabPages
            Dim point As New Point With {
                .X = 0,
                .Y = 0
            }
            Dim child = page.GetChildAtPoint(point, GetChildAtPointSkip.None)
            If TypeOf child Is Editor Then
                Dim edit As Editor = child
                edit.Save()
            End If
        Next
    End Sub

    Private Sub OpenDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOutput.Click, OpenOutputMnu.Click, OpenOutputFolderBtn.Click
        Try
            Process.Start(SiteTree.Nodes(0).Text & "\out\")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BrowseOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseSitePreview.Click, BrowseSitePreviewMnu.Click
        If Not PreviewPanel.Checked Then
            PreviewPanel.Checked = True
            panelUpdate()
        End If
        If My.Computer.FileSystem.FileExists(SiteTree.Nodes(0).Text & "\out\index.html") Then
            Preview.Navigate(SiteTree.Nodes(0).Text & "\out\index.html")
        ElseIf My.Computer.FileSystem.FileExists(SiteTree.Nodes(0).Text & "\out\index.phtml") Then
            Preview.Navigate(SiteTree.Nodes(0).Text & "\out\index.phtml", False)
        ElseIf My.Computer.FileSystem.FileExists(SiteTree.Nodes(0).Text & "\out\index.php") Then
            Preview.Navigate(SiteTree.Nodes(0).Text & "\out\index.php", False)
        Else
            If My.Computer.FileSystem.DirectoryExists(SiteTree.Nodes(0).Text & "\out\") Then
                Dim html = My.Computer.FileSystem.GetFiles(SiteTree.Nodes(0).Text & "\out\", FileIO.SearchOption.SearchAllSubDirectories, "*.html")
                If html.Count > 0 Then
                    Preview.Navigate(html.Item(0))
                Else
                    Preview.Navigate(SiteTree.Nodes(0).Text & "\out\")
                End If
            End If
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
        If e.Name.StartsWith("pages\") Then
            Dim f = Apricot.ReplaceFirst(e.Name, "pages\", "")
            Dim pnode As TreeNode = pages
            While f.Contains("\")
                Dim pdir = f.Split("\")(0)
                f = Apricot.ReplaceFirst(f, pdir & "\", "")
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
            pnode.Expand()
            If fileAddContext = "rename" Then
                fileAddContext = ""
                node.BeginEdit()
            End If
        ElseIf e.Name.StartsWith("templates\") Then
            Dim f = Apricot.ReplaceFirst(e.Name, "templates\", "")
            Dim pnode As TreeNode = templates
            While f.Contains("\")
                Dim pdir = f.Split("\")(0)
                f = Apricot.ReplaceFirst(f, pdir & "\", "")
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
            pnode.Expand()
            If fileAddContext = "rename" Then
                fileAddContext = ""
                node.BeginEdit()
            End If
        ElseIf e.Name.StartsWith("includes\") Then
            Dim f = Apricot.ReplaceFirst(e.Name, "includes\", "")
            Dim pnode As TreeNode = includes
            While f.Contains("\")
                Dim pdir = f.Split("\")(0)
                f = Apricot.ReplaceFirst(f, pdir & "\", "")
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
            pnode.Expand()
            If fileAddContext = "rename" Then
                fileAddContext = ""
                node.BeginEdit()
            End If
        End If
        If My.Settings.systemIcons Then
            Try
                Dim splt = node.Text.Split(".")
                Dim ext = splt(splt.Length - 1)
                If Not VS2017.Images.ContainsKey(ext) Then
                    Dim icon As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(node.Tag)
                    VS2017.Images.Add(ext, icon)
                    XP.Images.Add(ext, icon)
                End If
                node.ImageKey = ext
                node.SelectedImageKey = ext
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Watcher_Deleted(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles Watcher.Deleted
        foundNode = Nothing
        FindNodeTag(SiteTree.Nodes(0), e.FullPath)
        If Not foundNode Is Nothing Then
            foundNode.Remove()
        End If

        MarkDeletedAsUnsaved()
    End Sub

    Private Sub Watcher_Renamed(ByVal sender As System.Object, ByVal e As System.IO.RenamedEventArgs) Handles Watcher.Renamed
        foundNode = Nothing
        FindNodeTag(SiteTree.Nodes(0), e.OldFullPath)
        If Not foundNode Is Nothing Then
            iterateUpdateNodePaths(foundNode, e.OldFullPath, e.FullPath)
        End If
    End Sub

    Private Sub Rename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameCon.Click
        foundNode = Nothing
        FindNodeTag(SiteTree.Nodes(0), Context.Tag)
        If Not foundNode Is Nothing Then
            foundNode.BeginEdit()
        End If
    End Sub

    Private Sub BrowseOutputExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseSite.Click
        Dim path = SiteTree.Nodes(0).Text & "\out\"
        If My.Computer.FileSystem.FileExists(path & "index.html") Then
            path &= "index.html"
        End If
        If My.Computer.FileSystem.FileExists(path & "index.htm") Then
            path &= "index.htm"
        End If
        Try
            Process.Start(path)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ViewinDefaultBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewinDefaultBrowser.Click
          Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doViewinDefaultBrowser()
        End If
    End Sub

    Private Sub AttributeTree_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles AttributeTree.ItemDrag
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If e.Item.SelectedImageKey = "Attribute" Then
                DoDragDrop("[#" & e.Item.Text & "#]", DragDropEffects.Link)
            ElseIf e.Item.SelectedImageKey = "Value" Then
                DoDragDrop("<!-- attrib " & e.Item.Parent.Text & ": " & e.Item.Text & " -->", DragDropEffects.Link)
            End If
        End If
    End Sub

    Private Sub EditorFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditorFont.Click
        SelectFont.Font = My.Settings.editorFont
        If SelectFont.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            My.Settings.editorFont = SelectFont.Font
            panelUpdate()
        End If
    End Sub

    Private Sub SiteTree_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SiteTree.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                deleteFile(SiteTree.SelectedNode.Tag)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Sub doSanitaryBuild() Handles SanitaryBuild.Click, SanitaryBuildBtn.Click, CleanBuildBtn.Click
        If MsgBox(My.Resources.Prompt_SanitaryBuild, MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Try
                My.Computer.FileSystem.DeleteDirectory(SiteTree.Nodes(0).Text & "\out", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            doBuild()
        End If
    End Sub

    Sub updateRecents()
        Try
            OpenRecent.Enabled = My.Settings.recents.Count > 0
            Recent1.Visible = My.Settings.recents.Count > 0
            Recent2.Visible = My.Settings.recents.Count > 1
            Recent3.Visible = My.Settings.recents.Count > 2
            Recent4.Visible = My.Settings.recents.Count > 3
            Recent5.Visible = My.Settings.recents.Count > 4
            If My.Settings.recents.Count > 0 Then
                Recent1.Text = "1. " & My.Settings.recents(0)
                Recent1.Tag = My.Settings.recents(0)
            End If
            If My.Settings.recents.Count > 1 Then
                Recent2.Text = "2. " & My.Settings.recents(1)
                Recent2.Tag = My.Settings.recents(1)
            End If
            If My.Settings.recents.Count > 2 Then
                Recent3.Text = "3. " & My.Settings.recents(2)
                Recent3.Tag = My.Settings.recents(2)
            End If
            If My.Settings.recents.Count > 3 Then
                Recent4.Text = "4. " & My.Settings.recents(3)
                Recent4.Tag = My.Settings.recents(3)
            End If
            If My.Settings.recents.Count > 4 Then
                Recent5.Text = "5. " & My.Settings.recents(4)
                Recent5.Tag = My.Settings.recents(4)
            End If
        Catch ex As Exception
            OpenRecent.Enabled = False
            My.Settings.recents = New System.Collections.Specialized.StringCollection
        End Try
    End Sub

    Private Sub Recent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recent1.Click, Recent2.Click, Recent3.Click, Recent4.Click, Recent5.Click
        If My.Computer.FileSystem.DirectoryExists(sender.tag) Then
            openSite(sender.Tag, False)
        Else
            If MsgBox(String.Format(My.Resources.Question_RemoveFromRecents, sender.Tag), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Application.ProductName) = MsgBoxResult.Yes Then
                My.Settings.recents.Remove(sender.Tag)
                updateRecents()
            End If
        End If
    End Sub

    Private Sub ClearRecents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearRecents.Click
        My.Settings.recents = New System.Collections.Specialized.StringCollection
        updateRecents()
    End Sub

    Private Sub SendFeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendFeedback.Click
        Process.Start("https://github.com/dotcomboom/AutoSite/issues")
    End Sub

    Private Function activeEditor()
        If EditTabs.TabCount > 0 Then
            For Each c In EditTabs.SelectedTab.Controls
                If c.GetType() Is GetType(Editor) Then
                    Dim edit As Editor = c
                    Return edit
                End If
            Next
        End If
        Return Nothing
    End Function

    Private Sub EditMenu_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Popup
        Dim edit As Editor = activeEditor()
        If edit Is Nothing Then
            For Each item As MenuItem In EditMenu.MenuItems
                item.Enabled = False
            Next
        Else
            For Each item As MenuItem In EditMenu.MenuItems
                item.Enabled = True
            Next
            Undo.Enabled = edit.Undo.Enabled
            Redo.Enabled = edit.Redo.Enabled
            'Delete.Enabled = False
            Cut.Enabled = edit.Code.SelectionLength > 0
            Copy.Enabled = edit.Code.SelectionLength > 0
            Paste.Enabled = My.Computer.Clipboard.ContainsText
        End If
    End Sub

    Private Sub ViewMenu_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMenu.Popup
        Dim edit = activeEditor()
        If edit Is Nothing Then
            PreviewPage.Enabled = False
            ViewFileOutput.Enabled = False
        Else
            PreviewPage.Enabled = True
            ViewFileOutput.Enabled = True
        End If
    End Sub

    Private Sub FileMenu_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu.Popup
        Dim edit = activeEditor()
        If edit Is Nothing Then
            Save.Enabled = False
            CloseFile.Enabled = False
        Else
            Save.Enabled = True
            CloseFile.Enabled = True
        End If
    End Sub

    Private Sub Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Undo.Click, UndoBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doUndo()
        End If
    End Sub

    Public EverySpeciesofNeopet As String() = {"Acara", "Aisha", "Blumaroo", "Bori", "Bruce", "Buzz", "Chia", "Chomby", "Cybunny", "Draik", "Elephante", "Eyrie", "Flotsam", "Gelert", "Gnorbu", "Grarrl", "Grundo", "Hissi", "Ixi", "Jetsam", "JubJub", "Kacheek", "Kau", "Kiko", "Koi", "Korbat", "Kougra", "Krawk", "Kyrii", "Lenny", "Lupe", "Lutari", "Meerca", "Moehog", "Mynci", "Nimmo", "Ogrin", "Peophin", "Poogle", "Pteri", "Quiggle", "Ruki", "Scorchio", "Shoyru", "Skeith", "Techo", "Tonu", "Tuskaninny", "Uni", "Usul", "Vandagyre", "Wocky", "Xweetok", "Yurble", "Zafara"}

    Private Sub Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Redo.Click, RedoBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doRedo()
        End If
    End Sub

    Private Sub Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cut.Click, CutBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doCut()
        End If
    End Sub

    Private Sub Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy.Click, CopyBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doCopy()
        End If
    End Sub

    Private Sub Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paste.Click, PasteBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doPaste()
        End If
    End Sub

    Private Sub SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAll.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doSelectAll()
        End If
    End Sub

    Private Sub InsertConditional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertConditional.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doInsertConditional()
        End If
    End Sub

    Private Sub Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find.Click, FindBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doFind()
        End If
    End Sub

    Private Sub Replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Replace.Click, ReplaceBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doReplace()
        End If
    End Sub

    Private Sub GoToMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToMnu.Click, GotoBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doGoto()
        End If
    End Sub

    Private Sub PreviewPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewBtn.ButtonClick
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doPreview()
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click, SaveBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.Save()
        End If
    End Sub

    Private Sub CloseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFile.Click, CloseBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.Close()
        End If
    End Sub

    Private Sub ViewFileOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOutBtn.ButtonClick
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doViewOutput()
        End If
    End Sub

    Private Sub Website_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Website.Click
        Process.Start("http://autosite.somnolescent.net")
    End Sub

    Private Sub GitHub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GitHub.Click
        Process.Start("https://github.com/dotcomboom/AutoSite")
    End Sub

    Private Sub OpenContext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenContext.Click
        If Not openFiles.Contains(Context.Tag) Then
            openEditor(Context.Tag)
        End If
    End Sub

    Private Sub Context_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Context.Popup
        Dim edit = False
        If Context.Tag.StartsWith(".") Then
            edit = True
        Else
            For Each extension In editExtensions
                If Context.Tag.EndsWith(extension) Or Context.Tag = extension Then
                    edit = True
                    Exit For
                End If
            Next
        End If
        If EdSplit.Panel1Collapsed Then
            edit = False
        End If
        OpenContext.Visible = edit
        OpenContext.DefaultItem = edit
        OpenInDefault.DefaultItem = Not edit

        If OpenContext.Visible = False Then
            OpenInDefault.Text = My.Resources.UI_Open
        Else
            OpenInDefault.Text = My.Resources.UI_OpenWithDefault
        End If

        If My.Computer.FileSystem.DirectoryExists(Context.Tag) Then
            OpenFileLocation.Text = My.Resources.UI_OpenFolderLocation
        Else
            OpenFileLocation.Text = My.Resources.UI_OpenFileLocation
        End If
    End Sub

    Private Sub SaveLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveLog.Click
        If SaveLogDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Try
                If SaveLogDialog.FileName.EndsWith(".rtf") Then
                    Log.SaveFile(SaveLogDialog.FileName)
                ElseIf SaveLogDialog.FileName.EndsWith(".html") Then
                    ' not yet implemented
                    My.Computer.FileSystem.WriteAllText(SaveLogDialog.FileName, Log.Text, False)
                Else
                    My.Computer.FileSystem.WriteAllText(SaveLogDialog.FileName, Log.Text, False)
                End If
            Catch ex As Exception
                MsgBox(String.Format(My.Resources.Error_LogSaveFail, ex.Message), MsgBoxStyle.Exclamation, My.Resources.Error_LogSaveFail_Title)
            End Try
        End If
    End Sub

    Private Sub MenuStripBridge_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LogMenuBridge.Opening
        LogMenu.Show(Log, Log.PointToClient(MousePosition))
        e.Cancel = True
    End Sub

    'Private Sub InstallPackMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallPackMnu.Click
    '    If OpenPack.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '        InstallPack.Pack = OpenPack.FileName
    '        InstallPack.ShowDialog()
    '        'UnZip(OpenPack.FileName, SiteTree.Nodes(0).Tag)
    '    End If
    'End Sub

    Private Sub SystemIcons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemIcons.Click
        SystemIcons.Checked = Not SystemIcons.Checked
        My.Settings.systemIcons = SystemIcons.Checked
        If SiteTree.Nodes.Count > 0 Then
            refreshTree(SiteTree.Nodes(0))
        End If
    End Sub

    Private Sub SiteTree_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles SiteTree.ItemDrag
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If e.Item.Tag.Contains(SiteTree.Nodes(0).Tag & "\pages\") Or e.Item.tag.contains(SiteTree.Nodes(0).Tag & "\includes\") Then
                Dim slash = ""
                If My.Computer.FileSystem.DirectoryExists(e.Item.tag) Then
                    slash = "/"
                End If
                Dim pth As String = e.Item.Tag.Replace(SiteTree.Nodes(0).Tag & "\pages\", "").Replace(SiteTree.Nodes(0).Tag & "\includes\", "").Replace("\", "/")
                If e.Item.Tag.Contains(SiteTree.Nodes(0).Tag & "\pages\") Then
                    pth = Apricot.ReplaceLast(pth, ".md", ".html")
                End If
                DoDragDrop("[#root#]" & pth & slash, DragDropEffects.Link)
            End If
        End If
    End Sub

    Private Sub AttributeTree_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles AttributeTree.Layout
        AttributeExplanation.Visible = (AttributeTree.Nodes.Count < 1)
    End Sub

    Private Sub QuickstarMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickstartMnu.Click
        Dim q As New Quickstart
        q.ShowDialog()
    End Sub

    Private Sub QuickInsertMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickInsertMnu.Click, InsertBtn.Click
        Dim edit As Editor = activeEditor()
        If Not edit Is Nothing Then
            edit.doQuickInsert()
        End If
    End Sub

    Shared Function getFont() As Drawing.Font
        Dim uiFont = New Font("Segoe UI", 9, FontStyle.Regular)
        If Not uiFont.Name = "Segoe UI" Then
            uiFont = SystemFonts.DefaultFont
        End If
        Return uiFont
    End Function

    Private Sub InspectorBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspectorBtn.Click  ' F12 when enabled
        Inspector.Show()
        Inspector.TopMost = True
        Inspector.TopMost = False
    End Sub

    Private Sub setTheme(ByVal bk As Color, ByVal fc As Color, Optional ByVal mebk As Color = Nothing)
        If Not mebk = Nothing Then
            Me.BackColor = mebk
            BuildStrip.BackColor = mebk
        Else
            Me.BackColor = bk
            BuildStrip.BackColor = bk
        End If

        AttributeTree.BackColor = bk
        AttributeTree.ForeColor = fc

        MapPage.BackColor = bk

        LogPage.BackColor = bk
        Log.BackColor = bk
        Log.ForeColor = fc

        SiteTree.BackColor = bk
        SiteTree.ForeColor = fc
        SiteTree.HotTracking = False

        Me.ForeColor = fc

        Me.Refresh()
    End Sub

    Private Sub cDark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cDark.Click
        My.Settings.theme = "Dark"
        loadTheme()
    End Sub

    Private Sub cDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cDefault.Click
        My.Settings.theme = ""
        loadTheme()
    End Sub

    Private Sub loadTheme()
        cDefault.Checked = False
        cDark.Checked = False
        If My.Settings.theme = "Dark" Then
            setTheme(Color.FromArgb(61, 61, 61), Color.White)
            cDark.Checked = True
        Else
            setTheme(Color.White, SystemColors.ControlText, SystemColors.Control)
            cDefault.Checked = True
        End If
    End Sub

    Private Sub ChangeLanguage_Click(sender As System.Object, e As System.EventArgs) Handles EnglishLang.Click, SpanishLang.Click, PolishLang.Click, WelshLang.Click
        My.Settings.language = sender.Tag
        MsgBox(My.Resources.Prompt_ChangesOnRestart, MsgBoxStyle.Information, Application.ProductName) ' Added ProductName because for some reason my installed version of .NET (4.8?) has System.Windows.Forms as the title/caption by default
    End Sub

    Private Sub ShowVersion_Click(sender As System.Object, e As System.EventArgs) Handles ShowVersion.Click
        My.Settings.showVersion = Not My.Settings.showVersion
        updatewTitle()
    End Sub

    Private Sub updatewTitle()
        ShowVersion.Checked = My.Settings.showVersion

        Dim oldwtitle As String = wTitle
        wTitle = "AutoSite"
        If My.Settings.showVersion Then
            wTitle &= " " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
            If My.Application.Info.Version.Build > 0 Then
                wTitle &= "." & My.Application.Info.Version.Build
            End If
            If My.Application.Info.Version.Revision > 0 Then
                wTitle &= "." & My.Application.Info.Version.Revision
            End If
            wTitle &= " " & My.Application.Info.Description
        End If
        Me.Text = Me.Text.Replace(oldwtitle, wTitle)
    End Sub

    Public Sub Preview_Navigate(url As String)
        ' hooked into by editor
        Preview.Navigate(url)

        If Not PreviewPanel.Checked Then
            PreviewPanel.Checked = True
            panelUpdate()
        End If
    End Sub

    Private Sub OpenFileLocation_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileLocation.Click
        Process.Start(Path.GetDirectoryName(Context.Tag))
    End Sub

    Private Sub HelpTopics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpTopics.Click
        Preview_Navigate(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SampleSite\out\manual\index.html"))
    End Sub

    Private Sub OpenSampleSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSampleSite.Click
        openSite(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "SampleSite"), False)
    End Sub

    Private Sub BuildShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildShortcut.Click
        'Dim n As New SaveFileDialog
        'n.Title = "Save Build Shortcut"
        'n.Filter = "Shortcut (.lnk)|*.lnk"
        'n.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        'If n.ShowDialog = Windows.Forms.DialogResult.OK Then

        'End If
        ' TODO
    End Sub
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.VS2017 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.MenuBar = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem
        Me.OpenFolder = New System.Windows.Forms.MenuItem
        Me.OpenRecent = New System.Windows.Forms.MenuItem
        Me.Recent1 = New System.Windows.Forms.MenuItem
        Me.Recent2 = New System.Windows.Forms.MenuItem
        Me.Recent3 = New System.Windows.Forms.MenuItem
        Me.Recent4 = New System.Windows.Forms.MenuItem
        Me.Recent5 = New System.Windows.Forms.MenuItem
        Me.RecentSep = New System.Windows.Forms.MenuItem
        Me.ClearRecents = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.CloseSite = New System.Windows.Forms.MenuItem
        Me.SaveAll = New System.Windows.Forms.MenuItem
        Me.FileSep = New System.Windows.Forms.MenuItem
        Me.ExitItem = New System.Windows.Forms.MenuItem
        Me.ViewMenu = New System.Windows.Forms.MenuItem
        Me.ExplorerPanel = New System.Windows.Forms.MenuItem
        Me.BuildPanel = New System.Windows.Forms.MenuItem
        Me.EditorPanel = New System.Windows.Forms.MenuItem
        Me.PreviewPanel = New System.Windows.Forms.MenuItem
        Me.ViewMenuSep = New System.Windows.Forms.MenuItem
        Me.IconThemeMenu = New System.Windows.Forms.MenuItem
        Me.VS2017item = New System.Windows.Forms.MenuItem
        Me.XPitem = New System.Windows.Forms.MenuItem
        Me.RefreshItem = New System.Windows.Forms.MenuItem
        Me.FormatMenu = New System.Windows.Forms.MenuItem
        Me.WordWrap = New System.Windows.Forms.MenuItem
        Me.VirtualSpace = New System.Windows.Forms.MenuItem
        Me.WideCaret = New System.Windows.Forms.MenuItem
        Me.FormatMenuSep = New System.Windows.Forms.MenuItem
        Me.SyntaxHighlight = New System.Windows.Forms.MenuItem
        Me.LivePreview = New System.Windows.Forms.MenuItem
        Me.FormatSep2 = New System.Windows.Forms.MenuItem
        Me.EditorFont = New System.Windows.Forms.MenuItem
        Me.BuildMenu = New System.Windows.Forms.MenuItem
        Me.BuildSite = New System.Windows.Forms.MenuItem
        Me.SanitaryBuild = New System.Windows.Forms.MenuItem
        Me.BuildSep = New System.Windows.Forms.MenuItem
        Me.EngineApricot = New System.Windows.Forms.MenuItem
        Me.EnginePython = New System.Windows.Forms.MenuItem
        Me.HelpMenu = New System.Windows.Forms.MenuItem
        Me.AboutItem = New System.Windows.Forms.MenuItem
        Me.HelpTopics = New System.Windows.Forms.MenuItem
        Me.XP = New System.Windows.Forms.ImageList(Me.components)
        Me.Context = New System.Windows.Forms.ContextMenu
        Me.OpenInDefault = New System.Windows.Forms.MenuItem
        Me.ContextSep = New System.Windows.Forms.MenuItem
        Me.CopyCon = New System.Windows.Forms.MenuItem
        Me.PasteCon = New System.Windows.Forms.MenuItem
        Me.AddFilesCon = New System.Windows.Forms.MenuItem
        Me.ContextSep2 = New System.Windows.Forms.MenuItem
        Me.DeleteCon = New System.Windows.Forms.MenuItem
        Me.RenameCon = New System.Windows.Forms.MenuItem
        Me.ContextSep3 = New System.Windows.Forms.MenuItem
        Me.NewCon = New System.Windows.Forms.MenuItem
        Me.NewFolderCon = New System.Windows.Forms.MenuItem
        Me.NewSep = New System.Windows.Forms.MenuItem
        Me.NewHTMLCon = New System.Windows.Forms.MenuItem
        Me.NewMDCon = New System.Windows.Forms.MenuItem
        Me.NewPHPCon = New System.Windows.Forms.MenuItem
        Me.NewSep2 = New System.Windows.Forms.MenuItem
        Me.NewCSSCon = New System.Windows.Forms.MenuItem
        Me.NewJSCon = New System.Windows.Forms.MenuItem
        Me.NewTXTCon = New System.Windows.Forms.MenuItem
        Me.AddFilesDialog = New System.Windows.Forms.OpenFileDialog
        Me.Apricot = New System.ComponentModel.BackgroundWorker
        Me.Watcher = New System.IO.FileSystemWatcher
        Me.EdSplit = New System.Windows.Forms.SplitContainer
        Me.EditTabs = New System.Windows.Forms.TabControl
        Me.Preview = New System.Windows.Forms.WebBrowser
        Me.ExSplit = New System.Windows.Forms.SplitContainer
        Me.OpenLink = New System.Windows.Forms.LinkLabel
        Me.OpenPrompt = New System.Windows.Forms.Label
        Me.SiteTree = New System.Windows.Forms.TreeView
        Me.ApricotTabs = New System.Windows.Forms.TabControl
        Me.LogPage = New System.Windows.Forms.TabPage
        Me.Log = New System.Windows.Forms.RichTextBox
        Me.MapPage = New System.Windows.Forms.TabPage
        Me.AttributeTree = New System.Windows.Forms.TreeView
        Me.BuildProgress = New System.Windows.Forms.ProgressBar
        Me.BuildStrip = New System.Windows.Forms.ToolStrip
        Me.Build = New System.Windows.Forms.ToolStripButton
        Me.OpenOutput = New System.Windows.Forms.ToolStripButton
        Me.BrowseOutput = New System.Windows.Forms.ToolStripButton
        Me.BrowseOutputExt = New System.Windows.Forms.ToolStripButton
        Me.CoreSplit = New System.Windows.Forms.SplitContainer
        Me.SelectFont = New System.Windows.Forms.FontDialog
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EdSplit.Panel1.SuspendLayout()
        Me.EdSplit.Panel2.SuspendLayout()
        Me.EdSplit.SuspendLayout()
        Me.ExSplit.Panel1.SuspendLayout()
        Me.ExSplit.Panel2.SuspendLayout()
        Me.ExSplit.SuspendLayout()
        Me.ApricotTabs.SuspendLayout()
        Me.LogPage.SuspendLayout()
        Me.MapPage.SuspendLayout()
        Me.BuildStrip.SuspendLayout()
        Me.CoreSplit.Panel1.SuspendLayout()
        Me.CoreSplit.Panel2.SuspendLayout()
        Me.CoreSplit.SuspendLayout()
        Me.SuspendLayout()
        '
        'VS2017
        '
        Me.VS2017.ImageStream = CType(resources.GetObject("VS2017.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.VS2017.TransparentColor = System.Drawing.Color.Transparent
        Me.VS2017.Images.SetKeyName(0, "Folder")
        Me.VS2017.Images.SetKeyName(1, "Template")
        Me.VS2017.Images.SetKeyName(2, "Page")
        Me.VS2017.Images.SetKeyName(3, "Include")
        Me.VS2017.Images.SetKeyName(4, "Build")
        Me.VS2017.Images.SetKeyName(5, "Attribute")
        Me.VS2017.Images.SetKeyName(6, "Value")
        '
        'FolderBrowser
        '
        Me.FolderBrowser.Description = "Choose an existing site folder or create a new one to hold your site's files."
        '
        'MenuBar
        '
        Me.MenuBar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.ViewMenu, Me.FormatMenu, Me.BuildMenu, Me.HelpMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenFolder, Me.OpenRecent, Me.MenuItem1, Me.CloseSite, Me.SaveAll, Me.FileSep, Me.ExitItem})
        Me.FileMenu.Text = "File"
        '
        'OpenFolder
        '
        Me.OpenFolder.Index = 0
        Me.OpenFolder.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.OpenFolder.Text = "Open Folder..."
        '
        'OpenRecent
        '
        Me.OpenRecent.Index = 1
        Me.OpenRecent.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Recent1, Me.Recent2, Me.Recent3, Me.Recent4, Me.Recent5, Me.RecentSep, Me.ClearRecents})
        Me.OpenRecent.Text = "Open Recent"
        '
        'Recent1
        '
        Me.Recent1.Index = 0
        Me.Recent1.Text = "Recent 1"
        Me.Recent1.Visible = False
        '
        'Recent2
        '
        Me.Recent2.Index = 1
        Me.Recent2.Text = "Recent 2"
        Me.Recent2.Visible = False
        '
        'Recent3
        '
        Me.Recent3.Index = 2
        Me.Recent3.Text = "Recent 3"
        Me.Recent3.Visible = False
        '
        'Recent4
        '
        Me.Recent4.Index = 3
        Me.Recent4.Text = "Recent 4"
        Me.Recent4.Visible = False
        '
        'Recent5
        '
        Me.Recent5.Index = 4
        Me.Recent5.Text = "Recent 5"
        Me.Recent5.Visible = False
        '
        'RecentSep
        '
        Me.RecentSep.Index = 5
        Me.RecentSep.Text = "-"
        '
        'ClearRecents
        '
        Me.ClearRecents.Index = 6
        Me.ClearRecents.Text = "Clear Recent Sites"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'CloseSite
        '
        Me.CloseSite.Enabled = False
        Me.CloseSite.Index = 3
        Me.CloseSite.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftW
        Me.CloseSite.Text = "Close Site"
        '
        'SaveAll
        '
        Me.SaveAll.Index = 4
        Me.SaveAll.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.SaveAll.Text = "Save All"
        '
        'FileSep
        '
        Me.FileSep.Index = 5
        Me.FileSep.Text = "-"
        '
        'ExitItem
        '
        Me.ExitItem.Index = 6
        Me.ExitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.ExitItem.Text = "Exit"
        '
        'ViewMenu
        '
        Me.ViewMenu.Index = 1
        Me.ViewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ExplorerPanel, Me.BuildPanel, Me.EditorPanel, Me.PreviewPanel, Me.ViewMenuSep, Me.IconThemeMenu, Me.RefreshItem})
        Me.ViewMenu.Text = "View"
        '
        'ExplorerPanel
        '
        Me.ExplorerPanel.Checked = True
        Me.ExplorerPanel.Index = 0
        Me.ExplorerPanel.Shortcut = System.Windows.Forms.Shortcut.Alt1
        Me.ExplorerPanel.Text = "Explorer"
        '
        'BuildPanel
        '
        Me.BuildPanel.Checked = True
        Me.BuildPanel.Index = 1
        Me.BuildPanel.Shortcut = System.Windows.Forms.Shortcut.Alt2
        Me.BuildPanel.Text = "Apricot"
        '
        'EditorPanel
        '
        Me.EditorPanel.Checked = True
        Me.EditorPanel.Index = 2
        Me.EditorPanel.Shortcut = System.Windows.Forms.Shortcut.Alt3
        Me.EditorPanel.Text = "Editor"
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Checked = True
        Me.PreviewPanel.Index = 3
        Me.PreviewPanel.Shortcut = System.Windows.Forms.Shortcut.Alt4
        Me.PreviewPanel.Text = "Preview"
        '
        'ViewMenuSep
        '
        Me.ViewMenuSep.Index = 4
        Me.ViewMenuSep.Text = "-"
        '
        'IconThemeMenu
        '
        Me.IconThemeMenu.Index = 5
        Me.IconThemeMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.VS2017item, Me.XPitem})
        Me.IconThemeMenu.Text = "Explorer Icon Theme"
        '
        'VS2017item
        '
        Me.VS2017item.Index = 0
        Me.VS2017item.RadioCheck = True
        Me.VS2017item.Text = "Visual Studio 2017"
        '
        'XPitem
        '
        Me.XPitem.Index = 1
        Me.XPitem.RadioCheck = True
        Me.XPitem.Text = "XP"
        '
        'RefreshItem
        '
        Me.RefreshItem.Index = 6
        Me.RefreshItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.RefreshItem.Text = "Refresh"
        '
        'FormatMenu
        '
        Me.FormatMenu.Index = 2
        Me.FormatMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WordWrap, Me.VirtualSpace, Me.WideCaret, Me.FormatMenuSep, Me.SyntaxHighlight, Me.LivePreview, Me.FormatSep2, Me.EditorFont})
        Me.FormatMenu.Text = "Format"
        '
        'WordWrap
        '
        Me.WordWrap.Checked = True
        Me.WordWrap.Index = 0
        Me.WordWrap.Text = "Word Wrap"
        '
        'VirtualSpace
        '
        Me.VirtualSpace.Index = 1
        Me.VirtualSpace.Text = "Virtual Space"
        '
        'WideCaret
        '
        Me.WideCaret.Index = 2
        Me.WideCaret.Text = "Wide Caret"
        '
        'FormatMenuSep
        '
        Me.FormatMenuSep.Index = 3
        Me.FormatMenuSep.Text = "-"
        '
        'SyntaxHighlight
        '
        Me.SyntaxHighlight.Index = 4
        Me.SyntaxHighlight.Text = "Experimental Syntax Highlighting"
        '
        'LivePreview
        '
        Me.LivePreview.Index = 5
        Me.LivePreview.Text = "Live Preview"
        '
        'FormatSep2
        '
        Me.FormatSep2.Index = 6
        Me.FormatSep2.Text = "-"
        '
        'EditorFont
        '
        Me.EditorFont.Index = 7
        Me.EditorFont.Text = "Monospace Font..."
        '
        'BuildMenu
        '
        Me.BuildMenu.Index = 3
        Me.BuildMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BuildSite, Me.SanitaryBuild, Me.BuildSep, Me.EngineApricot, Me.EnginePython})
        Me.BuildMenu.Text = "Build"
        '
        'BuildSite
        '
        Me.BuildSite.Index = 0
        Me.BuildSite.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.BuildSite.Text = "Build Site"
        '
        'SanitaryBuild
        '
        Me.SanitaryBuild.Index = 1
        Me.SanitaryBuild.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftB
        Me.SanitaryBuild.Text = "Sanitary Build..."
        '
        'BuildSep
        '
        Me.BuildSep.Index = 2
        Me.BuildSep.Text = "-"
        '
        'EngineApricot
        '
        Me.EngineApricot.Checked = True
        Me.EngineApricot.Index = 3
        Me.EngineApricot.RadioCheck = True
        Me.EngineApricot.Text = "Apricot"
        '
        'EnginePython
        '
        Me.EnginePython.Index = 4
        Me.EnginePython.RadioCheck = True
        Me.EnginePython.Text = "Legacy AutoSite"
        '
        'HelpMenu
        '
        Me.HelpMenu.Index = 4
        Me.HelpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AboutItem, Me.HelpTopics})
        Me.HelpMenu.Text = "Help"
        '
        'AboutItem
        '
        Me.AboutItem.Index = 0
        Me.AboutItem.Text = "About"
        '
        'HelpTopics
        '
        Me.HelpTopics.Enabled = False
        Me.HelpTopics.Index = 1
        Me.HelpTopics.Text = "Help Topics"
        '
        'XP
        '
        Me.XP.ImageStream = CType(resources.GetObject("XP.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.XP.TransparentColor = System.Drawing.Color.Transparent
        Me.XP.Images.SetKeyName(0, "Folder")
        Me.XP.Images.SetKeyName(1, "Template")
        Me.XP.Images.SetKeyName(2, "Template")
        Me.XP.Images.SetKeyName(3, "Page")
        Me.XP.Images.SetKeyName(4, "Include")
        Me.XP.Images.SetKeyName(5, "Include")
        Me.XP.Images.SetKeyName(6, "Include")
        Me.XP.Images.SetKeyName(7, "Include")
        Me.XP.Images.SetKeyName(8, "Include")
        Me.XP.Images.SetKeyName(9, "Build")
        '
        'Context
        '
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenInDefault, Me.ContextSep, Me.CopyCon, Me.PasteCon, Me.AddFilesCon, Me.ContextSep2, Me.DeleteCon, Me.RenameCon, Me.ContextSep3, Me.NewCon})
        '
        'OpenInDefault
        '
        Me.OpenInDefault.Index = 0
        Me.OpenInDefault.Text = "Open in Default Program"
        '
        'ContextSep
        '
        Me.ContextSep.Index = 1
        Me.ContextSep.Text = "-"
        '
        'CopyCon
        '
        Me.CopyCon.Index = 2
        Me.CopyCon.Text = "Copy"
        '
        'PasteCon
        '
        Me.PasteCon.Index = 3
        Me.PasteCon.Text = "Paste"
        '
        'AddFilesCon
        '
        Me.AddFilesCon.Index = 4
        Me.AddFilesCon.Text = "Add Files..."
        '
        'ContextSep2
        '
        Me.ContextSep2.Index = 5
        Me.ContextSep2.Text = "-"
        '
        'DeleteCon
        '
        Me.DeleteCon.Index = 6
        Me.DeleteCon.Text = "Delete"
        '
        'RenameCon
        '
        Me.RenameCon.Index = 7
        Me.RenameCon.Text = "Rename"
        '
        'ContextSep3
        '
        Me.ContextSep3.Index = 8
        Me.ContextSep3.Text = "-"
        '
        'NewCon
        '
        Me.NewCon.Index = 9
        Me.NewCon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewFolderCon, Me.NewSep, Me.NewHTMLCon, Me.NewMDCon, Me.NewPHPCon, Me.NewSep2, Me.NewCSSCon, Me.NewJSCon, Me.NewTXTCon})
        Me.NewCon.Text = "New"
        '
        'NewFolderCon
        '
        Me.NewFolderCon.Index = 0
        Me.NewFolderCon.Text = "Folder"
        '
        'NewSep
        '
        Me.NewSep.Index = 1
        Me.NewSep.Text = "-"
        '
        'NewHTMLCon
        '
        Me.NewHTMLCon.Index = 2
        Me.NewHTMLCon.Text = "HTML Page (.html)"
        '
        'NewMDCon
        '
        Me.NewMDCon.Index = 3
        Me.NewMDCon.Text = "Markdown Page (.md)"
        '
        'NewPHPCon
        '
        Me.NewPHPCon.Index = 4
        Me.NewPHPCon.Text = "PHP Script (.php)"
        '
        'NewSep2
        '
        Me.NewSep2.Index = 5
        Me.NewSep2.Text = "-"
        '
        'NewCSSCon
        '
        Me.NewCSSCon.Index = 6
        Me.NewCSSCon.Text = "CSS Stylesheet (.css)"
        '
        'NewJSCon
        '
        Me.NewJSCon.Index = 7
        Me.NewJSCon.Text = "JS Script (.js)"
        '
        'NewTXTCon
        '
        Me.NewTXTCon.Index = 8
        Me.NewTXTCon.Text = "Plain Text (.txt)"
        '
        'AddFilesDialog
        '
        Me.AddFilesDialog.Filter = "All files (*.*)|*.*"
        Me.AddFilesDialog.Multiselect = True
        Me.AddFilesDialog.Title = "Add Files to Folder"
        '
        'Apricot
        '
        Me.Apricot.WorkerReportsProgress = True
        '
        'Watcher
        '
        Me.Watcher.EnableRaisingEvents = True
        Me.Watcher.Filter = "JINFC)(#@)D)(J@()J()DN@()NQND_)NQ#WNN"
        Me.Watcher.IncludeSubdirectories = True
        Me.Watcher.SynchronizingObject = Me
        '
        'EdSplit
        '
        Me.EdSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EdSplit.Location = New System.Drawing.Point(0, 0)
        Me.EdSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.EdSplit.Name = "EdSplit"
        Me.EdSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'EdSplit.Panel1
        '
        Me.EdSplit.Panel1.Controls.Add(Me.EditTabs)
        '
        'EdSplit.Panel2
        '
        Me.EdSplit.Panel2.Controls.Add(Me.Preview)
        Me.EdSplit.Size = New System.Drawing.Size(628, 513)
        Me.EdSplit.SplitterDistance = 295
        Me.EdSplit.SplitterWidth = 5
        Me.EdSplit.TabIndex = 1
        '
        'EditTabs
        '
        Me.EditTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditTabs.Location = New System.Drawing.Point(0, 0)
        Me.EditTabs.Margin = New System.Windows.Forms.Padding(0)
        Me.EditTabs.Multiline = True
        Me.EditTabs.Name = "EditTabs"
        Me.EditTabs.Padding = New System.Drawing.Point(0, 0)
        Me.EditTabs.SelectedIndex = 0
        Me.EditTabs.ShowToolTips = True
        Me.EditTabs.Size = New System.Drawing.Size(628, 295)
        Me.EditTabs.TabIndex = 1
        '
        'Preview
        '
        Me.Preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Preview.Location = New System.Drawing.Point(0, 0)
        Me.Preview.Margin = New System.Windows.Forms.Padding(4)
        Me.Preview.MinimumSize = New System.Drawing.Size(27, 25)
        Me.Preview.Name = "Preview"
        Me.Preview.ScriptErrorsSuppressed = True
        Me.Preview.Size = New System.Drawing.Size(628, 213)
        Me.Preview.TabIndex = 0
        Me.Preview.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'ExSplit
        '
        Me.ExSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExSplit.Location = New System.Drawing.Point(0, 0)
        Me.ExSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.ExSplit.Name = "ExSplit"
        Me.ExSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ExSplit.Panel1
        '
        Me.ExSplit.Panel1.Controls.Add(Me.OpenLink)
        Me.ExSplit.Panel1.Controls.Add(Me.OpenPrompt)
        Me.ExSplit.Panel1.Controls.Add(Me.SiteTree)
        '
        'ExSplit.Panel2
        '
        Me.ExSplit.Panel2.Controls.Add(Me.ApricotTabs)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildProgress)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildStrip)
        Me.ExSplit.Size = New System.Drawing.Size(310, 513)
        Me.ExSplit.SplitterDistance = 290
        Me.ExSplit.SplitterWidth = 5
        Me.ExSplit.TabIndex = 4
        '
        'OpenLink
        '
        Me.OpenLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenLink.AutoEllipsis = True
        Me.OpenLink.AutoSize = True
        Me.OpenLink.BackColor = System.Drawing.SystemColors.Window
        Me.OpenLink.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OpenLink.Location = New System.Drawing.Point(60, 64)
        Me.OpenLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OpenLink.Name = "OpenLink"
        Me.OpenLink.Size = New System.Drawing.Size(181, 17)
        Me.OpenLink.TabIndex = 1
        Me.OpenLink.TabStop = True
        Me.OpenLink.Text = "Create or open a site folder"
        Me.OpenLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenPrompt
        '
        Me.OpenPrompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenPrompt.AutoEllipsis = True
        Me.OpenPrompt.AutoSize = True
        Me.OpenPrompt.BackColor = System.Drawing.SystemColors.Window
        Me.OpenPrompt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OpenPrompt.Location = New System.Drawing.Point(47, 33)
        Me.OpenPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OpenPrompt.Name = "OpenPrompt"
        Me.OpenPrompt.Size = New System.Drawing.Size(209, 17)
        Me.OpenPrompt.TabIndex = 2
        Me.OpenPrompt.Text = "A site has not been opened yet."
        Me.OpenPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SiteTree
        '
        Me.SiteTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiteTree.ImageIndex = 0
        Me.SiteTree.ImageList = Me.VS2017
        Me.SiteTree.LabelEdit = True
        Me.SiteTree.Location = New System.Drawing.Point(0, 0)
        Me.SiteTree.Margin = New System.Windows.Forms.Padding(4)
        Me.SiteTree.Name = "SiteTree"
        Me.SiteTree.SelectedImageIndex = 0
        Me.SiteTree.Size = New System.Drawing.Size(310, 290)
        Me.SiteTree.TabIndex = 4
        '
        'ApricotTabs
        '
        Me.ApricotTabs.Controls.Add(Me.LogPage)
        Me.ApricotTabs.Controls.Add(Me.MapPage)
        Me.ApricotTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApricotTabs.Location = New System.Drawing.Point(0, 25)
        Me.ApricotTabs.Margin = New System.Windows.Forms.Padding(4)
        Me.ApricotTabs.Name = "ApricotTabs"
        Me.ApricotTabs.SelectedIndex = 0
        Me.ApricotTabs.Size = New System.Drawing.Size(310, 165)
        Me.ApricotTabs.TabIndex = 5
        '
        'LogPage
        '
        Me.LogPage.Controls.Add(Me.Log)
        Me.LogPage.Location = New System.Drawing.Point(4, 25)
        Me.LogPage.Margin = New System.Windows.Forms.Padding(4)
        Me.LogPage.Name = "LogPage"
        Me.LogPage.Padding = New System.Windows.Forms.Padding(4)
        Me.LogPage.Size = New System.Drawing.Size(302, 136)
        Me.LogPage.TabIndex = 0
        Me.LogPage.Text = "Log"
        Me.LogPage.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.SystemColors.Window
        Me.Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Log.Location = New System.Drawing.Point(4, 4)
        Me.Log.Margin = New System.Windows.Forms.Padding(4)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(294, 128)
        Me.Log.TabIndex = 5
        Me.Log.Text = Global.AutoSite_XL.My.Resources.Resources.iconTheme
        '
        'MapPage
        '
        Me.MapPage.Controls.Add(Me.AttributeTree)
        Me.MapPage.Location = New System.Drawing.Point(4, 25)
        Me.MapPage.Margin = New System.Windows.Forms.Padding(4)
        Me.MapPage.Name = "MapPage"
        Me.MapPage.Padding = New System.Windows.Forms.Padding(4)
        Me.MapPage.Size = New System.Drawing.Size(302, 136)
        Me.MapPage.TabIndex = 1
        Me.MapPage.Text = "Attribute Map"
        Me.MapPage.UseVisualStyleBackColor = True
        '
        'AttributeTree
        '
        Me.AttributeTree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AttributeTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AttributeTree.ImageIndex = 0
        Me.AttributeTree.ImageList = Me.VS2017
        Me.AttributeTree.Location = New System.Drawing.Point(4, 4)
        Me.AttributeTree.Margin = New System.Windows.Forms.Padding(4)
        Me.AttributeTree.Name = "AttributeTree"
        Me.AttributeTree.SelectedImageIndex = 0
        Me.AttributeTree.Size = New System.Drawing.Size(294, 128)
        Me.AttributeTree.TabIndex = 0
        '
        'BuildProgress
        '
        Me.BuildProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BuildProgress.Location = New System.Drawing.Point(0, 190)
        Me.BuildProgress.Margin = New System.Windows.Forms.Padding(4)
        Me.BuildProgress.Name = "BuildProgress"
        Me.BuildProgress.Size = New System.Drawing.Size(310, 28)
        Me.BuildProgress.TabIndex = 1
        Me.BuildProgress.Visible = False
        '
        'BuildStrip
        '
        Me.BuildStrip.BackColor = System.Drawing.SystemColors.Control
        Me.BuildStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BuildStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Build, Me.OpenOutput, Me.BrowseOutput, Me.BrowseOutputExt})
        Me.BuildStrip.Location = New System.Drawing.Point(0, 0)
        Me.BuildStrip.Name = "BuildStrip"
        Me.BuildStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BuildStrip.Size = New System.Drawing.Size(310, 25)
        Me.BuildStrip.TabIndex = 3
        Me.BuildStrip.Text = "ToolStrip1"
        '
        'Build
        '
        Me.Build.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Build.Image = CType(resources.GetObject("Build.Image"), System.Drawing.Image)
        Me.Build.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Build.Name = "Build"
        Me.Build.Size = New System.Drawing.Size(23, 22)
        Me.Build.Text = "ToolStripButton1"
        Me.Build.ToolTipText = "Build"
        '
        'OpenOutput
        '
        Me.OpenOutput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenOutput.Image = CType(resources.GetObject("OpenOutput.Image"), System.Drawing.Image)
        Me.OpenOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenOutput.Name = "OpenOutput"
        Me.OpenOutput.Size = New System.Drawing.Size(23, 22)
        Me.OpenOutput.Text = "Open Output Folder"
        '
        'BrowseOutput
        '
        Me.BrowseOutput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BrowseOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowseOutput.Image = CType(resources.GetObject("BrowseOutput.Image"), System.Drawing.Image)
        Me.BrowseOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseOutput.Name = "BrowseOutput"
        Me.BrowseOutput.Size = New System.Drawing.Size(23, 22)
        Me.BrowseOutput.Text = "Browse Site in Preview"
        '
        'BrowseOutputExt
        '
        Me.BrowseOutputExt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BrowseOutputExt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowseOutputExt.Image = CType(resources.GetObject("BrowseOutputExt.Image"), System.Drawing.Image)
        Me.BrowseOutputExt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowseOutputExt.Name = "BrowseOutputExt"
        Me.BrowseOutputExt.Size = New System.Drawing.Size(23, 22)
        Me.BrowseOutputExt.Text = "Browse Site"
        '
        'CoreSplit
        '
        Me.CoreSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoreSplit.Location = New System.Drawing.Point(0, 0)
        Me.CoreSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.CoreSplit.Name = "CoreSplit"
        '
        'CoreSplit.Panel1
        '
        Me.CoreSplit.Panel1.Controls.Add(Me.ExSplit)
        '
        'CoreSplit.Panel2
        '
        Me.CoreSplit.Panel2.Controls.Add(Me.EdSplit)
        Me.CoreSplit.Size = New System.Drawing.Size(943, 513)
        Me.CoreSplit.SplitterDistance = 310
        Me.CoreSplit.SplitterWidth = 5
        Me.CoreSplit.TabIndex = 4
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 513)
        Me.Controls.Add(Me.CoreSplit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Menu = Me.MenuBar
        Me.Name = "Main"
        Me.Text = "AutoSite XL"
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EdSplit.Panel1.ResumeLayout(False)
        Me.EdSplit.Panel2.ResumeLayout(False)
        Me.EdSplit.ResumeLayout(False)
        Me.ExSplit.Panel1.ResumeLayout(False)
        Me.ExSplit.Panel1.PerformLayout()
        Me.ExSplit.Panel2.ResumeLayout(False)
        Me.ExSplit.Panel2.PerformLayout()
        Me.ExSplit.ResumeLayout(False)
        Me.ApricotTabs.ResumeLayout(False)
        Me.LogPage.ResumeLayout(False)
        Me.MapPage.ResumeLayout(False)
        Me.BuildStrip.ResumeLayout(False)
        Me.BuildStrip.PerformLayout()
        Me.CoreSplit.Panel1.ResumeLayout(False)
        Me.CoreSplit.Panel2.ResumeLayout(False)
        Me.CoreSplit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VS2017 As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuBar As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents CloseSite As System.Windows.Forms.MenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents ExplorerPanel As System.Windows.Forms.MenuItem
    Friend WithEvents EditorPanel As System.Windows.Forms.MenuItem
    Friend WithEvents PreviewPanel As System.Windows.Forms.MenuItem
    Friend WithEvents WordWrap As System.Windows.Forms.MenuItem
    Friend WithEvents VirtualSpace As System.Windows.Forms.MenuItem
    Friend WithEvents WideCaret As System.Windows.Forms.MenuItem
    Friend WithEvents BuildMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BuildSite As System.Windows.Forms.MenuItem
    Friend WithEvents EnginePython As System.Windows.Forms.MenuItem
    Friend WithEvents EngineApricot As System.Windows.Forms.MenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AboutItem As System.Windows.Forms.MenuItem
    Friend WithEvents HelpTopics As System.Windows.Forms.MenuItem
    Friend WithEvents IconThemeMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VS2017item As System.Windows.Forms.MenuItem
    Friend WithEvents XP As System.Windows.Forms.ImageList
    Friend WithEvents XPitem As System.Windows.Forms.MenuItem
    Friend WithEvents FileSep As System.Windows.Forms.MenuItem
    Friend WithEvents ExitItem As System.Windows.Forms.MenuItem
    Friend WithEvents Context As System.Windows.Forms.ContextMenu
    Friend WithEvents OpenInDefault As System.Windows.Forms.MenuItem
    Friend WithEvents RefreshItem As System.Windows.Forms.MenuItem
    Friend WithEvents ContextSep As System.Windows.Forms.MenuItem
    Friend WithEvents CopyCon As System.Windows.Forms.MenuItem
    Friend WithEvents PasteCon As System.Windows.Forms.MenuItem
    Friend WithEvents DeleteCon As System.Windows.Forms.MenuItem
    Friend WithEvents ContextSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents NewCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewFolderCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewHTMLCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewMDCon As System.Windows.Forms.MenuItem
    Friend WithEvents AddFilesCon As System.Windows.Forms.MenuItem
    Friend WithEvents AddFilesDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NewPHPCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewSep As System.Windows.Forms.MenuItem
    Friend WithEvents Apricot As System.ComponentModel.BackgroundWorker
    Friend WithEvents FormatMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SyntaxHighlight As System.Windows.Forms.MenuItem
    Friend WithEvents FormatMenuSep As System.Windows.Forms.MenuItem
    Friend WithEvents SaveAll As System.Windows.Forms.MenuItem
    Friend WithEvents LivePreview As System.Windows.Forms.MenuItem
    Friend WithEvents Watcher As System.IO.FileSystemWatcher
    Friend WithEvents RenameCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewCSSCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents CoreSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents ExSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents OpenLink As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenPrompt As System.Windows.Forms.Label
    Friend WithEvents SiteTree As System.Windows.Forms.TreeView
    Friend WithEvents ApricotTabs As System.Windows.Forms.TabControl
    Friend WithEvents LogPage As System.Windows.Forms.TabPage
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents MapPage As System.Windows.Forms.TabPage
    Friend WithEvents AttributeTree As System.Windows.Forms.TreeView
    Friend WithEvents BuildProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents BuildStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenOutput As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseOutput As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseOutputExt As System.Windows.Forms.ToolStripButton
    Friend WithEvents EdSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents EditTabs As System.Windows.Forms.TabControl
    Friend WithEvents Preview As System.Windows.Forms.WebBrowser
    Friend WithEvents FormatSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents EditorFont As System.Windows.Forms.MenuItem
    Friend WithEvents SelectFont As System.Windows.Forms.FontDialog
    Friend WithEvents NewJSCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewTXTCon As System.Windows.Forms.MenuItem
    Friend WithEvents BuildPanel As System.Windows.Forms.MenuItem
    Friend WithEvents ViewMenuSep As System.Windows.Forms.MenuItem
    Friend WithEvents SanitaryBuild As System.Windows.Forms.MenuItem
    Friend WithEvents BuildSep As System.Windows.Forms.MenuItem
    Friend WithEvents Recent1 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent2 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent3 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent4 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent5 As System.Windows.Forms.MenuItem
    Friend WithEvents ClearRecents As System.Windows.Forms.MenuItem
    Friend WithEvents OpenRecent As System.Windows.Forms.MenuItem
    Friend WithEvents RecentSep As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
End Class
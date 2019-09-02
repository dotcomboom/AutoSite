<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.VS2017 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.MenuBar = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem
        Me.OpenFolder = New System.Windows.Forms.MenuItem
        Me.CloseSite = New System.Windows.Forms.MenuItem
        Me.SaveAll = New System.Windows.Forms.MenuItem
        Me.FileSep = New System.Windows.Forms.MenuItem
        Me.ExitItem = New System.Windows.Forms.MenuItem
        Me.ViewMenu = New System.Windows.Forms.MenuItem
        Me.Panels = New System.Windows.Forms.MenuItem
        Me.ExplorerPanel = New System.Windows.Forms.MenuItem
        Me.BuildPanel = New System.Windows.Forms.MenuItem
        Me.PanelSep = New System.Windows.Forms.MenuItem
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
        Me.BuildMenu = New System.Windows.Forms.MenuItem
        Me.BuildSite = New System.Windows.Forms.MenuItem
        Me.BuildEngineMenu = New System.Windows.Forms.MenuItem
        Me.EnginePython = New System.Windows.Forms.MenuItem
        Me.EngineApricot = New System.Windows.Forms.MenuItem
        Me.HelpMenu = New System.Windows.Forms.MenuItem
        Me.AboutItem = New System.Windows.Forms.MenuItem
        Me.HelpTopics = New System.Windows.Forms.MenuItem
        Me.CoreSplit = New System.Windows.Forms.SplitContainer
        Me.ExSplit = New System.Windows.Forms.SplitContainer
        Me.OpenLink = New System.Windows.Forms.LinkLabel
        Me.OpenPrompt = New System.Windows.Forms.Label
        Me.SiteTree = New System.Windows.Forms.TreeView
        Me.TabControl1 = New System.Windows.Forms.TabControl
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
        Me.EdSplit = New System.Windows.Forms.SplitContainer
        Me.EditTabs = New System.Windows.Forms.TabControl
        Me.Preview = New System.Windows.Forms.WebBrowser
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
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.NewCSSCon = New System.Windows.Forms.MenuItem
        Me.NewJSCon = New System.Windows.Forms.MenuItem
        Me.AddFilesDialog = New System.Windows.Forms.OpenFileDialog
        Me.Apricot = New System.ComponentModel.BackgroundWorker
        Me.Watcher = New System.IO.FileSystemWatcher
        Me.CoreSplit.Panel1.SuspendLayout()
        Me.CoreSplit.Panel2.SuspendLayout()
        Me.CoreSplit.SuspendLayout()
        Me.ExSplit.Panel1.SuspendLayout()
        Me.ExSplit.Panel2.SuspendLayout()
        Me.ExSplit.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.LogPage.SuspendLayout()
        Me.MapPage.SuspendLayout()
        Me.BuildStrip.SuspendLayout()
        Me.EdSplit.Panel1.SuspendLayout()
        Me.EdSplit.Panel2.SuspendLayout()
        Me.EdSplit.SuspendLayout()
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenFolder, Me.CloseSite, Me.SaveAll, Me.FileSep, Me.ExitItem})
        Me.FileMenu.Text = "File"
        '
        'OpenFolder
        '
        Me.OpenFolder.Index = 0
        Me.OpenFolder.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.OpenFolder.Text = "Open Folder..."
        '
        'CloseSite
        '
        Me.CloseSite.Enabled = False
        Me.CloseSite.Index = 1
        Me.CloseSite.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftW
        Me.CloseSite.Text = "Close Site"
        '
        'SaveAll
        '
        Me.SaveAll.Index = 2
        Me.SaveAll.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.SaveAll.Text = "Save All"
        '
        'FileSep
        '
        Me.FileSep.Index = 3
        Me.FileSep.Text = "-"
        '
        'ExitItem
        '
        Me.ExitItem.Index = 4
        Me.ExitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.ExitItem.Text = "Exit"
        '
        'ViewMenu
        '
        Me.ViewMenu.Index = 1
        Me.ViewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Panels, Me.ViewMenuSep, Me.IconThemeMenu, Me.RefreshItem})
        Me.ViewMenu.Text = "View"
        '
        'Panels
        '
        Me.Panels.Index = 0
        Me.Panels.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ExplorerPanel, Me.BuildPanel, Me.PanelSep, Me.EditorPanel, Me.PreviewPanel})
        Me.Panels.Text = "Panels"
        '
        'ExplorerPanel
        '
        Me.ExplorerPanel.Checked = True
        Me.ExplorerPanel.Index = 0
        Me.ExplorerPanel.Text = "Explorer"
        '
        'BuildPanel
        '
        Me.BuildPanel.Checked = True
        Me.BuildPanel.Index = 1
        Me.BuildPanel.Text = "Apricot Output"
        '
        'PanelSep
        '
        Me.PanelSep.Index = 2
        Me.PanelSep.Text = "-"
        '
        'EditorPanel
        '
        Me.EditorPanel.Checked = True
        Me.EditorPanel.Index = 3
        Me.EditorPanel.Text = "Editor"
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Checked = True
        Me.PreviewPanel.Index = 4
        Me.PreviewPanel.Text = "Preview"
        '
        'ViewMenuSep
        '
        Me.ViewMenuSep.Index = 1
        Me.ViewMenuSep.Text = "-"
        '
        'IconThemeMenu
        '
        Me.IconThemeMenu.Index = 2
        Me.IconThemeMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.VS2017item, Me.XPitem})
        Me.IconThemeMenu.Text = "Icon Theme"
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
        Me.RefreshItem.Index = 3
        Me.RefreshItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.RefreshItem.Text = "Refresh"
        '
        'FormatMenu
        '
        Me.FormatMenu.Index = 2
        Me.FormatMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WordWrap, Me.VirtualSpace, Me.WideCaret, Me.FormatMenuSep, Me.SyntaxHighlight, Me.LivePreview})
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
        'BuildMenu
        '
        Me.BuildMenu.Index = 3
        Me.BuildMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BuildSite, Me.BuildEngineMenu})
        Me.BuildMenu.Text = "Build"
        '
        'BuildSite
        '
        Me.BuildSite.Index = 0
        Me.BuildSite.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.BuildSite.Text = "Build Site"
        '
        'BuildEngineMenu
        '
        Me.BuildEngineMenu.Index = 1
        Me.BuildEngineMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.EnginePython, Me.EngineApricot})
        Me.BuildEngineMenu.Text = "Engine"
        '
        'EnginePython
        '
        Me.EnginePython.Index = 0
        Me.EnginePython.RadioCheck = True
        Me.EnginePython.Text = "Python 3 AutoSite"
        '
        'EngineApricot
        '
        Me.EngineApricot.Checked = True
        Me.EngineApricot.Index = 1
        Me.EngineApricot.RadioCheck = True
        Me.EngineApricot.Text = "Apricot"
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
        Me.CoreSplit.Size = New System.Drawing.Size(707, 417)
        Me.CoreSplit.SplitterDistance = 233
        Me.CoreSplit.TabIndex = 4
        '
        'ExSplit
        '
        Me.ExSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExSplit.Location = New System.Drawing.Point(0, 0)
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
        Me.ExSplit.Panel2.Controls.Add(Me.TabControl1)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildProgress)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildStrip)
        Me.ExSplit.Size = New System.Drawing.Size(233, 417)
        Me.ExSplit.SplitterDistance = 236
        Me.ExSplit.TabIndex = 4
        '
        'OpenLink
        '
        Me.OpenLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenLink.BackColor = System.Drawing.SystemColors.Window
        Me.OpenLink.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OpenLink.Location = New System.Drawing.Point(22, 51)
        Me.OpenLink.Name = "OpenLink"
        Me.OpenLink.Size = New System.Drawing.Size(189, 13)
        Me.OpenLink.TabIndex = 1
        Me.OpenLink.TabStop = True
        Me.OpenLink.Text = "Create or open a site folder"
        Me.OpenLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenPrompt
        '
        Me.OpenPrompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenPrompt.BackColor = System.Drawing.SystemColors.Window
        Me.OpenPrompt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OpenPrompt.Location = New System.Drawing.Point(19, 26)
        Me.OpenPrompt.Name = "OpenPrompt"
        Me.OpenPrompt.Size = New System.Drawing.Size(192, 13)
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
        Me.SiteTree.Name = "SiteTree"
        Me.SiteTree.SelectedImageIndex = 0
        Me.SiteTree.Size = New System.Drawing.Size(233, 236)
        Me.SiteTree.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LogPage)
        Me.TabControl1.Controls.Add(Me.MapPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(233, 129)
        Me.TabControl1.TabIndex = 5
        '
        'LogPage
        '
        Me.LogPage.Controls.Add(Me.Log)
        Me.LogPage.Location = New System.Drawing.Point(4, 22)
        Me.LogPage.Name = "LogPage"
        Me.LogPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LogPage.Size = New System.Drawing.Size(225, 103)
        Me.LogPage.TabIndex = 0
        Me.LogPage.Text = "Log"
        Me.LogPage.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.SystemColors.Window
        Me.Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Log.Location = New System.Drawing.Point(3, 3)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(219, 97)
        Me.Log.TabIndex = 5
        Me.Log.Text = Global.AutoSite_XL.My.Resources.Resources.iconTheme
        '
        'MapPage
        '
        Me.MapPage.Controls.Add(Me.AttributeTree)
        Me.MapPage.Location = New System.Drawing.Point(4, 22)
        Me.MapPage.Name = "MapPage"
        Me.MapPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MapPage.Size = New System.Drawing.Size(225, 103)
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
        Me.AttributeTree.Location = New System.Drawing.Point(3, 3)
        Me.AttributeTree.Name = "AttributeTree"
        Me.AttributeTree.SelectedImageIndex = 0
        Me.AttributeTree.Size = New System.Drawing.Size(219, 97)
        Me.AttributeTree.TabIndex = 0
        '
        'BuildProgress
        '
        Me.BuildProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BuildProgress.Location = New System.Drawing.Point(0, 154)
        Me.BuildProgress.Name = "BuildProgress"
        Me.BuildProgress.Size = New System.Drawing.Size(233, 23)
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
        Me.BuildStrip.Size = New System.Drawing.Size(233, 25)
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
        Me.BrowseOutputExt.Text = "Browse Site in Default Browser"
        '
        'EdSplit
        '
        Me.EdSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EdSplit.Location = New System.Drawing.Point(0, 0)
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
        Me.EdSplit.Size = New System.Drawing.Size(470, 417)
        Me.EdSplit.SplitterDistance = 240
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
        Me.EditTabs.Size = New System.Drawing.Size(470, 240)
        Me.EditTabs.TabIndex = 1
        '
        'Preview
        '
        Me.Preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Preview.Location = New System.Drawing.Point(0, 0)
        Me.Preview.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Preview.Name = "Preview"
        Me.Preview.ScriptErrorsSuppressed = True
        Me.Preview.Size = New System.Drawing.Size(470, 173)
        Me.Preview.TabIndex = 0
        Me.Preview.Url = New System.Uri("about:blank", System.UriKind.Absolute)
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
        Me.NewCon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewFolderCon, Me.NewSep, Me.NewHTMLCon, Me.NewMDCon, Me.NewPHPCon, Me.MenuItem3, Me.NewCSSCon, Me.NewJSCon})
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
        Me.NewHTMLCon.Text = "HTML Page"
        '
        'NewMDCon
        '
        Me.NewMDCon.Index = 3
        Me.NewMDCon.Text = "Markdown Page"
        '
        'NewPHPCon
        '
        Me.NewPHPCon.Index = 4
        Me.NewPHPCon.Text = "PHP Script"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Text = "-"
        '
        'NewCSSCon
        '
        Me.NewCSSCon.Index = 6
        Me.NewCSSCon.Text = "CSS Stylesheet"
        '
        'NewJSCon
        '
        Me.NewJSCon.Index = 7
        Me.NewJSCon.Text = "JS Script"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 417)
        Me.Controls.Add(Me.CoreSplit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MenuBar
        Me.Name = "Form1"
        Me.Text = "AutoSite XL"
        Me.CoreSplit.Panel1.ResumeLayout(False)
        Me.CoreSplit.Panel2.ResumeLayout(False)
        Me.CoreSplit.ResumeLayout(False)
        Me.ExSplit.Panel1.ResumeLayout(False)
        Me.ExSplit.Panel2.ResumeLayout(False)
        Me.ExSplit.Panel2.PerformLayout()
        Me.ExSplit.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.LogPage.ResumeLayout(False)
        Me.MapPage.ResumeLayout(False)
        Me.BuildStrip.ResumeLayout(False)
        Me.BuildStrip.PerformLayout()
        Me.EdSplit.Panel1.ResumeLayout(False)
        Me.EdSplit.Panel2.ResumeLayout(False)
        Me.EdSplit.ResumeLayout(False)
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VS2017 As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuBar As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents CloseSite As System.Windows.Forms.MenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Panels As System.Windows.Forms.MenuItem
    Friend WithEvents ExplorerPanel As System.Windows.Forms.MenuItem
    Friend WithEvents PanelSep As System.Windows.Forms.MenuItem
    Friend WithEvents EditorPanel As System.Windows.Forms.MenuItem
    Friend WithEvents PreviewPanel As System.Windows.Forms.MenuItem
    Friend WithEvents WordWrap As System.Windows.Forms.MenuItem
    Friend WithEvents VirtualSpace As System.Windows.Forms.MenuItem
    Friend WithEvents WideCaret As System.Windows.Forms.MenuItem
    Friend WithEvents BuildMenu As System.Windows.Forms.MenuItem
    Friend WithEvents BuildSite As System.Windows.Forms.MenuItem
    Friend WithEvents BuildEngineMenu As System.Windows.Forms.MenuItem
    Friend WithEvents EnginePython As System.Windows.Forms.MenuItem
    Friend WithEvents EngineApricot As System.Windows.Forms.MenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AboutItem As System.Windows.Forms.MenuItem
    Friend WithEvents HelpTopics As System.Windows.Forms.MenuItem
    Friend WithEvents CoreSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents EdSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents Preview As System.Windows.Forms.WebBrowser
    Friend WithEvents IconThemeMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VS2017item As System.Windows.Forms.MenuItem
    Friend WithEvents ViewMenuSep As System.Windows.Forms.MenuItem
    Friend WithEvents XP As System.Windows.Forms.ImageList
    Friend WithEvents XPitem As System.Windows.Forms.MenuItem
    Friend WithEvents EditTabs As System.Windows.Forms.TabControl
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
    Friend WithEvents BuildProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents Apricot As System.ComponentModel.BackgroundWorker
    Friend WithEvents BuildPanel As System.Windows.Forms.MenuItem
    Friend WithEvents ExSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents OpenLink As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenPrompt As System.Windows.Forms.Label
    Friend WithEvents SiteTree As System.Windows.Forms.TreeView
    Friend WithEvents FormatMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SyntaxHighlight As System.Windows.Forms.MenuItem
    Friend WithEvents FormatMenuSep As System.Windows.Forms.MenuItem
    Friend WithEvents SaveAll As System.Windows.Forms.MenuItem
    Friend WithEvents BuildStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents LivePreview As System.Windows.Forms.MenuItem
    Friend WithEvents OpenOutput As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseOutput As System.Windows.Forms.ToolStripButton
    Friend WithEvents Watcher As System.IO.FileSystemWatcher
    Friend WithEvents RenameCon As System.Windows.Forms.MenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LogPage As System.Windows.Forms.TabPage
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents MapPage As System.Windows.Forms.TabPage
    Friend WithEvents AttributeTree As System.Windows.Forms.TreeView
    Friend WithEvents BrowseOutputExt As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewCSSCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewJSCon As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
End Class

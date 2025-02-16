<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.EdSplit = New System.Windows.Forms.SplitContainer()
        Me.EditTabs = New System.Windows.Forms.TabControl()
        Me.Preview = New System.Windows.Forms.WebBrowser()
        Me.ExSplit = New System.Windows.Forms.SplitContainer()
        Me.SiteTree = New System.Windows.Forms.TreeView()
        Me.VS2017 = New System.Windows.Forms.ImageList(Me.components)
        Me.ApricotTabs = New System.Windows.Forms.TabControl()
        Me.LogPage = New System.Windows.Forms.TabPage()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.LogMenuBridge = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MapPage = New System.Windows.Forms.TabPage()
        Me.AttributeExplanation = New System.Windows.Forms.Label()
        Me.AttributeTree = New System.Windows.Forms.TreeView()
        Me.BuildProgress = New System.Windows.Forms.ProgressBar()
        Me.BuildStrip = New System.Windows.Forms.ToolStrip()
        Me.Build = New System.Windows.Forms.ToolStripButton()
        Me.SanitaryBuildBtn = New System.Windows.Forms.ToolStripButton()
        Me.OpenOutput = New System.Windows.Forms.ToolStripButton()
        Me.BrowseSitePreview = New System.Windows.Forms.ToolStripButton()
        Me.BrowseSite = New System.Windows.Forms.ToolStripButton()
        Me.CoreSplit = New System.Windows.Forms.SplitContainer()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRecent = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recent1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recent2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recent3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recent4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recent5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearRecents = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Find = New System.Windows.Forms.ToolStripMenuItem()
        Me.Replace = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickInsertMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertConditional = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.VirtualSpace = New System.Windows.Forms.ToolStripMenuItem()
        Me.WideCaret = New System.Windows.Forms.ToolStripMenuItem()
        Me.LivePreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplorerPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplorerAttributes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemIcons = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconThemeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.VS2017item = New System.Windows.Forms.ToolStripMenuItem()
        Me.XPitem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.cDark = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanitaryBuild = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFileOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOutputMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseSiteMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseSitePreviewMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopics = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickstartMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSampleSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.Website = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitHub = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedback = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishLang = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpanishLang = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolishLang = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelshLang = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspectorBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.XP = New System.Windows.Forms.ImageList(Me.components)
        Me.Context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFilesCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFolderCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewHTMLCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMDCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPHPCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCSSCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewJSCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTXTCon = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFilesDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ApricotWorker = New System.ComponentModel.BackgroundWorker()
        Me.Watcher = New System.IO.FileSystemWatcher()
        Me.SelectFont = New System.Windows.Forms.FontDialog()
        Me.LogMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLogDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenPack = New System.Windows.Forms.OpenFileDialog()
        Me.Strip = New System.Windows.Forms.ToolStrip()
        Me.NewSiteBtn = New System.Windows.Forms.ToolStripButton()
        Me.OpenSiteBtn = New System.Windows.Forms.ToolStripButton()
        Me.NewItemBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewFolderTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepNewItem0 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMarkdownPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepNewItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepNewItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewStylesheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewJavaScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepNewItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScriptingDropdown = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ScriptingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSpiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScriptGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SpicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScriptingGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveAllBtn = New System.Windows.Forms.ToolStripButton()
        Me.CloseBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep = New System.Windows.Forms.ToolStripSeparator()
        Me.CutBtn = New System.Windows.Forms.ToolStripButton()
        Me.CopyBtn = New System.Windows.Forms.ToolStripButton()
        Me.PasteBtn = New System.Windows.Forms.ToolStripButton()
        Me.InsertBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindBtn = New System.Windows.Forms.ToolStripButton()
        Me.ReplaceBtn = New System.Windows.Forms.ToolStripButton()
        Me.GotoBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoBtn = New System.Windows.Forms.ToolStripButton()
        Me.RedoBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviewBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuildBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.CleanBuildBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOutputFolderBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOutBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.ViewinDefaultBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.EditSep = New System.Windows.Forms.ToolStripSeparator()
        Me.EditSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditSep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatSep = New System.Windows.Forms.ToolStripSeparator()
        Me.FormatSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewSep = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsSep = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpSep = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileSep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextSep = New System.Windows.Forms.ToolStripSeparator()
        Me.RecentSep = New System.Windows.Forms.ToolStripSeparator()
        Me.NewSep = New System.Windows.Forms.ToolStripSeparator()
        Me.NewSep2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.MenuBar.SuspendLayout()
        Me.Context.SuspendLayout()
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogMenu.SuspendLayout()
        Me.Strip.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EdSplit
        '
        resources.ApplyResources(Me.EdSplit, "EdSplit")
        Me.EdSplit.Name = "EdSplit"
        '
        'EdSplit.Panel1
        '
        Me.EdSplit.Panel1.Controls.Add(Me.EditTabs)
        resources.ApplyResources(Me.EdSplit.Panel1, "EdSplit.Panel1")
        '
        'EdSplit.Panel2
        '
        Me.EdSplit.Panel2.Controls.Add(Me.Preview)
        resources.ApplyResources(Me.EdSplit.Panel2, "EdSplit.Panel2")
        '
        'EditTabs
        '
        resources.ApplyResources(Me.EditTabs, "EditTabs")
        Me.EditTabs.Multiline = True
        Me.EditTabs.Name = "EditTabs"
        Me.EditTabs.SelectedIndex = 0
        '
        'Preview
        '
        resources.ApplyResources(Me.Preview, "Preview")
        Me.Preview.Name = "Preview"
        Me.Preview.ScriptErrorsSuppressed = True
        Me.Preview.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'ExSplit
        '
        resources.ApplyResources(Me.ExSplit, "ExSplit")
        Me.ExSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.ExSplit.Name = "ExSplit"
        '
        'ExSplit.Panel1
        '
        Me.ExSplit.Panel1.Controls.Add(Me.SiteTree)
        resources.ApplyResources(Me.ExSplit.Panel1, "ExSplit.Panel1")
        '
        'ExSplit.Panel2
        '
        Me.ExSplit.Panel2.Controls.Add(Me.ApricotTabs)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildProgress)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildStrip)
        resources.ApplyResources(Me.ExSplit.Panel2, "ExSplit.Panel2")
        '
        'SiteTree
        '
        resources.ApplyResources(Me.SiteTree, "SiteTree")
        Me.SiteTree.HotTracking = True
        Me.SiteTree.ImageList = Me.VS2017
        Me.SiteTree.LabelEdit = True
        Me.SiteTree.Name = "SiteTree"
        '
        'VS2017
        '
        Me.VS2017.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.VS2017, "VS2017")
        Me.VS2017.TransparentColor = System.Drawing.Color.Transparent
        '
        'ApricotTabs
        '
        Me.ApricotTabs.Controls.Add(Me.LogPage)
        Me.ApricotTabs.Controls.Add(Me.MapPage)
        resources.ApplyResources(Me.ApricotTabs, "ApricotTabs")
        Me.ApricotTabs.Name = "ApricotTabs"
        Me.ApricotTabs.SelectedIndex = 0
        '
        'LogPage
        '
        Me.LogPage.BackColor = System.Drawing.Color.White
        Me.LogPage.Controls.Add(Me.Log)
        resources.ApplyResources(Me.LogPage, "LogPage")
        Me.LogPage.Name = "LogPage"
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.SystemColors.Window
        Me.Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Log.ContextMenuStrip = Me.LogMenuBridge
        resources.ApplyResources(Me.Log, "Log")
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        '
        'LogMenuBridge
        '
        Me.LogMenuBridge.Name = "LogMenuBridge"
        resources.ApplyResources(Me.LogMenuBridge, "LogMenuBridge")
        '
        'MapPage
        '
        Me.MapPage.BackColor = System.Drawing.SystemColors.Window
        Me.MapPage.Controls.Add(Me.AttributeExplanation)
        Me.MapPage.Controls.Add(Me.AttributeTree)
        resources.ApplyResources(Me.MapPage, "MapPage")
        Me.MapPage.Name = "MapPage"
        '
        'AttributeExplanation
        '
        resources.ApplyResources(Me.AttributeExplanation, "AttributeExplanation")
        Me.AttributeExplanation.Name = "AttributeExplanation"
        '
        'AttributeTree
        '
        Me.AttributeTree.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.AttributeTree, "AttributeTree")
        Me.AttributeTree.ImageList = Me.VS2017
        Me.AttributeTree.LabelEdit = True
        Me.AttributeTree.Name = "AttributeTree"
        '
        'BuildProgress
        '
        resources.ApplyResources(Me.BuildProgress, "BuildProgress")
        Me.BuildProgress.Name = "BuildProgress"
        '
        'BuildStrip
        '
        Me.BuildStrip.BackColor = System.Drawing.SystemColors.Control
        Me.BuildStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BuildStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Build, Me.SanitaryBuildBtn, Me.OpenOutput, Me.BrowseSitePreview, Me.BrowseSite})
        resources.ApplyResources(Me.BuildStrip, "BuildStrip")
        Me.BuildStrip.Name = "BuildStrip"
        Me.BuildStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'Build
        '
        Me.Build.Image = Global.AutoSite.My.Resources.Resources.Build
        resources.ApplyResources(Me.Build, "Build")
        Me.Build.Name = "Build"
        '
        'SanitaryBuildBtn
        '
        Me.SanitaryBuildBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SanitaryBuildBtn.Image = Global.AutoSite.My.Resources.Resources.SanitaryBuild
        resources.ApplyResources(Me.SanitaryBuildBtn, "SanitaryBuildBtn")
        Me.SanitaryBuildBtn.Name = "SanitaryBuildBtn"
        '
        'OpenOutput
        '
        Me.OpenOutput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenOutput.Image = Global.AutoSite.My.Resources.Resources.OpenFolder
        resources.ApplyResources(Me.OpenOutput, "OpenOutput")
        Me.OpenOutput.Name = "OpenOutput"
        '
        'BrowseSitePreview
        '
        Me.BrowseSitePreview.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BrowseSitePreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowseSitePreview.Image = Global.AutoSite.My.Resources.Resources.Browse
        resources.ApplyResources(Me.BrowseSitePreview, "BrowseSitePreview")
        Me.BrowseSitePreview.Name = "BrowseSitePreview"
        '
        'BrowseSite
        '
        Me.BrowseSite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BrowseSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowseSite.Image = Global.AutoSite.My.Resources.Resources.PreviewWebTab
        resources.ApplyResources(Me.BrowseSite, "BrowseSite")
        Me.BrowseSite.Name = "BrowseSite"
        '
        'CoreSplit
        '
        resources.ApplyResources(Me.CoreSplit, "CoreSplit")
        Me.CoreSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.CoreSplit.Name = "CoreSplit"
        '
        'CoreSplit.Panel1
        '
        Me.CoreSplit.Panel1.Controls.Add(Me.ExSplit)
        resources.ApplyResources(Me.CoreSplit.Panel1, "CoreSplit.Panel1")
        '
        'CoreSplit.Panel2
        '
        Me.CoreSplit.Panel2.Controls.Add(Me.EdSplit)
        resources.ApplyResources(Me.CoreSplit.Panel2, "CoreSplit.Panel2")
        '
        'FolderBrowser
        '
        resources.ApplyResources(Me.FolderBrowser, "FolderBrowser")
        '
        'MenuBar
        '
        resources.ApplyResources(Me.MenuBar, "MenuBar")
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.FormatMenu, Me.ViewMenu, Me.BuildMenu, Me.HelpMenu})
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Stretch = False
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSite, Me.OpenFolder, Me.CloseFile, Me.CloseSite, Me.FileSep2, Me.Save, Me.SaveAll, Me.FileSep3, Me.OpenRecent, Me.FileSep4, Me.ExitItem})
        Me.FileMenu.MergeIndex = 0
        Me.FileMenu.Name = "FileMenu"
        resources.ApplyResources(Me.FileMenu, "FileMenu")
        '
        'NewSite
        '
        Me.NewSite.MergeIndex = 0
        Me.NewSite.Name = "NewSite"
        resources.ApplyResources(Me.NewSite, "NewSite")
        '
        'OpenFolder
        '
        Me.OpenFolder.MergeIndex = 1
        Me.OpenFolder.Name = "OpenFolder"
        resources.ApplyResources(Me.OpenFolder, "OpenFolder")
        '
        'CloseFile
        '
        Me.CloseFile.MergeIndex = 2
        Me.CloseFile.Name = "CloseFile"
        resources.ApplyResources(Me.CloseFile, "CloseFile")
        '
        'CloseSite
        '
        resources.ApplyResources(Me.CloseSite, "CloseSite")
        Me.CloseSite.MergeIndex = 3
        Me.CloseSite.Name = "CloseSite"
        '
        'Save
        '
        Me.Save.MergeIndex = 5
        Me.Save.Name = "Save"
        resources.ApplyResources(Me.Save, "Save")
        '
        'SaveAll
        '
        Me.SaveAll.MergeIndex = 6
        Me.SaveAll.Name = "SaveAll"
        resources.ApplyResources(Me.SaveAll, "SaveAll")
        '
        'OpenRecent
        '
        Me.OpenRecent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Recent1, Me.Recent2, Me.Recent3, Me.Recent4, Me.Recent5, Me.RecentSep, Me.ClearRecents})
        Me.OpenRecent.MergeIndex = 8
        Me.OpenRecent.Name = "OpenRecent"
        resources.ApplyResources(Me.OpenRecent, "OpenRecent")
        '
        'Recent1
        '
        Me.Recent1.MergeIndex = 0
        Me.Recent1.Name = "Recent1"
        resources.ApplyResources(Me.Recent1, "Recent1")
        '
        'Recent2
        '
        Me.Recent2.MergeIndex = 1
        Me.Recent2.Name = "Recent2"
        resources.ApplyResources(Me.Recent2, "Recent2")
        '
        'Recent3
        '
        Me.Recent3.MergeIndex = 2
        Me.Recent3.Name = "Recent3"
        resources.ApplyResources(Me.Recent3, "Recent3")
        '
        'Recent4
        '
        Me.Recent4.MergeIndex = 3
        Me.Recent4.Name = "Recent4"
        resources.ApplyResources(Me.Recent4, "Recent4")
        '
        'Recent5
        '
        Me.Recent5.MergeIndex = 4
        Me.Recent5.Name = "Recent5"
        resources.ApplyResources(Me.Recent5, "Recent5")
        '
        'ClearRecents
        '
        Me.ClearRecents.MergeIndex = 6
        Me.ClearRecents.Name = "ClearRecents"
        resources.ApplyResources(Me.ClearRecents, "ClearRecents")
        '
        'ExitItem
        '
        Me.ExitItem.MergeIndex = 10
        Me.ExitItem.Name = "ExitItem"
        resources.ApplyResources(Me.ExitItem, "ExitItem")
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Undo, Me.Redo, Me.EditSep, Me.Cut, Me.Copy, Me.Paste, Me.EditSep2, Me.SelectAll, Me.EditSep3, Me.Find, Me.Replace, Me.GoToMnu, Me.EditSep4, Me.QuickInsertMnu, Me.InsertConditional, Me.MenuItem1})
        Me.EditMenu.MergeIndex = 1
        Me.EditMenu.Name = "EditMenu"
        resources.ApplyResources(Me.EditMenu, "EditMenu")
        '
        'Undo
        '
        Me.Undo.MergeIndex = 0
        Me.Undo.Name = "Undo"
        resources.ApplyResources(Me.Undo, "Undo")
        '
        'Redo
        '
        Me.Redo.MergeIndex = 1
        Me.Redo.Name = "Redo"
        resources.ApplyResources(Me.Redo, "Redo")
        '
        'Cut
        '
        Me.Cut.MergeIndex = 3
        Me.Cut.Name = "Cut"
        resources.ApplyResources(Me.Cut, "Cut")
        '
        'Copy
        '
        Me.Copy.MergeIndex = 4
        Me.Copy.Name = "Copy"
        resources.ApplyResources(Me.Copy, "Copy")
        '
        'Paste
        '
        Me.Paste.MergeIndex = 5
        Me.Paste.Name = "Paste"
        resources.ApplyResources(Me.Paste, "Paste")
        '
        'SelectAll
        '
        Me.SelectAll.MergeIndex = 7
        Me.SelectAll.Name = "SelectAll"
        resources.ApplyResources(Me.SelectAll, "SelectAll")
        '
        'Find
        '
        Me.Find.MergeIndex = 9
        Me.Find.Name = "Find"
        resources.ApplyResources(Me.Find, "Find")
        '
        'Replace
        '
        Me.Replace.MergeIndex = 10
        Me.Replace.Name = "Replace"
        resources.ApplyResources(Me.Replace, "Replace")
        '
        'GoToMnu
        '
        Me.GoToMnu.MergeIndex = 11
        Me.GoToMnu.Name = "GoToMnu"
        resources.ApplyResources(Me.GoToMnu, "GoToMnu")
        '
        'QuickInsertMnu
        '
        Me.QuickInsertMnu.MergeIndex = 13
        Me.QuickInsertMnu.Name = "QuickInsertMnu"
        resources.ApplyResources(Me.QuickInsertMnu, "QuickInsertMnu")
        '
        'InsertConditional
        '
        Me.InsertConditional.MergeIndex = 14
        Me.InsertConditional.Name = "InsertConditional"
        resources.ApplyResources(Me.InsertConditional, "InsertConditional")
        '
        'MenuItem1
        '
        Me.MenuItem1.MergeIndex = 15
        Me.MenuItem1.Name = "MenuItem1"
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'FormatMenu
        '
        Me.FormatMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordWrap, Me.VirtualSpace, Me.WideCaret, Me.FormatSep, Me.LivePreview, Me.FormatSep2, Me.EditorFont})
        Me.FormatMenu.MergeIndex = 2
        Me.FormatMenu.Name = "FormatMenu"
        resources.ApplyResources(Me.FormatMenu, "FormatMenu")
        '
        'WordWrap
        '
        Me.WordWrap.Checked = True
        Me.WordWrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WordWrap.MergeIndex = 0
        Me.WordWrap.Name = "WordWrap"
        resources.ApplyResources(Me.WordWrap, "WordWrap")
        '
        'VirtualSpace
        '
        Me.VirtualSpace.MergeIndex = 1
        Me.VirtualSpace.Name = "VirtualSpace"
        resources.ApplyResources(Me.VirtualSpace, "VirtualSpace")
        '
        'WideCaret
        '
        Me.WideCaret.MergeIndex = 2
        Me.WideCaret.Name = "WideCaret"
        resources.ApplyResources(Me.WideCaret, "WideCaret")
        '
        'LivePreview
        '
        Me.LivePreview.MergeIndex = 4
        Me.LivePreview.Name = "LivePreview"
        resources.ApplyResources(Me.LivePreview, "LivePreview")
        '
        'EditorFont
        '
        Me.EditorFont.MergeIndex = 6
        Me.EditorFont.Name = "EditorFont"
        resources.ApplyResources(Me.EditorFont, "EditorFont")
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExplorerPanel, Me.BuildPanel, Me.EditorPanel, Me.PreviewPanel, Me.MenuItem3, Me.MenuItem23, Me.ExplorerAttributes, Me.SystemIcons, Me.ViewSep, Me.IconThemeMenu, Me.MenuItem2, Me.RefreshItem})
        Me.ViewMenu.MergeIndex = 3
        Me.ViewMenu.Name = "ViewMenu"
        resources.ApplyResources(Me.ViewMenu, "ViewMenu")
        '
        'ExplorerPanel
        '
        Me.ExplorerPanel.Checked = True
        Me.ExplorerPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExplorerPanel.MergeIndex = 0
        Me.ExplorerPanel.Name = "ExplorerPanel"
        resources.ApplyResources(Me.ExplorerPanel, "ExplorerPanel")
        '
        'BuildPanel
        '
        Me.BuildPanel.Checked = True
        Me.BuildPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BuildPanel.MergeIndex = 1
        Me.BuildPanel.Name = "BuildPanel"
        resources.ApplyResources(Me.BuildPanel, "BuildPanel")
        '
        'EditorPanel
        '
        Me.EditorPanel.Checked = True
        Me.EditorPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EditorPanel.MergeIndex = 2
        Me.EditorPanel.Name = "EditorPanel"
        resources.ApplyResources(Me.EditorPanel, "EditorPanel")
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Checked = True
        Me.PreviewPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PreviewPanel.MergeIndex = 3
        Me.PreviewPanel.Name = "PreviewPanel"
        resources.ApplyResources(Me.PreviewPanel, "PreviewPanel")
        '
        'MenuItem23
        '
        Me.MenuItem23.MergeIndex = 6
        Me.MenuItem23.Name = "MenuItem23"
        resources.ApplyResources(Me.MenuItem23, "MenuItem23")
        '
        'ExplorerAttributes
        '
        Me.ExplorerAttributes.MergeIndex = 7
        Me.ExplorerAttributes.Name = "ExplorerAttributes"
        resources.ApplyResources(Me.ExplorerAttributes, "ExplorerAttributes")
        '
        'SystemIcons
        '
        Me.SystemIcons.Checked = True
        Me.SystemIcons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SystemIcons.MergeIndex = 8
        Me.SystemIcons.Name = "SystemIcons"
        resources.ApplyResources(Me.SystemIcons, "SystemIcons")
        '
        'IconThemeMenu
        '
        Me.IconThemeMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VS2017item, Me.XPitem})
        Me.IconThemeMenu.MergeIndex = 10
        Me.IconThemeMenu.Name = "IconThemeMenu"
        resources.ApplyResources(Me.IconThemeMenu, "IconThemeMenu")
        '
        'VS2017item
        '
        Me.VS2017item.Checked = True
        Me.VS2017item.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VS2017item.MergeIndex = 0
        Me.VS2017item.Name = "VS2017item"
        resources.ApplyResources(Me.VS2017item, "VS2017item")
        '
        'XPitem
        '
        Me.XPitem.Checked = True
        Me.XPitem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.XPitem.MergeIndex = 1
        Me.XPitem.Name = "XPitem"
        resources.ApplyResources(Me.XPitem, "XPitem")
        '
        'MenuItem2
        '
        Me.MenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cDefault, Me.cDark})
        Me.MenuItem2.MergeIndex = 11
        Me.MenuItem2.Name = "MenuItem2"
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        '
        'cDefault
        '
        Me.cDefault.Checked = True
        Me.cDefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDefault.MergeIndex = 0
        Me.cDefault.Name = "cDefault"
        resources.ApplyResources(Me.cDefault, "cDefault")
        '
        'cDark
        '
        Me.cDark.MergeIndex = 1
        Me.cDark.Name = "cDark"
        resources.ApplyResources(Me.cDark, "cDark")
        '
        'RefreshItem
        '
        Me.RefreshItem.MergeIndex = 12
        Me.RefreshItem.Name = "RefreshItem"
        resources.ApplyResources(Me.RefreshItem, "RefreshItem")
        '
        'BuildMenu
        '
        Me.BuildMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildSite, Me.SanitaryBuild, Me.ToolsSep, Me.PreviewPage, Me.ViewFileOutput, Me.OpenOutputMnu, Me.MenuItem5, Me.BrowseSiteMnu, Me.BrowseSitePreviewMnu})
        Me.BuildMenu.MergeIndex = 4
        Me.BuildMenu.Name = "BuildMenu"
        resources.ApplyResources(Me.BuildMenu, "BuildMenu")
        '
        'BuildSite
        '
        Me.BuildSite.MergeIndex = 0
        Me.BuildSite.Name = "BuildSite"
        resources.ApplyResources(Me.BuildSite, "BuildSite")
        '
        'SanitaryBuild
        '
        Me.SanitaryBuild.MergeIndex = 1
        Me.SanitaryBuild.Name = "SanitaryBuild"
        resources.ApplyResources(Me.SanitaryBuild, "SanitaryBuild")
        '
        'PreviewPage
        '
        Me.PreviewPage.MergeIndex = 3
        Me.PreviewPage.Name = "PreviewPage"
        resources.ApplyResources(Me.PreviewPage, "PreviewPage")
        '
        'ViewFileOutput
        '
        Me.ViewFileOutput.MergeIndex = 4
        Me.ViewFileOutput.Name = "ViewFileOutput"
        resources.ApplyResources(Me.ViewFileOutput, "ViewFileOutput")
        '
        'OpenOutputMnu
        '
        Me.OpenOutputMnu.MergeIndex = 5
        Me.OpenOutputMnu.Name = "OpenOutputMnu"
        resources.ApplyResources(Me.OpenOutputMnu, "OpenOutputMnu")
        '
        'BrowseSiteMnu
        '
        Me.BrowseSiteMnu.MergeIndex = 7
        Me.BrowseSiteMnu.Name = "BrowseSiteMnu"
        resources.ApplyResources(Me.BrowseSiteMnu, "BrowseSiteMnu")
        '
        'BrowseSitePreviewMnu
        '
        Me.BrowseSitePreviewMnu.MergeIndex = 8
        Me.BrowseSitePreviewMnu.Name = "BrowseSitePreviewMnu"
        resources.ApplyResources(Me.BrowseSitePreviewMnu, "BrowseSitePreviewMnu")
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpTopics, Me.QuickstartMnu, Me.OpenSampleSite, Me.HelpSep, Me.Website, Me.GitHub, Me.SendFeedback, Me.HelpSep2, Me.LanguageMenu, Me.HelpSep3, Me.AboutItem, Me.ShowVersion, Me.InspectorBtn})
        Me.HelpMenu.MergeIndex = 5
        Me.HelpMenu.Name = "HelpMenu"
        resources.ApplyResources(Me.HelpMenu, "HelpMenu")
        '
        'HelpTopics
        '
        Me.HelpTopics.MergeIndex = 0
        Me.HelpTopics.Name = "HelpTopics"
        resources.ApplyResources(Me.HelpTopics, "HelpTopics")
        '
        'QuickstartMnu
        '
        Me.QuickstartMnu.MergeIndex = 1
        Me.QuickstartMnu.Name = "QuickstartMnu"
        resources.ApplyResources(Me.QuickstartMnu, "QuickstartMnu")
        '
        'OpenSampleSite
        '
        Me.OpenSampleSite.MergeIndex = 2
        Me.OpenSampleSite.Name = "OpenSampleSite"
        resources.ApplyResources(Me.OpenSampleSite, "OpenSampleSite")
        '
        'Website
        '
        Me.Website.MergeIndex = 4
        Me.Website.Name = "Website"
        resources.ApplyResources(Me.Website, "Website")
        '
        'GitHub
        '
        Me.GitHub.MergeIndex = 5
        Me.GitHub.Name = "GitHub"
        resources.ApplyResources(Me.GitHub, "GitHub")
        '
        'SendFeedback
        '
        Me.SendFeedback.MergeIndex = 6
        Me.SendFeedback.Name = "SendFeedback"
        resources.ApplyResources(Me.SendFeedback, "SendFeedback")
        '
        'LanguageMenu
        '
        Me.LanguageMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishLang, Me.SpanishLang, Me.PolishLang, Me.WelshLang})
        Me.LanguageMenu.MergeIndex = 8
        Me.LanguageMenu.Name = "LanguageMenu"
        resources.ApplyResources(Me.LanguageMenu, "LanguageMenu")
        '
        'EnglishLang
        '
        Me.EnglishLang.MergeIndex = 0
        Me.EnglishLang.Name = "EnglishLang"
        resources.ApplyResources(Me.EnglishLang, "EnglishLang")
        Me.EnglishLang.Tag = "en-US"
        '
        'SpanishLang
        '
        Me.SpanishLang.MergeIndex = 1
        Me.SpanishLang.Name = "SpanishLang"
        resources.ApplyResources(Me.SpanishLang, "SpanishLang")
        Me.SpanishLang.Tag = "es-ES"
        '
        'PolishLang
        '
        Me.PolishLang.MergeIndex = 2
        Me.PolishLang.Name = "PolishLang"
        resources.ApplyResources(Me.PolishLang, "PolishLang")
        Me.PolishLang.Tag = "pl-PL"
        '
        'WelshLang
        '
        Me.WelshLang.MergeIndex = 3
        Me.WelshLang.Name = "WelshLang"
        resources.ApplyResources(Me.WelshLang, "WelshLang")
        Me.WelshLang.Tag = "cy-GB"
        '
        'AboutItem
        '
        Me.AboutItem.MergeIndex = 10
        Me.AboutItem.Name = "AboutItem"
        resources.ApplyResources(Me.AboutItem, "AboutItem")
        '
        'ShowVersion
        '
        Me.ShowVersion.MergeIndex = 11
        Me.ShowVersion.Name = "ShowVersion"
        resources.ApplyResources(Me.ShowVersion, "ShowVersion")
        '
        'InspectorBtn
        '
        Me.InspectorBtn.MergeIndex = 12
        Me.InspectorBtn.Name = "InspectorBtn"
        resources.ApplyResources(Me.InspectorBtn, "InspectorBtn")
        '
        'XP
        '
        Me.XP.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.XP, "XP")
        Me.XP.TransparentColor = System.Drawing.Color.Transparent
        '
        'Context
        '
        Me.Context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenContext, Me.OpenInDefault, Me.OpenFileLocation, Me.ContextSep, Me.CopyCon, Me.PasteCon, Me.AddFilesCon, Me.ContextSep2, Me.DeleteCon, Me.RenameCon, Me.ContextSep3, Me.NewCon})
        Me.Context.Name = "Context"
        resources.ApplyResources(Me.Context, "Context")
        '
        'OpenContext
        '
        Me.OpenContext.MergeIndex = 0
        Me.OpenContext.Name = "OpenContext"
        resources.ApplyResources(Me.OpenContext, "OpenContext")
        '
        'OpenInDefault
        '
        Me.OpenInDefault.MergeIndex = 1
        Me.OpenInDefault.Name = "OpenInDefault"
        resources.ApplyResources(Me.OpenInDefault, "OpenInDefault")
        '
        'OpenFileLocation
        '
        Me.OpenFileLocation.MergeIndex = 2
        Me.OpenFileLocation.Name = "OpenFileLocation"
        resources.ApplyResources(Me.OpenFileLocation, "OpenFileLocation")
        '
        'CopyCon
        '
        Me.CopyCon.MergeIndex = 4
        Me.CopyCon.Name = "CopyCon"
        resources.ApplyResources(Me.CopyCon, "CopyCon")
        '
        'PasteCon
        '
        Me.PasteCon.MergeIndex = 5
        Me.PasteCon.Name = "PasteCon"
        resources.ApplyResources(Me.PasteCon, "PasteCon")
        '
        'AddFilesCon
        '
        Me.AddFilesCon.MergeIndex = 6
        Me.AddFilesCon.Name = "AddFilesCon"
        resources.ApplyResources(Me.AddFilesCon, "AddFilesCon")
        '
        'DeleteCon
        '
        Me.DeleteCon.MergeIndex = 8
        Me.DeleteCon.Name = "DeleteCon"
        resources.ApplyResources(Me.DeleteCon, "DeleteCon")
        '
        'RenameCon
        '
        Me.RenameCon.MergeIndex = 9
        Me.RenameCon.Name = "RenameCon"
        resources.ApplyResources(Me.RenameCon, "RenameCon")
        '
        'NewCon
        '
        Me.NewCon.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFolderCon, Me.NewSep, Me.NewHTMLCon, Me.NewMDCon, Me.NewPHPCon, Me.NewSep2, Me.NewCSSCon, Me.NewJSCon, Me.NewTXTCon})
        Me.NewCon.MergeIndex = 11
        Me.NewCon.Name = "NewCon"
        resources.ApplyResources(Me.NewCon, "NewCon")
        '
        'NewFolderCon
        '
        Me.NewFolderCon.MergeIndex = 0
        Me.NewFolderCon.Name = "NewFolderCon"
        resources.ApplyResources(Me.NewFolderCon, "NewFolderCon")
        '
        'NewHTMLCon
        '
        Me.NewHTMLCon.MergeIndex = 2
        Me.NewHTMLCon.Name = "NewHTMLCon"
        resources.ApplyResources(Me.NewHTMLCon, "NewHTMLCon")
        '
        'NewMDCon
        '
        Me.NewMDCon.MergeIndex = 3
        Me.NewMDCon.Name = "NewMDCon"
        resources.ApplyResources(Me.NewMDCon, "NewMDCon")
        '
        'NewPHPCon
        '
        Me.NewPHPCon.MergeIndex = 4
        Me.NewPHPCon.Name = "NewPHPCon"
        resources.ApplyResources(Me.NewPHPCon, "NewPHPCon")
        '
        'NewCSSCon
        '
        Me.NewCSSCon.MergeIndex = 6
        Me.NewCSSCon.Name = "NewCSSCon"
        resources.ApplyResources(Me.NewCSSCon, "NewCSSCon")
        '
        'NewJSCon
        '
        Me.NewJSCon.MergeIndex = 7
        Me.NewJSCon.Name = "NewJSCon"
        resources.ApplyResources(Me.NewJSCon, "NewJSCon")
        '
        'NewTXTCon
        '
        Me.NewTXTCon.MergeIndex = 8
        Me.NewTXTCon.Name = "NewTXTCon"
        resources.ApplyResources(Me.NewTXTCon, "NewTXTCon")
        '
        'AddFilesDialog
        '
        resources.ApplyResources(Me.AddFilesDialog, "AddFilesDialog")
        Me.AddFilesDialog.Multiselect = True
        '
        'ApricotWorker
        '
        Me.ApricotWorker.WorkerReportsProgress = True
        '
        'Watcher
        '
        Me.Watcher.EnableRaisingEvents = True
        Me.Watcher.IncludeSubdirectories = True
        Me.Watcher.SynchronizingObject = Me
        '
        'LogMenu
        '
        Me.LogMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveLog})
        Me.LogMenu.Name = "LogMenu"
        resources.ApplyResources(Me.LogMenu, "LogMenu")
        '
        'SaveLog
        '
        Me.SaveLog.MergeIndex = 0
        Me.SaveLog.Name = "SaveLog"
        resources.ApplyResources(Me.SaveLog, "SaveLog")
        '
        'SaveLogDialog
        '
        Me.SaveLogDialog.DefaultExt = "rtf"
        resources.ApplyResources(Me.SaveLogDialog, "SaveLogDialog")
        '
        'OpenPack
        '
        resources.ApplyResources(Me.OpenPack, "OpenPack")
        '
        'Strip
        '
        Me.Strip.AllowItemReorder = True
        Me.Strip.BackColor = System.Drawing.SystemColors.MenuBar
        resources.ApplyResources(Me.Strip, "Strip")
        Me.Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSiteBtn, Me.OpenSiteBtn, Me.NewItemBtn, Me.ScriptingDropdown, Me.SaveBtn, Me.SaveAllBtn, Me.CloseBtn, Me.Sep, Me.CutBtn, Me.CopyBtn, Me.PasteBtn, Me.InsertBtn, Me.Sep2, Me.FindBtn, Me.ReplaceBtn, Me.GotoBtn, Me.Sep3, Me.UndoBtn, Me.RedoBtn, Me.Sep4, Me.PreviewBtn, Me.Sep5, Me.BuildBtn, Me.ViewOutBtn, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Strip.Name = "Strip"
        '
        'NewSiteBtn
        '
        Me.NewSiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewSiteBtn.Image = Global.AutoSite.My.Resources.Resources.NewWeb_16x
        resources.ApplyResources(Me.NewSiteBtn, "NewSiteBtn")
        Me.NewSiteBtn.Name = "NewSiteBtn"
        '
        'OpenSiteBtn
        '
        Me.OpenSiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenSiteBtn.Image = Global.AutoSite.My.Resources.Resources.OpenWeb_16x
        resources.ApplyResources(Me.OpenSiteBtn, "OpenSiteBtn")
        Me.OpenSiteBtn.Name = "OpenSiteBtn"
        '
        'NewItemBtn
        '
        Me.NewItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewItemBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFolderTool, Me.SepNewItem0, Me.NewPageToolStripMenuItem, Me.NewMarkdownPageToolStripMenuItem, Me.SepNewItem1, Me.NewTemplateToolStripMenuItem, Me.ToolStripMenuItem2, Me.SepNewItem2, Me.NewTextFileToolStripMenuItem, Me.NewStylesheetToolStripMenuItem, Me.NewJavaScriptToolStripMenuItem, Me.SepNewItem3, Me.AddFilesToolStripMenuItem})
        Me.NewItemBtn.Image = Global.AutoSite.My.Resources.Resources.NewFile_16x1
        resources.ApplyResources(Me.NewItemBtn, "NewItemBtn")
        Me.NewItemBtn.Name = "NewItemBtn"
        '
        'NewFolderTool
        '
        Me.NewFolderTool.Image = Global.AutoSite.My.Resources.Resources.Folder
        Me.NewFolderTool.Name = "NewFolderTool"
        resources.ApplyResources(Me.NewFolderTool, "NewFolderTool")
        '
        'SepNewItem0
        '
        Me.SepNewItem0.Name = "SepNewItem0"
        resources.ApplyResources(Me.SepNewItem0, "SepNewItem0")
        '
        'NewPageToolStripMenuItem
        '
        Me.NewPageToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.HTMLFile_16x
        Me.NewPageToolStripMenuItem.Name = "NewPageToolStripMenuItem"
        resources.ApplyResources(Me.NewPageToolStripMenuItem, "NewPageToolStripMenuItem")
        '
        'NewMarkdownPageToolStripMenuItem
        '
        Me.NewMarkdownPageToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.MarkdownFile_16x
        Me.NewMarkdownPageToolStripMenuItem.Name = "NewMarkdownPageToolStripMenuItem"
        resources.ApplyResources(Me.NewMarkdownPageToolStripMenuItem, "NewMarkdownPageToolStripMenuItem")
        '
        'SepNewItem1
        '
        Me.SepNewItem1.Name = "SepNewItem1"
        resources.ApplyResources(Me.SepNewItem1, "SepNewItem1")
        '
        'NewTemplateToolStripMenuItem
        '
        Me.NewTemplateToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.Template
        Me.NewTemplateToolStripMenuItem.Name = "NewTemplateToolStripMenuItem"
        resources.ApplyResources(Me.NewTemplateToolStripMenuItem, "NewTemplateToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.AutoSite.My.Resources.Resources.Structure_16x
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'SepNewItem2
        '
        Me.SepNewItem2.Name = "SepNewItem2"
        resources.ApplyResources(Me.SepNewItem2, "SepNewItem2")
        '
        'NewTextFileToolStripMenuItem
        '
        Me.NewTextFileToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.TextFile_16x
        Me.NewTextFileToolStripMenuItem.Name = "NewTextFileToolStripMenuItem"
        resources.ApplyResources(Me.NewTextFileToolStripMenuItem, "NewTextFileToolStripMenuItem")
        '
        'NewStylesheetToolStripMenuItem
        '
        Me.NewStylesheetToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.StyleSheet_16x
        Me.NewStylesheetToolStripMenuItem.Name = "NewStylesheetToolStripMenuItem"
        resources.ApplyResources(Me.NewStylesheetToolStripMenuItem, "NewStylesheetToolStripMenuItem")
        '
        'NewJavaScriptToolStripMenuItem
        '
        Me.NewJavaScriptToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.Script_16x
        Me.NewJavaScriptToolStripMenuItem.Name = "NewJavaScriptToolStripMenuItem"
        resources.ApplyResources(Me.NewJavaScriptToolStripMenuItem, "NewJavaScriptToolStripMenuItem")
        '
        'SepNewItem3
        '
        Me.SepNewItem3.Name = "SepNewItem3"
        resources.ApplyResources(Me.SepNewItem3, "SepNewItem3")
        '
        'AddFilesToolStripMenuItem
        '
        Me.AddFilesToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.NewFileCollection_16x
        Me.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem"
        resources.ApplyResources(Me.AddFilesToolStripMenuItem, "AddFilesToolStripMenuItem")
        '
        'ScriptingDropdown
        '
        Me.ScriptingDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ScriptingDropdown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScriptingToolStripMenuItem, Me.NewSpiceToolStripMenuItem, Me.ScriptGalleryToolStripMenuItem, Me.ToolStripSeparator1, Me.SpicesToolStripMenuItem, Me.ScriptingGuideToolStripMenuItem})
        Me.ScriptingDropdown.Image = Global.AutoSite.My.Resources.Resources.PY_16x
        resources.ApplyResources(Me.ScriptingDropdown, "ScriptingDropdown")
        Me.ScriptingDropdown.Name = "ScriptingDropdown"
        '
        'ScriptingToolStripMenuItem
        '
        Me.ScriptingToolStripMenuItem.Checked = True
        Me.ScriptingToolStripMenuItem.CheckOnClick = True
        Me.ScriptingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ScriptingToolStripMenuItem.Name = "ScriptingToolStripMenuItem"
        resources.ApplyResources(Me.ScriptingToolStripMenuItem, "ScriptingToolStripMenuItem")
        '
        'NewSpiceToolStripMenuItem
        '
        resources.ApplyResources(Me.NewSpiceToolStripMenuItem, "NewSpiceToolStripMenuItem")
        Me.NewSpiceToolStripMenuItem.Name = "NewSpiceToolStripMenuItem"
        '
        'ScriptGalleryToolStripMenuItem
        '
        Me.ScriptGalleryToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.PYClassLibrary_16x
        Me.ScriptGalleryToolStripMenuItem.Name = "ScriptGalleryToolStripMenuItem"
        resources.ApplyResources(Me.ScriptGalleryToolStripMenuItem, "ScriptGalleryToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'SpicesToolStripMenuItem
        '
        Me.SpicesToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.PYConsole_16x
        Me.SpicesToolStripMenuItem.Name = "SpicesToolStripMenuItem"
        resources.ApplyResources(Me.SpicesToolStripMenuItem, "SpicesToolStripMenuItem")
        '
        'ScriptingGuideToolStripMenuItem
        '
        Me.ScriptingGuideToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.HelpApplication_16x
        Me.ScriptingGuideToolStripMenuItem.Name = "ScriptingGuideToolStripMenuItem"
        resources.ApplyResources(Me.ScriptingGuideToolStripMenuItem, "ScriptingGuideToolStripMenuItem")
        '
        'SaveBtn
        '
        Me.SaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Image = Global.AutoSite.My.Resources.Resources.Save
        resources.ApplyResources(Me.SaveBtn, "SaveBtn")
        Me.SaveBtn.Name = "SaveBtn"
        '
        'SaveAllBtn
        '
        Me.SaveAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAllBtn.Image = Global.AutoSite.My.Resources.Resources.SaveAll
        resources.ApplyResources(Me.SaveAllBtn, "SaveAllBtn")
        Me.SaveAllBtn.Name = "SaveAllBtn"
        '
        'CloseBtn
        '
        Me.CloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.Name = "CloseBtn"
        '
        'Sep
        '
        Me.Sep.ForeColor = System.Drawing.Color.Black
        Me.Sep.Name = "Sep"
        resources.ApplyResources(Me.Sep, "Sep")
        '
        'CutBtn
        '
        Me.CutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutBtn.ForeColor = System.Drawing.Color.Black
        Me.CutBtn.Image = Global.AutoSite.My.Resources.Resources.Cut
        resources.ApplyResources(Me.CutBtn, "CutBtn")
        Me.CutBtn.Name = "CutBtn"
        '
        'CopyBtn
        '
        Me.CopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyBtn.ForeColor = System.Drawing.Color.Black
        Me.CopyBtn.Image = Global.AutoSite.My.Resources.Resources.Copy
        resources.ApplyResources(Me.CopyBtn, "CopyBtn")
        Me.CopyBtn.Name = "CopyBtn"
        '
        'PasteBtn
        '
        Me.PasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteBtn.ForeColor = System.Drawing.Color.Black
        Me.PasteBtn.Image = Global.AutoSite.My.Resources.Resources.Paste
        resources.ApplyResources(Me.PasteBtn, "PasteBtn")
        Me.PasteBtn.Name = "PasteBtn"
        '
        'InsertBtn
        '
        Me.InsertBtn.AutoToolTip = False
        Me.InsertBtn.ForeColor = System.Drawing.Color.Black
        Me.InsertBtn.Image = Global.AutoSite.My.Resources.Resources.Tag
        resources.ApplyResources(Me.InsertBtn, "InsertBtn")
        Me.InsertBtn.Name = "InsertBtn"
        '
        'Sep2
        '
        Me.Sep2.ForeColor = System.Drawing.Color.Black
        Me.Sep2.Name = "Sep2"
        resources.ApplyResources(Me.Sep2, "Sep2")
        '
        'FindBtn
        '
        Me.FindBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindBtn.ForeColor = System.Drawing.Color.Black
        Me.FindBtn.Image = Global.AutoSite.My.Resources.Resources.Search
        resources.ApplyResources(Me.FindBtn, "FindBtn")
        Me.FindBtn.Name = "FindBtn"
        '
        'ReplaceBtn
        '
        Me.ReplaceBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReplaceBtn.ForeColor = System.Drawing.Color.Black
        Me.ReplaceBtn.Image = Global.AutoSite.My.Resources.Resources.ReplaceAll
        resources.ApplyResources(Me.ReplaceBtn, "ReplaceBtn")
        Me.ReplaceBtn.Name = "ReplaceBtn"
        '
        'GotoBtn
        '
        Me.GotoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GotoBtn.ForeColor = System.Drawing.Color.Black
        Me.GotoBtn.Image = Global.AutoSite.My.Resources.Resources.GotoRow
        resources.ApplyResources(Me.GotoBtn, "GotoBtn")
        Me.GotoBtn.Name = "GotoBtn"
        '
        'Sep3
        '
        Me.Sep3.ForeColor = System.Drawing.Color.Black
        Me.Sep3.Name = "Sep3"
        resources.ApplyResources(Me.Sep3, "Sep3")
        '
        'UndoBtn
        '
        Me.UndoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoBtn.ForeColor = System.Drawing.Color.Black
        Me.UndoBtn.Image = Global.AutoSite.My.Resources.Resources.Undo
        resources.ApplyResources(Me.UndoBtn, "UndoBtn")
        Me.UndoBtn.Name = "UndoBtn"
        '
        'RedoBtn
        '
        Me.RedoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoBtn.ForeColor = System.Drawing.Color.Black
        Me.RedoBtn.Image = Global.AutoSite.My.Resources.Resources.Redo
        resources.ApplyResources(Me.RedoBtn, "RedoBtn")
        Me.RedoBtn.Name = "RedoBtn"
        '
        'Sep4
        '
        Me.Sep4.ForeColor = System.Drawing.Color.Black
        Me.Sep4.Name = "Sep4"
        resources.ApplyResources(Me.Sep4, "Sep4")
        '
        'PreviewBtn
        '
        Me.PreviewBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.PreviewBtn.ForeColor = System.Drawing.Color.Black
        Me.PreviewBtn.Image = Global.AutoSite.My.Resources.Resources.WebTest
        resources.ApplyResources(Me.PreviewBtn, "PreviewBtn")
        Me.PreviewBtn.Name = "PreviewBtn"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.CheckOnClick = True
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'Sep5
        '
        Me.Sep5.Name = "Sep5"
        resources.ApplyResources(Me.Sep5, "Sep5")
        '
        'BuildBtn
        '
        Me.BuildBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanBuildBtn, Me.OpenOutputFolderBtn})
        Me.BuildBtn.ForeColor = System.Drawing.Color.Black
        Me.BuildBtn.Image = Global.AutoSite.My.Resources.Resources.Build
        resources.ApplyResources(Me.BuildBtn, "BuildBtn")
        Me.BuildBtn.Name = "BuildBtn"
        '
        'CleanBuildBtn
        '
        Me.CleanBuildBtn.Image = Global.AutoSite.My.Resources.Resources.SanitaryBuild
        Me.CleanBuildBtn.Name = "CleanBuildBtn"
        resources.ApplyResources(Me.CleanBuildBtn, "CleanBuildBtn")
        '
        'OpenOutputFolderBtn
        '
        Me.OpenOutputFolderBtn.Image = Global.AutoSite.My.Resources.Resources.OpenFolder
        Me.OpenOutputFolderBtn.Name = "OpenOutputFolderBtn"
        resources.ApplyResources(Me.OpenOutputFolderBtn, "OpenOutputFolderBtn")
        '
        'ViewOutBtn
        '
        Me.ViewOutBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewinDefaultBrowser})
        Me.ViewOutBtn.ForeColor = System.Drawing.Color.Black
        Me.ViewOutBtn.Image = Global.AutoSite.My.Resources.Resources.Web
        resources.ApplyResources(Me.ViewOutBtn, "ViewOutBtn")
        Me.ViewOutBtn.Name = "ViewOutBtn"
        '
        'ViewinDefaultBrowser
        '
        Me.ViewinDefaultBrowser.Name = "ViewinDefaultBrowser"
        resources.ApplyResources(Me.ViewinDefaultBrowser, "ViewinDefaultBrowser")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ToolStripButton1
        '
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        resources.ApplyResources(Me.ToolStripContainer1.ContentPanel, "ToolStripContainer1.ContentPanel")
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.CoreSplit)
        resources.ApplyResources(Me.ToolStripContainer1, "ToolStripContainer1")
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        resources.ApplyResources(Me.ToolStripContainer1.LeftToolStripPanel, "ToolStripContainer1.LeftToolStripPanel")
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuBar)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.Strip)
        '
        'EditSep
        '
        Me.EditSep.MergeIndex = 2
        Me.EditSep.Name = "EditSep"
        resources.ApplyResources(Me.EditSep, "EditSep")
        '
        'EditSep2
        '
        Me.EditSep2.MergeIndex = 6
        Me.EditSep2.Name = "EditSep2"
        resources.ApplyResources(Me.EditSep2, "EditSep2")
        '
        'EditSep3
        '
        Me.EditSep3.MergeIndex = 8
        Me.EditSep3.Name = "EditSep3"
        resources.ApplyResources(Me.EditSep3, "EditSep3")
        '
        'EditSep4
        '
        Me.EditSep4.MergeIndex = 12
        Me.EditSep4.Name = "EditSep4"
        resources.ApplyResources(Me.EditSep4, "EditSep4")
        '
        'FormatSep
        '
        Me.FormatSep.MergeIndex = 3
        Me.FormatSep.Name = "FormatSep"
        resources.ApplyResources(Me.FormatSep, "FormatSep")
        '
        'FormatSep2
        '
        Me.FormatSep2.MergeIndex = 5
        Me.FormatSep2.Name = "FormatSep2"
        resources.ApplyResources(Me.FormatSep2, "FormatSep2")
        '
        'MenuItem3
        '
        Me.MenuItem3.MergeIndex = 5
        Me.MenuItem3.Name = "MenuItem3"
        resources.ApplyResources(Me.MenuItem3, "MenuItem3")
        '
        'ViewSep
        '
        Me.ViewSep.MergeIndex = 9
        Me.ViewSep.Name = "ViewSep"
        resources.ApplyResources(Me.ViewSep, "ViewSep")
        '
        'ToolsSep
        '
        Me.ToolsSep.MergeIndex = 2
        Me.ToolsSep.Name = "ToolsSep"
        resources.ApplyResources(Me.ToolsSep, "ToolsSep")
        '
        'MenuItem5
        '
        Me.MenuItem5.MergeIndex = 6
        Me.MenuItem5.Name = "MenuItem5"
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'HelpSep
        '
        Me.HelpSep.MergeIndex = 3
        Me.HelpSep.Name = "HelpSep"
        resources.ApplyResources(Me.HelpSep, "HelpSep")
        '
        'HelpSep2
        '
        Me.HelpSep2.MergeIndex = 7
        Me.HelpSep2.Name = "HelpSep2"
        resources.ApplyResources(Me.HelpSep2, "HelpSep2")
        '
        'HelpSep3
        '
        Me.HelpSep3.MergeIndex = 9
        Me.HelpSep3.Name = "HelpSep3"
        resources.ApplyResources(Me.HelpSep3, "HelpSep3")
        '
        'FileSep2
        '
        Me.FileSep2.MergeIndex = 4
        Me.FileSep2.Name = "FileSep2"
        resources.ApplyResources(Me.FileSep2, "FileSep2")
        '
        'FileSep3
        '
        Me.FileSep3.MergeIndex = 7
        Me.FileSep3.Name = "FileSep3"
        resources.ApplyResources(Me.FileSep3, "FileSep3")
        '
        'FileSep4
        '
        Me.FileSep4.MergeIndex = 9
        Me.FileSep4.Name = "FileSep4"
        resources.ApplyResources(Me.FileSep4, "FileSep4")
        '
        'ContextSep3
        '
        Me.ContextSep3.MergeIndex = 10
        Me.ContextSep3.Name = "ContextSep3"
        resources.ApplyResources(Me.ContextSep3, "ContextSep3")
        '
        'ContextSep2
        '
        Me.ContextSep2.MergeIndex = 7
        Me.ContextSep2.Name = "ContextSep2"
        resources.ApplyResources(Me.ContextSep2, "ContextSep2")
        '
        'ContextSep
        '
        Me.ContextSep.MergeIndex = 3
        Me.ContextSep.Name = "ContextSep"
        resources.ApplyResources(Me.ContextSep, "ContextSep")
        '
        'RecentSep
        '
        Me.RecentSep.MergeIndex = 5
        Me.RecentSep.Name = "RecentSep"
        resources.ApplyResources(Me.RecentSep, "RecentSep")
        '
        'NewSep
        '
        Me.NewSep.MergeIndex = 1
        Me.NewSep.Name = "NewSep"
        resources.ApplyResources(Me.NewSep, "NewSep")
        '
        'NewSep2
        '
        Me.NewSep2.MergeIndex = 5
        Me.NewSep2.Name = "NewSep2"
        resources.ApplyResources(Me.NewSep2, "NewSep2")
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = Global.AutoSite.My.Resources.Resources.autosite_32
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "Main"
        Me.EdSplit.Panel1.ResumeLayout(False)
        Me.EdSplit.Panel2.ResumeLayout(False)
        Me.EdSplit.ResumeLayout(False)
        Me.ExSplit.Panel1.ResumeLayout(False)
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
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.Context.ResumeLayout(False)
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogMenu.ResumeLayout(False)
        Me.Strip.ResumeLayout(False)
        Me.Strip.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VS2017 As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplorerPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditorPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordWrap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VirtualSpace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WideCaret As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconThemeMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VS2017item As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XP As System.Windows.Forms.ImageList
    Friend WithEvents XPitem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenInDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFolderCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewHTMLCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMDCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFilesCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFilesDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NewPHPCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApricotWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents FormatMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LivePreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Watcher As System.IO.FileSystemWatcher
    Friend WithEvents RenameCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCSSCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoreSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents ExSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents BuildProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents BuildStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenOutput As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseSitePreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseSite As System.Windows.Forms.ToolStripButton
    Friend WithEvents EdSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents EditTabs As System.Windows.Forms.TabControl
    Friend WithEvents Preview As System.Windows.Forms.WebBrowser
    Friend WithEvents EditorFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectFont As System.Windows.Forms.FontDialog
    Friend WithEvents NewJSCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTXTCon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SanitaryBuild As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recent1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recent2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recent3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recent4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recent5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearRecents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenRecent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpTopics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendFeedback As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenOutputMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Redo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertConditional As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Find As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Replace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Website As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GitHub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveLogDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LogMenuBridge As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenPack As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SystemIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickstartMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents SanitaryBuildBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents QuickInsertMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApricotTabs As System.Windows.Forms.TabControl
    Friend WithEvents LogPage As System.Windows.Forms.TabPage
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents MapPage As System.Windows.Forms.TabPage
    Friend WithEvents InspectorBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cDark As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttributeExplanation As System.Windows.Forms.Label
    Friend WithEvents AttributeTree As System.Windows.Forms.TreeView
    Friend WithEvents LanguageMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishLang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpanishLang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PolishLang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WelshLang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenSampleSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Strip As System.Windows.Forms.ToolStrip
    Friend WithEvents Sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents RedoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents GotoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReplaceBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents InsertBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreviewBtn As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOutBtn As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ViewinDefaultBrowser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSiteBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveAllBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenSiteBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewItemBtn As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NewFolderTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepNewItem0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMarkdownPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepNewItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepNewItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewStylesheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewJavaScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepNewItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFileOutput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseSiteMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseSitePreviewMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuildBtn As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CleanBuildBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenOutputFolderBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplorerAttributes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiteTree As System.Windows.Forms.TreeView
    Friend WithEvents MenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptingDropdown As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ScriptingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSpiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SpicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptingGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents EditSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormatSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolsSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RecentSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewSep2 As System.Windows.Forms.ToolStripSeparator
End Class

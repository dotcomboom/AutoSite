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
        Me.VS2017 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuBar = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMenu = New System.Windows.Forms.MenuItem()
        Me.NewSite = New System.Windows.Forms.MenuItem()
        Me.OpenFolder = New System.Windows.Forms.MenuItem()
        Me.CloseFile = New System.Windows.Forms.MenuItem()
        Me.CloseSite = New System.Windows.Forms.MenuItem()
        Me.FileSep2 = New System.Windows.Forms.MenuItem()
        Me.Save = New System.Windows.Forms.MenuItem()
        Me.SaveAll = New System.Windows.Forms.MenuItem()
        Me.FileSep3 = New System.Windows.Forms.MenuItem()
        Me.OpenRecent = New System.Windows.Forms.MenuItem()
        Me.Recent1 = New System.Windows.Forms.MenuItem()
        Me.Recent2 = New System.Windows.Forms.MenuItem()
        Me.Recent3 = New System.Windows.Forms.MenuItem()
        Me.Recent4 = New System.Windows.Forms.MenuItem()
        Me.Recent5 = New System.Windows.Forms.MenuItem()
        Me.RecentSep = New System.Windows.Forms.MenuItem()
        Me.ClearRecents = New System.Windows.Forms.MenuItem()
        Me.FileSep4 = New System.Windows.Forms.MenuItem()
        Me.ExitItem = New System.Windows.Forms.MenuItem()
        Me.EditMenu = New System.Windows.Forms.MenuItem()
        Me.Undo = New System.Windows.Forms.MenuItem()
        Me.Redo = New System.Windows.Forms.MenuItem()
        Me.EditSep = New System.Windows.Forms.MenuItem()
        Me.Cut = New System.Windows.Forms.MenuItem()
        Me.Copy = New System.Windows.Forms.MenuItem()
        Me.Paste = New System.Windows.Forms.MenuItem()
        Me.EditSep2 = New System.Windows.Forms.MenuItem()
        Me.SelectAll = New System.Windows.Forms.MenuItem()
        Me.EditSep3 = New System.Windows.Forms.MenuItem()
        Me.Find = New System.Windows.Forms.MenuItem()
        Me.Replace = New System.Windows.Forms.MenuItem()
        Me.GoToMnu = New System.Windows.Forms.MenuItem()
        Me.EditSep4 = New System.Windows.Forms.MenuItem()
        Me.QuickInsertMnu = New System.Windows.Forms.MenuItem()
        Me.InsertConditional = New System.Windows.Forms.MenuItem()
        Me.FormatMenu = New System.Windows.Forms.MenuItem()
        Me.WordWrap = New System.Windows.Forms.MenuItem()
        Me.VirtualSpace = New System.Windows.Forms.MenuItem()
        Me.WideCaret = New System.Windows.Forms.MenuItem()
        Me.FormatSep = New System.Windows.Forms.MenuItem()
        Me.SyntaxHighlight = New System.Windows.Forms.MenuItem()
        Me.LivePreview = New System.Windows.Forms.MenuItem()
        Me.FormatSep2 = New System.Windows.Forms.MenuItem()
        Me.EditorFont = New System.Windows.Forms.MenuItem()
        Me.ViewMenu = New System.Windows.Forms.MenuItem()
        Me.ExplorerPanel = New System.Windows.Forms.MenuItem()
        Me.BuildPanel = New System.Windows.Forms.MenuItem()
        Me.EditorPanel = New System.Windows.Forms.MenuItem()
        Me.PreviewPanel = New System.Windows.Forms.MenuItem()
        Me.StatusBarMnu = New System.Windows.Forms.MenuItem()
        Me.ViewSep = New System.Windows.Forms.MenuItem()
        Me.IconThemeMenu = New System.Windows.Forms.MenuItem()
        Me.VS2017item = New System.Windows.Forms.MenuItem()
        Me.XPitem = New System.Windows.Forms.MenuItem()
        Me.ColorScheme = New System.Windows.Forms.MenuItem()
        Me.cDefault = New System.Windows.Forms.MenuItem()
        Me.cDark = New System.Windows.Forms.MenuItem()
        Me.SystemIcons = New System.Windows.Forms.MenuItem()
        Me.RefreshItem = New System.Windows.Forms.MenuItem()
        Me.BuildMenu = New System.Windows.Forms.MenuItem()
        Me.BuildSite = New System.Windows.Forms.MenuItem()
        Me.SanitaryBuild = New System.Windows.Forms.MenuItem()
        Me.BuildShortcut = New System.Windows.Forms.MenuItem()
        Me.ToolsSep = New System.Windows.Forms.MenuItem()
        Me.PreviewPage = New System.Windows.Forms.MenuItem()
        Me.ViewFileOutput = New System.Windows.Forms.MenuItem()
        Me.OpenOutputMnu = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.BrowseSiteMnu = New System.Windows.Forms.MenuItem()
        Me.BrowseSitePreviewMnu = New System.Windows.Forms.MenuItem()
        Me.HelpMenu = New System.Windows.Forms.MenuItem()
        Me.HelpTopics = New System.Windows.Forms.MenuItem()
        Me.QuickstartMnu = New System.Windows.Forms.MenuItem()
        Me.OpenSampleSite = New System.Windows.Forms.MenuItem()
        Me.HelpSep = New System.Windows.Forms.MenuItem()
        Me.Website = New System.Windows.Forms.MenuItem()
        Me.GitHub = New System.Windows.Forms.MenuItem()
        Me.SendFeedback = New System.Windows.Forms.MenuItem()
        Me.HelpSep2 = New System.Windows.Forms.MenuItem()
        Me.InspectorBtn = New System.Windows.Forms.MenuItem()
        Me.LanguageMenu = New System.Windows.Forms.MenuItem()
        Me.EnglishLang = New System.Windows.Forms.MenuItem()
        Me.SpanishLang = New System.Windows.Forms.MenuItem()
        Me.PolishLang = New System.Windows.Forms.MenuItem()
        Me.WelshLang = New System.Windows.Forms.MenuItem()
        Me.ShowVersion = New System.Windows.Forms.MenuItem()
        Me.HelpSep3 = New System.Windows.Forms.MenuItem()
        Me.AboutItem = New System.Windows.Forms.MenuItem()
        Me.XP = New System.Windows.Forms.ImageList(Me.components)
        Me.Context = New System.Windows.Forms.ContextMenu()
        Me.OpenContext = New System.Windows.Forms.MenuItem()
        Me.OpenInDefault = New System.Windows.Forms.MenuItem()
        Me.OpenFileLocation = New System.Windows.Forms.MenuItem()
        Me.ContextSep = New System.Windows.Forms.MenuItem()
        Me.CopyCon = New System.Windows.Forms.MenuItem()
        Me.PasteCon = New System.Windows.Forms.MenuItem()
        Me.AddFilesCon = New System.Windows.Forms.MenuItem()
        Me.ContextSep2 = New System.Windows.Forms.MenuItem()
        Me.DeleteCon = New System.Windows.Forms.MenuItem()
        Me.RenameCon = New System.Windows.Forms.MenuItem()
        Me.ContextSep3 = New System.Windows.Forms.MenuItem()
        Me.NewCon = New System.Windows.Forms.MenuItem()
        Me.NewFolderCon = New System.Windows.Forms.MenuItem()
        Me.NewSep = New System.Windows.Forms.MenuItem()
        Me.NewHTMLCon = New System.Windows.Forms.MenuItem()
        Me.NewMDCon = New System.Windows.Forms.MenuItem()
        Me.NewPHPCon = New System.Windows.Forms.MenuItem()
        Me.NewSep2 = New System.Windows.Forms.MenuItem()
        Me.NewCSSCon = New System.Windows.Forms.MenuItem()
        Me.NewJSCon = New System.Windows.Forms.MenuItem()
        Me.NewTXTCon = New System.Windows.Forms.MenuItem()
        Me.AddFilesDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ApricotWorker = New System.ComponentModel.BackgroundWorker()
        Me.Watcher = New System.IO.FileSystemWatcher()
        Me.EdSplit = New System.Windows.Forms.SplitContainer()
        Me.EditTabs = New System.Windows.Forms.TabControl()
        Me.Preview = New System.Windows.Forms.WebBrowser()
        Me.ExSplit = New System.Windows.Forms.SplitContainer()
        Me.SiteTree = New System.Windows.Forms.TreeView()
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
        Me.SelectFont = New System.Windows.Forms.FontDialog()
        Me.LogMenu = New System.Windows.Forms.ContextMenu()
        Me.SaveLog = New System.Windows.Forms.MenuItem()
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
        Me.Sep = New System.Windows.Forms.ToolStripSeparator()
        Me.CutBtn = New System.Windows.Forms.ToolStripButton()
        Me.CopyBtn = New System.Windows.Forms.ToolStripButton()
        Me.PasteBtn = New System.Windows.Forms.ToolStripButton()
        Me.InsertBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseBtn = New System.Windows.Forms.ToolStripButton()
        Me.FindBtn = New System.Windows.Forms.ToolStripButton()
        Me.ReplaceBtn = New System.Windows.Forms.ToolStripButton()
        Me.GotoBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoBtn = New System.Windows.Forms.ToolStripButton()
        Me.RedoBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviewBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOutBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.ViewinDefaultBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuildBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.CleanBuildBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOutputFolderBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.ApriStatus = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.Strip.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'VS2017
        '
        Me.VS2017.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.VS2017, "VS2017")
        Me.VS2017.TransparentColor = System.Drawing.Color.Transparent
        '
        'FolderBrowser
        '
        resources.ApplyResources(Me.FolderBrowser, "FolderBrowser")
        '
        'MenuBar
        '
        Me.MenuBar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.EditMenu, Me.FormatMenu, Me.ViewMenu, Me.BuildMenu, Me.HelpMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewSite, Me.OpenFolder, Me.CloseFile, Me.CloseSite, Me.FileSep2, Me.Save, Me.SaveAll, Me.FileSep3, Me.OpenRecent, Me.FileSep4, Me.ExitItem})
        resources.ApplyResources(Me.FileMenu, "FileMenu")
        '
        'NewSite
        '
        Me.NewSite.Index = 0
        resources.ApplyResources(Me.NewSite, "NewSite")
        '
        'OpenFolder
        '
        Me.OpenFolder.Index = 1
        resources.ApplyResources(Me.OpenFolder, "OpenFolder")
        '
        'CloseFile
        '
        Me.CloseFile.Index = 2
        resources.ApplyResources(Me.CloseFile, "CloseFile")
        '
        'CloseSite
        '
        resources.ApplyResources(Me.CloseSite, "CloseSite")
        Me.CloseSite.Index = 3
        '
        'FileSep2
        '
        Me.FileSep2.Index = 4
        resources.ApplyResources(Me.FileSep2, "FileSep2")
        '
        'Save
        '
        Me.Save.Index = 5
        resources.ApplyResources(Me.Save, "Save")
        '
        'SaveAll
        '
        Me.SaveAll.Index = 6
        resources.ApplyResources(Me.SaveAll, "SaveAll")
        '
        'FileSep3
        '
        Me.FileSep3.Index = 7
        resources.ApplyResources(Me.FileSep3, "FileSep3")
        '
        'OpenRecent
        '
        Me.OpenRecent.Index = 8
        Me.OpenRecent.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Recent1, Me.Recent2, Me.Recent3, Me.Recent4, Me.Recent5, Me.RecentSep, Me.ClearRecents})
        resources.ApplyResources(Me.OpenRecent, "OpenRecent")
        '
        'Recent1
        '
        Me.Recent1.Index = 0
        resources.ApplyResources(Me.Recent1, "Recent1")
        '
        'Recent2
        '
        Me.Recent2.Index = 1
        resources.ApplyResources(Me.Recent2, "Recent2")
        '
        'Recent3
        '
        Me.Recent3.Index = 2
        resources.ApplyResources(Me.Recent3, "Recent3")
        '
        'Recent4
        '
        Me.Recent4.Index = 3
        resources.ApplyResources(Me.Recent4, "Recent4")
        '
        'Recent5
        '
        Me.Recent5.Index = 4
        resources.ApplyResources(Me.Recent5, "Recent5")
        '
        'RecentSep
        '
        Me.RecentSep.Index = 5
        resources.ApplyResources(Me.RecentSep, "RecentSep")
        '
        'ClearRecents
        '
        Me.ClearRecents.Index = 6
        resources.ApplyResources(Me.ClearRecents, "ClearRecents")
        '
        'FileSep4
        '
        Me.FileSep4.Index = 9
        resources.ApplyResources(Me.FileSep4, "FileSep4")
        '
        'ExitItem
        '
        Me.ExitItem.Index = 10
        resources.ApplyResources(Me.ExitItem, "ExitItem")
        '
        'EditMenu
        '
        Me.EditMenu.Index = 1
        Me.EditMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Undo, Me.Redo, Me.EditSep, Me.Cut, Me.Copy, Me.Paste, Me.EditSep2, Me.SelectAll, Me.EditSep3, Me.Find, Me.Replace, Me.GoToMnu, Me.EditSep4, Me.QuickInsertMnu, Me.InsertConditional})
        resources.ApplyResources(Me.EditMenu, "EditMenu")
        '
        'Undo
        '
        Me.Undo.Index = 0
        resources.ApplyResources(Me.Undo, "Undo")
        '
        'Redo
        '
        Me.Redo.Index = 1
        resources.ApplyResources(Me.Redo, "Redo")
        '
        'EditSep
        '
        Me.EditSep.Index = 2
        resources.ApplyResources(Me.EditSep, "EditSep")
        '
        'Cut
        '
        Me.Cut.Index = 3
        resources.ApplyResources(Me.Cut, "Cut")
        '
        'Copy
        '
        Me.Copy.Index = 4
        resources.ApplyResources(Me.Copy, "Copy")
        '
        'Paste
        '
        Me.Paste.Index = 5
        resources.ApplyResources(Me.Paste, "Paste")
        '
        'EditSep2
        '
        Me.EditSep2.Index = 6
        resources.ApplyResources(Me.EditSep2, "EditSep2")
        '
        'SelectAll
        '
        Me.SelectAll.Index = 7
        resources.ApplyResources(Me.SelectAll, "SelectAll")
        '
        'EditSep3
        '
        Me.EditSep3.Index = 8
        resources.ApplyResources(Me.EditSep3, "EditSep3")
        '
        'Find
        '
        Me.Find.Index = 9
        resources.ApplyResources(Me.Find, "Find")
        '
        'Replace
        '
        Me.Replace.Index = 10
        resources.ApplyResources(Me.Replace, "Replace")
        '
        'GoToMnu
        '
        Me.GoToMnu.Index = 11
        resources.ApplyResources(Me.GoToMnu, "GoToMnu")
        '
        'EditSep4
        '
        Me.EditSep4.Index = 12
        resources.ApplyResources(Me.EditSep4, "EditSep4")
        '
        'QuickInsertMnu
        '
        Me.QuickInsertMnu.Index = 13
        resources.ApplyResources(Me.QuickInsertMnu, "QuickInsertMnu")
        '
        'InsertConditional
        '
        Me.InsertConditional.Index = 14
        resources.ApplyResources(Me.InsertConditional, "InsertConditional")
        '
        'FormatMenu
        '
        Me.FormatMenu.Index = 2
        Me.FormatMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WordWrap, Me.VirtualSpace, Me.WideCaret, Me.FormatSep, Me.SyntaxHighlight, Me.LivePreview, Me.FormatSep2, Me.EditorFont})
        resources.ApplyResources(Me.FormatMenu, "FormatMenu")
        '
        'WordWrap
        '
        Me.WordWrap.Checked = True
        Me.WordWrap.Index = 0
        resources.ApplyResources(Me.WordWrap, "WordWrap")
        '
        'VirtualSpace
        '
        Me.VirtualSpace.Index = 1
        resources.ApplyResources(Me.VirtualSpace, "VirtualSpace")
        '
        'WideCaret
        '
        Me.WideCaret.Index = 2
        resources.ApplyResources(Me.WideCaret, "WideCaret")
        '
        'FormatSep
        '
        Me.FormatSep.Index = 3
        resources.ApplyResources(Me.FormatSep, "FormatSep")
        '
        'SyntaxHighlight
        '
        Me.SyntaxHighlight.Index = 4
        resources.ApplyResources(Me.SyntaxHighlight, "SyntaxHighlight")
        '
        'LivePreview
        '
        Me.LivePreview.Index = 5
        resources.ApplyResources(Me.LivePreview, "LivePreview")
        '
        'FormatSep2
        '
        Me.FormatSep2.Index = 6
        resources.ApplyResources(Me.FormatSep2, "FormatSep2")
        '
        'EditorFont
        '
        Me.EditorFont.Index = 7
        resources.ApplyResources(Me.EditorFont, "EditorFont")
        '
        'ViewMenu
        '
        Me.ViewMenu.Index = 3
        Me.ViewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ExplorerPanel, Me.BuildPanel, Me.EditorPanel, Me.PreviewPanel, Me.StatusBarMnu, Me.ViewSep, Me.IconThemeMenu, Me.ColorScheme, Me.SystemIcons, Me.RefreshItem})
        resources.ApplyResources(Me.ViewMenu, "ViewMenu")
        '
        'ExplorerPanel
        '
        Me.ExplorerPanel.Checked = True
        Me.ExplorerPanel.Index = 0
        resources.ApplyResources(Me.ExplorerPanel, "ExplorerPanel")
        '
        'BuildPanel
        '
        Me.BuildPanel.Checked = True
        Me.BuildPanel.Index = 1
        resources.ApplyResources(Me.BuildPanel, "BuildPanel")
        '
        'EditorPanel
        '
        Me.EditorPanel.Checked = True
        Me.EditorPanel.Index = 2
        resources.ApplyResources(Me.EditorPanel, "EditorPanel")
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Checked = True
        Me.PreviewPanel.Index = 3
        resources.ApplyResources(Me.PreviewPanel, "PreviewPanel")
        '
        'StatusBarMnu
        '
        Me.StatusBarMnu.Checked = True
        Me.StatusBarMnu.Index = 4
        resources.ApplyResources(Me.StatusBarMnu, "StatusBarMnu")
        '
        'ViewSep
        '
        Me.ViewSep.Index = 5
        resources.ApplyResources(Me.ViewSep, "ViewSep")
        '
        'IconThemeMenu
        '
        Me.IconThemeMenu.Index = 6
        Me.IconThemeMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.VS2017item, Me.XPitem})
        resources.ApplyResources(Me.IconThemeMenu, "IconThemeMenu")
        '
        'VS2017item
        '
        Me.VS2017item.Index = 0
        Me.VS2017item.RadioCheck = True
        resources.ApplyResources(Me.VS2017item, "VS2017item")
        '
        'XPitem
        '
        Me.XPitem.Index = 1
        Me.XPitem.RadioCheck = True
        resources.ApplyResources(Me.XPitem, "XPitem")
        '
        'ColorScheme
        '
        Me.ColorScheme.Index = 7
        Me.ColorScheme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cDefault, Me.cDark})
        resources.ApplyResources(Me.ColorScheme, "ColorScheme")
        '
        'cDefault
        '
        Me.cDefault.Checked = True
        Me.cDefault.Index = 0
        resources.ApplyResources(Me.cDefault, "cDefault")
        '
        'cDark
        '
        Me.cDark.Index = 1
        resources.ApplyResources(Me.cDark, "cDark")
        '
        'SystemIcons
        '
        Me.SystemIcons.Checked = True
        Me.SystemIcons.Index = 8
        resources.ApplyResources(Me.SystemIcons, "SystemIcons")
        '
        'RefreshItem
        '
        Me.RefreshItem.Index = 9
        resources.ApplyResources(Me.RefreshItem, "RefreshItem")
        '
        'BuildMenu
        '
        Me.BuildMenu.Index = 4
        Me.BuildMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BuildSite, Me.SanitaryBuild, Me.BuildShortcut, Me.ToolsSep, Me.PreviewPage, Me.ViewFileOutput, Me.OpenOutputMnu, Me.MenuItem5, Me.BrowseSiteMnu, Me.BrowseSitePreviewMnu})
        resources.ApplyResources(Me.BuildMenu, "BuildMenu")
        '
        'BuildSite
        '
        Me.BuildSite.Index = 0
        resources.ApplyResources(Me.BuildSite, "BuildSite")
        '
        'SanitaryBuild
        '
        Me.SanitaryBuild.Index = 1
        resources.ApplyResources(Me.SanitaryBuild, "SanitaryBuild")
        '
        'BuildShortcut
        '
        Me.BuildShortcut.Index = 2
        resources.ApplyResources(Me.BuildShortcut, "BuildShortcut")
        '
        'ToolsSep
        '
        Me.ToolsSep.Index = 3
        resources.ApplyResources(Me.ToolsSep, "ToolsSep")
        '
        'PreviewPage
        '
        Me.PreviewPage.Index = 4
        resources.ApplyResources(Me.PreviewPage, "PreviewPage")
        '
        'ViewFileOutput
        '
        Me.ViewFileOutput.Index = 5
        resources.ApplyResources(Me.ViewFileOutput, "ViewFileOutput")
        '
        'OpenOutputMnu
        '
        Me.OpenOutputMnu.Index = 6
        resources.ApplyResources(Me.OpenOutputMnu, "OpenOutputMnu")
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 7
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'BrowseSiteMnu
        '
        Me.BrowseSiteMnu.Index = 8
        resources.ApplyResources(Me.BrowseSiteMnu, "BrowseSiteMnu")
        '
        'BrowseSitePreviewMnu
        '
        Me.BrowseSitePreviewMnu.Index = 9
        resources.ApplyResources(Me.BrowseSitePreviewMnu, "BrowseSitePreviewMnu")
        '
        'HelpMenu
        '
        Me.HelpMenu.Index = 5
        Me.HelpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HelpTopics, Me.QuickstartMnu, Me.OpenSampleSite, Me.HelpSep, Me.Website, Me.GitHub, Me.SendFeedback, Me.HelpSep2, Me.InspectorBtn, Me.LanguageMenu, Me.ShowVersion, Me.HelpSep3, Me.AboutItem})
        resources.ApplyResources(Me.HelpMenu, "HelpMenu")
        '
        'HelpTopics
        '
        Me.HelpTopics.Index = 0
        resources.ApplyResources(Me.HelpTopics, "HelpTopics")
        '
        'QuickstartMnu
        '
        Me.QuickstartMnu.Index = 1
        resources.ApplyResources(Me.QuickstartMnu, "QuickstartMnu")
        '
        'OpenSampleSite
        '
        Me.OpenSampleSite.Index = 2
        resources.ApplyResources(Me.OpenSampleSite, "OpenSampleSite")
        '
        'HelpSep
        '
        Me.HelpSep.Index = 3
        resources.ApplyResources(Me.HelpSep, "HelpSep")
        '
        'Website
        '
        Me.Website.Index = 4
        resources.ApplyResources(Me.Website, "Website")
        '
        'GitHub
        '
        Me.GitHub.Index = 5
        resources.ApplyResources(Me.GitHub, "GitHub")
        '
        'SendFeedback
        '
        Me.SendFeedback.Index = 6
        resources.ApplyResources(Me.SendFeedback, "SendFeedback")
        '
        'HelpSep2
        '
        Me.HelpSep2.Index = 7
        resources.ApplyResources(Me.HelpSep2, "HelpSep2")
        '
        'InspectorBtn
        '
        resources.ApplyResources(Me.InspectorBtn, "InspectorBtn")
        Me.InspectorBtn.Index = 8
        '
        'LanguageMenu
        '
        Me.LanguageMenu.Index = 9
        Me.LanguageMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.EnglishLang, Me.SpanishLang, Me.PolishLang, Me.WelshLang})
        resources.ApplyResources(Me.LanguageMenu, "LanguageMenu")
        '
        'EnglishLang
        '
        Me.EnglishLang.Index = 0
        Me.EnglishLang.Tag = "en-US"
        resources.ApplyResources(Me.EnglishLang, "EnglishLang")
        '
        'SpanishLang
        '
        Me.SpanishLang.Index = 1
        Me.SpanishLang.Tag = "es-ES"
        resources.ApplyResources(Me.SpanishLang, "SpanishLang")
        '
        'PolishLang
        '
        Me.PolishLang.Index = 2
        Me.PolishLang.Tag = "pl-PL"
        resources.ApplyResources(Me.PolishLang, "PolishLang")
        '
        'WelshLang
        '
        Me.WelshLang.Index = 3
        Me.WelshLang.Tag = "cy-GB"
        resources.ApplyResources(Me.WelshLang, "WelshLang")
        '
        'ShowVersion
        '
        Me.ShowVersion.Index = 10
        resources.ApplyResources(Me.ShowVersion, "ShowVersion")
        '
        'HelpSep3
        '
        Me.HelpSep3.Index = 11
        resources.ApplyResources(Me.HelpSep3, "HelpSep3")
        '
        'AboutItem
        '
        Me.AboutItem.Index = 12
        resources.ApplyResources(Me.AboutItem, "AboutItem")
        '
        'XP
        '
        Me.XP.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.XP, "XP")
        Me.XP.TransparentColor = System.Drawing.Color.Transparent
        '
        'Context
        '
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenContext, Me.OpenInDefault, Me.OpenFileLocation, Me.ContextSep, Me.CopyCon, Me.PasteCon, Me.AddFilesCon, Me.ContextSep2, Me.DeleteCon, Me.RenameCon, Me.ContextSep3, Me.NewCon})
        '
        'OpenContext
        '
        Me.OpenContext.Index = 0
        resources.ApplyResources(Me.OpenContext, "OpenContext")
        '
        'OpenInDefault
        '
        Me.OpenInDefault.Index = 1
        resources.ApplyResources(Me.OpenInDefault, "OpenInDefault")
        '
        'OpenFileLocation
        '
        Me.OpenFileLocation.Index = 2
        resources.ApplyResources(Me.OpenFileLocation, "OpenFileLocation")
        '
        'ContextSep
        '
        Me.ContextSep.Index = 3
        resources.ApplyResources(Me.ContextSep, "ContextSep")
        '
        'CopyCon
        '
        Me.CopyCon.Index = 4
        resources.ApplyResources(Me.CopyCon, "CopyCon")
        '
        'PasteCon
        '
        Me.PasteCon.Index = 5
        resources.ApplyResources(Me.PasteCon, "PasteCon")
        '
        'AddFilesCon
        '
        Me.AddFilesCon.Index = 6
        resources.ApplyResources(Me.AddFilesCon, "AddFilesCon")
        '
        'ContextSep2
        '
        Me.ContextSep2.Index = 7
        resources.ApplyResources(Me.ContextSep2, "ContextSep2")
        '
        'DeleteCon
        '
        Me.DeleteCon.Index = 8
        resources.ApplyResources(Me.DeleteCon, "DeleteCon")
        '
        'RenameCon
        '
        Me.RenameCon.Index = 9
        resources.ApplyResources(Me.RenameCon, "RenameCon")
        '
        'ContextSep3
        '
        Me.ContextSep3.Index = 10
        resources.ApplyResources(Me.ContextSep3, "ContextSep3")
        '
        'NewCon
        '
        Me.NewCon.Index = 11
        Me.NewCon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewFolderCon, Me.NewSep, Me.NewHTMLCon, Me.NewMDCon, Me.NewPHPCon, Me.NewSep2, Me.NewCSSCon, Me.NewJSCon, Me.NewTXTCon})
        resources.ApplyResources(Me.NewCon, "NewCon")
        '
        'NewFolderCon
        '
        Me.NewFolderCon.Index = 0
        resources.ApplyResources(Me.NewFolderCon, "NewFolderCon")
        '
        'NewSep
        '
        Me.NewSep.Index = 1
        resources.ApplyResources(Me.NewSep, "NewSep")
        '
        'NewHTMLCon
        '
        Me.NewHTMLCon.Index = 2
        resources.ApplyResources(Me.NewHTMLCon, "NewHTMLCon")
        '
        'NewMDCon
        '
        Me.NewMDCon.Index = 3
        resources.ApplyResources(Me.NewMDCon, "NewMDCon")
        '
        'NewPHPCon
        '
        Me.NewPHPCon.Index = 4
        resources.ApplyResources(Me.NewPHPCon, "NewPHPCon")
        '
        'NewSep2
        '
        Me.NewSep2.Index = 5
        resources.ApplyResources(Me.NewSep2, "NewSep2")
        '
        'NewCSSCon
        '
        Me.NewCSSCon.Index = 6
        resources.ApplyResources(Me.NewCSSCon, "NewCSSCon")
        '
        'NewJSCon
        '
        Me.NewJSCon.Index = 7
        resources.ApplyResources(Me.NewJSCon, "NewJSCon")
        '
        'NewTXTCon
        '
        Me.NewTXTCon.Index = 8
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
        'EdSplit
        '
        resources.ApplyResources(Me.EdSplit, "EdSplit")
        Me.EdSplit.Name = "EdSplit"
        '
        'EdSplit.Panel1
        '
        Me.EdSplit.Panel1.Controls.Add(Me.EditTabs)
        '
        'EdSplit.Panel2
        '
        Me.EdSplit.Panel2.Controls.Add(Me.Preview)
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
        '
        'ExSplit.Panel2
        '
        Me.ExSplit.Panel2.Controls.Add(Me.ApricotTabs)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildProgress)
        Me.ExSplit.Panel2.Controls.Add(Me.BuildStrip)
        '
        'SiteTree
        '
        resources.ApplyResources(Me.SiteTree, "SiteTree")
        Me.SiteTree.HotTracking = True
        Me.SiteTree.ImageList = Me.VS2017
        Me.SiteTree.LabelEdit = True
        Me.SiteTree.Name = "SiteTree"
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
        '
        'CoreSplit.Panel2
        '
        Me.CoreSplit.Panel2.Controls.Add(Me.EdSplit)
        '
        'LogMenu
        '
        Me.LogMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.SaveLog})
        '
        'SaveLog
        '
        Me.SaveLog.Index = 0
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
        Me.Strip.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSiteBtn, Me.OpenSiteBtn, Me.NewItemBtn, Me.ScriptingDropdown, Me.SaveBtn, Me.SaveAllBtn, Me.Sep, Me.CutBtn, Me.CopyBtn, Me.PasteBtn, Me.InsertBtn, Me.Sep2, Me.CloseBtn, Me.FindBtn, Me.ReplaceBtn, Me.GotoBtn, Me.Sep3, Me.UndoBtn, Me.RedoBtn, Me.Sep4, Me.PreviewBtn, Me.Sep5, Me.BuildBtn, Me.ViewOutBtn})
        Me.Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        resources.ApplyResources(Me.Strip, "Strip")
        Me.Strip.Name = "Strip"
        Me.Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
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
        resources.ApplyResources(Me.ScriptingDropdown, "ScriptingDropdown")
        Me.ScriptingDropdown.Image = Global.AutoSite.My.Resources.Resources.PY_16x
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
        'CloseBtn
        '
        Me.CloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.Name = "CloseBtn"
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
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriStatus})
        resources.ApplyResources(Me.StatusBar, "StatusBar")
        Me.StatusBar.Name = "StatusBar"
        '
        'ApriStatus
        '
        Me.ApriStatus.Name = "ApriStatus"
        resources.ApplyResources(Me.ApriStatus, "ApriStatus")
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Strip)
        Me.Controls.Add(Me.CoreSplit)
        Me.Icon = Global.AutoSite.My.Resources.Resources.autosite_32
        Me.Menu = Me.MenuBar
        Me.Name = "Main"
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Strip.ResumeLayout(False)
        Me.Strip.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VS2017 As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuBar As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
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
    Friend WithEvents HelpMenu As System.Windows.Forms.MenuItem
    Friend WithEvents AboutItem As System.Windows.Forms.MenuItem
    Friend WithEvents IconThemeMenu As System.Windows.Forms.MenuItem
    Friend WithEvents VS2017item As System.Windows.Forms.MenuItem
    Friend WithEvents XP As System.Windows.Forms.ImageList
    Friend WithEvents XPitem As System.Windows.Forms.MenuItem
    Friend WithEvents FileSep3 As System.Windows.Forms.MenuItem
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
    Friend WithEvents ApricotWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents FormatMenu As System.Windows.Forms.MenuItem
    Friend WithEvents SyntaxHighlight As System.Windows.Forms.MenuItem
    Friend WithEvents FormatSep As System.Windows.Forms.MenuItem
    Friend WithEvents SaveAll As System.Windows.Forms.MenuItem
    Friend WithEvents LivePreview As System.Windows.Forms.MenuItem
    Friend WithEvents Watcher As System.IO.FileSystemWatcher
    Friend WithEvents RenameCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewCSSCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents CoreSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents ExSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents SiteTree As System.Windows.Forms.TreeView
    Friend WithEvents BuildProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents BuildStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenOutput As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseSitePreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowseSite As System.Windows.Forms.ToolStripButton
    Friend WithEvents EdSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents EditTabs As System.Windows.Forms.TabControl
    Friend WithEvents Preview As System.Windows.Forms.WebBrowser
    Friend WithEvents FormatSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents EditorFont As System.Windows.Forms.MenuItem
    Friend WithEvents SelectFont As System.Windows.Forms.FontDialog
    Friend WithEvents NewJSCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewTXTCon As System.Windows.Forms.MenuItem
    Friend WithEvents BuildPanel As System.Windows.Forms.MenuItem
    Friend WithEvents ViewSep As System.Windows.Forms.MenuItem
    Friend WithEvents SanitaryBuild As System.Windows.Forms.MenuItem
    Friend WithEvents Recent1 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent2 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent3 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent4 As System.Windows.Forms.MenuItem
    Friend WithEvents Recent5 As System.Windows.Forms.MenuItem
    Friend WithEvents ClearRecents As System.Windows.Forms.MenuItem
    Friend WithEvents OpenRecent As System.Windows.Forms.MenuItem
    Friend WithEvents RecentSep As System.Windows.Forms.MenuItem
    Friend WithEvents HelpTopics As System.Windows.Forms.MenuItem
    Friend WithEvents SendFeedback As System.Windows.Forms.MenuItem
    Friend WithEvents HelpSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolsSep As System.Windows.Forms.MenuItem
    Friend WithEvents OpenOutputMnu As System.Windows.Forms.MenuItem
    Friend WithEvents EditMenu As System.Windows.Forms.MenuItem
    Friend WithEvents Undo As System.Windows.Forms.MenuItem
    Friend WithEvents Redo As System.Windows.Forms.MenuItem
    Friend WithEvents EditSep As System.Windows.Forms.MenuItem
    Friend WithEvents Cut As System.Windows.Forms.MenuItem
    Friend WithEvents Copy As System.Windows.Forms.MenuItem
    Friend WithEvents Paste As System.Windows.Forms.MenuItem
    Friend WithEvents EditSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents SelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents InsertConditional As System.Windows.Forms.MenuItem
    Friend WithEvents Find As System.Windows.Forms.MenuItem
    Friend WithEvents GoToMnu As System.Windows.Forms.MenuItem
    Friend WithEvents Replace As System.Windows.Forms.MenuItem
    Friend WithEvents EditSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents EditSep4 As System.Windows.Forms.MenuItem
    Friend WithEvents Save As System.Windows.Forms.MenuItem
    Friend WithEvents CloseFile As System.Windows.Forms.MenuItem
    Friend WithEvents FileSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents HelpSep As System.Windows.Forms.MenuItem
    Friend WithEvents Website As System.Windows.Forms.MenuItem
    Friend WithEvents GitHub As System.Windows.Forms.MenuItem
    Friend WithEvents LogMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents SaveLog As System.Windows.Forms.MenuItem
    Friend WithEvents OpenContext As System.Windows.Forms.MenuItem
    Friend WithEvents SaveLogDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LogMenuBridge As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FileSep4 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenPack As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SystemIcons As System.Windows.Forms.MenuItem
    Friend WithEvents NewSite As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents QuickstartMnu As System.Windows.Forms.MenuItem
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents SanitaryBuildBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents QuickInsertMnu As System.Windows.Forms.MenuItem
    Friend WithEvents ApricotTabs As System.Windows.Forms.TabControl
    Friend WithEvents LogPage As System.Windows.Forms.TabPage
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents MapPage As System.Windows.Forms.TabPage
    Friend WithEvents InspectorBtn As System.Windows.Forms.MenuItem
    Friend WithEvents ColorScheme As System.Windows.Forms.MenuItem
    Friend WithEvents cDefault As System.Windows.Forms.MenuItem
    Friend WithEvents cDark As System.Windows.Forms.MenuItem
    Friend WithEvents AttributeExplanation As System.Windows.Forms.Label
    Friend WithEvents AttributeTree As System.Windows.Forms.TreeView
    Friend WithEvents LanguageMenu As System.Windows.Forms.MenuItem
    Friend WithEvents EnglishLang As System.Windows.Forms.MenuItem
    Friend WithEvents SpanishLang As System.Windows.Forms.MenuItem
    Friend WithEvents PolishLang As System.Windows.Forms.MenuItem
    Friend WithEvents WelshLang As System.Windows.Forms.MenuItem
    Friend WithEvents HelpSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents ShowVersion As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileLocation As System.Windows.Forms.MenuItem
    Friend WithEvents OpenSampleSite As System.Windows.Forms.MenuItem
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
    Friend WithEvents ScriptingDropdown As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SpicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSpiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptingGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptGalleryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuildShortcut As System.Windows.Forms.MenuItem
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
    Friend WithEvents PreviewPage As System.Windows.Forms.MenuItem
    Friend WithEvents ViewFileOutput As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents BrowseSiteMnu As System.Windows.Forms.MenuItem
    Friend WithEvents BrowseSitePreviewMnu As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarMnu As System.Windows.Forms.MenuItem
    Friend WithEvents Sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuildBtn As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CleanBuildBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenOutputFolderBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents ApriStatus As System.Windows.Forms.ToolStripStatusLabel
End Class

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
        Me.OpenRecent = New System.Windows.Forms.MenuItem()
        Me.Recent1 = New System.Windows.Forms.MenuItem()
        Me.Recent2 = New System.Windows.Forms.MenuItem()
        Me.Recent3 = New System.Windows.Forms.MenuItem()
        Me.Recent4 = New System.Windows.Forms.MenuItem()
        Me.Recent5 = New System.Windows.Forms.MenuItem()
        Me.RecentSep = New System.Windows.Forms.MenuItem()
        Me.ClearRecents = New System.Windows.Forms.MenuItem()
        Me.CloseFile = New System.Windows.Forms.MenuItem()
        Me.CloseSite = New System.Windows.Forms.MenuItem()
        Me.FileSep2 = New System.Windows.Forms.MenuItem()
        Me.Save = New System.Windows.Forms.MenuItem()
        Me.SaveAll = New System.Windows.Forms.MenuItem()
        Me.FileSep3 = New System.Windows.Forms.MenuItem()
        Me.InstallPackMnu = New System.Windows.Forms.MenuItem()
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
        Me.ViewSep = New System.Windows.Forms.MenuItem()
        Me.IconThemeMenu = New System.Windows.Forms.MenuItem()
        Me.VS2017item = New System.Windows.Forms.MenuItem()
        Me.XPitem = New System.Windows.Forms.MenuItem()
        Me.SystemIcons = New System.Windows.Forms.MenuItem()
        Me.RefreshItem = New System.Windows.Forms.MenuItem()
        Me.ViewSep2 = New System.Windows.Forms.MenuItem()
        Me.PreviewPage = New System.Windows.Forms.MenuItem()
        Me.ViewFileOutput = New System.Windows.Forms.MenuItem()
        Me.ViewSep3 = New System.Windows.Forms.MenuItem()
        Me.BrowseSiteMnu = New System.Windows.Forms.MenuItem()
        Me.BrowseSitePreviewMnu = New System.Windows.Forms.MenuItem()
        Me.BuildMenu = New System.Windows.Forms.MenuItem()
        Me.BuildSite = New System.Windows.Forms.MenuItem()
        Me.SanitaryBuild = New System.Windows.Forms.MenuItem()
        Me.BuildSep2 = New System.Windows.Forms.MenuItem()
        Me.OpenOutputMnu = New System.Windows.Forms.MenuItem()
        Me.HelpMenu = New System.Windows.Forms.MenuItem()
        Me.HelpTopics = New System.Windows.Forms.MenuItem()
        Me.HelpSep = New System.Windows.Forms.MenuItem()
        Me.Website = New System.Windows.Forms.MenuItem()
        Me.GitHub = New System.Windows.Forms.MenuItem()
        Me.SendFeedback = New System.Windows.Forms.MenuItem()
        Me.HelpSep2 = New System.Windows.Forms.MenuItem()
        Me.AboutItem = New System.Windows.Forms.MenuItem()
        Me.XP = New System.Windows.Forms.ImageList(Me.components)
        Me.Context = New System.Windows.Forms.ContextMenu()
        Me.OpenContext = New System.Windows.Forms.MenuItem()
        Me.OpenInDefault = New System.Windows.Forms.MenuItem()
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
        Me.OpenOutput = New System.Windows.Forms.ToolStripButton()
        Me.BrowseSitePreview = New System.Windows.Forms.ToolStripButton()
        Me.BrowseSite = New System.Windows.Forms.ToolStripButton()
        Me.CoreSplit = New System.Windows.Forms.SplitContainer()
        Me.SelectFont = New System.Windows.Forms.FontDialog()
        Me.LogMenu = New System.Windows.Forms.ContextMenu()
        Me.SaveLog = New System.Windows.Forms.MenuItem()
        Me.SaveLogDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenPack = New System.Windows.Forms.OpenFileDialog()
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
        Me.VS2017.Images.SetKeyName(7, "Billy la Bufanda")
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
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewSite, Me.OpenFolder, Me.OpenRecent, Me.CloseFile, Me.CloseSite, Me.FileSep2, Me.Save, Me.SaveAll, Me.FileSep3, Me.InstallPackMnu, Me.FileSep4, Me.ExitItem})
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
        'OpenRecent
        '
        Me.OpenRecent.Index = 2
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
        'CloseFile
        '
        Me.CloseFile.Index = 3
        resources.ApplyResources(Me.CloseFile, "CloseFile")
        '
        'CloseSite
        '
        resources.ApplyResources(Me.CloseSite, "CloseSite")
        Me.CloseSite.Index = 4
        '
        'FileSep2
        '
        Me.FileSep2.Index = 5
        resources.ApplyResources(Me.FileSep2, "FileSep2")
        '
        'Save
        '
        Me.Save.Index = 6
        resources.ApplyResources(Me.Save, "Save")
        '
        'SaveAll
        '
        Me.SaveAll.Index = 7
        resources.ApplyResources(Me.SaveAll, "SaveAll")
        '
        'FileSep3
        '
        Me.FileSep3.Index = 8
        resources.ApplyResources(Me.FileSep3, "FileSep3")
        '
        'InstallPackMnu
        '
        Me.InstallPackMnu.Index = 9
        resources.ApplyResources(Me.InstallPackMnu, "InstallPackMnu")
        '
        'FileSep4
        '
        Me.FileSep4.Index = 10
        resources.ApplyResources(Me.FileSep4, "FileSep4")
        '
        'ExitItem
        '
        Me.ExitItem.Index = 11
        resources.ApplyResources(Me.ExitItem, "ExitItem")
        '
        'EditMenu
        '
        Me.EditMenu.Index = 1
        Me.EditMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Undo, Me.Redo, Me.EditSep, Me.Cut, Me.Copy, Me.Paste, Me.EditSep2, Me.SelectAll, Me.EditSep3, Me.Find, Me.Replace, Me.GoToMnu, Me.EditSep4, Me.InsertConditional})
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
        'InsertConditional
        '
        Me.InsertConditional.Index = 13
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
        Me.ViewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ExplorerPanel, Me.BuildPanel, Me.EditorPanel, Me.PreviewPanel, Me.ViewSep, Me.IconThemeMenu, Me.SystemIcons, Me.RefreshItem, Me.ViewSep2, Me.PreviewPage, Me.ViewFileOutput, Me.ViewSep3, Me.BrowseSiteMnu, Me.BrowseSitePreviewMnu})
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
        'ViewSep
        '
        Me.ViewSep.Index = 4
        resources.ApplyResources(Me.ViewSep, "ViewSep")
        '
        'IconThemeMenu
        '
        Me.IconThemeMenu.Index = 5
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
        'SystemIcons
        '
        Me.SystemIcons.Checked = True
        Me.SystemIcons.Index = 6
        resources.ApplyResources(Me.SystemIcons, "SystemIcons")
        '
        'RefreshItem
        '
        Me.RefreshItem.Index = 7
        resources.ApplyResources(Me.RefreshItem, "RefreshItem")
        '
        'ViewSep2
        '
        Me.ViewSep2.Index = 8
        resources.ApplyResources(Me.ViewSep2, "ViewSep2")
        '
        'PreviewPage
        '
        Me.PreviewPage.Index = 9
        resources.ApplyResources(Me.PreviewPage, "PreviewPage")
        '
        'ViewFileOutput
        '
        Me.ViewFileOutput.Index = 10
        resources.ApplyResources(Me.ViewFileOutput, "ViewFileOutput")
        '
        'ViewSep3
        '
        Me.ViewSep3.Index = 11
        resources.ApplyResources(Me.ViewSep3, "ViewSep3")
        '
        'BrowseSiteMnu
        '
        Me.BrowseSiteMnu.Index = 12
        resources.ApplyResources(Me.BrowseSiteMnu, "BrowseSiteMnu")
        '
        'BrowseSitePreviewMnu
        '
        Me.BrowseSitePreviewMnu.Index = 13
        resources.ApplyResources(Me.BrowseSitePreviewMnu, "BrowseSitePreviewMnu")
        '
        'BuildMenu
        '
        Me.BuildMenu.Index = 4
        Me.BuildMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.BuildSite, Me.SanitaryBuild, Me.BuildSep2, Me.OpenOutputMnu})
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
        'BuildSep2
        '
        Me.BuildSep2.Index = 7
        resources.ApplyResources(Me.BuildSep2, "BuildSep2")
        '
        'OpenOutputMnu
        '
        Me.OpenOutputMnu.Index = 8
        resources.ApplyResources(Me.OpenOutputMnu, "OpenOutputMnu")
        '
        'HelpMenu
        '
        Me.HelpMenu.Index = 5
        Me.HelpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HelpTopics, Me.HelpSep, Me.Website, Me.GitHub, Me.SendFeedback, Me.HelpSep2, Me.AboutItem})
        resources.ApplyResources(Me.HelpMenu, "HelpMenu")
        '
        'HelpTopics
        '
        resources.ApplyResources(Me.HelpTopics, "HelpTopics")
        Me.HelpTopics.Index = 0
        '
        'HelpSep
        '
        Me.HelpSep.Index = 1
        resources.ApplyResources(Me.HelpSep, "HelpSep")
        '
        'Website
        '
        Me.Website.Index = 2
        resources.ApplyResources(Me.Website, "Website")
        '
        'GitHub
        '
        Me.GitHub.Index = 3
        resources.ApplyResources(Me.GitHub, "GitHub")
        '
        'SendFeedback
        '
        Me.SendFeedback.Index = 4
        resources.ApplyResources(Me.SendFeedback, "SendFeedback")
        '
        'HelpSep2
        '
        Me.HelpSep2.Index = 5
        resources.ApplyResources(Me.HelpSep2, "HelpSep2")
        '
        'AboutItem
        '
        Me.AboutItem.Index = 6
        resources.ApplyResources(Me.AboutItem, "AboutItem")
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
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenContext, Me.OpenInDefault, Me.ContextSep, Me.CopyCon, Me.PasteCon, Me.AddFilesCon, Me.ContextSep2, Me.DeleteCon, Me.RenameCon, Me.ContextSep3, Me.NewCon})
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
        'ContextSep
        '
        Me.ContextSep.Index = 2
        resources.ApplyResources(Me.ContextSep, "ContextSep")
        '
        'CopyCon
        '
        Me.CopyCon.Index = 3
        resources.ApplyResources(Me.CopyCon, "CopyCon")
        '
        'PasteCon
        '
        Me.PasteCon.Index = 4
        resources.ApplyResources(Me.PasteCon, "PasteCon")
        '
        'AddFilesCon
        '
        Me.AddFilesCon.Index = 5
        resources.ApplyResources(Me.AddFilesCon, "AddFilesCon")
        '
        'ContextSep2
        '
        Me.ContextSep2.Index = 6
        resources.ApplyResources(Me.ContextSep2, "ContextSep2")
        '
        'DeleteCon
        '
        Me.DeleteCon.Index = 7
        resources.ApplyResources(Me.DeleteCon, "DeleteCon")
        '
        'RenameCon
        '
        Me.RenameCon.Index = 8
        resources.ApplyResources(Me.RenameCon, "RenameCon")
        '
        'ContextSep3
        '
        Me.ContextSep3.Index = 9
        resources.ApplyResources(Me.ContextSep3, "ContextSep3")
        '
        'NewCon
        '
        Me.NewCon.Index = 10
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
        Me.Watcher.Filter = "JINFC)(#@)D)(J@()J()DN@()NQND_)NQ#WNN"
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
        Me.LogPage.Controls.Add(Me.Log)
        resources.ApplyResources(Me.LogPage, "LogPage")
        Me.LogPage.Name = "LogPage"
        Me.LogPage.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.SystemColors.Window
        Me.Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Log.ContextMenuStrip = Me.LogMenuBridge
        resources.ApplyResources(Me.Log, "Log")
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Text = Global.AutoSite.My.Resources.Resources.iconTheme
        '
        'LogMenuBridge
        '
        Me.LogMenuBridge.Name = "LogMenuBridge"
        resources.ApplyResources(Me.LogMenuBridge, "LogMenuBridge")
        '
        'MapPage
        '
        Me.MapPage.Controls.Add(Me.AttributeExplanation)
        Me.MapPage.Controls.Add(Me.AttributeTree)
        resources.ApplyResources(Me.MapPage, "MapPage")
        Me.MapPage.Name = "MapPage"
        Me.MapPage.UseVisualStyleBackColor = True
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
        Me.BuildStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Build, Me.OpenOutput, Me.BrowseSitePreview, Me.BrowseSite})
        resources.ApplyResources(Me.BuildStrip, "BuildStrip")
        Me.BuildStrip.Name = "BuildStrip"
        Me.BuildStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'Build
        '
        resources.ApplyResources(Me.Build, "Build")
        Me.Build.Name = "Build"
        '
        'OpenOutput
        '
        Me.OpenOutput.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.OpenOutput, "OpenOutput")
        Me.OpenOutput.Name = "OpenOutput"
        '
        'BrowseSitePreview
        '
        Me.BrowseSitePreview.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BrowseSitePreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BrowseSitePreview, "BrowseSitePreview")
        Me.BrowseSitePreview.Name = "BrowseSitePreview"
        '
        'BrowseSite
        '
        Me.BrowseSite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BrowseSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BrowseSite, "BrowseSite")
        Me.BrowseSite.Name = "BrowseSite"
        '
        'CoreSplit
        '
        resources.ApplyResources(Me.CoreSplit, "CoreSplit")
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
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CoreSplit)
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
        Me.ResumeLayout(False)

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
    Friend WithEvents ApricotTabs As System.Windows.Forms.TabControl
    Friend WithEvents LogPage As System.Windows.Forms.TabPage
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents MapPage As System.Windows.Forms.TabPage
    Friend WithEvents AttributeTree As System.Windows.Forms.TreeView
    Friend WithEvents BuildProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents BuildStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents BuildSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents BrowseSiteMnu As System.Windows.Forms.MenuItem
    Friend WithEvents BrowseSitePreviewMnu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenOutputMnu As System.Windows.Forms.MenuItem
    Friend WithEvents ViewSep2 As System.Windows.Forms.MenuItem
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
    Friend WithEvents PreviewPage As System.Windows.Forms.MenuItem
    Friend WithEvents ViewSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents Save As System.Windows.Forms.MenuItem
    Friend WithEvents CloseFile As System.Windows.Forms.MenuItem
    Friend WithEvents FileSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents ViewFileOutput As System.Windows.Forms.MenuItem
    Friend WithEvents HelpSep As System.Windows.Forms.MenuItem
    Friend WithEvents Website As System.Windows.Forms.MenuItem
    Friend WithEvents GitHub As System.Windows.Forms.MenuItem
    Friend WithEvents LogMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents SaveLog As System.Windows.Forms.MenuItem
    Friend WithEvents OpenContext As System.Windows.Forms.MenuItem
    Friend WithEvents SaveLogDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LogMenuBridge As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InstallPackMnu As System.Windows.Forms.MenuItem
    Friend WithEvents FileSep4 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenPack As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SystemIcons As System.Windows.Forms.MenuItem
    Friend WithEvents NewSite As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents AttributeExplanation As System.Windows.Forms.Label
End Class

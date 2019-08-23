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
        Me.FileSep = New System.Windows.Forms.MenuItem
        Me.ExitItem = New System.Windows.Forms.MenuItem
        Me.ViewMenu = New System.Windows.Forms.MenuItem
        Me.Panels = New System.Windows.Forms.MenuItem
        Me.ExplorerPanel = New System.Windows.Forms.MenuItem
        Me.PanelSep = New System.Windows.Forms.MenuItem
        Me.EditorPanel = New System.Windows.Forms.MenuItem
        Me.PreviewPanel = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.DisplayStyle = New System.Windows.Forms.MenuItem
        Me.NormalDisplay = New System.Windows.Forms.MenuItem
        Me.TemplateDisplay = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.VS2017item = New System.Windows.Forms.MenuItem
        Me.XPitem = New System.Windows.Forms.MenuItem
        Me.RefreshItem = New System.Windows.Forms.MenuItem
        Me.ViewSep = New System.Windows.Forms.MenuItem
        Me.WordWrap = New System.Windows.Forms.MenuItem
        Me.VirtualSpace = New System.Windows.Forms.MenuItem
        Me.WideCaret = New System.Windows.Forms.MenuItem
        Me.BuildMenu = New System.Windows.Forms.MenuItem
        Me.BuildSite = New System.Windows.Forms.MenuItem
        Me.BuildEngineMenu = New System.Windows.Forms.MenuItem
        Me.EnginePython = New System.Windows.Forms.MenuItem
        Me.EngineApricot = New System.Windows.Forms.MenuItem
        Me.HelpMenu = New System.Windows.Forms.MenuItem
        Me.AboutItem = New System.Windows.Forms.MenuItem
        Me.HelpTopics = New System.Windows.Forms.MenuItem
        Me.CoreSplit = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SiteTree = New System.Windows.Forms.TreeView
        Me.EdSplit = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.XP = New System.Windows.Forms.ImageList(Me.components)
        Me.Context = New System.Windows.Forms.ContextMenu
        Me.OpenInDefault = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.CopyCon = New System.Windows.Forms.MenuItem
        Me.PasteCon = New System.Windows.Forms.MenuItem
        Me.AddFilesCon = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.DeleteCon = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.NewCon = New System.Windows.Forms.MenuItem
        Me.NewFolderCon = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.NewHTMLCon = New System.Windows.Forms.MenuItem
        Me.NewMDCon = New System.Windows.Forms.MenuItem
        Me.NewPHPCon = New System.Windows.Forms.MenuItem
        Me.AddFilesDialog = New System.Windows.Forms.OpenFileDialog
        Me.CoreSplit.Panel1.SuspendLayout()
        Me.CoreSplit.Panel2.SuspendLayout()
        Me.CoreSplit.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.EdSplit.Panel1.SuspendLayout()
        Me.EdSplit.Panel2.SuspendLayout()
        Me.EdSplit.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'FolderBrowser
        '
        Me.FolderBrowser.Description = "Choose an existing site folder or create a new one to hold your site's files."
        '
        'MenuBar
        '
        Me.MenuBar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMenu, Me.ViewMenu, Me.BuildMenu, Me.HelpMenu})
        '
        'FileMenu
        '
        Me.FileMenu.Index = 0
        Me.FileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenFolder, Me.CloseSite, Me.FileSep, Me.ExitItem})
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
        Me.CloseSite.Shortcut = System.Windows.Forms.Shortcut.CtrlW
        Me.CloseSite.Text = "Close Site"
        '
        'FileSep
        '
        Me.FileSep.Index = 2
        Me.FileSep.Text = "-"
        '
        'ExitItem
        '
        Me.ExitItem.Index = 3
        Me.ExitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.ExitItem.Text = "Exit"
        '
        'ViewMenu
        '
        Me.ViewMenu.Index = 1
        Me.ViewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Panels, Me.MenuItem4, Me.DisplayStyle, Me.MenuItem1, Me.RefreshItem, Me.ViewSep, Me.WordWrap, Me.VirtualSpace, Me.WideCaret})
        Me.ViewMenu.Text = "View"
        '
        'Panels
        '
        Me.Panels.Index = 0
        Me.Panels.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ExplorerPanel, Me.PanelSep, Me.EditorPanel, Me.PreviewPanel})
        Me.Panels.Text = "Panels"
        '
        'ExplorerPanel
        '
        Me.ExplorerPanel.Checked = True
        Me.ExplorerPanel.Index = 0
        Me.ExplorerPanel.Text = "Explorer"
        '
        'PanelSep
        '
        Me.PanelSep.Index = 1
        Me.PanelSep.Text = "-"
        '
        'EditorPanel
        '
        Me.EditorPanel.Checked = True
        Me.EditorPanel.Index = 2
        Me.EditorPanel.Text = "Editor"
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Checked = True
        Me.PreviewPanel.Index = 3
        Me.PreviewPanel.Text = "Preview"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'DisplayStyle
        '
        Me.DisplayStyle.Index = 2
        Me.DisplayStyle.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NormalDisplay, Me.TemplateDisplay})
        Me.DisplayStyle.Text = "Display Style"
        '
        'NormalDisplay
        '
        Me.NormalDisplay.Checked = True
        Me.NormalDisplay.Index = 0
        Me.NormalDisplay.RadioCheck = True
        Me.NormalDisplay.Text = "Normal"
        '
        'TemplateDisplay
        '
        Me.TemplateDisplay.Enabled = False
        Me.TemplateDisplay.Index = 1
        Me.TemplateDisplay.RadioCheck = True
        Me.TemplateDisplay.Text = "Template"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.VS2017item, Me.XPitem})
        Me.MenuItem1.Text = "Icon Theme"
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
        Me.RefreshItem.Index = 4
        Me.RefreshItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.RefreshItem.Text = "Refresh"
        '
        'ViewSep
        '
        Me.ViewSep.Index = 5
        Me.ViewSep.Text = "-"
        '
        'WordWrap
        '
        Me.WordWrap.Checked = True
        Me.WordWrap.Index = 6
        Me.WordWrap.Text = "Word Wrap"
        '
        'VirtualSpace
        '
        Me.VirtualSpace.Index = 7
        Me.VirtualSpace.Text = "Virtual Space"
        '
        'WideCaret
        '
        Me.WideCaret.Index = 8
        Me.WideCaret.Text = "Wide Caret"
        '
        'BuildMenu
        '
        Me.BuildMenu.Index = 2
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
        Me.HelpMenu.Index = 3
        Me.HelpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AboutItem, Me.HelpTopics})
        Me.HelpMenu.Text = "Help"
        '
        'AboutItem
        '
        Me.AboutItem.Enabled = False
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
        Me.CoreSplit.Name = "CoreSplit"
        '
        'CoreSplit.Panel1
        '
        Me.CoreSplit.Panel1.Controls.Add(Me.Panel1)
        Me.CoreSplit.Panel1.Controls.Add(Me.SiteTree)
        '
        'CoreSplit.Panel2
        '
        Me.CoreSplit.Panel2.Controls.Add(Me.EdSplit)
        Me.CoreSplit.Size = New System.Drawing.Size(800, 429)
        Me.CoreSplit.SplitterDistance = 265
        Me.CoreSplit.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(27, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 55)
        Me.Panel1.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.LinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 42)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(196, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create or open a site folder"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A site has not been opened yet."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SiteTree
        '
        Me.SiteTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiteTree.LabelEdit = True
        Me.SiteTree.Location = New System.Drawing.Point(0, 0)
        Me.SiteTree.Name = "SiteTree"
        Me.SiteTree.Size = New System.Drawing.Size(265, 429)
        Me.SiteTree.TabIndex = 4
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
        Me.EdSplit.Panel1.Controls.Add(Me.TabControl1)
        '
        'EdSplit.Panel2
        '
        Me.EdSplit.Panel2.Controls.Add(Me.WebBrowser1)
        Me.EdSplit.Size = New System.Drawing.Size(531, 429)
        Me.EdSplit.SplitterDistance = 250
        Me.EdSplit.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(531, 250)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FastColoredTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(523, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "This does not save"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox1.AutoIndentCharsPatterns = Global.AutoSite_XL.My.Resources.Resources.iconTheme
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(0, 14)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.CharHeight = 14
        Me.FastColoredTextBox1.CharWidth = 8
        Me.FastColoredTextBox1.CommentPrefix = Nothing
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        Me.FastColoredTextBox1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.FastColoredTextBox1.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.FastColoredTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.FastColoredTextBox1.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(517, 215)
        Me.FastColoredTextBox1.TabIndex = 3
        Me.FastColoredTextBox1.WordWrap = True
        Me.FastColoredTextBox1.Zoom = 100
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(531, 175)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("about:blank", System.UriKind.Absolute)
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
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenInDefault, Me.MenuItem2, Me.CopyCon, Me.PasteCon, Me.AddFilesCon, Me.MenuItem3, Me.DeleteCon, Me.MenuItem10, Me.NewCon})
        '
        'OpenInDefault
        '
        Me.OpenInDefault.Index = 0
        Me.OpenInDefault.Text = "Open in Default Program"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
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
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Text = "-"
        '
        'DeleteCon
        '
        Me.DeleteCon.Index = 6
        Me.DeleteCon.Text = "Delete"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "-"
        '
        'NewCon
        '
        Me.NewCon.Index = 8
        Me.NewCon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.NewFolderCon, Me.MenuItem5, Me.NewHTMLCon, Me.NewMDCon, Me.NewPHPCon})
        Me.NewCon.Text = "New"
        '
        'NewFolderCon
        '
        Me.NewFolderCon.Index = 0
        Me.NewFolderCon.Text = "Folder"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "-"
        '
        'NewHTMLCon
        '
        Me.NewHTMLCon.Index = 2
        Me.NewHTMLCon.Text = "HTML Document"
        '
        'NewMDCon
        '
        Me.NewMDCon.Index = 3
        Me.NewMDCon.Text = "Markdown Document"
        '
        'NewPHPCon
        '
        Me.NewPHPCon.Index = 4
        Me.NewPHPCon.Text = "PHP Document"
        '
        'AddFilesDialog
        '
        Me.AddFilesDialog.Filter = "All files (*.*)|*.*"
        Me.AddFilesDialog.Multiselect = True
        Me.AddFilesDialog.Title = "Add Files to Folder"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 429)
        Me.Controls.Add(Me.CoreSplit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MenuBar
        Me.Name = "Form1"
        Me.Text = "AutoSite XL"
        Me.CoreSplit.Panel1.ResumeLayout(False)
        Me.CoreSplit.Panel1.PerformLayout()
        Me.CoreSplit.Panel2.ResumeLayout(False)
        Me.CoreSplit.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.EdSplit.Panel1.ResumeLayout(False)
        Me.EdSplit.Panel2.ResumeLayout(False)
        Me.EdSplit.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VS2017 As System.Windows.Forms.ImageList
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuBar As System.Windows.Forms.MainMenu
    Friend WithEvents FileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents CloseSite As System.Windows.Forms.MenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DisplayStyle As System.Windows.Forms.MenuItem
    Friend WithEvents NormalDisplay As System.Windows.Forms.MenuItem
    Friend WithEvents TemplateDisplay As System.Windows.Forms.MenuItem
    Friend WithEvents Panels As System.Windows.Forms.MenuItem
    Friend WithEvents ExplorerPanel As System.Windows.Forms.MenuItem
    Friend WithEvents PanelSep As System.Windows.Forms.MenuItem
    Friend WithEvents EditorPanel As System.Windows.Forms.MenuItem
    Friend WithEvents PreviewPanel As System.Windows.Forms.MenuItem
    Friend WithEvents ViewSep As System.Windows.Forms.MenuItem
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SiteTree As System.Windows.Forms.TreeView
    Friend WithEvents EdSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents VS2017item As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents XP As System.Windows.Forms.ImageList
    Friend WithEvents XPitem As System.Windows.Forms.MenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents FileSep As System.Windows.Forms.MenuItem
    Friend WithEvents ExitItem As System.Windows.Forms.MenuItem
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Context As System.Windows.Forms.ContextMenu
    Friend WithEvents OpenInDefault As System.Windows.Forms.MenuItem
    Friend WithEvents RefreshItem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents CopyCon As System.Windows.Forms.MenuItem
    Friend WithEvents PasteCon As System.Windows.Forms.MenuItem
    Friend WithEvents DeleteCon As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents NewCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewFolderCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewHTMLCon As System.Windows.Forms.MenuItem
    Friend WithEvents NewMDCon As System.Windows.Forms.MenuItem
    Friend WithEvents AddFilesCon As System.Windows.Forms.MenuItem
    Friend WithEvents AddFilesDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NewPHPCon As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
End Class

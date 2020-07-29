<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.Strip = New System.Windows.Forms.ToolStrip()
        Me.SaveBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoBtn = New System.Windows.Forms.ToolStripButton()
        Me.RedoBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutBtn = New System.Windows.Forms.ToolStripButton()
        Me.CopyBtn = New System.Windows.Forms.ToolStripButton()
        Me.PasteBtn = New System.Windows.Forms.ToolStripButton()
        Me.CloseBtn = New System.Windows.Forms.ToolStripButton()
        Me.Sep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Find = New System.Windows.Forms.ToolStripButton()
        Me.GTo = New System.Windows.Forms.ToolStripButton()
        Me.Replace = New System.Windows.Forms.ToolStripButton()
        Me.Sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Preview = New System.Windows.Forms.ToolStripSplitButton()
        Me.LivePreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Build = New System.Windows.Forms.ToolStripButton()
        Me.ViewOutput = New System.Windows.Forms.ToolStripSplitButton()
        Me.ViewinDefaultBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.Code = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Context = New System.Windows.Forms.ContextMenu()
        Me.Undo = New System.Windows.Forms.MenuItem()
        Me.Redo = New System.Windows.Forms.MenuItem()
        Me.ConSep = New System.Windows.Forms.MenuItem()
        Me.Cut = New System.Windows.Forms.MenuItem()
        Me.Copy = New System.Windows.Forms.MenuItem()
        Me.Paste = New System.Windows.Forms.MenuItem()
        Me.ConSep2 = New System.Windows.Forms.MenuItem()
        Me.SelectAll = New System.Windows.Forms.MenuItem()
        Me.ConSep3 = New System.Windows.Forms.MenuItem()
        Me.InsertConditional = New System.Windows.Forms.MenuItem()
        Me.Autocomplete = New AutocompleteMenuNS.AutocompleteMenu()
        Me.PopupIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Strip.SuspendLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Strip
        '
        Me.Strip.BackColor = System.Drawing.SystemColors.Window
        Me.Strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBtn, Me.Sep, Me.UndoBtn, Me.RedoBtn, Me.Sep2, Me.CutBtn, Me.CopyBtn, Me.PasteBtn, Me.CloseBtn, Me.Sep3, Me.Find, Me.GTo, Me.Replace, Me.Sep4, Me.Preview, Me.Sep5, Me.Build, Me.ViewOutput})
        Me.Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        resources.ApplyResources(Me.Strip, "Strip")
        Me.Strip.Name = "Strip"
        Me.Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoToolTip = False
        Me.SaveBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAllToolStripMenuItem})
        resources.ApplyResources(Me.SaveBtn, "SaveBtn")
        Me.SaveBtn.Name = "SaveBtn"
        '
        'SaveToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        '
        'SaveAllToolStripMenuItem
        '
        resources.ApplyResources(Me.SaveAllToolStripMenuItem, "SaveAllToolStripMenuItem")
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        '
        'Sep
        '
        Me.Sep.Name = "Sep"
        resources.ApplyResources(Me.Sep, "Sep")
        '
        'UndoBtn
        '
        Me.UndoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.UndoBtn, "UndoBtn")
        Me.UndoBtn.Name = "UndoBtn"
        '
        'RedoBtn
        '
        Me.RedoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.RedoBtn, "RedoBtn")
        Me.RedoBtn.Name = "RedoBtn"
        '
        'Sep2
        '
        Me.Sep2.Name = "Sep2"
        resources.ApplyResources(Me.Sep2, "Sep2")
        '
        'CutBtn
        '
        Me.CutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.CutBtn, "CutBtn")
        Me.CutBtn.Name = "CutBtn"
        '
        'CopyBtn
        '
        Me.CopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.CopyBtn, "CopyBtn")
        Me.CopyBtn.Name = "CopyBtn"
        '
        'PasteBtn
        '
        Me.PasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.PasteBtn, "PasteBtn")
        Me.PasteBtn.Name = "PasteBtn"
        '
        'CloseBtn
        '
        Me.CloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.Name = "CloseBtn"
        '
        'Sep3
        '
        Me.Sep3.Name = "Sep3"
        resources.ApplyResources(Me.Sep3, "Sep3")
        '
        'Find
        '
        Me.Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Find, "Find")
        Me.Find.Name = "Find"
        '
        'GTo
        '
        Me.GTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.GTo, "GTo")
        Me.GTo.Name = "GTo"
        '
        'Replace
        '
        Me.Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Replace, "Replace")
        Me.Replace.Name = "Replace"
        '
        'Sep4
        '
        Me.Sep4.Name = "Sep4"
        resources.ApplyResources(Me.Sep4, "Sep4")
        '
        'Preview
        '
        Me.Preview.AutoToolTip = False
        Me.Preview.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LivePreview})
        resources.ApplyResources(Me.Preview, "Preview")
        Me.Preview.Name = "Preview"
        '
        'LivePreview
        '
        Me.LivePreview.CheckOnClick = True
        Me.LivePreview.Name = "LivePreview"
        resources.ApplyResources(Me.LivePreview, "LivePreview")
        '
        'Sep5
        '
        Me.Sep5.Name = "Sep5"
        resources.ApplyResources(Me.Sep5, "Sep5")
        '
        'Build
        '
        resources.ApplyResources(Me.Build, "Build")
        Me.Build.Name = "Build"
        '
        'ViewOutput
        '
        Me.ViewOutput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewinDefaultBrowser})
        resources.ApplyResources(Me.ViewOutput, "ViewOutput")
        Me.ViewOutput.Name = "ViewOutput"
        '
        'ViewinDefaultBrowser
        '
        Me.ViewinDefaultBrowser.Name = "ViewinDefaultBrowser"
        resources.ApplyResources(Me.ViewinDefaultBrowser, "ViewinDefaultBrowser")
        '
        'Code
        '
        Me.Code.AllowSeveralTextStyleDrawing = True
        Me.Code.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Autocomplete.SetAutocompleteMenu(Me.Code, Me.Autocomplete)
        Me.Code.AutoIndentCharsPatterns = Global.AutoSite.My.Resources.Resources.openProject
        Me.Code.AutoIndentExistingLines = False
        resources.ApplyResources(Me.Code, "Code")
        Me.Code.BackBrush = Nothing
        Me.Code.CharHeight = 14
        Me.Code.CharWidth = 8
        Me.Code.CommentPrefix = Nothing
        Me.Code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Code.IndentBackColor = System.Drawing.SystemColors.Window
        Me.Code.IsReplaceMode = False
        Me.Code.Language = FastColoredTextBoxNS.Language.HTML
        Me.Code.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.Code.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.Code.Name = "Code"
        Me.Code.Paddings = New System.Windows.Forms.Padding(0)
        Me.Code.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.Code.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.Code.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Code.ServiceColors = CType(resources.GetObject("Code.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Code.Zoom = 100
        '
        'Context
        '
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Undo, Me.Redo, Me.ConSep, Me.Cut, Me.Copy, Me.Paste, Me.ConSep2, Me.SelectAll, Me.ConSep3, Me.InsertConditional})
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
        'ConSep
        '
        Me.ConSep.Index = 2
        resources.ApplyResources(Me.ConSep, "ConSep")
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
        'ConSep2
        '
        Me.ConSep2.Index = 6
        resources.ApplyResources(Me.ConSep2, "ConSep2")
        '
        'SelectAll
        '
        Me.SelectAll.Index = 7
        resources.ApplyResources(Me.SelectAll, "SelectAll")
        '
        'ConSep3
        '
        Me.ConSep3.Index = 8
        resources.ApplyResources(Me.ConSep3, "ConSep3")
        '
        'InsertConditional
        '
        Me.InsertConditional.Index = 9
        resources.ApplyResources(Me.InsertConditional, "InsertConditional")
        '
        'Autocomplete
        '
        Me.Autocomplete.Colors = CType(resources.GetObject("Autocomplete.Colors"), AutocompleteMenuNS.Colors)
        Me.Autocomplete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Autocomplete.ImageList = Me.PopupIcons
        Me.Autocomplete.Items = New String() {"-"}
        Me.Autocomplete.SearchPattern = "[@]"
        Me.Autocomplete.TargetControlWrapper = Nothing
        '
        'PopupIcons
        '
        Me.PopupIcons.ImageStream = CType(resources.GetObject("PopupIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PopupIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.PopupIcons.Images.SetKeyName(0, "Reference")
        Me.PopupIcons.Images.SetKeyName(1, "Define")
        Me.PopupIcons.Images.SetKeyName(2, "Lightbulb")
        Me.PopupIcons.Images.SetKeyName(3, "Build")
        Me.PopupIcons.Images.SetKeyName(4, "Conditional")
        '
        'Editor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Code)
        Me.Controls.Add(Me.Strip)
        Me.Name = "Editor"
        Me.Strip.ResumeLayout(False)
        Me.Strip.PerformLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Strip As System.Windows.Forms.ToolStrip
    Friend WithEvents UndoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents RedoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Code As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Context As System.Windows.Forms.ContextMenu
    Friend WithEvents Undo As System.Windows.Forms.MenuItem
    Friend WithEvents Redo As System.Windows.Forms.MenuItem
    Friend WithEvents Sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cut As System.Windows.Forms.MenuItem
    Friend WithEvents Copy As System.Windows.Forms.MenuItem
    Friend WithEvents Paste As System.Windows.Forms.MenuItem
    Friend WithEvents ConSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents ConSep As System.Windows.Forms.MenuItem
    Friend WithEvents SelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents Sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveBtn As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Find As System.Windows.Forms.ToolStripButton
    Friend WithEvents GTo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Replace As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Preview As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents LivePreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents InsertConditional As System.Windows.Forms.MenuItem
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewOutput As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ViewinDefaultBrowser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Autocomplete As AutocompleteMenuNS.AutocompleteMenu
    Friend WithEvents PopupIcons As System.Windows.Forms.ImageList

End Class

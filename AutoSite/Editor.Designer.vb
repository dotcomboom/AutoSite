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
        Me.QuickInsert = New System.Windows.Forms.ToolStripButton()
        Me.Sep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Preview = New System.Windows.Forms.ToolStripSplitButton()
        Me.LivePreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sep5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Build = New System.Windows.Forms.ToolStripButton()
        Me.ViewOutput = New System.Windows.Forms.ToolStripSplitButton()
        Me.ViewinDefaultBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.Code = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertConditional = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertAttribute = New System.Windows.Forms.ToolStripMenuItem()
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Autocomplete = New AutocompleteMenuNS.AutocompleteMenu()
        Me.PopupIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.PreviewWorker = New System.ComponentModel.BackgroundWorker()
        Me.ConSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Strip.SuspendLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Context.SuspendLayout()
        Me.SuspendLayout()
        '
        'Strip
        '
        Me.Strip.BackColor = System.Drawing.SystemColors.Window
        Me.Strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBtn, Me.Sep, Me.UndoBtn, Me.RedoBtn, Me.Sep2, Me.CutBtn, Me.CopyBtn, Me.PasteBtn, Me.CloseBtn, Me.Sep3, Me.Find, Me.GTo, Me.Replace, Me.QuickInsert, Me.Sep4, Me.Preview, Me.Sep5, Me.Build, Me.ViewOutput})
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
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.Image = Global.AutoSite.My.Resources.Resources.Save
        Me.SaveBtn.Name = "SaveBtn"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.Save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Image = Global.AutoSite.My.Resources.Resources.SaveAll
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        resources.ApplyResources(Me.SaveAllToolStripMenuItem, "SaveAllToolStripMenuItem")
        '
        'Sep
        '
        Me.Sep.ForeColor = System.Drawing.Color.Black
        Me.Sep.Name = "Sep"
        resources.ApplyResources(Me.Sep, "Sep")
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
        'Sep2
        '
        Me.Sep2.ForeColor = System.Drawing.Color.Black
        Me.Sep2.Name = "Sep2"
        resources.ApplyResources(Me.Sep2, "Sep2")
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
        'CloseBtn
        '
        Me.CloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.Name = "CloseBtn"
        '
        'Sep3
        '
        Me.Sep3.ForeColor = System.Drawing.Color.Black
        Me.Sep3.Name = "Sep3"
        resources.ApplyResources(Me.Sep3, "Sep3")
        '
        'Find
        '
        Me.Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Find.ForeColor = System.Drawing.Color.Black
        Me.Find.Image = Global.AutoSite.My.Resources.Resources.Search
        resources.ApplyResources(Me.Find, "Find")
        Me.Find.Name = "Find"
        '
        'GTo
        '
        Me.GTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GTo.ForeColor = System.Drawing.Color.Black
        Me.GTo.Image = Global.AutoSite.My.Resources.Resources.GotoRow
        resources.ApplyResources(Me.GTo, "GTo")
        Me.GTo.Name = "GTo"
        '
        'Replace
        '
        Me.Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Replace.ForeColor = System.Drawing.Color.Black
        Me.Replace.Image = Global.AutoSite.My.Resources.Resources.ReplaceAll
        resources.ApplyResources(Me.Replace, "Replace")
        Me.Replace.Name = "Replace"
        '
        'QuickInsert
        '
        Me.QuickInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QuickInsert.ForeColor = System.Drawing.Color.Black
        Me.QuickInsert.Image = Global.AutoSite.My.Resources.Resources.InsertPanel
        resources.ApplyResources(Me.QuickInsert, "QuickInsert")
        Me.QuickInsert.Name = "QuickInsert"
        '
        'Sep4
        '
        Me.Sep4.ForeColor = System.Drawing.Color.Black
        Me.Sep4.Name = "Sep4"
        resources.ApplyResources(Me.Sep4, "Sep4")
        '
        'Preview
        '
        Me.Preview.AutoToolTip = False
        Me.Preview.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LivePreview})
        Me.Preview.ForeColor = System.Drawing.Color.Black
        Me.Preview.Image = Global.AutoSite.My.Resources.Resources.WebTest
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
        Me.Sep5.ForeColor = System.Drawing.Color.Black
        Me.Sep5.Name = "Sep5"
        resources.ApplyResources(Me.Sep5, "Sep5")
        '
        'Build
        '
        Me.Build.ForeColor = System.Drawing.Color.Black
        Me.Build.Image = Global.AutoSite.My.Resources.Resources.Build
        resources.ApplyResources(Me.Build, "Build")
        Me.Build.Name = "Build"
        '
        'ViewOutput
        '
        Me.ViewOutput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewinDefaultBrowser})
        Me.ViewOutput.ForeColor = System.Drawing.Color.Black
        Me.ViewOutput.Image = Global.AutoSite.My.Resources.Resources.Web
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
        Me.Code.AutoIndentCharsPatterns = Global.AutoSite.My.Resources.Resources.__
        Me.Code.AutoIndentExistingLines = False
        resources.ApplyResources(Me.Code, "Code")
        Me.Code.BackBrush = Nothing
        Me.Code.CharHeight = 14
        Me.Code.CharWidth = 8
        Me.Code.CommentPrefix = Nothing
        Me.Code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Code.ForeColor = System.Drawing.Color.Black
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
        Me.Context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cut, Me.Copy, Me.Paste, Me.ConSep2, Me.SelectAll, Me.ConSep3, Me.InsertConditional, Me.InsertAttribute, Me.Insert})
        Me.Context.Name = "Context"
        resources.ApplyResources(Me.Context, "Context")
        '
        'Cut
        '
        Me.Cut.MergeIndex = 0
        Me.Cut.Name = "Cut"
        resources.ApplyResources(Me.Cut, "Cut")
        '
        'Copy
        '
        Me.Copy.MergeIndex = 1
        Me.Copy.Name = "Copy"
        resources.ApplyResources(Me.Copy, "Copy")
        '
        'Paste
        '
        Me.Paste.MergeIndex = 2
        Me.Paste.Name = "Paste"
        resources.ApplyResources(Me.Paste, "Paste")
        '
        'SelectAll
        '
        Me.SelectAll.MergeIndex = 4
        Me.SelectAll.Name = "SelectAll"
        resources.ApplyResources(Me.SelectAll, "SelectAll")
        '
        'InsertConditional
        '
        Me.InsertConditional.MergeIndex = 6
        Me.InsertConditional.Name = "InsertConditional"
        resources.ApplyResources(Me.InsertConditional, "InsertConditional")
        '
        'InsertAttribute
        '
        Me.InsertAttribute.MergeIndex = 7
        Me.InsertAttribute.Name = "InsertAttribute"
        resources.ApplyResources(Me.InsertAttribute, "InsertAttribute")
        '
        'Insert
        '
        Me.Insert.MergeIndex = 8
        Me.Insert.Name = "Insert"
        resources.ApplyResources(Me.Insert, "Insert")
        '
        'Autocomplete
        '
        Me.Autocomplete.AllowsTabKey = True
        Me.Autocomplete.CaptureFocus = True
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
        Me.PopupIcons.Images.SetKeyName(2, "ReferenceInternal")
        Me.PopupIcons.Images.SetKeyName(3, "Build")
        Me.PopupIcons.Images.SetKeyName(4, "Conditional")
        Me.PopupIcons.Images.SetKeyName(5, "NewAttribute")
        Me.PopupIcons.Images.SetKeyName(6, "Conditional")
        '
        'PreviewWorker
        '
        '
        'ConSep3
        '
        Me.ConSep3.MergeIndex = 5
        Me.ConSep3.Name = "ConSep3"
        resources.ApplyResources(Me.ConSep3, "ConSep3")
        '
        'ConSep2
        '
        Me.ConSep2.MergeIndex = 3
        Me.ConSep2.Name = "ConSep2"
        resources.ApplyResources(Me.ConSep2, "ConSep2")
        '
        'Editor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Code)
        Me.Controls.Add(Me.Strip)
        Me.Name = "Editor"
        Me.Strip.ResumeLayout(False)
        Me.Strip.PerformLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Context.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Strip As System.Windows.Forms.ToolStrip
    Friend WithEvents UndoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents RedoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Code As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAll As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents QuickInsert As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Preview As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents LivePreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertConditional As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewOutput As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ViewinDefaultBrowser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Autocomplete As AutocompleteMenuNS.AutocompleteMenu
    Friend WithEvents PopupIcons As System.Windows.Forms.ImageList
    Friend WithEvents Replace As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreviewWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertAttribute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConSep3 As System.Windows.Forms.ToolStripSeparator

End Class

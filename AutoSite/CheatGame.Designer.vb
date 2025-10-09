<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheatGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CPU1Cards = New System.Windows.Forms.Label()
        Me.CPU2Cards = New System.Windows.Forms.Label()
        Me.CPU3Cards = New System.Windows.Forms.Label()
        Me.CPUTurn = New System.Windows.Forms.Label()
        Me.Accuse = New System.Windows.Forms.Button()
        Me.CardList = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.YourCards = New System.Windows.Forms.Label()
        Me.Allow = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PileCards = New System.Windows.Forms.Label()
        Me.PickCard = New System.Windows.Forms.ComboBox()
        Me.Safe = New System.Windows.Forms.Label()
        Me.MakeMove = New System.Windows.Forms.Button()
        Me.CaughtNotif = New System.Windows.Forms.Label()
        Me._Turn = New System.Windows.Forms.Label()
        Me.FreeRound = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPU 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPU 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CPU 3"
        '
        'CPU1Cards
        '
        Me.CPU1Cards.AutoSize = True
        Me.CPU1Cards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU1Cards.Location = New System.Drawing.Point(77, 13)
        Me.CPU1Cards.Name = "CPU1Cards"
        Me.CPU1Cards.Size = New System.Drawing.Size(61, 19)
        Me.CPU1Cards.TabIndex = 4
        Me.CPU1Cards.Text = "13 cards"
        '
        'CPU2Cards
        '
        Me.CPU2Cards.AutoSize = True
        Me.CPU2Cards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU2Cards.Location = New System.Drawing.Point(77, 37)
        Me.CPU2Cards.Name = "CPU2Cards"
        Me.CPU2Cards.Size = New System.Drawing.Size(61, 19)
        Me.CPU2Cards.TabIndex = 5
        Me.CPU2Cards.Text = "13 cards"
        '
        'CPU3Cards
        '
        Me.CPU3Cards.AutoSize = True
        Me.CPU3Cards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU3Cards.Location = New System.Drawing.Point(77, 61)
        Me.CPU3Cards.Name = "CPU3Cards"
        Me.CPU3Cards.Size = New System.Drawing.Size(61, 19)
        Me.CPU3Cards.TabIndex = 8
        Me.CPU3Cards.Text = "13 cards"
        '
        'CPUTurn
        '
        Me.CPUTurn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUTurn.Location = New System.Drawing.Point(26, 151)
        Me.CPUTurn.Name = "CPUTurn"
        Me.CPUTurn.Size = New System.Drawing.Size(148, 13)
        Me.CPUTurn.TabIndex = 12
        Me.CPUTurn.Text = "CPU 1 played 4 eights"
        Me.CPUTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Accuse
        '
        Me.Accuse.Location = New System.Drawing.Point(26, 177)
        Me.Accuse.Name = "Accuse"
        Me.Accuse.Size = New System.Drawing.Size(148, 23)
        Me.Accuse.TabIndex = 19
        Me.Accuse.Text = "Accuse CPU 1 of cheating!"
        Me.Accuse.UseVisualStyleBackColor = True
        '
        'CardList
        '
        Me.CardList.FormattingEnabled = True
        Me.CardList.ItemHeight = 19
        Me.CardList.Location = New System.Drawing.Point(240, 29)
        Me.CardList.Name = "CardList"
        Me.CardList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.CardList.Size = New System.Drawing.Size(132, 137)
        Me.CardList.Sorted = True
        Me.CardList.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "YOUR HAND:"
        '
        'YourCards
        '
        Me.YourCards.AutoSize = True
        Me.YourCards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YourCards.Location = New System.Drawing.Point(237, 13)
        Me.YourCards.Name = "YourCards"
        Me.YourCards.Size = New System.Drawing.Size(61, 19)
        Me.YourCards.TabIndex = 16
        Me.YourCards.Text = "13 cards"
        '
        'Allow
        '
        Me.Allow.Location = New System.Drawing.Point(47, 203)
        Me.Allow.Name = "Allow"
        Me.Allow.Size = New System.Drawing.Size(109, 23)
        Me.Allow.TabIndex = 15
        Me.Allow.Text = "Let CPU 1 slide"
        Me.Allow.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "The Pile"
        '
        'PileCards
        '
        Me.PileCards.AutoSize = True
        Me.PileCards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PileCards.Location = New System.Drawing.Point(77, 89)
        Me.PileCards.Name = "PileCards"
        Me.PileCards.Size = New System.Drawing.Size(61, 19)
        Me.PileCards.TabIndex = 22
        Me.PileCards.Text = "13 cards"
        '
        'PickCard
        '
        Me.PickCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PickCard.FormattingEnabled = True
        Me.PickCard.Location = New System.Drawing.Point(240, 179)
        Me.PickCard.Name = "PickCard"
        Me.PickCard.Size = New System.Drawing.Size(132, 27)
        Me.PickCard.TabIndex = 23
        '
        'Safe
        '
        Me.Safe.AutoSize = True
        Me.Safe.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Safe.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Safe.Location = New System.Drawing.Point(23, 236)
        Me.Safe.Name = "Safe"
        Me.Safe.Size = New System.Drawing.Size(156, 38)
        Me.Safe.TabIndex = 24
        Me.Safe.Text = "The pile's empty!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No penalty for cheating."
        Me.Safe.Visible = False
        '
        'MakeMove
        '
        Me.MakeMove.Location = New System.Drawing.Point(240, 206)
        Me.MakeMove.Name = "MakeMove"
        Me.MakeMove.Size = New System.Drawing.Size(132, 23)
        Me.MakeMove.TabIndex = 25
        Me.MakeMove.Text = "Make your move"
        Me.MakeMove.UseVisualStyleBackColor = True
        '
        'CaughtNotif
        '
        Me.CaughtNotif.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaughtNotif.Location = New System.Drawing.Point(26, 110)
        Me.CaughtNotif.Name = "CaughtNotif"
        Me.CaughtNotif.Size = New System.Drawing.Size(148, 31)
        Me.CaughtNotif.TabIndex = 26
        Me.CaughtNotif.Text = "YOU GOT CAUGHT!"
        Me.CaughtNotif.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        '_Turn
        '
        Me._Turn.AutoSize = True
        Me._Turn.Location = New System.Drawing.Point(23, 249)
        Me._Turn.Name = "_Turn"
        Me._Turn.Size = New System.Drawing.Size(37, 19)
        Me._Turn.TabIndex = 27
        Me._Turn.Text = "Turn"
        Me._Turn.Visible = False
        '
        'FreeRound
        '
        Me.FreeRound.AutoSize = True
        Me.FreeRound.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeRound.Location = New System.Drawing.Point(177, 164)
        Me.FreeRound.Name = "FreeRound"
        Me.FreeRound.Size = New System.Drawing.Size(72, 76)
        Me.FreeRound.TabIndex = 28
        Me.FreeRound.Text = "You may " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pick any" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "value this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "turn!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'CheatGame
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FreeRound)
        Me.Controls.Add(Me._Turn)
        Me.Controls.Add(Me.CaughtNotif)
        Me.Controls.Add(Me.MakeMove)
        Me.Controls.Add(Me.Safe)
        Me.Controls.Add(Me.PickCard)
        Me.Controls.Add(Me.PileCards)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Accuse)
        Me.Controls.Add(Me.CardList)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.YourCards)
        Me.Controls.Add(Me.Allow)
        Me.Controls.Add(Me.CPUTurn)
        Me.Controls.Add(Me.CPU3Cards)
        Me.Controls.Add(Me.CPU2Cards)
        Me.Controls.Add(Me.CPU1Cards)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CheatGame"
        Me.Size = New System.Drawing.Size(416, 280)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CPU1Cards As System.Windows.Forms.Label
    Friend WithEvents CPU2Cards As System.Windows.Forms.Label
    Friend WithEvents CPU3Cards As System.Windows.Forms.Label
    Friend WithEvents CPUTurn As System.Windows.Forms.Label
    Friend WithEvents Accuse As System.Windows.Forms.Button
    Friend WithEvents CardList As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents YourCards As System.Windows.Forms.Label
    Friend WithEvents Allow As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PileCards As System.Windows.Forms.Label
    Friend WithEvents PickCard As System.Windows.Forms.ComboBox
    Friend WithEvents Safe As System.Windows.Forms.Label
    Friend WithEvents MakeMove As System.Windows.Forms.Button
    Friend WithEvents CaughtNotif As System.Windows.Forms.Label
    Friend WithEvents _Turn As System.Windows.Forms.Label
    Friend WithEvents FreeRound As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

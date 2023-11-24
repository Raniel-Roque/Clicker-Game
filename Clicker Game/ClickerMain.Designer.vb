<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClickerMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClickerMain))
        Me.AutoClick_1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TopMoneyLabel = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Settings = New System.Windows.Forms.PictureBox()
        Me.Home = New System.Windows.Forms.PictureBox()
        Me.MoneyBorder = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BotMoneyLabel = New System.Windows.Forms.TextBox()
        Me.DisposeMe = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Shop = New System.Windows.Forms.Button()
        Me.Minigame = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MainButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AutoClick_1
        '
        Me.AutoClick_1.Interval = 2000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TopMoneyLabel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Settings)
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.MoneyBorder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 60)
        Me.Panel1.TabIndex = 5
        '
        'TopMoneyLabel
        '
        Me.TopMoneyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TopMoneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TopMoneyLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopMoneyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.TopMoneyLabel.Location = New System.Drawing.Point(68, 19)
        Me.TopMoneyLabel.MaxLength = 0
        Me.TopMoneyLabel.Name = "TopMoneyLabel"
        Me.TopMoneyLabel.ReadOnly = True
        Me.TopMoneyLabel.Size = New System.Drawing.Size(202, 20)
        Me.TopMoneyLabel.TabIndex = 17
        Me.TopMoneyLabel.Text = "0"
        Me.TopMoneyLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(65, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 255)
        Me.Panel2.TabIndex = 9
        '
        'Settings
        '
        Me.Settings.Image = Global.Clicker_Game.My.Resources.Resources.Settings
        Me.Settings.Location = New System.Drawing.Point(285, 7)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(47, 47)
        Me.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Settings.TabIndex = 12
        Me.Settings.TabStop = False
        '
        'Home
        '
        Me.Home.Image = Global.Clicker_Game.My.Resources.Resources.Home
        Me.Home.Location = New System.Drawing.Point(9, 6)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(45, 47)
        Me.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home.TabIndex = 11
        Me.Home.TabStop = False
        '
        'MoneyBorder
        '
        Me.MoneyBorder.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_BG_Money
        Me.MoneyBorder.Location = New System.Drawing.Point(60, 7)
        Me.MoneyBorder.Name = "MoneyBorder"
        Me.MoneyBorder.Size = New System.Drawing.Size(219, 50)
        Me.MoneyBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MoneyBorder.TabIndex = 9
        Me.MoneyBorder.TabStop = False
        '
        'BotMoneyLabel
        '
        Me.BotMoneyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BotMoneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BotMoneyLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotMoneyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BotMoneyLabel.Location = New System.Drawing.Point(34, 336)
        Me.BotMoneyLabel.MaxLength = 0
        Me.BotMoneyLabel.Name = "BotMoneyLabel"
        Me.BotMoneyLabel.ReadOnly = True
        Me.BotMoneyLabel.Size = New System.Drawing.Size(277, 23)
        Me.BotMoneyLabel.TabIndex = 15
        Me.BotMoneyLabel.Text = "0"
        Me.BotMoneyLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DisposeMe
        '
        Me.DisposeMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DisposeMe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisposeMe.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisposeMe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.DisposeMe.Location = New System.Drawing.Point(0, 59)
        Me.DisposeMe.MaxLength = 0
        Me.DisposeMe.Name = "DisposeMe"
        Me.DisposeMe.ReadOnly = True
        Me.DisposeMe.Size = New System.Drawing.Size(19, 20)
        Me.DisposeMe.TabIndex = 0
        Me.DisposeMe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Clicker_Game.My.Resources.Resources.Achieve_Icon
        Me.Button2.Location = New System.Drawing.Point(262, 423)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 60)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Clicker_Game.My.Resources.Resources.MiniG_Icon
        Me.Button1.Location = New System.Drawing.Point(181, 423)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 60)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Shop
        '
        Me.Shop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Shop.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Shop.FlatAppearance.BorderSize = 0
        Me.Shop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Shop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Shop.Image = Global.Clicker_Game.My.Resources.Resources.Shop_Icon
        Me.Shop.Location = New System.Drawing.Point(100, 423)
        Me.Shop.Margin = New System.Windows.Forms.Padding(0)
        Me.Shop.Name = "Shop"
        Me.Shop.Size = New System.Drawing.Size(61, 60)
        Me.Shop.TabIndex = 23
        Me.Shop.UseVisualStyleBackColor = False
        '
        'Minigame
        '
        Me.Minigame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Minigame.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Minigame.FlatAppearance.BorderSize = 0
        Me.Minigame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Minigame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Minigame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minigame.Image = Global.Clicker_Game.My.Resources.Resources.MiniG_Icon
        Me.Minigame.Location = New System.Drawing.Point(19, 423)
        Me.Minigame.Margin = New System.Windows.Forms.Padding(0)
        Me.Minigame.Name = "Minigame"
        Me.Minigame.Size = New System.Drawing.Size(61, 60)
        Me.Minigame.TabIndex = 22
        Me.Minigame.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(255, 420)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 21
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(174, 420)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(93, 420)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 420)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'MainButton
        '
        Me.MainButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MainButton.FlatAppearance.BorderSize = 0
        Me.MainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButton.Image = Global.Clicker_Game.My.Resources.Resources.Cat_Click_Main_2
        Me.MainButton.Location = New System.Drawing.Point(65, 90)
        Me.MainButton.Name = "MainButton"
        Me.MainButton.Size = New System.Drawing.Size(225, 225)
        Me.MainButton.TabIndex = 0
        Me.MainButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_BG_Money_2
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 321)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.Clicker_Game.My.Resources.Resources.Ractangle_Home_Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 398)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(344, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'ClickerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 511)
        Me.Controls.Add(Me.DisposeMe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Shop)
        Me.Controls.Add(Me.Minigame)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BotMoneyLabel)
        Me.Controls.Add(Me.MainButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ClickerMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Idle Clicker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents AutoClick_1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MainButton As Button
    Friend WithEvents MoneyBorder As PictureBox
    Friend WithEvents Home As PictureBox
    Friend WithEvents Settings As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotMoneyLabel As TextBox
    Friend WithEvents TopMoneyLabel As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Minigame As Button
    Friend WithEvents Shop As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DisposeMe As TextBox
End Class

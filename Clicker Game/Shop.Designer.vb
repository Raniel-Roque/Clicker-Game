<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
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
        Me.UP1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopMoneyLabel = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Settings = New System.Windows.Forms.PictureBox()
        Me.MoneyBorder = New System.Windows.Forms.PictureBox()
        Me.DisposeMe = New System.Windows.Forms.TextBox()
        Me.DisplayLoop = New System.Windows.Forms.Timer(Me.components)
        Me.UP2 = New System.Windows.Forms.Button()
        Me.UP3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UP1
        '
        Me.UP1.BackColor = System.Drawing.Color.Cornsilk
        Me.UP1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UP1.FlatAppearance.BorderSize = 2
        Me.UP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UP1.Location = New System.Drawing.Point(21, 115)
        Me.UP1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.UP1.Name = "UP1"
        Me.UP1.Size = New System.Drawing.Size(80, 60)
        Me.UP1.TabIndex = 8
        Me.UP1.Text = "UP1"
        Me.UP1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TopMoneyLabel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Settings)
        Me.Panel1.Controls.Add(Me.MoneyBorder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 60)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PictureBox1.Image = Global.Clicker_Game.My.Resources.Resources.X
        Me.PictureBox1.Location = New System.Drawing.Point(290, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        Me.TopMoneyLabel.Text = "18,446,744,073,709,551,615"
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
        Me.Settings.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_BG_Button
        Me.Settings.Location = New System.Drawing.Point(285, 7)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(47, 47)
        Me.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Settings.TabIndex = 12
        Me.Settings.TabStop = False
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
        'DisposeMe
        '
        Me.DisposeMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DisposeMe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisposeMe.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisposeMe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.DisposeMe.Location = New System.Drawing.Point(0, 60)
        Me.DisposeMe.MaxLength = 0
        Me.DisposeMe.Name = "DisposeMe"
        Me.DisposeMe.ReadOnly = True
        Me.DisposeMe.Size = New System.Drawing.Size(19, 20)
        Me.DisposeMe.TabIndex = 0
        Me.DisposeMe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DisplayLoop
        '
        Me.DisplayLoop.Enabled = True
        '
        'UP2
        '
        Me.UP2.BackColor = System.Drawing.Color.Cornsilk
        Me.UP2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UP2.FlatAppearance.BorderSize = 2
        Me.UP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UP2.Location = New System.Drawing.Point(21, 183)
        Me.UP2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.UP2.Name = "UP2"
        Me.UP2.Size = New System.Drawing.Size(80, 60)
        Me.UP2.TabIndex = 13
        Me.UP2.Text = "UP2"
        Me.UP2.UseVisualStyleBackColor = False
        '
        'UP3
        '
        Me.UP3.BackColor = System.Drawing.Color.Cornsilk
        Me.UP3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UP3.FlatAppearance.BorderSize = 2
        Me.UP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UP3.Location = New System.Drawing.Point(21, 251)
        Me.UP3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.UP3.Name = "UP3"
        Me.UP3.Size = New System.Drawing.Size(80, 60)
        Me.UP3.TabIndex = 14
        Me.UP3.Text = "UP3"
        Me.UP3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cornsilk
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(21, 319)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 60)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cornsilk
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(21, 387)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 60)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_Shop_Type
        Me.PictureBox3.Location = New System.Drawing.Point(174, 72)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(158, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_Shop_Type
        Me.PictureBox2.Location = New System.Drawing.Point(12, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_Back_Next
        Me.PictureBox4.Location = New System.Drawing.Point(12, 463)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(120, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_Back_Next
        Me.PictureBox5.Location = New System.Drawing.Point(202, 463)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(125, 47)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PictureBox6.Image = Global.Clicker_Game.My.Resources.Resources._NEXT
        Me.PictureBox6.Location = New System.Drawing.Point(221, 471)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(89, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PictureBox7.Image = Global.Clicker_Game.My.Resources.Resources.BACK
        Me.PictureBox7.Location = New System.Drawing.Point(28, 470)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(89, 30)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 511)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UP3)
        Me.Controls.Add(Me.UP2)
        Me.Controls.Add(Me.UP1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DisposeMe)
        Me.Name = "Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents UP1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Settings As PictureBox
    Friend WithEvents MoneyBorder As PictureBox
    Friend WithEvents DisposeMe As TextBox
    Friend WithEvents DisplayLoop As Timer
    Public WithEvents TopMoneyLabel As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents UP2 As Button
    Public WithEvents UP3 As Button
    Public WithEvents Button1 As Button
    Public WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class

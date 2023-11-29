<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsMusic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsMusic))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Settings = New System.Windows.Forms.PictureBox()
        Me.DisposeMe = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CatsSong = New System.Windows.Forms.Button()
        Me.Nyan = New System.Windows.Forms.Button()
        Me.Bongo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Settings)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 60)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Clicker_Game.My.Resources.Resources.X
        Me.PictureBox1.Location = New System.Drawing.Point(290, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        Me.Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settings.Image = Global.Clicker_Game.My.Resources.Resources.Rectangle_BG_Button
        Me.Settings.Location = New System.Drawing.Point(285, 7)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(47, 47)
        Me.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Settings.TabIndex = 12
        Me.Settings.TabStop = False
        '
        'DisposeMe
        '
        Me.DisposeMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DisposeMe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisposeMe.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisposeMe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.DisposeMe.Location = New System.Drawing.Point(685, 84)
        Me.DisposeMe.MaxLength = 0
        Me.DisposeMe.Name = "DisposeMe"
        Me.DisposeMe.ReadOnly = True
        Me.DisposeMe.Size = New System.Drawing.Size(10, 20)
        Me.DisposeMe.TabIndex = 0
        Me.DisposeMe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Clicker_Game.My.Resources.Resources.Max_Volume_Final
        Me.Button1.Location = New System.Drawing.Point(225, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 60)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CatsSong
        '
        Me.CatsSong.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.CatsSong.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CatsSong.FlatAppearance.BorderSize = 3
        Me.CatsSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.CatsSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.CatsSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CatsSong.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatsSong.Location = New System.Drawing.Point(65, 334)
        Me.CatsSong.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CatsSong.Name = "CatsSong"
        Me.CatsSong.Size = New System.Drawing.Size(225, 35)
        Me.CatsSong.TabIndex = 14
        Me.CatsSong.Text = "Cats - The Living Tombstone"
        Me.CatsSong.UseVisualStyleBackColor = False
        '
        'Nyan
        '
        Me.Nyan.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Nyan.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Nyan.FlatAppearance.BorderSize = 3
        Me.Nyan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Nyan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Nyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nyan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nyan.Location = New System.Drawing.Point(65, 379)
        Me.Nyan.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Nyan.Name = "Nyan"
        Me.Nyan.Size = New System.Drawing.Size(225, 35)
        Me.Nyan.TabIndex = 15
        Me.Nyan.Text = "Nyan Cat"
        Me.Nyan.UseVisualStyleBackColor = False
        '
        'Bongo
        '
        Me.Bongo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Bongo.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Bongo.FlatAppearance.BorderSize = 3
        Me.Bongo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Bongo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Bongo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bongo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bongo.ForeColor = System.Drawing.Color.DarkGreen
        Me.Bongo.Location = New System.Drawing.Point(65, 289)
        Me.Bongo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Bongo.Name = "Bongo"
        Me.Bongo.Size = New System.Drawing.Size(225, 35)
        Me.Bongo.TabIndex = 16
        Me.Bongo.Text = "Bongo Cat - CG5"
        Me.Bongo.UseVisualStyleBackColor = False
        '
        'SettingsMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BackgroundImage = Global.Clicker_Game.My.Resources.Resources.Music_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(344, 511)
        Me.Controls.Add(Me.Bongo)
        Me.Controls.Add(Me.Nyan)
        Me.Controls.Add(Me.CatsSong)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DisposeMe)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsMusic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Settings As PictureBox
    Friend WithEvents DisposeMe As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CatsSong As Button
    Friend WithEvents Nyan As Button
    Friend WithEvents Bongo As Button
End Class

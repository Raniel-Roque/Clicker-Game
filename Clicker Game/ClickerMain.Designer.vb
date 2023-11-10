<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClickerMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClickerMain))
        Me.MainButton = New System.Windows.Forms.Button()
        Me.Minigames = New System.Windows.Forms.Button()
        Me.Shop = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Achievement = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainButton
        '
        Me.MainButton.BackColor = System.Drawing.Color.Cornsilk
        Me.MainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MainButton.FlatAppearance.BorderSize = 2
        Me.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainButton.Location = New System.Drawing.Point(64, 68)
        Me.MainButton.Name = "MainButton"
        Me.MainButton.Size = New System.Drawing.Size(218, 188)
        Me.MainButton.TabIndex = 0
        Me.MainButton.Text = "0"
        Me.MainButton.UseVisualStyleBackColor = False
        '
        'Minigames
        '
        Me.Minigames.BackColor = System.Drawing.Color.Cornsilk
        Me.Minigames.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Minigames.FlatAppearance.BorderSize = 2
        Me.Minigames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minigames.Location = New System.Drawing.Point(0, 351)
        Me.Minigames.Name = "Minigames"
        Me.Minigames.Size = New System.Drawing.Size(63, 61)
        Me.Minigames.TabIndex = 1
        Me.Minigames.Text = "Minigames"
        Me.Minigames.UseVisualStyleBackColor = False
        '
        'Shop
        '
        Me.Shop.BackColor = System.Drawing.Color.Cornsilk
        Me.Shop.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Shop.FlatAppearance.BorderSize = 2
        Me.Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Shop.Location = New System.Drawing.Point(64, 351)
        Me.Shop.Name = "Shop"
        Me.Shop.Size = New System.Drawing.Size(63, 61)
        Me.Shop.TabIndex = 2
        Me.Shop.Text = "Shop"
        Me.Shop.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.Cornsilk
        Me.Settings.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Settings.FlatAppearance.BorderSize = 2
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings.Location = New System.Drawing.Point(283, 351)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(63, 61)
        Me.Settings.TabIndex = 4
        Me.Settings.Text = "Setting"
        Me.Settings.UseVisualStyleBackColor = False
        '
        'Achievement
        '
        Me.Achievement.BackColor = System.Drawing.Color.Cornsilk
        Me.Achievement.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Achievement.FlatAppearance.BorderSize = 2
        Me.Achievement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Achievement.Location = New System.Drawing.Point(219, 351)
        Me.Achievement.Name = "Achievement"
        Me.Achievement.Size = New System.Drawing.Size(63, 61)
        Me.Achievement.TabIndex = 3
        Me.Achievement.Text = "Avhievement"
        Me.Achievement.UseVisualStyleBackColor = False
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Cornsilk
        Me.Play.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Play.FlatAppearance.BorderSize = 2
        Me.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play.Location = New System.Drawing.Point(128, 321)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(90, 91)
        Me.Play.TabIndex = 5
        Me.Play.Text = "PLAY"
        Me.Play.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(346, 32)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'ClickerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(346, 411)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.Achievement)
        Me.Controls.Add(Me.Shop)
        Me.Controls.Add(Me.Minigames)
        Me.Controls.Add(Me.MainButton)
        Me.Name = "ClickerMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Idle Clicker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Minigames As Button
    Friend WithEvents Shop As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Achievement As Button
    Friend WithEvents Play As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Public WithEvents MainButton As Button
End Class

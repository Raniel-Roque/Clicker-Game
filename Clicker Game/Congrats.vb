Imports System.Reflection
Public Class Congrats
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        Me.MaximizeBox = False
    End Sub
    Dim SettingsMainOpen As SettingsMain
    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If SettingsMainOpen Is Nothing OrElse SettingsMainOpen.IsDisposed Then
            SettingsMainOpen = New SettingsMain
        End If

        SettingsMainOpen.BringToFront()
        SettingsMainOpen.Show()
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop3.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
        Me.Dispose()
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click, Settings.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
        Me.Dispose()
    End Sub
End Class
Imports System.Reflection
Public Class SettingsMain
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        Me.Dispose()
    End Sub
    Dim SettingMusicMain As SettingsMusic
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SettingMusicMain Is Nothing OrElse SettingMusicMain.IsDisposed Then
            SettingMusicMain = New SettingsMusic
        End If

        SettingMusicMain.BringToFront()
        SettingMusicMain.Show()
        Me.Hide()
    End Sub
End Class
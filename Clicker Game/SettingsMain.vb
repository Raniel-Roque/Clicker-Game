Imports System.Reflection
Public Class SettingsMain
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        Me.MaximizeBox = False
    End Sub
    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        Me.Dispose()
    End Sub
    Dim SettingMusicMain As SettingsMusic
    Dim CredsMain As Credits
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SettingMusicMain Is Nothing OrElse SettingMusicMain.IsDisposed Then
            SettingMusicMain = New SettingsMusic
        End If

        SettingMusicMain.BringToFront()
        SettingMusicMain.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CredsMain Is Nothing OrElse CredsMain.IsDisposed Then
            CredsMain = New Credits
        End If

        CredsMain.BringToFront()
        CredsMain.Show()
        Me.Hide()
    End Sub
End Class
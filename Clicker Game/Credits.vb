Imports System.Reflection
Public Class Credits
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If SettingsMainOpen Is Nothing OrElse SettingsMainOpen.IsDisposed Then
            SettingsMainOpen = New SettingsMain
        End If

        SettingsMainOpen.BringToFront()
        SettingsMainOpen.Show()
        Me.Dispose()
    End Sub
End Class
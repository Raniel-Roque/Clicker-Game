Imports System.Reflection
Public Class SettingsMusic
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
    End Sub
    Dim SettingsMainOpen As SettingsMain
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Volume = True Then
            Button1.Image = My.Resources.No_Volume_Final
            My.Computer.Audio.Stop()
            Volume = False
        Else
            Button1.Image = My.Resources.Max_Volume_Final
            Volume = True

            Select Case MChosen
                Case 0
                    My.Computer.Audio.Stop()
                    My.Computer.Audio.Play(My.Resources.Cats___TLT, AudioPlayMode.BackgroundLoop)
                Case 1
                    My.Computer.Audio.Stop()
                    My.Computer.Audio.Play(My.Resources.Nyan_Cat, AudioPlayMode.BackgroundLoop)
                Case 2
                    My.Computer.Audio.Stop()
                    My.Computer.Audio.Play(My.Resources.Bongo_Cat_Song___CG5, AudioPlayMode.BackgroundLoop)
            End Select
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MChosen = 0
        If Volume = True Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.Cats___TLT, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MChosen = 1
        If Volume = True Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.Nyan_Cat, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MChosen = 2
        If Volume = True Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.Bongo_Cat_Song___CG5, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
End Class
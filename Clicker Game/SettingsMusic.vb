Imports System.Reflection
Public Class SettingsMusic
    Private Sub Chosen(Butt As Button)
        Butt.ForeColor = Color.DarkGreen
        Butt.FlatAppearance.BorderColor = Color.ForestGreen
        Butt.BackColor = Color.FromArgb(230, 193, 197)
    End Sub
    Private Sub Reset_Chosen()
        Bongo.ForeColor = Color.Black
        Bongo.FlatAppearance.BorderColor = Color.White
        CatsSong.ForeColor = Color.Black
        CatsSong.FlatAppearance.BorderColor = Color.White
        Nyan.ForeColor = Color.Black
        Nyan.FlatAppearance.BorderColor = Color.White
        Bongo.BackColor = Color.FromArgb(246, 206, 211)
        CatsSong.BackColor = Color.FromArgb(246, 206, 211)
        Nyan.BackColor = Color.FromArgb(246, 206, 211)

        Select Case MChosen
            Case 0
                Chosen(Bongo)
            Case 1
                Chosen(CatsSong)
            Case 2
                Chosen(Nyan)
        End Select
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        Me.MaximizeBox = False
        Reset_Chosen()
        If Volume = True Then
            Button1.Image = My.Resources.Max_Volume_Final
        Else
            Button1.Image = My.Resources.No_Volume_Final
        End If
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
                    My.Computer.Audio.Play(My.Resources.Bongo_Cat_Song___CG5, AudioPlayMode.BackgroundLoop)
                Case 1
                    My.Computer.Audio.Play(My.Resources.Cats___TLT, AudioPlayMode.BackgroundLoop)
                Case 2
                    My.Computer.Audio.Play(My.Resources.Nyan_Cat, AudioPlayMode.BackgroundLoop)
            End Select
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Bongo.Click
        MChosen = 0
        Reset_Chosen()
        If Volume = True Then
            My.Computer.Audio.Play(My.Resources.Bongo_Cat_Song___CG5, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CatsSong.Click
        MChosen = 1
        Reset_Chosen()
        If Volume = True Then
            My.Computer.Audio.Play(My.Resources.Cats___TLT, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Nyan.Click
        MChosen = 2
        Reset_Chosen()
        If Volume = True Then
            My.Computer.Audio.Play(My.Resources.Nyan_Cat, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
End Class
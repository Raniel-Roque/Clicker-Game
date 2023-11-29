Imports System.Reflection
Public Class Tutorial
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        Me.MaximizeBox = False

        For i As Integer = 3 To 16
            Dim pb As PictureBox = Me.Controls("PictureBox" & i)
            pb.Visible = False
        Next

        Me.BackgroundImage = My.Resources.T1
    End Sub
    Dim SettingsMainOpen As SettingsMain
    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If SettingsMainOpen Is Nothing OrElse SettingsMainOpen.IsDisposed Then
            SettingsMainOpen = New SettingsMain
        End If

        SettingsMainOpen.BringToFront()
        SettingsMainOpen.Show()
    End Sub

    Private Sub Skip(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox4.Click, PictureBox6.Click, PictureBox8.Click, PictureBox10.Click, PictureBox12.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click
        If SettingsMainOpen Is Nothing OrElse SettingsMainOpen.IsDisposed Then
            SettingsMainOpen = New SettingsMain
        End If

        SettingsMainOpen.BringToFront()
        SettingsMainOpen.Show()
        Me.Dispose()
    End Sub
    Private Sub ChangePictureBoxes(currentPictureBox As PictureBox, nextPictureBox As PictureBox, visiblePictureBox As PictureBox, visiblePictureBox2 As PictureBox, backgroundImageName As Image)
        currentPictureBox.Dispose()
        nextPictureBox.Dispose()
        visiblePictureBox.Visible = True
        visiblePictureBox2.Visible = True
        Me.BackgroundImage = backgroundImageName
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ChangePictureBoxes(PictureBox1, PictureBox2, PictureBox3, PictureBox4, My.Resources.T2)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ChangePictureBoxes(PictureBox3, PictureBox4, PictureBox5, PictureBox6, My.Resources.T3)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ChangePictureBoxes(PictureBox5, PictureBox6, PictureBox7, PictureBox8, My.Resources.T4)
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        ChangePictureBoxes(PictureBox7, PictureBox8, PictureBox9, PictureBox10, My.Resources.T5)
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ChangePictureBoxes(PictureBox9, PictureBox10, PictureBox11, PictureBox12, My.Resources.T6)
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        ChangePictureBoxes(PictureBox11, PictureBox12, PictureBox13, PictureBox14, My.Resources.T7)
    End Sub
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        ChangePictureBoxes(PictureBox13, PictureBox14, PictureBox15, PictureBox16, My.Resources.T8)
    End Sub
End Class
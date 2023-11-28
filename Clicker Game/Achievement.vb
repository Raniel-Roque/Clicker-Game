Imports System.Reflection
Public Class Achievement
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()

        Me.MaximizeBox = False

        If GData.Achievement(0) = True Then
            Achieve1.Image = My.Resources.Cat_Click_Main
        End If
        If GData.Achievement(1) = True Then
            Achieve2.Image = My.Resources.Upgrade_Achievement
        End If
        If GData.Achievement(2) = True Then
            Achieve3.Image = My.Resources.money_bag
        End If
        If GData.Achievement(3) = True Then
            Achieve4.Image = My.Resources.Cat_God
        End If
        If GData.Achievement(4) = True Then
            Achieve5.Image = My.Resources.Shiba_Inu_Cat
        End If
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
End Class
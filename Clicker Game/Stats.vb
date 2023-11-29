Imports System.Reflection
Public Class Stats
    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        Me.MaximizeBox = False

        Stat1.Text = String.Format("{0:N0}", GData.Click)
        Stat3.Text = String.Format("{0:N0}", GData.AscCount)
        Stat4.Text = String.Format("{0:N0}", GData.Rebirth)

        Dim AutoClickPower As ULong = 0UL

        If Level(1) > 0 Then
            AutoClickPower += AutoClickValue(0)
        End If
        If Level(4) > 0 Then
            AutoClickPower += AutoClickValue(1)
        End If
        If Level(9) > 0 Then
            AutoClickPower += AutoClickValue(2)
        End If

        Stat2.Text = String.Format("{0:N0}", AutoClickPower)

    End Sub
    Private Sub Stats_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        Me.Dispose()
    End Sub
End Class
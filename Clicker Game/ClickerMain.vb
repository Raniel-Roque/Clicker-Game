Imports System.Reflection.Emit

Public Class ClickerMain
    Public timers As New List(Of Timer)
    Public Sub AutoClick(ByVal ACValueIndex As Integer)
        Try
            GData.Money += GData.AutoClickValue(ACValueIndex)
        Catch ex As OverflowException
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            For i As Integer = 0 To Max.Length - 1
                GData.Max(i) = True
            Next

            For Each timer As Timer In timers
                timer.Enabled = False
            Next

            For i As Integer = 0 To Max.Length - 1
                Dim UPButt As Button = CType(ShopMain.Controls.Find("UP" & (i + 1).ToString, True).FirstOrDefault(), Button)
                If UPButt IsNot Nothing Then
                    UPButt.Text = String.Format("Upgrade_{0} - {1} Level: Max", i + 1, Costs(i))
                    UPButt.Enabled = False
                End If
            Next
        End Try

        GData.Display()
    End Sub
    Private Sub MainButton_Click(sender As Object, e As EventArgs) Handles MainButton.Click
        MainButton.Image = My.Resources.Cat_Click_Main_2
    End Sub
    Private Sub MainButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainButton.MouseDown
        MainButton.Image = My.Resources.Cat_Click_Main

        Try
            GData.Money += GData.Click
        Catch ex As OverflowException
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            For i As Integer = 0 To Max.Length - 1
                GData.Max(i) = True
            Next

            For Each timer As Timer In timers
                timer.Enabled = False
            Next
        End Try

        GData.Display()
    End Sub
    Dim ShopMain As Shop
    Private Sub Shop_Click(sender As Object, e As EventArgs) Handles Shop.Click
        If ShopMain Is Nothing OrElse ShopMain.IsDisposed Then
            ShopMain = New Shop
        End If
        ShopMain.Show()
        ShopMain.BringToFront()
        Me.Hide()
    End Sub

    Private Sub AutoClick_1_Tick(sender As Object, e As EventArgs) Handles AutoClick_1.Tick
        AutoClick(0)
    End Sub

    Private Sub ClickerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Dispose()
        GData.Display()
        timers.Add(AutoClick_1)
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MessageBox.Show("Home")
    End Sub
    Private Sub Home_Enter(sender As Object, e As EventArgs) Handles Home.MouseEnter
        Home.BackColor = Color.FromArgb(252, 215, 215)
    End Sub
    Private Sub Home_NotEnter(sender As Object, e As EventArgs) Handles Home.MouseLeave
        Home.BackColor = Color.FromArgb(252, 228, 228)
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        MessageBox.Show("Settings")
    End Sub
    Private Sub Settings_Enter(sender As Object, e As EventArgs) Handles Settings.MouseEnter
        Settings.BackColor = Color.FromArgb(252, 215, 215)
    End Sub
    Private Sub Settings_NotEnter(sender As Object, e As EventArgs) Handles Settings.MouseLeave
        Settings.BackColor = Color.FromArgb(252, 228, 228)
    End Sub

    Private Sub MainButton_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
Imports System.Reflection
Public Class ShopCosmetic
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        DisposeMe.Dispose()

        Select Case Cosmetic
            Case 0
                Label1.ForeColor = Color.Green
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label13.ForeColor = Color.Black
            Case 1
                Label1.ForeColor = Color.Black
                Label3.ForeColor = Color.Green
                Label4.ForeColor = Color.Black
                Label13.ForeColor = Color.Black
            Case 2
                Label1.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Green
                Label13.ForeColor = Color.Black
            Case 3
                Label1.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                Label4.ForeColor = Color.Black
                Label13.ForeColor = Color.Green
        End Select

        TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
        Shop3.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        Shop3.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
        Me.Dispose()
    End Sub
    Private Sub UP5_Click(sender As Object, e As EventArgs) Handles UP5.Click
        Cosmetic = 0
        Label1.ForeColor = Color.Green
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
        ClickerMain.MainButton.Image = CosmeticList(Cosmetic + 1)
    End Sub
    Private Sub UP6_Click(sender As Object, e As EventArgs) Handles UP6.Click
        If CosmeticUnlocked(1) = True Then
            Cosmetic = 2
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Green
            Label4.ForeColor = Color.Black
            Label13.ForeColor = Color.Black
            ClickerMain.MainButton.Image = CosmeticList(Cosmetic + 1)
        End If
    End Sub
    Private Sub UP7_Click(sender As Object, e As EventArgs) Handles UP7.Click
        If CosmeticUnlocked(2) = False AndAlso Asc >= 50 Then
            Asc -= 50
            CosmeticUnlocked(2) = True
            Cosmetic = 4
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Green
            Label13.ForeColor = Color.Black
            ClickerMain.MainButton.Image = CosmeticList(Cosmetic + 1)
            TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
            Return
        ElseIf CosmeticUnlocked(2) = True Then
            Cosmetic = 4
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Green
            Label13.ForeColor = Color.Black
            ClickerMain.MainButton.Image = CosmeticList(Cosmetic + 1)
        End If
    End Sub
    Private Sub UP8_Click(sender As Object, e As EventArgs) Handles UP8.Click
        If CosmeticUnlocked(3) = True Then
            Cosmetic = 6
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label13.ForeColor = Color.Green
            ClickerMain.MainButton.Image = CosmeticList(Cosmetic + 1)
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Shop.Show()
        Shop.BringToFront()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AscendCoin.Tick
        TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
    End Sub
End Class
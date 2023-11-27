Imports System.Reflection

Public Class Shop
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()

        For i As Integer = 0 To 3
            Dim UPButt As Button = CType(Me.Controls.Find("UP" & (i + 1).ToString, True).FirstOrDefault(), Button)
            Dim UPLabel As Label = CType(Me.Controls.Find("LevelLabel" & (i + 1).ToString, True).FirstOrDefault(), Label)
            If Max(i) = True OrElse Level(i) >= ULong.MaxValue Then
                UPLabel.Text = String.Format("Level Max")
                UPButt.Enabled = False
            Else
                UPLabel.Text = String.Format("Level {0:N0}", Level(i))
                If i = 2 Then
                    UPLabel.Text = String.Format("Level {0:N0} / 10", Level(i))
                    If Level(i - 1) = 0 OrElse Level(i) = 10 Then
                        UPButt.Enabled = False
                    End If
                End If
            End If
        Next

        If Level(1) > 0 Then
            DisposeUnlock1.Dispose()
        End If
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop2.Dispose()
        Shop3.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop2.Dispose()
        Shop3.Dispose()
        Me.Dispose()
    End Sub
    Private Sub UP1_Click(sender As Object, e As EventArgs) Handles UP1.Click
        GData.UpgradeClick(UP1, LevelLabel1, 0, 1UL)
    End Sub
    Private Sub UP2_Click(sender As Object, e As EventArgs) Handles UP2.Click
        GData.AutoClickUpgrade_Value(ClickerMain.AutoClick_1, UP2, UP3, LevelLabel2, 1, 0, 5UL)

        If Level(1) > 0 AndAlso DisposeUnlock1 IsNot Nothing Then
            DisposeUnlock1.Dispose()
            ClickerMain.GField.Image = My.Resources.Clicker_Main_Garfield
        End If
    End Sub
    Private Sub UP3_Click(sender As Object, e As EventArgs) Handles UP3.Click
        GData.AutoClickUpgrade_Speed(ClickerMain.AutoClick_1, UP3, LevelLabel3, 2, 100UL)
    End Sub
    Private Sub UP4_Click(sender As Object, e As EventArgs) Handles UP4.Click
        GData.UpgradeClick(UP4, LevelLabel4, 3, 150UL)
    End Sub

    Private Sub DisplayLoop_Tick(sender As Object, e As EventArgs) Handles DisplayLoop.Tick
        If Money < ULong.MaxValue Then
            TopMoneyLabel.Text = String.Format("${0:N0}", GData.Money)
        Else
            TopMoneyLabel.Text = "Ascend Now!"
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            GData.Max(0) = True
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, PictureBox5.Click
        Shop2.Show()
        Shop2.BringToFront()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox7.Click
        ShopCosmetic.Show()
        ShopCosmetic.BringToFront()
        Me.Hide()
    End Sub
End Class
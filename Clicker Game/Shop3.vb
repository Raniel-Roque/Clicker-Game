Imports System.Diagnostics.Tracing
Imports System.Reflection

Public Class Shop3
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        Me.MaximizeBox = False

        For i As Integer = 8 To 11
            Dim UPButt As Button = CType(Me.Controls.Find("UP" & (i + 1).ToString, True).FirstOrDefault(), Button)
            Dim UPLabel As Label = CType(Me.Controls.Find("LevelLabel" & (i + 1).ToString, True).FirstOrDefault(), Label)
            If Max(i) = True OrElse Level(i) >= ULong.MaxValue Then
                UPLabel.Text = String.Format("Level {0:N0} - Max Cash", Level(i))
                UPButt.Enabled = False
                If i = 11 Then
                    UPLabel.Text = String.Format("Level {0:N0}", Level(i))
                    UPButt.Enabled = True
                End If
            Else
                UPLabel.Text = String.Format("Level {0:N0}", Level(i))
                If i = 10 Then
                    UPLabel.Text = String.Format("Level {0:N0} / 10", Level(i))
                    If Level(i - 1) = 0 OrElse Level(i) = 10 Then
                        UPButt.Enabled = False
                    End If
                End If
            End If
        Next

        If Level(9) > 0 Then
            DisposeUnlock1.Dispose()
        End If

        TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop2.Dispose()
        Shop.Dispose()
        Me.Dispose()
    End Sub
    Private Sub UP9_Click(sender As Object, e As EventArgs) Handles UP9.Click
        If Max(8) = True OrElse Level(8) >= ULong.MaxValue Then
            LevelLabel9.Text = String.Format("Level Max")
            UP9.Enabled = False
            GData.Max(8) = True
            Return
        End If

        If Asc - Costs(8) >= 0 Then
            Asc -= Costs(8)
            Level(8) += 1UL
            LevelLabel9.Text = String.Format("Level {0:N0}", Level(8))
            Try
                GData.Clicker(GData.Click * 0.25)
            Catch ex As OverflowException
                GData.Clicker(ULong.MaxValue)
            End Try

            GData.Display()
            TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
        End If
    End Sub
    Private Sub UP10_Click(sender As Object, e As EventArgs) Handles UP10.Click
        If Level(9) = 0 AndAlso Asc - Costs(9) >= 0 Then
            If DisposeUnlock1 IsNot Nothing Then
                DisposeUnlock1.Dispose()
                ClickerMain.CatG.Image = My.Resources.Clicker_Main_EgyptianCat
            End If

            Asc -= Costs(9)
            Level(9) += 1UL
            LevelLabel10.Text = String.Format("Level {0:N0}", Level(9))
            UP11.Enabled = True
            ClickerMain.AutoClick_3.Enabled = True
            TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
            GData.Display()
            Return
        End If

        If Asc - Costs(9) >= 0 Then
            Asc -= Costs(9)
            Level(9) += 1UL
            AutoClickValue(2) += 5000UL
            LevelLabel10.Text = String.Format("Level {0:N0}", Level(9))
            TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
            GData.Display()
        End If
    End Sub
    Private Sub UP11_Click(sender As Object, e As EventArgs) Handles UP11.Click
        If Level(10) = 0 AndAlso Asc - Costs(10) >= 0 Then
            Asc -= Costs(10)
            Level(10) += 1UL
            LevelLabel11.Text = String.Format("Level {0:N0} / 10", Level(10))
            TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
            GData.Display()
            Return
        ElseIf Asc - Costs(10) >= 0 Then
            Asc -= Costs(10)
            Level(10) += 1UL
            ClickerMain.AutoClick_3.Interval -= 750
            LevelLabel11.Text = String.Format("Level {0:N0} / 10", Level(10))

            If Level(10) = 10 Then
                UP11.Enabled = False
            End If

            TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
            GData.Display()
            Return
        End If
    End Sub
    Private Sub UP12_Click(sender As Object, e As EventArgs) Handles UP12.Click
        If Asc - Costs(11) >= 0 Then
            If GData.Achievement(4) = False Then
                GData.Achievement(4) = True
            End If

            CosmeticUnlocked(3) = True
            Rebirth += 1UL
            Level(11) += 1UL
            LevelLabel12.Text = String.Format("Level {0:N0}", Level(11))
            GData.Money = 0UL
            GData.Asc = 0UL
            GData.Click = 1UL
            For i As Integer = 0 To 10
                GData.Level(i) = 0
                GData.Max(i) = False
            Next
            ClickerMain.AutoClick_1.Enabled = False
            ClickerMain.AutoClick_2.Enabled = False
            ClickerMain.AutoClick_3.Enabled = False
            ClickerMain.AutoClick_1.Interval = 2000
            ClickerMain.AutoClick_2.Interval = 5000
            ClickerMain.AutoClick_3.Interval = 10000
            ClickerMain.GField.Image = Nothing
            ClickerMain.HKitty.Image = Nothing
            ClickerMain.CatG.Image = Nothing

            GData.AutoClickValue(0) = 5UL
            GData.AutoClickValue(1) = 500UL
            GData.AutoClickValue(2) = 5000UL

            TopMoneyLabel.Text = String.Format("{0:N0}", GData.Money)
            GData.Display()

            Shop.Dispose()
            Shop2.Dispose()
            ShopCosmetic.Dispose()
            ClickerMain.Show()
            ClickerMain.BringToFront()
            Me.Dispose()
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles BG_Back.Click, Back.Click
        Shop2.Show()
        Shop2.BringToFront()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox7.Click
        ShopCosmetic.Show()
        ShopCosmetic.BringToFront()
        Me.Hide()
    End Sub

    Private Sub AscendCoin_Tick(sender As Object, e As EventArgs) Handles AscendCoin.Tick
        TopMoneyLabel.Text = String.Format("Ascenscion Coins: {0:N0}", GData.Asc)
    End Sub
End Class
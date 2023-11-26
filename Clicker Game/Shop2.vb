Imports System.Reflection

Public Class Shop2
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        DisposeMe.Dispose()

        For i As Integer = 4 To 7
            Dim UPButt As Button = CType(Me.Controls.Find("UP" & (i + 1).ToString, True).FirstOrDefault(), Button)
            Dim UPLabel As Label = CType(Me.Controls.Find("LevelLabel" & (i + 1).ToString, True).FirstOrDefault(), Label)
            If Max(i) = True OrElse Level(i) >= ULong.MaxValue Then
                UPLabel.Text = String.Format("Level Max")
                UPButt.Enabled = False
            Else
                UPLabel.Text = String.Format("Level {0:N0}", Level(i))
                If i = 5 Then
                    UPLabel.Text = String.Format("Level {0:N0} / 10", Level(i))
                    If Level(i - 1) = 0 OrElse Level(i) = 10 Then
                        UPButt.Enabled = False
                    End If
                End If
            End If
        Next

        If Level(4) > 0 Then
            DisposeUnlock1.Dispose()
        End If
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop3.Dispose()
        Shop.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        ShopCosmetic.Dispose()
        Shop3.Dispose()
        Shop.Dispose()
        Me.Dispose()
    End Sub
    Private Sub UP5_Click(sender As Object, e As EventArgs) Handles UP5.Click
        GData.AutoClickUpgrade_Value(ClickerMain.AutoClick_2, UP5, UP6, LevelLabel5, 4, 1, 500UL)

        If Level(4) > 0 AndAlso DisposeUnlock1 IsNot Nothing Then
            DisposeUnlock1.Dispose()
        End If
    End Sub
    Private Sub UP6_Click(sender As Object, e As EventArgs) Handles UP6.Click
        GData.AutoClickUpgrade_Speed(ClickerMain.AutoClick_2, UP6, LevelLabel6, 5, 250)
    End Sub
    Private Sub UP7_Click(sender As Object, e As EventArgs) Handles UP7.Click
        GData.UpgradeClick(UP5, LevelLabel7, 6, 1500UL)
    End Sub
    Private Sub UP8_Click(sender As Object, e As EventArgs) Handles UP8.Click
        If Money - Costs(7) >= 0 Then
            Asc += 1UL
            Money = 0
            Level(7) += 1UL
            LevelLabel8.Text = String.Format("Level {0:N0}", Level(7))
            GData.Money = 0UL
            GData.Click = 1UL
            For i As Integer = 0 To 6
                GData.Level(i) = 0
                GData.Max(i) = False
            Next

            ClickerMain.AutoClick_1.Enabled = False
            ClickerMain.AutoClick_2.Enabled = False
            ClickerMain.AutoClick_1.Interval = 2000
            ClickerMain.AutoClick_2.Interval = 5000

            GData.AutoClickValue(0) = 5UL
            GData.AutoClickValue(1) = 500UL

            TopMoneyLabel.Text = String.Format("{0:N0}", GData.Money)
            GData.Display()

            ClickerMain.Show()
            ClickerMain.BringToFront()
            Me.Dispose()
        End If
    End Sub

    Private Sub DisplayLoop_Tick(sender As Object, e As EventArgs) Handles DisplayLoop.Tick
        If Money < ULong.MaxValue Then
            TopMoneyLabel.Text = String.Format("{0:N0}", GData.Money)
        Else
            TopMoneyLabel.Text = "Ascend Now!"
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            GData.Max(0) = True
        End If
    End Sub

    Private Sub Next_Click(sender As Object, e As EventArgs) Handles Next_.Click, BG_Next.Click
        Shop3.Show()
        Shop3.BringToFront()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles BG_Back.Click, Back.Click
        Shop.Show()
        Shop.BringToFront()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ShopCosmetic.Show()
        ShopCosmetic.BringToFront()
        Me.Hide()
    End Sub
End Class
Imports System.Reflection

Public Class Shop
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Dispose()

        For i As Integer = 0 To Max.Length - 1
            Dim UPButt As Button = CType(Me.Controls.Find("UP" & (i + 1).ToString, True).FirstOrDefault(), Button)
            Dim UPLabel As Label = CType(Me.Controls.Find("LevelLabel" & (i + 1).ToString, True).FirstOrDefault(), Label)
            If Max(i) = True OrElse Level(i) >= ULong.MaxValue Then
                UPLabel.Text = String.Format("Level Max")
                UPButt.Enabled = False
            Else
                UPLabel.Text = String.Format("Level {0:N0}", Level(i))
                If i <> 0 AndAlso i Mod 2 = 0 Then
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
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ClickerMain.Show()
        ClickerMain.BringToFront()
        Me.Dispose()
    End Sub
    Private Sub UpgradeClick(
                            UPButt As Button,
                            UPLabel As Label,
                            Index As Integer,
                            Click_Value As ULong
                            )

        If Max(Index) = True OrElse Level(Index) >= ULong.MaxValue Then
            UPLabel.Text = String.Format("Level Max")
            UPButt.Enabled = False
            GData.Max(Index) = True
            Return
        End If

        If Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            UPLabel.Text = String.Format("Level {0:N0}", Level(Index))
            GData.Clicker(Click_Value)
            GData.Display()
        End If
    End Sub
    Private Sub AutoClickUpgrade_Value(
                                      AutoClick_Timer As Timer,
                                      UPButt As Button,
                                      UPButtSpeed As Button,
                                      UPLabel As Label,
                                      Index As Integer,
                                      IndexVal As Integer,
                                      AutoClick_Val As Integer
                                      )

        If Level(Index) = 0 AndAlso Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            UPLabel.Text = String.Format("Level {0:N0}", Level(Index))
            UPButtSpeed.Enabled = True
            AutoClick_Timer.Enabled = True
            GData.Display()
            Return
        End If

        If Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            AutoClickValue(IndexVal) += AutoClick_Val
            UPLabel.Text = String.Format("Level {0:N0}", Level(Index))
            GData.Display()
        End If
    End Sub
    Private Sub AutoClickUpgrade_Speed(
                                      AutoClick_Timer As Timer,
                                      UPButt As Button,
                                      UPLabel As Label,
                                      Index As Integer,
                                      AutoClick_Speed As Integer
                                      )

        If Level(Index) = 0 AndAlso Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            UPLabel.Text = String.Format("Level {0:N0} / 10", Level(Index))
            GData.Display()
            Return
        ElseIf Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            AutoClick_Timer.Interval -= AutoClick_Speed
            UPLabel.Text = String.Format("Level {0:N0} / 10", Level(Index))

            If Level(Index) = 10 Then
                UPButt.Enabled = False
            End If

            GData.Display()
            Return
        End If
    End Sub
    Private Sub UP1_Click(sender As Object, e As EventArgs) Handles UP1.Click
        UpgradeClick(UP1, LevelLabel1, 0, 1UL)
    End Sub
    Private Sub UP2_Click(sender As Object, e As EventArgs) Handles UP2.Click
        AutoClickUpgrade_Value(ClickerMain.AutoClick_1, UP2, UP3, LevelLabel2, 1, 0, 2UL)

        If Level(1) > 0 AndAlso DisposeUnlock1 IsNot Nothing Then
            DisposeUnlock1.Dispose()
        End If
    End Sub
    Private Sub UP3_Click(sender As Object, e As EventArgs) Handles UP3.Click
        AutoClickUpgrade_Speed(ClickerMain.AutoClick_1, UP3, LevelLabel3, 2, 100)
    End Sub
    Private Sub UP4_Click(sender As Object, e As EventArgs) Handles UP4.Click
        UpgradeClick(UP4, LevelLabel4, 3, 80UL)
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
End Class
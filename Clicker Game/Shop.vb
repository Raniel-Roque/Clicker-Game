Imports System.Reflection

Public Class Shop
    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Dispose()

        For i As Integer = 0 To Max.Length - 1
            Dim UPButt As Button = CType(Me.Controls.Find("UP" & (i + 1).ToString, True).FirstOrDefault(), Button)
            If Max(i) = True OrElse Level(i) >= ULong.MaxValue Then
                UPButt.Text = String.Format("Upgrade_{0} - {1} Level: Max", i + 1, Costs(i))
                UPButt.Enabled = False
            Else
                UPButt.Text = String.Format("Upgrade_{0} - {1} Level: {2:N0}", i + 1, Costs(i), Level(i))
                If i <> 0 AndAlso i Mod 2 = 0 Then
                    If Level(i - 1) = 0 OrElse Level(i) = 10 Then
                        UPButt.Enabled = False
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Shop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClickerMain.Show()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ClickerMain.Show()
        Me.Close()
    End Sub
    Private Sub UpgradeClick(UPButt As Button, Upgrade_Name As String, Index As Integer, Click_Value As ULong)
        If Max(Index) = True OrElse Level(Index) >= ULong.MaxValue Then
            UPButt.Text = String.Format("{0} - {1} Level: Max", Upgrade_Name, Costs(Index))
            UPButt.Enabled = False
            GData.Max(Index) = True
            Return
        End If

        If Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            UPButt.Text = String.Format("{0} - {1} Level: {2:N0}", Upgrade_Name, Costs(Index), Level(Index))
            GData.Clicker(Click_Value)
            GData.Display()
        End If
    End Sub
    Private Sub AutoClickUpgrade_Value(AutoClick_Timer As Timer, UPButt As Button, UPButtSpeed As Button, Upgrade_Name As String, Index As Integer, IndexVal As Integer, AutoClick_Val As Integer)
        If Level(Index) = 0 AndAlso Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            UPButt.Text = String.Format("{0} - {1} Level: {2:N0}", Upgrade_Name, Costs(Index), Level(Index))
            UPButtSpeed.Enabled = True
            AutoClick_Timer.Enabled = True
            GData.Display()
            Return
        End If

        If Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            AutoClickValue(IndexVal) += AutoClick_Val
            UPButt.Text = String.Format("{0} - {1} Level: {2:N0}", Upgrade_Name, Costs(Index), Level(Index))
            GData.Display()
        End If
    End Sub
    Private Sub AutoClickUpgrade_Speed(AutoClick_Timer As Timer, UPButt As Button, Upgrade_Name As String, Index As Integer, AutoClick_Speed As Integer)
        If Level(Index) = 0 AndAlso Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            UPButt.Text = String.Format("{0} - {1} Level: {2:N0} / 10", Upgrade_Name, Costs(Index), Level(Index))
            GData.Display()
            Return
        ElseIf Money - Costs(Index) >= 0 Then
            Money -= Costs(Index)
            Level(Index) += 1UL
            AutoClick_Timer.Interval -= AutoClick_Speed
            UPButt.Text = String.Format("{0} - {1} Level: {2:N0} / 10", Upgrade_Name, Costs(Index), Level(Index))

            If Level(Index) = 10 Then
                UPButt.Enabled = False
            End If

            GData.Display()
            Return
        End If
    End Sub
    Private Sub UP1_Click(sender As Object, e As EventArgs) Handles UP1.Click
        UpgradeClick(UP1, "Upgrade_1", 0, 1UL)
    End Sub
    Private Sub UP2_Click(sender As Object, e As EventArgs) Handles UP2.Click
        AutoClickUpgrade_Value(ClickerMain.AutoClick_1, UP2, UP3, "Upgrade_2", 1, 0, 2UL)
    End Sub
    Private Sub UP3_Click(sender As Object, e As EventArgs) Handles UP3.Click
        AutoClickUpgrade_Speed(ClickerMain.AutoClick_1, UP3, "Upgrade_3", 2, 100)
    End Sub

    Private Sub DisplayLoop_Tick(sender As Object, e As EventArgs) Handles DisplayLoop.Tick
        If Money < ULong.MaxValue Then
            TopMoneyLabel.Text = String.Format("{0:N0}", GData.Money)
        Else
            TopMoneyLabel.Text = "Maxed Cash! Ascend Now!"
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            GData.Max(0) = True
        End If
    End Sub
End Class
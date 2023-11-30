Module GData
    'Settings
    Public Volume = True
    Public MChosen As Integer = 0

    'Main Money
    Public Money As ULong = 0UL
    Public Click As ULong = 1UL
    Public Asc As ULong = 50UL
    Public AscCount As ULong = 0UL
    Public Rebirth As ULong = 0UL
    Public FirstClick As Boolean = False

    'Upgrades
    Public Costs() = {
        10, 100, 500, 1000,
        3000, 5000, 10000, 50000,
        1, 1, 1, 5
    }
    Public Max() = {
        False, False, False, False,
        False, False, False, False,
        False, False, False, False
    }
    Public Level() = {
        0, 0, 0, 0,
        0, 0, 0, 0,
        0, 0, 0, 0
    }

    Public AutoClickValue() = {5UL, 500UL, 5000UL}

    'Cosmetics
    Public CosmeticUnlocked() = {True, False, False, False}
    Public Cosmetic = 0
    Public CosmeticList() = {
        My.Resources.Cat_Click_Main, My.Resources.Cat_Click_Main_2,
        My.Resources.Golden_Main_1, My.Resources.Golden_Main_2,
        My.Resources.Cookie_Main_1, My.Resources.Cookie_Main_2,
        My.Resources.Black_Main_1, My.Resources.Black_Main_2
    }

    Public Achievement() As Boolean = {False, False, False, False, False}
    'Global Functions
    Public Sub Clicker(ByVal Click_Count As ULong)
        If Click_Count < ULong.MaxValue Then
            Click += Click_Count
        Else
            For i As Integer = 0 To Max.Length - 1
                If i = 0 OrElse i = 3 OrElse i = 6 OrElse i = 8 Then
                    GData.Max(i) = True
                End If
            Next
            Shop.UP1.Enabled = False
            Shop.UP4.Enabled = False
            Shop2.UP7.Enabled = False
            Shop3.UP9.Enabled = False

            Shop2.LevelLabel7.Text = "Level Max"
            Shop3.LevelLabel9.Text = "Level Max"
        End If
    End Sub
    Public Sub Display()
        If Money < ULong.MaxValue Then
            ClickerMain.TopMoneyLabel.Text = String.Format("${0:N0}", GData.Money)
            ClickerMain.BotMoneyLabel.Text = String.Format("${0:N0}", GData.Money)
        Else
            ClickerMain.TopMoneyLabel.Text = "Ascend Now!"
            ClickerMain.BotMoneyLabel.Text = "Maxed Cash! Ascend Now!"
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            GData.Max(0) = True
        End If
    End Sub

    'Global Shop Functions
    Public Sub UpgradeClick(
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

            If GData.Achievement(1) = False Then
                GData.Achievement(1) = True
            End If
        End If
    End Sub
    Public Sub AutoClickUpgrade_Value(
                                      AutoClick_Timer As Timer,
                                      UPButt As Button,
                                      UPButtSpeed As Button,
                                      UPLabel As Label,
                                      Index As Integer,
                                      IndexVal As Integer,
                                      AutoClick_Val As Integer
                                      )

        If Level(Index) = 0 AndAlso Money - Costs(Index) >= 0 Then
            If GData.Achievement(1) = False Then
                GData.Achievement(1) = True
            End If
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
    Public Sub AutoClickUpgrade_Speed(
                                      AutoClick_Timer As Timer,
                                      UPButt As Button,
                                      UPLabel As Label,
                                      Index As Integer,
                                      AutoClick_Speed As Integer
                                      )

        If Level(Index) = 0 AndAlso Money - Costs(Index) >= 0 Then
            If GData.Achievement(1) = False Then
                GData.Achievement(1) = True
            End If
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
End Module

Module GData
    'Save State

    'Main Money
    Public Money As ULong = 1UL
    Public Click As ULong = 1UL

    'Upgrades
    Public Costs() = {10, 100, 250}
    Public Max() = {False, False, False}
    Public Level() = {0, 0, 0}
    Public AutoClickValue() = {2UL}

    'Global Functions
    Public Sub Clicker(ByVal Click_Count As Integer)
        If Click < ULong.MaxValue Then
            Click += Click_Count
        Else
            For i As Integer = 0 To Max.Length - 1
                If i = 0 OrElse i Mod 3 = 0 Then
                    GData.Max(i) = True
                End If
            Next
        End If
    End Sub
    Public Sub Display()
        If Money < ULong.MaxValue Then
            ClickerMain.TopMoneyLabel.Text = String.Format("{0:N0}", GData.Money)
            ClickerMain.BotMoneyLabel.Text = String.Format("{0:N0}", GData.Money)
        Else
            ClickerMain.TopMoneyLabel.Text = "Maxed Cash! Ascend Now!"
            ClickerMain.BotMoneyLabel.Text = "Maxed Cash! Ascend Now!"
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            GData.Max(0) = True
        End If
    End Sub
End Module

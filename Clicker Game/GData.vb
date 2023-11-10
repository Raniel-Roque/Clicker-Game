Module GData
    'Main Money
    Public Money As Decimal = 1000000
    Public Click As Decimal = 1
    Public Click_Temp As ULong = 1
    'Upgrades
    Public UP1_Base = 25
    Public UP1_Cost = 25
    Public UP1_Level As Decimal
    Public UP1_Max = False

    'Suffixes
    Public Suffix() = {Nothing, "K", "M"}
    Public SuffixType = 0
    Public SuffixUP1 = 0

    'Functions
    Public Sub Display()
        If SuffixType <> 0 Then
            ClickerMain.MainButton.Text = String.Format("{0:F2} {1}", GData.Money, Suffix(SuffixType))
            Return
        End If

        ClickerMain.MainButton.Text = String.Format("{0} {1}", GData.Money, Suffix(SuffixType))
    End Sub

    Public Sub Update()
        If GData.Money < 1000 Then
            Display()
        Else
            UP1_Cost = UP1_Base / 1000

            SuffixType += 1
            Money /= 1000
            Click /= 1000
            Display()
        End If
    End Sub

    Public Function Format(ByVal Num As Integer, UPNum As Integer)
        Click = Click_Temp / (1000 ^ SuffixType)
        UP1_Cost = UP1_Base / (1000 ^ SuffixType)

        If Num < (1000 ^ (UPNum + 1)) Then
            If UPNum <> 0 Then
                Return String.Format("{0:F2} {1}", (Num / 1000), Suffix(UPNum))
            End If

            Return String.Format("{0} {1}", Num, Suffix(UPNum))
        Else
            UPNum += 1
            Return String.Format("{0:F2} {1}", (Num / 1000), Suffix(UPNum))
        End If
    End Function
End Module

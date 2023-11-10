Public Class Shop
    Dim Constant_BaseUP1 = 25
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ClickerMain.Show()
        Me.Close()
    End Sub

    Private Sub UP1_Click(sender As Object, e As EventArgs) Handles UP1.Click
        If Money - UP1_Cost >= 0 Then
            Money -= UP1_Cost
            UP1_Level += 1
            UP1_Base = CInt(Math.Round(Constant_BaseUP1 * Math.Pow(2, 0.2 * (UP1_Level))))
            GData.Click_Temp += 1
            UP1.Text = String.Format("UP1 - {0} Level: {1} / 50", Format(UP1_Base, GData.SuffixUP1), UP1_Level)
            GData.Update()
        End If

        If UP1_Level = 50 Then
            UP1.Enabled = False
            UP1_Max = True
            UP1.Text = "UP1 - Max Level - 50 / 50"
        End If
    End Sub

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UP1.Enabled = Not UP1_Max

        If Not UP1_Max Then
            UP1.Text = String.Format("UP1 - {0} Level: {1} / 50", Format(UP1_Base, GData.SuffixUP1), UP1_Level)
        Else
            UP1.Text = "UP1 - Max Level - 50 / 50"
        End If
    End Sub
End Class
Public Class ClickerMain
    Private Sub MainButton_Click(sender As Object, e As EventArgs) Handles MainButton.Click
        GData.Money += GData.Click
        GData.Update()
    End Sub
    Dim ShopMain As Shop
    Private Sub Shop_Click(sender As Object, e As EventArgs) Handles Shop.Click
        If ShopMain Is Nothing OrElse ShopMain.IsDisposed Then
            ShopMain = New Shop
        End If
        ShopMain.Show()
        ShopMain.BringToFront()
        Me.Hide()
    End Sub
End Class
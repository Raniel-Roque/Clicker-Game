Imports System.Reflection.Emit

Public Class ClickerMain
    Public timers As New List(Of Timer)
    Private Sub ClickerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisposeMe.Focus()
        GData.Display()
        timers.Add(AutoClick_1)
        timers.Add(AutoClick_2)
        timers.Add(AutoClick_3)
        My.Computer.Audio.Play(My.Resources.Bongo_Cat_Song___CG5, AudioPlayMode.BackgroundLoop)
        Me.MaximizeBox = False
    End Sub
    Private Sub ClickerMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Public Sub AutoClick(ByVal ACValueIndex As Integer)
        Try
            GData.Money += GData.AutoClickValue(ACValueIndex)
        Catch ex As OverflowException
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            For i As Integer = 0 To 6
                GData.Max(i) = True
            Next

            For Each timer As Timer In timers
                timer.Enabled = False
            Next
        End Try

        GData.Display()
    End Sub
    Private Sub MainButton_Click(sender As Object, e As EventArgs) Handles MainButton.Click
        MainButton.Image = CosmeticList(Cosmetic + 1)
    End Sub

    Private Sub MainButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MainButton.MouseDown
        MainButton.Image = CosmeticList(Cosmetic)

        Try
            GData.Money += GData.Click
        Catch ex As OverflowException
            GData.Money = ULong.MaxValue
            GData.Click = ULong.MaxValue
            For i As Integer = 0 To Max.Length - 1
                GData.Max(i) = True
            Next

            For Each timer As Timer In timers
                timer.Enabled = False
            Next
        End Try

        If FirstClick = False Then
            FirstClick = True
            GData.Achievement(0) = True
        End If

        If Money >= 1000000 Then
            CosmeticUnlocked(1) = True
            GData.Achievement(2) = True
        End If

        GData.Display()
    End Sub
    Dim SettingsMainOpen As SettingsMain
    Dim StatsMain As Stats
    Dim AchievementMain As Achievement
    Dim ShopMain As Shop
    Dim ShopMain2 As Shop2
    Dim ShopMain3 As Shop3
    Dim ShopMainCosmetic As ShopCosmetic
    Private Sub Shop_Click(sender As Object, e As EventArgs) Handles Shop.Click
        If ShopMain IsNot Nothing Then
            ShopMain.Dispose()
        End If

        If ShopMain2 IsNot Nothing Then
            ShopMain2.Dispose()
        End If

        If ShopMain3 IsNot Nothing Then
            ShopMain3.Dispose()
        End If

        If ShopMainCosmetic IsNot Nothing Then
            ShopMainCosmetic.Dispose()
        End If

        If ShopMain Is Nothing OrElse ShopMain.IsDisposed Then
            ShopMain = New Shop
        End If

        If ShopMain Is Nothing OrElse ShopMain.IsDisposed Then
            ShopMain2 = New Shop2
        End If

        If ShopMain3 Is Nothing OrElse ShopMain.IsDisposed Then
            ShopMain3 = New Shop3
        End If

        If ShopMainCosmetic Is Nothing OrElse ShopMain.IsDisposed Then
            ShopMainCosmetic = New ShopCosmetic
        End If

        ShopMain.BringToFront()
        ShopMain.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Achievement.Click
        If AchievementMain Is Nothing OrElse AchievementMain.IsDisposed Then
            AchievementMain = New Achievement
        End If

        AchievementMain.BringToFront()
        AchievementMain.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If StatsMain Is Nothing OrElse StatsMain.IsDisposed Then
            StatsMain = New Stats
        End If

        StatsMain.BringToFront()
        StatsMain.Show()
        Me.Hide()
    End Sub
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        If SettingsMainOpen Is Nothing OrElse SettingsMainOpen.IsDisposed Then
            SettingsMainOpen = New SettingsMain
        End If

        SettingsMainOpen.BringToFront()
        SettingsMainOpen.Show()
        Me.Hide()
    End Sub
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MessageBox.Show("Home")
    End Sub
    Private Sub AutoClick_1_Tick(sender As Object, e As EventArgs) Handles AutoClick_1.Tick
        AutoClick(0)
    End Sub
    Private Sub AutoClick_2_Tick(sender As Object, e As EventArgs) Handles AutoClick_2.Tick
        AutoClick(1)
    End Sub
    Private Sub AutoClick_3_Tick(sender As Object, e As EventArgs) Handles AutoClick_3.Tick
        AutoClick(2)
    End Sub
    Private Sub Home_Enter(sender As Object, e As EventArgs) Handles Home.MouseEnter
        Home.BackColor = Color.FromArgb(252, 215, 215)
    End Sub
    Private Sub Home_NotEnter(sender As Object, e As EventArgs) Handles Home.MouseLeave
        Home.BackColor = Color.FromArgb(252, 228, 228)
    End Sub
    Private Sub Settings_Enter(sender As Object, e As EventArgs) Handles Settings.MouseEnter
        Settings.BackColor = Color.FromArgb(252, 215, 215)
    End Sub
    Private Sub Settings_NotEnter(sender As Object, e As EventArgs) Handles Settings.MouseLeave
        Settings.BackColor = Color.FromArgb(252, 228, 228)
    End Sub
End Class
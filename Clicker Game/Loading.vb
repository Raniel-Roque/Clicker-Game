Imports System.Reflection
Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            If Label1.Text = "Loading" Then
                Label1.Text = "Loading."
            ElseIf Label1.Text = "Loading." Then
                Label1.Text = "Loading.."
            ElseIf Label1.Text = "Loading.." Then
                Label1.Text = "Loading..."
            ElseIf Label1.Text = "Loading..." Then
                Label1.Text = "Loading"
            End If

            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            ClickerMain.Show()
            Me.Close()
        End If
    End Sub
End Class
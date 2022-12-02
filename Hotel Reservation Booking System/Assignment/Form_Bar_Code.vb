Public Class Form_Bar_Code
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim m As New MsgBoxResult
        m = MessageBox.Show("Payment Successful, Thank You For Supporting Sparrow Resort!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If (m = MsgBoxResult.Ok) = True Then
            Form_MainPage.Show()
            Me.Close()
        End If
    End Sub
End Class
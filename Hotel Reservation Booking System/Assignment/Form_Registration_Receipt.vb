Imports System.Drawing.Printing
Public Class Form_Registration_Receipt
    Friend strICPass As String
    Friend strGname As String
    Friend strChkinD As String
    Friend strChkoutD As String
    Friend strdeposit As String
    Private Sub Form_Registration_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strICPass = Form_Payment.txtIC.Text
        strGname = Form_Payment.txtGuest_Name.Text
        strChkinD = Form_Payment.dtpCheck_In_Date.Value
        strChkoutD = Form_Payment.dtpCheck_Out_Date.Value
        strdeposit = Form_Payment.txtDeposit.Text

        txtReceipt.BackColor = Color.White
        txtReceipt.Text &= Chr(13) & "                                             SPARROW'S RESORT                                                         "
        txtReceipt.Text &= Chr(13) & "                                                    "
        txtReceipt.Text &= Chr(13) & "                                                     "
        txtReceipt.Text &= Chr(13) & "                                           Guess Reservation Receipt"
        txtReceipt.Text &= Chr(13) & "      ----------------------------------------------------------------------------------------------------------------"
        txtReceipt.Text &= Chr(13) & "              "
        txtReceipt.Text &= Chr(13) & "         Check In Date:    " & strChkinD
        txtReceipt.Text &= Chr(13) & "         Check Out Date: " & strChkoutD
        txtReceipt.Text &= Chr(13) & "                                  "
        txtReceipt.Text &= Chr(13) & "         -----Guest-----       "
        txtReceipt.Text &= Chr(13) & "       "
        txtReceipt.Text &= Chr(13) & "         Guest Name:                          " & strGname
        txtReceipt.Text &= Chr(13) & "         Guess's IC/Passport number: " & strICPass
        txtReceipt.Text &= Chr(13) & "              "
        txtReceipt.Text &= Chr(13) & "         Deposit (RM):  " & strdeposit
        txtReceipt.Text &= Chr(13) & "               "
        txtReceipt.Text &= Chr(13) & "      -------------------THANK YOU FOR CHOOSING OUR RESORT,-------------------"
        txtReceipt.Text &= Chr(13) & "                         HAVE A NICE DAY ON YOUR VACATION...!!!             "
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt.Text, New Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 150, 125)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1
        Dim result As DialogResult = PrintDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
Imports System.Drawing.Printing
Public Class Form_Receipt
    Friend strICPass As String
    Friend strGname As String
    Friend strChaletno As String
    Friend strChaletT As String
    Friend strChkinD As String
    Friend strChkoutD As String
    Friend strdeposit As String
    Friend strtotal As String
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        prnDlg.Document = prnDoc
        Dim result As DialogResult = prnDlg.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            prnDoc.Print()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub prnDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles prnDoc.PrintPage
        e.Graphics.DrawString(txtReceipt.Text, New Font("Verdana", 12, FontStyle.Bold), Brushes.Black, 150, 125)
    End Sub

    Private Sub Form_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strICPass = Form_Search_Guest_Details.txtIC_Passport.Text
        strGname = Form_Search_Guest_Details.txtGuestName.Text
        strChaletno = Form_Search_Guest_Details.txtChaletNumber.Text
        strChaletT = Form_Search_Guest_Details.txtChaletType.Text
        strChkinD = Form_Search_Guest_Details.dtpCheckIn.Value
        strChkoutD = Form_Search_Guest_Details.dtpCheckOut.Value
        strdeposit = Form_Search_Guest_Details.txtDeposit.Text
        strtotal = Form_Search_Guest_Details.txtTotal_Amount.Text

        txtReceipt.BackColor = Color.White
        txtReceipt.Text &= Chr(13) & "                                             SPARROW'S RESORT                                                         "
        txtReceipt.Text &= Chr(13) & "                                                    "
        txtReceipt.Text &= Chr(13) & "                                                     "
        txtReceipt.Text &= Chr(13) & "                                                    Guess Receipt"
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
        txtReceipt.Text &= Chr(13) & "        -----Chalet-----  "
        txtReceipt.Text &= Chr(13) & "              "
        txtReceipt.Text &= Chr(13) & "          Chalet Number:  " & strChaletno
        txtReceipt.Text &= Chr(13) & "          Chalet Type:      " & strChaletT
        txtReceipt.Text &= Chr(13) & "              "
        txtReceipt.Text &= Chr(13) & "                                                                             Deposit (RM):  " & strdeposit
        txtReceipt.Text &= Chr(13) & "                                                                    Total Amount (RM):  " & strtotal
        txtReceipt.Text &= Chr(13) & "               "
        txtReceipt.Text &= Chr(13) & "      -------------------THANK YOU FOR CHOOSING OUR RESORT,-------------------"
        txtReceipt.Text &= Chr(13) & "                                  HAVE A NICE DAY !!!             "
    End Sub

    Private Sub txtReceipt_TextChanged(sender As Object, e As EventArgs) Handles txtReceipt.TextChanged

    End Sub
End Class
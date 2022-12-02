Imports System.Data.OleDb
Public Class Form_Payment
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdUpdate As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"

    Private Sub Form_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'open connection

        MessageBox.Show("Please Click [Total] To Calculate The Total Payment of The Guest", "Total Payment", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Sparrow Resort's Staff have to Click Total Button to View the Total Deposit, Owing and Total Amout
        btnCalculate.Enabled = False
        btnSelect.Enabled = False
        btnPayment.Enabled = False
        btnPrint_Receipt.Enabled = False
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Try
            If txtChalet_Type.Text = "Supreme" Then 'If Chalet Type TextBox Show Supreme, Price TextBox will show 250
                lblPrice.Text = "250"
            ElseIf txtChalet_Type.Text = "Standard" Then 'If Chalet Type TextBox Show Standard, Price TextBox will show 150
                lblPrice.Text = "150"
            End If

            Dim deposit As Integer 'Declare deposit as Integer
            Dim total As Integer 'Declare total as Integer
            Dim owing As Integer 'Declare owing as Integer
            Dim paid As String 'Declare paid as Integer

            deposit = lblPrice.Text * txtDuration.Text * 0.4 'Deposit Amount = Price of Chalet Type * Duration Stay * 0.4 (40%)
            total = (lblPrice.Text * txtDuration.Text) - deposit 'Total Amount = (Price of Chalet Type * Duration Stay) - Deposit Value
            owing = paid - (total + deposit) 'Owing Amount = Paid Amount - (Total Amount + Total Deposit)
            txtDeposit.Text = deposit
            txtTotal_Amount.Text = total
            txtOwing.Text = owing
            txtPaid.Text = paid

            btnCalculate.Enabled = True
        Catch
            MessageBox.Show("Please Calculate Again", "Calculation Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblPayment_Type.Text = "(Please Select the Type of Method)" 'After users click Payment Button, a MessageBox will to remind users to select the Payment Method From Guest
        lblPayment_Type.Show() 'Payment Label will show
        MessageBox.Show("Please Select the Type of Mehthod.", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnSelect.Hide() ''Select' Button will hide
        btnCash.Show() ' 'Cash' Button will Show
        btnCreditCard.Show() ' 'Credit Card' Button will Show
        btnBarCode.Show() ' 'Bar Code' Button will Show

    End Sub

    Private Sub btnPrint_Receipt_Click(sender As Object, e As EventArgs) Handles btnPrint_Receipt.Click
        Form_Registration_Receipt.Show()
        MessageBox.Show("Print Receipt Successful, Please Select The Type of Payment", "Type of Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnSelect.Enabled = True

        Form_Chalet.Close()
        Form_Register.Close()
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        If btnCash.Enabled = True Then 'If 'Cash' Button is SELECTED, 'Bar Code' and 'Credit Card' Button will DISABLE
            btnBarCode.Enabled = False
            btnCreditCard.Enabled = False

            Dim m As New MsgBoxResult
            m = MessageBox.Show("Payment Successful! Thank You For Supporting Sparrow Resort!", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If (m = MsgBoxResult.Ok) = True Then
                Form_MainPage.Show()
                Me.Close()
            End If
        Else 'If 'Cash' Button is NOT SELECTED, 'Bar Code' and 'Credit Card' Button will ENABLE
            btnCash.Enabled = True
            btnBarCode.Enabled = True
            btnCreditCard.Enabled = True
        End If
    End Sub

    Private Sub btnCreditCard_Click(sender As Object, e As EventArgs) Handles btnCreditCard.Click
        If btnCreditCard.Enabled = True Then 'If 'Credit Card' Button is SELECTED, 'Bar Code' and 'Cash' Button will DISABLE
            btnCash.Enabled = False
            btnBarCode.Enabled = False

            Dim m As New MsgBoxResult
            m = MessageBox.Show("Payment Successful! Thank You For Supporting Sparrow Resort!", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If (m = MsgBoxResult.Ok) = True Then
                Form_MainPage.Show()
                Me.Close()
            End If
        Else 'If 'Credit Card' Button is NOT SELECTED, 'Bar Code' and 'Cash' Button will ENABLE
            btnCash.Enabled = True
            btnBarCode.Enabled = True
            btnCreditCard.Enabled = True
        End If
    End Sub

    Private Sub btnBarCode_Click(sender As Object, e As EventArgs) Handles btnBarCode.Click
        Form_Bar_Code.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If txtPaid.Text = "" Then 'If Paid TextBox is Blank, an error will appear
            MessageBox.Show("Plase Insert Value of Paid", "Value of Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPaid.Text < txtDeposit.Text Then 'If Paid Amount is LESS THAN Deposit Amount , an error will appear to remind staff to collect actual deposit value
            MessageBox.Show("Please Insert Actual Deposit Value", "Actual Deposit Value", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtOwing.Text = txtPaid.Text + CInt(txtOwing.Text) 'Owing Amount = Paid Value + Owing Amount (Owing Amount is Negative value)

            MessageBox.Show("Please Click [Payment] Button to Proceed Payment", "Proceed Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnPayment.Enabled = True 'If payment is successful, 'Payment' Button will enable
        End If
    End Sub

    Private Sub btnPayment_Click_1(sender As Object, e As EventArgs) Handles btnPayment.Click
        Try
            cmdUpdate.CommandText = "Update tbl_reservation Set Deposit = " & txtDeposit.Text & ", Total_Amount = " & txtTotal_Amount.Text & ", Owing = " & txtOwing.Text & " Where GuestIC_PassportNo= '" & txtIC.Text & "';" 'Update Deposit, Owing and Total Amount by Searching IC / Passport in Reservation Database Table.
            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = cnnOLEDB
            cmdUpdate.ExecuteNonQuery()

            btnPrint_Receipt.Enabled = True 'If Update successful, 'Print' Receipt will Enable.
            MessageBox.Show("Payment Successful, Please Print for Receipt", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("Payment Failed", "Payment Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
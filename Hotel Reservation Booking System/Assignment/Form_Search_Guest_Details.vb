Imports System.Data.OleDb
Public Class Form_Search_Guest_Details
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdSearch As New OleDbCommand
    Dim cmdSearch1 As New OleDbCommand
    Dim cmdSearch2 As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
    Dim cmdDelete1 As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdUpdate1 As New OleDbCommand
    Dim cmdupdate2 As New OleDbCommand
    Dim cmdUpdate3 As New OleDbCommand
    Dim cmdUpdate4 As New OleDbCommand
    Dim cmdUpdate5 As New OleDbCommand
    Dim cmdUpdate6 As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"

    Private Sub Form_Search_Guest_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'Open connection

        btnCalculate.Enabled = False 'Calculate Button Disable
        btnSubmit.Visible = False 'Submit Button Disable
        btnPayment.Visible = False 'Payment Button Invisible
        btnPrint_Receipt.Visible = False 'Print Button Invisible
        txtIC_Passport.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtIC_Passport.Text = "" Then 'If IC/ Passport is Blank, an Error will appear to remind users to insert COMPLETE DETAILS
                MessageBox.Show("Please Insert Guest IC / Passport Number", "IC / Passport Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim s As String 'Declare s as String Variable
                s = CStr(txtIC_Passport.Text)
                cmdSearch.CommandText = "SELECT * From tbl_guestdetails Where GuestIC_PassportNo = '" & s & "'" 'Select ALL Data using Guest IC / Passport from Guest Details Database Table
                cmdSearch.Connection = cnnOLEDB
                Dim dr As OleDbDataReader = cmdSearch.ExecuteReader()
                If dr.Read() = True Then ' If the record can be queried,Data Row from 1,2,3,4 will show in Guest Name TextBox, Contact Number TextBox, Email Address TextBox and Number of Peoples ComboBox 
                    txtGuestName.Text = dr(1).ToString
                    txtContactNumber.Text = dr(2).ToString
                    txtEmailAddress.Text = dr(3).ToString
                    cboNumberOfPeoples.Text = dr(4).ToString
                End If
                dr.Close()
                cmdSearch1.CommandText = "SELECT * From tbl_reservation Where GuestIC_PassportNo = '" & s & "'" 'Select All DATA by using Guest IC / Passport Number from Reservation Database Table
                cmdSearch1.Connection = cnnOLEDB
                Dim dr1 As OleDbDataReader = cmdSearch1.ExecuteReader()
                If dr1.Read() = True Then ' If the record can be queried, 
                    txtChaletNumber.Text = dr1(2).ToString 'Data Row 2 data will show in Chalet Number TextBox
                    txtChaletType.Text = dr1(3).ToString 'Data Row 3 data will show in Chalet Type TextBox
                    cboBedCounts.Text = dr1(1).ToString 'Data Row 1 data will show in Bed Counts ComboBox
                    dtpCheckIn.Value = dr1(4).ToString 'Data Row 4 data will show in Check-In DateTimePicker
                    dtpCheckOut.Value = dr1(5).ToString 'Data Row 5 data will show in Check-Out DateTimePicker
                    txtDeposit.Text = dr1(9).ToString 'Data Row 9 data will show in Deposit TextBox
                    txtTotal_Amount.Text = dr1(10).ToString 'Data Row 10 data will show in Total Amount TextBox
                    txtOwing.Text = dr1(11).ToString 'Data Row 11 data will show in Owing TextBox

                    If txtOwing.Text >= "0" Then 'If Owing is more than 0 (Possitive Value), which mean Guest have no owing. Paid CheckBox Checked
                        chkPaid.Checked = True
                    End If

                    If dr1("Check_In").ToString = "Check" Then 'If DataRead 'Check_In' Row from Reservation Database Table is Check, Check-In CheckBox and RadioButton is checked
                        chkCheckIn.Checked = True
                        radCheckIn.Checked = True
                    End If
                    If dr1("Check_Out").ToString = "Checked" Then 'If DataRead 'Check_Out' Row from Reservation Database Table is Check, Check-Out CheckBox and RadioButton is checked
                        chkCheckOut.Checked = True
                        radCheckOut.Checked = True
                    End If
                    dr1.Close()
                End If
            End If
        Catch
            MessageBox.Show("Database Error", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'Delect All Data Using Guest IC / Passport from Reservation Database Table
            cmdDelete.CommandText = "Delete * from tbl_reservation where GuestIC_PassportNo = '" & txtIC_Passport.Text & "';"
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.Connection = cnnOLEDB
            cmdDelete.ExecuteNonQuery()

            'Delect All Data Using Guest IC / Passport from Guest Details Database Table
            cmdDelete1.CommandText = "Delete * from tbl_guestdetails where GuestIC_PassportNo = '" & txtIC_Passport.Text & "';"
            cmdDelete1.CommandType = CommandType.Text
            cmdDelete1.Connection = cnnOLEDB
            cmdDelete1.ExecuteNonQuery()
            MessageBox.Show("Deletion Successful", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtContactNumber.Clear()
            txtEmailAddress.Clear()
            txtGuestName.Clear()
            txtIC_Passport.Clear()
            cboNumberOfPeoples.Text = ""
        Catch
            MessageBox.Show("Delete Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtGuestName.Text = "" Then 'If Guest Name TextBox is Blank, an Error will appear to remind users to insert COMPLETE DETAILS
                MessageBox.Show("Please INSERT Guest Name", "GUEST NAME", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtIC_Passport.Text = "" Then 'If IC / Passport Number TextBox is Blank, an Error will appear to remind users to insert COMPLETE DETAILS
                MessageBox.Show("Please INSERT Full IC / PASSPORT Details", "IC / PASSPORT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtEmailAddress.Text = "" Then 'If Email Address TextBox is Blank, an Error will appear to remind users to insert COMPLETE DETAILS
                MessageBox.Show("Please INSERT Emaill Address", "EMAIL ADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtContactNumber.Text = "" Then 'If Contact Number TextBox is Blank, an Error will appear to remind users to insert COMPLETE DETAILS
                MessageBox.Show("Please Insert Contact Number", "CONTACT NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cboNumberOfPeoples.Text = "" Then 'If Number of Peoples ComboBox is Blank, an Error will appear to remind users to Fill COMPLETE DETAILS
                MessageBox.Show("Please Insert Number of Peoples", "NUMBER OF PEOPLES", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not IsNumeric(txtContactNumber.Text) Then 'If Contact Number is not Numeric, an Error will appear to remind users to insert NUMERIC ONLY
                MessageBox.Show("Only NUMERIC Accepted in Contact Number", "NUMERIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Update Guest Name,Contact Number, Email Address, Number of Peoples using IC / Passport from Guest Details Database Table
                cmdUpdate.CommandText = "Update tbl_guestdetails Set Guest_Name = '" & txtGuestName.Text & "', Contact_Number = " & txtContactNumber.Text & ", Email_Address = '" & txtEmailAddress.Text & "', Number_of_Peoples = " & cboNumberOfPeoples.Text & "  Where GuestIC_PassportNo= '" & txtIC_Passport.Text & "';"
                cmdUpdate.CommandType = CommandType.Text
                cmdUpdate.Connection = cnnOLEDB
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Updation Guest Details Successfull")
            End If
        Catch
            MessageBox.Show("This Guest Doesn't In The Database, Please Proceed To Register for Registration.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        Form_MainPage.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        Try
            'Update Bed Count ComboBox using IC / Passport Numbers from Reservation Database Table.
            cmdUpdate1.CommandText = "Update tbl_reservation Set Bed_Counts = " & cboBedCounts.Text & " Where GuestIC_PassportNo= '" & txtIC_Passport.Text & "';"
            cmdUpdate1.CommandType = CommandType.Text
            cmdUpdate1.Connection = cnnOLEDB
            cmdUpdate1.ExecuteNonQuery()
            MessageBox.Show("Updation Chalet Details Successfull", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("Update Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        Dim d1 As DateTime = dtpCheckIn.Value 'Declare Check-In date as d1 variable.
        Dim d2 As DateTime = dtpCheckOut.Value 'Declare Check-Out date as d2 variable.
        Dim d3 As TimeSpan = d2.Subtract(d1) 'Check-Out date minus Check-In date to find the duration of days
        Dim Duration As Integer = d3.TotalDays 'Declare duration as integer to display d3 total days
        txtDuration.Text = Duration
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Try
            If txtPaid.Text = "" Then 'If Paid TextBox is Blank, an error will appear to remind staff to FILL the Details
                MessageBox.Show("Please Insert The Value for Paid", "Value Of Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not IsNumeric(txtPaid.Text) Then 'If Paid TextBox is NOT NUMERIC, an error will appear to remind staff to fill NUMERIC only
                MessageBox.Show("Only NUMERIC accepted in Amount of Paid", "NUMERIC ONLY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Update Deposit, Owing and Total Amunt using IC / Passport Number from Reservation Database Table
                cmdUpdate3.CommandText = "Update tbl_reservation Set Deposit = " & txtDeposit.Text & ", Total_Amount = " & txtTotal_Amount.Text & ", Owing = " & txtOwing.Text & " Where GuestIC_PassportNo= '" & txtIC_Passport.Text & "';"
                cmdUpdate3.CommandType = CommandType.Text
                cmdUpdate3.Connection = cnnOLEDB
                cmdUpdate3.ExecuteNonQuery()
                MessageBox.Show("Update Payment Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
            MessageBox.Show("Update Payment Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If radCheckIn.Checked = True Then ' If the record can be queried,
                'Update 'Check_In' row from Reservation Database from blank to 'Check' using IC / Passport to search data
                cmdUpdate4.CommandText = "Update tbl_reservation Set Check_In = '" & lblCheck.Text & "' Where GuestIC_PassportNo= '" & txtIC_Passport.Text & "';"
                cmdUpdate4.CommandType = CommandType.Text
                cmdUpdate4.Connection = cnnOLEDB
                cmdUpdate4.ExecuteNonQuery()
                MessageBox.Show("Check In Successfully", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If radCheckOut.Checked = True Then 'If the record can be queried,
                'Update 'Check_Out' row from Reservation Database from blank to 'Checked' using IC / Passport to search data
                cmdUpdate5.CommandText = "Update tbl_reservation Set Check_Out = '" & lblChecked.Text & "' Where GuestIC_PassportNo= '" & txtIC_Passport.Text & "';"
                cmdUpdate5.CommandType = CommandType.Text
                cmdUpdate5.Connection = cnnOLEDB
                cmdUpdate5.ExecuteNonQuery()

                'If Check Out successfully, Chalet Database Table's Chalet Status will update from Occupied to Available based on Chalet Number to search data
                cmdUpdate6.CommandText = "Update tbl_chalet Set Chalet_Status = '" & lblAvailable.Text & "' Where Chalet_Number= '" & txtChaletNumber.Text & "';"
                cmdUpdate6.CommandType = CommandType.Text
                cmdUpdate6.Connection = cnnOLEDB
                cmdUpdate6.ExecuteNonQuery()
                MessageBox.Show("Check Out Successfully", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
            MessageBox.Show("Update Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtPaid.TextChanged
        btnCalculate.Enabled = True
    End Sub

    Private Sub btnPrint_Receipt_Click(sender As Object, e As EventArgs) Handles btnPrint_Receipt.Click
        Form_Receipt.Show()
    End Sub

    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            If txtPaid.Text = "" Then 'If Paid TextBox is Blank, an error will appear to remind staff to INSERT the Value of Paid
                MessageBox.Show("Please Insert The Value of Guest Paid", "Value of GUEST PAID", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtOwing.Text = txtPaid.Text + CInt(txtOwing.Text)

                If txtOwing.Text >= "0" Then 'If Owing is more than euqal to 0 (Possitive Value), which mean Guest have no owing. Paid CheckBox Checked
                    chkPaid.Checked = True
                    btnPrint_Receipt.Enabled = True
                    btnPayment.Enabled = True
                ElseIf txtOwing.Text < "0" Then 'If Owing is less than 0 (Negative Value), which mean Guest have owing. Paid CheckBox Not Checked
                    chkPaid.Checked = False
                End If
            End If
        Catch
            MessageBox.Show("Payment Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
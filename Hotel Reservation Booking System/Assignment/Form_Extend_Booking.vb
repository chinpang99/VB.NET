Imports System.Data.OleDb
Public Class Form_Extend_Booking
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdSearch As New OleDbCommand
    Dim cmdSearch1 As New OleDbCommand
    Dim cmdSearch2 As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdUpdate1 As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtIC_Passport.Text = "" Then 'If IC / Passport field is empty, an error will appear
                MessageBox.Show("Please Insert Number of IC / Passport", "Number of IC / Passport", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim s As String
                s = CStr(txtIC_Passport.Text)
                'Select ALL data using IC / Passport number from Reservation Database Table 
                cmdSearch.CommandText = "SELECT * From tbl_reservation Where GuestIC_PassportNo = '" & s & "'"
                cmdSearch.Connection = cnnOLEDB
                Dim dr As OleDbDataReader = cmdSearch.ExecuteReader()
                If dr.Read() = True Then 'If the record can be queried, Database Row 2,3,4,5 will display on each Label or DateTimePicker 
                    lblChaletNumber.Text = dr(2).ToString
                    lblChaletType.Text = dr(3).ToString
                    dtpCheckIn.Value = dr(4).ToString
                    dtpCheckOut.Value = dr(5).ToString
                End If
                dr.Close()

                dtpCheckOut.Enabled = True
                btnCheck.Enabled = True
                btnUpdate.Enabled = True
                txtTotalAmount.Enabled = True
            End If
        Catch
            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form_Extend_Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'open connection

        btnUpdate.Enabled = False
        txtTotalAmount.Enabled = False
        dtpCheckOut.Enabled = False
        btnCheck.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'Update Check-Out Date, Deposit, Owing and Total Amount into Reservation Database Table.

            cmdUpdate1.CommandText = "Update tbl_reservation Set Check_Out_Date = '" & dtpCheckOut.Value & "', Total_Amount = " & txtTotalAmount.Text & ", Owing = " & txtOwing.Text & " Where GuestIC_PassportNo = '" & txtIC_Passport.Text & "';"
            cmdUpdate1.CommandType = CommandType.Text
            cmdUpdate1.Connection = cnnOLEDB
            cmdUpdate1.ExecuteNonQuery()
            MessageBox.Show("Updation Successful")
        Catch
            MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        Form_MainPage.Show()
        Me.Close()
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        Try
            Dim d1 As DateTime = dtpCheckIn.Value 'Declare Check-In date as d1 variable.
            Dim d2 As DateTime = dtpCheckOut.Value 'Declare Check-Out date as d2 variable.
            Dim d3 As TimeSpan = d2.Subtract(d1) 'Check-Out date minus Check-In date to find the duration of days
            Dim Duration As Integer = d3.TotalDays 'Declare duration as integer to display d3 total days
            txtDuration.Text = Duration

            Dim total As Integer
            Dim owing As Integer
            If lblChaletType.Text = "Standard" Then 'If the label in Chalet Type show 'Standard', the total amount is duration * 150
                total = (txtDuration.Text * 150) - txtDeposit.Text 'New Total Amount MINUS Deposit paid by customer to find real actual total amount
                owing = txtDeposit.Text - total 'New total owing amount from guest
            ElseIf lblChaletType.Text = "Supreme" Then 'If the label in Chalet Type show 'Standard', the total amount is duration * 250
                total = (txtDuration.Text * 250) - txtDeposit.Text 'New Total Amount MINUS Deposit paid by customer to find real actual total amount
                owing = txtDeposit.Text - total 'New total owing amount from guest
            End If

            txtTotalAmount.Text = total
            txtOwing.Text = owing
        Catch
            MessageBox.Show("Update New Payment Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        Dim s As String 'Declare s as String 
        s = CStr(txtIC_Passport.Text)
        'Select ALL data using IC / Passport to Search Data in Reservation Database Table
        cmdSearch1.CommandText = "SELECT * From tbl_reservation Where GuestIC_PassportNo = '" & s & "'"
        cmdSearch1.Connection = cnnOLEDB
        Dim dr1 As OleDbDataReader = cmdSearch1.ExecuteReader()
        If dr1.Read() = True Then 'If the record can be queried, Database Row 9 and 11 will show in Deposit and Owing TextBox 
            txtDeposit.Text = dr1(9).ToString
            txtOwing.Text = dr1(11).ToString
        End If
        dr1.Close()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        cmdSearch2.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & lblChaletNumber.Text & "';"
        cmdSearch2.Connection = cnnOLEDB
        Dim dr As OleDbDataReader = cmdSearch2.ExecuteReader
        'If the record can be queried, then Check-Out Date will find between all dates in Check_In and Check Out Date in Specific Room base on Chalet Number Label from Database
        While dr.Read = True

            'If Customer Check-Out Date is In-Between all Customer Check-In and Out Date at the same chalet room. A MessageBox of 'Occupied' will show for not allow guest to extend booking
            If dtpCheckOut.Value > dr(1) And dtpCheckOut.Value < dr(2) Then
                MessageBox.Show("Occupied")
                Exit While 'Stop data reading (which is go to End While)
            Else
                MessageBox.Show("Available")
                'Stop data reading (which is go to End While)
            End If
            End While
        dr.Close()
    End Sub
End Class
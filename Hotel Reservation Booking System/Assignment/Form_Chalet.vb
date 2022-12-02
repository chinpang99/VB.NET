Imports System.Data.OleDb
Public Class Form_Chalet
    Dim cnnOLEDB As New OleDbConnection
    Dim dr As OleDbDataReader
    Dim i As String
    Dim cmdUpdate As New OleDbCommand
    Dim cmdInsert As New OleDbCommand
    Dim cmdInsert1 As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"
    Private Sub Form_Chalet_Standard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'Open connection

        MessageBox.Show("Please Fill Booking Details Section First") 'Inform to Sparrow Resort's Staff to Fill Booking Details first for enable Chalet Room button.
        btnChaletRoom.Enabled = False
        dtpCheckIn.MinDate = Now
        dtpCheckOut.MinDate = Now
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtChaletNumber.Text = "" Then 'If Chalet Number is empty, an error will appear
            MessageBox.Show("Please INSERT Chalet Number", "Chalet Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtChaletType.Text = "" Then 'If Chalet Type is empty, an error will appear
            MessageBox.Show("Your Chalet Type doesn't display", "Chalet Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cboChaletStatus.Text = "" Then 'If Chalet Status is empty, an error will appear
            MessageBox.Show("Your Chalet Status doesn't display", "Chalet Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cboBedCounts.Text = "" Then 'If Bed Counts is empty, an error will appear
            MessageBox.Show("Please INSERT the VALUE of Bed Counts", "Bed Counts", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDuration.Text = "" Then 'If Duration is empty, an error will appear
            MessageBox.Show("Please Insert Check Out Date", "Check-Out-Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDuration.Text <= "0" Then 'If Duration less than 0 , an error will appear
            MessageBox.Show("Please Insert Check Out Date", "Check-Out-Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmdInsert.CommandText = "Insert Into tbl_reservation ([Chalet_Number], [Chalet_Type], [Bed_Counts], [Check_In_Date], [Check_Out_Date], [GuestIC_PassportNo]) Values ('" & txtChaletNumber.Text & "','" & txtChaletType.Text & "'," & cboBedCounts.Text & ", '" & dtpCheckIn.Value & "', '" & dtpCheckOut.Value & "', '" & txtIC.Text & "');" 'Insert information into Reservation Database Table
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = cnnOLEDB
            cmdInsert.ExecuteNonQuery()

            cmdInsert1.CommandText = "Insert Into tbl_further_booking ([Chalet_Number], [Check_In], [Check_Out]) Values ('" & txtChaletNumber.Text & "', '" & dtpCheckIn.Value & "', '" & dtpCheckOut.Value & "');" 'Insert information into Further Booking Database table for checking availability room when next guest register.
            cmdInsert1.CommandType = CommandType.Text
            cmdInsert1.Connection = cnnOLEDB
            cmdInsert1.ExecuteNonQuery()

            cmdUpdate.CommandText = "Update tbl_chalet Set Chalet_Status = '" & cboChaletStatus.Text & "' Where Chalet_Number = '" & txtChaletNumber.Text & "';" 'Update chalet status from 'Available' to 'Occupied'
            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = cnnOLEDB
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Insertation Chalet Sucessful", "Please Click Next To Proceed To Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_Payment.Show()
            Me.Hide()
            Form_Payment.txtChalet_Number.Text = txtChaletNumber.Text 'All information will link to payment form for calculating deposit and total amount and also printing receipt.
            Form_Payment.txtChalet_Type.Text = txtChaletType.Text
            Form_Payment.txtIC.Text = Form_Register.txtIC_Passport.Text
            Form_Payment.txtGuest_Name.Text = Form_Register.txtGuestName.Text
            Form_Payment.dtpCheck_In_Date.Value = dtpCheckIn.Value
            Form_Payment.dtpCheck_Out_Date.Value = dtpCheckOut.Value
            Form_Payment.txtDuration.Text = txtDuration.Text
        End If
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        Dim d1 As DateTime = dtpCheckIn.Value 'Declare Check-In date as d1 variable.
        Dim d2 As DateTime = dtpCheckOut.Value 'Declare Check-Out date as d2 variable.
        Dim d3 As TimeSpan = d2.Subtract(d1) 'Check-Out date minus Check-In date to find the duration of days
        Dim Duration As Integer = d3.TotalDays 'Declare duration as integer to display d3 total days
        txtDuration.Text = Duration

        btnChaletRoom.Enabled = True
    End Sub

    Private Sub btnChaletRoom_Click(sender As Object, e As EventArgs) Handles btnChaletRoom.Click
        Form_Chalet_Room.Show()
        Form_Chalet_Room.btnSubmit.Show()
        Form_Chalet_Room.dtpCheckIn.Enabled = False
        Form_Chalet_Room.dtpCheckOut.Enabled = False
    End Sub
End Class
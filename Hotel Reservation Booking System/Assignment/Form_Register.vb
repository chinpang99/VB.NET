Imports System.Data.OleDb
Public Class Form_Register
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdInsert As New OleDbCommand
    Dim cmdGenerate As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"

    Private Sub Form_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'open connection

        cboNumberOfPeoples.Text = "1" 'Default Number of Number of Peoples is 1'
        txtIC_Passport.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtGuestName.Text = "" Then 'If Guest Name TextBox is Blank, an Error will appear to remind users to FILL DETAILS
                MessageBox.Show("Please INSERT your FULLNAME details", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txtIC_Passport.Text = "" Then 'If IC TextBox is Blank, an Error will appear to remind users to FILL DETAILS
                MessageBox.Show("Please INSERT your FULL IC number or Passport number details", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txtEmail.Text = "" Then 'If Email TextBox is Blank, an Error will appear to remind users to FILL DETAILS
                MessageBox.Show("Please INSERT your FULL EMAIL details", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txtContact.Text = "" Then 'If Contact Number TextBox is Blank, an Error will appear to remind users to FILL DETAILS
                MessageBox.Show("Please INSERT your FULL CONTACT details", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not IsNumeric(txtContact.Text) Then 'If Contact TextBox is Not Numeric, an Error will appear to remind users to fill NUMERIC ONLY
                MessageBox.Show("Please INSERT ONLY NUMERIC for Contact Number", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf IsNumeric(txtGuestName.Text) Then 'If Guest Name TextBox is Numeric, an Error will appear to remind users to fill NOT NUMERIC
                MessageBox.Show("Please Insert Characters ONLY for Name", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'Insert Guest IC / Passport, Guest FullName, Contact Number, Email Address, Number of Peoples into Guest Details Database Table
                cmdInsert.CommandText = "Insert Into tbl_guestdetails ([GuestIC_PassportNo], [Guest_Name], [Contact_Number], [Email_Address], [Number_of_Peoples]) Values ('" & txtIC_Passport.Text & "','" & txtGuestName.Text & "'," & txtContact.Text & ", '" & txtEmail.Text & "', '" & cboNumberOfPeoples.Text & "');"
                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = cnnOLEDB
                cmdInsert.ExecuteNonQuery()
                MessageBox.Show("Guest registraion is successfully.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form_Payment.txtGuest_Name.Text = txtGuestName.Text 'Guest Name Text in Register Form will link to Payment Form's Guest Name TextBox
                Form_Payment.txtIC.Text = txtIC_Passport.Text 'IC Text in Register Form will link to Payment Form's IC TextBox
                Form_Chalet.txtGuestName.Text = txtGuestName.Text 'Guest Name Text in Register Form will link to Chalet Form's Guest Name TextBox
                Form_Chalet.txtIC.Text = txtIC_Passport.Text 'ICText in Register Form will link to Chalet Form's IC TextBox

                Form_Chalet.Show()
                Me.Hide()
            End If
        Catch
            MessageBox.Show("Please check your Database.", "Duplication Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtContact.Clear()
        txtEmail.Clear()
        txtGuestName.Clear()
        txtIC_Passport.Clear()
        cboNumberOfPeoples.Text = "1"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        Form_MainPage.Show()
        Me.Close()
    End Sub
End Class
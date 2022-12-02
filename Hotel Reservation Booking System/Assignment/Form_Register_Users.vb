Imports System.Data.OleDb
Public Class Form_Register_Users
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdInsert As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Names() As String = txtFullname.Text.Split(" ") 'Declare Names as Array and String and Split text when my Fullname Text got Spaces
        Dim Initials As String = vbNullString '
        For Each Name As String In Names
            Initials += Name.Chars(0).ToString.ToUpper 'In every split word take the first alphabets which is Name.Chars(0) with uppercase
        Next

        txtUsername.Text = Initials
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If txtFullname.Text = "" Then 'If Fullname text is BLANK, an error will appear to remind staffs to FILL the DETAILS
                MessageBox.Show("Please INSERT STAFF FULL NAME", "FULLNAME", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text = "" Then 'If Password text is BLANK, an error will appear to remind staffs to FILL the DETAILS
                MessageBox.Show("Please INSERT STAFF PASSWORD", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtUsername.Text = "" Then 'If Username text is BLANK, an error will appear to remind staffs to FILL the DETAILS
                MessageBox.Show("Please click GENERATE Button for generate username", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtPassword.Text <> txtRe_Enter.Text Then 'If Password textbox not same as re_enter password textbox, an error will show to remind staff to fill the same password between two textbox
                MessageBox.Show("Password not match.... Please Try Again", "PASSWORD NOT MATCH", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Inser User Fullname, Generated Username, Password and Role into Users Database Table.
                cmdInsert.CommandText = "Insert Into tbl_users ([User_Fullname], [Login_Username], [Password], [Role]) Values ('" & txtFullname.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "', '" & cboStaff.Text & "');"
                cmdInsert.CommandType = CommandType.Text
                cmdInsert.Connection = cnnOLEDB
                cmdInsert.ExecuteNonQuery()
                MessageBox.Show("Insertion Successful")
                Form_MainPage.Show()
                Me.Close()
            End If
        Catch
            MessageBox.Show("This staffs is already registered in the system", "Duplication Staffs Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Form_Register_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'open connection
    End Sub

    Private Sub txtRe_Enter_TextChanged(sender As Object, e As EventArgs) Handles txtRe_Enter.TextChanged
        If txtPassword.Text = txtRe_Enter.Text Then 'If Password TextBox same as Re_Enter Password TextBox, then show 'Match' Label Text with Green Color
            lblMatch.Text = "Match"
            lblMatch.ForeColor = Color.Green
            lblMatch.Show()
        Else
            lblMatch.Text = "Not-Match" 'If Password TextBox NOT same as Re_Enter Password TextBox, then show 'Not-Match' Label Text with Red Color
            lblMatch.ForeColor = Color.Red
            lblMatch.Show()
        End If
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        Me.Close()
        Form_MainPage.Show()
    End Sub
End Class
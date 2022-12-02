Imports System.Data.OleDb
Public Class Form_Manager_Access
    Private Sub Form_Manager_Access_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True 'Password Text Will Show in Password Character while entering Manager Access Form

        txtPassword.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Try
            If txtPassword.Text = "" Then 'If Password TextBox in blank field, an error will appear
                MessageBox.Show("Please Insert Manager's Password", "Manager's Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb") 'connection
                Dim cmd As OleDbCommand = New OleDbCommand("Select * From tbl_users Where Password = '" & txtPassword.Text & "' And [Role];", con) 'Select ALL data using Password from Users Database Table.
                con.Open() 'open connection
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.Read() And dr(4) = "Manager" Then ' If the record can be queried, it means passing verification, but the information must same as DataRow 4 (Staff Role Rows) which show 'Manager' Role in Database Table, then only allow to open Report form.   
                    MessageBox.Show("Access to Report sucessfully", "Access Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Form_Report.Show()
                    Me.Close()
                    Form_MainPage.Hide()
                Else
                    MessageBox.Show("Report Is only for Manager, Staff don't have the permission to access", "Access Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch
            MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then 'If Show Password CheckBox is tick, System Password Characters in Password TextBox will disable.
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
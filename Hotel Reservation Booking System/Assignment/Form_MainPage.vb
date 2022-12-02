Public Class Form_MainPage
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister_Guest.Click
        Form_Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Form_Search_Guest_Details.Show()
        Form_Search_Guest_Details.radCheckIn.Visible = False 'In Search Guest Details Form, Check-In Radio button will INVISIBLE
        Form_Search_Guest_Details.radCheckOut.Visible = False 'In Search Guest Details Form, Check-Out Radio button will INVISIBLE
        Form_Search_Guest_Details.txtPaid.Enabled = False 'In Search Guest Details Form, TextBox Paid will DISABLE
        Form_Search_Guest_Details.btnCalculate.Enabled = False 'In Search Guest Details Form, Calculate Button will DISABLE
        Form_Search_Guest_Details.btnPayment.Enabled = False 'In Search Guest Details Form, Payment Button will DISABLE
        Form_Search_Guest_Details.chkPaid.Enabled = False 'In Search Guest Details Form, Paid CheckBox will DISABLE
        Form_Search_Guest_Details.btnCalculate.Visible = False 'In Search Guest Details Form, Calculate button will INVISIBLE
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form_Log_In.Show()
        Me.Hide()
        Form_Log_In.txtUsername.Clear() 'Username in Log In Form Will Clear
        Form_Log_In.txtPassword.Clear() 'Password in Log In Form Will Clear
    End Sub

    Private Sub btnExtend_Click(sender As Object, e As EventArgs) Handles btnExtend.Click
        Form_Extend_Booking.Show() 'Extend Booking Form Show
        Me.Hide()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn_Out.Click
        Form_Search_Guest_Details.Show()
        Form_Search_Guest_Details.cboBedCounts.Visible = False 'In Search Guest Details Form, Bed Counts ComboBox will DISABLE
        Form_Search_Guest_Details.btnUpdate1.Visible = False 'In Search Guest Details Form, Update Chalet Details Button will DISABLE
        Form_Search_Guest_Details.chkCheckIn.Visible = False 'In Search Guest Details Form, Check-In CheckBox will INVISIBLE
        Form_Search_Guest_Details.chkCheckOut.Visible = False 'In Search Guest Details Form, Check-Out CheckBox will INVISIBLE
        Form_Search_Guest_Details.txtContactNumber.Enabled = False 'In Search Guest Details Form, Contact Number Button will DISABLE
        Form_Search_Guest_Details.txtEmailAddress.Enabled = False 'In Search Guest Details Form, Email Address TextBox will DISABLE
        Form_Search_Guest_Details.txtGuestName.Enabled = False 'In Search Guest Details Form, Guest Name TextBox will DISABLE
        Form_Search_Guest_Details.btnUpdate.Visible = False 'In Search Guest Details Form, Update Guest Information and Reservation Button will INVISIBLE
        Form_Search_Guest_Details.btnDelete.Visible = False 'In Search Guest Details Form, Delete Button will INVISIBLE
        Form_Search_Guest_Details.btnSubmit.Visible = True 'In Search Guest Details Form, Check-In / Out Submit Button will VISIBLE
        Form_Search_Guest_Details.btnPrint_Receipt.Visible = True 'In Search Guest Details Form, Print Receipt Button will VISIBLE
        Form_Search_Guest_Details.btnPayment.Visible = True 'In Search Guest Details Form, Payment Button will VISIBLE
        Me.Hide()
    End Sub

    Private Sub btnChaletRoom_Click(sender As Object, e As EventArgs) Handles btnChaletRoom.Click
        Form_Chalet_Room.Show()
        Form_Chalet_Room.btnSP01.Enabled = False
        Form_Chalet_Room.btnSP02.Enabled = False
        Form_Chalet_Room.btnSP03.Enabled = False
        Form_Chalet_Room.btnSP04.Enabled = False
        Form_Chalet_Room.btnSP05.Enabled = False
        Form_Chalet_Room.btnSP06.Enabled = False
        Form_Chalet_Room.btnSP07.Enabled = False
        Form_Chalet_Room.btnSP08.Enabled = False
        Form_Chalet_Room.btnSP09.Enabled = False
        Form_Chalet_Room.btnSP10.Enabled = False
        Form_Chalet_Room.btnST01.Enabled = False
        Form_Chalet_Room.btnST02.Enabled = False
        Form_Chalet_Room.btnST03.Enabled = False
        Form_Chalet_Room.btnST04.Enabled = False
        Form_Chalet_Room.btnST05.Enabled = False
        Form_Chalet_Room.btnST06.Enabled = False
        Form_Chalet_Room.btnST07.Enabled = False
        Form_Chalet_Room.btnST08.Enabled = False
        Form_Chalet_Room.btnST09.Enabled = False
        Form_Chalet_Room.btnST10.Enabled = False
    End Sub

    Private Sub btnRegisterUser_Click(sender As Object, e As EventArgs) Handles btnRegister_User.Click
        Form_Manager_Access_Register_Users.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Form_Manager_Access.Show()
    End Sub
End Class
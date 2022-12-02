Public Class Form_Report
    Private Sub Form_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Assignment_DbDataSet.tbl_reservation' table. You can move, or remove it, as needed.
        Me.tbl_reservationTableAdapter.Fill(Me._Assignment_DbDataSet.tbl_reservation)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        Form_MainPage.Show()
        Me.Close()
    End Sub
End Class
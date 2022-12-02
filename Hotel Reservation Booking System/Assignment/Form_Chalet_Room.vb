Imports System.Data.OleDb
Public Class Form_Chalet_Room
    Dim cnnOLEDB As New OleDbConnection
    Dim i As String
    Dim cmdSearch As New OleDbCommand
    Dim con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb"

    Private Sub btnST01_Click(sender As Object, e As EventArgs) Handles btnST01.Click
        If btnST01.BackColor = Color.PaleGreen Then 'If ST01 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST01.BackColor = Color.Green 'If ST01 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except ST01 button, others button except will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST01.BackColor = Color.Red Then 'If button ST01 back color is Red, then this button CANNOT BE SELECTED
            btnST01.Enabled = False
        Else
            btnST01.BackColor = Color.PaleGreen 'If button ST01 is not selected, ST01 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST02_Click(sender As Object, e As EventArgs) Handles btnST02.Click
        If btnST02.BackColor = Color.PaleGreen Then 'If ST02 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST02.BackColor = Color.Green 'If ST02 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST02, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST02.BackColor = Color.Red Then 'If button ST02 back color is Red, then this button CANNOT BE SELECTED
            btnST02.Enabled = False
        Else
            btnST02.BackColor = Color.PaleGreen 'If button ST02 is not selected, ST02 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST03_Click(sender As Object, e As EventArgs) Handles btnST03.Click
        If btnST03.BackColor = Color.PaleGreen Then 'If ST03 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST03.BackColor = Color.Green 'If ST03 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST03, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST03.BackColor = Color.Red Then 'If button ST03 back color is Red, then this button CANNOT BE SELECTED
            btnST03.Enabled = False
        Else
            'If button ST03 is not selected, ST03 button will change to Pale Green color and all of the button are able to SELECTED
            btnST03.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST05_Click(sender As Object, e As EventArgs) Handles btnST05.Click
        If btnST05.BackColor = Color.PaleGreen Then 'If ST05 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST05.BackColor = Color.Green 'If ST05 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST05, others button will DISABLE because one guest only can register one room
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST05.BackColor = Color.Red Then 'If button ST05 back color is Red, then this button CANNOT BE SELECTED
            btnST05.Enabled = False
        Else
            'If button ST05 is not selected, ST05 button will change to Pale Green color and all of the button are able to SELECTED
            btnST05.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST04_Click(sender As Object, e As EventArgs) Handles btnST04.Click
        If btnST04.BackColor = Color.PaleGreen Then 'If ST04 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST04.BackColor = Color.Green 'If ST04 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST04, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST04.BackColor = Color.Red Then 'If button ST04 back color is Red, then this button CANNOT BE SELECTED
            btnST04.Enabled = False
        Else
            'If button ST04 is not selected, ST04 button will change to Pale Green color and all of the button are able to SELECTED
            btnST04.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST06.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST06_Click(sender As Object, e As EventArgs) Handles btnST06.Click
        If btnST06.BackColor = Color.PaleGreen Then 'If ST06 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST06.BackColor = Color.Green 'If ST06 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST06, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST06.BackColor = Color.Red Then 'If button ST06 back color is Red, then this button CANNOT BE SELECTED
            btnST06.Enabled = False
        Else
            'If button ST06 is not selected, ST06 button will change to Pale Green color and all of the button are able to SELECTED
            btnST06.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST07_Click(sender As Object, e As EventArgs) Handles btnST07.Click
        If btnST07.BackColor = Color.PaleGreen Then 'If button ST07 is not selected, ST07 button will change to Pale Green color and all of the button are able to SELECTED
            btnST07.BackColor = Color.Green 'If ST07 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST02, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST07.BackColor = Color.Red Then 'If button ST07 back color is Red, then this button CANNOT BE SELECTED
            btnST07.Enabled = False
        Else
            'If button ST07 is not selected, ST07 button will change to Pale Green color and all of the button are able to SELECTED
            btnST07.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST08_Click(sender As Object, e As EventArgs) Handles btnST08.Click
        If btnST08.BackColor = Color.PaleGreen Then 'If ST08 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST08.BackColor = Color.Green 'If ST08 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST08, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST08.BackColor = Color.Red Then 'If button ST08 back color is Red, then this button CANNOT BE SELECTED
            btnST08.Enabled = False
        Else
            'If button ST08 is not selected, ST08 button will change to Pale Green color and all of the button are able to SELECTED
            btnST08.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST09_Click(sender As Object, e As EventArgs) Handles btnST09.Click
        If btnST09.BackColor = Color.PaleGreen Then 'If ST09 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST09.BackColor = Color.Green 'If ST09 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST09, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST10.Enabled = False
        ElseIf btnST09.BackColor = Color.Red Then 'If button ST09 back color is Red, then this button CANNOT BE SELECTED
            btnST09.Enabled = False
        Else
            'If button ST09 is not selected, ST09 button will change to Pale Green color and all of the button are able to SELECTED
            btnST09.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnST10_Click(sender As Object, e As EventArgs) Handles btnST10.Click
        If btnST10.BackColor = Color.PaleGreen Then 'If ST10 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnST10.BackColor = Color.Green 'If ST10 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button ST10, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
        ElseIf btnST10.BackColor = Color.Red Then 'If button ST10 back color is Red, then this button CANNOT BE SELECTED
            btnST10.Enabled = False
        Else
            'If button ST10 is not selected, ST10 button will change to Pale Green color and all of the button are able to SELECTED
            btnST10.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP01_Click(sender As Object, e As EventArgs) Handles btnSP01.Click
        If btnSP01.BackColor = Color.PaleGreen Then 'If SP01 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP01.BackColor = Color.Green 'If SP01 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP01, others button will DISABLE because one guest only can register one room.
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP01.BackColor = Color.Red Then 'If button SP01 back color is Red, then this button CANNOT BE SELECTED
            btnSP01.Enabled = False
        Else
            'If button SP01 is not selected, SP01 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP01.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP02_Click(sender As Object, e As EventArgs) Handles btnSP02.Click
        If btnSP02.BackColor = Color.PaleGreen Then 'If SP02 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP02.BackColor = Color.Green 'If SP02 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP02, others button will DISABLE because one guest only can register one room
            btnSP01.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP02.BackColor = Color.Red Then 'If button SP02 back color is Red, then this button CANNOT BE SELECTED
            btnSP02.Enabled = False
        Else
            'If button SP02 is not selected, SP02 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP02.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP03_Click(sender As Object, e As EventArgs) Handles btnSP03.Click
        If btnSP03.BackColor = Color.PaleGreen Then 'If SP03 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP03.BackColor = Color.Green 'If SP03 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP03, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP03.BackColor = Color.Red Then 'If button SP03 back color is Red, then this button CANNOT BE SELECTED
            btnSP03.Enabled = False
        Else
            'If button SP03 is not selected, ST03 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP03.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP04_Click(sender As Object, e As EventArgs) Handles btnSP04.Click
        If btnSP04.BackColor = Color.PaleGreen Then 'If SP04 Button back color Is Pale Green Color Means This Room Is Available And allow to SELECT
            btnSP04.BackColor = Color.Green 'If SP04 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP04, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP04.BackColor = Color.Red Then 'If button SP04 back color is Red, then this button CANNOT BE SELECTED
            btnSP04.Enabled = False
        Else
            'If button SP04 is not selected, SP04 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP04.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP05_Click(sender As Object, e As EventArgs) Handles btnSP05.Click
        If btnSP05.BackColor = Color.PaleGreen Then 'If SP05 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP05.BackColor = Color.Green 'If SP05 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP05, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP05.BackColor = Color.Red Then 'If button SP05 back color is Red, then this button CANNOT BE SELECTED
            btnSP05.Enabled = False
        Else
            'If button SP05 is not selected, SP05 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP05.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP06_Click(sender As Object, e As EventArgs) Handles btnSP06.Click
        If btnSP06.BackColor = Color.PaleGreen Then 'If SP06 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP06.BackColor = Color.Green 'If SP06 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP06, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP06.BackColor = Color.Red Then 'If button SP06 back color is Red, then this button CANNOT BE SELECTED
            btnSP06.Enabled = False
        Else
            'If button SP06 is not selected, SP06 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP06.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP07_Click(sender As Object, e As EventArgs) Handles btnSP07.Click
        If btnSP07.BackColor = Color.PaleGreen Then 'If SP07 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP07.BackColor = Color.Green 'If SP07 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP07, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP07.BackColor = Color.Red Then 'If button SP07 back color is Red, then this button CANNOT BE SELECTED
            btnSP07.Enabled = False
        Else
            'If button SP07 is not selected, SP07 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP07.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP08_Click(sender As Object, e As EventArgs) Handles btnSP08.Click
        If btnSP08.BackColor = Color.PaleGreen Then 'If SP08 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP08.BackColor = Color.Green 'If SP08 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP08, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP09.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP08.BackColor = Color.Red Then 'If button SP08 back color is Red, then this button CANNOT BE SELECTED
            btnSP08.Enabled = False
        Else
            'If button SP08 is not selected, SP08 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP08.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP09_Click(sender As Object, e As EventArgs) Handles btnSP09.Click
        If btnSP09.BackColor = Color.PaleGreen Then 'If SP09 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP09.BackColor = Color.Green 'If SP09 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP09, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP10.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP09.BackColor = Color.Red Then 'If button SP09 back color is Red, then this button CANNOT BE SELECTED
            btnSP09.Enabled = False
        Else
            'If button SP09 is not selected, SP09 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP09.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub btnSP10_Click(sender As Object, e As EventArgs) Handles btnSP10.Click
        If btnSP10.BackColor = Color.PaleGreen Then 'If SP10 button back color is Pale Green Color Means This Room is Available and allow to SELECT
            btnSP10.BackColor = Color.Green 'If SP10 button is Selected, the Button Back Color will change from Pale Green to Green
            'Except button SP10, others button will DISABLE because one guest only can register one room.
            btnSP01.Enabled = False
            btnSP02.Enabled = False
            btnSP03.Enabled = False
            btnSP04.Enabled = False
            btnSP05.Enabled = False
            btnSP06.Enabled = False
            btnSP07.Enabled = False
            btnSP08.Enabled = False
            btnSP09.Enabled = False
            btnST01.Enabled = False
            btnST02.Enabled = False
            btnST03.Enabled = False
            btnST04.Enabled = False
            btnST05.Enabled = False
            btnST06.Enabled = False
            btnST07.Enabled = False
            btnST08.Enabled = False
            btnST09.Enabled = False
            btnST10.Enabled = False
        ElseIf btnSP09.BackColor = Color.Red Then 'If button SP10 back color is Red, then this button CANNOT BE SELECTED
            btnSP10.Enabled = False
        Else
            'If button SP10 is not selected, SP10 button will change to Pale Green color and all of the button are able to SELECTED
            btnSP10.BackColor = Color.PaleGreen
            btnSP01.Enabled = True
            btnSP02.Enabled = True
            btnSP03.Enabled = True
            btnSP04.Enabled = True
            btnSP05.Enabled = True
            btnSP06.Enabled = True
            btnSP07.Enabled = True
            btnSP08.Enabled = True
            btnSP09.Enabled = True
            btnSP10.Enabled = True
            btnST01.Enabled = True
            btnST02.Enabled = True
            btnST03.Enabled = True
            btnST04.Enabled = True
            btnST05.Enabled = True
            btnST06.Enabled = True
            btnST07.Enabled = True
            btnST08.Enabled = True
            btnST09.Enabled = True
            btnST10.Enabled = True
        End If
    End Sub

    Private Sub Form_Chalet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open() 'Open connection

        dtpCheckIn.Value = Form_Chalet.dtpCheckIn.Value 'Check-In Date link from Form Chalet Check-In Value
        dtpCheckOut.Value = Form_Chalet.dtpCheckOut.Value 'Check-Out Date link from Form Chalet Check-Out Value

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST01.Text & "';" 'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.Connection = cnnOLEDB
        Dim drST01 As OleDbDataReader = cmdSearch.ExecuteReader
        While drST01.Read = True 'If the record can be queried, then Check-In and Check-Out Date will find between all dates in Check_In and Check Out Date in ST01 from Database
            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value < drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value > drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value > drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value < drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else 'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST01.BackColor = Color.PaleGreen
            End If
        End While
        drST01.Close()

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST02.Text & "';" 'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.Connection = cnnOLEDB
        Dim drST02 As OleDbDataReader = cmdSearch.ExecuteReader
        While drST02.Read = True 'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST02 from Database

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value < drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value > drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value > drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value < drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST02.BackColor = Color.PaleGreen
            End If
        End While
        drST02.Close()

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST03.Text & "';" 'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.Connection = cnnOLEDB
        Dim drST03 As OleDbDataReader = cmdSearch.ExecuteReader
        While drST03.Read = True 'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST03 from Database

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value < drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value > drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value > drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value < drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else 'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST03.BackColor = Color.PaleGreen
            End If
        End While
        drST03.Close()

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST04.Text & "';" 'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.Connection = cnnOLEDB
        Dim drST04 As OleDbDataReader = cmdSearch.ExecuteReader
        While drST04.Read = True 'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST04 from Database

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value < drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value > drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value > drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value < drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else 'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available

                btnST04.BackColor = Color.PaleGreen
            End If
        End While
        drST04.Close()

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST05.Text & "';" 'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.Connection = cnnOLEDB
        Dim drST05 As OleDbDataReader = cmdSearch.ExecuteReader
        While drST05.Read = True 'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST05 from Database

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value < drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value > drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value > drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value < drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST05.BackColor = Color.PaleGreen
            End If
        End While
        drST05.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST06.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST06 As OleDbDataReader = cmdSearch.ExecuteReader

        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST06 from Database

        While drST06.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value < drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value > drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value > drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value < drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST06.BackColor = Color.PaleGreen
            End If
        End While
        drST06.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST07.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST07 As OleDbDataReader = cmdSearch.ExecuteReader
        While drST07.Read = True 'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST07 from Database

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value < drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value > drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value > drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value < drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST07.BackColor = Color.PaleGreen
            End If
        End While
        drST07.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST08.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST08 As OleDbDataReader = cmdSearch.ExecuteReader

        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST08 from Database

        While drST08.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value < drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value > drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value > drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value < drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST07.BackColor = Color.PaleGreen
            End If
        End While
        drST08.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST09.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST09 As OleDbDataReader = cmdSearch.ExecuteReader

        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST09 from Database

        While drST09.Read = True
            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value < drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value > drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value > drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value < drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST09.BackColor = Color.PaleGreen
            End If
        End While
        drST09.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST10.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST10 As OleDbDataReader = cmdSearch.ExecuteReader

        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST03 from Database

        While drST10.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value < drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value > drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value > drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value < drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else

                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnST10.BackColor = Color.PaleGreen
            End If
        End While
        drST10.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table

        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP01.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP01 As OleDbDataReader = cmdSearch.ExecuteReader

        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP01 from Database

        While drSP01.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value < drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value > drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value > drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value < drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.

                btnSP01.BackColor = Color.PaleGreen
            End If
        End While
        drSP01.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP02.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP02 As OleDbDataReader = cmdSearch.ExecuteReader

        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP02 from Database

        While drSP02.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            If dtpCheckIn.Value < drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value < drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value > drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value < drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value > drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.

            ElseIf dtpCheckIn.Value > drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value < drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP02.BackColor = Color.PaleGreen
            End If
        End While
        drSP02.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP03.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP03 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP03 from Database
        While drSP03.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value < drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value > drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value > drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value < drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP03.BackColor = Color.PaleGreen
            End If
        End While
        drSP03.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP04.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP04 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP04 from Database
        While drSP04.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value < drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value > drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value > drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value < drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP04.BackColor = Color.PaleGreen
            End If
        End While
        drSP04.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP05.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP05 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP05 from Database
        While drSP05.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value < drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value > drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value > drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value < drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP05.BackColor = Color.PaleGreen
            End If
        End While
        drSP05.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP06.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP06 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP06 from Database
        While drSP06.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value < drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value > drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value > drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value < drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP06.BackColor = Color.PaleGreen
            End If
        End While
        drSP06.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP07.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP07 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP07 from Database
        While drSP07.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value < drSP07(2) Then
                btnSP07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value > drSP07(2) Then
                btnSP07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value > drSP07(2) Then
                btnSP07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value < drSP07(2) Then
                btnSP07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP07.BackColor = Color.PaleGreen
            End If
        End While
        drSP07.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP08.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP08 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP08 from Database
        While drSP08.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value < drSP08(2) Then
                btnSP08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value > drSP08(2) Then
                btnSP08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value > drSP08(2) Then
                btnSP08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value < drSP08(2) Then
                btnSP08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP08.BackColor = Color.PaleGreen
            End If
        End While
        drSP08.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP09.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP09 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP09 from Database
        While drSP09.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value < drSP09(2) Then
                btnSP09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value > drSP09(2) Then
                btnSP09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value > drSP09(2) Then
                btnSP09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value < drSP09(2) Then
                btnSP09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP09.BackColor = Color.PaleGreen
            End If
        End While
        drSP09.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP10.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP10 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP10 from Database
        While drSP10.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value < drSP10(2) Then
                btnSP10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value > drSP10(2) Then
                btnSP10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value > drSP10(2) Then
                btnSP10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value < drSP10(2) Then
                btnSP10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP10.BackColor = Color.PaleGreen
            End If
        End While
        drSP10.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If btnST01.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST01"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST02.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST02"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST03.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST03"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST04.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST04"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST05.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST05"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
        End If

        If btnST06.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST06"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST07.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST07"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST08.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST08"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST09.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST09"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnST10.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Standard"
            Form_Chalet.txtChaletNumber.Text = "ST10"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP01.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP01"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP02.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP02"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP03.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP03"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP04.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP04"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP05.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP05"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP06.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP06"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP07.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP07"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP08.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP08"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP09.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP09"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If

        If btnSP10.BackColor = Color.Green Then
            Form_Chalet.txtChaletType.Text = "Supreme"
            Form_Chalet.txtChaletNumber.Text = "SP10"
            Form_Chalet.cboChaletStatus.Text = "Occupied"
            Me.Close()
        End If
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST01.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST01 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST01 from Database
        While drST01.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value < drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value > drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value > drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST01(1) And dtpCheckIn.Value < drST01(2) And dtpCheckOut.Value > drST01(1) And dtpCheckOut.Value < drST01(2) Then
                btnST01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST01.BackColor = Color.PaleGreen
            End If
        End While
        drST01.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST02.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST02 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST02 from Database
        While drST02.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value < drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value > drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value > drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST02(1) And dtpCheckIn.Value < drST02(2) And dtpCheckOut.Value > drST02(1) And dtpCheckOut.Value < drST02(2) Then
                btnST02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST02.BackColor = Color.PaleGreen
            End If
        End While
        drST02.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST03.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST03 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST03 from Database
        While drST03.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value < drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value > drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value > drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST03(1) And dtpCheckIn.Value < drST03(2) And dtpCheckOut.Value > drST03(1) And dtpCheckOut.Value < drST03(2) Then
                btnST03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST03.BackColor = Color.PaleGreen
            End If
        End While
        drST03.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST04.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST04 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST04 from Database
        While drST04.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value < drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value > drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value > drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST04(1) And dtpCheckIn.Value < drST04(2) And dtpCheckOut.Value > drST04(1) And dtpCheckOut.Value < drST04(2) Then
                btnST04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available
                btnST04.BackColor = Color.PaleGreen
            End If
        End While
        drST04.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST05.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST05 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST05 from Database
        While drST05.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value < drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value > drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value > drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST05(1) And dtpCheckIn.Value < drST05(2) And dtpCheckOut.Value > drST05(1) And dtpCheckOut.Value < drST05(2) Then
                btnST05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available
                btnST05.BackColor = Color.PaleGreen
            End If
        End While
        drST05.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST06.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST06 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST06 from Database
        While drST06.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value < drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value > drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value > drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST06(1) And dtpCheckIn.Value < drST06(2) And dtpCheckOut.Value > drST06(1) And dtpCheckOut.Value < drST06(2) Then
                btnST06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available
                btnST06.BackColor = Color.PaleGreen
            End If
        End While
        drST06.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST07.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST07 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST07 from Database
        While drST07.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value < drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value > drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value > drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST07(1) And dtpCheckIn.Value < drST07(2) And dtpCheckOut.Value > drST07(1) And dtpCheckOut.Value < drST07(2) Then
                btnST07.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST07.BackColor = Color.PaleGreen
            End If
        End While
        drST07.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST08.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST08 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST08 from Database
        While drST08.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value < drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value > drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value > drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST08(1) And dtpCheckIn.Value < drST08(2) And dtpCheckOut.Value > drST08(1) And dtpCheckOut.Value < drST08(2) Then
                btnST08.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST07.BackColor = Color.PaleGreen
            End If
        End While
        drST08.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST09.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST09 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST09 from Database
        While drST09.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value < drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value > drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value > drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST09(1) And dtpCheckIn.Value < drST09(2) And dtpCheckOut.Value > drST09(1) And dtpCheckOut.Value < drST09(2) Then
                btnST09.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST09.BackColor = Color.PaleGreen
            End If
        End While
        drST09.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnST10.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drST10 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a ST10 from Database
        While drST10.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value < drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value > drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value > drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drST10(1) And dtpCheckIn.Value < drST10(2) And dtpCheckOut.Value > drST10(1) And dtpCheckOut.Value < drST10(2) Then
                btnST10.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnST10.BackColor = Color.PaleGreen
            End If
        End While
        drST10.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP01.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP01 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP01 from Database
        While drSP01.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value < drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value > drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value > drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP01(1) And dtpCheckIn.Value < drSP01(2) And dtpCheckOut.Value > drSP01(1) And dtpCheckOut.Value < drSP01(2) Then
                btnSP01.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP01.BackColor = Color.PaleGreen
            End If
        End While
        drSP01.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP02.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP02 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP02 from Database
        While drSP02.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value < drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value > drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value > drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP02(1) And dtpCheckIn.Value < drSP02(2) And dtpCheckOut.Value > drSP02(1) And dtpCheckOut.Value < drSP02(2) Then
                btnSP02.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP02.BackColor = Color.PaleGreen
            End If
        End While
        drSP02.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP03.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP03 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP03 from Database
        While drSP03.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value < drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value > drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value > drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP03(1) And dtpCheckIn.Value < drSP03(2) And dtpCheckOut.Value > drSP03(1) And dtpCheckOut.Value < drSP03(2) Then
                btnSP03.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP03.BackColor = Color.PaleGreen
            End If
        End While
        drSP03.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP04.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP04 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP04 from Database
        While drSP04.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value < drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value > drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value > drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP04(1) And dtpCheckIn.Value < drSP04(2) And dtpCheckOut.Value > drSP04(1) And dtpCheckOut.Value < drSP04(2) Then
                btnSP04.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP04.BackColor = Color.PaleGreen
            End If
        End While
        drSP04.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP05.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP05 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP05 from Database
        While drSP05.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value < drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value > drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value > drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP05(1) And dtpCheckIn.Value < drSP05(2) And dtpCheckOut.Value > drSP05(1) And dtpCheckOut.Value < drSP05(2) Then
                btnSP05.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP05.BackColor = Color.PaleGreen
            End If
        End While
        drSP05.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP06.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP06 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP06 from Database
        While drSP06.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value < drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value > drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value > drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP06(1) And dtpCheckIn.Value < drSP06(2) And dtpCheckOut.Value > drSP06(1) And dtpCheckOut.Value < drSP06(2) Then
                btnSP06.BackColor = Color.Red
                Exit While 'Stop data reading (which is go to End While)
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP06.BackColor = Color.PaleGreen
            End If
        End While
        drSP06.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP07.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP07 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP07 from Database
        While drSP07.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value < drSP07(2) Then
                btnSP07.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value > drSP07(2) Then
                btnSP07.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value > drSP07(2) Then
                btnSP07.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP07(1) And dtpCheckIn.Value < drSP07(2) And dtpCheckOut.Value > drSP07(1) And dtpCheckOut.Value < drSP07(2) Then
                btnSP07.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP07.BackColor = Color.PaleGreen
            End If
        End While
        drSP07.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP08.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP08 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP08 from Database
        While drSP08.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value < drSP08(2) Then
                btnSP08.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value > drSP08(2) Then
                btnSP08.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value > drSP08(2) Then
                btnSP08.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP08(1) And dtpCheckIn.Value < drSP08(2) And dtpCheckOut.Value > drSP08(1) And dtpCheckOut.Value < drSP08(2) Then
                btnSP08.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP08.BackColor = Color.PaleGreen
            End If
        End While
        drSP08.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP09.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP09 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP09 from Database
        While drSP09.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value < drSP09(2) Then
                btnSP09.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value > drSP09(2) Then
                btnSP09.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value > drSP09(2) Then
                btnSP09.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP09(1) And dtpCheckIn.Value < drSP09(2) And dtpCheckOut.Value > drSP09(1) And dtpCheckOut.Value < drSP09(2) Then
                btnSP09.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP09.BackColor = Color.PaleGreen
            End If
        End While
        drSP09.Close()

        'Select All Data Using Chalet Number Search Data from Further Booking Database Table
        cmdSearch.CommandText = "Select * From tbl_further_booking Where Chalet_Number = '" & btnSP10.Text & "';"
        cmdSearch.Connection = cnnOLEDB
        Dim drSP10 As OleDbDataReader = cmdSearch.ExecuteReader
        'If the record can be queried, then Check-In and Check-Out Date will find between All dates in Check_In and Check Out Date in a SP10 from Database
        While drSP10.Read = True

            'If Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            If dtpCheckIn.Value < drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value < drSP10(2) Then
                btnSP10.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value > drSP10(2) Then
                btnSP10.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value < drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value > drSP10(2) Then
                btnSP10.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While

                'If Check-In and Check-Out Date in Date Time Picker is between dates of Check-In and Check-Out dates, The room will show occupied.
            ElseIf dtpCheckIn.Value > drSP10(1) And dtpCheckIn.Value < drSP10(2) And dtpCheckOut.Value > drSP10(1) And dtpCheckOut.Value < drSP10(2) Then
                btnSP10.BackColor = Color.Red 'Stop data reading (which is go to End While)
                Exit While
            Else
                'If Check-In and Check-Out Date in Date Time Picker is NOT between dates of Check-In and Check-Out dates, The room will show available.
                btnSP10.BackColor = Color.PaleGreen
            End If
        End While
        drSP10.Close()
    End Sub
End Class
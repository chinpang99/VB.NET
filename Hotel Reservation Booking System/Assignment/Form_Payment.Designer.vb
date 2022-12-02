<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.btnPrint_Receipt = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOwing = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtTotal_Amount = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.dtpCheck_Out_Date = New System.Windows.Forms.DateTimePicker()
        Me.txtChalet_Number = New System.Windows.Forms.TextBox()
        Me.txtChalet_Type = New System.Windows.Forms.TextBox()
        Me.txtGuest_Name = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpCheck_In_Date = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBarCode = New System.Windows.Forms.Button()
        Me.btnCreditCard = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.lblPayment_Type = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDuration
        '
        Me.txtDuration.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDuration.Enabled = False
        Me.txtDuration.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(159, 667)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(150, 31)
        Me.txtDuration.TabIndex = 51
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(33, 667)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(107, 24)
        Me.lblDuration.TabIndex = 50
        Me.lblDuration.Text = "Duration: "
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Enabled = False
        Me.lblPrice.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(276, 386)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(74, 24)
        Me.lblPrice.TabIndex = 49
        Me.lblPrice.Text = "(Price)"
        Me.lblPrice.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnPayment)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.txtPaid)
        Me.GroupBox1.Controls.Add(Me.btnPrint_Receipt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtOwing)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnTotal)
        Me.GroupBox1.Controls.Add(Me.txtTotal_Amount)
        Me.GroupBox1.Controls.Add(Me.txtDeposit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1045, 382)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 500)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAYMENT "
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.Lime
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Red
        Me.btnPayment.Location = New System.Drawing.Point(242, 255)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(200, 200)
        Me.btnPayment.TabIndex = 40
        Me.btnPayment.Text = "PAYMENT"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Lime
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Gold
        Me.btnCalculate.Location = New System.Drawing.Point(448, 136)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 100)
        Me.btnCalculate.TabIndex = 39
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(234, 141)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(201, 31)
        Me.txtPaid.TabIndex = 10
        '
        'btnPrint_Receipt
        '
        Me.btnPrint_Receipt.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPrint_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint_Receipt.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint_Receipt.ForeColor = System.Drawing.Color.Lime
        Me.btnPrint_Receipt.Location = New System.Drawing.Point(448, 255)
        Me.btnPrint_Receipt.Name = "btnPrint_Receipt"
        Me.btnPrint_Receipt.Size = New System.Drawing.Size(200, 200)
        Me.btnPrint_Receipt.TabIndex = 38
        Me.btnPrint_Receipt.Text = "PRINT RECEIPT"
        Me.btnPrint_Receipt.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Paid (RM):"
        '
        'txtOwing
        '
        Me.txtOwing.Cursor = System.Windows.Forms.Cursors.No
        Me.txtOwing.Enabled = False
        Me.txtOwing.Location = New System.Drawing.Point(235, 184)
        Me.txtOwing.Name = "txtOwing"
        Me.txtOwing.Size = New System.Drawing.Size(200, 31)
        Me.txtOwing.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total Owing(RM):"
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Lime
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTotal.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.Color.Gold
        Me.btnTotal.Location = New System.Drawing.Point(36, 255)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(200, 200)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "TOTAL"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'txtTotal_Amount
        '
        Me.txtTotal_Amount.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotal_Amount.Enabled = False
        Me.txtTotal_Amount.Location = New System.Drawing.Point(235, 90)
        Me.txtTotal_Amount.Name = "txtTotal_Amount"
        Me.txtTotal_Amount.Size = New System.Drawing.Size(200, 31)
        Me.txtTotal_Amount.TabIndex = 6
        '
        'txtDeposit
        '
        Me.txtDeposit.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDeposit.Enabled = False
        Me.txtDeposit.Location = New System.Drawing.Point(235, 41)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(200, 31)
        Me.txtDeposit.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Total Amount (RM):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Deposit (RM):"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelect.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Lime
        Me.btnSelect.Location = New System.Drawing.Point(36, 37)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(125, 125)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'dtpCheck_Out_Date
        '
        Me.dtpCheck_Out_Date.Enabled = False
        Me.dtpCheck_Out_Date.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheck_Out_Date.Location = New System.Drawing.Point(37, 598)
        Me.dtpCheck_Out_Date.Name = "dtpCheck_Out_Date"
        Me.dtpCheck_Out_Date.Size = New System.Drawing.Size(400, 31)
        Me.dtpCheck_Out_Date.TabIndex = 46
        '
        'txtChalet_Number
        '
        Me.txtChalet_Number.Cursor = System.Windows.Forms.Cursors.No
        Me.txtChalet_Number.Enabled = False
        Me.txtChalet_Number.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChalet_Number.Location = New System.Drawing.Point(37, 285)
        Me.txtChalet_Number.Name = "txtChalet_Number"
        Me.txtChalet_Number.Size = New System.Drawing.Size(200, 31)
        Me.txtChalet_Number.TabIndex = 44
        '
        'txtChalet_Type
        '
        Me.txtChalet_Type.Cursor = System.Windows.Forms.Cursors.No
        Me.txtChalet_Type.Enabled = False
        Me.txtChalet_Type.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChalet_Type.Location = New System.Drawing.Point(37, 383)
        Me.txtChalet_Type.Name = "txtChalet_Type"
        Me.txtChalet_Type.Size = New System.Drawing.Size(200, 31)
        Me.txtChalet_Type.TabIndex = 43
        '
        'txtGuest_Name
        '
        Me.txtGuest_Name.Cursor = System.Windows.Forms.Cursors.No
        Me.txtGuest_Name.Enabled = False
        Me.txtGuest_Name.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuest_Name.Location = New System.Drawing.Point(37, 182)
        Me.txtGuest_Name.Name = "txtGuest_Name"
        Me.txtGuest_Name.Size = New System.Drawing.Size(500, 31)
        Me.txtGuest_Name.TabIndex = 42
        '
        'txtIC
        '
        Me.txtIC.Enabled = False
        Me.txtIC.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC.Location = New System.Drawing.Point(37, 84)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(500, 31)
        Me.txtIC.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Check Out Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Check In Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 24)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Chalet Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Chalet Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Guest Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "IC/ Passport Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpCheck_In_Date)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDuration)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblDuration)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpCheck_Out_Date)
        Me.GroupBox2.Controls.Add(Me.txtIC)
        Me.GroupBox2.Controls.Add(Me.txtGuest_Name)
        Me.GroupBox2.Controls.Add(Me.txtChalet_Number)
        Me.GroupBox2.Controls.Add(Me.txtChalet_Type)
        Me.GroupBox2.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(395, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 800)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GUEST DETAILS"
        '
        'dtpCheck_In_Date
        '
        Me.dtpCheck_In_Date.Enabled = False
        Me.dtpCheck_In_Date.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheck_In_Date.Location = New System.Drawing.Point(37, 485)
        Me.dtpCheck_In_Date.Name = "dtpCheck_In_Date"
        Me.dtpCheck_In_Date.Size = New System.Drawing.Size(400, 31)
        Me.dtpCheck_In_Date.TabIndex = 52
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnBarCode)
        Me.GroupBox3.Controls.Add(Me.btnCreditCard)
        Me.GroupBox3.Controls.Add(Me.btnCash)
        Me.GroupBox3.Controls.Add(Me.lblPayment_Type)
        Me.GroupBox3.Controls.Add(Me.btnSelect)
        Me.GroupBox3.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1095, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 300)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PAYMENT TYPE"
        '
        'btnBarCode
        '
        Me.btnBarCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBarCode.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarCode.ForeColor = System.Drawing.Color.Lime
        Me.btnBarCode.Location = New System.Drawing.Point(342, 142)
        Me.btnBarCode.Name = "btnBarCode"
        Me.btnBarCode.Size = New System.Drawing.Size(125, 125)
        Me.btnBarCode.TabIndex = 8
        Me.btnBarCode.Text = "BARCODE SCANNER"
        Me.btnBarCode.UseVisualStyleBackColor = False
        Me.btnBarCode.Visible = False
        '
        'btnCreditCard
        '
        Me.btnCreditCard.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreditCard.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditCard.ForeColor = System.Drawing.Color.Lime
        Me.btnCreditCard.Location = New System.Drawing.Point(187, 143)
        Me.btnCreditCard.Name = "btnCreditCard"
        Me.btnCreditCard.Size = New System.Drawing.Size(125, 125)
        Me.btnCreditCard.TabIndex = 7
        Me.btnCreditCard.Text = "CREDIT CARD"
        Me.btnCreditCard.UseVisualStyleBackColor = False
        Me.btnCreditCard.Visible = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCash.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.Lime
        Me.btnCash.Location = New System.Drawing.Point(36, 142)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(125, 125)
        Me.btnCash.TabIndex = 6
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        Me.btnCash.Visible = False
        '
        'lblPayment_Type
        '
        Me.lblPayment_Type.AutoSize = True
        Me.lblPayment_Type.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment_Type.Location = New System.Drawing.Point(57, 51)
        Me.lblPayment_Type.Name = "lblPayment_Type"
        Me.lblPayment_Type.Size = New System.Drawing.Size(163, 24)
        Me.lblPayment_Type.TabIndex = 5
        Me.lblPayment_Type.Text = "(Payment Type)"
        Me.lblPayment_Type.Visible = False
        '
        'Form_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Functions_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "Form_Payment"
        Me.Text = "Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtOwing As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal_Amount As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpCheck_Out_Date As DateTimePicker
    Friend WithEvents txtChalet_Number As TextBox
    Friend WithEvents txtChalet_Type As TextBox
    Friend WithEvents txtGuest_Name As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint_Receipt As Button
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblPayment_Type As Label
    Friend WithEvents btnBarCode As Button
    Friend WithEvents btnCreditCard As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents dtpCheck_In_Date As DateTimePicker
End Class

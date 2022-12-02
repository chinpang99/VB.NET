<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Extend_Booking
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIC_Passport = New System.Windows.Forms.TextBox()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnMainPage = New System.Windows.Forms.Button()
        Me.lblChaletType = New System.Windows.Forms.Label()
        Me.lblChaletNumber = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtOwing = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(574, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest IC / Passport No: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Chalet Type: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(574, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 29)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Chalet Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(574, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Check In Date: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(574, 551)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 29)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Check Out Date: "
        '
        'txtIC_Passport
        '
        Me.txtIC_Passport.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC_Passport.Location = New System.Drawing.Point(579, 134)
        Me.txtIC_Passport.Name = "txtIC_Passport"
        Me.txtIC_Passport.Size = New System.Drawing.Size(600, 37)
        Me.txtIC_Passport.TabIndex = 1
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.Enabled = False
        Me.dtpCheckIn.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.Location = New System.Drawing.Point(579, 484)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(450, 37)
        Me.dtpCheckIn.TabIndex = 8
        Me.dtpCheckIn.Value = New Date(2018, 4, 7, 16, 54, 26, 0)
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Location = New System.Drawing.Point(579, 608)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(450, 37)
        Me.dtpCheckOut.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Gold
        Me.btnSearch.Location = New System.Drawing.Point(1256, 82)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 125)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Lime
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnUpdate.Location = New System.Drawing.Point(1181, 484)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(200, 200)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnMainPage
        '
        Me.btnMainPage.BackColor = System.Drawing.Color.Gold
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainPage.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainPage.ForeColor = System.Drawing.Color.Maroon
        Me.btnMainPage.Location = New System.Drawing.Point(1181, 690)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(200, 200)
        Me.btnMainPage.TabIndex = 20
        Me.btnMainPage.Text = "MAIN PAGE"
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'lblChaletType
        '
        Me.lblChaletType.AutoSize = True
        Me.lblChaletType.BackColor = System.Drawing.Color.Transparent
        Me.lblChaletType.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaletType.Location = New System.Drawing.Point(574, 378)
        Me.lblChaletType.Name = "lblChaletType"
        Me.lblChaletType.Size = New System.Drawing.Size(0, 29)
        Me.lblChaletType.TabIndex = 6
        '
        'lblChaletNumber
        '
        Me.lblChaletNumber.AutoSize = True
        Me.lblChaletNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblChaletNumber.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaletNumber.Location = New System.Drawing.Point(574, 264)
        Me.lblChaletNumber.Name = "lblChaletNumber"
        Me.lblChaletNumber.Size = New System.Drawing.Size(0, 29)
        Me.lblChaletNumber.TabIndex = 4
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(574, 696)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(260, 29)
        Me.lblTotalAmount.TabIndex = 11
        Me.lblTotalAmount.Text = "Total Amount (RM) :"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(579, 746)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(450, 37)
        Me.txtTotalAmount.TabIndex = 12
        '
        'txtDuration
        '
        Me.txtDuration.Enabled = False
        Me.txtDuration.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(425, 608)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(139, 37)
        Me.txtDuration.TabIndex = 15
        Me.txtDuration.Visible = False
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration.Enabled = False
        Me.lblDuration.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(432, 551)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(132, 29)
        Me.lblDuration.TabIndex = 14
        Me.lblDuration.Text = "Duration: "
        Me.lblDuration.Visible = False
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.BackColor = System.Drawing.Color.Transparent
        Me.lblDeposit.Enabled = False
        Me.lblDeposit.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeposit.Location = New System.Drawing.Point(432, 696)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(117, 29)
        Me.lblDeposit.TabIndex = 16
        Me.lblDeposit.Text = "Deposit: "
        Me.lblDeposit.Visible = False
        '
        'txtDeposit
        '
        Me.txtDeposit.Enabled = False
        Me.txtDeposit.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposit.Location = New System.Drawing.Point(425, 746)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(139, 37)
        Me.txtDeposit.TabIndex = 17
        Me.txtDeposit.Visible = False
        '
        'txtOwing
        '
        Me.txtOwing.Enabled = False
        Me.txtOwing.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwing.Location = New System.Drawing.Point(579, 801)
        Me.txtOwing.Name = "txtOwing"
        Me.txtOwing.Size = New System.Drawing.Size(139, 37)
        Me.txtOwing.TabIndex = 13
        Me.txtOwing.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(447, 804)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Owing: "
        Me.Label2.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheck.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.Gold
        Me.btnCheck.Location = New System.Drawing.Point(1035, 508)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(125, 125)
        Me.btnCheck.TabIndex = 22
        Me.btnCheck.Text = "CHECK"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'Form_Extend_Booking
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Functions_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtOwing)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblChaletNumber)
        Me.Controls.Add(Me.lblChaletType)
        Me.Controls.Add(Me.btnMainPage)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.txtIC_Passport)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Extend_Booking"
        Me.Text = "Extend Booking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIC_Passport As TextBox
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnMainPage As Button
    Friend WithEvents lblChaletType As Label
    Friend WithEvents lblChaletNumber As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtOwing As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCheck As Button
End Class

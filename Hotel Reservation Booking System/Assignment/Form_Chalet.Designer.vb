<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Chalet
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboChaletStatus = New System.Windows.Forms.ComboBox()
        Me.txtChaletType = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBedCounts = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChaletRoom = New System.Windows.Forms.Button()
        Me.txtChaletNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chalet Number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chalet Status: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chalet Type: "
        '
        'cboChaletStatus
        '
        Me.cboChaletStatus.Cursor = System.Windows.Forms.Cursors.No
        Me.cboChaletStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChaletStatus.Enabled = False
        Me.cboChaletStatus.FormattingEnabled = True
        Me.cboChaletStatus.Items.AddRange(New Object() {"Available", "Occupied"})
        Me.cboChaletStatus.Location = New System.Drawing.Point(41, 257)
        Me.cboChaletStatus.Name = "cboChaletStatus"
        Me.cboChaletStatus.Size = New System.Drawing.Size(200, 32)
        Me.cboChaletStatus.TabIndex = 4
        '
        'txtChaletType
        '
        Me.txtChaletType.Cursor = System.Windows.Forms.Cursors.No
        Me.txtChaletType.Location = New System.Drawing.Point(41, 171)
        Me.txtChaletType.Name = "txtChaletType"
        Me.txtChaletType.ReadOnly = True
        Me.txtChaletType.Size = New System.Drawing.Size(250, 31)
        Me.txtChaletType.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Lime
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Gold
        Me.btnNext.Location = New System.Drawing.Point(1425, 721)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 200)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "NEXT (PAYMENT)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Location = New System.Drawing.Point(29, 274)
        Me.dtpCheckOut.MinDate = New Date(2018, 4, 7, 0, 0, 0, 0)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(400, 31)
        Me.dtpCheckOut.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 24)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Check-Out-Date： "
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.Location = New System.Drawing.Point(29, 163)
        Me.dtpCheckIn.MinDate = New Date(2018, 4, 7, 0, 0, 0, 0)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(400, 31)
        Me.dtpCheckIn.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 24)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Check-In-Date： "
        '
        'cboBedCounts
        '
        Me.cboBedCounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBedCounts.FormattingEnabled = True
        Me.cboBedCounts.Items.AddRange(New Object() {"0", "1", "2"})
        Me.cboBedCounts.Location = New System.Drawing.Point(180, 54)
        Me.cboBedCounts.Name = "cboBedCounts"
        Me.cboBedCounts.Size = New System.Drawing.Size(150, 32)
        Me.cboBedCounts.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 24)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Bed Counts: "
        '
        'txtDuration
        '
        Me.txtDuration.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDuration.Location = New System.Drawing.Point(180, 344)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.ReadOnly = True
        Me.txtDuration.Size = New System.Drawing.Size(150, 31)
        Me.txtDuration.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Duration: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnChaletRoom)
        Me.GroupBox1.Controls.Add(Me.txtChaletNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboChaletStatus)
        Me.GroupBox1.Controls.Add(Me.txtChaletType)
        Me.GroupBox1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1025, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 400)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHALET"
        '
        'btnChaletRoom
        '
        Me.btnChaletRoom.BackColor = System.Drawing.Color.Tan
        Me.btnChaletRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChaletRoom.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChaletRoom.ForeColor = System.Drawing.Color.DimGray
        Me.btnChaletRoom.Location = New System.Drawing.Point(350, 90)
        Me.btnChaletRoom.Name = "btnChaletRoom"
        Me.btnChaletRoom.Size = New System.Drawing.Size(200, 200)
        Me.btnChaletRoom.TabIndex = 32
        Me.btnChaletRoom.Text = "CHALET ROOM"
        Me.btnChaletRoom.UseVisualStyleBackColor = False
        '
        'txtChaletNumber
        '
        Me.txtChaletNumber.Cursor = System.Windows.Forms.Cursors.No
        Me.txtChaletNumber.Location = New System.Drawing.Point(41, 87)
        Me.txtChaletNumber.Name = "txtChaletNumber"
        Me.txtChaletNumber.ReadOnly = True
        Me.txtChaletNumber.Size = New System.Drawing.Size(250, 31)
        Me.txtChaletNumber.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtIC)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtGuestName)
        Me.GroupBox2.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(450, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GUEST DETAILS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Guest IC/ Passport: "
        '
        'txtIC
        '
        Me.txtIC.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIC.Location = New System.Drawing.Point(34, 171)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.ReadOnly = True
        Me.txtIC.Size = New System.Drawing.Size(400, 31)
        Me.txtIC.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Guest Name: "
        '
        'txtGuestName
        '
        Me.txtGuestName.Cursor = System.Windows.Forms.Cursors.No
        Me.txtGuestName.Location = New System.Drawing.Point(34, 87)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(400, 31)
        Me.txtGuestName.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cboBedCounts)
        Me.GroupBox3.Controls.Add(Me.txtDuration)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpCheckIn)
        Me.GroupBox3.Controls.Add(Me.dtpCheckOut)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(450, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 521)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BOOKING DETAILS"
        '
        'Form_Chalet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Functions_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Chalet"
        Me.Text = "Chalet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboChaletStatus As ComboBox
    Friend WithEvents txtChaletType As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBedCounts As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtChaletNumber As TextBox
    Friend WithEvents btnChaletRoom As Button
End Class

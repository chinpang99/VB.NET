<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRegister_Guest = New System.Windows.Forms.Button()
        Me.btnCheckIn_Out = New System.Windows.Forms.Button()
        Me.btnChaletRoom = New System.Windows.Forms.Button()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRegister_User = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.DarkRed
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Gold
        Me.btnLogOut.Location = New System.Drawing.Point(1700, 750)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 200)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnRegister_Guest)
        Me.GroupBox1.Controls.Add(Me.btnCheckIn_Out)
        Me.GroupBox1.Controls.Add(Me.btnChaletRoom)
        Me.GroupBox1.Controls.Add(Me.btnExtend)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 750)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GUEST AND CHALET MANAGEMENT"
        '
        'btnRegister_Guest
        '
        Me.btnRegister_Guest.BackgroundImage = Global.Assignment.My.Resources.Resources.Registration
        Me.btnRegister_Guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister_Guest.Location = New System.Drawing.Point(98, 74)
        Me.btnRegister_Guest.Name = "btnRegister_Guest"
        Me.btnRegister_Guest.Size = New System.Drawing.Size(175, 175)
        Me.btnRegister_Guest.TabIndex = 0
        Me.btnRegister_Guest.UseVisualStyleBackColor = True
        '
        'btnCheckIn_Out
        '
        Me.btnCheckIn_Out.BackgroundImage = Global.Assignment.My.Resources.Resources.Check_In_Check_Out
        Me.btnCheckIn_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCheckIn_Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckIn_Out.Location = New System.Drawing.Point(98, 500)
        Me.btnCheckIn_Out.Name = "btnCheckIn_Out"
        Me.btnCheckIn_Out.Size = New System.Drawing.Size(175, 175)
        Me.btnCheckIn_Out.TabIndex = 7
        Me.btnCheckIn_Out.UseVisualStyleBackColor = True
        '
        'btnChaletRoom
        '
        Me.btnChaletRoom.BackgroundImage = Global.Assignment.My.Resources.Resources.Chalet_Status
        Me.btnChaletRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChaletRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChaletRoom.Location = New System.Drawing.Point(328, 293)
        Me.btnChaletRoom.Name = "btnChaletRoom"
        Me.btnChaletRoom.Size = New System.Drawing.Size(175, 175)
        Me.btnChaletRoom.TabIndex = 8
        Me.btnChaletRoom.UseVisualStyleBackColor = True
        '
        'btnExtend
        '
        Me.btnExtend.BackgroundImage = Global.Assignment.My.Resources.Resources.Extend_Booking
        Me.btnExtend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExtend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExtend.Location = New System.Drawing.Point(98, 293)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(175, 175)
        Me.btnExtend.TabIndex = 2
        Me.btnExtend.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Assignment.My.Resources.Resources.Search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(328, 74)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(175, 175)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnRegister_User)
        Me.GroupBox2.Controls.Add(Me.btnReport)
        Me.GroupBox2.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1500, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 550)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESORT ADMINISTRATIVE"
        '
        'btnRegister_User
        '
        Me.btnRegister_User.BackgroundImage = Global.Assignment.My.Resources.Resources.Staff
        Me.btnRegister_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister_User.Location = New System.Drawing.Point(105, 90)
        Me.btnRegister_User.Name = "btnRegister_User"
        Me.btnRegister_User.Size = New System.Drawing.Size(175, 175)
        Me.btnRegister_User.TabIndex = 9
        Me.btnRegister_User.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.BackgroundImage = Global.Assignment.My.Resources.Resources.Report
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.Location = New System.Drawing.Point(105, 306)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(175, 175)
        Me.btnReport.TabIndex = 6
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Form_MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Sparrow_bird_mainpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogOut)
        Me.Name = "Form_MainPage"
        Me.Text = "Main Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegister_Guest As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExtend As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnCheckIn_Out As Button
    Friend WithEvents btnChaletRoom As Button
    Friend WithEvents btnRegister_User As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

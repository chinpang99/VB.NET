<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Register_Users
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cboStaff = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtRe_Enter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.btnMainPage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(697, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fullname: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(697, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(697, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(697, 650)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Role: "
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(702, 229)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(500, 37)
        Me.txtFullname.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(702, 456)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(350, 37)
        Me.txtPassword.TabIndex = 6
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Items.AddRange(New Object() {"Staff", "Manager"})
        Me.cboStaff.Location = New System.Drawing.Point(852, 642)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(200, 37)
        Me.cboStaff.TabIndex = 7
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.OrangeRed
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Gold
        Me.btnRegister.Location = New System.Drawing.Point(960, 719)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(200, 200)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Maroon
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(1276, 257)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(125, 125)
        Me.btnGenerate.TabIndex = 9
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(702, 335)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(500, 37)
        Me.txtUsername.TabIndex = 5
        '
        'txtRe_Enter
        '
        Me.txtRe_Enter.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRe_Enter.Location = New System.Drawing.Point(702, 570)
        Me.txtRe_Enter.Name = "txtRe_Enter"
        Me.txtRe_Enter.Size = New System.Drawing.Size(350, 37)
        Me.txtRe_Enter.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(697, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Re-Enter Password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Stencil", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(660, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(741, 59)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Create Your Own Account "
        '
        'lblMatch
        '
        Me.lblMatch.AutoSize = True
        Me.lblMatch.BackColor = System.Drawing.Color.Transparent
        Me.lblMatch.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatch.Location = New System.Drawing.Point(1099, 573)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.Size = New System.Drawing.Size(103, 29)
        Me.lblMatch.TabIndex = 66
        Me.lblMatch.Text = "(Match)"
        Me.lblMatch.Visible = False
        '
        'btnMainPage
        '
        Me.btnMainPage.BackColor = System.Drawing.Color.Gold
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainPage.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainPage.ForeColor = System.Drawing.Color.Maroon
        Me.btnMainPage.Location = New System.Drawing.Point(1201, 719)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(200, 200)
        Me.btnMainPage.TabIndex = 67
        Me.btnMainPage.Text = "MAIN PAGE"
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'Form_Register_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Functions_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.btnMainPage)
        Me.Controls.Add(Me.lblMatch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRe_Enter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.cboStaff)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Register_Users"
        Me.Text = "Register Users"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboStaff As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtRe_Enter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMatch As Label
    Friend WithEvents btnMainPage As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Register
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtIC_Passport = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnMainPage = New System.Windows.Forms.Button()
        Me.cboNumberOfPeoples = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(499, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(474, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Guest IC number  or Passport Number: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(499, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Number: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(499, 453)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address: "
        '
        'txtGuestName
        '
        Me.txtGuestName.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(504, 273)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(600, 37)
        Me.txtGuestName.TabIndex = 5
        '
        'txtIC_Passport
        '
        Me.txtIC_Passport.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIC_Passport.Location = New System.Drawing.Point(504, 158)
        Me.txtIC_Passport.Name = "txtIC_Passport"
        Me.txtIC_Passport.Size = New System.Drawing.Size(500, 37)
        Me.txtIC_Passport.TabIndex = 4
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(504, 387)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(400, 37)
        Me.txtContact.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(504, 509)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(750, 37)
        Me.txtEmail.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(1365, 105)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 200)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Location = New System.Drawing.Point(1365, 336)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 200)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnMainPage
        '
        Me.btnMainPage.BackColor = System.Drawing.Color.Gold
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainPage.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainPage.ForeColor = System.Drawing.Color.Maroon
        Me.btnMainPage.Location = New System.Drawing.Point(504, 682)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(200, 200)
        Me.btnMainPage.TabIndex = 12
        Me.btnMainPage.Text = "MAIN PAGE"
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'cboNumberOfPeoples
        '
        Me.cboNumberOfPeoples.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNumberOfPeoples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumberOfPeoples.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNumberOfPeoples.FormattingEnabled = True
        Me.cboNumberOfPeoples.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboNumberOfPeoples.Location = New System.Drawing.Point(773, 579)
        Me.cboNumberOfPeoples.Name = "cboNumberOfPeoples"
        Me.cboNumberOfPeoples.Size = New System.Drawing.Size(200, 37)
        Me.cboNumberOfPeoples.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(499, 582)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 29)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Number of Peoples: "
        '
        'Form_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Functions_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.cboNumberOfPeoples)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnMainPage)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtIC_Passport)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.Name = "Form_Register"
        Me.Text = "Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtIC_Passport As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnMainPage As Button
    Friend WithEvents cboNumberOfPeoples As ComboBox
    Friend WithEvents Label5 As Label
End Class

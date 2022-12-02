<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_reservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Assignment_DbDataSet = New Assignment._Assignment_DbDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_reservationTableAdapter = New Assignment._Assignment_DbDataSetTableAdapters.tbl_reservationTableAdapter()
        Me.btnMainPage = New System.Windows.Forms.Button()
        CType(Me.tbl_reservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Assignment_DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_reservationBindingSource
        '
        Me.tbl_reservationBindingSource.DataMember = "tbl_reservation"
        Me.tbl_reservationBindingSource.DataSource = Me._Assignment_DbDataSet
        '
        '_Assignment_DbDataSet
        '
        Me._Assignment_DbDataSet.DataSetName = "_Assignment_DbDataSet"
        Me._Assignment_DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_reservationBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Assignment.Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(550, 200)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(886, 600)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbl_reservationTableAdapter
        '
        Me.tbl_reservationTableAdapter.ClearBeforeFill = True
        '
        'btnMainPage
        '
        Me.btnMainPage.BackColor = System.Drawing.Color.Gold
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainPage.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainPage.ForeColor = System.Drawing.Color.Maroon
        Me.btnMainPage.Location = New System.Drawing.Point(1480, 600)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(200, 200)
        Me.btnMainPage.TabIndex = 22
        Me.btnMainPage.Text = "MAIN PAGE"
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'Form_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.btnMainPage)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form_Report"
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tbl_reservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Assignment_DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_reservationBindingSource As BindingSource
    Friend WithEvents _Assignment_DbDataSet As _Assignment_DbDataSet
    Friend WithEvents tbl_reservationTableAdapter As _Assignment_DbDataSetTableAdapters.tbl_reservationTableAdapter
    Friend WithEvents btnMainPage As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportProfiles = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImportFillLists = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRefreshWhyNotFilled = New System.Windows.Forms.Button()
        Me.btnRefreshNeedsRefills = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PAISProfilesDataSet = New PAIS_Monthly_Check.PAISProfilesDataSet()
        Me.WhyNotFilledBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WhyNotFilledTableAdapter = New PAIS_Monthly_Check.PAISProfilesDataSetTableAdapters.WhyNotFilledTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NeedsRefillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NeedsRefillsTableAdapter = New PAIS_Monthly_Check.PAISProfilesDataSetTableAdapters.NeedsRefillsTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.btnRefreshNeedsRefills.SuspendLayout()
        CType(Me.PAISProfilesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhyNotFilledBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeedsRefillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(244, 158)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnImportProfiles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 223)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1"
        '
        'btnImportProfiles
        '
        Me.btnImportProfiles.Location = New System.Drawing.Point(24, 186)
        Me.btnImportProfiles.Name = "btnImportProfiles"
        Me.btnImportProfiles.Size = New System.Drawing.Size(244, 23)
        Me.btnImportProfiles.TabIndex = 1
        Me.btnImportProfiles.Text = "Import PAIS Profiles"
        Me.btnImportProfiles.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnImportFillLists)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(664, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 223)
        Me.Panel2.TabIndex = 2
        '
        'btnImportFillLists
        '
        Me.btnImportFillLists.Location = New System.Drawing.Point(24, 186)
        Me.btnImportFillLists.Name = "btnImportFillLists"
        Me.btnImportFillLists.Size = New System.Drawing.Size(244, 23)
        Me.btnImportFillLists.TabIndex = 1
        Me.btnImportFillLists.Text = "Import Fill Lists"
        Me.btnImportFillLists.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "3"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(24, 22)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(244, 158)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.TextBox4)
        Me.Panel5.Location = New System.Drawing.Point(340, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 223)
        Me.Panel5.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "2"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(24, 22)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(244, 187)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Controls.Add(Me.btnRefreshWhyNotFilled)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 241)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(948, 400)
        Me.Panel3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Click this button to refresh report.  Print report if needed."
        '
        'btnRefreshWhyNotFilled
        '
        Me.btnRefreshWhyNotFilled.Location = New System.Drawing.Point(304, 3)
        Me.btnRefreshWhyNotFilled.Name = "btnRefreshWhyNotFilled"
        Me.btnRefreshWhyNotFilled.Size = New System.Drawing.Size(626, 23)
        Me.btnRefreshWhyNotFilled.TabIndex = 2
        Me.btnRefreshWhyNotFilled.Text = "Refresh Report: Missing from Fill List"
        Me.btnRefreshWhyNotFilled.UseVisualStyleBackColor = True
        '
        'btnRefreshNeedsRefills
        '
        Me.btnRefreshNeedsRefills.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRefreshNeedsRefills.Controls.Add(Me.ReportViewer2)
        Me.btnRefreshNeedsRefills.Controls.Add(Me.Button1)
        Me.btnRefreshNeedsRefills.Controls.Add(Me.Label7)
        Me.btnRefreshNeedsRefills.Controls.Add(Me.Label8)
        Me.btnRefreshNeedsRefills.Location = New System.Drawing.Point(12, 647)
        Me.btnRefreshNeedsRefills.Name = "btnRefreshNeedsRefills"
        Me.btnRefreshNeedsRefills.Size = New System.Drawing.Size(948, 428)
        Me.btnRefreshNeedsRefills.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(626, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Refresh Report: Needs Refills"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Click this button to refresh report.  Print report if needed."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "5"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "PAISNotOnFillList"
        ReportDataSource1.Value = Me.WhyNotFilledBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAIS_Monthly_Check.MissingFromFillList.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 32)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(922, 365)
        Me.ReportViewer1.TabIndex = 3
        '
        'PAISProfilesDataSet
        '
        Me.PAISProfilesDataSet.DataSetName = "PAISProfilesDataSet"
        Me.PAISProfilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WhyNotFilledBindingSource
        '
        Me.WhyNotFilledBindingSource.DataMember = "WhyNotFilled"
        Me.WhyNotFilledBindingSource.DataSource = Me.PAISProfilesDataSet
        '
        'WhyNotFilledTableAdapter
        '
        Me.WhyNotFilledTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "PAISNeedsRefills"
        ReportDataSource2.Value = Me.NeedsRefillsBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "PAIS_Monthly_Check.NeedsRefills.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(8, 32)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(922, 393)
        Me.ReportViewer2.TabIndex = 3
        '
        'NeedsRefillsBindingSource
        '
        Me.NeedsRefillsBindingSource.DataMember = "NeedsRefills"
        Me.NeedsRefillsBindingSource.DataSource = Me.PAISProfilesDataSet
        '
        'NeedsRefillsTableAdapter
        '
        Me.NeedsRefillsTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(983, 722)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnRefreshNeedsRefills)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "PAIS Monthly Check"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.btnRefreshNeedsRefills.ResumeLayout(False)
        Me.btnRefreshNeedsRefills.PerformLayout()
        CType(Me.PAISProfilesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhyNotFilledBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeedsRefillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImportProfiles As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnImportFillLists As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRefreshWhyNotFilled As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRefreshNeedsRefills As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents WhyNotFilledBindingSource As BindingSource
    Friend WithEvents PAISProfilesDataSet As PAISProfilesDataSet
    Friend WithEvents WhyNotFilledTableAdapter As PAISProfilesDataSetTableAdapters.WhyNotFilledTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NeedsRefillsBindingSource As BindingSource
    Friend WithEvents NeedsRefillsTableAdapter As PAISProfilesDataSetTableAdapters.NeedsRefillsTableAdapter
End Class

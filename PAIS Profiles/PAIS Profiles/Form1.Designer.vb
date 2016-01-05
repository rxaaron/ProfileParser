<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.WhyNotFilledBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAISProfilesDataSet1 = New PAIS_Profiles.PAISProfilesDataSet1()
        Me.CurrentProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.datataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()

        Me.Button3 = New System.Windows.Forms.Button()
        Me.WhyNotFilledTableAdapter = New PAIS_Profiles.PAISProfilesDataSet1TableAdapters.WhyNotFilledTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.WhyNotFilledBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAISProfilesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.datataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WhyNotFilledBindingSource
        '
        Me.WhyNotFilledBindingSource.DataMember = "WhyNotFilled"
        Me.WhyNotFilledBindingSource.DataSource = Me.PAISProfilesDataSet1
        '
        'PAISProfilesDataSet1
        '
        Me.PAISProfilesDataSet1.DataSetName = "PAISProfilesDataSet1"
        Me.PAISProfilesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CurrentProfilesBindingSource
        '
        Me.CurrentProfilesBindingSource.DataMember = "CurrentProfiles"

        '
        'PAISProfilesDataSet

        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CurrentProfilesTableAdapter
        '

        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(176, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'WhyNotFilledTableAdapter
        '
        Me.WhyNotFilledTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.WhyNotFilledBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PAIS_Profiles.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(22, 79)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1176, 492)
        Me.ReportViewer1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 629)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.WhyNotFilledBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAISProfilesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.datataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents datataBindingSource As BindingSource
    Friend WithEvents CurrentProfilesBindingSource As BindingSource


    Friend WithEvents Button3 As Button
    Friend WithEvents WhyNotFilledBindingSource As BindingSource
    Friend WithEvents PAISProfilesDataSet1 As PAISProfilesDataSet1
    Friend WithEvents WhyNotFilledTableAdapter As PAISProfilesDataSet1TableAdapters.WhyNotFilledTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

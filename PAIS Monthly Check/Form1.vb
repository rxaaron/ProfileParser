Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports Microsoft.Reporting.WinForms

Public Class frmMain
    Dim myconn As New SqlConnection("Data Source=gmap-server\ENCORE,1776;Network Library=DBMSSOCN;Database=PAISProfiles;UID=gmapuser;PWD=Password1")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PAISProfilesDataSet.NeedsRefills' table. You can move, or remove it, as needed.
        Me.NeedsRefillsTableAdapter.Fill(Me.PAISProfilesDataSet.NeedsRefills)
        'TODO: This line of code loads data into the 'PAISProfilesDataSet.WhyNotFilled' table. You can move, or remove it, as needed.
        Me.WhyNotFilledTableAdapter.Fill(Me.PAISProfilesDataSet.WhyNotFilled)

    End Sub

    Private Sub btnRefreshWhyNotFilled_Click(sender As Object, e As EventArgs)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnImportProfiles_Click(sender As Object, e As EventArgs) Handles btnImportProfiles.Click
        myconn.Open()

        Using afile As New FileIO.TextFieldParser("C:\PAISPROFILES.CSV")
            afile.TextFieldType = FileIO.FieldType.Delimited
            afile.HasFieldsEnclosedInQuotes = True
            afile.SetDelimiters(",")
            Dim currentrow As String()

            Dim da As New SqlDataAdapter
            Dim trnc As New SqlCommand("TRUNCATE TABLE CurrentProfiles;", myconn)
            trnc.ExecuteNonQuery()
            Dim insrt As New SqlCommand("INSERT INTO CurrentProfiles (PatientName, PatientGroup, RxNumber, DrugName, QtyDispensed, QtyRemaining, FillList, Sig1, Sig2, Sig3, Sig4, HOA, DrugNDC, DrugSPI, Doctor, DoctorFax) VALUES (@pn, @pg, @rxn, @dn, @qd, @qr, @fl, @s1, @s2, @s3, @s4, @hoa, @ndc, @spi, @doc, @dfax);", myconn)
            With insrt.Parameters
                .Add("@pn", VarChar)
                .Add("@pg", VarChar)
                .Add("@rxn", Int)
                .Add("@dn", VarChar)
                .Add("@qd", SqlDbType.Decimal)
                .Add("@qr", SqlDbType.Decimal)
                .Add("@fl", Bit)
                .Add("@s1", VarChar)
                .Add("@s2", VarChar)
                .Add("@s3", VarChar)
                .Add("@s4", VarChar)
                .Add("@hoa", VarChar)
                .Add("@ndc", BigInt)
                .Add("@spi", Int)
                .Add("@doc", VarChar)
                .Add("@dfax", VarChar)
            End With
            da.InsertCommand = insrt
            While Not afile.EndOfData
                Dim i As Integer = 0
                Try

                    currentrow = afile.ReadFields()
                    For Each currentfields As String In currentrow
                        If String.IsNullOrEmpty(currentfields) = True Then
                            insrt.Parameters(i).Value = DBNull.Value
                        Else
                            Select Case insrt.Parameters(i).SqlDbType
                                Case SqlDbType.Bit
                                    insrt.Parameters(i).Value = String.Equals("YES", currentfields, StringComparison.OrdinalIgnoreCase)
                                Case SqlDbType.Int
                                    insrt.Parameters(i).Value = CInt(currentfields)
                                Case SqlDbType.Decimal
                                    insrt.Parameters(i).Value = Decimal.Parse(currentfields)
                                Case SqlDbType.BigInt
                                    insrt.Parameters(i).Value = CType(currentfields, Int64)
                                Case SqlDbType.VarChar
                                    insrt.Parameters(i).Value = currentfields
                            End Select
                        End If

                        i = i + 1
                    Next
                    insrt.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("ERROR:   " & ex.Message & Chr(13) & "Line Number:  " & afile.LineNumber.ToString)
                End Try

            End While


        End Using
        MsgBox("File has been imported.", MsgBoxStyle.OkOnly, "File Imported")
        myconn.Close()
    End Sub

    Private Sub btnImportFillLists_Click(sender As Object, e As EventArgs) Handles btnImportFillLists.Click
        myconn.Open()

        Using afile As New FileIO.TextFieldParser("C:\PAIS2.CSV")
            afile.TextFieldType = FileIO.FieldType.Delimited
            afile.HasFieldsEnclosedInQuotes = True
            afile.SetDelimiters(",")
            Dim currentrow As String()

            Dim da As New SqlDataAdapter
            Dim trnc As New SqlCommand("TRUNCATE TABLE CurrentFillList;", myconn)
            trnc.ExecuteNonQuery()
            Dim insrt As New SqlCommand("INSERT INTO CurrentFillList (RxNumber, QtyDispensed) VALUES (@rxn, @qd);", myconn)
            With insrt.Parameters
                .Add("@qd", SqlDbType.Decimal)
                .Add("@rxn", Int)
            End With
            da.InsertCommand = insrt
            While Not afile.EndOfData
                Dim i As Integer = 0
                Try

                    currentrow = afile.ReadFields()
                    For Each currentfields As String In currentrow
                        If String.IsNullOrEmpty(currentfields) = True Then
                            insrt.Parameters(i).Value = DBNull.Value
                        Else
                            Select Case insrt.Parameters(i).SqlDbType
                                Case SqlDbType.Int
                                    insrt.Parameters(i).Value = CInt(currentfields)
                                Case SqlDbType.Decimal
                                    insrt.Parameters(i).Value = Decimal.Parse(currentfields)
                                Case SqlDbType.BigInt
                                    insrt.Parameters(i).Value = CType(currentfields, Int64)
                                Case SqlDbType.VarChar
                                    insrt.Parameters(i).Value = currentfields
                            End Select
                        End If

                        i = i + 1
                    Next
                    insrt.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("ERROR:   " & ex.Message & Chr(13) & "Line Number:  " & afile.LineNumber.ToString)
                End Try

            End While


        End Using
        MsgBox("File has been imported.", MsgBoxStyle.OkOnly, "File Imported")
        myconn.Close()
    End Sub

    Private Sub RadioCheckChanged(sender As Object, e As EventArgs) Handles rdoNeedsRefillsNursing.CheckedChanged, rdoNeedsRefillsPharmacy.CheckedChanged, rdoShouldBeOnFillList.CheckedChanged


        Dim rptDataSource1 As New ReportDataSource
        Dim rptDataSource2 As New ReportDataSource

        rptDataSource1.Name = "NeedsRefills"
        rptDataSource1.Value = Me.PAISProfilesDataSet.NeedsRefills
        rptDataSource2.Name = "WhyNotFilled"
        rptDataSource2.Value = Me.PAISProfilesDataSet.WhyNotFilled
        Me.WhyNotFilledTableAdapter.Fill(Me.PAISProfilesDataSet.WhyNotFilled)
        Me.NeedsRefillsTableAdapter.Fill(Me.PAISProfilesDataSet.NeedsRefills)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.Reset()

        If rdoNeedsRefillsNursing.Checked = True Then
            ReportViewer1.LocalReport.DataSources.Add(rptDataSource1)
            ReportViewer1.LocalReport.ReportEmbeddedResource = "PAIS_Monthly_Check.NeedsRefillsNursing.rdlc"
        ElseIf rdoNeedsRefillsPharmacy.Checked = True Then
            ReportViewer1.LocalReport.DataSources.Add(rptDataSource1)
            ReportViewer1.LocalReport.ReportEmbeddedResource = "PAIS_Monthly_Check.NeedsRefills.rdlc"

        ElseIf rdoShouldBeOnFillList.Checked = True Then
            ReportViewer1.LocalReport.DataSources.Add(rptDataSource2)
            ReportViewer1.LocalReport.ReportEmbeddedResource = "PAIS_Monthly_Check.MissingFromFillList.rdlc"
        Else
            ReportViewer1.Clear()
        End If
        ReportViewer1.RefreshReport()
    End Sub

End Class

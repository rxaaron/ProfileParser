Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.Data.SqlClient
Imports System.Data.SqlDbType

Public Class frmMain
    Dim myconn As New SqlConnection("Data Source=gmap-server\ENCORE,1776;Network Library=DBMSSOCN;Database=PAISProfiles;UID=gmapuser;PWD=Password1")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pg As New System.Drawing.Printing.PageSettings
        pg.Margins.Top = 25
        pg.Margins.Bottom = 25
        pg.Margins.Left = 100
        pg.Margins.Right = 100
        pg.Landscape = True
        ReportViewer1.SetPageSettings(pg)
        ReportViewer2.SetPageSettings(pg)

    End Sub

    Private Sub btnRefreshWhyNotFilled_Click(sender As Object, e As EventArgs) Handles btnRefreshWhyNotFilled.Click
        Me.WhyNotFilledTableAdapter.Fill(Me.PAISProfilesDataSet.WhyNotFilled)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.NeedsRefillsTableAdapter.Fill(Me.PAISProfilesDataSet.NeedsRefills)
        Me.ReportViewer2.RefreshReport()

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
            Dim insrt As New SqlCommand("INSERT INTO CurrentProfiles (PatientName, PatientGroup, RxNumber, DrugName, QtyDispensed, QtyRemaining, FillList, Sig1, Sig2, Sig3, Sig4, HOA, DrugNDC, DrugSPI) VALUES (@pn, @pg, @rxn, @dn, @qd, @qr, @fl, @s1, @s2, @s3, @s4, @hoa, @ndc, @spi);", myconn)
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

End Class

﻿Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.Data.SqlClient
Imports System.Data.SqlDbType

Public Class Form1
    Dim myconn As New SqlConnection("Data Source=gmap-server\ENCORE,1776;Network Library=DBMSSOCN;Database=PAISProfiles;UID=gmapuser;PWD=Password1")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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



                        'If insrt.Parameters(i).SqlDbType = SqlDbType.Bit Then
                        '    insrt.Parameters(i).Value = String.Equals("YES", currentfields, StringComparison.OrdinalIgnoreCase)
                        'ElseIf insrt.Parameters(i).SqlDbType = SqlDbType.Int Then
                        'ElseIf
                        '    insrt.Parameters(i).Value = currentfields
                        'End If

                        i = i + 1
                    Next
                    insrt.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("ERROR:   " & ex.Message & Chr(13) & "Line Number:  " & afile.LineNumber.ToString)
                End Try

            End While


        End Using
        myconn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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



                        'If insrt.Parameters(i).SqlDbType = SqlDbType.Bit Then
                        '    insrt.Parameters(i).Value = String.Equals("YES", currentfields, StringComparison.OrdinalIgnoreCase)
                        'ElseIf insrt.Parameters(i).SqlDbType = SqlDbType.Int Then
                        'ElseIf
                        '    insrt.Parameters(i).Value = currentfields
                        'End If

                        i = i + 1
                    Next
                    insrt.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("ERROR:   " & ex.Message & Chr(13) & "Line Number:  " & afile.LineNumber.ToString)
                End Try

            End While


        End Using
        myconn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PAISProfilesDataSet1.WhyNotFilled' table. You can move, or remove it, as needed.

        ''TODO: This line of code loads data into the 'PAISProfilesDataSet1.WhyNotFilled' table. You can move, or remove it, as needed.
        'Me.WhyNotFilledTableAdapter.Fill(Me.PAISProfilesDataSet1.WhyNotFilled)
        ''TODO: This line of code loads data into the 'PAISProfilesDataSet.CurrentProfiles' table. You can move, or remove it, as needed.
        'Me.CurrentProfilesTableAdapter.Fill(Me.PAISProfilesDataSet.CurrentProfiles)

        '' Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WhyNotFilledTableAdapter.Fill(Me.PAISProfilesDataSet1.WhyNotFilled)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class

Imports Microsoft.VisualBasic.FileIO.TextFieldParser

Public Class Form1

    Dim dt As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using afile As New FileIO.TextFieldParser("C:\PAISPROFILES.CSV")
            afile.TextFieldType = FileIO.FieldType.Delimited
            afile.HasFieldsEnclosedInQuotes = True
            afile.SetDelimiters(",")
            Dim currentrow As String()
            Dim i As Integer = 0
            While Not afile.EndOfData
                Try
                    currentrow = afile.ReadFields()
                    If i = 0 Then
                        For Each currentfield As String In currentrow
                            dt.Columns.Add(currentfield)
                        Next
                    Else
                        Dim q As Integer = 0
                        Dim dr As DataRow = dt.NewRow()
                        For Each currentfields As String In currentrow

                            dr(q) = currentfields

                            q = q + 1
                        Next
                        dt.Rows.Add(dr)
                    End If
                Catch ex As Exception

                End Try
                i = i + 1
            End While
            dt.TableName = "datata"
            DataSet1.Tables.Add(dt)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Me.ReportViewer1.RefreshReport()
    End Sub
End Class

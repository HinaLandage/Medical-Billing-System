Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\medico\medico.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "DELETE FROM info WHERE code=@code"
            sqlquery.Parameters.AddWithValue("@code", TextBox1.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("Delete record process is in running....")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Successfully complete ... ")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
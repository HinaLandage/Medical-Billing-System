Public Class Form3

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = "0"
        MsgBox("Click on confrim after give info ")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sqlconn As New OleDb.OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Try
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\medico\medico.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO info(code,medicine,mfg,proddate,expdate,price,StockIn,StockOut,StockInHand)VALUES(@code,@medicine,@mfg,@proddate,@expdate,@price,@StockIn,@StockOut,@StockInHand)"
            sqlquery.Parameters.AddWithValue("@code", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@meidcine", TextBox2.Text)
            sqlquery.Parameters.AddWithValue("@mfg", TextBox3.Text)
            sqlquery.Parameters.AddWithValue("@proddate", TextBox4.Text)
            sqlquery.Parameters.AddWithValue("@expdate", TextBox5.Text)
            sqlquery.Parameters.AddWithValue("@price", TextBox6.Text)
            sqlquery.Parameters.AddWithValue("@StockIn", TextBox7.Text)
            sqlquery.Parameters.AddWithValue("@StockOut", TextBox8.Text)
            sqlquery.Parameters.AddWithValue("@StockInHand", TextBox9.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("Successfully add record in table ")
        Catch ex As Exception
            MessageBox.Show("Sorry repeated code not allow....")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim x As String
        x = DateTimePicker1.Value
        TextBox4.Text = x

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
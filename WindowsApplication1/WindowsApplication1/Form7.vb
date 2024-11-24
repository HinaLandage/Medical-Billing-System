Public Class Form7

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sqlconn As New OleDb.OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Try
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\medico\medico.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            Dim aa, bb, cc
            aa = ComboBox1.Text * TextBox8.Text
            bb = aa * 18 / 100
            cc = aa + bb
            TextBox4.Text = aa
            TextBox5.Text = bb
            TextBox6.Text = cc
            sqlquery.CommandText = "INSERT INTO trans(CustCode,CustName,TransDate,details,BillAmt,Gst,TotalBill)VALUES(@CustCode,@CustName,@TransDate,@details,@BillAmt,@Gst,@TotalBill)"
            sqlquery.Parameters.AddWithValue("@CustCode", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@CustName", TextBox2.Text)
            sqlquery.Parameters.AddWithValue("@TransDate", TextBox3.Text)
            sqlquery.Parameters.AddWithValue("@details", TextBox9.Text)
            sqlquery.Parameters.AddWithValue("@BillAmt", TextBox4.Text)
            sqlquery.Parameters.AddWithValue("@Gst", TextBox5.Text)
            sqlquery.Parameters.AddWithValue("@TotalBill", TextBox6.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("Successfully add record in table ")
        Catch ex As Exception
            MessageBox.Show("Sorry repeated code not allow....")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            Dim p, q
            p = InputBox("Enter Price ")
            q = InputBox("Enter Med Details")
            TextBox8.Text = p
            TextBox9.Text = q
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\medico\medico.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            If ComboBox1.Text = "5" Then
                sqlquery.CommandText = "UPDATE info set StockIn=StockIn+5,StockInHand=StockInHand+5 where code=@code"
            End If
            If ComboBox1.Text = "15" Then
                sqlquery.CommandText = "UPDATE info set StockIn=StockIn+15,StockInHand=StockInHand+15 where code=@code"
            End If
            If ComboBox1.Text = "10" Then
                sqlquery.CommandText = "UPDATE info set StockIn=StockIn+10,StockInHand=StockInHand+10 where code=@code"
            End If
            If ComboBox1.Text = "20" Then
                sqlquery.CommandText = "UPDATE info set StockIn=StockIn+20,StockInHand=StockInHand+20 where code=@code"
            End If
            If ComboBox1.Text = "50" Then
                sqlquery.CommandText = "UPDATE info set StockIn=StockIn+50,StockInHand=StockInHand+50 where code=@code"
            End If
            sqlquery.Parameters.AddWithValue("@code", TextBox7.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("Update record process is in running....")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\medico\medico.mdb"
            con.Open()
            ds.Tables.Add(dt)
            da = New OleDb.OleDbDataAdapter("Select * from info where code = " + TextBox7.Text, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            con.Close()
        Catch
            MsgBox("Sorry invalid process...")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\medico\medico.mdb"
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDb.OleDbDataAdapter("Select * from info", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
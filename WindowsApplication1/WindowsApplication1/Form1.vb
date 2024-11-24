Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "komal" Or TextBox1.Text = "KOMAL" Then
            If TextBox2.Text = "123" Then
                MsgBox("Success Passwrod Detect")
                Form2.Show()
            Else
                MsgBox("SORRY....")
            End If
        Else
            MsgBox("SORRY")
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

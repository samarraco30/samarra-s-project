Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblusn.Click

    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim lblusn As String = txtusn.Text
        Dim Llblpass As String = txtpass.Text

        If txtusn.Text = ("samarra") And txtpass.Text = ("bozzsam30") Then
            Me.Hide()
            Form2.Show()

        Else
            MsgBox("YOU Put Incorrect Usename or Password")
        End If
    End Sub

    Private Sub txtusn_TextChanged(sender As Object, e As EventArgs) Handles txtusn.TextChanged
        txtusn.Focus()
    End Sub
End Class

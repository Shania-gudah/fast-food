Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String
        Dim password As String
        username = Txtusername.Text
        password = txtpassword.Text
        If (Txtusername.Text = ("Delicious") And txtpassword.Text = ("pass254")) Then
            MessageBox.Show("Login Successful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("ERROR", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Form2.Show()
        Me.Hide()


    End Sub
End Class

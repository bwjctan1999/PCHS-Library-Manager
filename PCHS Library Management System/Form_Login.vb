Public Class Form_Login
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Me.Hide()
        Form1.Show()
    End Sub

    'TEXTBOX FUNCTIONS:'
    Private Sub Txtbox_Username_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Username.Click
        Txtbox_Username.Clear()
        Txtbox_Username.ForeColor = Color.Black
    End Sub

    Private Sub Txtbox_Password_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Password.Click
        Txtbox_Password.Clear()
        Txtbox_Password.ForeColor = Color.Black
        Txtbox_Password.PasswordChar = "*"
    End Sub

    Private Sub Lbl_Click_Click(sender As Object, e As EventArgs) Handles Lbl_Click.Click
        MsgBox("You idjit")
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
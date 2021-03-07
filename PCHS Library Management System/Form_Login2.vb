Public Class Form_Login2
    Private Sub Form_Login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Windowstate to Fullscreen'
        Me.WindowState = 2
    End Sub

    Private Sub Lbl_ForgetPass_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_ForgetPass.MouseEnter
        Me.Lbl_ForgetPass.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Lbl_ForgetPass_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ForgetPass.MouseLeave
        Me.Lbl_ForgetPass.ForeColor = Color.White
    End Sub

    Private Sub Lbl_ForgetPass_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Me.Hide()
        Form_Manager.Show()
    End Sub
End Class
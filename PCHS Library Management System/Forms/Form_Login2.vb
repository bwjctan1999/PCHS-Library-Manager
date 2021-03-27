Public Class Form_Login2
    Private Sub Form_Login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Windowstate to Fullscreen'
        Me.WindowState = 2
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Me.Hide()
        Form_SplashScreen.Show()
    End Sub

    Private Sub Txtbox_Username_Click(sender As Object, e As EventArgs) Handles Txtbox_Username.Click
        If Txtbox_Username.Text = "Username" Then
            Txtbox_Username.Clear()
            Txtbox_Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtbox_Password_Click(sender As Object, e As EventArgs) Handles Txtbox_Password.Click
        If Txtbox_Password.Text = "Password" Then
            Txtbox_Password.Clear()
            Txtbox_Password.ForeColor = Color.Black
            Txtbox_Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Lbl_ForgetPass_Click(sender As Object, e As EventArgs) Handles Lbl_ForgetPass.Click
        Panel_Login.Hide()
        Panel_ForgotPass.Show()
    End Sub

    Private Sub Btn_Okay_Click(sender As Object, e As EventArgs) Handles Btn_Okay.Click
        Panel_ForgotPass.Hide()
        Panel_Login.Show()
    End Sub



    Private Sub Txtbox_Username_TextLeave(sender As Object, e As EventArgs) Handles Txtbox_Username.Leave
        If Txtbox_Username.Text = "" Then
            Txtbox_Username.ForeColor = Color.DimGray
            Txtbox_Username.Text = "Username"
        End If
    End Sub

    Private Sub Txtbox_Password_Leave(sender As Object, e As EventArgs) Handles Txtbox_Password.Leave
        If Txtbox_Password.Text = "" Then
            Txtbox_Password.ForeColor = Color.DimGray
            Txtbox_Password.Text = "Password"
            Txtbox_Password.PasswordChar = ""
        End If
    End Sub

    'GUI DESIGN - NO NEED TO TOUCH
    Private Sub Lbl_ForgetPass_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_ForgetPass.MouseEnter
        Me.Lbl_ForgetPass.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Lbl_ForgetPass_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ForgetPass.MouseLeave
        Me.Lbl_ForgetPass.ForeColor = Color.White
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class
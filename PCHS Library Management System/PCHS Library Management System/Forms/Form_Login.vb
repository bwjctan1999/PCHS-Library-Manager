
Public Class Form_Login

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckConnection() = False Then
            Form_DatabaseSettings.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Try
            openCon()
            command("SELECT * FROM tbl_librarians WHERE username = '" & Txtbox_Username.Text & "' AND password = '" & Txtbox_Password.Text & "'")
            FillTable()

            If GetTable().Rows.Count = Nothing Then
                Msg.SetContent("", "Incorrect Username or Password")
                Msg.ShowDialog()
            Else
                SetCurrentUser(GetTable().Rows(0).Item(0))
                Me.Hide()
                Form_SplashScreen.Show()
            End If

            closeCon()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Txtbox_Username_Click(sender As Object, e As EventArgs) Handles Txtbox_Username.Click
        If Txtbox_Username.Text = "Username" Then
            Txtbox_Username.Clear()
            Txtbox_Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtbox_Password_Click(sender As Object, e As EventArgs) Handles Txtbox_Password.GotFocus
        If Txtbox_Password.Text = "Password" Then
            Txtbox_Password.Clear()
            Txtbox_Password.ForeColor = Color.Black
            Txtbox_Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Lbl_ForgetPass_Click(sender As Object, e As EventArgs) Handles Lbl_ForgetPass.Click
        If Txtbox_Username.Text = "Username" Then
            Msg.SetContent("", "Please input a Username")
            Msg.ShowDialog()
        Else
            Try
                openCon()
                cmd.Parameters.Clear()
                command("SELECT email, fname, lname, password FROM tbl_librarians WHERE (`username`) = @username")
                cmd.Parameters.AddWithValue("@username", Txtbox_Username.Text)

                reader = cmd.ExecuteReader

                Dim email As String
                Dim fname As String
                Dim lname As String
                Dim password As String

                While reader.Read
                    email = reader("email")
                    fname = reader("fname")
                    lname = reader("lname")
                    password = reader("password")
                End While
                closeCon()


                If email <> "" Then
                    Dim emailer As New Emailer
                    Dim message As String = "Good Day " & fname & " " & lname & vbCrLf &
                                            "This is the password of your account: '" & password & "'"

                    emailer.SetSendtoInfo(email, message)
                    emailer.SendEmail()

                    Panel_Login.Hide()
                    Panel_ForgotPass.Show()
                Else
                    Msg.SetContent("", "This account doesnt have an email or does not exist, Please contact your System administrator")
                    Msg.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End If

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
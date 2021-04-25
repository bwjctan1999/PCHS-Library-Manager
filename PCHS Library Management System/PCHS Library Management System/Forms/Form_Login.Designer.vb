<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtbox_Password = New System.Windows.Forms.TextBox()
        Me.Txtbox_Username = New System.Windows.Forms.TextBox()
        Me.Lbl_ForgetPass = New System.Windows.Forms.Label()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_ForgotPass = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Okay = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ForgotPass.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Login
        '
        Me.Panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_Login.Controls.Add(Me.Label2)
        Me.Panel_Login.Controls.Add(Me.Txtbox_Password)
        Me.Panel_Login.Controls.Add(Me.Txtbox_Username)
        Me.Panel_Login.Controls.Add(Me.Lbl_ForgetPass)
        Me.Panel_Login.Controls.Add(Me.Btn_Login)
        Me.Panel_Login.Controls.Add(Me.Label1)
        Me.Panel_Login.Location = New System.Drawing.Point(285, 190)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Size = New System.Drawing.Size(412, 337)
        Me.Panel_Login.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pangantucan Community High School Library"
        '
        'Txtbox_Password
        '
        Me.Txtbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtbox_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Password.ForeColor = System.Drawing.Color.DimGray
        Me.Txtbox_Password.Location = New System.Drawing.Point(50, 175)
        Me.Txtbox_Password.Name = "Txtbox_Password"
        Me.Txtbox_Password.Size = New System.Drawing.Size(311, 27)
        Me.Txtbox_Password.TabIndex = 2
        Me.Txtbox_Password.Text = "Password"
        '
        'Txtbox_Username
        '
        Me.Txtbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtbox_Username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Username.ForeColor = System.Drawing.Color.DimGray
        Me.Txtbox_Username.Location = New System.Drawing.Point(50, 125)
        Me.Txtbox_Username.Name = "Txtbox_Username"
        Me.Txtbox_Username.Size = New System.Drawing.Size(311, 27)
        Me.Txtbox_Username.TabIndex = 1
        Me.Txtbox_Username.Text = "Username"
        '
        'Lbl_ForgetPass
        '
        Me.Lbl_ForgetPass.AutoSize = True
        Me.Lbl_ForgetPass.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ForgetPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_ForgetPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ForgetPass.ForeColor = System.Drawing.Color.White
        Me.Lbl_ForgetPass.Location = New System.Drawing.Point(47, 225)
        Me.Lbl_ForgetPass.Name = "Lbl_ForgetPass"
        Me.Lbl_ForgetPass.Size = New System.Drawing.Size(122, 17)
        Me.Lbl_ForgetPass.TabIndex = 4
        Me.Lbl_ForgetPass.Text = "Forget Password?"
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Login.FlatAppearance.BorderSize = 0
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.Color.White
        Me.Btn_Login.Location = New System.Drawing.Point(50, 249)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(311, 31)
        Me.Btn_Login.TabIndex = 3
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(118, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Back!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.PCHS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(413, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel_ForgotPass
        '
        Me.Panel_ForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_ForgotPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_ForgotPass.Controls.Add(Me.Label4)
        Me.Panel_ForgotPass.Controls.Add(Me.Panel1)
        Me.Panel_ForgotPass.Controls.Add(Me.Label6)
        Me.Panel_ForgotPass.Controls.Add(Me.Label3)
        Me.Panel_ForgotPass.Controls.Add(Me.Label5)
        Me.Panel_ForgotPass.Location = New System.Drawing.Point(285, 190)
        Me.Panel_ForgotPass.Name = "Panel_ForgotPass"
        Me.Panel_ForgotPass.Size = New System.Drawing.Size(412, 280)
        Me.Panel_ForgotPass.TabIndex = 7
        Me.Panel_ForgotPass.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "benzwaltertan@gmail.com," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_Okay)
        Me.Panel1.Location = New System.Drawing.Point(1, 212)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 68)
        Me.Panel1.TabIndex = 7
        '
        'Btn_Okay
        '
        Me.Btn_Okay.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Okay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Okay.FlatAppearance.BorderSize = 0
        Me.Btn_Okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Okay.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Okay.ForeColor = System.Drawing.Color.White
        Me.Btn_Okay.Location = New System.Drawing.Point(258, 19)
        Me.Btn_Okay.Name = "Btn_Okay"
        Me.Btn_Okay.Size = New System.Drawing.Size(133, 31)
        Me.Btn_Okay.TabIndex = 3
        Me.Btn_Okay.Text = "Okay"
        Me.Btn_Okay.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(365, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "please check both your inbox and spam folder."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "We have sent your password to "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "PASSWORD SENT"
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Background_7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel_Login)
        Me.Controls.Add(Me.Panel_ForgotPass)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Login"
        Me.Text = "PCHS Library Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Login.ResumeLayout(False)
        Me.Panel_Login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ForgotPass.ResumeLayout(False)
        Me.Panel_ForgotPass.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Login As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtbox_Password As TextBox
    Friend WithEvents Txtbox_Username As TextBox
    Friend WithEvents Lbl_ForgetPass As Label
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel_ForgotPass As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Okay As Button
    Friend WithEvents Label6 As Label
End Class

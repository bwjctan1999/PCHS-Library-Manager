<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Student
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_LogIn = New System.Windows.Forms.Button()
        Me.UserControl_FeaturedBooks = New PCHS_Library_Management_System.UserControl_BookShowcase()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserControl_NewBooks = New PCHS_Library_Management_System.UserControl_BookShowcase()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_SearchSettings = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.searchbar
        Me.PictureBox1.Location = New System.Drawing.Point(179, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(630, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(197, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(536, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Btn_LogIn
        '
        Me.Btn_LogIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_LogIn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_LogIn.FlatAppearance.BorderSize = 0
        Me.Btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LogIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_LogIn.ForeColor = System.Drawing.Color.White
        Me.Btn_LogIn.Location = New System.Drawing.Point(906, 12)
        Me.Btn_LogIn.Name = "Btn_LogIn"
        Me.Btn_LogIn.Size = New System.Drawing.Size(75, 29)
        Me.Btn_LogIn.TabIndex = 2
        Me.Btn_LogIn.Text = "Log In"
        Me.Btn_LogIn.UseVisualStyleBackColor = False
        '
        'UserControl_FeaturedBooks
        '
        Me.UserControl_FeaturedBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_FeaturedBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserControl_FeaturedBooks.Location = New System.Drawing.Point(105, 174)
        Me.UserControl_FeaturedBooks.Name = "UserControl_FeaturedBooks"
        Me.UserControl_FeaturedBooks.Size = New System.Drawing.Size(772, 160)
        Me.UserControl_FeaturedBooks.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(105, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Featured"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label2.Location = New System.Drawing.Point(105, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "New Arrivals"
        '
        'UserControl_NewBooks
        '
        Me.UserControl_NewBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_NewBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserControl_NewBooks.Location = New System.Drawing.Point(105, 389)
        Me.UserControl_NewBooks.Name = "UserControl_NewBooks"
        Me.UserControl_NewBooks.Size = New System.Drawing.Size(772, 160)
        Me.UserControl_NewBooks.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Search2
        Me.Button1.Location = New System.Drawing.Point(768, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_SearchSettings
        '
        Me.Btn_SearchSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_SearchSettings.BackColor = System.Drawing.Color.White
        Me.Btn_SearchSettings.FlatAppearance.BorderSize = 0
        Me.Btn_SearchSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SearchSettings.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icons_Settings2
        Me.Btn_SearchSettings.Location = New System.Drawing.Point(739, 76)
        Me.Btn_SearchSettings.Name = "Btn_SearchSettings"
        Me.Btn_SearchSettings.Size = New System.Drawing.Size(29, 30)
        Me.Btn_SearchSettings.TabIndex = 8
        Me.Btn_SearchSettings.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Borrow"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(82, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Return"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Background_7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_SearchSettings)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserControl_NewBooks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserControl_FeaturedBooks)
        Me.Controls.Add(Me.Btn_LogIn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Student"
        Me.Text = "Form_Student"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_LogIn As Button
    Friend WithEvents UserControl_FeaturedBooks As UserControl_BookShowcase
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserControl_NewBooks As UserControl_BookShowcase
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_SearchSettings As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

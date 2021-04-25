<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtbox_Email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtbox_Fine = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtbox_Epassword = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Save2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_ShelfNo = New System.Windows.Forms.Label()
        Me.Txtbox_Server = New System.Windows.Forms.TextBox()
        Me.LABELSDF = New System.Windows.Forms.Label()
        Me.Txtbox_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FASDF = New System.Windows.Forms.Label()
        Me.Txtbox_Username = New System.Windows.Forms.TextBox()
        Me.Txtbox_Database = New System.Windows.Forms.TextBox()
        Me.Cbox_Duration = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtbox_Duration = New System.Windows.Forms.TextBox()
        Me.Btn_AddDuration = New System.Windows.Forms.Button()
        Me.Cbox_Interval = New System.Windows.Forms.ComboBox()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Save1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_Inc = New System.Windows.Forms.Button()
        Me.Btn_Minus = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 53)
        Me.Panel3.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_DatabaseWarning
        Me.PictureBox2.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrow Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txtbox_Email
        '
        Me.Txtbox_Email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Email.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Email.Location = New System.Drawing.Point(26, 339)
        Me.Txtbox_Email.Name = "Txtbox_Email"
        Me.Txtbox_Email.Size = New System.Drawing.Size(375, 26)
        Me.Txtbox_Email.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Due Date Fine"
        '
        'Txtbox_Fine
        '
        Me.Txtbox_Fine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Fine.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Fine.Location = New System.Drawing.Point(50, 91)
        Me.Txtbox_Fine.Name = "Txtbox_Fine"
        Me.Txtbox_Fine.Size = New System.Drawing.Size(197, 26)
        Me.Txtbox_Fine.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Email Password"
        '
        'Txtbox_Epassword
        '
        Me.Txtbox_Epassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Epassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Epassword.Location = New System.Drawing.Point(26, 412)
        Me.Txtbox_Epassword.Name = "Txtbox_Epassword"
        Me.Txtbox_Epassword.Size = New System.Drawing.Size(375, 26)
        Me.Txtbox_Epassword.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(0, 243)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(292, 53)
        Me.Panel4.TabIndex = 15
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_DatabaseWarning
        Me.PictureBox3.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(46, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Forgot Password Emailer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Save2
        '
        Me.Btn_Save2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Save2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Save2.FlatAppearance.BorderSize = 0
        Me.Btn_Save2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Save2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Save2.Location = New System.Drawing.Point(217, 463)
        Me.Btn_Save2.Name = "Btn_Save2"
        Me.Btn_Save2.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Save2.TabIndex = 16
        Me.Btn_Save2.Text = "Save"
        Me.Btn_Save2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Btn_Save2)
        Me.Panel2.Controls.Add(Me.Txtbox_Server)
        Me.Panel2.Controls.Add(Me.LABELSDF)
        Me.Panel2.Controls.Add(Me.Txtbox_Password)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.FASDF)
        Me.Panel2.Controls.Add(Me.Txtbox_Username)
        Me.Panel2.Controls.Add(Me.Txtbox_Database)
        Me.Panel2.Location = New System.Drawing.Point(430, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 508)
        Me.Panel2.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_ShelfNo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 53)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_DatabaseWarning
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Lbl_ShelfNo
        '
        Me.Lbl_ShelfNo.AutoSize = True
        Me.Lbl_ShelfNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ShelfNo.ForeColor = System.Drawing.Color.White
        Me.Lbl_ShelfNo.Location = New System.Drawing.Point(46, 15)
        Me.Lbl_ShelfNo.Name = "Lbl_ShelfNo"
        Me.Lbl_ShelfNo.Size = New System.Drawing.Size(177, 23)
        Me.Lbl_ShelfNo.TabIndex = 0
        Me.Lbl_ShelfNo.Text = "Database Settings"
        Me.Lbl_ShelfNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txtbox_Server
        '
        Me.Txtbox_Server.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Server.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Server.Location = New System.Drawing.Point(35, 91)
        Me.Txtbox_Server.Name = "Txtbox_Server"
        Me.Txtbox_Server.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Server.TabIndex = 0
        '
        'LABELSDF
        '
        Me.LABELSDF.AutoSize = True
        Me.LABELSDF.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABELSDF.ForeColor = System.Drawing.Color.White
        Me.LABELSDF.Location = New System.Drawing.Point(31, 69)
        Me.LABELSDF.Name = "LABELSDF"
        Me.LABELSDF.Size = New System.Drawing.Size(54, 18)
        Me.LABELSDF.TabIndex = 1
        Me.LABELSDF.Text = "Server"
        '
        'Txtbox_Password
        '
        Me.Txtbox_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Password.Location = New System.Drawing.Point(35, 231)
        Me.Txtbox_Password.Name = "Txtbox_Password"
        Me.Txtbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtbox_Password.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Password.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'FASDF
        '
        Me.FASDF.AutoSize = True
        Me.FASDF.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FASDF.ForeColor = System.Drawing.Color.White
        Me.FASDF.Location = New System.Drawing.Point(31, 136)
        Me.FASDF.Name = "FASDF"
        Me.FASDF.Size = New System.Drawing.Size(82, 18)
        Me.FASDF.TabIndex = 1
        Me.FASDF.Text = "Username"
        '
        'Txtbox_Username
        '
        Me.Txtbox_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Username.Location = New System.Drawing.Point(35, 158)
        Me.Txtbox_Username.Name = "Txtbox_Username"
        Me.Txtbox_Username.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Username.TabIndex = 0
        '
        'Txtbox_Database
        '
        Me.Txtbox_Database.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Database.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Database.Location = New System.Drawing.Point(35, 300)
        Me.Txtbox_Database.Name = "Txtbox_Database"
        Me.Txtbox_Database.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Database.TabIndex = 0
        '
        'Cbox_Duration
        '
        Me.Cbox_Duration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cbox_Duration.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_Duration.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cbox_Duration.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Cbox_Duration.FormattingEnabled = True
        Me.Cbox_Duration.Location = New System.Drawing.Point(24, 157)
        Me.Cbox_Duration.Name = "Cbox_Duration"
        Me.Cbox_Duration.Size = New System.Drawing.Size(100, 28)
        Me.Cbox_Duration.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Borrow Durations"
        '
        'Txtbox_Duration
        '
        Me.Txtbox_Duration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_Duration.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Duration.Location = New System.Drawing.Point(130, 159)
        Me.Txtbox_Duration.Name = "Txtbox_Duration"
        Me.Txtbox_Duration.Size = New System.Drawing.Size(33, 26)
        Me.Txtbox_Duration.TabIndex = 0
        '
        'Btn_AddDuration
        '
        Me.Btn_AddDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddDuration.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_AddDuration.FlatAppearance.BorderSize = 0
        Me.Btn_AddDuration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddDuration.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_AddDuration.ForeColor = System.Drawing.Color.White
        Me.Btn_AddDuration.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_AddDuration.Location = New System.Drawing.Point(330, 158)
        Me.Btn_AddDuration.Name = "Btn_AddDuration"
        Me.Btn_AddDuration.Size = New System.Drawing.Size(71, 26)
        Me.Btn_AddDuration.TabIndex = 16
        Me.Btn_AddDuration.Text = "Add"
        Me.Btn_AddDuration.UseVisualStyleBackColor = False
        '
        'Cbox_Interval
        '
        Me.Cbox_Interval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cbox_Interval.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_Interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_Interval.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cbox_Interval.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Cbox_Interval.FormattingEnabled = True
        Me.Cbox_Interval.Items.AddRange(New Object() {"Day", "Month"})
        Me.Cbox_Interval.Location = New System.Drawing.Point(169, 158)
        Me.Cbox_Interval.Name = "Cbox_Interval"
        Me.Cbox_Interval.Size = New System.Drawing.Size(78, 28)
        Me.Cbox_Interval.TabIndex = 18
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Delete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Delete.Location = New System.Drawing.Point(253, 158)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(71, 26)
        Me.Btn_Delete.TabIndex = 16
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_Save1
        '
        Me.Btn_Save1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Save1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Save1.FlatAppearance.BorderSize = 0
        Me.Btn_Save1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Save1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Save1.Location = New System.Drawing.Point(285, 463)
        Me.Btn_Save1.Name = "Btn_Save1"
        Me.Btn_Save1.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Save1.TabIndex = 16
        Me.Btn_Save1.Text = "Save"
        Me.Btn_Save1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "₱"
        '
        'Btn_Inc
        '
        Me.Btn_Inc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Inc.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Inc.FlatAppearance.BorderSize = 0
        Me.Btn_Inc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Inc.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inc.ForeColor = System.Drawing.Color.White
        Me.Btn_Inc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Inc.Location = New System.Drawing.Point(330, 91)
        Me.Btn_Inc.Name = "Btn_Inc"
        Me.Btn_Inc.Size = New System.Drawing.Size(71, 26)
        Me.Btn_Inc.TabIndex = 16
        Me.Btn_Inc.Text = "+"
        Me.Btn_Inc.UseVisualStyleBackColor = False
        '
        'Btn_Minus
        '
        Me.Btn_Minus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minus.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Minus.FlatAppearance.BorderSize = 0
        Me.Btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Minus.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Minus.ForeColor = System.Drawing.Color.White
        Me.Btn_Minus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Minus.Location = New System.Drawing.Point(253, 91)
        Me.Btn_Minus.Name = "Btn_Minus"
        Me.Btn_Minus.Size = New System.Drawing.Size(71, 26)
        Me.Btn_Minus.TabIndex = 16
        Me.Btn_Minus.Text = " -"
        Me.Btn_Minus.UseVisualStyleBackColor = False
        '
        'UC_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Cbox_Interval)
        Me.Controls.Add(Me.Btn_Save1)
        Me.Controls.Add(Me.Cbox_Duration)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Minus)
        Me.Controls.Add(Me.Btn_Inc)
        Me.Controls.Add(Me.Btn_AddDuration)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Txtbox_Duration)
        Me.Controls.Add(Me.Txtbox_Fine)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtbox_Epassword)
        Me.Controls.Add(Me.Txtbox_Email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UC_Settings"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtbox_Email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtbox_Fine As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtbox_Epassword As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_Save2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_ShelfNo As Label
    Friend WithEvents Txtbox_Server As TextBox
    Friend WithEvents LABELSDF As Label
    Friend WithEvents Txtbox_Password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FASDF As Label
    Friend WithEvents Txtbox_Username As TextBox
    Friend WithEvents Txtbox_Database As TextBox
    Friend WithEvents Cbox_Duration As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtbox_Duration As TextBox
    Friend WithEvents Btn_AddDuration As Button
    Friend WithEvents Cbox_Interval As ComboBox
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Save1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Btn_Inc As Button
    Friend WithEvents Btn_Minus As Button
End Class

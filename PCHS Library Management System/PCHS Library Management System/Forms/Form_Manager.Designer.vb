<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Manager))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.Picbox_ProfilePic = New System.Windows.Forms.PictureBox()
        Me.Btn_More = New System.Windows.Forms.Button()
        Me.Btn_LogOut = New System.Windows.Forms.Button()
        Me.Panel_MainTaskBar = New System.Windows.Forms.Panel()
        Me.Panel_Highlight = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Borrowed = New System.Windows.Forms.Button()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Btn_Authors = New System.Windows.Forms.Button()
        Me.Btn_Inventory = New System.Windows.Forms.Button()
        Me.Btn_Subjects = New System.Windows.Forms.Button()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Staff = New System.Windows.Forms.Button()
        Me.Btn_BookShowcase = New System.Windows.Forms.Button()
        Me.Btn_Publishers = New System.Windows.Forms.Button()
        Me.Btn_Borrowers = New System.Windows.Forms.Button()
        Me.Panel_More = New System.Windows.Forms.Panel()
        Me.Btn_GenerateReports = New System.Windows.Forms.Button()
        Me.Btn_AccInfo = New System.Windows.Forms.Button()
        Me.UserControl_Reports = New PCHS_Library_Management_System.UC_Reports()
        Me.UserControl_Inventory = New PCHS_Library_Management_System.UC_Inventory()
        Me.UserControl_Borrowed = New PCHS_Library_Management_System.UC_Borrowed()
        Me.UserControl_ShowCase = New PCHS_Library_Management_System.UC_ShowCase()
        Me.UserControl_Staff = New PCHS_Library_Management_System.UC_Staff()
        Me.UserControl_Authors = New PCHS_Library_Management_System.UC_Authors()
        Me.UserControl_Publisher = New PCHS_Library_Management_System.UC_Publishers()
        Me.UserControl_Subjects = New PCHS_Library_Management_System.UC_Subjects()
        Me.UserControl_Settings = New PCHS_Library_Management_System.UC_Settings()
        Me.UserControl_Borrowers = New PCHS_Library_Management_System.UC_Borrowers()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picbox_ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MainTaskBar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel_More.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Lbl_Type)
        Me.Panel1.Controls.Add(Me.Lbl_Name)
        Me.Panel1.Controls.Add(Me.Picbox_ProfilePic)
        Me.Panel1.Controls.Add(Me.Btn_More)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 56)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 56)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.PCHS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PCHS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Manager"
        '
        'Lbl_Type
        '
        Me.Lbl_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Type.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Type.Location = New System.Drawing.Point(687, 27)
        Me.Lbl_Type.MaximumSize = New System.Drawing.Size(236, 17)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_Type.Size = New System.Drawing.Size(236, 17)
        Me.Lbl_Type.TabIndex = 7
        Me.Lbl_Type.Text = "Admin"
        '
        'Lbl_Name
        '
        Me.Lbl_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Name.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Name.Location = New System.Drawing.Point(687, 7)
        Me.Lbl_Name.MaximumSize = New System.Drawing.Size(236, 17)
        Me.Lbl_Name.Name = "Lbl_Name"
        Me.Lbl_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_Name.Size = New System.Drawing.Size(236, 17)
        Me.Lbl_Name.TabIndex = 7
        Me.Lbl_Name.Text = "Benz Walter Jacques Tan"
        '
        'Picbox_ProfilePic
        '
        Me.Picbox_ProfilePic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picbox_ProfilePic.Location = New System.Drawing.Point(929, 7)
        Me.Picbox_ProfilePic.Name = "Picbox_ProfilePic"
        Me.Picbox_ProfilePic.Size = New System.Drawing.Size(40, 40)
        Me.Picbox_ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picbox_ProfilePic.TabIndex = 6
        Me.Picbox_ProfilePic.TabStop = False
        '
        'Btn_More
        '
        Me.Btn_More.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_More.BackColor = System.Drawing.Color.Transparent
        Me.Btn_More.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Down
        Me.Btn_More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_More.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_More.FlatAppearance.BorderSize = 0
        Me.Btn_More.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_More.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_More.ForeColor = System.Drawing.Color.White
        Me.Btn_More.Location = New System.Drawing.Point(979, 17)
        Me.Btn_More.Name = "Btn_More"
        Me.Btn_More.Size = New System.Drawing.Size(20, 20)
        Me.Btn_More.TabIndex = 3
        Me.Btn_More.UseVisualStyleBackColor = False
        '
        'Btn_LogOut
        '
        Me.Btn_LogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_LogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_LogOut.FlatAppearance.BorderSize = 0
        Me.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LogOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_LogOut.ForeColor = System.Drawing.Color.White
        Me.Btn_LogOut.Location = New System.Drawing.Point(0, 59)
        Me.Btn_LogOut.Name = "Btn_LogOut"
        Me.Btn_LogOut.Size = New System.Drawing.Size(200, 29)
        Me.Btn_LogOut.TabIndex = 3
        Me.Btn_LogOut.Text = "Logout"
        Me.Btn_LogOut.UseVisualStyleBackColor = False
        '
        'Panel_MainTaskBar
        '
        Me.Panel_MainTaskBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_MainTaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel_MainTaskBar.Controls.Add(Me.Panel_Highlight)
        Me.Panel_MainTaskBar.Controls.Add(Me.Panel4)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Borrowed)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Dashboard)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Authors)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Inventory)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Subjects)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Settings)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Staff)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_BookShowcase)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Publishers)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Borrowers)
        Me.Panel_MainTaskBar.Location = New System.Drawing.Point(0, 55)
        Me.Panel_MainTaskBar.Name = "Panel_MainTaskBar"
        Me.Panel_MainTaskBar.Size = New System.Drawing.Size(204, 508)
        Me.Panel_MainTaskBar.TabIndex = 1
        '
        'Panel_Highlight
        '
        Me.Panel_Highlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel_Highlight.Location = New System.Drawing.Point(-3, 13)
        Me.Panel_Highlight.Name = "Panel_Highlight"
        Me.Panel_Highlight.Size = New System.Drawing.Size(10, 46)
        Me.Panel_Highlight.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(-3, 472)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(207, 36)
        Me.Panel4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pangantucan Community High School"
        '
        'Btn_Borrowed
        '
        Me.Btn_Borrowed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Borrowed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Borrowed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Borrowed.FlatAppearance.BorderSize = 0
        Me.Btn_Borrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Borrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Borrowed.ForeColor = System.Drawing.Color.White
        Me.Btn_Borrowed.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Borrow
        Me.Btn_Borrowed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrowed.Location = New System.Drawing.Point(8, 105)
        Me.Btn_Borrowed.Name = "Btn_Borrowed"
        Me.Btn_Borrowed.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Borrowed.TabIndex = 5
        Me.Btn_Borrowed.Text = "     Borrows"
        Me.Btn_Borrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrowed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Borrowed.UseVisualStyleBackColor = False
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Dashboard.FlatAppearance.BorderSize = 0
        Me.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Dashboard.ForeColor = System.Drawing.Color.White
        Me.Btn_Dashboard.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_DashBoard
        Me.Btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Dashboard.Location = New System.Drawing.Point(8, 13)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Dashboard.TabIndex = 4
        Me.Btn_Dashboard.Text = "     Dashboard"
        Me.Btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Btn_Authors
        '
        Me.Btn_Authors.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Authors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Authors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Authors.FlatAppearance.BorderSize = 0
        Me.Btn_Authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Authors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Authors.ForeColor = System.Drawing.Color.White
        Me.Btn_Authors.Image = CType(resources.GetObject("Btn_Authors.Image"), System.Drawing.Image)
        Me.Btn_Authors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Authors.Location = New System.Drawing.Point(8, 197)
        Me.Btn_Authors.Name = "Btn_Authors"
        Me.Btn_Authors.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Authors.TabIndex = 4
        Me.Btn_Authors.Text = "     Authors"
        Me.Btn_Authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Authors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Authors.UseVisualStyleBackColor = False
        '
        'Btn_Inventory
        '
        Me.Btn_Inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Inventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Inventory.FlatAppearance.BorderSize = 0
        Me.Btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Inventory.ForeColor = System.Drawing.Color.White
        Me.Btn_Inventory.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Inventory
        Me.Btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventory.Location = New System.Drawing.Point(8, 151)
        Me.Btn_Inventory.Name = "Btn_Inventory"
        Me.Btn_Inventory.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Inventory.TabIndex = 4
        Me.Btn_Inventory.Text = "     Inventory"
        Me.Btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Inventory.UseVisualStyleBackColor = False
        '
        'Btn_Subjects
        '
        Me.Btn_Subjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Subjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Subjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Subjects.FlatAppearance.BorderSize = 0
        Me.Btn_Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Subjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Subjects.ForeColor = System.Drawing.Color.White
        Me.Btn_Subjects.Image = CType(resources.GetObject("Btn_Subjects.Image"), System.Drawing.Image)
        Me.Btn_Subjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Subjects.Location = New System.Drawing.Point(8, 243)
        Me.Btn_Subjects.Name = "Btn_Subjects"
        Me.Btn_Subjects.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Subjects.TabIndex = 4
        Me.Btn_Subjects.Text = "     Subjects"
        Me.Btn_Subjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Subjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Subjects.UseVisualStyleBackColor = False
        '
        'Btn_Settings
        '
        Me.Btn_Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Settings.FlatAppearance.BorderSize = 0
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Settings.ForeColor = System.Drawing.Color.White
        Me.Btn_Settings.Image = CType(resources.GetObject("Btn_Settings.Image"), System.Drawing.Image)
        Me.Btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Settings.Location = New System.Drawing.Point(8, 427)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Settings.TabIndex = 4
        Me.Btn_Settings.Text = "     Settings"
        Me.Btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Settings.UseVisualStyleBackColor = False
        '
        'Btn_Staff
        '
        Me.Btn_Staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Staff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Staff.FlatAppearance.BorderSize = 0
        Me.Btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Staff.ForeColor = System.Drawing.Color.White
        Me.Btn_Staff.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Accounts
        Me.Btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Staff.Location = New System.Drawing.Point(8, 381)
        Me.Btn_Staff.Name = "Btn_Staff"
        Me.Btn_Staff.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Staff.TabIndex = 4
        Me.Btn_Staff.Text = "     Staff"
        Me.Btn_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Staff.UseVisualStyleBackColor = False
        '
        'Btn_BookShowcase
        '
        Me.Btn_BookShowcase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_BookShowcase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BookShowcase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_BookShowcase.FlatAppearance.BorderSize = 0
        Me.Btn_BookShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BookShowcase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BookShowcase.ForeColor = System.Drawing.Color.White
        Me.Btn_BookShowcase.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icons_Books
        Me.Btn_BookShowcase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BookShowcase.Location = New System.Drawing.Point(8, 59)
        Me.Btn_BookShowcase.Name = "Btn_BookShowcase"
        Me.Btn_BookShowcase.Size = New System.Drawing.Size(196, 46)
        Me.Btn_BookShowcase.TabIndex = 3
        Me.Btn_BookShowcase.Text = "     Books Showcase"
        Me.Btn_BookShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BookShowcase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_BookShowcase.UseVisualStyleBackColor = False
        '
        'Btn_Publishers
        '
        Me.Btn_Publishers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Publishers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Publishers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Publishers.FlatAppearance.BorderSize = 0
        Me.Btn_Publishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Publishers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Publishers.ForeColor = System.Drawing.Color.White
        Me.Btn_Publishers.Image = CType(resources.GetObject("Btn_Publishers.Image"), System.Drawing.Image)
        Me.Btn_Publishers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Publishers.Location = New System.Drawing.Point(8, 289)
        Me.Btn_Publishers.Name = "Btn_Publishers"
        Me.Btn_Publishers.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Publishers.TabIndex = 4
        Me.Btn_Publishers.Text = "     Publishers"
        Me.Btn_Publishers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Publishers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Publishers.UseVisualStyleBackColor = False
        '
        'Btn_Borrowers
        '
        Me.Btn_Borrowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Borrowers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Borrowers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Borrowers.FlatAppearance.BorderSize = 0
        Me.Btn_Borrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Borrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Borrowers.ForeColor = System.Drawing.Color.White
        Me.Btn_Borrowers.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Borrowersss
        Me.Btn_Borrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrowers.Location = New System.Drawing.Point(8, 335)
        Me.Btn_Borrowers.Name = "Btn_Borrowers"
        Me.Btn_Borrowers.Size = New System.Drawing.Size(196, 46)
        Me.Btn_Borrowers.TabIndex = 4
        Me.Btn_Borrowers.Text = "     Borrowers"
        Me.Btn_Borrowers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Borrowers.UseVisualStyleBackColor = False
        '
        'Panel_More
        '
        Me.Panel_More.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_More.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel_More.Controls.Add(Me.Btn_GenerateReports)
        Me.Panel_More.Controls.Add(Me.Btn_AccInfo)
        Me.Panel_More.Controls.Add(Me.Btn_LogOut)
        Me.Panel_More.Location = New System.Drawing.Point(809, 55)
        Me.Panel_More.Name = "Panel_More"
        Me.Panel_More.Size = New System.Drawing.Size(200, 94)
        Me.Panel_More.TabIndex = 13
        Me.Panel_More.Visible = False
        '
        'Btn_GenerateReports
        '
        Me.Btn_GenerateReports.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_GenerateReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_GenerateReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_GenerateReports.FlatAppearance.BorderSize = 0
        Me.Btn_GenerateReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GenerateReports.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GenerateReports.ForeColor = System.Drawing.Color.White
        Me.Btn_GenerateReports.Location = New System.Drawing.Point(0, 0)
        Me.Btn_GenerateReports.Name = "Btn_GenerateReports"
        Me.Btn_GenerateReports.Size = New System.Drawing.Size(200, 29)
        Me.Btn_GenerateReports.TabIndex = 3
        Me.Btn_GenerateReports.Text = "Generate Reports"
        Me.Btn_GenerateReports.UseVisualStyleBackColor = False
        '
        'Btn_AccInfo
        '
        Me.Btn_AccInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AccInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_AccInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AccInfo.FlatAppearance.BorderSize = 0
        Me.Btn_AccInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AccInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AccInfo.ForeColor = System.Drawing.Color.White
        Me.Btn_AccInfo.Location = New System.Drawing.Point(0, 30)
        Me.Btn_AccInfo.Name = "Btn_AccInfo"
        Me.Btn_AccInfo.Size = New System.Drawing.Size(200, 29)
        Me.Btn_AccInfo.TabIndex = 3
        Me.Btn_AccInfo.Text = "Account Information"
        Me.Btn_AccInfo.UseVisualStyleBackColor = False
        '
        'UserControl_Reports
        '
        Me.UserControl_Reports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Reports.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Reports.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Reports.Name = "UserControl_Reports"
        Me.UserControl_Reports.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Reports.TabIndex = 6
        '
        'UserControl_Inventory
        '
        Me.UserControl_Inventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Inventory.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Inventory.Name = "UserControl_Inventory"
        Me.UserControl_Inventory.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Inventory.TabIndex = 4
        '
        'UserControl_Borrowed
        '
        Me.UserControl_Borrowed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Borrowed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Borrowed.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Borrowed.Name = "UserControl_Borrowed"
        Me.UserControl_Borrowed.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Borrowed.TabIndex = 5
        '
        'UserControl_ShowCase
        '
        Me.UserControl_ShowCase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_ShowCase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_ShowCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserControl_ShowCase.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_ShowCase.Name = "UserControl_ShowCase"
        Me.UserControl_ShowCase.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_ShowCase.TabIndex = 3
        '
        'UserControl_Staff
        '
        Me.UserControl_Staff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Staff.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Staff.Name = "UserControl_Staff"
        Me.UserControl_Staff.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Staff.TabIndex = 7
        '
        'UserControl_Authors
        '
        Me.UserControl_Authors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Authors.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Authors.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Authors.Name = "UserControl_Authors"
        Me.UserControl_Authors.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Authors.TabIndex = 8
        '
        'UserControl_Publisher
        '
        Me.UserControl_Publisher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Publisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Publisher.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Publisher.Name = "UserControl_Publisher"
        Me.UserControl_Publisher.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Publisher.TabIndex = 9
        '
        'UserControl_Subjects
        '
        Me.UserControl_Subjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Subjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Subjects.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Subjects.Name = "UserControl_Subjects"
        Me.UserControl_Subjects.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Subjects.TabIndex = 10
        '
        'UserControl_Settings
        '
        Me.UserControl_Settings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Settings.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Settings.Name = "UserControl_Settings"
        Me.UserControl_Settings.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Settings.TabIndex = 11
        '
        'UserControl_Borrowers
        '
        Me.UserControl_Borrowers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Borrowers.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Borrowers.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Borrowers.Name = "UserControl_Borrowers"
        Me.UserControl_Borrowers.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Borrowers.TabIndex = 12
        '
        'Form_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.Panel_More)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_MainTaskBar)
        Me.Controls.Add(Me.UserControl_Reports)
        Me.Controls.Add(Me.UserControl_Inventory)
        Me.Controls.Add(Me.UserControl_Borrowed)
        Me.Controls.Add(Me.UserControl_ShowCase)
        Me.Controls.Add(Me.UserControl_Staff)
        Me.Controls.Add(Me.UserControl_Authors)
        Me.Controls.Add(Me.UserControl_Publisher)
        Me.Controls.Add(Me.UserControl_Subjects)
        Me.Controls.Add(Me.UserControl_Settings)
        Me.Controls.Add(Me.UserControl_Borrowers)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCHS Library Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picbox_ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MainTaskBar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel_More.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_MainTaskBar As Panel
    Friend WithEvents Btn_BookShowcase As Button
    Friend WithEvents Btn_Staff As Button
    Friend WithEvents Btn_Borrowed As Button
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Btn_Inventory As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_LogOut As Button
    Friend WithEvents Panel_Highlight As Panel
    Friend WithEvents UserControl_ShowCase As UC_ShowCase
    Friend WithEvents UserControl_Inventory As UC_Inventory
    Friend WithEvents UserControl_Borrowed As UC_Borrowed
    Friend WithEvents UserControl_Reports As UC_Reports
    Friend WithEvents UserControl_Staff As UC_Staff
    Friend WithEvents Lbl_Type As Label
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Picbox_ProfilePic As PictureBox
    Friend WithEvents Btn_More As Button
    Friend WithEvents Btn_Publishers As Button
    Friend WithEvents Btn_Authors As Button
    Friend WithEvents UserControl_Authors As UC_Authors
    Friend WithEvents UserControl_Publisher As UC_Publishers
    Friend WithEvents Btn_Subjects As Button
    Friend WithEvents UserControl_Subjects As UC_Subjects
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents UserControl_Settings As UC_Settings
    Friend WithEvents UserControl_Borrowers As UC_Borrowers
    Friend WithEvents Btn_Borrowers As Button
    Friend WithEvents Panel_More As Panel
    Friend WithEvents Btn_GenerateReports As Button
    Friend WithEvents Btn_AccInfo As Button
End Class

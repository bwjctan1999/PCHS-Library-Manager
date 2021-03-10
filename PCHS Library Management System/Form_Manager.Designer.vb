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
        Me.Btn_LogOut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MainTaskBar = New System.Windows.Forms.Panel()
        Me.Panel_Highlight = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Borrowed = New System.Windows.Forms.Button()
        Me.Btn_Staffs = New System.Windows.Forms.Button()
        Me.Btn_Inventory = New System.Windows.Forms.Button()
        Me.Btn_Suppliers = New System.Windows.Forms.Button()
        Me.Btn_BookShowcase = New System.Windows.Forms.Button()
        Me.Btn_Borrows = New System.Windows.Forms.Button()
        Me.UserControl_Reports = New PCHS_Library_Management_System.UC_Reports()
        Me.UserControl_Inventory = New PCHS_Library_Management_System.UC_Inventory()
        Me.UserControl_Borrowed = New PCHS_Library_Management_System.UC_Borrowed()
        Me.UserControl_ShowCase = New PCHS_Library_Management_System.UC_ShowCase()
        Me.UserControl_Borrows = New PCHS_Library_Management_System.UC_Borrows()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel_MainTaskBar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Btn_LogOut)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 56)
        Me.Panel1.TabIndex = 0
        '
        'Btn_LogOut
        '
        Me.Btn_LogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_LogOut.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_LogOut.FlatAppearance.BorderSize = 0
        Me.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LogOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_LogOut.ForeColor = System.Drawing.Color.White
        Me.Btn_LogOut.Location = New System.Drawing.Point(922, 13)
        Me.Btn_LogOut.Name = "Btn_LogOut"
        Me.Btn_LogOut.Size = New System.Drawing.Size(75, 29)
        Me.Btn_LogOut.TabIndex = 3
        Me.Btn_LogOut.Text = "Logout"
        Me.Btn_LogOut.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 56)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PCHS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Manager"
        '
        'Panel_MainTaskBar
        '
        Me.Panel_MainTaskBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_MainTaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel_MainTaskBar.Controls.Add(Me.Panel_Highlight)
        Me.Panel_MainTaskBar.Controls.Add(Me.Panel4)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Borrowed)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Staffs)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Inventory)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Suppliers)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_BookShowcase)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Borrows)
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
        Me.Panel4.Location = New System.Drawing.Point(-3, 455)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(207, 53)
        Me.Panel4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pangantucan Community High School"
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
        'Btn_Borrowed
        '
        Me.Btn_Borrowed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Borrowed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Borrowed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Borrowed.FlatAppearance.BorderSize = 0
        Me.Btn_Borrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Borrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Borrowed.ForeColor = System.Drawing.Color.White
        Me.Btn_Borrowed.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Supplier
        Me.Btn_Borrowed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrowed.Location = New System.Drawing.Point(6, 105)
        Me.Btn_Borrowed.Name = "Btn_Borrowed"
        Me.Btn_Borrowed.Size = New System.Drawing.Size(198, 46)
        Me.Btn_Borrowed.TabIndex = 5
        Me.Btn_Borrowed.Text = "     Borrowed"
        Me.Btn_Borrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrowed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Borrowed.UseVisualStyleBackColor = False
        '
        'Btn_Staffs
        '
        Me.Btn_Staffs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Staffs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Staffs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Staffs.FlatAppearance.BorderSize = 0
        Me.Btn_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Staffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Staffs.ForeColor = System.Drawing.Color.White
        Me.Btn_Staffs.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Staff
        Me.Btn_Staffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Staffs.Location = New System.Drawing.Point(6, 197)
        Me.Btn_Staffs.Name = "Btn_Staffs"
        Me.Btn_Staffs.Size = New System.Drawing.Size(198, 46)
        Me.Btn_Staffs.TabIndex = 4
        Me.Btn_Staffs.Text = "     Staffs"
        Me.Btn_Staffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Staffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Staffs.UseVisualStyleBackColor = False
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
        Me.Btn_Inventory.Location = New System.Drawing.Point(6, 151)
        Me.Btn_Inventory.Name = "Btn_Inventory"
        Me.Btn_Inventory.Size = New System.Drawing.Size(198, 46)
        Me.Btn_Inventory.TabIndex = 4
        Me.Btn_Inventory.Text = "     Inventory"
        Me.Btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Inventory.UseVisualStyleBackColor = False
        '
        'Btn_Suppliers
        '
        Me.Btn_Suppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Suppliers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Suppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Suppliers.FlatAppearance.BorderSize = 0
        Me.Btn_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Suppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Suppliers.ForeColor = System.Drawing.Color.White
        Me.Btn_Suppliers.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Accounts
        Me.Btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Suppliers.Location = New System.Drawing.Point(6, 243)
        Me.Btn_Suppliers.Name = "Btn_Suppliers"
        Me.Btn_Suppliers.Size = New System.Drawing.Size(198, 46)
        Me.Btn_Suppliers.TabIndex = 4
        Me.Btn_Suppliers.Text = "     Something"
        Me.Btn_Suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Suppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Suppliers.UseVisualStyleBackColor = False
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
        Me.Btn_BookShowcase.Location = New System.Drawing.Point(6, 13)
        Me.Btn_BookShowcase.Name = "Btn_BookShowcase"
        Me.Btn_BookShowcase.Size = New System.Drawing.Size(198, 46)
        Me.Btn_BookShowcase.TabIndex = 3
        Me.Btn_BookShowcase.Text = "     Books Showcase"
        Me.Btn_BookShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BookShowcase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_BookShowcase.UseVisualStyleBackColor = False
        '
        'Btn_Borrows
        '
        Me.Btn_Borrows.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Borrows.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Borrows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Borrows.FlatAppearance.BorderSize = 0
        Me.Btn_Borrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Borrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Borrows.ForeColor = System.Drawing.Color.White
        Me.Btn_Borrows.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Borrow
        Me.Btn_Borrows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrows.Location = New System.Drawing.Point(6, 59)
        Me.Btn_Borrows.Name = "Btn_Borrows"
        Me.Btn_Borrows.Size = New System.Drawing.Size(198, 46)
        Me.Btn_Borrows.TabIndex = 2
        Me.Btn_Borrows.Text = "     Borrows"
        Me.Btn_Borrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Borrows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Borrows.UseVisualStyleBackColor = False
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
        'UserControl_Borrows
        '
        Me.UserControl_Borrows.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_Borrows.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UserControl_Borrows.Location = New System.Drawing.Point(205, 55)
        Me.UserControl_Borrows.Name = "UserControl_Borrows"
        Me.UserControl_Borrows.Size = New System.Drawing.Size(804, 508)
        Me.UserControl_Borrows.TabIndex = 2
        '
        'Form_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.UserControl_Reports)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_MainTaskBar)
        Me.Controls.Add(Me.UserControl_Inventory)
        Me.Controls.Add(Me.UserControl_Borrowed)
        Me.Controls.Add(Me.UserControl_ShowCase)
        Me.Controls.Add(Me.UserControl_Borrows)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCHS Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel_MainTaskBar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_MainTaskBar As Panel
    Friend WithEvents Btn_Borrows As Button
    Friend WithEvents Btn_BookShowcase As Button
    Friend WithEvents Btn_Suppliers As Button
    Friend WithEvents Btn_Borrowed As Button
    Friend WithEvents Btn_Staffs As Button
    Friend WithEvents Btn_Inventory As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UserControl_Borrows As UC_Borrows
    Friend WithEvents Btn_LogOut As Button
    Friend WithEvents Panel_Highlight As Panel
    Friend WithEvents UserControl_ShowCase As UC_ShowCase
    Friend WithEvents UserControl_Inventory As UC_Inventory
    Friend WithEvents UserControl_Borrowed As UC_Borrowed
    Friend WithEvents UserControl_Reports As UC_Reports
End Class

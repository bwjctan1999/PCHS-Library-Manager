<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MainTaskBar = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Inventory = New System.Windows.Forms.Button()
        Me.Btn_Staffs = New System.Windows.Forms.Button()
        Me.Btn_Students = New System.Windows.Forms.Button()
        Me.Btn_Suppliers = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Books = New System.Windows.Forms.Button()
        Me.UC_Books = New PCHS_Library_Management_System.UserControl_Books()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MainTaskBar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 56)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 56)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Library
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PCHS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Manager"
        '
        'Panel_MainTaskBar
        '
        Me.Panel_MainTaskBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_MainTaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_MainTaskBar.Controls.Add(Me.Panel4)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Inventory)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Staffs)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Students)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Suppliers)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Search)
        Me.Panel_MainTaskBar.Controls.Add(Me.Btn_Books)
        Me.Panel_MainTaskBar.Location = New System.Drawing.Point(0, 55)
        Me.Panel_MainTaskBar.Name = "Panel_MainTaskBar"
        Me.Panel_MainTaskBar.Size = New System.Drawing.Size(204, 508)
        Me.Panel_MainTaskBar.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer))
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
        'Btn_Inventory
        '
        Me.Btn_Inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Inventory.FlatAppearance.BorderSize = 0
        Me.Btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Inventory.ForeColor = System.Drawing.Color.White
        Me.Btn_Inventory.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Inventory
        Me.Btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventory.Location = New System.Drawing.Point(0, 105)
        Me.Btn_Inventory.Name = "Btn_Inventory"
        Me.Btn_Inventory.Size = New System.Drawing.Size(204, 40)
        Me.Btn_Inventory.TabIndex = 5
        Me.Btn_Inventory.Text = "     Inventory"
        Me.Btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Inventory.UseVisualStyleBackColor = False
        '
        'Btn_Staffs
        '
        Me.Btn_Staffs.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Staffs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Staffs.FlatAppearance.BorderSize = 0
        Me.Btn_Staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Staffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Staffs.ForeColor = System.Drawing.Color.White
        Me.Btn_Staffs.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Staff
        Me.Btn_Staffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Staffs.Location = New System.Drawing.Point(0, 197)
        Me.Btn_Staffs.Name = "Btn_Staffs"
        Me.Btn_Staffs.Size = New System.Drawing.Size(204, 40)
        Me.Btn_Staffs.TabIndex = 4
        Me.Btn_Staffs.Text = "     Staffs"
        Me.Btn_Staffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Staffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Staffs.UseVisualStyleBackColor = False
        '
        'Btn_Students
        '
        Me.Btn_Students.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Students.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Students.FlatAppearance.BorderSize = 0
        Me.Btn_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Students.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Students.ForeColor = System.Drawing.Color.White
        Me.Btn_Students.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Accounts
        Me.Btn_Students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Students.Location = New System.Drawing.Point(0, 151)
        Me.Btn_Students.Name = "Btn_Students"
        Me.Btn_Students.Size = New System.Drawing.Size(204, 40)
        Me.Btn_Students.TabIndex = 4
        Me.Btn_Students.Text = "     Students"
        Me.Btn_Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Students.UseVisualStyleBackColor = False
        '
        'Btn_Suppliers
        '
        Me.Btn_Suppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Suppliers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Suppliers.FlatAppearance.BorderSize = 0
        Me.Btn_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Suppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Suppliers.ForeColor = System.Drawing.Color.White
        Me.Btn_Suppliers.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Supplier
        Me.Btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Suppliers.Location = New System.Drawing.Point(0, 243)
        Me.Btn_Suppliers.Name = "Btn_Suppliers"
        Me.Btn_Suppliers.Size = New System.Drawing.Size(204, 40)
        Me.Btn_Suppliers.TabIndex = 4
        Me.Btn_Suppliers.Text = "     Suppliers"
        Me.Btn_Suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Suppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Suppliers.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Search.FlatAppearance.BorderSize = 0
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Image = CType(resources.GetObject("Btn_Search.Image"), System.Drawing.Image)
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(0, 13)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(204, 40)
        Me.Btn_Search.TabIndex = 3
        Me.Btn_Search.Text = "     Search"
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Books
        '
        Me.Btn_Books.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btn_Books.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_Books.FlatAppearance.BorderSize = 0
        Me.Btn_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Books.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Btn_Books.ForeColor = System.Drawing.Color.White
        Me.Btn_Books.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icons_Books
        Me.Btn_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Books.Location = New System.Drawing.Point(0, 59)
        Me.Btn_Books.Name = "Btn_Books"
        Me.Btn_Books.Size = New System.Drawing.Size(204, 40)
        Me.Btn_Books.TabIndex = 2
        Me.Btn_Books.Text = "     Books"
        Me.Btn_Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Books.UseVisualStyleBackColor = False
        '
        'UC_Books
        '
        Me.UC_Books.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_Books.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.UC_Books.Location = New System.Drawing.Point(205, 55)
        Me.UC_Books.Name = "UC_Books"
        Me.UC_Books.Size = New System.Drawing.Size(804, 508)
        Me.UC_Books.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.UC_Books)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_MainTaskBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCHS Library Management System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MainTaskBar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_MainTaskBar As Panel
    Friend WithEvents Btn_Books As Button
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Btn_Suppliers As Button
    Friend WithEvents Btn_Inventory As Button
    Friend WithEvents Btn_Staffs As Button
    Friend WithEvents Btn_Students As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UC_Books As UserControl_Books
End Class

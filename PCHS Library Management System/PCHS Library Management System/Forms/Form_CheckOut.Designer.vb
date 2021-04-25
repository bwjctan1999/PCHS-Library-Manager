<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_CheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CheckOut))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtbox_ID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_BorrowDate = New System.Windows.Forms.Label()
        Me.Lbl_DueDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_CheckOut = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_QRReader = New System.Windows.Forms.Button()
        Me.Cbox_Duration = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserControl_BookShelf = New PCHS_Library_Management_System.UC_BookShelf()
        Me.Btn_Select = New System.Windows.Forms.Button()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 49)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Check_Out
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(13, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(63, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHECK OUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Location = New System.Drawing.Point(14, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 2)
        Me.Panel3.TabIndex = 8
        '
        'Txtbox_ID
        '
        Me.Txtbox_ID.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_ID.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Txtbox_ID.Location = New System.Drawing.Point(14, 170)
        Me.Txtbox_ID.Name = "Txtbox_ID"
        Me.Txtbox_ID.Size = New System.Drawing.Size(272, 19)
        Me.Txtbox_ID.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(14, 191)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 2)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student ID / Faculty ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(414, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Duration"
        '
        'Lbl_BorrowDate
        '
        Me.Lbl_BorrowDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BorrowDate.ForeColor = System.Drawing.Color.SeaGreen
        Me.Lbl_BorrowDate.Location = New System.Drawing.Point(526, 93)
        Me.Lbl_BorrowDate.Name = "Lbl_BorrowDate"
        Me.Lbl_BorrowDate.Size = New System.Drawing.Size(96, 21)
        Me.Lbl_BorrowDate.TabIndex = 12
        Me.Lbl_BorrowDate.Text = "03/03/2021"
        Me.Lbl_BorrowDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_DueDate
        '
        Me.Lbl_DueDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DueDate.ForeColor = System.Drawing.Color.Firebrick
        Me.Lbl_DueDate.Location = New System.Drawing.Point(645, 93)
        Me.Lbl_DueDate.Name = "Lbl_DueDate"
        Me.Lbl_DueDate.Size = New System.Drawing.Size(96, 21)
        Me.Lbl_DueDate.TabIndex = 12
        Me.Lbl_DueDate.Text = "10/03/2021"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(527, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Start and Due Date"
        '
        'Lbl_Info
        '
        Me.Lbl_Info.AutoSize = True
        Me.Lbl_Info.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Info.Location = New System.Drawing.Point(413, 152)
        Me.Lbl_Info.MaximumSize = New System.Drawing.Size(293, 85)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(287, 40)
        Me.Lbl_Info.TabIndex = 11
        Me.Lbl_Info.Text = "An amount of 1 peso per hour will be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "charged if you go past your due date." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Cancel.Location = New System.Drawing.Point(390, 433)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Cancel.TabIndex = 14
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_CheckOut
        '
        Me.Btn_CheckOut.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_CheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CheckOut.FlatAppearance.BorderSize = 0
        Me.Btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_CheckOut.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_CheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_CheckOut.Location = New System.Drawing.Point(638, 433)
        Me.Btn_CheckOut.Name = "Btn_CheckOut"
        Me.Btn_CheckOut.Size = New System.Drawing.Size(116, 29)
        Me.Btn_CheckOut.TabIndex = 13
        Me.Btn_CheckOut.Text = "Check Out"
        Me.Btn_CheckOut.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Books to Borrow"
        '
        'Btn_QRReader
        '
        Me.Btn_QRReader.BackColor = System.Drawing.Color.DarkGray
        Me.Btn_QRReader.FlatAppearance.BorderSize = 0
        Me.Btn_QRReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_QRReader.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_QRReader.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_QRReader.Location = New System.Drawing.Point(514, 433)
        Me.Btn_QRReader.Name = "Btn_QRReader"
        Me.Btn_QRReader.Size = New System.Drawing.Size(116, 29)
        Me.Btn_QRReader.TabIndex = 14
        Me.Btn_QRReader.Text = "Add Book"
        Me.Btn_QRReader.UseVisualStyleBackColor = False
        '
        'Cbox_Duration
        '
        Me.Cbox_Duration.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_Duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_Duration.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cbox_Duration.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Cbox_Duration.FormattingEnabled = True
        Me.Cbox_Duration.Items.AddRange(New Object() {"1 - Day", "2 - Days", "3 - Days", "5 - Days", "10 - Days", "1 - Month"})
        Me.Cbox_Duration.Location = New System.Drawing.Point(408, 92)
        Me.Cbox_Duration.Name = "Cbox_Duration"
        Me.Cbox_Duration.Size = New System.Drawing.Size(101, 28)
        Me.Cbox_Duration.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(625, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "-"
        '
        'UserControl_BookShelf
        '
        Me.UserControl_BookShelf.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserControl_BookShelf.Location = New System.Drawing.Point(-1, 254)
        Me.UserControl_BookShelf.Name = "UserControl_BookShelf"
        Me.UserControl_BookShelf.Size = New System.Drawing.Size(775, 160)
        Me.UserControl_BookShelf.TabIndex = 10
        '
        'Btn_Select
        '
        Me.Btn_Select.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Select.FlatAppearance.BorderSize = 0
        Me.Btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Select.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Select.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Select.Location = New System.Drawing.Point(292, 165)
        Me.Btn_Select.Name = "Btn_Select"
        Me.Btn_Select.Size = New System.Drawing.Size(81, 25)
        Me.Btn_Select.TabIndex = 13
        Me.Btn_Select.Text = "Select"
        Me.Btn_Select.UseVisualStyleBackColor = False
        '
        'Lbl_Name
        '
        Me.Lbl_Name.AutoSize = True
        Me.Lbl_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Name.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Name.Location = New System.Drawing.Point(13, 94)
        Me.Lbl_Name.Name = "Lbl_Name"
        Me.Lbl_Name.Size = New System.Drawing.Size(193, 20)
        Me.Lbl_Name.TabIndex = 9
        Me.Lbl_Name.Text = "Please Select A Borrower"
        '
        'Form_CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cbox_Duration)
        Me.Controls.Add(Me.Btn_QRReader)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Select)
        Me.Controls.Add(Me.Btn_CheckOut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lbl_DueDate)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Lbl_BorrowDate)
        Me.Controls.Add(Me.UserControl_BookShelf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtbox_ID)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_CheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCHS Library Manager"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtbox_ID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents UserControl_BookShelf As UC_BookShelf
    Friend WithEvents Label11 As Label
    Friend WithEvents Lbl_BorrowDate As Label
    Friend WithEvents Lbl_DueDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_Info As Label
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_CheckOut As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_QRReader As Button
    Friend WithEvents Cbox_Duration As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Select As Button
    Friend WithEvents Lbl_Name As Label
End Class

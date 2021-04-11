<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Add_Edit_Book
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Add_Edit_Book))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_mode = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtbox_Title = New System.Windows.Forms.TextBox()
        Me.Txtbox_Author = New System.Windows.Forms.TextBox()
        Me.Txtbox_ISBNNo = New System.Windows.Forms.TextBox()
        Me.Txtbox_ShelfNo = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cbox_Subjects = New System.Windows.Forms.ComboBox()
        Me.Btn_AddBook = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Txtbox_Publisher = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Picbox_QRCode = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel_Image = New System.Windows.Forms.Panel()
        Me.Lbl_ChangeImage = New System.Windows.Forms.Label()
        Me.Txtbox_Quantity = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_AddSub = New System.Windows.Forms.Button()
        Me.Btn_UpdateBook = New System.Windows.Forms.Button()
        Me.Txtbox_Subject = New System.Windows.Forms.TextBox()
        Me.Panel_Subject = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.Picbox_QRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel_Image.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lbl_mode)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icons_Addbook
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Lbl_mode
        '
        resources.ApplyResources(Me.Lbl_mode, "Lbl_mode")
        Me.Lbl_mode.ForeColor = System.Drawing.Color.White
        Me.Lbl_mode.Name = "Lbl_mode"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Name = "Label4"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Name = "Label6"
        '
        'Txtbox_Title
        '
        Me.Txtbox_Title.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_Title, "Txtbox_Title")
        Me.Txtbox_Title.Name = "Txtbox_Title"
        '
        'Txtbox_Author
        '
        Me.Txtbox_Author.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Author.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_Author, "Txtbox_Author")
        Me.Txtbox_Author.Name = "Txtbox_Author"
        '
        'Txtbox_ISBNNo
        '
        Me.Txtbox_ISBNNo.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_ISBNNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_ISBNNo, "Txtbox_ISBNNo")
        Me.Txtbox_ISBNNo.Name = "Txtbox_ISBNNo"
        '
        'Txtbox_ShelfNo
        '
        Me.Txtbox_ShelfNo.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_ShelfNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_ShelfNo, "Txtbox_ShelfNo")
        Me.Txtbox_ShelfNo.Name = "Txtbox_ShelfNo"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel9, "Panel9")
        Me.Panel9.Name = "Panel9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Name = "Label8"
        '
        'Cbox_Subjects
        '
        Me.Cbox_Subjects.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_Subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.Cbox_Subjects, "Cbox_Subjects")
        Me.Cbox_Subjects.FormattingEnabled = True
        Me.Cbox_Subjects.Name = "Cbox_Subjects"
        '
        'Btn_AddBook
        '
        Me.Btn_AddBook.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_AddBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddBook.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Btn_AddBook, "Btn_AddBook")
        Me.Btn_AddBook.Name = "Btn_AddBook"
        Me.Btn_AddBook.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Btn_Cancel, "Btn_Cancel")
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Controls.Add(Me.Panel_Subject)
        Me.Panel10.Controls.Add(Me.Txtbox_Subject)
        Me.Panel10.Controls.Add(Me.DatePicker)
        Me.Panel10.Controls.Add(Me.Txtbox_Publisher)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Panel6)
        Me.Panel10.Controls.Add(Me.Txtbox_Quantity)
        Me.Panel10.Controls.Add(Me.Panel1)
        Me.Panel10.Controls.Add(Me.Label9)
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Controls.Add(Me.Btn_Cancel)
        Me.Panel10.Controls.Add(Me.Btn_AddSub)
        Me.Panel10.Controls.Add(Me.Btn_AddBook)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.Cbox_Subjects)
        Me.Panel10.Controls.Add(Me.Panel4)
        Me.Panel10.Controls.Add(Me.Txtbox_ShelfNo)
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.Txtbox_ISBNNo)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.Txtbox_Author)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.Txtbox_Title)
        Me.Panel10.Controls.Add(Me.Btn_UpdateBook)
        resources.ApplyResources(Me.Panel10, "Panel10")
        Me.Panel10.Name = "Panel10"
        '
        'DatePicker
        '
        resources.ApplyResources(Me.DatePicker, "DatePicker")
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker.Name = "DatePicker"
        '
        'Txtbox_Publisher
        '
        Me.Txtbox_Publisher.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Publisher.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_Publisher, "Txtbox_Publisher")
        Me.Txtbox_Publisher.Name = "Txtbox_Publisher"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Name = "Label1"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.Name = "Panel12"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel11.Controls.Add(Me.Picbox_QRCode)
        resources.ApplyResources(Me.Panel11, "Panel11")
        Me.Panel11.Name = "Panel11"
        '
        'Picbox_QRCode
        '
        Me.Picbox_QRCode.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Picbox_QRCode, "Picbox_QRCode")
        Me.Picbox_QRCode.Name = "Picbox_QRCode"
        Me.Picbox_QRCode.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel6.Controls.Add(Me.Panel_Image)
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
        '
        'Panel_Image
        '
        Me.Panel_Image.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Image.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Screenshot_3
        resources.ApplyResources(Me.Panel_Image, "Panel_Image")
        Me.Panel_Image.Controls.Add(Me.Lbl_ChangeImage)
        Me.Panel_Image.Name = "Panel_Image"
        '
        'Lbl_ChangeImage
        '
        Me.Lbl_ChangeImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_ChangeImage.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Lbl_ChangeImage, "Lbl_ChangeImage")
        Me.Lbl_ChangeImage.ForeColor = System.Drawing.Color.White
        Me.Lbl_ChangeImage.Name = "Lbl_ChangeImage"
        '
        'Txtbox_Quantity
        '
        Me.Txtbox_Quantity.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_Quantity, "Txtbox_Quantity")
        Me.Txtbox_Quantity.Name = "Txtbox_Quantity"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Name = "Label9"
        '
        'Btn_AddSub
        '
        Me.Btn_AddSub.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_AddSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        resources.ApplyResources(Me.Btn_AddSub, "Btn_AddSub")
        Me.Btn_AddSub.ForeColor = System.Drawing.Color.Black
        Me.Btn_AddSub.Name = "Btn_AddSub"
        Me.Btn_AddSub.UseVisualStyleBackColor = False
        '
        'Btn_UpdateBook
        '
        Me.Btn_UpdateBook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_UpdateBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_UpdateBook.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Btn_UpdateBook, "Btn_UpdateBook")
        Me.Btn_UpdateBook.Name = "Btn_UpdateBook"
        Me.Btn_UpdateBook.UseVisualStyleBackColor = False
        '
        'Txtbox_Subject
        '
        Me.Txtbox_Subject.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Subject.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Txtbox_Subject, "Txtbox_Subject")
        Me.Txtbox_Subject.Name = "Txtbox_Subject"
        '
        'Panel_Subject
        '
        Me.Panel_Subject.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.Panel_Subject, "Panel_Subject")
        Me.Panel_Subject.Name = "Panel_Subject"
        '
        'Form_Add_Edit_Book
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Add_Edit_Book"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        CType(Me.Picbox_QRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel_Image.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_mode As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtbox_Title As TextBox
    Friend WithEvents Txtbox_Author As TextBox
    Friend WithEvents Txtbox_ISBNNo As TextBox
    Friend WithEvents Txtbox_ShelfNo As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Cbox_Subjects As ComboBox
    Friend WithEvents Btn_AddBook As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txtbox_Quantity As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel_Image As Panel
    Friend WithEvents Lbl_ChangeImage As Label
    Friend WithEvents Btn_UpdateBook As Button
    Friend WithEvents Picbox_QRCode As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Txtbox_Publisher As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents Btn_AddSub As Button
    Friend WithEvents Panel_Subject As Panel
    Friend WithEvents Txtbox_Subject As TextBox
End Class

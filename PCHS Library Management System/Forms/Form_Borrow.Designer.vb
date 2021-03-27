<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Borrow
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
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Picbox_Cover = New System.Windows.Forms.PictureBox()
        Me.Btn_Borrow = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Lbl_Author = New System.Windows.Forms.Label()
        Me.Lbl_Category = New System.Windows.Forms.Label()
        Me.Lbl_ShelveNo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_YearPub = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_ISBNNo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_CodeNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Picbox_Cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Lbl_Title.Location = New System.Drawing.Point(299, 55)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(245, 32)
        Me.Lbl_Title.TabIndex = 0
        Me.Lbl_Title.Text = "The Great Gatsby"
        '
        'Picbox_Cover
        '
        Me.Picbox_Cover.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.BOOK_2
        Me.Picbox_Cover.Location = New System.Drawing.Point(12, 55)
        Me.Picbox_Cover.Name = "Picbox_Cover"
        Me.Picbox_Cover.Size = New System.Drawing.Size(269, 327)
        Me.Picbox_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picbox_Cover.TabIndex = 1
        Me.Picbox_Cover.TabStop = False
        '
        'Btn_Borrow
        '
        Me.Btn_Borrow.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Borrow.FlatAppearance.BorderSize = 0
        Me.Btn_Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Borrow.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Borrow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Borrow.Location = New System.Drawing.Point(658, 394)
        Me.Btn_Borrow.Name = "Btn_Borrow"
        Me.Btn_Borrow.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Borrow.TabIndex = 8
        Me.Btn_Borrow.Text = "Borrow"
        Me.Btn_Borrow.UseVisualStyleBackColor = False
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Close.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Close.Location = New System.Drawing.Point(527, 394)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Close.TabIndex = 9
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Lbl_Author
        '
        Me.Lbl_Author.AutoSize = True
        Me.Lbl_Author.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Author.ForeColor = System.Drawing.Color.Olive
        Me.Lbl_Author.Location = New System.Drawing.Point(338, 87)
        Me.Lbl_Author.Name = "Lbl_Author"
        Me.Lbl_Author.Size = New System.Drawing.Size(185, 24)
        Me.Lbl_Author.TabIndex = 0
        Me.Lbl_Author.Text = "F. Scott Fitzgerald"
        '
        'Lbl_Category
        '
        Me.Lbl_Category.AutoSize = True
        Me.Lbl_Category.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Category.Location = New System.Drawing.Point(440, 172)
        Me.Lbl_Category.Name = "Lbl_Category"
        Me.Lbl_Category.Size = New System.Drawing.Size(95, 23)
        Me.Lbl_Category.TabIndex = 0
        Me.Lbl_Category.Text = "Literature"
        '
        'Lbl_ShelveNo
        '
        Me.Lbl_ShelveNo.AutoSize = True
        Me.Lbl_ShelveNo.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ShelveNo.ForeColor = System.Drawing.Color.White
        Me.Lbl_ShelveNo.Location = New System.Drawing.Point(30, 35)
        Me.Lbl_ShelveNo.Name = "Lbl_ShelveNo"
        Me.Lbl_ShelveNo.Size = New System.Drawing.Size(105, 77)
        Me.Lbl_ShelveNo.TabIndex = 0
        Me.Lbl_ShelveNo.Text = "04"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(301, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "by"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(301, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Category:"
        '
        'Lbl_YearPub
        '
        Me.Lbl_YearPub.AutoSize = True
        Me.Lbl_YearPub.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_YearPub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_YearPub.Location = New System.Drawing.Point(440, 201)
        Me.Lbl_YearPub.Name = "Lbl_YearPub"
        Me.Lbl_YearPub.Size = New System.Drawing.Size(105, 23)
        Me.Lbl_YearPub.TabIndex = 0
        Me.Lbl_YearPub.Text = "10/4/1925"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(301, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Year Published:"
        '
        'Lbl_ISBNNo
        '
        Me.Lbl_ISBNNo.AutoSize = True
        Me.Lbl_ISBNNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ISBNNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_ISBNNo.Location = New System.Drawing.Point(440, 232)
        Me.Lbl_ISBNNo.Name = "Lbl_ISBNNo"
        Me.Lbl_ISBNNo.Size = New System.Drawing.Size(185, 23)
        Me.Lbl_ISBNNo.TabIndex = 0
        Me.Lbl_ISBNNo.Text = "978-3-16-148410-0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Shelf Number:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lbl_ShelveNo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(650, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 133)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_CodeNo
        '
        Me.Lbl_CodeNo.AutoSize = True
        Me.Lbl_CodeNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CodeNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_CodeNo.Location = New System.Drawing.Point(440, 264)
        Me.Lbl_CodeNo.Name = "Lbl_CodeNo"
        Me.Lbl_CodeNo.Size = New System.Drawing.Size(32, 23)
        Me.Lbl_CodeNo.TabIndex = 0
        Me.Lbl_CodeNo.Text = "77"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(301, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Code Number:"
        '
        'Form_Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Borrow)
        Me.Controls.Add(Me.Picbox_Cover)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_CodeNo)
        Me.Controls.Add(Me.Lbl_ISBNNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Lbl_YearPub)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lbl_Category)
        Me.Controls.Add(Me.Lbl_Author)
        Me.Controls.Add(Me.Lbl_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form_Borrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Book Details"
        CType(Me.Picbox_Cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Picbox_Cover As PictureBox
    Friend WithEvents Btn_Borrow As Button
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Lbl_Author As Label
    Friend WithEvents Lbl_Category As Label
    Friend WithEvents Lbl_ShelveNo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Lbl_YearPub As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Lbl_ISBNNo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_CodeNo As Label
    Friend WithEvents Label2 As Label
End Class

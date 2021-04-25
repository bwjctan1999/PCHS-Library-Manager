<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_View))
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Picbox_Cover = New System.Windows.Forms.PictureBox()
        Me.Lbl_Author = New System.Windows.Forms.Label()
        Me.Lbl_Subject = New System.Windows.Forms.Label()
        Me.Lbl_ShelfNo = New System.Windows.Forms.Label()
        Me.Lbl_By = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_YearPub = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_ISBNNo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Publisher = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Okay = New System.Windows.Forms.Button()
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
        Me.Lbl_Title.MaximumSize = New System.Drawing.Size(334, 0)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(245, 32)
        Me.Lbl_Title.TabIndex = 0
        Me.Lbl_Title.Text = "The Great Gatsby"
        '
        'Picbox_Cover
        '
        Me.Picbox_Cover.Image = Global.PCHS_Library___Student.My.Resources.Resources.Book_Default
        Me.Picbox_Cover.Location = New System.Drawing.Point(12, 55)
        Me.Picbox_Cover.Name = "Picbox_Cover"
        Me.Picbox_Cover.Size = New System.Drawing.Size(269, 327)
        Me.Picbox_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picbox_Cover.TabIndex = 1
        Me.Picbox_Cover.TabStop = False
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
        'Lbl_Subject
        '
        Me.Lbl_Subject.AutoSize = True
        Me.Lbl_Subject.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Subject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Subject.Location = New System.Drawing.Point(448, 204)
        Me.Lbl_Subject.Name = "Lbl_Subject"
        Me.Lbl_Subject.Size = New System.Drawing.Size(95, 23)
        Me.Lbl_Subject.TabIndex = 0
        Me.Lbl_Subject.Text = "Literature"
        '
        'Lbl_ShelfNo
        '
        Me.Lbl_ShelfNo.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ShelfNo.ForeColor = System.Drawing.Color.White
        Me.Lbl_ShelfNo.Location = New System.Drawing.Point(26, 35)
        Me.Lbl_ShelfNo.Name = "Lbl_ShelfNo"
        Me.Lbl_ShelfNo.Size = New System.Drawing.Size(108, 77)
        Me.Lbl_ShelfNo.TabIndex = 0
        Me.Lbl_ShelfNo.Text = "04"
        Me.Lbl_ShelfNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_By
        '
        Me.Lbl_By.AutoSize = True
        Me.Lbl_By.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_By.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_By.Location = New System.Drawing.Point(301, 87)
        Me.Lbl_By.Name = "Lbl_By"
        Me.Lbl_By.Size = New System.Drawing.Size(35, 24)
        Me.Lbl_By.TabIndex = 0
        Me.Lbl_By.Text = "by"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(361, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Subject:"
        '
        'Lbl_YearPub
        '
        Me.Lbl_YearPub.AutoSize = True
        Me.Lbl_YearPub.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_YearPub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_YearPub.Location = New System.Drawing.Point(448, 264)
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
        Me.Label11.Location = New System.Drawing.Point(306, 266)
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
        Me.Lbl_ISBNNo.Location = New System.Drawing.Point(448, 298)
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
        Me.Panel1.Controls.Add(Me.Lbl_ShelfNo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(650, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 133)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_Publisher
        '
        Me.Lbl_Publisher.AutoSize = True
        Me.Lbl_Publisher.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Publisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Publisher.Location = New System.Drawing.Point(448, 235)
        Me.Lbl_Publisher.Name = "Lbl_Publisher"
        Me.Lbl_Publisher.Size = New System.Drawing.Size(159, 23)
        Me.Lbl_Publisher.TabIndex = 0
        Me.Lbl_Publisher.Text = "Allen and Unwin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(319, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ISBN Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(353, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Publisher:"
        '
        'Btn_Okay
        '
        Me.Btn_Okay.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Okay.FlatAppearance.BorderSize = 0
        Me.Btn_Okay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Okay.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Okay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Okay.Location = New System.Drawing.Point(654, 397)
        Me.Btn_Okay.Name = "Btn_Okay"
        Me.Btn_Okay.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Okay.TabIndex = 8
        Me.Btn_Okay.Text = "Ok"
        Me.Btn_Okay.UseVisualStyleBackColor = False
        '
        'Form_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Okay)
        Me.Controls.Add(Me.Picbox_Cover)
        Me.Controls.Add(Me.Lbl_By)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Publisher)
        Me.Controls.Add(Me.Lbl_ISBNNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Lbl_YearPub)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lbl_Subject)
        Me.Controls.Add(Me.Lbl_Author)
        Me.Controls.Add(Me.Lbl_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PCHS Library: Book Details"
        CType(Me.Picbox_Cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Picbox_Cover As PictureBox
    Friend WithEvents Lbl_Author As Label
    Friend WithEvents Lbl_Subject As Label
    Friend WithEvents Lbl_ShelfNo As Label
    Friend WithEvents Lbl_By As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Lbl_YearPub As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Lbl_ISBNNo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_Publisher As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Okay As Button
End Class

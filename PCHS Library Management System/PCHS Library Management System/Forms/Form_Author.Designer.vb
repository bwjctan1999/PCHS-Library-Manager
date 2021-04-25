<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddAuthor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AddAuthor))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_mode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtbox_Name = New System.Windows.Forms.TextBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_AddBook = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lbl_mode)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 49)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icons_Addbook
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Lbl_mode
        '
        Me.Lbl_mode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_mode.ForeColor = System.Drawing.Color.White
        Me.Lbl_mode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_mode.Location = New System.Drawing.Point(63, 14)
        Me.Lbl_mode.Name = "Lbl_mode"
        Me.Lbl_mode.Size = New System.Drawing.Size(141, 21)
        Me.Lbl_mode.TabIndex = 0
        Me.Lbl_mode.Text = "ADD AUTHOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(25, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Location = New System.Drawing.Point(27, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 2)
        Me.Panel3.TabIndex = 8
        '
        'Txtbox_Name
        '
        Me.Txtbox_Name.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Txtbox_Name.Location = New System.Drawing.Point(27, 98)
        Me.Txtbox_Name.Name = "Txtbox_Name"
        Me.Txtbox_Name.Size = New System.Drawing.Size(318, 19)
        Me.Txtbox_Name.TabIndex = 7
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Cancel.Location = New System.Drawing.Point(107, 154)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Cancel.TabIndex = 11
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_AddBook
        '
        Me.Btn_AddBook.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_AddBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddBook.FlatAppearance.BorderSize = 0
        Me.Btn_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddBook.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_AddBook.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_AddBook.Location = New System.Drawing.Point(229, 154)
        Me.Btn_AddBook.Name = "Btn_AddBook"
        Me.Btn_AddBook.Size = New System.Drawing.Size(116, 29)
        Me.Btn_AddBook.TabIndex = 10
        Me.Btn_AddBook.Text = "Add"
        Me.Btn_AddBook.UseVisualStyleBackColor = False
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.FlatAppearance.BorderSize = 0
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Edit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Edit.Location = New System.Drawing.Point(229, 154)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Edit.TabIndex = 10
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        Me.Btn_Edit.Visible = False
        '
        'Form_AddAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 195)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_AddBook)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Txtbox_Name)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_Edit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_AddAuthor"
        Me.Text = "PCHS Library Manager"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_mode As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtbox_Name As TextBox
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_AddBook As Button
    Friend WithEvents Btn_Edit As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AddSubject))
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtbox_Subject = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_mode = New System.Windows.Forms.Label()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Cancel.Location = New System.Drawing.Point(108, 154)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Cancel.TabIndex = 18
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.FlatAppearance.BorderSize = 0
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Add.Location = New System.Drawing.Point(230, 154)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Add.TabIndex = 16
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(26, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Location = New System.Drawing.Point(28, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 2)
        Me.Panel3.TabIndex = 14
        '
        'Txtbox_Subject
        '
        Me.Txtbox_Subject.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Subject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_Subject.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Txtbox_Subject.Location = New System.Drawing.Point(28, 98)
        Me.Txtbox_Subject.Name = "Txtbox_Subject"
        Me.Txtbox_Subject.Size = New System.Drawing.Size(318, 19)
        Me.Txtbox_Subject.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lbl_mode)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 49)
        Me.Panel2.TabIndex = 12
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
        Me.Lbl_mode.Size = New System.Drawing.Size(194, 21)
        Me.Lbl_mode.TabIndex = 0
        Me.Lbl_mode.Text = "ADD SUBJECT"
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.FlatAppearance.BorderSize = 0
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Edit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Edit.Location = New System.Drawing.Point(230, 154)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Edit.TabIndex = 17
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        Me.Btn_Edit.Visible = False
        '
        'Form_AddSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 195)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Txtbox_Subject)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_Edit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_AddSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PCHS Library Manager"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtbox_Subject As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_mode As Label
    Friend WithEvents Btn_Edit As Button
End Class

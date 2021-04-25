<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddPublisher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AddPublisher))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_mode = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Txtbox_Name = New System.Windows.Forms.TextBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
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
        Me.Panel2.Size = New System.Drawing.Size(233, 49)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_AddStaff
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
        Me.Lbl_mode.Location = New System.Drawing.Point(56, 14)
        Me.Lbl_mode.Name = "Lbl_mode"
        Me.Lbl_mode.Size = New System.Drawing.Size(174, 21)
        Me.Lbl_mode.TabIndex = 0
        Me.Lbl_mode.Text = "ADD PUBLISHER"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel9.Location = New System.Drawing.Point(22, 120)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(318, 2)
        Me.Panel9.TabIndex = 41
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Password.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Password.Location = New System.Drawing.Point(19, 74)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(53, 18)
        Me.Lbl_Password.TabIndex = 42
        Me.Lbl_Password.Text = "Name"
        '
        'Txtbox_Name
        '
        Me.Txtbox_Name.BackColor = System.Drawing.SystemColors.Control
        Me.Txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Txtbox_Name.Location = New System.Drawing.Point(22, 99)
        Me.Txtbox_Name.Name = "Txtbox_Name"
        Me.Txtbox_Name.Size = New System.Drawing.Size(318, 19)
        Me.Txtbox_Name.TabIndex = 40
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.FlatAppearance.BorderSize = 0
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Add.Location = New System.Drawing.Point(224, 153)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Add.TabIndex = 36
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Cancel.Location = New System.Drawing.Point(102, 153)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Cancel.TabIndex = 35
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.FlatAppearance.BorderSize = 0
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Edit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Edit.Location = New System.Drawing.Point(224, 153)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Edit.TabIndex = 37
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        Me.Btn_Edit.Visible = False
        '
        'Btn_Remove
        '
        Me.Btn_Remove.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Remove.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Remove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Remove.Location = New System.Drawing.Point(102, 153)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Remove.TabIndex = 38
        Me.Btn_Remove.Text = "Remove"
        Me.Btn_Remove.UseVisualStyleBackColor = False
        Me.Btn_Remove.Visible = False
        '
        'Form_AddPublisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 208)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Lbl_Password)
        Me.Controls.Add(Me.Btn_Remove)
        Me.Controls.Add(Me.Txtbox_Name)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_AddPublisher"
        Me.Text = "PCHS Library Manager"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_mode As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Txtbox_Name As TextBox
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Remove As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DatabaseSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DatabaseSettings))
        Me.Txtbox_Server = New System.Windows.Forms.TextBox()
        Me.LABELSDF = New System.Windows.Forms.Label()
        Me.Txtbox_Username = New System.Windows.Forms.TextBox()
        Me.FASDF = New System.Windows.Forms.Label()
        Me.Txtbox_Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtbox_Database = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_ShelfNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtbox_Server
        '
        Me.Txtbox_Server.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Server.Location = New System.Drawing.Point(35, 91)
        Me.Txtbox_Server.Name = "Txtbox_Server"
        Me.Txtbox_Server.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Server.TabIndex = 0
        '
        'LABELSDF
        '
        Me.LABELSDF.AutoSize = True
        Me.LABELSDF.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABELSDF.ForeColor = System.Drawing.Color.White
        Me.LABELSDF.Location = New System.Drawing.Point(31, 69)
        Me.LABELSDF.Name = "LABELSDF"
        Me.LABELSDF.Size = New System.Drawing.Size(54, 18)
        Me.LABELSDF.TabIndex = 1
        Me.LABELSDF.Text = "Server"
        '
        'Txtbox_Username
        '
        Me.Txtbox_Username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Username.Location = New System.Drawing.Point(35, 158)
        Me.Txtbox_Username.Name = "Txtbox_Username"
        Me.Txtbox_Username.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Username.TabIndex = 0
        '
        'FASDF
        '
        Me.FASDF.AutoSize = True
        Me.FASDF.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FASDF.ForeColor = System.Drawing.Color.White
        Me.FASDF.Location = New System.Drawing.Point(31, 136)
        Me.FASDF.Name = "FASDF"
        Me.FASDF.Size = New System.Drawing.Size(82, 18)
        Me.FASDF.TabIndex = 1
        Me.FASDF.Text = "Username"
        '
        'Txtbox_Password
        '
        Me.Txtbox_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Password.Location = New System.Drawing.Point(35, 231)
        Me.Txtbox_Password.Name = "Txtbox_Password"
        Me.Txtbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtbox_Password.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Password.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Txtbox_Database
        '
        Me.Txtbox_Database.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Database.Location = New System.Drawing.Point(35, 300)
        Me.Txtbox_Database.Name = "Txtbox_Database"
        Me.Txtbox_Database.Size = New System.Drawing.Size(298, 26)
        Me.Txtbox_Database.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Database"
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Save.Location = New System.Drawing.Point(642, 369)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Save.TabIndex = 9
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Salmon
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Close.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Close.Location = New System.Drawing.Point(520, 369)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Close.TabIndex = 9
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_ShelfNo)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 53)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_DatabaseWarning
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Lbl_ShelfNo
        '
        Me.Lbl_ShelfNo.AutoSize = True
        Me.Lbl_ShelfNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ShelfNo.ForeColor = System.Drawing.Color.White
        Me.Lbl_ShelfNo.Location = New System.Drawing.Point(46, 15)
        Me.Lbl_ShelfNo.Name = "Lbl_ShelfNo"
        Me.Lbl_ShelfNo.Size = New System.Drawing.Size(177, 23)
        Me.Lbl_ShelfNo.TabIndex = 0
        Me.Lbl_ShelfNo.Text = "Database Settings"
        Me.Lbl_ShelfNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Txtbox_Server)
        Me.Panel2.Controls.Add(Me.LABELSDF)
        Me.Panel2.Controls.Add(Me.Txtbox_Password)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.FASDF)
        Me.Panel2.Controls.Add(Me.Txtbox_Username)
        Me.Panel2.Controls.Add(Me.Txtbox_Database)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 411)
        Me.Panel2.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(404, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "If This Appears:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(404, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(357, 174)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Form_DatabaseSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 410)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_DatabaseSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCHS Library Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtbox_Server As TextBox
    Friend WithEvents LABELSDF As Label
    Friend WithEvents Txtbox_Username As TextBox
    Friend WithEvents FASDF As Label
    Friend WithEvents Txtbox_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtbox_Database As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_ShelfNo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

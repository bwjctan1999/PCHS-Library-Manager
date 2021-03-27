<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_QRReader
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbox_Cameras = New System.Windows.Forms.ComboBox()
        Me.Timer_QR = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_mode = New System.Windows.Forms.Label()
        Me.Picbox_Display = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picbox_Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Capture Device:"
        '
        'Cbox_Cameras
        '
        Me.Cbox_Cameras.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_Cameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_Cameras.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cbox_Cameras.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Cbox_Cameras.FormattingEnabled = True
        Me.Cbox_Cameras.Location = New System.Drawing.Point(284, 87)
        Me.Cbox_Cameras.Name = "Cbox_Cameras"
        Me.Cbox_Cameras.Size = New System.Drawing.Size(253, 28)
        Me.Cbox_Cameras.TabIndex = 3
        '
        'Timer_QR
        '
        Me.Timer_QR.Interval = 1000
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(284, 150)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(253, 170)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Lbl_mode)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 49)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_QR
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
        Me.Lbl_mode.Text = "QR READER"
        '
        'Picbox_Display
        '
        Me.Picbox_Display.BackColor = System.Drawing.Color.Black
        Me.Picbox_Display.Location = New System.Drawing.Point(12, 70)
        Me.Picbox_Display.Name = "Picbox_Display"
        Me.Picbox_Display.Size = New System.Drawing.Size(250, 250)
        Me.Picbox_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picbox_Display.TabIndex = 0
        Me.Picbox_Display.TabStop = False
        '
        'Form_QRReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 332)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Cbox_Cameras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Picbox_Display)
        Me.Name = "Form_QRReader"
        Me.Text = "Form_QRReader"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picbox_Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picbox_Display As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbox_Cameras As ComboBox
    Friend WithEvents Timer_QR As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_mode As Label
End Class

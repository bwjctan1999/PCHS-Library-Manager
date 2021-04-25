<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Msg
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Lbl_Header = New System.Windows.Forms.Label()
        Me.Lbl_Paragraph = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_Cancel)
        Me.Panel1.Controls.Add(Me.Btn_Ok)
        Me.Panel1.Location = New System.Drawing.Point(-1, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 48)
        Me.Panel1.TabIndex = 4
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Cancel.Location = New System.Drawing.Point(104, 11)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(85, 29)
        Me.Btn_Cancel.TabIndex = 9
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Ok.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btn_Ok.FlatAppearance.BorderSize = 0
        Me.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Ok.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Ok.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Ok.Location = New System.Drawing.Point(195, 11)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(85, 29)
        Me.Btn_Ok.TabIndex = 8
        Me.Btn_Ok.Text = "Ok"
        Me.Btn_Ok.UseVisualStyleBackColor = False
        '
        'Lbl_Header
        '
        Me.Lbl_Header.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Header.Location = New System.Drawing.Point(14, 21)
        Me.Lbl_Header.Name = "Lbl_Header"
        Me.Lbl_Header.Size = New System.Drawing.Size(265, 20)
        Me.Lbl_Header.TabIndex = 2
        Me.Lbl_Header.Text = "Header"
        '
        'Lbl_Paragraph
        '
        Me.Lbl_Paragraph.AutoSize = True
        Me.Lbl_Paragraph.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Paragraph.Location = New System.Drawing.Point(12, 44)
        Me.Lbl_Paragraph.MaximumSize = New System.Drawing.Size(265, 0)
        Me.Lbl_Paragraph.Name = "Lbl_Paragraph"
        Me.Lbl_Paragraph.Size = New System.Drawing.Size(247, 34)
        Me.Lbl_Paragraph.TabIndex = 3
        Me.Lbl_Paragraph.Text = "Lorem Ipsum, Something Dolor amel shenaninigags"
        '
        'Msg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(289, 150)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_Header)
        Me.Controls.Add(Me.Lbl_Paragraph)
        Me.Name = "Msg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_NewPublisher"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Lbl_Header As Label
    Friend WithEvents Lbl_Paragraph As Label
End Class

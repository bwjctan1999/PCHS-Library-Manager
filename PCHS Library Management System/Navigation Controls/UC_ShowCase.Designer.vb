<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ShowCase
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Txtbox_SC1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txtbox_SC2 = New System.Windows.Forms.TextBox()
        Me.Btn_Save1 = New System.Windows.Forms.Button()
        Me.Btn_Save2 = New System.Windows.Forms.Button()
        Me.UC_SCBookShelf2 = New PCHS_Library_Management_System.UC_SCBookShelf()
        Me.UC_SCBookShelf1 = New PCHS_Library_Management_System.UC_SCBookShelf()
        Me.SuspendLayout()
        '
        'Txtbox_SC1
        '
        Me.Txtbox_SC1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txtbox_SC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Txtbox_SC1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_SC1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_SC1.ForeColor = System.Drawing.Color.White
        Me.Txtbox_SC1.Location = New System.Drawing.Point(23, 71)
        Me.Txtbox_SC1.Name = "Txtbox_SC1"
        Me.Txtbox_SC1.Size = New System.Drawing.Size(182, 19)
        Me.Txtbox_SC1.TabIndex = 1
        Me.Txtbox_SC1.Text = "Featured"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(14, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 25)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(14, 294)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(202, 25)
        Me.Panel2.TabIndex = 0
        '
        'Txtbox_SC2
        '
        Me.Txtbox_SC2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txtbox_SC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Txtbox_SC2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbox_SC2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_SC2.ForeColor = System.Drawing.Color.White
        Me.Txtbox_SC2.Location = New System.Drawing.Point(23, 300)
        Me.Txtbox_SC2.Name = "Txtbox_SC2"
        Me.Txtbox_SC2.Size = New System.Drawing.Size(182, 19)
        Me.Txtbox_SC2.TabIndex = 1
        Me.Txtbox_SC2.Text = "New Arrivals"
        '
        'Btn_Save1
        '
        Me.Btn_Save1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Btn_Save1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Save1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Save1.FlatAppearance.BorderSize = 0
        Me.Btn_Save1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Save1.Location = New System.Drawing.Point(215, 64)
        Me.Btn_Save1.Name = "Btn_Save1"
        Me.Btn_Save1.Size = New System.Drawing.Size(62, 26)
        Me.Btn_Save1.TabIndex = 8
        Me.Btn_Save1.Text = "Save"
        Me.Btn_Save1.UseVisualStyleBackColor = False
        Me.Btn_Save1.Visible = False
        '
        'Btn_Save2
        '
        Me.Btn_Save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Save2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Save2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Save2.FlatAppearance.BorderSize = 0
        Me.Btn_Save2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Save2.Location = New System.Drawing.Point(215, 294)
        Me.Btn_Save2.Name = "Btn_Save2"
        Me.Btn_Save2.Size = New System.Drawing.Size(62, 26)
        Me.Btn_Save2.TabIndex = 9
        Me.Btn_Save2.Text = "Save"
        Me.Btn_Save2.UseVisualStyleBackColor = False
        Me.Btn_Save2.Visible = False
        '
        'UC_SCBookShelf2
        '
        Me.UC_SCBookShelf2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_SCBookShelf2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.UC_SCBookShelf2.Location = New System.Drawing.Point(14, 319)
        Me.UC_SCBookShelf2.Name = "UC_SCBookShelf2"
        Me.UC_SCBookShelf2.Size = New System.Drawing.Size(775, 160)
        Me.UC_SCBookShelf2.TabIndex = 1
        '
        'UC_SCBookShelf1
        '
        Me.UC_SCBookShelf1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_SCBookShelf1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.UC_SCBookShelf1.Location = New System.Drawing.Point(14, 89)
        Me.UC_SCBookShelf1.Name = "UC_SCBookShelf1"
        Me.UC_SCBookShelf1.Size = New System.Drawing.Size(775, 160)
        Me.UC_SCBookShelf1.TabIndex = 1
        '
        'UC_ShowCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Btn_Save2)
        Me.Controls.Add(Me.Btn_Save1)
        Me.Controls.Add(Me.Txtbox_SC2)
        Me.Controls.Add(Me.Txtbox_SC1)
        Me.Controls.Add(Me.UC_SCBookShelf2)
        Me.Controls.Add(Me.UC_SCBookShelf1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_ShowCase"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtbox_SC1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Txtbox_SC2 As TextBox
    Friend WithEvents UC_SCBookShelf1 As UC_SCBookShelf
    Friend WithEvents UC_SCBookShelf2 As UC_SCBookShelf
    Friend WithEvents Btn_Save1 As Button
    Friend WithEvents Btn_Save2 As Button
End Class

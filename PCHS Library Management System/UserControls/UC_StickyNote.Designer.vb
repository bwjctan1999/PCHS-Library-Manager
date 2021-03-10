<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_StickyNote
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
        Me.TaskBar = New System.Windows.Forms.Panel()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.RTBox = New System.Windows.Forms.RichTextBox()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Panel_Bottom = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_StrikeOut = New System.Windows.Forms.Button()
        Me.Btn_Underline = New System.Windows.Forms.Button()
        Me.Btn_Italic = New System.Windows.Forms.Button()
        Me.Btn_Bold = New System.Windows.Forms.Button()
        Me.Btn_Red = New System.Windows.Forms.Button()
        Me.Btn_Green = New System.Windows.Forms.Button()
        Me.Btn_Blue = New System.Windows.Forms.Button()
        Me.Btn_Yellow = New System.Windows.Forms.Button()
        Me.Btn_More = New System.Windows.Forms.Panel()
        Me.Btn_Bullets = New System.Windows.Forms.Button()
        Me.Btn_Picture = New System.Windows.Forms.Button()
        Me.TaskBar.SuspendLayout()
        Me.Panel_Body.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskBar
        '
        Me.TaskBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskBar.BackColor = System.Drawing.Color.Khaki
        Me.TaskBar.Controls.Add(Me.Btn_More)
        Me.TaskBar.Controls.Add(Me.Btn_Close)
        Me.TaskBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.TaskBar.Location = New System.Drawing.Point(0, 0)
        Me.TaskBar.Name = "TaskBar"
        Me.TaskBar.Size = New System.Drawing.Size(223, 22)
        Me.TaskBar.TabIndex = 2
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.BackColor = System.Drawing.Color.Khaki
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Close.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Close.Location = New System.Drawing.Point(202, 1)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Close.TabIndex = 0
        Me.Btn_Close.Text = "X"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Panel_Body
        '
        Me.Panel_Body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Body.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel_Body.Controls.Add(Me.RTBox)
        Me.Panel_Body.Location = New System.Drawing.Point(3, 44)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(217, 169)
        Me.Panel_Body.TabIndex = 2
        '
        'RTBox
        '
        Me.RTBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.RTBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBox.Location = New System.Drawing.Point(5, 6)
        Me.RTBox.Name = "RTBox"
        Me.RTBox.Size = New System.Drawing.Size(211, 156)
        Me.RTBox.TabIndex = 3
        Me.RTBox.Text = "Type Here..."
        '
        'Panel_Left
        '
        Me.Panel_Left.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel_Left.BackColor = System.Drawing.Color.Khaki
        Me.Panel_Left.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Left.Location = New System.Drawing.Point(0, 22)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(3, 194)
        Me.Panel_Left.TabIndex = 0
        '
        'Panel_Right
        '
        Me.Panel_Right.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Right.BackColor = System.Drawing.Color.Khaki
        Me.Panel_Right.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Right.Location = New System.Drawing.Point(220, 22)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(3, 184)
        Me.Panel_Right.TabIndex = 1
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Bottom.BackColor = System.Drawing.Color.Khaki
        Me.Panel_Bottom.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Bottom.Location = New System.Drawing.Point(3, 213)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(210, 3)
        Me.Panel_Bottom.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_Bullets)
        Me.Panel1.Controls.Add(Me.Btn_Picture)
        Me.Panel1.Controls.Add(Me.Btn_StrikeOut)
        Me.Panel1.Controls.Add(Me.Btn_Underline)
        Me.Panel1.Controls.Add(Me.Btn_Italic)
        Me.Panel1.Controls.Add(Me.Btn_Bold)
        Me.Panel1.Controls.Add(Me.Btn_Red)
        Me.Panel1.Controls.Add(Me.Btn_Green)
        Me.Panel1.Controls.Add(Me.Btn_Blue)
        Me.Panel1.Controls.Add(Me.Btn_Yellow)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 22)
        Me.Panel1.TabIndex = 2
        '
        'Btn_StrikeOut
        '
        Me.Btn_StrikeOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_StrikeOut.FlatAppearance.BorderSize = 0
        Me.Btn_StrikeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_StrikeOut.Font = New System.Drawing.Font("Bahnschrift Condensed", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_StrikeOut.ForeColor = System.Drawing.Color.White
        Me.Btn_StrikeOut.Location = New System.Drawing.Point(64, 1)
        Me.Btn_StrikeOut.Name = "Btn_StrikeOut"
        Me.Btn_StrikeOut.Size = New System.Drawing.Size(20, 20)
        Me.Btn_StrikeOut.TabIndex = 0
        Me.Btn_StrikeOut.Text = "S"
        Me.Btn_StrikeOut.UseVisualStyleBackColor = False
        '
        'Btn_Underline
        '
        Me.Btn_Underline.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Underline.FlatAppearance.BorderSize = 0
        Me.Btn_Underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Underline.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Underline.ForeColor = System.Drawing.Color.White
        Me.Btn_Underline.Location = New System.Drawing.Point(44, 1)
        Me.Btn_Underline.Name = "Btn_Underline"
        Me.Btn_Underline.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Underline.TabIndex = 0
        Me.Btn_Underline.Text = "U"
        Me.Btn_Underline.UseVisualStyleBackColor = False
        '
        'Btn_Italic
        '
        Me.Btn_Italic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Italic.FlatAppearance.BorderSize = 0
        Me.Btn_Italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Italic.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Italic.ForeColor = System.Drawing.Color.White
        Me.Btn_Italic.Location = New System.Drawing.Point(24, 1)
        Me.Btn_Italic.Name = "Btn_Italic"
        Me.Btn_Italic.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Italic.TabIndex = 0
        Me.Btn_Italic.Text = "I"
        Me.Btn_Italic.UseVisualStyleBackColor = False
        '
        'Btn_Bold
        '
        Me.Btn_Bold.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Bold.FlatAppearance.BorderSize = 0
        Me.Btn_Bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Bold.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.3!, System.Drawing.FontStyle.Bold)
        Me.Btn_Bold.ForeColor = System.Drawing.Color.White
        Me.Btn_Bold.Location = New System.Drawing.Point(4, 1)
        Me.Btn_Bold.Name = "Btn_Bold"
        Me.Btn_Bold.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Bold.TabIndex = 0
        Me.Btn_Bold.Text = "B"
        Me.Btn_Bold.UseVisualStyleBackColor = False
        '
        'Btn_Red
        '
        Me.Btn_Red.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Red.BackColor = System.Drawing.Color.MistyRose
        Me.Btn_Red.FlatAppearance.BorderSize = 0
        Me.Btn_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Red.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Red.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Red.Location = New System.Drawing.Point(139, 1)
        Me.Btn_Red.Name = "Btn_Red"
        Me.Btn_Red.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Red.TabIndex = 0
        Me.Btn_Red.UseVisualStyleBackColor = False
        '
        'Btn_Green
        '
        Me.Btn_Green.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Green.BackColor = System.Drawing.Color.PaleGreen
        Me.Btn_Green.FlatAppearance.BorderSize = 0
        Me.Btn_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Green.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Green.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Green.Location = New System.Drawing.Point(159, 1)
        Me.Btn_Green.Name = "Btn_Green"
        Me.Btn_Green.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Green.TabIndex = 0
        Me.Btn_Green.UseVisualStyleBackColor = False
        '
        'Btn_Blue
        '
        Me.Btn_Blue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Blue.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Blue.FlatAppearance.BorderSize = 0
        Me.Btn_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Blue.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Blue.Location = New System.Drawing.Point(179, 1)
        Me.Btn_Blue.Name = "Btn_Blue"
        Me.Btn_Blue.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Blue.TabIndex = 0
        Me.Btn_Blue.UseVisualStyleBackColor = False
        '
        'Btn_Yellow
        '
        Me.Btn_Yellow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Yellow.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btn_Yellow.FlatAppearance.BorderSize = 0
        Me.Btn_Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Yellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Yellow.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Yellow.Location = New System.Drawing.Point(199, 1)
        Me.Btn_Yellow.Name = "Btn_Yellow"
        Me.Btn_Yellow.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Yellow.TabIndex = 0
        Me.Btn_Yellow.UseVisualStyleBackColor = False
        '
        'Btn_More
        '
        Me.Btn_More.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_More.BackColor = System.Drawing.Color.Khaki
        Me.Btn_More.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_More
        Me.Btn_More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_More.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_More.Location = New System.Drawing.Point(178, 1)
        Me.Btn_More.Name = "Btn_More"
        Me.Btn_More.Size = New System.Drawing.Size(20, 20)
        Me.Btn_More.TabIndex = 4
        '
        'Btn_Bullets
        '
        Me.Btn_Bullets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Bullets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Bullets.FlatAppearance.BorderSize = 0
        Me.Btn_Bullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Bullets.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Bullets.ForeColor = System.Drawing.Color.White
        Me.Btn_Bullets.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Bullet
        Me.Btn_Bullets.Location = New System.Drawing.Point(84, 1)
        Me.Btn_Bullets.Name = "Btn_Bullets"
        Me.Btn_Bullets.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Bullets.TabIndex = 0
        Me.Btn_Bullets.UseVisualStyleBackColor = False
        '
        'Btn_Picture
        '
        Me.Btn_Picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Btn_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Picture.FlatAppearance.BorderSize = 0
        Me.Btn_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Picture.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Picture.ForeColor = System.Drawing.Color.White
        Me.Btn_Picture.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Image
        Me.Btn_Picture.Location = New System.Drawing.Point(105, 1)
        Me.Btn_Picture.Name = "Btn_Picture"
        Me.Btn_Picture.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Picture.TabIndex = 0
        Me.Btn_Picture.UseVisualStyleBackColor = False
        '
        'UC_StickyNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Controls.Add(Me.Panel_Bottom)
        Me.Controls.Add(Me.Panel_Right)
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.TaskBar)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "UC_StickyNote"
        Me.Size = New System.Drawing.Size(223, 216)
        Me.TaskBar.ResumeLayout(False)
        Me.Panel_Body.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TaskBar As Panel
    Friend WithEvents Panel_Body As Panel
    Friend WithEvents Panel_Left As Panel
    Friend WithEvents Panel_Right As Panel
    Friend WithEvents Panel_Bottom As Panel
    Friend WithEvents RTBox As RichTextBox
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_More As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Bold As Button
    Friend WithEvents Btn_Italic As Button
    Friend WithEvents Btn_Red As Button
    Friend WithEvents Btn_Green As Button
    Friend WithEvents Btn_Blue As Button
    Friend WithEvents Btn_Yellow As Button
    Friend WithEvents Btn_Underline As Button
    Friend WithEvents Btn_StrikeOut As Button
    Friend WithEvents Btn_Picture As Button
    Friend WithEvents Btn_Bullets As Button
End Class

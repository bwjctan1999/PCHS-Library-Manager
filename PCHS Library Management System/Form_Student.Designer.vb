﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Student
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_Admin = New System.Windows.Forms.Button()
        Me.Lbl_BookShowcase_1 = New System.Windows.Forms.Label()
        Me.Lbl_BookShowcase_2 = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_SearchSettings = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cbox_SearchSettings = New System.Windows.Forms.ComboBox()
        Me.Cbox_Categories = New System.Windows.Forms.ComboBox()
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.UserControl_NewBooks = New PCHS_Library_Management_System.UC_BookShelf()
        Me.UserControl_FeaturedBooks = New PCHS_Library_Management_System.UC_BookShelf()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.searchbar
        Me.PictureBox1.Location = New System.Drawing.Point(179, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(630, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(197, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(536, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Btn_Admin
        '
        Me.Btn_Admin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_Admin.FlatAppearance.BorderSize = 0
        Me.Btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Admin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Admin.ForeColor = System.Drawing.Color.White
        Me.Btn_Admin.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Admin.Name = "Btn_Admin"
        Me.Btn_Admin.Size = New System.Drawing.Size(75, 29)
        Me.Btn_Admin.TabIndex = 2
        Me.Btn_Admin.Text = "Admin"
        Me.Btn_Admin.UseVisualStyleBackColor = False
        '
        'Lbl_BookShowcase_1
        '
        Me.Lbl_BookShowcase_1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_BookShowcase_1.AutoSize = True
        Me.Lbl_BookShowcase_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_BookShowcase_1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BookShowcase_1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Lbl_BookShowcase_1.Location = New System.Drawing.Point(117, 151)
        Me.Lbl_BookShowcase_1.Name = "Lbl_BookShowcase_1"
        Me.Lbl_BookShowcase_1.Size = New System.Drawing.Size(82, 21)
        Me.Lbl_BookShowcase_1.TabIndex = 4
        Me.Lbl_BookShowcase_1.Text = "Featured"
        '
        'Lbl_BookShowcase_2
        '
        Me.Lbl_BookShowcase_2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_BookShowcase_2.AutoSize = True
        Me.Lbl_BookShowcase_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_BookShowcase_2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BookShowcase_2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Lbl_BookShowcase_2.Location = New System.Drawing.Point(117, 366)
        Me.Lbl_BookShowcase_2.Name = "Lbl_BookShowcase_2"
        Me.Lbl_BookShowcase_2.Size = New System.Drawing.Size(106, 21)
        Me.Lbl_BookShowcase_2.TabIndex = 6
        Me.Lbl_BookShowcase_2.Text = "New Arrivals"
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Search.BackColor = System.Drawing.Color.White
        Me.Btn_Search.FlatAppearance.BorderSize = 0
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Search2
        Me.Btn_Search.Location = New System.Drawing.Point(768, 76)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Search.TabIndex = 7
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_SearchSettings
        '
        Me.Btn_SearchSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_SearchSettings.BackColor = System.Drawing.Color.White
        Me.Btn_SearchSettings.FlatAppearance.BorderSize = 0
        Me.Btn_SearchSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SearchSettings.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.Icons_Settings2
        Me.Btn_SearchSettings.Location = New System.Drawing.Point(739, 76)
        Me.Btn_SearchSettings.Name = "Btn_SearchSettings"
        Me.Btn_SearchSettings.Size = New System.Drawing.Size(29, 30)
        Me.Btn_SearchSettings.TabIndex = 8
        Me.Btn_SearchSettings.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(794, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Check Out"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(902, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Return Book"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Cbox_SearchSettings
        '
        Me.Cbox_SearchSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cbox_SearchSettings.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_SearchSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_SearchSettings.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cbox_SearchSettings.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Cbox_SearchSettings.FormattingEnabled = True
        Me.Cbox_SearchSettings.Items.AddRange(New Object() {"All", "Title", "Author", "ISBN Number", "Category"})
        Me.Cbox_SearchSettings.Location = New System.Drawing.Point(577, 77)
        Me.Cbox_SearchSettings.Name = "Cbox_SearchSettings"
        Me.Cbox_SearchSettings.Size = New System.Drawing.Size(162, 28)
        Me.Cbox_SearchSettings.TabIndex = 3
        Me.Cbox_SearchSettings.Visible = False
        '
        'Cbox_Categories
        '
        Me.Cbox_Categories.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cbox_Categories.BackColor = System.Drawing.SystemColors.Control
        Me.Cbox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_Categories.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cbox_Categories.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Cbox_Categories.FormattingEnabled = True
        Me.Cbox_Categories.Items.AddRange(New Object() {"Computer science, information & general works", "Philosophy & psychology", "Religion", "Social sciences", "Language", "Pure Science", "Technology", "Arts & recreation", "Literature", "History & geography"})
        Me.Cbox_Categories.Location = New System.Drawing.Point(197, 77)
        Me.Cbox_Categories.Name = "Cbox_Categories"
        Me.Cbox_Categories.Size = New System.Drawing.Size(374, 28)
        Me.Cbox_Categories.TabIndex = 3
        Me.Cbox_Categories.Visible = False
        '
        'UserControl_DataViewer
        '
        Me.UserControl_DataViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_DataViewer.BackColor = System.Drawing.Color.Transparent
        Me.UserControl_DataViewer.Location = New System.Drawing.Point(120, 139)
        Me.UserControl_DataViewer.Name = "UserControl_DataViewer"
        Me.UserControl_DataViewer.Size = New System.Drawing.Size(766, 389)
        Me.UserControl_DataViewer.TabIndex = 10
        Me.UserControl_DataViewer.Visible = False
        '
        'UserControl_NewBooks
        '
        Me.UserControl_NewBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_NewBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserControl_NewBooks.Location = New System.Drawing.Point(117, 387)
        Me.UserControl_NewBooks.Name = "UserControl_NewBooks"
        Me.UserControl_NewBooks.Size = New System.Drawing.Size(772, 160)
        Me.UserControl_NewBooks.TabIndex = 5
        '
        'UserControl_FeaturedBooks
        '
        Me.UserControl_FeaturedBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_FeaturedBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserControl_FeaturedBooks.Location = New System.Drawing.Point(117, 172)
        Me.UserControl_FeaturedBooks.Name = "UserControl_FeaturedBooks"
        Me.UserControl_FeaturedBooks.Size = New System.Drawing.Size(772, 160)
        Me.UserControl_FeaturedBooks.TabIndex = 3
        '
        'Form_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Background_7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Controls.Add(Me.Cbox_Categories)
        Me.Controls.Add(Me.Cbox_SearchSettings)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_SearchSettings)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Lbl_BookShowcase_2)
        Me.Controls.Add(Me.UserControl_NewBooks)
        Me.Controls.Add(Me.Lbl_BookShowcase_1)
        Me.Controls.Add(Me.UserControl_FeaturedBooks)
        Me.Controls.Add(Me.Btn_Admin)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Student"
        Me.Text = "PCHS Library Manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_Admin As Button
    Friend WithEvents UserControl_FeaturedBooks As UC_BookShelf
    Friend WithEvents Lbl_BookShowcase_1 As Label
    Friend WithEvents Lbl_BookShowcase_2 As Label
    Friend WithEvents UserControl_NewBooks As UC_BookShelf
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Btn_SearchSettings As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Cbox_SearchSettings As ComboBox
    Friend WithEvents Cbox_Categories As ComboBox
    Friend WithEvents UserControl_DataViewer As UC_DataViewer
End Class

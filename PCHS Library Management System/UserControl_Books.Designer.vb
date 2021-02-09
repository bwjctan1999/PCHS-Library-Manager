<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Books
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
        Me.Panel_BookSettings = New System.Windows.Forms.Panel()
        Me.Lbl_GridSettings = New System.Windows.Forms.Label()
        Me.Lbl_FontSettings = New System.Windows.Forms.Label()
        Me.Label_SpaceSettings = New System.Windows.Forms.Label()
        Me.Lbl_ViewSettings = New System.Windows.Forms.Label()
        Me.Cbox_FontSize = New System.Windows.Forms.ComboBox()
        Me.Cbox_FontStyleSettings = New System.Windows.Forms.ComboBox()
        Me.Cbox_FontSettings = New System.Windows.Forms.ComboBox()
        Me.Cbox_GridSettings = New System.Windows.Forms.ComboBox()
        Me.Cbox_ArrangeSettings = New System.Windows.Forms.ComboBox()
        Me.Cbox_ViewSettings = New System.Windows.Forms.ComboBox()
        Me.Btn_BookSettings = New System.Windows.Forms.Button()
        Me.Btn_UpdateBook = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_AddBook = New System.Windows.Forms.Button()
        Me.Btn_BookSearch = New System.Windows.Forms.Button()
        Me.Txtbox_InvSearchBar = New System.Windows.Forms.TextBox()
        Me.ListView_Books = New System.Windows.Forms.ListView()
        Me.CH_Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_ISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_YearPublished = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_ShelveNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel_BookSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_BookSettings
        '
        Me.Panel_BookSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_BookSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel_BookSettings.Controls.Add(Me.Lbl_GridSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Lbl_FontSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Label_SpaceSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Lbl_ViewSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Cbox_FontSize)
        Me.Panel_BookSettings.Controls.Add(Me.Cbox_FontStyleSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Cbox_FontSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Cbox_GridSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Cbox_ArrangeSettings)
        Me.Panel_BookSettings.Controls.Add(Me.Cbox_ViewSettings)
        Me.Panel_BookSettings.Location = New System.Drawing.Point(508, 33)
        Me.Panel_BookSettings.Name = "Panel_BookSettings"
        Me.Panel_BookSettings.Size = New System.Drawing.Size(252, 272)
        Me.Panel_BookSettings.TabIndex = 5
        Me.Panel_BookSettings.Visible = False
        '
        'Lbl_GridSettings
        '
        Me.Lbl_GridSettings.AutoSize = True
        Me.Lbl_GridSettings.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GridSettings.Location = New System.Drawing.Point(5, 156)
        Me.Lbl_GridSettings.Name = "Lbl_GridSettings"
        Me.Lbl_GridSettings.Size = New System.Drawing.Size(34, 16)
        Me.Lbl_GridSettings.TabIndex = 1
        Me.Lbl_GridSettings.Text = "Grid:"
        '
        'Lbl_FontSettings
        '
        Me.Lbl_FontSettings.AutoSize = True
        Me.Lbl_FontSettings.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FontSettings.Location = New System.Drawing.Point(5, 109)
        Me.Lbl_FontSettings.Name = "Lbl_FontSettings"
        Me.Lbl_FontSettings.Size = New System.Drawing.Size(34, 16)
        Me.Lbl_FontSettings.TabIndex = 1
        Me.Lbl_FontSettings.Text = "Font:"
        '
        'Label_SpaceSettings
        '
        Me.Label_SpaceSettings.AutoSize = True
        Me.Label_SpaceSettings.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SpaceSettings.Location = New System.Drawing.Point(5, 63)
        Me.Label_SpaceSettings.Name = "Label_SpaceSettings"
        Me.Label_SpaceSettings.Size = New System.Drawing.Size(56, 16)
        Me.Label_SpaceSettings.TabIndex = 1
        Me.Label_SpaceSettings.Text = "Spacing:"
        '
        'Lbl_ViewSettings
        '
        Me.Lbl_ViewSettings.AutoSize = True
        Me.Lbl_ViewSettings.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ViewSettings.Location = New System.Drawing.Point(5, 14)
        Me.Lbl_ViewSettings.Name = "Lbl_ViewSettings"
        Me.Lbl_ViewSettings.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_ViewSettings.TabIndex = 1
        Me.Lbl_ViewSettings.Text = "View Mode:"
        '
        'Cbox_FontSize
        '
        Me.Cbox_FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_FontSize.FormattingEnabled = True
        Me.Cbox_FontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18"})
        Me.Cbox_FontSize.Location = New System.Drawing.Point(199, 127)
        Me.Cbox_FontSize.Name = "Cbox_FontSize"
        Me.Cbox_FontSize.Size = New System.Drawing.Size(45, 21)
        Me.Cbox_FontSize.TabIndex = 0
        '
        'Cbox_FontStyleSettings
        '
        Me.Cbox_FontStyleSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_FontStyleSettings.FormattingEnabled = True
        Me.Cbox_FontStyleSettings.Location = New System.Drawing.Point(122, 127)
        Me.Cbox_FontStyleSettings.Name = "Cbox_FontStyleSettings"
        Me.Cbox_FontStyleSettings.Size = New System.Drawing.Size(71, 21)
        Me.Cbox_FontStyleSettings.TabIndex = 0
        '
        'Cbox_FontSettings
        '
        Me.Cbox_FontSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_FontSettings.FormattingEnabled = True
        Me.Cbox_FontSettings.Location = New System.Drawing.Point(7, 127)
        Me.Cbox_FontSettings.Name = "Cbox_FontSettings"
        Me.Cbox_FontSettings.Size = New System.Drawing.Size(109, 21)
        Me.Cbox_FontSettings.TabIndex = 0
        '
        'Cbox_GridSettings
        '
        Me.Cbox_GridSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_GridSettings.FormattingEnabled = True
        Me.Cbox_GridSettings.Items.AddRange(New Object() {"None", "Lines", "Divisions"})
        Me.Cbox_GridSettings.Location = New System.Drawing.Point(8, 174)
        Me.Cbox_GridSettings.Name = "Cbox_GridSettings"
        Me.Cbox_GridSettings.Size = New System.Drawing.Size(237, 21)
        Me.Cbox_GridSettings.TabIndex = 0
        '
        'Cbox_ArrangeSettings
        '
        Me.Cbox_ArrangeSettings.BackColor = System.Drawing.Color.White
        Me.Cbox_ArrangeSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_ArrangeSettings.FormattingEnabled = True
        Me.Cbox_ArrangeSettings.Items.AddRange(New Object() {"Default Length", "Header Length", "Content Length"})
        Me.Cbox_ArrangeSettings.Location = New System.Drawing.Point(7, 81)
        Me.Cbox_ArrangeSettings.Name = "Cbox_ArrangeSettings"
        Me.Cbox_ArrangeSettings.Size = New System.Drawing.Size(237, 21)
        Me.Cbox_ArrangeSettings.TabIndex = 0
        '
        'Cbox_ViewSettings
        '
        Me.Cbox_ViewSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_ViewSettings.FormattingEnabled = True
        Me.Cbox_ViewSettings.Items.AddRange(New Object() {"Details", "List", "Large Icons", "Small Icons", "Tile"})
        Me.Cbox_ViewSettings.Location = New System.Drawing.Point(7, 32)
        Me.Cbox_ViewSettings.Name = "Cbox_ViewSettings"
        Me.Cbox_ViewSettings.Size = New System.Drawing.Size(237, 21)
        Me.Cbox_ViewSettings.TabIndex = 0
        '
        'Btn_BookSettings
        '
        Me.Btn_BookSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BookSettings.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Settings
        Me.Btn_BookSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_BookSettings.FlatAppearance.BorderSize = 0
        Me.Btn_BookSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BookSettings.Location = New System.Drawing.Point(760, 33)
        Me.Btn_BookSettings.Name = "Btn_BookSettings"
        Me.Btn_BookSettings.Size = New System.Drawing.Size(24, 24)
        Me.Btn_BookSettings.TabIndex = 4
        Me.Btn_BookSettings.UseVisualStyleBackColor = True
        '
        'Btn_UpdateBook
        '
        Me.Btn_UpdateBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_UpdateBook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_UpdateBook.FlatAppearance.BorderSize = 0
        Me.Btn_UpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_UpdateBook.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdateBook.Location = New System.Drawing.Point(546, 463)
        Me.Btn_UpdateBook.Name = "Btn_UpdateBook"
        Me.Btn_UpdateBook.Size = New System.Drawing.Size(114, 26)
        Me.Btn_UpdateBook.TabIndex = 3
        Me.Btn_UpdateBook.Text = "Update"
        Me.Btn_UpdateBook.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Delete.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Delete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.Location = New System.Drawing.Point(422, 463)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Delete.TabIndex = 3
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_AddBook
        '
        Me.Btn_AddBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddBook.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_AddBook.FlatAppearance.BorderSize = 0
        Me.Btn_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddBook.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddBook.Location = New System.Drawing.Point(669, 463)
        Me.Btn_AddBook.Name = "Btn_AddBook"
        Me.Btn_AddBook.Size = New System.Drawing.Size(114, 26)
        Me.Btn_AddBook.TabIndex = 3
        Me.Btn_AddBook.Text = "Add"
        Me.Btn_AddBook.UseVisualStyleBackColor = False
        '
        'Btn_BookSearch
        '
        Me.Btn_BookSearch.Location = New System.Drawing.Point(294, 23)
        Me.Btn_BookSearch.Name = "Btn_BookSearch"
        Me.Btn_BookSearch.Size = New System.Drawing.Size(75, 23)
        Me.Btn_BookSearch.TabIndex = 2
        Me.Btn_BookSearch.Text = "Search"
        Me.Btn_BookSearch.UseVisualStyleBackColor = True
        '
        'Txtbox_InvSearchBar
        '
        Me.Txtbox_InvSearchBar.Location = New System.Drawing.Point(21, 25)
        Me.Txtbox_InvSearchBar.Name = "Txtbox_InvSearchBar"
        Me.Txtbox_InvSearchBar.Size = New System.Drawing.Size(267, 20)
        Me.Txtbox_InvSearchBar.TabIndex = 1
        '
        'ListView_Books
        '
        Me.ListView_Books.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Books.BackColor = System.Drawing.SystemColors.Window
        Me.ListView_Books.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView_Books.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CH_Title, Me.CH_Author, Me.CH_ISBN, Me.CH_YearPublished, Me.CH_Code, Me.CH_Category, Me.CH_ShelveNo})
        Me.ListView_Books.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Books.FullRowSelect = True
        Me.ListView_Books.HideSelection = False
        Me.ListView_Books.Location = New System.Drawing.Point(21, 62)
        Me.ListView_Books.Name = "ListView_Books"
        Me.ListView_Books.Size = New System.Drawing.Size(762, 382)
        Me.ListView_Books.TabIndex = 0
        Me.ListView_Books.UseCompatibleStateImageBehavior = False
        Me.ListView_Books.View = System.Windows.Forms.View.Details
        '
        'CH_Title
        '
        Me.CH_Title.Text = "Name"
        Me.CH_Title.Width = 200
        '
        'CH_Author
        '
        Me.CH_Author.Text = "Author"
        Me.CH_Author.Width = 200
        '
        'CH_ISBN
        '
        Me.CH_ISBN.Text = "ISBN No"
        Me.CH_ISBN.Width = 150
        '
        'CH_YearPublished
        '
        Me.CH_YearPublished.Text = "Year Published"
        Me.CH_YearPublished.Width = 130
        '
        'CH_Code
        '
        Me.CH_Code.Text = "Code No"
        Me.CH_Code.Width = 100
        '
        'CH_Category
        '
        Me.CH_Category.Text = "Category"
        Me.CH_Category.Width = 100
        '
        'CH_ShelveNo
        '
        Me.CH_ShelveNo.Text = "Shelve No"
        Me.CH_ShelveNo.Width = 100
        '
        'UserControl_Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.Panel_BookSettings)
        Me.Controls.Add(Me.ListView_Books)
        Me.Controls.Add(Me.Btn_AddBook)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_UpdateBook)
        Me.Controls.Add(Me.Btn_BookSettings)
        Me.Controls.Add(Me.Txtbox_InvSearchBar)
        Me.Controls.Add(Me.Btn_BookSearch)
        Me.Name = "UserControl_Books"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.Panel_BookSettings.ResumeLayout(False)
        Me.Panel_BookSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_BookSettings As Panel
    Friend WithEvents Lbl_GridSettings As Label
    Friend WithEvents Lbl_FontSettings As Label
    Friend WithEvents Label_SpaceSettings As Label
    Friend WithEvents Lbl_ViewSettings As Label
    Friend WithEvents Cbox_FontSize As ComboBox
    Friend WithEvents Cbox_FontStyleSettings As ComboBox
    Friend WithEvents Cbox_FontSettings As ComboBox
    Friend WithEvents Cbox_GridSettings As ComboBox
    Friend WithEvents Cbox_ArrangeSettings As ComboBox
    Friend WithEvents Cbox_ViewSettings As ComboBox
    Friend WithEvents Btn_BookSettings As Button
    Friend WithEvents Btn_UpdateBook As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_AddBook As Button
    Friend WithEvents Btn_BookSearch As Button
    Friend WithEvents Txtbox_InvSearchBar As TextBox
    Friend WithEvents ListView_Books As ListView
    Friend WithEvents CH_Title As ColumnHeader
    Friend WithEvents CH_Author As ColumnHeader
    Protected Friend WithEvents CH_ISBN As ColumnHeader
    Friend WithEvents CH_YearPublished As ColumnHeader
    Friend WithEvents CH_Code As ColumnHeader
    Friend WithEvents CH_Category As ColumnHeader
    Friend WithEvents CH_ShelveNo As ColumnHeader
End Class

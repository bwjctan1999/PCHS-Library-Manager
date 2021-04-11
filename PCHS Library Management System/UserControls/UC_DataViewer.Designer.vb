<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DataViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ListViewer = New System.Windows.Forms.ListView()
        Me.Btn_ListSettings = New System.Windows.Forms.Button()
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
        Me.Txtbox_Searchbar = New System.Windows.Forms.TextBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.ListViewSearch = New System.Windows.Forms.ListView()
        Me.Panel_BookSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewer
        '
        Me.ListViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewer.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewer.FullRowSelect = True
        Me.ListViewer.HideSelection = False
        Me.ListViewer.Location = New System.Drawing.Point(2, 31)
        Me.ListViewer.Name = "ListViewer"
        Me.ListViewer.Size = New System.Drawing.Size(762, 382)
        Me.ListViewer.TabIndex = 1
        Me.ListViewer.UseCompatibleStateImageBehavior = False
        Me.ListViewer.View = System.Windows.Forms.View.Details
        '
        'Btn_ListSettings
        '
        Me.Btn_ListSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_ListSettings.BackgroundImage = Global.PCHS_Library_Management_System.My.Resources.Resources.Icon_Settings
        Me.Btn_ListSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_ListSettings.FlatAppearance.BorderSize = 0
        Me.Btn_ListSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ListSettings.Location = New System.Drawing.Point(739, 3)
        Me.Btn_ListSettings.Name = "Btn_ListSettings"
        Me.Btn_ListSettings.Size = New System.Drawing.Size(24, 24)
        Me.Btn_ListSettings.TabIndex = 5
        Me.Btn_ListSettings.UseVisualStyleBackColor = True
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
        Me.Panel_BookSettings.Location = New System.Drawing.Point(487, 3)
        Me.Panel_BookSettings.Name = "Panel_BookSettings"
        Me.Panel_BookSettings.Size = New System.Drawing.Size(252, 272)
        Me.Panel_BookSettings.TabIndex = 6
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
        Me.Cbox_ViewSettings.Items.AddRange(New Object() {"Details", "Large Icons", "Tile"})
        Me.Cbox_ViewSettings.Location = New System.Drawing.Point(7, 32)
        Me.Cbox_ViewSettings.Name = "Cbox_ViewSettings"
        Me.Cbox_ViewSettings.Size = New System.Drawing.Size(237, 21)
        Me.Cbox_ViewSettings.TabIndex = 0
        '
        'Txtbox_Searchbar
        '
        Me.Txtbox_Searchbar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_Searchbar.Location = New System.Drawing.Point(3, 0)
        Me.Txtbox_Searchbar.Name = "Txtbox_Searchbar"
        Me.Txtbox_Searchbar.Size = New System.Drawing.Size(283, 23)
        Me.Txtbox_Searchbar.TabIndex = 7
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_Search.FlatAppearance.BorderSize = 0
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Location = New System.Drawing.Point(292, -1)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(75, 24)
        Me.Btn_Search.TabIndex = 8
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'ListViewSearch
        '
        Me.ListViewSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewSearch.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewSearch.FullRowSelect = True
        Me.ListViewSearch.HideSelection = False
        Me.ListViewSearch.Location = New System.Drawing.Point(2, 31)
        Me.ListViewSearch.Name = "ListViewSearch"
        Me.ListViewSearch.Size = New System.Drawing.Size(762, 382)
        Me.ListViewSearch.TabIndex = 9
        Me.ListViewSearch.UseCompatibleStateImageBehavior = False
        Me.ListViewSearch.View = System.Windows.Forms.View.Details
        Me.ListViewSearch.Visible = False
        '
        'UC_DataViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel_BookSettings)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txtbox_Searchbar)
        Me.Controls.Add(Me.Btn_ListSettings)
        Me.Controls.Add(Me.ListViewer)
        Me.Controls.Add(Me.ListViewSearch)
        Me.Name = "UC_DataViewer"
        Me.Size = New System.Drawing.Size(766, 415)
        Me.Panel_BookSettings.ResumeLayout(False)
        Me.Panel_BookSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewer As ListView
    Friend WithEvents Btn_ListSettings As Button
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
    Friend WithEvents Txtbox_Searchbar As TextBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents ListViewSearch As ListView
End Class

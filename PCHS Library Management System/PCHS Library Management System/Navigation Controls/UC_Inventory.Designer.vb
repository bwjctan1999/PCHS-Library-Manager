<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Inventory
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
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.Btn_AddBook = New System.Windows.Forms.Button()
        Me.Btn_DeleteBook = New System.Windows.Forms.Button()
        Me.Btn_UpdateBook = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserControl_DataViewer
        '
        Me.UserControl_DataViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl_DataViewer.BackColor = System.Drawing.Color.Transparent
        Me.UserControl_DataViewer.Location = New System.Drawing.Point(19, 34)
        Me.UserControl_DataViewer.Name = "UserControl_DataViewer"
        Me.UserControl_DataViewer.Size = New System.Drawing.Size(766, 415)
        Me.UserControl_DataViewer.TabIndex = 0
        '
        'Btn_AddBook
        '
        Me.Btn_AddBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddBook.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_AddBook.FlatAppearance.BorderSize = 0
        Me.Btn_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddBook.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddBook.Location = New System.Drawing.Point(670, 467)
        Me.Btn_AddBook.Name = "Btn_AddBook"
        Me.Btn_AddBook.Size = New System.Drawing.Size(114, 26)
        Me.Btn_AddBook.TabIndex = 4
        Me.Btn_AddBook.Text = "Add"
        Me.Btn_AddBook.UseVisualStyleBackColor = False
        '
        'Btn_DeleteBook
        '
        Me.Btn_DeleteBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_DeleteBook.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_DeleteBook.FlatAppearance.BorderSize = 0
        Me.Btn_DeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_DeleteBook.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DeleteBook.Location = New System.Drawing.Point(423, 467)
        Me.Btn_DeleteBook.Name = "Btn_DeleteBook"
        Me.Btn_DeleteBook.Size = New System.Drawing.Size(114, 26)
        Me.Btn_DeleteBook.TabIndex = 5
        Me.Btn_DeleteBook.Text = "Delete"
        Me.Btn_DeleteBook.UseVisualStyleBackColor = False
        '
        'Btn_UpdateBook
        '
        Me.Btn_UpdateBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_UpdateBook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_UpdateBook.FlatAppearance.BorderSize = 0
        Me.Btn_UpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_UpdateBook.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdateBook.Location = New System.Drawing.Point(547, 467)
        Me.Btn_UpdateBook.Name = "Btn_UpdateBook"
        Me.Btn_UpdateBook.Size = New System.Drawing.Size(114, 26)
        Me.Btn_UpdateBook.TabIndex = 6
        Me.Btn_UpdateBook.Text = "Update"
        Me.Btn_UpdateBook.UseVisualStyleBackColor = False
        '
        'UC_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.Btn_AddBook)
        Me.Controls.Add(Me.Btn_DeleteBook)
        Me.Controls.Add(Me.Btn_UpdateBook)
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Name = "UC_Inventory"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl_DataViewer As UC_DataViewer
    Friend WithEvents Btn_AddBook As Button
    Friend WithEvents Btn_DeleteBook As Button
    Friend WithEvents Btn_UpdateBook As Button
End Class

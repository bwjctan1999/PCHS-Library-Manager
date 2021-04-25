<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Subjects
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
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.SuspendLayout()
        '
        'Btn_Add
        '
        Me.Btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Add.FlatAppearance.BorderSize = 0
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Location = New System.Drawing.Point(669, 467)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Add.TabIndex = 15
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Delete.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Delete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.Location = New System.Drawing.Point(422, 467)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Delete.TabIndex = 16
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_Update
        '
        Me.Btn_Update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Update.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_Update.FlatAppearance.BorderSize = 0
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Update.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.Location = New System.Drawing.Point(546, 467)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Update.TabIndex = 17
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
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
        Me.UserControl_DataViewer.TabIndex = 14
        '
        'UC_Subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Name = "UC_Subjects"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Update As Button
    Friend WithEvents UserControl_DataViewer As UC_DataViewer
End Class

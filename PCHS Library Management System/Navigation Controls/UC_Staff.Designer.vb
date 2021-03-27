<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Staff
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
        Me.Btn_AddStaff = New System.Windows.Forms.Button()
        Me.Btn_DeleteStaff = New System.Windows.Forms.Button()
        Me.Btn_UpdateStaff = New System.Windows.Forms.Button()
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
        Me.UserControl_DataViewer.TabIndex = 8
        '
        'Btn_AddStaff
        '
        Me.Btn_AddStaff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddStaff.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_AddStaff.FlatAppearance.BorderSize = 0
        Me.Btn_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddStaff.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddStaff.Location = New System.Drawing.Point(669, 465)
        Me.Btn_AddStaff.Name = "Btn_AddStaff"
        Me.Btn_AddStaff.Size = New System.Drawing.Size(114, 26)
        Me.Btn_AddStaff.TabIndex = 9
        Me.Btn_AddStaff.Text = "Add"
        Me.Btn_AddStaff.UseVisualStyleBackColor = False
        '
        'Btn_DeleteStaff
        '
        Me.Btn_DeleteStaff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_DeleteStaff.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_DeleteStaff.FlatAppearance.BorderSize = 0
        Me.Btn_DeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_DeleteStaff.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DeleteStaff.Location = New System.Drawing.Point(422, 465)
        Me.Btn_DeleteStaff.Name = "Btn_DeleteStaff"
        Me.Btn_DeleteStaff.Size = New System.Drawing.Size(114, 26)
        Me.Btn_DeleteStaff.TabIndex = 10
        Me.Btn_DeleteStaff.Text = "Delete"
        Me.Btn_DeleteStaff.UseVisualStyleBackColor = False
        '
        'Btn_UpdateStaff
        '
        Me.Btn_UpdateStaff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_UpdateStaff.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_UpdateStaff.FlatAppearance.BorderSize = 0
        Me.Btn_UpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_UpdateStaff.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdateStaff.Location = New System.Drawing.Point(546, 465)
        Me.Btn_UpdateStaff.Name = "Btn_UpdateStaff"
        Me.Btn_UpdateStaff.Size = New System.Drawing.Size(114, 26)
        Me.Btn_UpdateStaff.TabIndex = 11
        Me.Btn_UpdateStaff.Text = "Update"
        Me.Btn_UpdateStaff.UseVisualStyleBackColor = False
        '
        'UC_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.Btn_AddStaff)
        Me.Controls.Add(Me.Btn_DeleteStaff)
        Me.Controls.Add(Me.Btn_UpdateStaff)
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Name = "UC_Staff"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl_DataViewer As UC_DataViewer
    Friend WithEvents Btn_AddStaff As Button
    Friend WithEvents Btn_DeleteStaff As Button
    Friend WithEvents Btn_UpdateStaff As Button
End Class

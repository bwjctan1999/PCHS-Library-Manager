<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Staff
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
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.Btn_AddStaff = New System.Windows.Forms.Button()
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
        'UC_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.Btn_AddStaff)
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Name = "UC_Staff"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl_DataViewer As UC_DataViewer
    Friend WithEvents Btn_AddStaff As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Borrows
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
        Me.Btn_Reject = New System.Windows.Forms.Button()
        Me.Btn_Confirm = New System.Windows.Forms.Button()
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.SuspendLayout()
        '
        'Btn_Reject
        '
        Me.Btn_Reject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Reject.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Reject.FlatAppearance.BorderSize = 0
        Me.Btn_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reject.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reject.Location = New System.Drawing.Point(547, 467)
        Me.Btn_Reject.Name = "Btn_Reject"
        Me.Btn_Reject.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Reject.TabIndex = 3
        Me.Btn_Reject.Text = "Reject"
        Me.Btn_Reject.UseVisualStyleBackColor = False
        '
        'Btn_Confirm
        '
        Me.Btn_Confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Confirm.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Confirm.FlatAppearance.BorderSize = 0
        Me.Btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Confirm.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Confirm.Location = New System.Drawing.Point(670, 467)
        Me.Btn_Confirm.Name = "Btn_Confirm"
        Me.Btn_Confirm.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Confirm.TabIndex = 3
        Me.Btn_Confirm.Text = "Confirm"
        Me.Btn_Confirm.UseVisualStyleBackColor = False
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
        Me.UserControl_DataViewer.TabIndex = 4
        '
        'UC_Borrows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Controls.Add(Me.Btn_Confirm)
        Me.Controls.Add(Me.Btn_Reject)
        Me.Name = "UC_Borrows"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Reject As Button
    Friend WithEvents Btn_Confirm As Button
    Friend WithEvents UserControl_DataViewer As UC_DataViewer
End Class

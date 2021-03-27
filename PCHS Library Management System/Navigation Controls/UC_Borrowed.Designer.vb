<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Borrowed
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
        Me.Btn_Return = New System.Windows.Forms.Button()
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.SuspendLayout()
        '
        'Btn_Return
        '
        Me.Btn_Return.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Return.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Return.FlatAppearance.BorderSize = 0
        Me.Btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Return.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Return.Location = New System.Drawing.Point(670, 467)
        Me.Btn_Return.Name = "Btn_Return"
        Me.Btn_Return.Size = New System.Drawing.Size(114, 26)
        Me.Btn_Return.TabIndex = 5
        Me.Btn_Return.Text = "Return"
        Me.Btn_Return.UseVisualStyleBackColor = False
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
        Me.UserControl_DataViewer.TabIndex = 7
        '
        'UC_Borrowed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.Controls.Add(Me.Btn_Return)
        Me.Name = "UC_Borrowed"
        Me.Size = New System.Drawing.Size(804, 508)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl_DataViewer As UC_DataViewer
    Friend WithEvents Btn_Return As Button
End Class

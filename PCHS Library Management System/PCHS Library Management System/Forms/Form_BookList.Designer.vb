<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BookList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BookList))
        Me.UserControl_DataViewer = New PCHS_Library_Management_System.UC_DataViewer()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserControl_DataViewer
        '
        Me.UserControl_DataViewer.BackColor = System.Drawing.Color.Transparent
        Me.UserControl_DataViewer.Location = New System.Drawing.Point(12, 12)
        Me.UserControl_DataViewer.Name = "UserControl_DataViewer"
        Me.UserControl_DataViewer.Size = New System.Drawing.Size(766, 415)
        Me.UserControl_DataViewer.TabIndex = 0
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.FlatAppearance.BorderSize = 0
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Add.Location = New System.Drawing.Point(660, 438)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Add.TabIndex = 14
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_Cancel.Location = New System.Drawing.Point(535, 438)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(116, 29)
        Me.Btn_Cancel.TabIndex = 15
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Form_BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 479)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.UserControl_DataViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_BookList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCHS Library Manager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl_DataViewer As UC_DataViewer
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Cancel As Button
End Class

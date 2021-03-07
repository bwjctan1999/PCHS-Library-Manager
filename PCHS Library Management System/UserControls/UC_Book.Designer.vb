<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Book
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
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.PicBox_Cover = New System.Windows.Forms.PictureBox()
        CType(Me.PicBox_Cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Title.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Title.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.White
        Me.Lbl_Title.Location = New System.Drawing.Point(11, 113)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(129, 37)
        Me.Lbl_Title.TabIndex = 3
        Me.Lbl_Title.Text = "The Great Gatsby"
        Me.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PicBox_Cover
        '
        Me.PicBox_Cover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBox_Cover.Image = Global.PCHS_Library_Management_System.My.Resources.Resources.BOOK_2
        Me.PicBox_Cover.Location = New System.Drawing.Point(34, 13)
        Me.PicBox_Cover.Name = "PicBox_Cover"
        Me.PicBox_Cover.Size = New System.Drawing.Size(80, 90)
        Me.PicBox_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox_Cover.TabIndex = 4
        Me.PicBox_Cover.TabStop = False
        '
        'UC_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PicBox_Cover)
        Me.Controls.Add(Me.Lbl_Title)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "UC_Book"
        CType(Me.PicBox_Cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Title As Label
    Friend WithEvents PicBox_Cover As PictureBox
End Class

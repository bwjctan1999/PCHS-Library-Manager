<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_SCBook
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
        Me.BookCover = New System.Windows.Forms.Panel()
        Me.Lbl_Plus = New System.Windows.Forms.Label()
        Me.BookCover.SuspendLayout()
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
        Me.Lbl_Title.TabIndex = 6
        Me.Lbl_Title.Text = "Add Book"
        Me.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BookCover
        '
        Me.BookCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BookCover.Controls.Add(Me.Lbl_Plus)
        Me.BookCover.Location = New System.Drawing.Point(34, 13)
        Me.BookCover.Name = "BookCover"
        Me.BookCover.Size = New System.Drawing.Size(80, 90)
        Me.BookCover.TabIndex = 8
        '
        'Lbl_Plus
        '
        Me.Lbl_Plus.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Plus.ForeColor = System.Drawing.Color.White
        Me.Lbl_Plus.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Plus.Name = "Lbl_Plus"
        Me.Lbl_Plus.Size = New System.Drawing.Size(80, 90)
        Me.Lbl_Plus.TabIndex = 0
        Me.Lbl_Plus.Text = "+"
        Me.Lbl_Plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UC_SCBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BookCover)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Name = "UC_SCBook"
        Me.BookCover.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents BookCover As Panel
    Friend WithEvents Lbl_Plus As Label
End Class

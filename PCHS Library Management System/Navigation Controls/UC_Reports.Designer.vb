<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Reports
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel_Books = New System.Windows.Forms.Panel()
        Me.Chart1_LegendText2 = New System.Windows.Forms.Label()
        Me.Chart1_LegendText1 = New System.Windows.Forms.Label()
        Me.Chart1_LegendColor2 = New System.Windows.Forms.Panel()
        Me.Chart1_LegendColor1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbl_Stock = New System.Windows.Forms.Label()
        Me.Panel_Subjects = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UC_SNHolder1 = New PCHS_Library_Management_System.UC_SNHolder()
        Me.Lbl_Borrowed = New System.Windows.Forms.Label()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel_Books.SuspendLayout()
        Me.Panel_Subjects.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chart2.BackColor = System.Drawing.SystemColors.Window
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(3, 6)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart2.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(145, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(149, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(106, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(67, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(166, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(154, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(125, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(84, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(28, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieLabelStyle=Disabled"
        Series1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.White
        Series1.Name = "s1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(275, 240)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.SystemColors.Window
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(135, Byte), Integer))}
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.CustomProperties = "PieLabelStyle=Disabled"
        Series2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.MarkerBorderColor = System.Drawing.Color.White
        Series2.Name = "s1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(275, 240)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel_Books)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_Subjects)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart2)
        Me.SplitContainer1.Size = New System.Drawing.Size(556, 495)
        Me.SplitContainer1.SplitterDistance = 242
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel_Books
        '
        Me.Panel_Books.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Books.BackColor = System.Drawing.Color.White
        Me.Panel_Books.Controls.Add(Me.Chart1_LegendText2)
        Me.Panel_Books.Controls.Add(Me.Chart1_LegendText1)
        Me.Panel_Books.Controls.Add(Me.Chart1_LegendColor2)
        Me.Panel_Books.Controls.Add(Me.Chart1_LegendColor1)
        Me.Panel_Books.Controls.Add(Me.Label4)
        Me.Panel_Books.Controls.Add(Me.Label7)
        Me.Panel_Books.Controls.Add(Me.Lbl_Borrowed)
        Me.Panel_Books.Controls.Add(Me.Lbl_Stock)
        Me.Panel_Books.Location = New System.Drawing.Point(278, 3)
        Me.Panel_Books.Name = "Panel_Books"
        Me.Panel_Books.Size = New System.Drawing.Size(275, 240)
        Me.Panel_Books.TabIndex = 1
        '
        'Chart1_LegendText2
        '
        Me.Chart1_LegendText2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1_LegendText2.Location = New System.Drawing.Point(42, 44)
        Me.Chart1_LegendText2.Name = "Chart1_LegendText2"
        Me.Chart1_LegendText2.Size = New System.Drawing.Size(125, 17)
        Me.Chart1_LegendText2.TabIndex = 1
        Me.Chart1_LegendText2.Text = "Borrowed Books"
        '
        'Chart1_LegendText1
        '
        Me.Chart1_LegendText1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1_LegendText1.Location = New System.Drawing.Point(42, 27)
        Me.Chart1_LegendText1.Name = "Chart1_LegendText1"
        Me.Chart1_LegendText1.Size = New System.Drawing.Size(125, 17)
        Me.Chart1_LegendText1.TabIndex = 1
        Me.Chart1_LegendText1.Text = "In Stock"
        '
        'Chart1_LegendColor2
        '
        Me.Chart1_LegendColor2.BackColor = System.Drawing.Color.DimGray
        Me.Chart1_LegendColor2.Location = New System.Drawing.Point(15, 47)
        Me.Chart1_LegendColor2.Name = "Chart1_LegendColor2"
        Me.Chart1_LegendColor2.Size = New System.Drawing.Size(20, 10)
        Me.Chart1_LegendColor2.TabIndex = 0
        '
        'Chart1_LegendColor1
        '
        Me.Chart1_LegendColor1.BackColor = System.Drawing.Color.Gray
        Me.Chart1_LegendColor1.Location = New System.Drawing.Point(15, 30)
        Me.Chart1_LegendColor1.Name = "Chart1_LegendColor1"
        Me.Chart1_LegendColor1.Size = New System.Drawing.Size(20, 10)
        Me.Chart1_LegendColor1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Books"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(185, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Quantity"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_Stock
        '
        Me.Lbl_Stock.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Stock.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Lbl_Stock.Location = New System.Drawing.Point(185, 27)
        Me.Lbl_Stock.MaximumSize = New System.Drawing.Size(50, 17)
        Me.Lbl_Stock.Name = "Lbl_Stock"
        Me.Lbl_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_Stock.Size = New System.Drawing.Size(50, 17)
        Me.Lbl_Stock.TabIndex = 1
        Me.Lbl_Stock.Text = "0000"
        '
        'Panel_Subjects
        '
        Me.Panel_Subjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Subjects.BackColor = System.Drawing.Color.White
        Me.Panel_Subjects.Controls.Add(Me.Label2)
        Me.Panel_Subjects.Controls.Add(Me.Label1)
        Me.Panel_Subjects.Location = New System.Drawing.Point(278, 6)
        Me.Panel_Subjects.Name = "Panel_Subjects"
        Me.Panel_Subjects.Size = New System.Drawing.Size(275, 240)
        Me.Panel_Subjects.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(185, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UC_SNHolder1
        '
        Me.UC_SNHolder1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_SNHolder1.BackColor = System.Drawing.Color.White
        Me.UC_SNHolder1.Location = New System.Drawing.Point(566, 9)
        Me.UC_SNHolder1.Name = "UC_SNHolder1"
        Me.UC_SNHolder1.Size = New System.Drawing.Size(230, 489)
        Me.UC_SNHolder1.TabIndex = 2
        '
        'Lbl_Borrowed
        '
        Me.Lbl_Borrowed.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Borrowed.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Lbl_Borrowed.Location = New System.Drawing.Point(185, 44)
        Me.Lbl_Borrowed.MaximumSize = New System.Drawing.Size(50, 17)
        Me.Lbl_Borrowed.Name = "Lbl_Borrowed"
        Me.Lbl_Borrowed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_Borrowed.Size = New System.Drawing.Size(50, 17)
        Me.Lbl_Borrowed.TabIndex = 1
        Me.Lbl_Borrowed.Text = "0000"
        '
        'UC_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.UC_SNHolder1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UC_Reports"
        Me.Size = New System.Drawing.Size(804, 508)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel_Books.ResumeLayout(False)
        Me.Panel_Subjects.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel_Books As Panel
    Friend WithEvents Chart1_LegendColor2 As Panel
    Friend WithEvents Chart1_LegendColor1 As Panel
    Friend WithEvents Chart1_LegendText1 As Label
    Friend WithEvents Chart1_LegendText2 As Label
    Friend WithEvents Panel_Subjects As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UC_SNHolder1 As UC_SNHolder
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbl_Stock As Label
    Friend WithEvents Lbl_Borrowed As Label
End Class

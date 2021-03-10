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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1_LegendText2 = New System.Windows.Forms.Label()
        Me.Chart1_LegendText1 = New System.Windows.Forms.Label()
        Me.Chart1_LegendColor2 = New System.Windows.Forms.Panel()
        Me.Chart1_LegendColor1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendTotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart2_LegendNum10 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText10 = New System.Windows.Forms.Label()
        Me.Chart2_LegendColor10 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendNum9 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText9 = New System.Windows.Forms.Label()
        Me.Chart2_LegendNum8 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText8 = New System.Windows.Forms.Label()
        Me.Chart2_LegendColor9 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendColor8 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendNum7 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText7 = New System.Windows.Forms.Label()
        Me.Chart2_LegendNum6 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText6 = New System.Windows.Forms.Label()
        Me.Chart2_LegendColor7 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendColor6 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendNum5 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText5 = New System.Windows.Forms.Label()
        Me.Chart2_LegendColor5 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendNum4 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText4 = New System.Windows.Forms.Label()
        Me.Chart2_LegendNum3 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText3 = New System.Windows.Forms.Label()
        Me.Chart2_LegendColor4 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendColor3 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendNum2 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart2_LegendNum1 = New System.Windows.Forms.Label()
        Me.Chart2_LegendText1 = New System.Windows.Forms.Label()
        Me.Chart2_LegendColor2 = New System.Windows.Forms.Panel()
        Me.Chart2_LegendColor1 = New System.Windows.Forms.Panel()
        Me.UC_SNHolder1 = New PCHS_Library_Management_System.UC_SNHolder()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(163, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(133, Byte), Integer))}
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart2)
        Me.SplitContainer1.Size = New System.Drawing.Size(556, 495)
        Me.SplitContainer1.SplitterDistance = 242
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Chart1_LegendText2)
        Me.Panel1.Controls.Add(Me.Chart1_LegendText1)
        Me.Panel1.Controls.Add(Me.Chart1_LegendColor2)
        Me.Panel1.Controls.Add(Me.Chart1_LegendColor1)
        Me.Panel1.Location = New System.Drawing.Point(278, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 240)
        Me.Panel1.TabIndex = 1
        '
        'Chart1_LegendText2
        '
        Me.Chart1_LegendText2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1_LegendText2.Location = New System.Drawing.Point(42, 27)
        Me.Chart1_LegendText2.Name = "Chart1_LegendText2"
        Me.Chart1_LegendText2.Size = New System.Drawing.Size(125, 17)
        Me.Chart1_LegendText2.TabIndex = 1
        Me.Chart1_LegendText2.Text = "Label2"
        '
        'Chart1_LegendText1
        '
        Me.Chart1_LegendText1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1_LegendText1.Location = New System.Drawing.Point(42, 10)
        Me.Chart1_LegendText1.Name = "Chart1_LegendText1"
        Me.Chart1_LegendText1.Size = New System.Drawing.Size(125, 17)
        Me.Chart1_LegendText1.TabIndex = 1
        Me.Chart1_LegendText1.Text = "Label1"
        '
        'Chart1_LegendColor2
        '
        Me.Chart1_LegendColor2.BackColor = System.Drawing.Color.DimGray
        Me.Chart1_LegendColor2.Location = New System.Drawing.Point(16, 32)
        Me.Chart1_LegendColor2.Name = "Chart1_LegendColor2"
        Me.Chart1_LegendColor2.Size = New System.Drawing.Size(20, 10)
        Me.Chart1_LegendColor2.TabIndex = 0
        '
        'Chart1_LegendColor1
        '
        Me.Chart1_LegendColor1.BackColor = System.Drawing.Color.Gray
        Me.Chart1_LegendColor1.Location = New System.Drawing.Point(16, 14)
        Me.Chart1_LegendColor1.Name = "Chart1_LegendColor1"
        Me.Chart1_LegendColor1.Size = New System.Drawing.Size(20, 10)
        Me.Chart1_LegendColor1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Chart2_LegendTotal)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum10)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText10)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor10)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum9)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText9)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum8)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText8)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor9)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor8)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum7)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText7)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum6)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText6)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor7)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor6)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum5)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText5)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor5)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum4)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText4)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum3)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText3)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor4)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor3)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum2)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Chart2_LegendNum1)
        Me.Panel2.Controls.Add(Me.Chart2_LegendText1)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor2)
        Me.Panel2.Controls.Add(Me.Chart2_LegendColor1)
        Me.Panel2.Location = New System.Drawing.Point(278, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(275, 240)
        Me.Panel2.TabIndex = 1
        '
        'Chart2_LegendTotal
        '
        Me.Chart2_LegendTotal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendTotal.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendTotal.Location = New System.Drawing.Point(185, 209)
        Me.Chart2_LegendTotal.Name = "Chart2_LegendTotal"
        Me.Chart2_LegendTotal.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendTotal.TabIndex = 17
        Me.Chart2_LegendTotal.Text = "Label2"
        Me.Chart2_LegendTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(191, 203)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(50, 2)
        Me.Panel3.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(150, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendNum10
        '
        Me.Chart2_LegendNum10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum10.Location = New System.Drawing.Point(185, 183)
        Me.Chart2_LegendNum10.Name = "Chart2_LegendNum10"
        Me.Chart2_LegendNum10.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum10.TabIndex = 17
        Me.Chart2_LegendNum10.Text = "Label2"
        Me.Chart2_LegendNum10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText10
        '
        Me.Chart2_LegendText10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText10.Location = New System.Drawing.Point(42, 183)
        Me.Chart2_LegendText10.Name = "Chart2_LegendText10"
        Me.Chart2_LegendText10.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText10.TabIndex = 17
        Me.Chart2_LegendText10.Text = "Label2"
        '
        'Chart2_LegendColor10
        '
        Me.Chart2_LegendColor10.BackColor = System.Drawing.Color.DimGray
        Me.Chart2_LegendColor10.Location = New System.Drawing.Point(16, 188)
        Me.Chart2_LegendColor10.Name = "Chart2_LegendColor10"
        Me.Chart2_LegendColor10.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor10.TabIndex = 16
        '
        'Chart2_LegendNum9
        '
        Me.Chart2_LegendNum9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum9.Location = New System.Drawing.Point(185, 166)
        Me.Chart2_LegendNum9.Name = "Chart2_LegendNum9"
        Me.Chart2_LegendNum9.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum9.TabIndex = 14
        Me.Chart2_LegendNum9.Text = "Label2"
        Me.Chart2_LegendNum9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText9
        '
        Me.Chart2_LegendText9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText9.Location = New System.Drawing.Point(42, 166)
        Me.Chart2_LegendText9.Name = "Chart2_LegendText9"
        Me.Chart2_LegendText9.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText9.TabIndex = 14
        Me.Chart2_LegendText9.Text = "Label2"
        '
        'Chart2_LegendNum8
        '
        Me.Chart2_LegendNum8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum8.Location = New System.Drawing.Point(185, 149)
        Me.Chart2_LegendNum8.Name = "Chart2_LegendNum8"
        Me.Chart2_LegendNum8.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum8.TabIndex = 15
        Me.Chart2_LegendNum8.Text = "Label1"
        Me.Chart2_LegendNum8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText8
        '
        Me.Chart2_LegendText8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText8.Location = New System.Drawing.Point(42, 149)
        Me.Chart2_LegendText8.Name = "Chart2_LegendText8"
        Me.Chart2_LegendText8.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText8.TabIndex = 15
        Me.Chart2_LegendText8.Text = "Label1"
        '
        'Chart2_LegendColor9
        '
        Me.Chart2_LegendColor9.BackColor = System.Drawing.Color.DimGray
        Me.Chart2_LegendColor9.Location = New System.Drawing.Point(16, 171)
        Me.Chart2_LegendColor9.Name = "Chart2_LegendColor9"
        Me.Chart2_LegendColor9.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor9.TabIndex = 12
        '
        'Chart2_LegendColor8
        '
        Me.Chart2_LegendColor8.BackColor = System.Drawing.Color.Gray
        Me.Chart2_LegendColor8.Location = New System.Drawing.Point(16, 153)
        Me.Chart2_LegendColor8.Name = "Chart2_LegendColor8"
        Me.Chart2_LegendColor8.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor8.TabIndex = 13
        '
        'Chart2_LegendNum7
        '
        Me.Chart2_LegendNum7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum7.Location = New System.Drawing.Point(185, 130)
        Me.Chart2_LegendNum7.Name = "Chart2_LegendNum7"
        Me.Chart2_LegendNum7.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum7.TabIndex = 10
        Me.Chart2_LegendNum7.Text = "Label2"
        Me.Chart2_LegendNum7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText7
        '
        Me.Chart2_LegendText7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText7.Location = New System.Drawing.Point(42, 130)
        Me.Chart2_LegendText7.Name = "Chart2_LegendText7"
        Me.Chart2_LegendText7.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText7.TabIndex = 10
        Me.Chart2_LegendText7.Text = "Label2"
        '
        'Chart2_LegendNum6
        '
        Me.Chart2_LegendNum6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum6.Location = New System.Drawing.Point(185, 113)
        Me.Chart2_LegendNum6.Name = "Chart2_LegendNum6"
        Me.Chart2_LegendNum6.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum6.TabIndex = 11
        Me.Chart2_LegendNum6.Text = "Label1"
        Me.Chart2_LegendNum6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText6
        '
        Me.Chart2_LegendText6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText6.Location = New System.Drawing.Point(42, 113)
        Me.Chart2_LegendText6.Name = "Chart2_LegendText6"
        Me.Chart2_LegendText6.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText6.TabIndex = 11
        Me.Chart2_LegendText6.Text = "Label1"
        '
        'Chart2_LegendColor7
        '
        Me.Chart2_LegendColor7.BackColor = System.Drawing.Color.DimGray
        Me.Chart2_LegendColor7.Location = New System.Drawing.Point(16, 135)
        Me.Chart2_LegendColor7.Name = "Chart2_LegendColor7"
        Me.Chart2_LegendColor7.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor7.TabIndex = 8
        '
        'Chart2_LegendColor6
        '
        Me.Chart2_LegendColor6.BackColor = System.Drawing.Color.Gray
        Me.Chart2_LegendColor6.Location = New System.Drawing.Point(16, 117)
        Me.Chart2_LegendColor6.Name = "Chart2_LegendColor6"
        Me.Chart2_LegendColor6.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor6.TabIndex = 9
        '
        'Chart2_LegendNum5
        '
        Me.Chart2_LegendNum5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum5.Location = New System.Drawing.Point(185, 95)
        Me.Chart2_LegendNum5.Name = "Chart2_LegendNum5"
        Me.Chart2_LegendNum5.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum5.TabIndex = 7
        Me.Chart2_LegendNum5.Text = "Label2"
        Me.Chart2_LegendNum5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText5
        '
        Me.Chart2_LegendText5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText5.Location = New System.Drawing.Point(42, 95)
        Me.Chart2_LegendText5.Name = "Chart2_LegendText5"
        Me.Chart2_LegendText5.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText5.TabIndex = 7
        Me.Chart2_LegendText5.Text = "Label2"
        '
        'Chart2_LegendColor5
        '
        Me.Chart2_LegendColor5.BackColor = System.Drawing.Color.DimGray
        Me.Chart2_LegendColor5.Location = New System.Drawing.Point(16, 100)
        Me.Chart2_LegendColor5.Name = "Chart2_LegendColor5"
        Me.Chart2_LegendColor5.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor5.TabIndex = 6
        '
        'Chart2_LegendNum4
        '
        Me.Chart2_LegendNum4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum4.Location = New System.Drawing.Point(185, 78)
        Me.Chart2_LegendNum4.Name = "Chart2_LegendNum4"
        Me.Chart2_LegendNum4.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum4.TabIndex = 4
        Me.Chart2_LegendNum4.Text = "Label2"
        Me.Chart2_LegendNum4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText4
        '
        Me.Chart2_LegendText4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText4.Location = New System.Drawing.Point(42, 78)
        Me.Chart2_LegendText4.Name = "Chart2_LegendText4"
        Me.Chart2_LegendText4.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText4.TabIndex = 4
        Me.Chart2_LegendText4.Text = "Label2"
        '
        'Chart2_LegendNum3
        '
        Me.Chart2_LegendNum3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum3.Location = New System.Drawing.Point(185, 61)
        Me.Chart2_LegendNum3.Name = "Chart2_LegendNum3"
        Me.Chart2_LegendNum3.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum3.TabIndex = 5
        Me.Chart2_LegendNum3.Text = "Label1"
        Me.Chart2_LegendNum3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText3
        '
        Me.Chart2_LegendText3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText3.Location = New System.Drawing.Point(42, 61)
        Me.Chart2_LegendText3.Name = "Chart2_LegendText3"
        Me.Chart2_LegendText3.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText3.TabIndex = 5
        Me.Chart2_LegendText3.Text = "Label1"
        '
        'Chart2_LegendColor4
        '
        Me.Chart2_LegendColor4.BackColor = System.Drawing.Color.DimGray
        Me.Chart2_LegendColor4.Location = New System.Drawing.Point(16, 83)
        Me.Chart2_LegendColor4.Name = "Chart2_LegendColor4"
        Me.Chart2_LegendColor4.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor4.TabIndex = 2
        '
        'Chart2_LegendColor3
        '
        Me.Chart2_LegendColor3.BackColor = System.Drawing.Color.Gray
        Me.Chart2_LegendColor3.Location = New System.Drawing.Point(16, 65)
        Me.Chart2_LegendColor3.Name = "Chart2_LegendColor3"
        Me.Chart2_LegendColor3.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor3.TabIndex = 3
        '
        'Chart2_LegendNum2
        '
        Me.Chart2_LegendNum2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum2.Location = New System.Drawing.Point(185, 42)
        Me.Chart2_LegendNum2.Name = "Chart2_LegendNum2"
        Me.Chart2_LegendNum2.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum2.TabIndex = 1
        Me.Chart2_LegendNum2.Text = "Label2"
        Me.Chart2_LegendNum2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText2
        '
        Me.Chart2_LegendText2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText2.Location = New System.Drawing.Point(42, 42)
        Me.Chart2_LegendText2.Name = "Chart2_LegendText2"
        Me.Chart2_LegendText2.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText2.TabIndex = 1
        Me.Chart2_LegendText2.Text = "Label2"
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
        'Chart2_LegendNum1
        '
        Me.Chart2_LegendNum1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendNum1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Chart2_LegendNum1.Location = New System.Drawing.Point(185, 25)
        Me.Chart2_LegendNum1.Name = "Chart2_LegendNum1"
        Me.Chart2_LegendNum1.Size = New System.Drawing.Size(50, 17)
        Me.Chart2_LegendNum1.TabIndex = 1
        Me.Chart2_LegendNum1.Text = "Label1"
        Me.Chart2_LegendNum1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Chart2_LegendText1
        '
        Me.Chart2_LegendText1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart2_LegendText1.Location = New System.Drawing.Point(42, 25)
        Me.Chart2_LegendText1.Name = "Chart2_LegendText1"
        Me.Chart2_LegendText1.Size = New System.Drawing.Size(125, 17)
        Me.Chart2_LegendText1.TabIndex = 1
        Me.Chart2_LegendText1.Text = "Label1"
        '
        'Chart2_LegendColor2
        '
        Me.Chart2_LegendColor2.BackColor = System.Drawing.Color.DimGray
        Me.Chart2_LegendColor2.Location = New System.Drawing.Point(16, 47)
        Me.Chart2_LegendColor2.Name = "Chart2_LegendColor2"
        Me.Chart2_LegendColor2.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor2.TabIndex = 0
        '
        'Chart2_LegendColor1
        '
        Me.Chart2_LegendColor1.BackColor = System.Drawing.Color.Gray
        Me.Chart2_LegendColor1.Location = New System.Drawing.Point(16, 29)
        Me.Chart2_LegendColor1.Name = "Chart2_LegendColor1"
        Me.Chart2_LegendColor1.Size = New System.Drawing.Size(20, 10)
        Me.Chart2_LegendColor1.TabIndex = 0
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chart1_LegendColor2 As Panel
    Friend WithEvents Chart1_LegendColor1 As Panel
    Friend WithEvents Chart1_LegendText1 As Label
    Friend WithEvents Chart1_LegendText2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Chart2_LegendText2 As Label
    Friend WithEvents Chart2_LegendText1 As Label
    Friend WithEvents Chart2_LegendColor2 As Panel
    Friend WithEvents Chart2_LegendColor1 As Panel
    Friend WithEvents Chart2_LegendText10 As Label
    Friend WithEvents Chart2_LegendColor10 As Panel
    Friend WithEvents Chart2_LegendText9 As Label
    Friend WithEvents Chart2_LegendText8 As Label
    Friend WithEvents Chart2_LegendColor9 As Panel
    Friend WithEvents Chart2_LegendColor8 As Panel
    Friend WithEvents Chart2_LegendText7 As Label
    Friend WithEvents Chart2_LegendText6 As Label
    Friend WithEvents Chart2_LegendColor7 As Panel
    Friend WithEvents Chart2_LegendColor6 As Panel
    Friend WithEvents Chart2_LegendText5 As Label
    Friend WithEvents Chart2_LegendColor5 As Panel
    Friend WithEvents Chart2_LegendText4 As Label
    Friend WithEvents Chart2_LegendText3 As Label
    Friend WithEvents Chart2_LegendColor4 As Panel
    Friend WithEvents Chart2_LegendColor3 As Panel
    Friend WithEvents Chart2_LegendNum10 As Label
    Friend WithEvents Chart2_LegendNum9 As Label
    Friend WithEvents Chart2_LegendNum8 As Label
    Friend WithEvents Chart2_LegendNum7 As Label
    Friend WithEvents Chart2_LegendNum6 As Label
    Friend WithEvents Chart2_LegendNum5 As Label
    Friend WithEvents Chart2_LegendNum4 As Label
    Friend WithEvents Chart2_LegendNum3 As Label
    Friend WithEvents Chart2_LegendNum2 As Label
    Friend WithEvents Chart2_LegendNum1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart2_LegendTotal As Label
    Friend WithEvents UC_SNHolder1 As UC_SNHolder
End Class

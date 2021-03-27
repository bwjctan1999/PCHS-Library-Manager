Imports System.Windows.Forms.DataVisualization.Charting

Public Class UC_Reports
    Public Sub Load_Data()
        Load_Borrowed_Data()
        Load_Categories_Data()
    End Sub

    Private Sub Load_Borrowed_Data()
        Dim Title_States = New Title()
        Title_States.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        Title_States.Text = "BOOK STATES"

        Chart1.Titles.Add(Title_States)
        Chart1.Series("s1").Points.AddXY("In Stock", "875")
        Chart1.Series("s1").Points.AddXY("Borrowed", "258")
        Chart1.Series("s1").Points.AddXY("Expired", "15")

        Chart1.Series("s1").Points(0).IsVisibleInLegend = False
        Chart1.Series("s1").Points(1).IsVisibleInLegend = False
        Chart1.Series("s1").Points(2).IsVisibleInLegend = False

        Chart1_LegendColor1.BackColor = Chart1.PaletteCustomColors(0)
        Chart1_LegendColor2.BackColor = Chart1.PaletteCustomColors(1)
        Chart1_LegendColor3.BackColor = Chart1.PaletteCustomColors(2)

        Chart1_LegendText1.Text = "In Stock"
        Chart1_LegendText2.Text = "Borrowed"
        Chart1_LegendText3.Text = "Expired"
        Chart1_LegendNum1.Text = "875"
        Chart1_LegendNum2.Text = "258"
        Chart1_LegendNum3.Text = "15"
    End Sub

    Private Sub Load_Categories_Data()
        Dim Title_Categories = New Title()
        Title_Categories.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        Title_Categories.Text = "Inventory Summary"


        Dim categories(,) As String = {{"Computer science, information & general works", "100"},
                                       {"Philosophy & psychology", "148"}, {"Social sciences", "126"},
                                       {"Language", "103"}, {"Religion", "91"}, {"Pure Science", "120"},
                                       {"Technology", "94"}, {"Arts & recreation", "132"},
                                       {"Literature", "121"}, {"History & geography", "113"}}

        Dim legendlabels = New Label() {Chart2_LegendText1, Chart2_LegendText2, Chart2_LegendText3, Chart2_LegendText4,
                                  Chart2_LegendText5, Chart2_LegendText6, Chart2_LegendText7, Chart2_LegendText8,
                                  Chart2_LegendText9, Chart2_LegendText10}


        Dim legendnums = New Label() {Chart2_LegendNum1, Chart2_LegendNum2, Chart2_LegendNum3, Chart2_LegendNum4,
                                  Chart2_LegendNum5, Chart2_LegendNum6, Chart2_LegendNum7, Chart2_LegendNum8,
                                  Chart2_LegendNum9, Chart2_LegendNum10}

        Dim legendcolors = New Panel() {Chart2_LegendColor1, Chart2_LegendColor2, Chart2_LegendColor3, Chart2_LegendColor4,
                                  Chart2_LegendColor5, Chart2_LegendColor6, Chart2_LegendColor7, Chart2_LegendColor8,
                                  Chart2_LegendColor9, Chart2_LegendColor10}


        Dim total As Integer = 0
        Chart2.Titles.Add(Title_Categories)
        For i As Integer = 0 To 9
            Chart2.Series("s1").Points.AddXY(categories(i, 0), categories(i, 1))
            Chart2.Series("s1").Points(i).IsVisibleInLegend = False

            legendlabels(i).Text = categories(i, 0)
            legendnums(i).Text = categories(i, 1)
            legendcolors(i).BackColor = Chart2.PaletteCustomColors(i)
            total += categories(i, 1)
        Next
        Chart2_LegendTotal.Text = total
    End Sub
End Class

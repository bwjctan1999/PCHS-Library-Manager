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
        Chart1.Series("s1").Points.AddXY("Not Borrowed", "875")
        Chart1.Series("s1").Points.AddXY("Borrowed", "258")

        Chart1.Series("s1").Points(0).IsVisibleInLegend = False
        Chart1.Series("s1").Points(1).IsVisibleInLegend = False

        Chart1_LegendColor1.BackColor = Chart1.PaletteCustomColors(0)
        Chart1_LegendColor2.BackColor = Chart1.PaletteCustomColors(1)

        Chart1_LegendText1.Text = "Not Borrowed"
        Chart1_LegendText2.Text = "Borrowed"
    End Sub

    Private Sub Load_Categories_Data()
        Dim Title_Categories = New Title()
        Title_Categories.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        Title_Categories.Text = "BOOK CATEGORIES"


        Dim categories(,) As String = {{"Computer science, information & general works", "20"},
                                       {"Philosophy & psychology", "21"}, {"Social sciences", "23"},
                                       {"Language", "22"}, {"Religion", "25"}, {"Pure Science", "25"},
                                       {"Technology", "24"}, {"Arts & recreation", "20"},
                                       {"Literature", "35"}, {"History & geography", "10"}}

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


    'STICKY NOTES FUNCTIONS
    'Private stickynotes As New List(Of UC_StickyNote)
    'Private allowCoolMove As Boolean = False
    'Private myCoolPoint As New Point

    'Private Sub Btn_CreateNote_Click(sender As Object, e As EventArgs)
    '    stickynotes.Add(New UC_StickyNote)
    '    StickyNotes_Holder.Controls.Add(stickynotes.Item(stickynotes.Count - 1))
    '    stickynotes.Item(stickynotes.Count - 1).Location = New Point(10, 10)
    '    stickynotes.Item(stickynotes.Count - 1).BringToFront()

    '    AddHandler stickynotes.Item(stickynotes.Count - 1).MouseDown, AddressOf StickyNote_MouseDown
    '    AddHandler stickynotes.Item(stickynotes.Count - 1).MouseMove, AddressOf StickyNote_MouseMove
    '    AddHandler stickynotes.Item(stickynotes.Count - 1).MouseUp, AddressOf StickyNote_MouseUp
    'End Sub

    'Private Sub StickyNote_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    allowCoolMove = True
    '    myCoolPoint = New Point(e.X, e.Y)
    '    Me.Cursor = Cursors.SizeAll
    'End Sub

    'Private Sub StickyNote_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If allowCoolMove = True Then
    '        'If StickyNote is within all borders = Allow Right, Left, Up, and Down dragging
    '        If (sender.Location.X + e.X - myCoolPoint.X) > 0 And ((sender.Location.X + e.X - myCoolPoint.X) + sender.width) < StickyNotes_Holder.Width And
    '           (sender.Location.Y + e.Y - myCoolPoint.Y) > 0 And (sender.Location.Y + e.Y - myCoolPoint.Y) + sender.height < StickyNotes_Holder.Width Then

    '            sender.Location = New Point(sender.Location.X + e.X - myCoolPoint.X, sender.Location.Y + e.Y - myCoolPoint.Y)

    '            'If StickyNote is touches left or right borders = Allow Up and Down - Left or Right dragging
    '        ElseIf (sender.Location.X + e.X - myCoolPoint.X) < 0 Or ((sender.Location.X + e.X - myCoolPoint.X) + sender.width) > StickyNotes_Holder.Width Then

    '            'If StickyNote touches Top and Bottom Borders = Stop Up or Down Dragging
    '            If (sender.Location.Y + e.Y - myCoolPoint.Y) > 0 And (sender.Location.Y + e.Y - myCoolPoint.Y) + sender.height < StickyNotes_Holder.Width Then
    '                sender.Location = New Point(sender.Location.X, sender.Location.Y + e.Y - myCoolPoint.Y)
    '            End If

    '            'If StickyNote is whithin Top or Bottom borders = Allow Left and Right - Top or Bottom dragging
    '        ElseIf (sender.Location.Y + e.Y - myCoolPoint.Y) < 0 Or (sender.Location.Y + e.Y - myCoolPoint.Y) + sender.height > StickyNotes_Holder.Width Then

    '            'If StickyNote touches Left or Right Borders = Stop Left and Right  dragging
    '            If (sender.Location.X + e.X - myCoolPoint.X) > 0 And ((sender.Location.X + e.X - myCoolPoint.X) + sender.width) < StickyNotes_Holder.Width Then
    '                sender.Location = New Point(sender.Location.X + e.X - myCoolPoint.X, sender.Location.Y)
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub StickyNote_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    allowCoolMove = False
    '    Me.Cursor = Cursors.Default
    'End Sub
End Class

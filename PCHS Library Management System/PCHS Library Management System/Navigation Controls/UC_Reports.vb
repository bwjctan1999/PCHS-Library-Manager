Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UC_Reports
    Private legendnames As New List(Of Label)
    Private legendcolors As New List(Of Panel)
    Private legendcounts As New List(Of Label)

    Public Sub Load_Data()
        Load_Borrowed_Data()
        Load_Categories_Data()
    End Sub

    Private Sub UC_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_StickyNotes()
    End Sub

    Private Sub Load_Borrowed_Data()
        Chart1.Series("s1").Points.Clear()
        Chart1.Titles.Clear()
        Dim booktotal As Integer
        Dim borrowedtotal As Integer

        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT SUM(quantity) FROM tbl_book")
            Int32.TryParse(cmd.ExecuteScalar.ToString, booktotal)

            command("SELECT COUNT(*) FROM tbl_borrowed_books")
            Int32.TryParse(cmd.ExecuteScalar.ToString, borrowedtotal)

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Dim Title_States = New Title()
        Title_States.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        Title_States.Text = "BOOK STATES"

        Chart1.Titles.Add(Title_States)
        Chart1.Series("s1").Points.AddXY("In Stock", booktotal)
        Chart1.Series("s1").Points.AddXY("Borrowed", borrowedtotal)
        Chart1.Series("s1").Points(0).IsVisibleInLegend = False
        Chart1.Series("s1").Points(1).IsVisibleInLegend = False
        Chart1_LegendColor1.BackColor = Chart1.PaletteCustomColors(0)
        Chart1_LegendColor2.BackColor = Chart1.PaletteCustomColors(1)

        Lbl_Stock.Text = booktotal
        Lbl_Borrowed.Text = borrowedtotal
    End Sub

    Private Sub Load_Categories_Data()
        Chart2.Series("s1").Points.Clear()
        Chart2.Titles.Clear()
        Dim subName As New List(Of String)
        Dim bookCount As New List(Of Integer)

        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT S.subjectID, sub_name, COUNT(B.bookID) AS TotalBooks FROM tbl_subjects S 
                    LEFT JOIN tbl_book B ON B.subjectID = S.subjectID 
                    GROUP BY S.subjectID")

            reader = cmd.ExecuteReader

            While reader.Read()
                subName.Add(reader("sub_name"))
                bookCount.Add(reader("TotalBooks"))
            End While
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim Title_Categories = New Title()
        Title_Categories.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        Title_Categories.Text = "Inventory Summary"
        Chart2.Titles.Add(Title_Categories)

        Dim legendcount As Integer = subName.Count - 1
        Dim loclabel As Integer = 27
        Dim locColor As Integer = 30
        Dim spacer As Integer = 17
        Dim total As Integer = 0

        For i As Integer = 0 To legendcount
            Chart2.Series("s1").Points.AddXY(subName(i), bookCount(i))
            Chart2.Series("s1").Points(i).IsVisibleInLegend = False

            'Add The Legend Names
            Dim labelname As New Label
            labelname.Text = subName(i)
            labelname.Font = New Drawing.Font("Century Gothic", 8, FontStyle.Regular)
            labelname.Location = New Point(42, loclabel)
            labelname.MaximumSize = New Size(125, 17)
            legendnames.Add(labelname)
            Panel_Subjects.Controls.Add(legendnames(legendnames.Count - 1))

            'Add The Legend Colors
            Dim panel As New Panel
            panel.BackColor = Chart2.PaletteCustomColors(i)
            panel.Size = New Size(20, 10)
            panel.Location = New Point(15, locColor)
            legendcolors.Add(panel)
            Panel_Subjects.Controls.Add(legendcolors(legendcolors.Count - 1))

            'Add The Legend Count
            Dim labelcount As New Label
            labelcount.Text = bookCount(i)
            labelcount.Font = New Drawing.Font("Century Gothic", 8, FontStyle.Bold)
            labelcount.TextAlign = ContentAlignment.TopRight
            labelcount.Location = New Point(185, loclabel)
            labelcount.MaximumSize = New Size(50, 17)
            legendcounts.Add(labelcount)
            Panel_Subjects.Controls.Add(legendcounts(legendcounts.Count - 1))

            total += bookCount(i)
            loclabel += spacer
            locColor += spacer
        Next

        Dim divider As New Panel
        divider.BackColor = Color.Black
        divider.Size = New Size(45, 2)
        divider.Location = New Point(190, loclabel + 5)
        Me.Panel_Subjects.Controls.Add(divider)

        Dim labeltotal As New Label
        labeltotal.Text = total
        labeltotal.Font = New Drawing.Font("Century Gothic", 8, FontStyle.Regular)
        labeltotal.TextAlign = ContentAlignment.TopRight
        labeltotal.Location = New Point(185, loclabel + 10)
        labeltotal.MaximumSize = New Size(50, 17)
        Me.Panel_Subjects.Controls.Add(labeltotal)

        Dim labeldecor As New Label
        labeldecor.Text = "Total:"
        labeldecor.Font = New Drawing.Font("Century Gothic", 8, FontStyle.Bold)
        labeldecor.TextAlign = ContentAlignment.TopRight
        labeldecor.Location = New Point(125, loclabel + 9)
        labeldecor.MaximumSize = New Size(50, 17)
        Me.Panel_Subjects.Controls.Add(labeldecor)
    End Sub

    Private Sub Load_StickyNotes()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT * FROM tbl_stickynotes WHERE (`librarianID` = @libid)")
            cmd.Parameters.AddWithValue("@libid", GetCurrentUser())
            reader = cmd.ExecuteReader()

            While reader.Read()
                UC_SNHolder1.AddNote(System.Text.Encoding.ASCII.GetChars(reader("text")), reader("location"), reader("size"), reader("color"))
            End While
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub SaveNotes()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("DELETE FROM tbl_stickynotes WHERE (`librarianID` = @id)")
            cmd.Parameters.AddWithValue("@id", GetCurrentUser())
            execute()

            For Each note As UC_StickyNote In UC_SNHolder1.GetNotes()
                Dim location As String = CStr(note.Location.X) & "," & CStr(note.Location.Y)
                Dim size As String = CStr(note.Size.Width) & "," & CStr(note.Size.Height)
                cmd.Parameters.Clear()

                command("INSERT INTO tbl_stickynotes (`text`, `location`, `size`, `color`, `librarianID`) VALUES (@text, @loc, @size, @color, @libid)")
                Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(note.GetRTF())
                cmd.Parameters.AddWithValue("@text", bytes)
                cmd.Parameters.AddWithValue("@loc", location)
                cmd.Parameters.AddWithValue("@size", size)
                cmd.Parameters.AddWithValue("@libid", GetCurrentUser())
                cmd.Parameters.AddWithValue("@color", note.GetColor())
                execute()
            Next

            closeCon()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class

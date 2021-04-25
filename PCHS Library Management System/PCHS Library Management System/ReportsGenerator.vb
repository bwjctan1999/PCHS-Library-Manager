Imports Microsoft.Office.Interop.Excel
Public Class ReportsGenerator
    Private Location As String
    Private Name As String

    Public Sub Generate()
        Try
            Dim app As New Microsoft.Office.Interop.Excel.Application
            Dim wb As Workbook = app.Workbooks.Add(XlSheetType.xlWorksheet)
            wb.Sheets("sheet1").Name = "Staff"
            Dim ws As Worksheet
            With wb
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Borrowers"
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Borrowed Books"
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Publishers"
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Subjects"
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Authors"
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Books"
                ws = .Sheets.Add(After:= .Sheets(.Sheets.Count))
                ws.Name = "Summary"
            End With
            app.Visible = False

            ws = wb.Sheets("Staff")
            GenerateStaff(ws)

            ws = wb.Sheets("Borrowers")
            GenerateBorrowers(ws)

            ws = wb.Sheets("Borrowed Books")
            GenerateBorrowed(ws)

            ws = wb.Sheets("Publishers")
            GeneratePublishers(ws)

            ws = wb.Sheets("Subjects")
            GenerateSubjects(ws)

            ws = wb.Sheets("Authors")
            GenerateAuthors(ws)

            ws = wb.Sheets("Books")
            GenerateBooks(ws)

            ws = wb.Sheets("Summary")
            GenerateSummary(ws)

            wb.SaveAs(Location & "\" & Name)
            wb.Close()
            app.Quit()
            Msg.SetContent("Report Successfuly Generated... ", "To View reports, go to the selected folder")
            Msg.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateSummary(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "INVENTORY SUMMARY"
            ws.Cells(3, 1) = "Books Count: "
            ws.Cells(4, 1) = "Subjects Count: "
            ws.Cells(5, 1) = "Authors Count: "
            ws.Cells(6, 1) = "Publishers Count: "
            ws.Cells(7, 1) = "Current Borrowed Count: "
            ws.Cells(9, 1) = "Borrowers Count: "
            ws.Cells(10, 1) = "Staff Count: "

            openCon()
            command("SELECT 
                        (SELECT COUNT(*) FROM tbl_book) as bookCount,  
                        (SELECT COUNT(*) FROM tbl_subjects) as subjectCount,
                        (SELECT COUNT(*) FROM tbl_authors) as authorCount,
                        (SELECT COUNT(*) FROM tbl_publishers) as pubCount, 
                        (SELECT COUNT(*) FROM tbl_borrowed_books) as borrowedCount, 
                        (SELECT COUNT(*) FROM tbl_borrowers) as borrowersCount,
                        (SELECT COUNT(*) FROM tbl_librarians) as libCount")

            reader = cmd.ExecuteReader

            While reader.Read
                ws.Cells(3, 2) = reader("bookCount").ToString
                ws.Cells(4, 2) = reader("subjectCount").ToString
                ws.Cells(5, 2) = reader("authorCount").ToString
                ws.Cells(6, 2) = reader("pubCount").ToString
                ws.Cells(7, 2) = reader("borrowedCount").ToString

                ws.Cells(9, 2) = reader("borrowersCount")
                ws.Cells(10, 2) = reader("libCount").ToString
            End While
            ws.Columns.AutoFit()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateBooks(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            openCon()

            ws.Cells(1, 1) = "BOOKS"
            ws.Cells(3, 1) = "Title"
            ws.Cells(3, 2) = "Author"
            ws.Cells(3, 3) = "Subject"
            ws.Cells(3, 4) = "Shelf No"
            ws.Cells(3, 5) = "Year Published"
            ws.Cells(3, 6) = "Quantity"
            ws.Cells(3, 7) = "ISBN No"
            ws.Cells(3, 8) = "ID"

            command("SELECT * FROM tbl_book
                    LEFT JOIN tbl_authors ON tbl_authors.authorID = tbl_book.authorID
                    LEFT JOIN tbl_subjects ON tbl_subjects.subjectID = tbl_book.subjectID")
            reader = cmd.ExecuteReader()

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("title").ToString
                ws.Cells(x, 2) = reader("author_name").ToString
                ws.Cells(x, 3) = reader("sub_name").ToString
                ws.Cells(x, 4) = reader("shelfNo").ToString
                ws.Cells(x, 5) = reader("yearPublished").ToString
                ws.Cells(x, 6) = reader("quantity").ToString
                ws.Cells(x, 7) = reader("isbn").ToString
                ws.Cells(x, 8) = reader("bookID").ToString
                x += 1
            End While
            ws.Columns.AutoFit()
            ws.Range(ws.Cells(4, 7), ws.Cells(4 + x, 7)).NumberFormat = "0"
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateAuthors(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "AUTHORS"
            ws.Cells(3, 1) = "Name"
            ws.Cells(3, 2) = "ID"

            openCon()
            command("SELECT authorID, author_name FROM tbl_authors")
            reader = cmd.ExecuteReader()

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("author_name").ToString
                ws.Cells(x, 2) = reader("authorID").ToString
                x += 1
            End While

            ws.Columns.AutoFit()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateSubjects(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "SUBJECTS"
            ws.Cells(3, 1) = "Name"
            ws.Cells(3, 2) = "Count"
            ws.Cells(3, 3) = "ID"

            openCon()
            cmd.Parameters.Clear()
            command("SELECT S.subjectID, sub_name, COUNT(B.bookID) AS TotalBooks FROM tbl_subjects S 
                    LEFT JOIN tbl_book B ON B.subjectID = S.subjectID 
                    GROUP BY S.subjectID")

            reader = cmd.ExecuteReader

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("sub_name").ToString
                ws.Cells(x, 2) = reader("TotalBooks").ToString
                ws.Cells(x, 3) = reader("subjectID").ToString
                x += 1
            End While

            closeCon()
            ws.Columns.AutoFit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GeneratePublishers(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "PUBLISHERS"
            ws.Cells(3, 1) = "Name"
            ws.Cells(3, 2) = "ID"

            openCon()
            command("SELECT publisherID, pub_name FROM tbl_publishers")
            reader = cmd.ExecuteReader()

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("pub_name").ToString
                ws.Cells(x, 2) = reader("publisherID").ToString
                x += 1
            End While

            ws.Columns.AutoFit()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateBorrowed(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "BORROWED BOOKS"
            ws.Cells(3, 1) = "Title"
            ws.Cells(3, 2) = "Borrowed By"
            ws.Cells(3, 3) = "Borrowed Date"
            ws.Cells(3, 4) = "Due Date"
            ws.Cells(3, 5) = "Fine"
            ws.Cells(3, 6) = "ID"

            openCon()
            command("SELECT tbl_borrowers.fname, tbl_borrowers.lname, tbl_borrowers_record.dateBorrowed, tbl_borrowers_record.dueDate,tbl_borrowed_books.bbID, tbl_book.title
                    FROM tbl_borrowers 
                    INNER JOIN tbl_borrowers_record ON tbl_borrowers_record.borrowerID = tbl_borrowers.borrowerID
                    INNER JOIN tbl_borrowed_books ON tbl_borrowers_record.brID=tbl_borrowed_books.brID 
                    INNER JOIN tbl_book ON tbl_borrowed_books.bookID=tbl_book.bookID")

            reader = cmd.ExecuteReader()

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("title").ToString
                ws.Cells(x, 2) = reader("fname").ToString & " " & reader("lname").ToString
                ws.Cells(x, 3) = reader("dateBorrowed").ToString
                ws.Cells(x, 4) = reader("dueDate").ToString
                ws.Cells(x, 5) = "₱ " & CheckFine(reader("dueDate"))
                ws.Cells(x, 6) = reader("bbID").ToString
                x += 1
            End While

            ws.Columns.AutoFit()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateBorrowers(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "BORROWERS"
            ws.Cells(3, 1) = "Name"
            ws.Cells(3, 2) = "Section"
            ws.Cells(3, 3) = "Email"
            ws.Cells(3, 4) = "Contact Number"
            ws.Cells(3, 5) = "Home Address"
            ws.Cells(3, 6) = "ID"

            openCon()
            command("SELECT fname, lname, section, email, contactnum, address, borrowerIMG, borrowerID FROM tbl_borrowers")

            reader = cmd.ExecuteReader()

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("fname").ToString & " " & reader("lname").ToString
                ws.Cells(x, 2) = reader("section").ToString
                ws.Cells(x, 3) = reader("email").ToString
                ws.Cells(x, 4) = reader("contactnum").ToString
                ws.Cells(x, 5) = reader("address").ToString
                ws.Cells(x, 6) = reader("borrowerID").ToString
                x += 1
            End While
            ws.Range(ws.Cells(4, 4), ws.Cells(4 + x, 4)).NumberFormat = "0"
            ws.Columns.AutoFit()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GenerateStaff(ws As Worksheet)
        Try
            ws.Columns.AutoFit()
            ws.Cells(1, 1) = "STAFF"
            ws.Cells(3, 1) = "Username"
            ws.Cells(3, 2) = "Name"
            ws.Cells(3, 3) = "Type"
            ws.Cells(3, 4) = "Address"
            ws.Cells(3, 5) = "Email"
            ws.Cells(3, 6) = "Contact Number"
            ws.Cells(3, 7) = "ID"

            openCon()
            command("SELECT * FROM tbl_librarians")
            reader = cmd.ExecuteReader()

            Dim x As Integer = 4
            While reader.Read()
                ws.Cells(x, 1) = reader("username").ToString
                ws.Cells(x, 2) = reader("fname") & " " & reader("lname")
                ws.Cells(x, 3) = reader("type").ToString
                ws.Cells(x, 4) = reader("address").ToString
                ws.Cells(x, 5) = reader("email").ToString
                ws.Cells(x, 6) = reader("contactnum").ToString
                ws.Cells(x, 7) = reader("librarianID").ToString
                x += 1
            End While
            ws.Range(ws.Cells(4, 6), ws.Cells(4 + x, 6)).NumberFormat = "0"
            ws.Columns.AutoFit()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub SetLocation(loc As String)
        Me.Location = loc
    End Sub

    Public Sub SetName(name As String)
        Me.Name = name
    End Sub

    Private Function CheckFine(duedate)
        Dim fine As Double = DateDiff("h", duedate, Now)
        fine = fine * My.Settings.BorrowFine

        If fine < 0 Then
            fine = 0
        End If

        Return fine
    End Function
End Class

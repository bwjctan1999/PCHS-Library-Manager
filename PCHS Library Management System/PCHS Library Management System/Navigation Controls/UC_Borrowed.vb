Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class UC_Borrowed

    'Load Function
    Private Sub UC_Borrowed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip
        CMS.Items.Add("Borrow")
        CMS.Items.Add("Return")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_Borrow_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_Return_Click
        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub


    'LOAD DATABASE FUNCTION
    Public Sub Load_Data()
        CreateListViewColumns()
        PopulateListView()
    End Sub

    Private Sub CreateListViewColumns()
        Dim HeaderText = New String() {"Title", "Name", "Borrowed Date", "Due Date", "Fine", "ID"}
        Dim HeaderWidth = New Integer() {300, 300, 110, 110, 100, 70}

        For i As Integer = 0 To HeaderText.Length - 1
            UserControl_DataViewer.ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
        Next
    End Sub

    Public Sub PopulateListView()
        UserControl_DataViewer.ListViewer.Items.Clear()
        Dim limages As New ImageList
        Dim simages As New ImageList

        limages.ColorDepth = ColorDepth.Depth32Bit
        simages.ColorDepth = ColorDepth.Depth32Bit
        limages.ImageSize = New Size(66, 100)
        simages.ImageSize = New Size(33, 50)

        Try
            openCon()
            command("SELECT tbl_borrowers.fname, tbl_borrowers.lname, tbl_borrowers_record.dateBorrowed, tbl_borrowers_record.dueDate,tbl_borrowed_books.bbID, tbl_book.title, tbl_book.cover 
                    FROM tbl_borrowers 
                    INNER JOIN tbl_borrowers_record ON tbl_borrowers_record.borrowerID = tbl_borrowers.borrowerID
                    INNER JOIN tbl_borrowed_books ON tbl_borrowers_record.brID=tbl_borrowed_books.brID 
                    INNER JOIN tbl_book ON tbl_borrowed_books.bookID=tbl_book.bookID")

            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("title"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("fname") & " " & reader("lname"))
                        .Add(reader("dateBorrowed"))
                        .Add(reader("dueDate"))
                        .Add("₱ " & CheckFine(reader("dueDate")))
                        .Add(reader("bbID"))
                    End With
                End With

                Dim bytes() As Byte
                bytes = (reader("cover"))
                Dim memStream As New MemoryStream(bytes)
                limages.Images.Add(Drawing.Image.FromStream(memStream))
                simages.Images.Add(Drawing.Image.FromStream(memStream))
            End While
            closeCon()

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Borrows")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function CheckFine(duedate)
        Dim fine As Double = DateDiff("h", duedate, Now)
        fine = fine * My.Settings.BorrowFine

        If fine < 0 Then
            fine = 0
        End If

        Return fine
    End Function

    'Return Book Function
    Private Sub Return_Book()
        Dim fines As Double
        Dim msgString As String = "Are you sure?"

        For Each item As ListViewItem In UserControl_DataViewer.Get_SelectedItems()
            Dim temp() As String = Split(item.SubItems(4).Text)

            If temp(1) > 0 Then
                fines += temp(1)
            End If
        Next

        If fines > 0 Then
            msgString = "Fines of ₱" & fines & " Exists. Is it paid?"
        End If

        Msg.SetContent("", msgString)
        If Msg.ShowDialog = DialogResult.OK Then
            Try
                Dim recordids As New List(Of Integer)

                openCon()
                For Each item As ListViewItem In UserControl_DataViewer.Get_SelectedItems()
                    cmd.Parameters.Clear()
                    command("SELECT brID FROM tbl_borrowed_books WHERE (bbID = @bbID)")
                    cmd.Parameters.AddWithValue("@bbID", item.SubItems(5).Text)
                    recordids.Add(cmd.ExecuteScalar)

                    cmd.Parameters.Clear()
                    command("DELETE FROM tbl_borrowed_books WHERE (bbID = @bbID)")
                    cmd.Parameters.AddWithValue("@bbID", item.SubItems(5).Text)
                    execute()
                Next

                recordids = recordids.Distinct().ToList

                For Each id In recordids
                    cmd.Parameters.Clear()
                    command("SELECT bbID FROM tbl_borrowed_books WHERE (brID = @brID)")
                    cmd.Parameters.AddWithValue("@brID", id)
                    Dim temp = cmd.ExecuteScalar

                    If temp Is Nothing Then
                        cmd.Parameters.Clear()
                        command("DELETE FROM tbl_borrowers_record WHERE (brID = @brID)")
                        cmd.Parameters.AddWithValue("@brID", id)
                        execute()
                    End If
                Next

                closeCon()
                UserControl_DataViewer.Remove_SelectedItems()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    'CONTROL FUNCTIONS 
    Private Sub Btn_Return_Click(sender As Object, e As EventArgs) Handles Btn_Return.Click
        Return_Book()
    End Sub

    'Double Click Event
    Public Sub Double_Click_Event()
        Return_Book()
    End Sub

    Private Sub Btn_Borrow_Click(sender As Object, e As EventArgs) Handles Btn_Borrow.Click
        If Form_CheckOut.ShowDialog() = DialogResult.OK Then
            For Each id In Form_CheckOut.addedIDs
                Try
                    openCon()
                    cmd.Parameters.Clear()
                    command("SELECT tbl_borrowers.fname, tbl_borrowers.lname, tbl_borrowers_record.dateBorrowed, tbl_borrowers_record.dueDate,tbl_borrowed_books.bbID, tbl_book.title, tbl_book.cover 
                    FROM tbl_borrowers 
                    INNER JOIN tbl_borrowers_record ON tbl_borrowers_record.borrowerID = tbl_borrowers.borrowerID
                    INNER JOIN tbl_borrowed_books ON tbl_borrowers_record.brID=tbl_borrowed_books.brID 
                    INNER JOIN tbl_book ON tbl_borrowed_books.bookID=tbl_book.bookID
                    WHERE (`bbID` = @bbID)")

                    cmd.Parameters.AddWithValue("@bbID", id)
                    reader = cmd.ExecuteReader

                    While reader.Read()
                        Dim item As New ListViewItem
                        item.Text = (reader("title"))
                        item.SubItems.Add(reader("fname") & " " & reader("lname"))
                        item.SubItems.Add(reader("dateBorrowed"))
                        item.SubItems.Add(reader("dueDate"))
                        item.SubItems.Add("₱ 0")
                        item.SubItems.Add(reader("bbID"))

                        Dim bytes() As Byte
                        bytes = (reader("cover"))
                        Dim memStream As New MemoryStream(bytes)
                        Dim tempimg = Drawing.Image.FromStream(memStream)

                        UserControl_DataViewer.Add_Item(item, tempimg)
                    End While

                    closeCon()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Next
        End If
    End Sub
End Class

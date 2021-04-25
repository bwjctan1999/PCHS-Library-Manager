Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Public Class Form_Main
    Private coverpanel As New Panel
    Dim scID1 As Integer = 1
    Dim scID2 As Integer = 2

    Public Sub LoadData(ss)

        ss.UpdateStatus(0, "LOADING SHOWCASE TITLES...")
        SetShowcaseTitles()

        ss.UpdateStatus(5, "LOADING SUBJECTS...")
        PopulateCboxSubjects()

        ss.UpdateStatus(10, "LOADING SHOWCASE 1 BOOKS...")
        PopulateShowcase(UserControl_BookShowcase_1, 1)

        ss.UpdateStatus(25, "LOADING SHOWCASE 2 BOOKS...")
        PopulateShowcase(UserControl_BookShowcase_2, 2)

        ss.UpdateStatus(55, "CREATING HEADERS FOR BOOKS...")
        CreateListViewColumns()

        ss.UpdateStatus(60, "LOADING ALL BOOKS...")
        PopulateListView()
    End Sub

    Private Sub SetShowcaseTitles()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT * FROM tbl_showcase")

            reader = cmd.ExecuteReader

            Dim ids(1) As String

            Dim counter As Integer = 0
            While reader.Read
                ids(counter) = reader("sc_title")
                counter += 1
            End While

            closeCon()

            Lbl_BookShowcase_1.Text = ids(0)
            Lbl_BookShowcase_2.Text = ids(1)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PopulateShowcase(bookshelf As UC_BookShelf, id As Integer)
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT title, author_name, sub_name, shelfNo, pub_name, yearPublished, quantity, isbn, bookID FROM tbl_showcase_books
                    LEFT JOIN tbl_book a ON a.bookID = tbl_showcase_books.booksID 
                    LEFT JOIN tbl_authors ON tbl_authors.authorID = a.authorID
                    LEFT JOIN tbl_subjects ON tbl_subjects.subjectID = a.subjectID
                    LEFT JOIN tbl_publishers ON tbl_publishers.publisherID = a.publisherID
                    WHERE (scID = @scID)")
            cmd.Parameters.AddWithValue("@scID", id)
            reader = cmd.ExecuteReader()

            Dim bookinfos As New List(Of BookInfo)
            While reader.Read()
                Dim info As New BookInfo

                info.Title = reader("title").ToString
                info.Author = reader("author_name").ToString
                info.Subject = reader("sub_name").ToString
                info.Shelf_No = reader("shelfNo").ToString
                info.Publisher = reader("pub_name").ToString
                info.Year_Published = reader("yearPublished")
                info.Quantity = reader("quantity").ToString
                info.ISBN_No = reader("isbn").ToString
                info.BookID = reader("bookID").ToString

                bookinfos.Add(info)
            End While

            closeCon()

            For Each info In bookinfos
                Dim book As New UC_Book

                book.Set_BookInfo(info.Title,
                                  info.Author,
                                  info.Subject,
                                  info.Shelf_No,
                                  info.Publisher,
                                  info.Year_Published,
                                  info.Quantity,
                                  info.ISBN_No,
                                  info.BookID)

                bookshelf.Add_Book(book)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CreateListViewColumns()
        Dim HeaderText = New String() {"Title", " Author", "Subject", "Shelf No", "Publisher", "Year Published",
                                       "Quantity", "ISBN", "ID"}
        Dim HeaderWidth = New Integer() {250, 200, 150, 80, 130, 125, 80, 125, 30}

        For i As Integer = 0 To HeaderText.Length - 1
            UserControl_DataViewer.ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
        Next
    End Sub

    '== 2.1 Populate List View ==
    Private Sub PopulateListView()
        UserControl_DataViewer.ListViewer.Items.Clear()
        Dim limages As New ImageList
        Dim simages As New ImageList
        limages.ColorDepth = ColorDepth.Depth32Bit
        simages.ColorDepth = ColorDepth.Depth32Bit
        limages.ImageSize = New Size(66, 100)
        simages.ImageSize = New Size(33, 50)
        Try
            openCon()
            command("SELECT b.title, author_name, sub_name, b.shelfNo, pub_name, b.yearPublished, b.quantity, b.isbn, b.cover, b.bookID FROM tbl_book b
                    LEFT JOIN tbl_authors ON tbl_authors.authorID = b.authorID
                    LEFT JOIN tbl_subjects ON tbl_subjects.subjectID = b.subjectID
                    LEFT JOIN tbl_publishers ON tbl_publishers.publisherID = b.publisherID")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("title").ToString)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("author_name").ToString)
                        .Add(reader("sub_name").ToString)
                        .Add(reader("shelfNo").ToString)
                        .Add(reader("pub_name").ToString)
                        .Add(reader("yearPublished"))
                        .Add(reader("quantity").ToString)
                        .Add(reader("isbn").ToString)
                        .Add(reader("bookID").ToString)
                    End With
                End With

                Dim bytes() As Byte
                bytes = (reader("cover"))
                Dim memStream As New MemoryStream(bytes)
                limages.Images.Add(Drawing.Image.FromStream(memStream))
                simages.Images.Add(Drawing.Image.FromStream(memStream))
            End While

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Settings()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        closeCon()
    End Sub

    Private Sub PopulateCboxSubjects()
        Try
            openCon()
            command("SELECT subjectID, sub_name FROM tbl_subjects")
            FillTable()
            Cbox_Subjects.Items.Clear()
            Cbox_Subjects.DataSource = New BindingSource(datatable, Nothing)
            Cbox_Subjects.DisplayMember = "sub_name"
            Cbox_Subjects.ValueMember = "subjectID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Cbox_Subjects.SelectedIndex = Cbox_Subjects.Items.Count - 1
        Cbox_SearchSettings.SelectedIndex = 0
        closeCon()
    End Sub

    'Login Button Function
    Private Sub Btn_LogIn_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub


    'SEARCH BAR FUNCTIONS ================================================================================================

    'Search button
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        UserControl_BookShowcase_1.Hide()
        UserControl_BookShowcase_2.Hide()
        Lbl_BookShowcase_1.Hide()
        Lbl_BookShowcase_2.Hide()

        Btn_Back.Show()
        UserControl_DataViewer.Show()

        Dim searchstring As String = Txtbox_Searchbar.Text
        Dim filter As String = ""

        Select Case Cbox_SearchSettings.Text
            Case "All"
                filter = "All"

            Case "Title"
                filter = "Title"

            Case "Author"
                filter = "Author"

            Case "Subject"
                searchstring = Cbox_Subjects.Text
                filter = "Subject"

            Case "Publisher"
                filter = "Publisher"
        End Select

        UserControl_DataViewer.Search(searchstring, filter)
    End Sub

    'Search Settings Button
    Private Sub Btn_SearchSettings_Click(sender As Object, e As EventArgs) Handles Btn_SearchSettings.Click
        Select Case Cbox_SearchSettings.Visible
            Case False
                Cbox_SearchSettings.Visible = True
            Case True
                Cbox_SearchSettings.Visible = False
                Cbox_Subjects.Visible = False
        End Select
    End Sub

    'Search Combobox
    Private Sub Cbox_SearchSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_SearchSettings.SelectedIndexChanged
        Select Case Cbox_SearchSettings.Text
            Case "All"
                Cbox_Subjects.Hide()
            Case "Title"
                Cbox_Subjects.Hide()
            Case "Author"
                Cbox_Subjects.Hide()
            Case "Subject"
                Cbox_Subjects.Show()
        End Select
    End Sub

    Structure BookInfo
        Dim Picture As Image
        Dim Title As String
        Dim Author As String
        Dim Subject As String
        Dim Shelf_No As String
        Dim Publisher As String
        Dim Year_Published As String
        Dim Quantity As String
        Dim ISBN_No As String
        Dim BookID As String
    End Structure

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams

    Public Sub Double_Click_Event()
        Dim book As New UC_Book

        Dim item As ListViewItem = UserControl_DataViewer.Get_SelectedItems().Item(0)

        book.Set_BookInfo(item.SubItems(0).Text,
                              item.SubItems(1).Text,
                              item.SubItems(2).Text,
                              item.SubItems(3).Text,
                              item.SubItems(4).Text,
                              item.SubItems(5).Text,
                              item.SubItems(6).Text,
                              item.SubItems(7).Text,
                              item.SubItems(8).Text)

        Dim BorrowForm As New Form_View
        BorrowForm.Set_Book(book)
        BorrowForm.ShowDialog()
    End Sub

    Private Sub Txtbox_Searchbar_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Searchbar.TextChanged
        If Txtbox_Searchbar.Text = "" Then
            UserControl_BookShowcase_1.Hide()
            UserControl_BookShowcase_2.Hide()
            Lbl_BookShowcase_1.Hide()
            Lbl_BookShowcase_2.Hide()

            Btn_Back.Show()
            UserControl_DataViewer.Show()
            UserControl_DataViewer.Search(Txtbox_Searchbar.Text, "")
        End If
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Btn_Back.Hide()
        UserControl_DataViewer.Hide()

        UserControl_BookShowcase_1.Show()
        UserControl_BookShowcase_2.Show()
        Lbl_BookShowcase_1.Show()
        Lbl_BookShowcase_2.Show()
    End Sub
End Class

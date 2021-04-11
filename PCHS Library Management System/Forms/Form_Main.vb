Imports System.Configuration
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form_Main
    Dim scID1 As Integer = 1
    Dim scID2 As Integer = 2

    'Load Function
    Private Sub Form_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateListViewColumns()
        PopulateListView()
        SetShowcaseTitles()
        PopulateShowcase(UserControl_BookShowcase_1, 1)
        PopulateShowcase(UserControl_BookShowcase_2, 2)
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
            command("SELECT * FROM tbl_showcase_books
                    INNER JOIN tbl_book a ON a.bookID = tbl_showcase_books.booksID 
                    INNER JOIN tbl_authors ON tbl_authors.authorID = a.authorID
                    INNER JOIN tbl_subjects ON tbl_subjects.subjectID = a.subjectID
                    WHERE (scID = @scID)")
            cmd.Parameters.AddWithValue("@scID", id)
            reader = cmd.ExecuteReader()

            Dim bookinfos As New List(Of BookInfo)
            While reader.Read()
                Dim info As New BookInfo

                info.Title = reader("title")
                info.Author = reader("author_name")
                info.Subject = reader("sub_name")
                info.Shelf_No = reader("shelfNo")
                info.Year_Published = reader("yearPublished")
                info.Quantity = reader("quantity")
                info.ISBN_No = reader("isbn")
                info.BookID = reader("booksID")

                bookinfos.Add(info)
            End While

            closeCon()

            For Each info In bookinfos
                Dim book As New UC_Book
                book.Set_Mode("View")

                book.Set_BookInfo(info.Title,
                                  info.Author,
                                  info.Subject,
                                  info.Shelf_No,
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
        Dim HeaderText = New String() {"Title", " Author", "Subject", "Shelf No", "Year Published",
                                       "Quantity", "ISBN", "ID"}
        Dim HeaderWidth = New Integer() {250, 250, 150, 70, 120, 80, 110, 50}

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
            command("SELECT * FROM tbl_book
                    INNER JOIN tbl_authors ON tbl_authors.authorID = tbl_book.authorID
                    INNER JOIN tbl_subjects ON tbl_subjects.subjectID = tbl_book.subjectID")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("title"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("author_name"))
                        .Add(reader("sub_name"))
                        .Add(reader("shelfNo"))
                        .Add(reader("yearPublished"))
                        .Add(reader("quantity"))
                        .Add(reader("isbn"))
                        .Add(reader("bookID"))
                    End With
                End With

                Dim bytes() As Byte
                bytes = (reader("cover"))
                Dim memStream As New MemoryStream(bytes)
                limages.Images.Add(Drawing.Image.FromStream(memStream))
                simages.Images.Add(Drawing.Image.FromStream(memStream))
            End While

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Main")
        Catch ex As Exception
            Msg.SetContent("MySQL CONNECTION ACCESS ERROR", "If you are prototyping please follow the instructions given in the link below." & vbCrLf & vbCrLf &
                           "https://github.com/bwjctan1999/PCHS-Library-Manager/tree/main/MySQL%20INSTRUCTIONS/Instructions/MYSQL%20ACCESS%20ERROR" & vbCrLf & vbCrLf &
                           "All errors following this can be fixed through the instructions in the link, please ignore them")
            Msg.ShowDialog()
            MsgBox(ex.ToString)
        End Try

        closeCon()
    End Sub


    'Login Button Function
    Private Sub Btn_LogIn_Click(sender As Object, e As EventArgs) Handles Btn_Admin.Click
        Me.Hide()
        Form_Login.Show()
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
        UserControl_DataViewer.Search(Txtbox_Searchbar.Text, "")
    End Sub

    'Search Settings Button
    Private Sub Btn_SearchSettings_Click(sender As Object, e As EventArgs) Handles Btn_SearchSettings.Click
        Select Case Cbox_SearchSettings.Visible
            Case False
                Cbox_SearchSettings.Visible = True
            Case True
                Cbox_SearchSettings.Visible = False
                Cbox_Categories.Visible = False
        End Select
    End Sub

    'Search Combobox
    Private Sub Cbox_SearchSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_SearchSettings.SelectedIndexChanged
        Select Case Cbox_SearchSettings.Text
            Case "All"
                Cbox_Categories.Hide()
            Case "Title"
                Cbox_Categories.Hide()
            Case "Author"
                Cbox_Categories.Hide()
            Case "Category"
                Cbox_Categories.Show()
        End Select
    End Sub

    Structure BookInfo
        Dim Picture As Image
        Dim Title As String
        Dim Author As String
        Dim Subject As String
        Dim Shelf_No As String
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
                              item.SubItems(7).Text)

        Dim BorrowForm As New Form_Borrow
        BorrowForm.Set_Book(book)
        BorrowForm.Set_Mode("View")
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

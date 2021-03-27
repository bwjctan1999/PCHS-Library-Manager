Public Class Form_Main

    'Load Function
    Private Sub Form_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim database(,) As String = {{"C:\Users\Jukebox\Desktop\Images\BOOK 1.jpg", "My Book Cover",
                                     "J. R. R. Someone", "978-3-16-148410-0", "7/31/1999", "01", "Technology", "01"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 2.jpg", "The Great Gatsby",
                                     "F. Scott Fitzgerald", "578-2-15-174210-5", "9/15/1977", "02", "Literature", "02"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 3.jpg", "If It Bleeds",
                                     "Stephen King", "658-3-36-759410-5", "3/21/1990", "03", "Literature", "02"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 4.jpg", "The Good Guy",
                                     "Dean Koontz", "539-3-16-185530-2", "9/15/2010", "04", "Language", "01"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 5.jpg", "A Boy In Winter",
                                     "Rachel Seifferte", "173-3-16-187400-0", "9/15/2018", "05", "History and Geography", "01"}}

        For i As Integer = 0 To 4
            Dim book As New UC_Book
            book.Set_Data(database(i, 0), database(i, 1), database(i, 2), database(i, 3),
                          database(i, 4), database(i, 5), database(i, 6), database(i, 7))

            UserControl_BookShowcase_1.Add_Book(book)
        Next

        For i As Integer = 0 To 4
            Dim book As New UC_Book
            book.Set_Data(database(i, 0), database(i, 1), database(i, 2), database(i, 3),
                          database(i, 4), database(i, 5), database(i, 6), database(i, 7))

            UserControl_BookShowcase_2.Add_Book(book)
        Next
    End Sub

    'Login Button Function
    Private Sub Btn_LogIn_Click(sender As Object, e As EventArgs) Handles Btn_Admin.Click
        Me.Hide()
        Form_Login2.Show()
    End Sub

    'Checkout Button Function

    Private Sub Btn_CheckOut_Click(sender As Object, e As EventArgs) Handles Btn_CheckOut.Click
        Form_CheckOut.ShowDialog()
    End Sub

    'SEARCH BAR FUNCTIONS ================================================================================================

    'Search button
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        UserControl_DataViewer.Hide()

        UserControl_DataViewer.ListViewer.Clear()
        Dim database2(,) As String = {{"C:\Users\Jukebox\Desktop\Images\BOOK 1.jpg", "My Book Cover",
                                     "J. R. R. Someone", "978-3-16-148410-0", "7/31/1999", "01", "Technology", "01"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 2.jpg", "The Great Gatsby",
                                     "F. Scott Fitzgerald", "578-2-15-174210-5", "9/15/1977", "02", "Literature", "02"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 3.jpg", "If It Bleeds",
                                     "Stephen King", "658-3-36-759410-5", "3/21/1990", "03", "Literature", "02"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 4.jpg", "The Good Guy",
                                     "Dean Koontz", "539-3-16-185530-2", "9/15/2010", "04", "Language", "01"},
                                     {"C:\Users\Jukebox\Desktop\Images\BOOK 5.jpg", "A Boy In Winter",
                                     "Rachel Seifferte", "173-3-16-187400-0", "9/15/2018", "05", "History and Geography", "01"}}

        UserControl_DataViewer.Load_DataViewer(database2, "Main", Me)

        If Txtbox_Searchbar.Text <> "" Then
            UserControl_DataViewer.Search(Txtbox_Searchbar.Text, Cbox_SearchSettings.Text)
        End If


        UserControl_BookShowcase_1.Hide()
        UserControl_BookShowcase_2.Hide()
        Lbl_BookShowcase_1.Hide()
        Lbl_BookShowcase_2.Hide()
        UserControl_DataViewer.Show()
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

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class
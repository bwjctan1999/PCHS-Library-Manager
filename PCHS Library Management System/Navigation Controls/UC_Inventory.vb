Public Class UC_Inventory

    Private Sub UC_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip

        CMS.Items.Add("Update")
        CMS.Items.Add("Add")
        CMS.Items.Add("Delete")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_UpdateBook_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_AddBook_Click
        AddHandler CMS.Items(2).Click, AddressOf Me.Btn_DeleteBook_Click

        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub

    Public Sub Load_Data()
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

        UserControl_DataViewer.Load_DataViewer(database, "Inventory", Me)
    End Sub

    Private Sub Update_Book()
        Dim FormBook As New Form_Add_Edit_Book

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else
            Dim images As New List(Of Image)

            For Each item In UserControl_DataViewer.Get_SelectedItems()
                images.Add(UserControl_DataViewer.Large_imgs.Images(item.ImageIndex))
            Next

            FormBook.Start("Update", UserControl_DataViewer.Get_SelectedItems(), images)
            FormBook.ShowDialog()
        End If
    End Sub

    'CONTROL FUNCTIONS ============================================================================================
    Public Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        Dim FormBook As New Form_Add_Edit_Book
        FormBook.Start("Add", "none", Nothing)
        FormBook.ShowDialog()
    End Sub

    Private Sub Btn_UpdateBook_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBook.Click
        Update_Book()
    End Sub

    Private Sub Btn_DeleteBook_Click(sender As Object, e As EventArgs) Handles Btn_DeleteBook.Click
        UserControl_DataViewer.Remove_SelectedItems()
    End Sub

    Public Sub Double_Click_Event()
        Update_Book()
    End Sub
End Class

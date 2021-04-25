Imports System.IO

'================================
'TABLE OF CONTENTS
'   1. Form Load Event
'
'   2. Listview Subs
'       2.1 Populate List View
'
'   3. Double Click Sub
'
'   4. Get DB BookCover
'================================



Public Class UC_Inventory

    '=======================
    '  1. FORM LOAD EVENT  
    '=======================
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

    '======================
    '  2. LIST VIEW SUBS 
    '======================
    Public Sub Load_Data()
        CreateListViewColumns()
        PopulateListView()
    End Sub


    Private Sub CreateListViewColumns()
        Dim HeaderText = New String() {"Title", "Author", "Subject", "Shelf No", "Year Published",
                                       "Quantity", "ISBN", "ID"}
        Dim HeaderWidth = New Integer() {250, 250, 100, 70, 120, 100, 110, 50}

        For i As Integer = 0 To HeaderText.Length - 1
            UserControl_DataViewer.ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
        Next
    End Sub

    '== 2.1 Populate List View ==
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
            command("SELECT * FROM tbl_book
                    LEFT JOIN tbl_authors ON tbl_authors.authorID = tbl_book.authorID
                    LEFT JOIN tbl_subjects ON tbl_subjects.subjectID = tbl_book.subjectID")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("title").ToString)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("author_name").ToString)
                        .Add(reader("sub_name").ToString)
                        .Add(reader("shelfNo").ToString)
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
            closeCon()

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Inventory")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub EditBook()
        Dim FormBook As New Form_Add_Edit_Book

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else
            Dim seLength As Integer = UserControl_DataViewer.Get_SelectedItems().Count
            Dim ids(seLength - 1) As Integer

            For i As Integer = 0 To seLength - 1
                ids(i) = UserControl_DataViewer.Get_SelectedItems()(i).SubItems(7).Text
            Next

            FormBook.UpdateMode(ids)
            If FormBook.ShowDialog() = DialogResult.OK Then

                Dim i As Integer = 0
                For Each index In UserControl_DataViewer.ListViewer.SelectedIndices
                    UserControl_DataViewer.ListViewer.Items(index) = FormBook.listviewItems(i)

                    Dim img As Image = FormBook.listimages(i)
                    Dim bmp As Bitmap = New Bitmap(66, 100)
                    Dim graph As Graphics = Graphics.FromImage(bmp)
                    graph.DrawImage(img, New Rectangle(0, 0, 66, 100))
                    UserControl_DataViewer.Large_imgs.Images(index) = bmp

                    bmp = New Bitmap(100, 100)
                    graph = Graphics.FromImage(bmp)
                    graph.DrawImage(img, New Rectangle(0, 0, 33, 50))
                    UserControl_DataViewer.Small_imgs.Images(index) = bmp

                    UserControl_DataViewer.ListViewer.Items(index).ImageIndex = index
                    i += 1
                Next
            End If
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    'CONTROL FUNCTIONS ============================================================================================
    Public Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        Dim FormBook As New Form_Add_Edit_Book
        FormBook.PopulateSubjects()

        If FormBook.ShowDialog() = DialogResult.OK Then
            UserControl_DataViewer.Add_Item(FormBook.listviewItems(0), FormBook.listimages(0))
        End If
    End Sub

    Private Sub Btn_UpdateBook_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBook.Click
        EditBook()
    End Sub

    Private Sub Btn_DeleteBook_Click(sender As Object, e As EventArgs) Handles Btn_DeleteBook.Click
        Msg.SetContent("", "Delete Book/s ?")
        If Msg.ShowDialog = DialogResult.OK Then
            Try
                openCon()
                cmd.Parameters.Clear()
                For Each item As ListViewItem In UserControl_DataViewer.Get_SelectedItems()

                    cmd.Parameters.Clear()
                    command("DELETE FROM tbl_book WHERE (bookID = @bookid)")

                    cmd.Parameters.AddWithValue("@bookid", item.SubItems(7).Text)
                    execute()

                Next

                closeCon()
                UserControl_DataViewer.Remove_SelectedItems()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Public Sub Double_Click_Event()
        EditBook()
    End Sub
End Class

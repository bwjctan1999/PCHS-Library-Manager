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


Public Class Form_BookList
    Dim Mode As String
    Public selectedID As Integer

    '=======================
    '  1. FORM LOAD EVENT 
    '=======================
    Private Sub Form_BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateListViewColumns()
        PopulateListView()
    End Sub

    '======================
    '  2. LIST VIEW SUBS 
    '======================
    Private Sub CreateListViewColumns()
        UserControl_DataViewer.ListViewer.Clear()
        Dim HeaderText = New String() {"Title", " Author", "Subject", "Shelf No", "Year Published",
                                       "Quantity", "ISBN", "ID"}
        Dim HeaderWidth = New Integer() {250, 250, 150, 70, 120, 100, 110, 50}

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
            UserControl_DataViewer.Set_Mode("Inventory")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        closeCon()
    End Sub

    '========================
    ' 3. Double Click Event
    '========================
    Public Sub Double_Click_Event()
        Add()
    End Sub

    '==================
    ' 4. SHOWCASE MODE
    '===================
    Public Sub Add()
        If Mode = "Showcase" Then
            selectedID = UserControl_DataViewer.Get_SelectedItems().Item(0).SubItems(7).Text
            Me.DialogResult = DialogResult.OK
        Else
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
            BorrowForm.Set_Mode("Borrow")
            BorrowForm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Public Sub SetMode(mode)
        Me.Mode = mode
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Add()

    End Sub
End Class
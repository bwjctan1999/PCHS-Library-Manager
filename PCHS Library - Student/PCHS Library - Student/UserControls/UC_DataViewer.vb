
'================================
'TABLE OF CONTENTS
'   1. Set Settings
'   2. List View Functions
'   3. Form Controls
'   4. Search
'================================


Imports System.IO

Public Class UC_DataViewer
    Private parent_form

    'Images List for List View
    Public Large_imgs As New ImageList
    Public Small_imgs As New ImageList
    Public SearchLimgs As New ImageList
    Public SearchSimgs As New ImageList

    '=====================
    '  1. Set Settings 
    '=====================
    Public Sub Set_Settings()
        For Each oFont As FontFamily In FontFamily.Families
            Cbox_FontSettings.Items.Add(oFont.Name)
        Next

        'Loads Book Viewer Default Settings'
        Cbox_ViewSettings.SelectedIndex = 0
        Cbox_ArrangeSettings.SelectedIndex = 0
        Cbox_FontSize.SelectedIndex = 2
        Cbox_FontSettings.SelectedIndex = 134


        Cbox_ViewSettings.SelectedIndex = 2
        Cbox_GridSettings.SelectedIndex = 0
    End Sub

    '===========================
    '  2. LIST VIEW FUNCTIONS 
    '===========================
    Public Sub SetData(limg, simg, parent)
        SearchLimgs.ColorDepth = ColorDepth.Depth32Bit
        SearchSimgs.ColorDepth = ColorDepth.Depth32Bit
        SearchLimgs.ImageSize = New Size(66, 100)
        SearchSimgs.ImageSize = New Size(33, 50)

        For Each column In ListViewer.Columns
            ListViewSearch.Columns.Add(column.clone())
        Next

        Large_imgs = limg
        Small_imgs = simg

        ListViewer.LargeImageList = Large_imgs
        ListViewer.SmallImageList = Small_imgs

        For i As Integer = 0 To ListViewer.Items.Count - 1
            ListViewer.Items(i).ImageIndex = i
        Next

        parent_form = parent
    End Sub


    Public Sub Add_Item(items, img)
        Me.Large_imgs.Images.Add(img)
        Me.Small_imgs.Images.Add(img)
        ListViewer.Items.Add(items.Clone())
        ListViewer.Items(ListViewer.Items.Count - 1).ImageIndex = Large_imgs.Images.Count - 1

        ListViewer.Items(ListViewer.Items.Count - 1).Font = ListViewer.Font

        If Cbox_GridSettings.SelectedItem = "Divisions" Then
            If (ListViewer.Items.Count - 1) Mod 2 = 0 Then
                ListViewer.Items(ListViewer.Items.Count - 1).BackColor = Color.FromArgb(233, 242, 252)
            End If
        End If
    End Sub


    Public Function Get_SelectedItems()
        Dim selected As ListView.SelectedListViewItemCollection

        If ListViewer.Visible = True Then
            selected = ListViewer.SelectedItems
        ElseIf ListViewSearch.Visible = True Then
            selected = ListViewSearch.SelectedItems
        End If

        Return selected
    End Function


    'Remove Selected Item/s
    Public Sub Remove_SelectedItems()
        For Each i As ListViewItem In ListViewer.SelectedItems
            ListViewer.Items.Remove(i)
        Next
    End Sub


    '======================
    '   3. FORM CONTROLS
    '======================
    Private Sub ListViewer_DoubleClick(sender As Object, e As EventArgs) Handles ListViewer.DoubleClick, ListViewSearch.DoubleClick
        parent_form.Double_Click_Event()
    End Sub

    Private Sub Btn_ListSettings_Click(sender As Object, e As EventArgs) Handles Btn_ListSettings.Click
        If Panel_BookSettings.Visible = False Then
            Panel_BookSettings.Show()
            Btn_ListSettings.BackColor = Color.FromArgb(201, 199, 199)
        Else
            Panel_BookSettings.Hide()
            Btn_ListSettings.BackColor = Color.Transparent
        End If
    End Sub


    '============================
    '   2. LIST VIEW SETTINGS
    '============================
    'View Settings Combobox
    Private Sub Cbox_ViewSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_ViewSettings.SelectedIndexChanged
        Select Case Cbox_ViewSettings.Text
            Case "Details"
                Me.ListViewer.View = View.Details
                Me.ListViewSearch.View = View.Details
            Case "Large Icons"
                Me.ListViewer.View = View.LargeIcon
                Me.ListViewSearch.View = View.LargeIcon
            Case "Tile"
                Me.ListViewer.View = View.Tile
                Me.ListViewSearch.View = View.Tile
        End Select
    End Sub

    'Spacing/Arrangement Settings Combobox
    Private Sub Cb_Arrangement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_ArrangeSettings.SelectedIndexChanged
        Select Case Cbox_ArrangeSettings.Text
            Case "Default Length"
                Dim columnWidths() As Integer = {250, 200, 150, 80, 130, 125, 80, 125, 30}

                For i As Integer = 0 To columnWidths.Length - 1
                    ListViewer.Columns(i).Width = columnWidths(i)
                    ListViewSearch.Columns(i).Width = columnWidths(i)
                Next

            Case "Header Length"
                Me.ListViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                ListViewer.Columns(ListViewer.Columns.Count - 1).Width = ListViewer.Columns(ListViewer.Columns.Count - 1).Width - 30

                Me.ListViewSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                ListViewSearch.Columns(ListViewSearch.Columns.Count - 1).Width = ListViewSearch.Columns(ListViewSearch.Columns.Count - 1).Width - 30
            Case "Content Length"
                Me.ListViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                Me.ListViewSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End Select
    End Sub

    'Font Settings Combobox
    Private Sub Cbox_FontSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_FontSettings.SelectedIndexChanged
        Dim oFont As New FontFamily(Cbox_FontSettings.Text)

        Cbox_FontStyleSettings.Items.Clear()

        If oFont.IsStyleAvailable(FontStyle.Regular) Then
            Cbox_FontStyleSettings.Items.Add("Regular")
        End If

        If oFont.IsStyleAvailable(FontStyle.Bold) Then
            Cbox_FontStyleSettings.Items.Add("Bold")
        End If

        If oFont.IsStyleAvailable(FontStyle.Italic) Then
            Cbox_FontStyleSettings.Items.Add("Italic")
        End If

        Cbox_FontStyleSettings.SelectedIndex = 0
    End Sub

    'Font Settings, Font Stlye, Font Size Settings Combobox
    Private Sub Change_Font_and_Style(sender As Object, e As EventArgs) Handles Cbox_FontSettings.SelectedIndexChanged, Cbox_FontStyleSettings.SelectedIndexChanged, Cbox_FontSize.SelectedIndexChanged
        Select Case Cbox_FontStyleSettings.Text
            Case "Regular"
                Me.ListViewer.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Regular)
                Me.ListViewSearch.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Regular)
            Case "Bold"
                Me.ListViewer.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Bold)
                Me.ListViewSearch.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Bold)
            Case "Italic"
                Me.ListViewer.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Italic)
                Me.ListViewSearch.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Italic)
        End Select
    End Sub

    'Grid Settings Combobox
    Private Sub Cbox_GridSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_GridSettings.SelectedIndexChanged
        Select Case Cbox_GridSettings.Text
            Case "None"
                ListViewer.GridLines = False
                For i As Integer = 0 To ListViewer.Items.Count - 1 Step 1
                    ListViewer.Items(i).BackColor = Color.White
                Next

                ListViewSearch.GridLines = False
                For i As Integer = 0 To ListViewSearch.Items.Count - 1 Step 1
                    ListViewSearch.Items(i).BackColor = Color.White
                Next

            Case "Lines"
                ListViewer.GridLines = True
                For i As Integer = 0 To ListViewer.Items.Count - 1 Step 1
                    ListViewer.Items(i).BackColor = Color.White
                Next

                ListViewSearch.GridLines = True
                For i As Integer = 0 To ListViewSearch.Items.Count - 1 Step 1
                    ListViewSearch.Items(i).BackColor = Color.White
                Next
            Case "Divisions"
                ListViewer.GridLines = False
                For i As Integer = 0 To ListViewer.Items.Count - 1 Step 2
                    ListViewer.Items(i).BackColor = Color.FromArgb(233, 242, 252)
                Next

                ListViewSearch.GridLines = False
                For i As Integer = 0 To ListViewSearch.Items.Count - 1 Step 2
                    ListViewSearch.Items(i).BackColor = Color.FromArgb(233, 242, 252)
                Next
        End Select
    End Sub


    '================
    '   4. SEARCH
    '================
    Public Sub Search(searchstring As String, filter As String)

        ListViewSearch.Items.Clear()
        SearchLimgs.Images.Clear()
        SearchSimgs.Images.Clear()

        ListViewSearch.LargeImageList = SearchLimgs
        ListViewSearch.SmallImageList = SearchSimgs

        If searchstring = "" Then
            ListViewSearch.Hide()
            ListViewer.Show()
        Else
            Try
                openCon()
                cmd.Parameters.Clear()
                command(DoFilter(filter))
                cmd.Parameters.AddWithValue("@searchstring", searchstring)

                reader = cmd.ExecuteReader()

                Dim index As Integer = 0
                While reader.Read()
                    Dim bytes() As Byte
                    bytes = (reader("cover"))
                    Dim memStream As New MemoryStream(bytes)
                    SearchLimgs.Images.Add(Drawing.Image.FromStream(memStream))
                    SearchSimgs.Images.Add(Drawing.Image.FromStream(memStream))

                    With ListViewSearch
                        .Items.Add(reader("title"))
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

                    ListViewSearch.Items(ListViewSearch.Items.Count - 1).ImageIndex = index
                    index += 1
                End While

                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ListViewer.Hide()
            ListViewSearch.Show()
        End If
    End Sub

    Private Function DoFilter(filter)
        Dim filters As String() = {"Match(title, shelfNo, isbn) Against (@searchstring)",
                                   "Match(author_name) Against (@searchstring)",
                                   "Match(sub_name) Against (@searchstring)",
                                   "Match(pub_name) Against (@searchstring)"}

        Dim comm As String = "SELECT b.title, author_name, sub_name, b.shelfNo, pub_name, b.yearPublished, b.quantity, b.isbn, b.cover, b.bookID FROM tbl_book b
                                LEFT JOIN tbl_authors ON tbl_authors.authorID = b.authorID
                                LEFT JOIN tbl_subjects ON tbl_subjects.subjectID = b.subjectID
                                LEFT JOIN tbl_publishers ON tbl_publishers.publisherID = b.publisherID
                                     WHERE "

        Select Case filter
            Case "All"
                comm += filters(0) & " OR " & filters(1) & " OR " & filters(2) & " OR " & filters(3)

            Case "Title"
                comm += filters(0)

            Case "Author"
                comm += filters(1)

            Case "Subject"
                comm += filters(2)

            Case "Publisher"
                comm += filters(3)

        End Select

        Return comm
    End Function
End Class

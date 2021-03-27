Public Class UC_DataViewer
    Private datatype As String
    Private database
    Private parent_form

    Public Large_imgs As New ImageList
    Public Small_imgs As New ImageList

    Public Sub Load_DataViewer(database, type, parent)
        Me.database = database
        Me.datatype = type
        Me.parent_form = parent

        Create_Column_Header()
        Fill_Data(database)
        Set_Default_Settings()

    End Sub

    'Create Column Headers of Data List
    Private Sub Create_Column_Header()
        Select Case datatype
            Case "Borrows"
                Dim HeaderText = New String() {"Name", "Sections", "Books"}
                Dim HeaderWidth = New Integer() {250, 150, 650}

                For i As Integer = 0 To HeaderText.Length - 1
                    ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
                Next
            Case "Borrowed"
                Dim HeaderText = New String() {"Name", "Sections", "Books"}
                Dim HeaderWidth = New Integer() {250, 150, 650}

                For i As Integer = 0 To HeaderText.Length - 1
                    ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
                Next
            Case "Inventory"
                Dim HeaderText = New String() {"Title", "Author", "ISBN Number", "Year Published",
                                               "Code Number", "Category", "Shelf Number"}
                Dim HeaderWidth = New Integer() {250, 250, 150, 130, 100, 100, 100}

                For i As Integer = 0 To HeaderText.Length - 1
                    ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
                Next
            Case "Main"
                Dim HeaderText = New String() {"Title", "Author", "ISBN Number", "Year Published",
                                               "Code Number", "Category", "Shelf Number"}
                Dim HeaderWidth = New Integer() {250, 250, 150, 130, 100, 100, 100}

                For i As Integer = 0 To HeaderText.Length - 1
                    ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
                Next
            Case "Staff"
                Dim HeaderText = New String() {"Name", "Gender", "Type", "Email Address",
                                               "Home Address", "Contact Number"}
                Dim HeaderWidth = New Integer() {300, 100, 100, 250, 200, 150}

                For i As Integer = 0 To HeaderText.Length - 1
                    ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
                Next
        End Select
    End Sub

    'Fill Data Function (To be edited...)
    Private Sub Fill_Data(database As String(,))
        Me.ListViewer.View = View.Details


        'Dim Small_imgs As ImageList = New ImageList()

        Large_imgs.ColorDepth = ColorDepth.Depth32Bit
        Small_imgs.ColorDepth = ColorDepth.Depth32Bit

        If datatype = "Main" Or datatype = "Inventory" Then
            Large_imgs.ImageSize = New Size(66, 100)
            Small_imgs.ImageSize = New Size(33, 50)
        Else
            Large_imgs.ImageSize = New Size(100, 100)
            Small_imgs.ImageSize = New Size(50, 50)
        End If

        ListViewer.LargeImageList = Large_imgs
        ListViewer.SmallImageList = Small_imgs

        Dim itemcollection(database.GetLength(0) - 1) As ListViewItem

        ListViewer.BeginUpdate()
        For i = 0 To database.GetLength(0) - 1
            Try
                Large_imgs.Images.Add(Image.FromFile(database(i, 0)))
                Small_imgs.Images.Add(Image.FromFile(database(i, 0)))
            Catch ex As Exception

            End Try

            Dim item As New ListViewItem(database(i, 1), i)

            For j As Integer = 2 To database.GetLength(1) - 1
                item.SubItems.Add(database(i, j))
            Next

            itemcollection(i) = item
        Next

        ListViewer.Items.AddRange(itemcollection)
        ListViewer.EndUpdate()
    End Sub

    Private Sub Set_Default_Settings()
        For Each oFont As FontFamily In FontFamily.Families
            Cbox_FontSettings.Items.Add(oFont.Name)
        Next

        'Loads Book Viewer Default Settings'
        Cbox_ViewSettings.SelectedIndex = 0
        Cbox_ArrangeSettings.SelectedIndex = 0
        Cbox_FontSize.SelectedIndex = 2
        Cbox_FontSettings.SelectedIndex = 134

        If datatype = "Main" Then
            Cbox_ViewSettings.SelectedIndex = 2
            Cbox_GridSettings.SelectedIndex = 0
            Btn_Search.Hide()
            Txtbox_Searchbar.Hide()
        Else
            Cbox_GridSettings.SelectedIndex = 2
        End If
    End Sub

    'Search Function (To be edited...)
    Public Sub Search(searchstring As String, filter As String)
        ListViewer.SelectedIndices.Clear()
        For Each item As ListViewItem In ListViewer.Items
            Dim match As Boolean = False

            For Each subitem As ListViewItem.ListViewSubItem In item.SubItems
                If subitem.Text = searchstring Then
                    match = True

                    Exit For
                End If
            Next

            If match = False Then
                'UNFINISHED: change content of If statement'
                ListViewer.Items.Remove(item)
            End If
        Next
    End Sub

    'Get Selected Item/s
    Public Function Get_SelectedItems()
        Return ListViewer.SelectedItems
    End Function



    'Remove Selected Item/s
    Public Sub Remove_SelectedItems()
        For Each i As ListViewItem In ListViewer.SelectedItems
            ListViewer.Items.Remove(i)
        Next
    End Sub

    'Add Item to the ListView, (items = ListViewItem of Pending, img = Assigned Image to ListViewItem of Pending)
    Public Sub Add_Item(items, img)
        Me.Large_imgs.Images.Add(img)
        Me.Small_imgs.Images.Add(img)
        ListViewer.Items.Add(items.Clone())
        ListViewer.Items(ListViewer.Items.Count - 1).ImageIndex = Large_imgs.Images.Count - 1
    End Sub


    'CONTROL COMPONENTS============================================================================================

    'List Settings Button
    Private Sub Btn_ListSettings_Click(sender As Object, e As EventArgs) Handles Btn_ListSettings.Click
        If Panel_BookSettings.Visible = False Then
            Panel_BookSettings.Show()
            Btn_ListSettings.BackColor = Color.FromArgb(201, 199, 199)
        Else
            Panel_BookSettings.Hide()
            Btn_ListSettings.BackColor = Color.Transparent
        End If
    End Sub

    'View Settings Combobox
    Private Sub Cbox_ViewSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_ViewSettings.SelectedIndexChanged
        Select Case Cbox_ViewSettings.Text
            Case "Details"
                Me.ListViewer.View = View.Details
            Case "Large Icons"
                Me.ListViewer.View = View.LargeIcon
            Case "Tile"
                Me.ListViewer.View = View.Tile
        End Select
    End Sub

    'Spacing/Arrangement Settings Combobox
    Private Sub Cb_Arrangement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_ArrangeSettings.SelectedIndexChanged
        Select Case Cbox_ArrangeSettings.Text
            Case "Default Length"
                Select Case datatype
                    Case "Borrows"
                        ListViewer.Columns(0).Width = 250
                        ListViewer.Columns(1).Width = 150
                        ListViewer.Columns(2).Width = 650
                    Case "Borrowed"
                        ListViewer.Columns(0).Width = 250
                        ListViewer.Columns(1).Width = 150
                        ListViewer.Columns(2).Width = 650
                    Case "Inventory"
                        ListViewer.Columns(0).Width = 250
                        ListViewer.Columns(1).Width = 250
                        ListViewer.Columns(2).Width = 150
                        ListViewer.Columns(3).Width = 130
                        ListViewer.Columns(4).Width = 100
                        ListViewer.Columns(5).Width = 100
                        ListViewer.Columns(6).Width = 100
                    Case "Main"
                        ListViewer.Columns(0).Width = 250
                        ListViewer.Columns(1).Width = 250
                        ListViewer.Columns(2).Width = 150
                        ListViewer.Columns(3).Width = 130
                        ListViewer.Columns(4).Width = 100
                        ListViewer.Columns(5).Width = 100
                        ListViewer.Columns(6).Width = 100
                    Case "Staff"
                        ListViewer.Columns(0).Width = 300
                        ListViewer.Columns(1).Width = 100
                        ListViewer.Columns(2).Width = 100
                        ListViewer.Columns(3).Width = 250
                        ListViewer.Columns(4).Width = 200
                        ListViewer.Columns(5).Width = 150
                End Select
            Case "Header Length"
                Me.ListViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                ListViewer.Columns(ListViewer.Columns.Count - 1).Width = ListViewer.Columns(ListViewer.Columns.Count - 1).Width - 30
            Case "Content Length"
                Me.ListViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
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
            Case "Bold"
                Me.ListViewer.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Bold)
            Case "Italic"
                Me.ListViewer.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Italic)
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
            Case "Lines"
                ListViewer.GridLines = True
                For i As Integer = 0 To ListViewer.Items.Count - 1 Step 1
                    ListViewer.Items(i).BackColor = Color.White
                Next
            Case "Divisions"
                ListViewer.GridLines = False
                For i As Integer = 0 To ListViewer.Items.Count - 1 Step 2
                    ListViewer.Items(i).BackColor = Color.FromArgb(233, 242, 252)
                Next
        End Select
    End Sub

    Private Sub ListViewer_DoubleClick(sender As Object, e As EventArgs) Handles ListViewer.DoubleClick
        parent_form.Double_Click_Event()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        ListViewer.Clear()
        Load_DataViewer(database, datatype, parent_form)

        If Txtbox_Searchbar.Text <> "" Then
            Search(Txtbox_Searchbar.Text, "All")
        End If
    End Sub

    Private Sub Txtbox_Searchbar_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Searchbar.TextChanged
        If Txtbox_Searchbar.Text = "" Then
            ListViewer.Clear()
            Load_DataViewer(database, datatype, parent_form)
        End If
    End Sub
End Class

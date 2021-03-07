Public Class UC_DataViewer
    Private datatype As String
    Private parentform

    Public Sub Load_DataViewer(type, parent)
        Me.datatype = type
        Me.parentform = parent

        Create_Column_Header()
        Fill_Data()

        For Each oFont As FontFamily In FontFamily.Families
            Cbox_FontSettings.Items.Add(oFont.Name)
        Next

        'Loads Book Viewer Default Settings'
        Cbox_ViewSettings.SelectedIndex = 0
        Cbox_ArrangeSettings.SelectedIndex = 0
        Cbox_FontSize.SelectedIndex = 2
        Cbox_FontSettings.SelectedIndex = 134
        Cbox_GridSettings.SelectedIndex = 2
    End Sub

    'Create Column Headers of Data List
    Private Sub Create_Column_Header()
        Select Case datatype
            Case "Borrows"
                Dim HeaderText = New String() {"Name", "Sections", "Books"}
                Dim HeaderWidth = New Integer() {550, 250, 250}

                For i As Integer = 0 To HeaderText.Length - 1
                    ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
                Next
            Case "Borrowed"
                Dim HeaderText = New String() {"Name", "Sections", "Books"}
                Dim HeaderWidth = New Integer() {550, 250, 250}

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
        End Select
    End Sub

    'Fill Data Function (To be edited...)
    Private Sub Fill_Data()
        Me.ListViewer.View = View.Details

        Dim Large_imgs As ImageList = New ImageList()
        Large_imgs.ImageSize = New Size(66, 100)
        Large_imgs.ColorDepth = ColorDepth.Depth32Bit

        Dim Small_imgs As ImageList = New ImageList()
        Small_imgs.ImageSize = New Size(33, 50)
        Small_imgs.ColorDepth = ColorDepth.Depth32Bit

        ListViewer.LargeImageList = Large_imgs
        ListViewer.SmallImageList = Small_imgs

        Dim title As String = "Some Book I've Never Read Some Book I've Never Read"
        Dim author As String = "J. R. R. Someone"
        Dim isbn As String = "9780048231536"
        Dim year As String = "9/15/1977"
        Dim codeNo As String = ""
        Dim category As String = "Literature"
        Dim shelveNo As String = "001"

        'fix to i = 4 to i = 0
        For i = 0 To 3
            Dim files As String() = New String() {}
            files = System.IO.Directory.GetFiles("C:/Users/Jukebox/Desktop/Images")
            Try
                For Each f In files
                    Large_imgs.Images.Add(Image.FromFile(f))
                    Small_imgs.Images.Add(Image.FromFile(f))
                Next
            Catch ex As Exception

            End Try

            codeNo = i
            Dim book As String() = {author, isbn, year, codeNo, category, shelveNo}
            Me.ListViewer.Items.Add(title, i).SubItems.AddRange(book)
        Next
    End Sub

    'Search Function (To be edited...)
    Private Sub SearchList(lstview As ListView, searchstring As String)
        lstview.SelectedIndices.Clear()
        For Each item As ListViewItem In lstview.Items
            For Each subitem As ListViewItem.ListViewSubItem In item.SubItems
                If subitem.Text = searchstring Then
                    'UNFINISHED: change content of If statement'
                    lstview.SelectedIndices.Add(item.Index)
                    Exit For
                End If
            Next
        Next
    End Sub

    'Get Selected Item/s
    Public Function Get_Selected()
        Return ListViewer.SelectedItems
    End Function

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
                        ListViewer.Columns(0).Width = 550
                        ListViewer.Columns(1).Width = 250
                        ListViewer.Columns(2).Width = 250
                    Case "Borrowed"
                        ListViewer.Columns(0).Width = 550
                        ListViewer.Columns(1).Width = 250
                        ListViewer.Columns(2).Width = 250
                    Case "Inventory"
                        ListViewer.Columns(0).Width = 250
                        ListViewer.Columns(1).Width = 250
                        ListViewer.Columns(2).Width = 150
                        ListViewer.Columns(3).Width = 130
                        ListViewer.Columns(4).Width = 100
                        ListViewer.Columns(5).Width = 100
                        ListViewer.Columns(6).Width = 100
                End Select




            Case "Header Length"
                Me.ListViewer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                ListViewer.Columns(6).Width = 100
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
        parentform.Double_Click_Event()
    End Sub
End Class

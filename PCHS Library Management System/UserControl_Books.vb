Public Class UserControl_Books

    Private Sub UserControl_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_BooksData()
        LoadSettings()
    End Sub

    'BOOKS PANEL BUTTONS AND FUNCTIONS'
    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        Dim FormBook As New Form_Books
        FormBook.ShowDialog()
    End Sub

    Private Sub Btn_BookSearch_Click(sender As Object, e As EventArgs) Handles Btn_BookSearch.Click
        SearchList(Me.ListView_Books, Txtbox_InvSearchBar.Text)
    End Sub

    Private Sub Btn_BookSettings_Click(sender As Object, e As EventArgs) Handles Btn_BookSettings.Click
        If Panel_BookSettings.Visible = False Then
            Panel_BookSettings.Show()
            Btn_BookSettings.BackColor = Color.FromArgb(201, 199, 199)
        Else
            Panel_BookSettings.Hide()
            Btn_BookSettings.BackColor = Color.FromArgb(224, 222, 222)
        End If
    End Sub

    Private Sub Cbox_ViewSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_ViewSettings.SelectedIndexChanged
        Select Case Cbox_ViewSettings.Text
            Case "Details"
                Me.ListView_Books.View = View.Details
            Case "List"
                Me.ListView_Books.View = View.List
            Case "Large Icons"
                Me.ListView_Books.View = View.LargeIcon
            Case "Small Icons"
                Me.ListView_Books.View = View.SmallIcon
            Case "Tile"
                Me.ListView_Books.View = View.Tile
        End Select
    End Sub

    Private Sub Cb_Arrangement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_ArrangeSettings.SelectedIndexChanged
        Select Case Cbox_ArrangeSettings.Text
            Case "Default Length"
                CH_Title.Width = 250
                CH_Author.Width = 250
                CH_ISBN.Width = 150
                CH_YearPublished.Width = 130
                CH_Code.Width = 100
                CH_Category.Width = 100
                CH_ShelveNo.Width = 100
            Case "Header Length"
                Me.ListView_Books.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                CH_ShelveNo.Width = 100
            Case "Content Length"
                Me.ListView_Books.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End Select
    End Sub

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

    Private Sub Change_Font_and_Style(sender As Object, e As EventArgs) Handles Cbox_FontSettings.SelectedIndexChanged, Cbox_FontStyleSettings.SelectedIndexChanged, Cbox_FontSize.SelectedIndexChanged

        Select Case Cbox_FontStyleSettings.Text
            Case "Regular"
                Me.ListView_Books.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Regular)
            Case "Bold"
                Me.ListView_Books.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Bold)
            Case "Italic"
                Me.ListView_Books.Font = New Font(New FontFamily(Cbox_FontSettings.Text), Convert.ToInt32(Cbox_FontSize.Text), FontStyle.Italic)
        End Select
    End Sub

    Private Sub Cbox_GridSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_GridSettings.SelectedIndexChanged
        Select Case Cbox_GridSettings.Text
            Case "None"
                ListView_Books.GridLines = False
                For i As Integer = 0 To ListView_Books.Items.Count - 1 Step 1
                    ListView_Books.Items(i).BackColor = Color.White
                Next
            Case "Lines"
                ListView_Books.GridLines = True
                For i As Integer = 0 To ListView_Books.Items.Count - 1 Step 1
                    ListView_Books.Items(i).BackColor = Color.White
                Next
            Case "Divisions"
                ListView_Books.GridLines = False
                For i As Integer = 0 To ListView_Books.Items.Count - 1 Step 2
                    ListView_Books.Items(i).BackColor = Color.FromArgb(233, 242, 252)
                Next
        End Select
    End Sub

    Private Sub Fill_BooksData()
        Me.ListView_Books.View = View.Details

        Dim title As String = "Some Book I've Never Read"
        Dim author As String = "J. R. R. Someone"
        Dim isbn As String = "9780048231536"
        Dim year As String = "9/15/1977"
        Dim codeNo As String = ""
        Dim category As String = "Literature"
        Dim shelveNo As String = "001"

        Dim Large_imgs As ImageList = New ImageList()
        Large_imgs.ImageSize = New Size(100, 100)


        Dim Small_imgs As ImageList = New ImageList()
        Small_imgs.ImageSize = New Size(50, 50)
        Small_imgs.ColorDepth = ColorDepth.Depth32Bit

        ListView_Books.LargeImageList = Large_imgs
        ListView_Books.SmallImageList = Small_imgs

        For i = 0 To 51

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
            Me.ListView_Books.Items.Add(title, i).SubItems.AddRange(book)
        Next
    End Sub

    'LOAD FUNCTIONS
    Private Sub LoadSettings()
        For Each oFont As FontFamily In FontFamily.Families
            Cbox_FontSettings.Items.Add(oFont.Name)
        Next

        'Loads Book Viewer Settings'
        Cbox_ViewSettings.SelectedIndex = 0
        Cbox_ArrangeSettings.SelectedIndex = 0
        Cbox_FontSize.SelectedIndex = 2
        Cbox_FontSettings.SelectedIndex = 134
        Cbox_GridSettings.SelectedIndex = 2
    End Sub


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


End Class

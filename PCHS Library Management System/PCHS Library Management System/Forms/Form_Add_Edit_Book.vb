Imports System.Text
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode.Internal
Imports ZXing.Rendering
Imports System.IO

'================================
'TABLE OF CONTENTS
'   1. Form Loader
'
'   2. Button Functions
'================================
Public Class Form_Add_Edit_Book
    Public listviewItems As New List(Of ListViewItem)
    Public listimages As New List(Of Image)

    Private bookids() As Integer
    Private currentindex As Integer = 0

    '==================
    '  1. FORM LOADER  
    '==================

    Public Sub PopulateSubjects()
        Try
            openCon()
            command("SELECT * FROM tbl_subjects")
            FillTable()
            Cbox_Subjects.DataSource = Nothing
            Cbox_Subjects.Items.Clear()
            Cbox_Subjects.DataSource = New BindingSource(datatable, Nothing)
            Cbox_Subjects.DisplayMember = "sub_name"
            Cbox_Subjects.ValueMember = "subjectID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        closeCon()
    End Sub


    '========================
    '  1. BUTTON FUNCTIONS  
    '========================
    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        If ErrorChecker() = True Then
            Dim authorID = CheckAuthor()
            Dim publisherID = CheckPublisher()

            If authorID <> 0 And publisherID <> 0 Then
                AddBook(authorID, publisherID)
            End If
        End If
    End Sub

    Private Sub Btn_UpdateBook_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBook.Click
        UpdateBook()

        If currentindex = bookids.Length - 1 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            currentindex += 1
            Lbl_mode.Text = "EDIT BOOK  " & (currentindex + 1) & "/" & bookids.Length
            FillTextboxes()
        End If
    End Sub

    Private Sub Button_Cancel(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub ImageCover_Label_Click(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.Click
        Try
            Dim fd As OpenFileDialog = New OpenFileDialog()

            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "Desktop"
            fd.Filter = "All Files|*.*|Image Files|*.jpg;*.gif;*.png;*.bmp"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True

            If fd.ShowDialog() = DialogResult.OK Then
                Panel_Image.BackgroundImage = Image.FromFile(fd.FileName)
            End If
        Catch ex As Exception
            Msg.SetContent("", "File is not a valid Image")
            Msg.ShowDialog()
        End Try
    End Sub


    '=======================
    '  3. LOCAL FUNCTIONS  
    '=======================

    Private Function CheckAuthor()
        Dim authID As Integer = 0

        Try
            openCon()
            command("SELECT * FROM tbl_authors WHERE author_name = @author")
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@author", Txtbox_Author.Text)
            Dim tempname = cmd.ExecuteScalar()

            If tempname IsNot Nothing Then
                authID = tempname
            Else
                Try
                    Msg.SetContent(Txtbox_Author.Text, "does not exist in the data base, Would you like to add this Author?")

                    If Msg.ShowDialog() = DialogResult.OK Then
                        cmd.Parameters.Clear()
                        command("INSERT INTO tbl_authors (`author_name`) VALUES (@author); Select @@identity")
                        cmd.Parameters.AddWithValue("@author", Txtbox_Author.Text)
                        authID = cmd.ExecuteScalar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return authID
    End Function

    Private Function CheckPublisher()
        Dim pubid As Integer = 0

        Try
            openCon()
            command("SELECT * FROM tbl_publishers WHERE pub_name = @name")
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", Txtbox_Publisher.Text)
            Dim tempname = cmd.ExecuteScalar()

            If tempname IsNot Nothing Then
                pubid = tempname
            Else
                Msg.SetContent(Txtbox_Publisher.Text, "does not exist in the data base, Would you like to add this Publisher?")

                If Msg.ShowDialog() = DialogResult.OK Then

                    cmd.Parameters.Clear()
                    command("INSERT INTO tbl_publishers (`pub_name`) VALUES (@publisher); SELECT @@identity")
                    cmd.Parameters.AddWithValue("@publisher", Txtbox_Publisher.Text)
                    pubid = cmd.ExecuteScalar()

                End If
            End If

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return pubid
    End Function

    Private Sub AddBook(authorID, publisherID)
        Try
            openCon()
            cmd.Parameters.Clear()
            command("INSERT INTO tbl_book (`title`, `quantity`, `yearPublished`, 
                    `shelfNo`, `isbn`, `cover`, `authorID`, `subjectID`, `publisherID`) 

                    VALUES (@title, @quantity, @yearpub, @shelfno, @isbn, @cover, @authorID, @subjectID, @publisherID); 
                    SELECT @@identity")

            cmd.Parameters.AddWithValue("@title", Txtbox_Title.Text)
            cmd.Parameters.AddWithValue("@quantity", Txtbox_Quantity.Text)
            cmd.Parameters.AddWithValue("@yearpub", DatePicker.Value)
            cmd.Parameters.AddWithValue("@shelfno", Txtbox_ShelfNo.Text)
            cmd.Parameters.AddWithValue("@isbn", Txtbox_ISBNNo.Text)
            cmd.Parameters.AddWithValue("@authorID", authorID)
            cmd.Parameters.AddWithValue("@subjectID", Cbox_Subjects.SelectedValue)
            cmd.Parameters.AddWithValue("@publisherID", publisherID)

            Dim ms As New MemoryStream
            Panel_Image.BackgroundImage.Save(ms, Panel_Image.BackgroundImage.RawFormat)
            Dim imagedata As Byte() = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@cover", imagedata)

            Dim temp As Integer = cmd.ExecuteScalar

            CreateListItem(temp)

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub UpdateBook()
        If ErrorChecker() = True Then
            Dim authorID = CheckAuthor()
            Dim publisherID = CheckPublisher()

            If authorID <> 0 And publisherID <> 0 Then
                Try
                    openCon()

                    cmd.Parameters.Clear()
                    command("UPDATE tbl_book SET `title` = @title, `quantity` = @quantity, `yearPublished` = @date, 
                    `shelfNo` = @shelfno, `isbn` = @isbn, `authorID` = @authoriD, `subjectID` = @subjectID,
                    `publisherID` = @publisherID, `cover` = @cover WHERE (`bookID` = @bookID);")

                    cmd.Parameters.AddWithValue("@title", Txtbox_Title.Text)
                    cmd.Parameters.AddWithValue("@quantity", Txtbox_Quantity.Text)
                    cmd.Parameters.AddWithValue("@date", DatePicker.Value.Date)
                    cmd.Parameters.AddWithValue("@shelfno", Txtbox_ShelfNo.Text)
                    cmd.Parameters.AddWithValue("@isbn", Txtbox_ISBNNo.Text)
                    cmd.Parameters.AddWithValue("@authorID", authorID)
                    cmd.Parameters.AddWithValue("@subjectID", Cbox_Subjects.SelectedValue)
                    cmd.Parameters.AddWithValue("@publisherID", publisherID)
                    cmd.Parameters.AddWithValue("@bookID", bookids(currentindex))

                    Dim ms As New MemoryStream
                    Panel_Image.BackgroundImage.Save(ms, Panel_Image.BackgroundImage.RawFormat)
                    Dim imagedata As Byte() = ms.GetBuffer()
                    cmd.Parameters.AddWithValue("@cover", imagedata)

                    CreateListItem(bookids(currentindex))
                    execute()
                    closeCon()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Public Sub UpdateMode(ids)
        PopulateSubjects()
        Me.bookids = ids
        currentindex = 0

        Btn_AddBook.Visible = False
        Btn_UpdateBook.Visible = True

        Lbl_mode.Text = "EDIT 1 / " & ids.Length
        FillTextboxes()
    End Sub

    Private Sub FillTextboxes()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT * FROM tbl_book 
                    LEFT JOIN tbl_authors ON tbl_authors.authorID = tbl_book.authorID
                    LEFT JOIN tbl_subjects ON tbl_subjects.subjectID = tbl_book.subjectID 
                    LEFT JOIN tbl_publishers ON tbl_publishers.publisherID = tbl_book.publisherID 
                    WHERE (bookID = @bookid)")

            cmd.Parameters.AddWithValue("@bookid", bookids(currentindex))
            reader = cmd.ExecuteReader()

            While reader.Read()
                Txtbox_Title.Text = reader("title").ToString
                Txtbox_Author.Text = reader("author_name").ToString
                Txtbox_ISBNNo.Text = reader("isbn").ToString
                DatePicker.Value = reader("yearPublished")
                Txtbox_Quantity.Text = reader("quantity").ToString
                Txtbox_ShelfNo.Text = reader("shelfNo").ToString
                Txtbox_Publisher.Text = reader("pub_name").ToString

                Dim bytes() As Byte
                bytes = (reader("cover"))
                Dim memStream As New MemoryStream(bytes)
                Panel_Image.BackgroundImage = Drawing.Image.FromStream(memStream)

                Cbox_Subjects.SelectedIndex = -1
                For Each item In Cbox_Subjects.Items
                    If reader("sub_name").ToString = Cbox_Subjects.GetItemText(item) Then Cbox_Subjects.SelectedItem = item
                Next
            End While

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CreateListItem(id)
        Dim listitem As New ListViewItem

        listitem.SubItems(0).Text = Txtbox_Title.Text
        listitem.SubItems.Add(Txtbox_Author.Text)
        listitem.SubItems.Add(Cbox_Subjects.Text)
        listitem.SubItems.Add(Txtbox_ShelfNo.Text)
        listitem.SubItems.Add(CStr(DatePicker.Value.Date))
        listitem.SubItems.Add(Txtbox_Quantity.Text)
        listitem.SubItems.Add(Txtbox_ISBNNo.Text)
        listitem.SubItems.Add(id)

        listviewItems.Add(listitem)
        listimages.Add(Panel_Image.BackgroundImage)
    End Sub


    Private Function ErrorChecker()
        Dim textbox As TextBox() = {Txtbox_Title, Txtbox_Author, Txtbox_ISBNNo, Txtbox_Publisher,
                                    Txtbox_Quantity, Txtbox_ShelfNo}
        Dim boxname As String() = {"Title", "Author", "ISBN No", "Publisher", "Quantity", "Shelf No"}

        Dim pass As Boolean = True
        Dim errormsg As String = ""

        For i As Integer = 0 To textbox.Length - 1
            Dim errors As String = boxname(i) & " "

            If textbox(i).Text = "" Then
                errors += " Is Empty. "
                pass = False
            End If

            If textbox(i) Is Txtbox_Quantity Then
                If IsNumeric(textbox(i).Text) = False Then
                    errors += "is not a number. "
                    pass = False
                End If
            End If

            If errors <> boxname(i) & " " Then
                If i <> 0 Then
                    errormsg += vbCrLf & vbCrLf
                End If
                errormsg += errors
            End If
        Next

        If pass = False Then
            Msg.SetContent("ERROR!", errormsg)
            Msg.ShowDialog()
        End If

        Return pass
    End Function


    '========================
    '  3. GUI DESIGN FUNCTIONS  
    '========================
    Private Sub Panel_Image_Cover_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Image.MouseEnter
        Lbl_ChangeImage.Visible = True
    End Sub

    Private Sub Lbl_ChangeImage_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.MouseLeave
        Lbl_ChangeImage.Visible = False
    End Sub

    Private Sub Btn_AddSub_Click(sender As Object, e As EventArgs) Handles Btn_AddSub.Click
        If Cbox_Subjects.Visible = True Then
            Cbox_Subjects.Hide()
            Txtbox_Subject.Show()
            Panel_Subject.Show()
        Else
            If Txtbox_Subject.Text <> "" Then
                AddSubject()
            End If

            Txtbox_Subject.Hide()
            Panel_Subject.Hide()
            Cbox_Subjects.Show()
        End If
    End Sub

    Private Sub AddSubject()
        Msg.SetContent("", "Add This subject?")

        If Msg.ShowDialog = DialogResult.OK Then
            Try
                openCon()
                cmd.Parameters.Clear()
                command("INSERT INTO tbl_subjects (`sub_name`)  VALUES (@subject)")
                cmd.Parameters.AddWithValue("@subject", Txtbox_Subject.Text)
                execute()
                closeCon()

                PopulateSubjects()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Txtbox_Subject_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Subject.TextChanged
        If Txtbox_Subject.Text <> "" Then
            Btn_AddSub.BackColor = Color.DarkSeaGreen
        Else
            Btn_AddSub.BackColor = SystemColors.ControlLight
        End If
    End Sub
End Class

Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports Google.Protobuf.WellKnownTypes

Public Class Form_Borrowers
    Public addedID As String
    Public selectedItems As ListView.SelectedListViewItemCollection
    Public index As Integer = 0
    Public listimage As Image
    Public largeimage As ImageList
    Public smallimage As ImageList

    Private Sub AddLibrarian()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("INSERT INTO tbl_borrowers (`fname`, `lname`, `section`, `email`, `contactnum`, `address`, `borrowerIMG`) 

                    VALUES (@fname, @lname, @section, @email, @contactnum, @address, @borrowerIMG); 
                    SELECT @@identity")

            cmd.Parameters.AddWithValue("@fname", Txtbox_Fname.Text)
            cmd.Parameters.AddWithValue("@lname", Txtbox_Lname.Text)
            cmd.Parameters.AddWithValue("@section", Txtbox_Section.Text)
            cmd.Parameters.AddWithValue("@email", Txtbox_Email.Text)
            cmd.Parameters.AddWithValue("@contactnum", Txtbox_ContactNum.Text)
            cmd.Parameters.AddWithValue("@address", Txtbox_HomeAdd.Text)

            Dim ms As New MemoryStream
            Panel_Image.BackgroundImage.Save(ms, Panel_Image.BackgroundImage.RawFormat)
            Dim imagedata As Byte() = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@borrowerIMG", imagedata)

            addedID = cmd.ExecuteScalar
            listimage = Panel_Image.BackgroundImage

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Function ErrorChecker()
        Dim textbox As TextBox() = {Txtbox_Fname, Txtbox_Lname, Txtbox_Section, Txtbox_Email, Txtbox_HomeAdd, Txtbox_ContactNum}
        Dim boxname As String() = {"First Name", "Last Name", "Section", "Email Address", "Home Address", "Contact Number"}

        Dim pass As Boolean = True
        Dim errormsg As String = ""

        For i As Integer = 0 To textbox.Length - 1
            Dim errors As String = boxname(i) & " "

            If textbox(i).Text = "" Then
                errors += " Is Empty. "
                pass = False
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


    Public Sub UpdateItems(selectedlistitems As ListView.SelectedListViewItemCollection)
        Btn_Cancel.Location = New Point(431, 466)
        Btn_AddStaff.Hide()
        Btn_Edit.Show()
        Btn_Remove.Show()

        Lbl_mode.Text = "EDIT BORROWERS 1 /" & " " & selectedlistitems.Count
        Me.selectedItems = selectedlistitems
        FillInformation()
    End Sub

    Private Sub FillInformation()
        Dim names As String() = Split(selectedItems(index).SubItems(0).Text)

        Dim fname As String = names(0)
        If names.Length > 2 Then
            For i As Integer = 1 To names.Length - 2
                fname += " " & names(i)
            Next
        End If

        Txtbox_Fname.Text = fname
        Txtbox_Lname.Text = names(names.Length - 1)
        Txtbox_Section.Text = selectedItems(index).SubItems(1).Text
        Txtbox_Email.Text = selectedItems(index).SubItems(2).Text
        Txtbox_ContactNum.Text = selectedItems(index).SubItems(3).Text
        Txtbox_HomeAdd.Text = selectedItems(index).SubItems(4).Text
        FillImage(selectedItems(index).SubItems(5).Text)
    End Sub

    Private Sub FillImage(id)
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT borrowerIMG FROM tbl_borrowers WHERE (`borrowerID` = @id)")
            cmd.Parameters.AddWithValue("@id", id)

            Dim bytes() As Byte = (cmd.ExecuteScalar)
            Dim memStream As New IO.MemoryStream(bytes)
            Panel_Image.BackgroundImage = (Drawing.Image.FromStream(memStream))
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateBorrower()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("UPDATE tbl_borrowers SET `fname` = @fname, `lname` = @lname, `section` = @section,
                    `email` = @email, `contactnum` = @contactnum, `address` = @address, `borrowerIMG` = @img
                    WHERE (`borrowerID` = @ID);")
            cmd.Parameters.AddWithValue("@fname", Txtbox_Fname.Text)
            cmd.Parameters.AddWithValue("@lname", Txtbox_Lname.Text)
            cmd.Parameters.AddWithValue("@section", Txtbox_Section.Text)
            cmd.Parameters.AddWithValue("@email", Txtbox_Email.Text)
            cmd.Parameters.AddWithValue("@contactnum", Txtbox_ContactNum.Text)
            cmd.Parameters.AddWithValue("@address", Txtbox_HomeAdd.Text)
            cmd.Parameters.AddWithValue("@ID", selectedItems(index).SubItems(5).Text)

            Dim ms As New MemoryStream
            Panel_Image.BackgroundImage.Save(ms, Panel_Image.BackgroundImage.RawFormat)
            Dim imagedata As Byte() = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@img", imagedata)
            execute()
            closeCon()

            selectedItems(index).SubItems(0).Text = Txtbox_Fname.Text & " " & Txtbox_Lname.Text
            selectedItems(index).SubItems(1).Text = Txtbox_Section.Text
            selectedItems(index).SubItems(2).Text = Txtbox_Email.Text
            selectedItems(index).SubItems(3).Text = Txtbox_ContactNum.Text
            selectedItems(index).SubItems(4).Text = Txtbox_HomeAdd.Text

            Dim img As Image = Panel_Image.BackgroundImage
            Dim bmp As Bitmap = New Bitmap(50, 50)
            Dim graph As Graphics = Graphics.FromImage(bmp)
            graph.DrawImage(img, New Rectangle(0, 0, 50, 50))
            smallimage.Images(selectedItems(index).ImageIndex) = bmp

            bmp = New Bitmap(100, 100)
            graph = Graphics.FromImage(bmp)
            graph.DrawImage(img, New Rectangle(0, 0, 100, 100))
            largeimage.Images(selectedItems(index).ImageIndex) = bmp
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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



    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Msg.SetContent("", "Are you sure you would like to edit this account?")
        If Msg.ShowDialog = DialogResult.OK Then
            UpdateBorrower()
        End If

        If index = selectedItems.Count - 1 Then
            Me.DialogResult = DialogResult.OK
        Else
            index += 1
            Lbl_mode.Text = "Edit Borrower " & index + 1 & " / " & selectedItems.Count
            FillInformation()
        End If
    End Sub

    'GUI DESIGN FUNCTIONS ==========================================================================================
    Private Sub Panel_Image_Cover_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Image.MouseEnter
        Lbl_ChangeImage.Visible = True
    End Sub

    Private Sub Lbl_ChangeImage_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.MouseLeave
        Lbl_ChangeImage.Visible = False
    End Sub

    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddStaff.Click
        If ErrorChecker() = True Then
            AddLibrarian()
        End If
    End Sub

    Private Sub Button_Cancel(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Msg.SetContent("", "Are you sure you would like to remove this account?")
        If Msg.ShowDialog = DialogResult.OK Then
            Try
                openCon()
                cmd.Parameters.Clear()

                command("DELETE FROM tbl_librarians WHERE (librarianID = @libID)")
                cmd.Parameters.AddWithValue("@libID", GetCurrentUser())
                execute()

                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Application.Restart()
        End If
    End Sub
End Class
Imports System.IO

Public Class Form_AddLibrarian
    Public tempUsername As String
    Public listviewItem As New ListViewItem
    Public listimage As Image

    Private Sub AddLibrarian()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("INSERT INTO tbl_librarians (`username`, `password`, `fname`, `lname`, `address`, `email`,
                    `contactnum`, `type`, `libimg`) 

                    VALUES (@username, @password, @fname, @lname, @address, @email, @contactnum, @type, @libimg); 
                    SELECT @@identity")

            cmd.Parameters.AddWithValue("@username", Txtbox_Username.Text)
            cmd.Parameters.AddWithValue("@password", Txtbox_Password.Text)
            cmd.Parameters.AddWithValue("@fname", Txtbox_Fname.Text)
            cmd.Parameters.AddWithValue("@lname", Txtbox_Lname.Text)
            cmd.Parameters.AddWithValue("@address", Txtbox_HomeAdd.Text)
            cmd.Parameters.AddWithValue("@email", Txtbox_EmailAdd.Text)
            cmd.Parameters.AddWithValue("@contactnum", Txtbox_ContactNum.Text)
            cmd.Parameters.AddWithValue("@type", Cbox_Type.SelectedItem)

            Dim ms As New MemoryStream
            Panel_Image.BackgroundImage.Save(ms, Panel_Image.BackgroundImage.RawFormat)
            Dim imagedata As Byte() = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@libimg", imagedata)

            Dim temp As Integer = cmd.ExecuteScalar

            listviewItem.SubItems(0).Text = Txtbox_Username.Text
            listviewItem.SubItems.Add(Txtbox_Fname.Text & " " & Txtbox_Lname.Text)
            listviewItem.SubItems.Add(Txtbox_HomeAdd.Text)
            listviewItem.SubItems.Add(Txtbox_EmailAdd.Text)
            listviewItem.SubItems.Add(Txtbox_ContactNum.Text)
            listviewItem.SubItems.Add(Cbox_Type.SelectedItem)
            listviewItem.SubItems.Add(temp)
            listimage = Panel_Image.BackgroundImage

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Function ErrorChecker()
        Dim textbox As TextBox() = {Txtbox_Username, Txtbox_Fname, Txtbox_Lname, Txtbox_EmailAdd, Txtbox_HomeAdd, Txtbox_ContactNum}
        Dim boxname As String() = {"User Name", "First Name", "Last Name", "Email Address", "Home Address", "Contact Number"}

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

    Public Function CheckUsername(temp As String)
        Dim pass As Boolean = True

        Try
            If temp <> Txtbox_Username.Text Then
                openCon()
                cmd.Parameters.Clear()
                command("SELECT librarianID FROM tbl_librarians WHERE (`username` = @username)")
                cmd.Parameters.AddWithValue("@username", Txtbox_Username.Text)

                Dim id As String = cmd.ExecuteScalar
                If id IsNot Nothing Then
                    pass = False
                    Msg.SetContent("", vbCrLf & "Your Username: " & Txtbox_Username.Text & " is already taken")
                    Msg.ShowDialog()
                End If

                closeCon()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return pass
    End Function


    Public Sub EditMode()
        Btn_Cancel.Location = New Point(431, 466)
        Btn_AddStaff.Hide()
        Btn_Edit.Show()
        Btn_Remove.Show()
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

    'GUI DESIGN FUNCTIONS ==========================================================================================
    Private Sub Panel_Image_Cover_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Image.MouseEnter
        Lbl_ChangeImage.Visible = True
    End Sub

    Private Sub Lbl_ChangeImage_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.MouseLeave
        Lbl_ChangeImage.Visible = False
    End Sub

    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddStaff.Click
        If ErrorChecker() = True And CheckUsername("") = True Then
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

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If ErrorChecker() = True And CheckUsername(tempUsername) = True Then
            Msg.SetContent("", "Are you sure you would like to edit this account?")
            If Msg.ShowDialog = DialogResult.OK Then
                Dim passcommand As String = ""

                Try
                    openCon()
                    cmd.Parameters.Clear()

                    If Txtbox_Password.Text <> "" Then
                        passcommand = "`password` = @password,"
                        cmd.Parameters.AddWithValue("@password", Txtbox_Password.Text)
                    End If

                    command("UPDATE tbl_librarians SET `username` = @username, " & passcommand & "`fname` = @fname, 
                        `lname` = @lname, `address` = @address, `email` = @email, `contactnum` = @contactnum, 
                        `type` = @type, `libimg` = @libimg WHERE (`librarianID` = @libID);")
                    cmd.Parameters.AddWithValue("@username", Txtbox_Username.Text)
                    cmd.Parameters.AddWithValue("@fname", Txtbox_Fname.Text)
                    cmd.Parameters.AddWithValue("@lname", Txtbox_Lname.Text)
                    cmd.Parameters.AddWithValue("@address", Txtbox_HomeAdd.Text)
                    cmd.Parameters.AddWithValue("@email", Txtbox_EmailAdd.Text)
                    cmd.Parameters.AddWithValue("@contactnum", Txtbox_ContactNum.Text)
                    cmd.Parameters.AddWithValue("@type", Cbox_Type.Text)
                    cmd.Parameters.AddWithValue("@libID", GetCurrentUser())

                    Dim ms As New MemoryStream
                    Panel_Image.BackgroundImage.Save(ms, Panel_Image.BackgroundImage.RawFormat)
                    Dim imagedata As Byte() = ms.GetBuffer()
                    cmd.Parameters.AddWithValue("@libimg", imagedata)

                    execute()
                    closeCon()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class
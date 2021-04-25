Public Class Form_AddAuthor
    Public listviewItems As New List(Of ListViewItem)
    Public authorID As String
    Public ids As Integer()
    Public index As Integer = 0

    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        If ErrorChecker() = True Then
            Try
                openCon()
                cmd.Parameters.Clear()
                command("INSERT INTO tbl_authors (`author_name`)  VALUES (@name); SELECT @@identity")
                cmd.Parameters.AddWithValue("@name", Txtbox_Name.Text)
                authorID = cmd.ExecuteScalar
                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Public Sub UpdateAuthor(ids As Integer())
        Btn_AddBook.Hide()
        Btn_Edit.Show()
        Me.ids = ids

        Lbl_mode.Text = "Edit Author 1 / " & ids.Length
        FillTextBoxes()
    End Sub

    Private Sub FillTextBoxes()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT author_name FROM tbl_authors WHERE (authorID = @id)")
            cmd.Parameters.AddWithValue("@id", ids(index))
            Txtbox_Name.Text = cmd.ExecuteScalar

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateAuthor()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("UPDATE tbl_authors SET author_name = @name WHERE (authorID = @ID)")
            cmd.Parameters.AddWithValue("@name", Txtbox_Name.Text)
            cmd.Parameters.AddWithValue("@ID", ids(index))
            execute()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim listitem As New ListViewItem
        listitem.SubItems(0).Text = Txtbox_Name.Text
        listitem.SubItems.Add(ids(index))
        listviewItems.Add(listitem)
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If ErrorChecker() = True Then
            UpdateAuthor()

            If index = ids.Length - 1 Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                index += 1
                Lbl_mode.Text = "Edit Author " & index + 1 & " / " & ids.Length
                FillTextBoxes()
            End If
        End If
    End Sub

    Private Function ErrorChecker()
        Dim pass As Boolean = True

        If Txtbox_Name.Text = "" Then
            pass = False
            Msg.SetContent("", "Input is Empty, Please type in an Author")
            Msg.ShowDialog()
        End If

        Return pass
    End Function

End Class
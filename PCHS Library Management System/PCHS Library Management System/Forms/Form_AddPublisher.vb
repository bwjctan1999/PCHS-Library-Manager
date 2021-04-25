Public Class Form_AddPublisher
    Public listviewItems As New List(Of ListViewItem)
    Dim selectedItems As ListView.SelectedListViewItemCollection
    Public pubID As String
    Public index As Integer = 0

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        If ErrorChecker() = True Then
            Try
                openCon()
                cmd.Parameters.Clear()
                command("INSERT INTO tbl_publishers (`pub_name`)  VALUES (@name); SELECT @@identity")
                cmd.Parameters.AddWithValue("@name", Txtbox_Name.Text)
                pubID = cmd.ExecuteScalar
                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If ErrorChecker() = True Then
            EditPublisher()

            If index = selectedItems.Count - 1 Then
                Me.DialogResult = DialogResult.OK

            Else
                index += 1
                FillInformation()
            End If
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ErrorChecker()
        Dim pass As Boolean = True

        If Txtbox_Name.Text = "" Then
            pass = False
            Msg.SetContent("", "Input is Empty, Please type in a Publisher")
            Msg.ShowDialog()
        End If

        Return pass
    End Function

    Public Sub UpdateItems(selecteditems)
        Btn_Add.Hide()
        Btn_Edit.Show()

        Me.selectedItems = selecteditems
        FillInformation()
    End Sub

    Public Sub FillInformation()
        Lbl_mode.Text = "EDIT PUBLISHER " & index + 1 & " / " & selectedItems.Count
        Txtbox_Name.Text = selectedItems(index).SubItems(0).Text
    End Sub

    Private Sub EditPublisher()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("UPDATE tbl_publishers SET `pub_name` = @name WHERE (publisherID = @ID)")
            cmd.Parameters.AddWithValue("@name", Txtbox_Name.Text)
            cmd.Parameters.AddWithValue("@ID", selectedItems(index).SubItems(1).Text)
            execute()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        selectedItems(index).SubItems(0).Text = Txtbox_Name.Text
    End Sub
End Class
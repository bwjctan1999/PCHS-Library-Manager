Imports System.Security.Cryptography.X509Certificates

Public Class Form_AddSubject

    Public selecteditems As ListView.SelectedListViewItemCollection
    Public index As Integer = 0
    Public subID As String

    Private Sub AddSubject()
        If ErrorChecker() = True Then
            Try
                openCon()
                cmd.Parameters.Clear()
                command("INSERT INTO tbl_subjects (`sub_name`)  VALUES (@name); SELECT @@identity")
                cmd.Parameters.AddWithValue("@name", Txtbox_Subject.Text)
                subID = cmd.ExecuteScalar
                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub UpdateSubject()
        If ErrorChecker() = True Then

            Try
                openCon()
                cmd.Parameters.Clear()
                command("UPDATE tbl_subjects SET `sub_name` = @name WHERE (subjectID = @ID)")
                cmd.Parameters.AddWithValue("@name", Txtbox_Subject.Text)
                cmd.Parameters.AddWithValue("@ID", selecteditems(index).SubItems(1).Text)
                execute()
                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            selecteditems(index).SubItems(0).Text = Txtbox_Subject.Text
        End If
    End Sub

    Public Sub UpdateItems(selecteditems)
        Btn_Add.Hide()
        Btn_Edit.Show()

        Me.selecteditems = selecteditems
        FillInformation()
    End Sub

    Private Sub FillInformation()
        Lbl_mode.Text = "UPDATE SUBJECT " & index + 1 & " / " & selecteditems.Count
        Txtbox_Subject.Text = selecteditems(index).SubItems(0).Text
    End Sub

    Private Function ErrorChecker()
        Dim pass As Boolean = True

        If Txtbox_Subject.Text = "" Then
            Msg.SetContent("Error, Input Empty", "Please input a subject.")
            Msg.ShowDialog()
            pass = False
        End If

        Return pass
    End Function

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        AddSubject()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        UpdateSubject()

        If index = selecteditems.Count - 1 Then
            Me.DialogResult = DialogResult.OK
        Else
            index += 1
            FillInformation()
        End If
    End Sub
End Class
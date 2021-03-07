Public Class Form_Add_Edit_Book
    Private selectedindex As Integer = 0
    Private selecteditems

    Public Sub Start(mode, listitems)
        Me.selecteditems = listitems

        Select Case mode
            Case "Add"
                Lbl_mode.Text = "ADD BOOK"
                Btn_UpdateBook.Hide()
                Btn_AddBook.Show()

            Case "Update"
                Lbl_mode.Text = "EDIT BOOK  1/" & selecteditems.count
                Btn_AddBook.Hide()
                Btn_UpdateBook.Show()
                Load_Textboxes(0)

                Select Case selecteditems(0).SubItems(5).Text
                    Case "Computer science, information & general works"
                        Cbox_Category.SelectedIndex = 0
                    Case "Philosophy & psychology"
                        Cbox_Category.SelectedIndex = 1
                    Case "Religion"
                        Cbox_Category.SelectedIndex = 2
                    Case "Social sciences"
                        Cbox_Category.SelectedIndex = 3
                    Case "Language"
                        Cbox_Category.SelectedIndex = 4
                    Case "Pure Science"
                        Cbox_Category.SelectedIndex = 5
                    Case "Technology"
                        Cbox_Category.SelectedIndex = 6
                    Case "Arts & recreation"
                        Cbox_Category.SelectedIndex = 7
                    Case "Literature"
                        Cbox_Category.SelectedIndex = 8
                    Case "History & geography"
                        Cbox_Category.SelectedIndex = 9
                End Select
        End Select
    End Sub

    Private Sub Load_Textboxes(index As Integer)
        Txtbox_Title.Text = selecteditems(index).SubItems(0).Text
        Txtbox_Author.Text = selecteditems(index).SubItems(1).Text
        Txtbox_ISBNNo.Text = selecteditems(index).SubItems(2).Text
        Txtbox_PubDate.Text = selecteditems(index).SubItems(3).Text
        Txtbox_Quantity.Text = selecteditems(index).SubItems(4).Text 'FIX THIS: replace with quantity value
        Txtbox_CodeNo.Text = selecteditems(index).SubItems(4).Text
        Txtbox_ShelfNo.Text = selecteditems(index).SubItems(6).Text
    End Sub

    'CONTROL FUNCTIONS ===========================================================================================
    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        Me.Close()
    End Sub

    Private Sub Btn_UpdateBook_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBook.Click
        If selectedindex = selecteditems.count - 1 Then
            'Insert Update Function
            Me.Close()
        Else
            'Insert Update Function
            selectedindex += 1
            Lbl_mode.Text = "EDIT BOOK  " & (selectedindex + 1) & "/" & selecteditems.count
            Load_Textboxes(selectedindex)
        End If
    End Sub

    Private Sub Button_Cancel(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub ImageCover_Label_Click(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
    End Sub

    'GUI DESIGN FUNCTIONS ==========================================================================================
    Private Sub Panel_Image_Cover_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Image.MouseEnter
        Lbl_ChangeImage.Visible = True
    End Sub

    Private Sub Lbl_ChangeImage_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.MouseLeave
        Lbl_ChangeImage.Visible = False
    End Sub
End Class

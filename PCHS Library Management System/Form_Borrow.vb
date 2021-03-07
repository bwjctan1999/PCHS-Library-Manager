Public Class Form_Borrow
    Public Sub Set_Content(title, author, isbn, yearpub, code, category, shelve)
        Lbl_Title.Text = title
        Lbl_Author.Text = author
        Lbl_ISBNNo.Text = isbn
        Lbl_YearPub.Text = yearpub
        Lbl_CodeNo.Text = code
        Lbl_Category.Text = category
        Lbl_ShelveNo.Text = shelve
    End Sub

    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click

    End Sub
End Class
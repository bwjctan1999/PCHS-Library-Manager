Public Class Form_Borrow
    Private Mode As String = "Borrow"
    Private Selectedbook As UC_Book
    Private Picture As String

    Private Sub Change_to_CheckoutMode(sender As Object, e As EventArgs) Handles Me.Shown
        If Form_CheckOut.Visible = True Then
            Mode = "Remove"
            Btn_Borrow.Text = "Remove"
        Else
            Mode = "Borrow"
            Btn_Borrow.Text = "Borrow"
        End If
    End Sub

    Public Sub Set_Content(book, pic, title, author, isbn, yearpub, code, category, shelve)
        Selectedbook = book
        Me.Picture = pic
        Lbl_Title.Text = title
        Lbl_Author.Text = author
        Lbl_ISBNNo.Text = isbn
        Lbl_YearPub.Text = yearpub
        Lbl_CodeNo.Text = code
        Lbl_Category.Text = category
        Lbl_ShelveNo.Text = shelve

        Picbox_Cover.Image = Image.FromFile(pic)
    End Sub

    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_Borrow.Click
        If Mode = "Borrow" Then
            Dim book As New UC_Book
            book.Set_Data(Picture, Lbl_Title.Text, Lbl_Author.Text, Lbl_ISBNNo.Text, Lbl_YearPub.Text,
                          Lbl_CodeNo.Text, Lbl_Category.Text, Lbl_ShelveNo.Text)
            Form_CheckOut.Add_Book(book)
            Me.Close()
        ElseIf Mode = "Remove" Then
            Form_CheckOut.Remove_Book(Selectedbook)
            Me.Close()
        ElseIf Mode = "Reserve" Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class
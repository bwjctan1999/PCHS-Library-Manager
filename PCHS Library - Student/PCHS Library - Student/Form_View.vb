'================================
'TABLE OF CONTENTS
'   1. Form Loader
'   2. Set Book
'   3. Button Okay
'================================

Public Class Form_View
    Private Book As UC_Book
    Private Picture As Image


    '======================
    '   2. Form Loader
    '======================
    Private Sub Form_Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Author.Location = New Point(338, Lbl_Title.Height + Lbl_Title.Location.Y + 1)
        Lbl_By.Location = New Point(301, Lbl_Title.Height + Lbl_Title.Location.Y + 1)
    End Sub


    '================
    '  1. Set Book 
    '================
    Public Sub Set_Book(book As UC_Book)
        Me.Book = book
        Me.Picture = book.Picture
        Lbl_Title.Text = book.Title
        Lbl_Author.Text = book.Author
        Lbl_ISBNNo.Text = book.ISBN_No
        Lbl_YearPub.Text = book.Year_Published
        Lbl_Publisher.Text = book.Publisher
        Lbl_Subject.Text = book.Subject
        Lbl_ShelfNo.Text = book.Shelf_No
        Picbox_Cover.Image = Picture
    End Sub


    '=======================
    '  3. Button Okay
    '=======================
    Private Sub Btn_Okay_Click(sender As Object, e As EventArgs) Handles Btn_Okay.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class
Public Class UC_Book
    Public Picture As String
    Public Title As String
    Private Author As String
    Private ISBN_No As String
    Private Year_Published As String
    Private Code_No As String
    Private Category As String
    Private Shelve_No As String

    Public Sub Set_Data(pic, title, author, isbn_no, yearpub, code_no, category, shelve_no)
        Me.Picture = pic
        Me.Title = title
        Me.Author = author
        Me.ISBN_No = isbn_no
        Me.Year_Published = yearpub
        Me.Code_No = code_no
        Me.Category = category
        Me.Shelve_No = shelve_no


        PicBox_Cover.Image = Image.FromFile(pic)
        Lbl_Title.Text = title
    End Sub

    Private Sub Items_Click(sender As Object, e As EventArgs) Handles PicBox_Cover.Click, Lbl_Title.Click
        Form_Borrow.Set_Content(Me, Picture, Title, Author, ISBN_No, Year_Published, Code_No, Category, Shelve_No)
        Form_Borrow.ShowDialog()
    End Sub


    'GUI DESIGN - NO NEED TO TOUCH
    Private Sub Cover_MouseEnter(sender As Object, e As EventArgs) Handles PicBox_Cover.MouseEnter
        PicBox_Cover.Size = New Size(100, 100)
        PicBox_Cover.Location = New Point(24, 3)
    End Sub

    Private Sub Cover_MouseLeave(sender As Object, e As EventArgs) Handles PicBox_Cover.MouseLeave
        PicBox_Cover.Size = New Size(90, 90)
        PicBox_Cover.Location = New Point(30, 13)
    End Sub

    Private Sub Lbl_Title_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Title.MouseEnter
        Lbl_Title.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Lbl_Title_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Title.MouseLeave
        Lbl_Title.ForeColor = Color.White
    End Sub


End Class

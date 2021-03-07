Public Class UC_Book
    Private Title As String
    Private Author As String
    Private ISBN_No As String
    Private Year_Published As String
    Private Code_No As String
    Private Category As String
    Private Shelve_No As String

    Private Sub UC_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Title = "Insert Title"
        Me.Author = "Insert Author"
        Me.ISBN_No = "Insert ISBN No"
        Me.Year_Published = "Insert Year Published"
        Me.Code_No = "Insert Code No"
        Me.Category = "Insert Category"
        Me.Shelve_No = "Insert Shelve No"
    End Sub

    Private Sub Items_Click(sender As Object, e As EventArgs) Handles PicBox_Cover.Click, Lbl_Title.Click
        'Form_Borrow.Set_Content(Title, Author, ISBN_No, Year_Published, Code_No, Category, Shelve_No)
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

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class

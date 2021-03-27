
Public Class Form_CheckOut
    Public Sub Add_Book(book)
        UserControl_BookShelf.Add_Book(book)
    End Sub

    Public Sub Remove_Book(book)
        UserControl_BookShelf.Remove_Book(book)
    End Sub

    Private Sub Form_CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserControl_BookShelf.Set_Panel_Color(Color.FromArgb(19, 97, 170))
    End Sub

    Private Sub Btn_CheckOut_Click(sender As Object, e As EventArgs) Handles Btn_CheckOut.Click
        Me.Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.UserControl_BookShelf.Clear_Books()
        Me.Close()
    End Sub

    Private Sub Btn_QRReader_Click(sender As Object, e As EventArgs) Handles Btn_QRReader.Click
        Form_QRReader.ShowDialog()
    End Sub
End Class
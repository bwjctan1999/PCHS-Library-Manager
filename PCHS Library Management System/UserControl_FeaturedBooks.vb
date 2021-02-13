Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.VisualBasic.ApplicationServices

Public Class UserControl_FeaturedBooks


    Private Sub Change_Size(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim picboxes = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5}
        Dim labels = New Label() {Label1, Label2, Label3, Label4, Label5}

        Dim divide = Me.Width / 5

        'Arranges The Books
        Dim start = divide
        For i As Integer = 0 To picboxes.Length - 1
            Dim picWidth = start - (divide / 2) - (PictureBox1.Width / 2)
            Dim labWidth = start - (divide / 2) - (Label1.Width / 2)
            picboxes(i).Location = New Point(picWidth, picboxes(i).Location.Y)
            labels(i).Location = New Point(labWidth, labels(i).Location.Y)
            start += divide
        Next
    End Sub
End Class

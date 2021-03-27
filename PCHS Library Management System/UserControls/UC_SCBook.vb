Public Class UC_SCBook
    Dim mode As String

    Private Sub UC_SCBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check_State()
    End Sub

    Public Sub Check_State()
        If Lbl_Title.Text = "Add Book" Then
            Lbl_Plus.Show()
            mode = "Add"
        Else
            Lbl_Plus.Hide()
            mode = "Change"
        End If
    End Sub

    'GUI DESIGN - NO NEED TO TOUCH
    Private Sub BookAdder_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Plus.MouseEnter
        If mode = "Add" Then
            Lbl_Plus.Font = New Font("Microsoft Sans Serif", 38, FontStyle.Regular)
            Lbl_Plus.Text = "+"
        ElseIf mode = "Change" Then
            Lbl_Plus.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            Lbl_Plus.Text = "Change"
        End If
    End Sub

    Private Sub BookAdder_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Plus.MouseLeave
        If mode = "Add" Then
            Lbl_Plus.Font = New Font("Microsoft Sans Serif", 28, FontStyle.Regular)
            Lbl_Plus.ForeColor = Color.White
        ElseIf mode = "Change" Then
            Lbl_Plus.Hide()
        End If
    End Sub

    Private Sub Lbl_Title_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Title.MouseEnter
        Lbl_Title.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Lbl_Title_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Title.MouseLeave
        Lbl_Title.ForeColor = Color.White
    End Sub

    Private Sub BookCover_MouseEnter(sender As Object, e As EventArgs) Handles BookCover.MouseEnter
        Lbl_Plus.Show()
    End Sub
End Class

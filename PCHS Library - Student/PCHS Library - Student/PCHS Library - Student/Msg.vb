Public Class Msg

    Private Function Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        Return DialogResult.OK
    End Function

    Private Function Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Return DialogResult.Cancel
    End Function

    Public Sub SetContent(header As String, paragraph As String)
        Me.Size = New Size(305, 189)
        Lbl_Header.Size = New Size(265, 20)
        Lbl_Paragraph.Size = New Size(12, 44)

        Lbl_Header.Text = header
        Lbl_Paragraph.Text = paragraph
    End Sub

    Private Sub Msg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Lbl_Paragraph.Height > 50 Then
            Me.Height += 60
        End If
    End Sub
End Class
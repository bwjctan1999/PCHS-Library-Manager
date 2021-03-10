Public Class UC_Inventory
    Public Sub Load_Data()
        UserControl_DataViewer.Load_DataViewer("Inventory", Me)
    End Sub

    Public Sub Double_Click_Event()
        Dim FormBook As New Form_Add_Edit_Book

        If UserControl_DataViewer.Get_Selected().count = 0 Then
            MsgBox("Select Book/s")
        Else
            FormBook.Start("Update", UserControl_DataViewer.Get_Selected())
            FormBook.ShowDialog()
        End If
    End Sub

    'CONTROL FUNCTIONS ============================================================================================
    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        Dim FormBook As New Form_Add_Edit_Book
        FormBook.Start("Add", "none")
        FormBook.ShowDialog()
    End Sub

    Private Sub Btn_UpdateBook_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBook.Click
        Dim FormBook As New Form_Add_Edit_Book

        If UserControl_DataViewer.Get_Selected().count = 0 Then
            MsgBox("Select Book/s")
        Else
            FormBook.Start("Update", UserControl_DataViewer.Get_Selected())
            FormBook.ShowDialog()
        End If
    End Sub
End Class

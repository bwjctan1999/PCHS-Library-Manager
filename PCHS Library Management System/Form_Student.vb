Public Class Form_Student
    Private Sub Form_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Windowstate to Fullscreen'
        Me.WindowState = 2
    End Sub

    Private Sub Btn_LogIn_Click(sender As Object, e As EventArgs) Handles Btn_Admin.Click
        Me.Hide()
        Form_Login2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_CheckOut.ShowDialog()
    End Sub


    'SEARCH BAR FUNCTIONS ================================================================================================

    'Search button
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        UserControl_FeaturedBooks.Hide()
        UserControl_NewBooks.Hide()
        Lbl_BookShowcase_1.Hide()
        Lbl_BookShowcase_2.Hide()
        UserControl_DataViewer.Show()
    End Sub

    'Search Settings Button
    Private Sub Btn_SearchSettings_Click(sender As Object, e As EventArgs) Handles Btn_SearchSettings.Click
        Select Case Cbox_SearchSettings.Visible
            Case False
                Cbox_SearchSettings.Visible = True
            Case True
                Cbox_SearchSettings.Visible = False
        End Select
    End Sub

    'Search Combobox
    Private Sub Cbox_SearchSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_SearchSettings.SelectedIndexChanged
        Select Case Cbox_SearchSettings.Text
            Case "All"
                Cbox_Categories.Hide()
            Case "Title"
                Cbox_Categories.Hide()
            Case "Author"
                Cbox_Categories.Hide()
            Case "Category"
                Cbox_Categories.Show()
        End Select
    End Sub
End Class
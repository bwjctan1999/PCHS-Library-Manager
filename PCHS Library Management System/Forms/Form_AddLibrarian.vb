Public Class Form_AddLibrarian
    Private selectedindex As Integer = 0
    Private selecteditems
    Private selectedimgs

    Public Sub Start(mode, listitems, imgs)
        Me.selecteditems = listitems
        Me.selectedimgs = imgs

        Select Case mode
            Case "Add"
                Lbl_mode.Text = "ADD LIBRARIAN"
                Btn_UpdateStaff.Hide()
                Btn_AddStaff.Show()
            Case "Update"
                Lbl_mode.Text = "EDIT LIBRARIAN  1/" & selecteditems.count
                Btn_AddStaff.Hide()
                Btn_UpdateStaff.Show()
                Load_Data(selectedindex)
        End Select
    End Sub

    Private Sub Load_Data(index As Integer)
        Panel_Image.BackgroundImage = selectedimgs(index)

        Dim fullname As String = selecteditems(index).SubItems(0).Text

        Dim first_last_name() As String = Split(fullname, ",")

        Txtbox_Fname.Text = first_last_name(1)
        Txtbox_Lname.Text = first_last_name(0)
        Txtbox_EmailAdd.Text = selecteditems(index).SubItems(3).Text
        Txtbox_HomeAdd.Text = selecteditems(index).SubItems(4).Text
        Txtbox_ContactNum.Text = selecteditems(index).SubItems(5).Text

        Select Case selecteditems(selectedindex).SubItems(1).Text
            Case "Male"
                Cbox_Gender.SelectedIndex = 0
            Case "Female"
                Cbox_Gender.SelectedIndex = 1
            Case "Other"
                Cbox_Gender.SelectedIndex = 2
        End Select

        Select Case selecteditems(selectedindex).SubItems(2).Text
            Case "Librarian"
                Cbox_Type.SelectedIndex = 0
            Case "Student Assistant"
                Cbox_Type.SelectedIndex = 1
        End Select
    End Sub


    Private Sub ImageCover_Label_Click(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
    End Sub

    'GUI DESIGN FUNCTIONS ==========================================================================================
    Private Sub Panel_Image_Cover_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Image.MouseEnter
        Lbl_ChangeImage.Visible = True
    End Sub

    Private Sub Lbl_ChangeImage_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_ChangeImage.MouseLeave
        Lbl_ChangeImage.Visible = False
    End Sub

    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddStaff.Click
        Me.Close()
    End Sub

    Private Sub Btn_UpdateStaff_Click(sender As Object, e As EventArgs) Handles Btn_UpdateStaff.Click
        If selectedindex = selecteditems.count - 1 Then
            'Insert Update Function
            Me.Close()
        Else
            'Insert Update Function
            selectedindex += 1
            Lbl_mode.Text = "EDIT LIBRARIAN  " & (selectedindex + 1) & "/" & selecteditems.count
            Load_Data(selectedindex)
        End If
    End Sub

    Private Sub Button_Cancel(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub
End Class
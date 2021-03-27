Public Class UC_Staff
    Private Sub UC_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip

        CMS.Items.Add("Update")
        CMS.Items.Add("Add")
        CMS.Items.Add("Delete")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_UpdateStaff_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_AddStaff_Click
        AddHandler CMS.Items(2).Click, AddressOf Me.Btn_DeleteStaff_Click

        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub

    Public Sub Load_Data()
        Dim database(,) As String = {{"C:\Users\Jukebox\Desktop\Images\Staff 1.jpg", "Einstein, Albert",
                                     "Male", "Librarian", "SpaceTime@gmail.com", "Ulm, Württemberg, Germany", "+63 935 166 9874"},
                                     {"C:\Users\Jukebox\Desktop\Images\Staff 2.jpg", "Newton, Isaac",
                                     "Male", "Librarian", "Gravity@gmail.com", "Woolsthorpe, Lincolnshire, England", "+63 936 125 6544"},
                                     {"C:\Users\Jukebox\Desktop\Images\Staff 3.jpg", "Curie, Maria Salomea Skłodowska",
                                     "Female", "Librarian", "Radiation@gmail.com", " Warsaw, Poland", "+63 925 564 8264"},
                                     {"C:\Users\Jukebox\Desktop\Images\Staff 4.jpg", "Turing, Alan Mathison",
                                     "Male", "Student Assistant", "FirstComputer@gmail.com", "Maida Vale, London, United Kingdom", "+63 973 163 0874"},
                                     {"C:\Users\Jukebox\Desktop\Images\Staff 5.jpg", "Tesla, Nikola",
                                     "Male", "Librarian", "AC@gmail.com", "Smiljan, Croatia", "+63 973 275 0956"}}

        UserControl_DataViewer.Load_DataViewer(database, "Staff", Me)
    End Sub

    Private Sub Update_Staff()
        Dim FormStaff As New Form_AddLibrarian

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else
            Dim images As New List(Of Image)

            For Each item In UserControl_DataViewer.Get_SelectedItems()
                images.Add(UserControl_DataViewer.Large_imgs.Images(item.ImageIndex))
            Next

            FormStaff.Start("Update", UserControl_DataViewer.Get_SelectedItems(), images)
            FormStaff.ShowDialog()
        End If
    End Sub

    Private Sub Btn_AddStaff_Click(sender As Object, e As EventArgs) Handles Btn_AddStaff.Click
        Dim FormStaff As New Form_AddLibrarian
        FormStaff.Start("Add", "none", Nothing)
        FormStaff.ShowDialog()
    End Sub

    Private Sub Btn_UpdateStaff_Click(sender As Object, e As EventArgs) Handles Btn_UpdateStaff.Click
        Update_Staff()
    End Sub

    Private Sub Btn_DeleteStaff_Click(sender As Object, e As EventArgs) Handles Btn_DeleteStaff.Click
        UserControl_DataViewer.Remove_SelectedItems()
    End Sub

    Public Sub Double_Click_Event()
        Update_Staff()
    End Sub
End Class

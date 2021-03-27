Public Class UC_Borrowed

    'Load Function
    Private Sub UC_Borrowed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip
        CMS.Items.Add("Return")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_Return_Click
        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub

    'CONTROL FUNCTIONS 
    Private Sub Btn_Return_Click(sender As Object, e As EventArgs) Handles Btn_Return.Click
        Return_Book()
    End Sub

    'Double Click Event
    Public Sub Double_Click_Event()
        Return_Book()
    End Sub

    'LOAD DATABASE FUNCTION
    Public Sub Load_Data()
        Dim database(,) As String = {{"C:\Users\Jukebox\Desktop\Images\jordan.jpg", "Jordan, Michael",
                                      "STEM 3", "The Great Gatsby, My Book Cover"},
                                      {"C:\Users\Jukebox\Desktop\Images\pippen.jpg", "Pippen, Scottie",
                                      "STEM 5", "The Boy In Winter"},
                                      {"C:\Users\Jukebox\Desktop\Images\jabbar.jpg", "Abdul-Jabbar, Kareem",
                                      "HUMMS 2", "If It Bleeds"},
                                      {"C:\Users\Jukebox\Desktop\Images\johnson.jpg", "Johnson, Earvin Magic",
                                      "ABM 2", "The Good Guy"},
                                      {"C:\Users\Jukebox\Desktop\Images\bird.jpg", "Bird, Larry",
                                      "ABM 1", "A Boy In Winter, The Good Guy"}}

        UserControl_DataViewer.Load_DataViewer(database, "Borrows", Me)
    End Sub

    'Return Book Function
    Private Sub Return_Book()
        UserControl_DataViewer.Remove_SelectedItems()
    End Sub
End Class

Public Class UC_Borrows
    Dim Parent_form As Form_Manager

    'Load Function
    Private Sub UC_Borrows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creates the Right Click Menu
        Dim CMS As New ContextMenuStrip

        'Adds The Confirm and Reject Buttons of the Menu
        CMS.Items.Add("Confirm")
        CMS.Items.Add("Reject")

        'Connects the Confirm and Reject Buttons to Btn_Confirm_Click() and Btn_Reject_Click() functions
        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_Confirm_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_Reject_Click

        'Sets the DataViewer's Right Click function to the created Right Click Menu above
        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub

    'CONTRON FUNCTIONS
    Private Sub Btn_Confirm_Click(sender As Object, e As EventArgs) Handles Btn_Confirm.Click
        Confirm_Borrow()
    End Sub

    Private Sub Btn_Reject_Click(sender As Object, e As EventArgs) Handles Btn_Reject.Click
        Reject_Borrow()
    End Sub

    Private Sub Double_Click_Event()
        Confirm_Borrow()
    End Sub

    'LOAD DATABASE FUNCTION
    Public Sub Load_Data()
        'the database to load - NEEDS CHANGING
        Dim database(,) As String = {{"C:\Users\Jukebox\Desktop\Images\Avatar.png", "Tan, Benz Walter Jacques C.",
                                      "STEM 6", "The Great Gatsby, My Book Cover"},
                                      {"C:\Users\Jukebox\Desktop\Images\Doe.jpg", "Doe, John J.",
                                      "STEM 6", "The Boy In Winter"},
                                      {"C:\Users\Jukebox\Desktop\Images\mozart.jpg", "Mozart, Wolfgang Amadeus",
                                      "HUMMS 2", "If It Bleeds"},
                                      {"C:\Users\Jukebox\Desktop\Images\bach.jpg", "Bach, Johann Sebastian",
                                      "STEM 6", "The Good Guy"},
                                      {"C:\Users\Jukebox\Desktop\Images\chopin.jpg", "Chopin, Frederic Francois ",
                                      "STEM 6", "A Boy In Winter, The Good Guy"}}

        'Tells the DataViewer what to load, what type of data to load, and what is its parent form
        UserControl_DataViewer.Load_DataViewer(database, "Borrows", Me)
    End Sub

    Public Sub Set_Parent_Form(pform)
        Me.Parent_form = pform
    End Sub

    'Confirm Book Borrow Function
    Private Sub Confirm_Borrow()
        For Each item In UserControl_DataViewer.Get_SelectedItems()
            Parent_form.UserControl_Borrowed.UserControl_DataViewer.Add_Item(item, UserControl_DataViewer.Large_imgs.Images(item.ImageIndex))
        Next

        UserControl_DataViewer.Remove_SelectedItems()
    End Sub

    'Reject Book Borrow Function
    Private Sub Reject_Borrow()
        UserControl_DataViewer.Remove_SelectedItems()
    End Sub

End Class

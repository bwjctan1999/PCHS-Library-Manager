Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form_Manager

    'Constructor, argument is connected to the Form_SplashScreen Subs
    Public Sub New(ss)
        ' This call is required by the designer.
        InitializeComponent()

        'Loads the database
        UserControl_Borrows.Load_Data()
        ss.UpdateStatus(25, "LOADING BORROWED DATA...")
        UserControl_Borrowed.Load_Data()
        ss.UpdateStatus(50, "LOADING INVENTORY DATA...")
        UserControl_Inventory.Load_Data()
        ss.UpdateStatus(76, "LOADING Reports DATA...")
        UserControl_Reports.Load_Data()
    End Sub

    'MAIN PANEL BUTTONS AND FUNCTIONS'

    'Logout button
    Private Sub Btn_LogOut_Click(sender As Object, e As EventArgs) Handles Btn_LogOut.Click
        Form_Login2.Show()
        Me.Close()
    End Sub

    'Book Showcase Button
    Private Sub Btn_BookShowcase_Click(sender As Object, e As EventArgs) Handles Btn_BookShowcase.Click
        Panel_Highlight.Location = New Point(-3, 13)
        Select_MainPanel_Button(Btn_BookShowcase, UserControl_ShowCase)
    End Sub

    'Borrows Button
    Private Sub Btn_Borrows_Click(sender As Object, e As EventArgs) Handles Btn_Borrows.Click
        Panel_Highlight.Location = New Point(-3, 59)
        Select_MainPanel_Button(Btn_Borrows, UserControl_Borrows)
    End Sub

    'Borrowed Button
    Private Sub Btn_Borrowed_Click(sender As Object, e As EventArgs) Handles Btn_Borrowed.Click
        Panel_Highlight.Location = New Point(-3, 105)
        Select_MainPanel_Button(Btn_Borrowed, UserControl_Borrowed)
    End Sub

    'Inventory Button
    Private Sub Btn_Inventory_Click(sender As Object, e As EventArgs) Handles Btn_Inventory.Click
        Panel_Highlight.Location = New Point(-3, 151)
        Select_MainPanel_Button(Btn_Inventory, UserControl_Inventory)
    End Sub

    'Staffs Button
    Private Sub Btn_Staffs_Click(sender As Object, e As EventArgs) Handles Btn_Staffs.Click
        Panel_Highlight.Location = New Point(-3, 197)
        Select_MainPanel_Button(Btn_Staffs, UserControl_Reports)
    End Sub

    'Suppliers Button
    Private Sub Btn_Suppliers_Click(sender As Object, e As EventArgs) Handles Btn_Suppliers.Click
        Panel_Highlight.Location = New Point(-3, 243)
        Select_MainPanel_Button(Btn_Suppliers, UserControl_Borrows)
    End Sub

    'Function for selecting a Panel Button
    Private Sub Select_MainPanel_Button(btn As Button, usercontrol As UserControl)
        Dim MainPanelBtns = New Button() {Btn_BookShowcase, Btn_Borrows, Btn_Borrowed, Btn_Inventory, Btn_Staffs, Btn_Suppliers}
        Dim usercontrols = New UserControl() {UserControl_Borrows}

        For Each button In MainPanelBtns
            button.BackColor = Color.FromArgb(0, 29, 38)
            button.ForeColor = Color.White
        Next
        btn.BackColor = Color.FromArgb(13, 42, 51)

        usercontrol.BringToFront()
    End Sub
End Class

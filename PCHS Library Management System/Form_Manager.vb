Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form_Manager

    'MAIN PANEL BUTTONS AND FUNCTIONS'

    Private Sub Btn_BookShowcase_Click(sender As Object, e As EventArgs) Handles Btn_BookShowcase.Click
        Panel_Highlight.Location = New Point(-3, 13)
        Select_MainPanel_Button(Btn_BookShowcase, UserControl_ShowCase)
    End Sub

    Private Sub Btn_Borrows_Click(sender As Object, e As EventArgs) Handles Btn_Borrows.Click
        Panel_Highlight.Location = New Point(-3, 59)
        Select_MainPanel_Button(Btn_Borrows, UserControl_Borrows)
    End Sub

    Private Sub Btn_Borrowed_Click(sender As Object, e As EventArgs) Handles Btn_Borrowed.Click
        Panel_Highlight.Location = New Point(-3, 105)
        Select_MainPanel_Button(Btn_Borrowed, UserControl_Borrowed)
    End Sub

    Private Sub Btn_Inventory_Click(sender As Object, e As EventArgs) Handles Btn_Inventory.Click
        Panel_Highlight.Location = New Point(-3, 151)
        Select_MainPanel_Button(Btn_Inventory, UserControl_Inventory)
    End Sub

    Private Sub Btn_Staffs_Click(sender As Object, e As EventArgs) Handles Btn_Staffs.Click
        Panel_Highlight.Location = New Point(-3, 197)
        Select_MainPanel_Button(Btn_Staffs, UserControl_Borrows)
    End Sub

    Private Sub Btn_Suppliers_Click(sender As Object, e As EventArgs) Handles Btn_Suppliers.Click
        Panel_Highlight.Location = New Point(-3, 243)
        Select_MainPanel_Button(Btn_Suppliers, UserControl_Borrows)
        Form_Login2.ShowDialog()
    End Sub

    Private Sub Select_MainPanel_Button(btn As Button, usercontrol As UserControl)
        Dim MainPanelBtns = New Button() {Btn_BookShowcase, Btn_Borrows, Btn_Borrowed, Btn_Inventory, Btn_Staffs, Btn_Suppliers}
        Dim usercontrols = New UserControl() {UserControl_Borrows}

        For Each button In MainPanelBtns
            button.BackColor = Color.FromArgb(30, 53, 63)
            button.ForeColor = Color.White
        Next
        btn.BackColor = Color.FromArgb(30, 43, 53)

        usercontrol.BringToFront()
    End Sub

End Class

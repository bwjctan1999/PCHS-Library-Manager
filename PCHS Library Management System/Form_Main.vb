Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form_Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Windowstate to Fullscreen'
        Me.WindowState = 2
    End Sub

    'MAIN PANEL BUTTONS AND FUNCTIONS'

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Select_MainPanel_Button(Btn_Search, UC_Books)
    End Sub

    Private Sub Btn_Books_Click(sender As Object, e As EventArgs) Handles Btn_Books.Click
        Select_MainPanel_Button(Btn_Books, UC_Books)
        UC_Books.Show()
    End Sub

    Private Sub Btn_Inventory_Click(sender As Object, e As EventArgs) Handles Btn_Inventory.Click
        Select_MainPanel_Button(Btn_Inventory, UC_Books)
    End Sub

    Private Sub Btn_Students_Click(sender As Object, e As EventArgs) Handles Btn_Students.Click
        Select_MainPanel_Button(Btn_Students, UC_Books)
    End Sub

    Private Sub Btn_Staffs_Click(sender As Object, e As EventArgs) Handles Btn_Staffs.Click
        Select_MainPanel_Button(Btn_Staffs, UC_Books)
    End Sub

    Private Sub Btn_Suppliers_Click(sender As Object, e As EventArgs) Handles Btn_Suppliers.Click
        Select_MainPanel_Button(Btn_Suppliers, UC_Books)
        Form_Login2.ShowDialog()
    End Sub

    Private Sub Select_MainPanel_Button(btn As Button, usercontrol As UserControl)
        Dim MainPanelBtns = New Button() {Btn_Search, Btn_Books, Btn_Inventory, Btn_Students, Btn_Staffs, Btn_Suppliers}
        Dim usercontrols = New UserControl() {UC_Books}

        For Each button In MainPanelBtns
            button.BackColor = Color.FromArgb(30, 53, 63)
            button.ForeColor = Color.White
        Next
        btn.BackColor = Color.FromArgb(30, 43, 53)

        usercontrol.BringToFront()
    End Sub
End Class

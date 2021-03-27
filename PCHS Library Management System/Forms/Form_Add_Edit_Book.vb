Imports System.Text
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode.Internal
Imports ZXing.Rendering

Public Class Form_Add_Edit_Book
    Private selectedindex As Integer = 0
    Private selecteditems
    Private selectedimgs

    Public Sub Start(mode, listitems, imgs)
        Me.selecteditems = listitems
        Me.selectedimgs = imgs

        Select Case mode
            Case "Add"
                Lbl_mode.Text = "ADD BOOK"
                Btn_UpdateBook.Hide()
                Btn_AddBook.Show()

            Case "Update"
                Lbl_mode.Text = "EDIT BOOK  1/" & selecteditems.count
                Btn_AddBook.Hide()
                Btn_UpdateBook.Show()
                Load_Data(selectedindex)
        End Select
    End Sub

    Private Sub Load_Data(index As Integer)
        Panel_Image.BackgroundImage = selectedimgs(index)
        Txtbox_Title.Text = selecteditems(index).SubItems(0).Text
        Txtbox_Author.Text = selecteditems(index).SubItems(1).Text
        Txtbox_ISBNNo.Text = selecteditems(index).SubItems(2).Text
        Txtbox_PubDate.Text = selecteditems(index).SubItems(3).Text
        Txtbox_Quantity.Text = selecteditems(index).SubItems(4).Text 'FIX THIS: replace with quantity value
        Txtbox_CodeNo.Text = selecteditems(index).SubItems(4).Text
        Txtbox_ShelfNo.Text = selecteditems(index).SubItems(6).Text

        Select Case selecteditems(selectedindex).SubItems(5).Text
            Case "Computer science, information & general works"
                Cbox_Category.SelectedIndex = 0
            Case "Philosophy & psychology"
                Cbox_Category.SelectedIndex = 1
            Case "Religion"
                Cbox_Category.SelectedIndex = 2
            Case "Social sciences"
                Cbox_Category.SelectedIndex = 3
            Case "Language"
                Cbox_Category.SelectedIndex = 4
            Case "Pure Science"
                Cbox_Category.SelectedIndex = 5
            Case "Technology"
                Cbox_Category.SelectedIndex = 6
            Case "Arts & recreation"
                Cbox_Category.SelectedIndex = 7
            Case "Literature"
                Cbox_Category.SelectedIndex = 8
            Case "History & geography"
                Cbox_Category.SelectedIndex = 9
        End Select
    End Sub

    'CONTROL FUNCTIONS ===========================================================================================
    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_AddBook.Click
        Me.Close()
    End Sub

    Private Sub Btn_UpdateBook_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBook.Click
        If selectedindex = selecteditems.count - 1 Then
            'Insert Update Function
            Me.Close()
        Else
            'Insert Update Function
            selectedindex += 1
            Lbl_mode.Text = "EDIT BOOK  " & (selectedindex + 1) & "/" & selecteditems.count
            Load_Data(selectedindex)
        End If
    End Sub

    Private Sub Button_Cancel(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Txtbox_Title_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Title.TextChanged
        If Txtbox_Title.Text <> "" Then
            Dim barcodeWriter As New BarcodeWriter
            Dim encodingOptions As New EncodingOptions
            encodingOptions.Width = 100
            encodingOptions.Height = 100
            encodingOptions.Margin = 0
            encodingOptions.PureBarcode = False
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H)
            barcodeWriter.Renderer = New BitmapRenderer
            barcodeWriter.Options = encodingOptions
            barcodeWriter.Format = BarcodeFormat.QR_CODE
            Dim bitmap = barcodeWriter.Write(Txtbox_Title.Text)
            Dim g As Graphics = Graphics.FromImage(bitmap)
            Picbox_QRCode.Image = bitmap
        Else
            Picbox_QRCode.Image = Nothing
        End If
    End Sub
End Class

Imports System.Text
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode.Internal
Imports ZXing.Rendering
Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class Form_QRReader
    Dim filterInfoCollection As FilterInfoCollection
    Dim captureDevice As VideoCaptureDevice

    Private Sub Form_QRReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cbox_Cameras.Items.Clear()
        filterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each filterInfo In filterInfoCollection
            Cbox_Cameras.Items.Add(filterInfo.Name)
        Next

        Cbox_Cameras.SelectedIndex = 0
    End Sub

    Private Sub Cbox_Cameras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_Cameras.SelectedIndexChanged
        captureDevice = New VideoCaptureDevice(filterInfoCollection(Cbox_Cameras.SelectedIndex).MonikerString)

        'captureDevice.VideoResolution = selectResolution(captureDevice)

        AddHandler captureDevice.NewFrame, AddressOf CaptureDevice_NewFrame
        captureDevice.Start()
        Timer_QR.Start()
    End Sub

    'Private Function selectResolution(device As VideoCaptureDevice)
    '    For Each cap In device.VideoCapabilities
    '        If cap.FrameSize.Height = 50 Then
    '            Return cap
    '        End If

    '        If cap.FrameSize.Width = 50 Then
    '            Return cap
    '        End If

    '    Next

    '    Return device.VideoCapabilities.Last()
    'End Function

    Private Sub CaptureDevice_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        Picbox_Display.Image = eventArgs.Frame.Clone
    End Sub

    Private Sub Me_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        If captureDevice.IsRunning Then
            captureDevice.Stop()
        End If
    End Sub

    Private Sub Timer_QR_Tick(sender As Object, e As EventArgs) Handles Timer_QR.Tick
        If Picbox_Display.Image IsNot Nothing Then
            Dim barcodeReader As New BarcodeReader
            Dim result = barcodeReader.Decode(New Bitmap(Picbox_Display.Image))

            If result IsNot Nothing Then
                RichTextBox1.Text = result.ToString
                'Timer_QR.Stop()

                'If captureDevice.IsRunning Then
                '    captureDevice.Stop()
                'End If
            End If
        End If
    End Sub
End Class
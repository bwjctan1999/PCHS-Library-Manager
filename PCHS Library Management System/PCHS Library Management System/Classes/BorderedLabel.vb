Imports System.Drawing.Drawing2D

Public Class BorderedLabel
    Inherits Label
    Public outline_color As Color = Color.Black
    Public border_thickness As Integer = 5
    Public Sub New()
        MyBase.New

    End Sub


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.FillRectangle(New SolidBrush(BackColor), ClientRectangle)
        Dim gp As GraphicsPath = New GraphicsPath
        Dim outline As Pen = New Pen(Me.outline_color, Me.border_thickness)
        Dim sf As StringFormat = New StringFormat
        Dim foreBrush As Brush = New SolidBrush(ForeColor)
        gp.AddString(Text, Font.FontFamily, CType(Font.Style, Integer), Font.Size, ClientRectangle, sf)
        e.Graphics.ScaleTransform(1.3!, 1.35!)
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        e.Graphics.DrawPath(outline, gp)
        e.Graphics.FillPath(foreBrush, gp)
    End Sub
End Class
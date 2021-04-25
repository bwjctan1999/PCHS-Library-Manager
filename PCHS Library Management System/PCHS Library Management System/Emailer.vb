Imports System.Net.Mail

Public Class Emailer
    Dim sendToAddress As String
    Dim message As String

    Public Sub SendEmail()
        Dim EmailMSG As New MailMessage()

        Try
            EmailMSG.From = New MailAddress(My.Settings.EmailerAddress)
            EmailMSG.To.Add(sendToAddress)
            EmailMSG.Subject = "PCHS Library: Forgotten Password"

            EmailMSG.Body = message


            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(My.Settings.EmailerAddress, My.Settings.EmailerPassword)
            SMTP.Send(EmailMSG)
        Catch ex As Exception
            MsgBox("Emailing Failed, Email not sent.")
        End Try
    End Sub

    Public Sub SetSendtoInfo(address, message)
        Me.sendToAddress = address
        Me.message = message
    End Sub
End Class

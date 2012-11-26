Imports System.Net.Mail
Imports System.Net.Mime

Public Class h_mail

    Private Sub bt_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_send.Click
        sendmail()

    End Sub

    Private Sub sendmail()
        Dim strFrom As String = txtFrom.Text
        Dim strTo As String = txtTo.Text
        Dim strSubject As String = txtSubject.Text
        Dim strData As String = txtData.Text

        Dim kc_smtp As New SmtpClient("smtp.139.com", 25)


        Try
            Dim kc_mailbody As New MailMessage(strFrom, strTo, strSubject, strData)
            kc_mailbody.ReplyTo = New MailAddress("knightc@139.com")
            kc_mailbody.Bcc.Add(New MailAddress("knightc@139.com"))
            '
            'txtData.Text = ofdialog.FileName

            kc_mailbody.Attachments.Add(New Attachment(ofdialog.FileName, MediaTypeNames.Text.Plain))




            kc_smtp.Send(kc_mailbody)
            MessageBox.Show("邮件发送完毕")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub bt_attachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_attachment.Click
        If ofdialog.ShowDialog = DialogResult.OK Then
            txt_attachment.Text = ofdialog.FileName
        End If
    End Sub
End Class
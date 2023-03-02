Imports System.Net
Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Appeared As Boolean = False
        If Not Appeared Then
            Opacity += 0.1
            If Opacity >= 1.0 Then
                Appeared = True
                Timer1.Interval = 10000
            End If
        End If
        If Appeared Then
            System.Threading.Thread.Sleep(100)
            Dim req As System.Net.WebRequest
            Dim res As System.Net.WebResponse

            req = System.Net.WebRequest.Create("https://www.facebook.com/")
            req.Proxy = Nothing
            Timer1.Stop()
            Try
                res = req.GetResponse()


                Login.Show()
                Me.Close()
            Catch ex As WebException
                MsgBox("There was a problem with connecting to the server")
                Form1.Close()
                Close()
            End Try

            Me.Close()
        End If

    End Sub
End Class
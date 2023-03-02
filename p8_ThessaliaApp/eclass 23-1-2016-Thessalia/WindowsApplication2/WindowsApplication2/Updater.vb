Public Class Updater
 
    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.dropbox.com/s/vc3mglzw0cstu8z/Version.txt?dl=1")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Button1.Text = ("You are up todate!")
                Label8.ForeColor = Color.LimeGreen
                Label8.Text = ("You are up to date!")
            Else
                Label8.ForeColor = Color.LimeGreen
                Label8.Text = ("Update found!")
                Label11.Text = newestversion
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Text = "Checking for updates..."
        Timer1.Start()

        Try
            CheckForUpdates()

        Catch ex As Exception
            MessageBox.Show("There was a error with loading the page/logging in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Button1.Text = ("Ευρεση Ενημέρωσης")
    End Sub

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = Application.ProductVersion




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        Label8.Visible = True
        Label10.Visible = False
        Label8.Text = ProgressBar1.Value & "%" & " checked."
        PictureBox1.Width = CInt(ProgressBar1.Value * 2.82)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            CheckForUpdates()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label8.Text = "Update found!" Then
            MessageBox.Show("Download Update..", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("No available Updates!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.BringToFront()
    End Sub
End Class
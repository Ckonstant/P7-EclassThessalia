Public Class Login
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Σύνδεση..."
        If ElegantThemeCheckBox1.Checked = True Then
            My.Settings.myUser = ElegantThemeTextBox1.Text
            My.Settings.Save()

        End If


        Try


            Form1.WebBrowser1.Document.GetElementById("login_username").SetAttribute("value", ElegantThemeTextBox1.Text)
            Form1.WebBrowser1.Document.GetElementById("login_password").SetAttribute("value", ElegantThemeTextBox2.Text)


            Dim Submit As HtmlElement = Nothing
            For Each Elem As HtmlElement In Form1.WebBrowser1.Document.All
                If Elem.GetAttribute("type") = "submit" Then
                    Submit = Elem
                End If
            Next


            Submit.InvokeMember("Click")
            WaitForPageLoad()
            If Form1.WebBrowser1.DocumentText.Contains("Έχετε εισέλθει ως") Then
                Me.Hide()
                Form1.Show()

            Else
                Me.Hide()
                Form1.Show()
                MsgBox("You put wrong username/password combination.Try again!")

            End If


        Catch ex As Exception

            MessageBox.Show("There was a error with loading the page/logging in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Form1.WebBrowser1.Navigate("http://ecourse.uoi.gr/")
        WaitForPageLoad()
        ElegantThemeTextBox1.Text = My.Settings.myUser


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)





    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
       
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub ElegantThemeTextBox1_Click(sender As Object, e As EventArgs) Handles ElegantThemeTextBox1.Click
        ElegantThemeTextBox1.Text = ""
    End Sub

    Private Sub ElegantThemeTextBox2_Click(sender As Object, e As EventArgs) Handles ElegantThemeTextBox2.Click
        ElegantThemeTextBox2.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If ElegantThemeTextBox2.UseSystemPasswordChar = False Then
            ElegantThemeTextBox2.UseSystemPasswordChar = True
        Else
            ElegantThemeTextBox2.UseSystemPasswordChar = False
        End If
    End Sub

   
    Private Sub ElegantThemeCheckBox1_CheckedChanged(sender As Object) Handles ElegantThemeCheckBox1.CheckedChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        grades.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress As String = "http://ecourse.uoi.gr/"
        Process.Start(webAddress)
    End Sub
End Class
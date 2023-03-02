Public Class grades
    Private Property pageready As Boolean = False

#Region "Page Loading Functions"
    Private Sub WaitForPageLoad()
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region
    Private Sub grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim greeting As String = My.Settings.mySetting
        TextBox1.Text = greeting


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Σύνδεση..."



        Try


            WebBrowser1.Document.GetElementById("userName").SetAttribute("value", TextBox1.Text)
            WebBrowser1.Document.GetElementById("pwd").SetAttribute("value", TextBox2.Text)


            Dim Submit As HtmlElement = Nothing
            For Each Elem As HtmlElement In WebBrowser1.Document.All
                If Elem.GetAttribute("type") = "submit1" Then
                    Submit = Elem
                End If
            Next


            Submit.InvokeMember("Click")
            WaitForPageLoad()
            If WebBrowser1.Document.Body.InnerText.Contains("Αποσύνδεση") Then
                MsgBox("Good job")
            Else

                MsgBox("You put wrong username/password combination.Try again!")

            End If


        Catch ex As Exception

            MessageBox.Show("There was a error with loading the page/logging in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If WebBrowser1.Document.Body.InnerText.Contains("Αποσύνδεση") Then
            Dim Submit1 As HtmlElement = Nothing
            For Each Elem As HtmlElement In WebBrowser1.Document.All
                If Elem.GetAttribute("id") = "mnu3" Then
                    Submit1 = Elem
                End If
            Next


            Submit1.InvokeMember("Click")
            WaitForPageLoad()
            WebBrowser1.Document.GetElementById("main").ScrollIntoView(True)
            Dim ele = WebBrowser1.Document.GetElementById("menuTable")

            If ele IsNot Nothing Then
                ele.Style = "Display:none"
            End If
        Else
            MsgBox("we facked")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate("https://cronos.cc.uoi.gr/unistudent/")
        WaitForPageLoad()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Submit As HtmlElement = Nothing
        For Each Elem As HtmlElement In WebBrowser1.Document.All
            If Elem.GetAttribute("id") = "mnu3" Then
                Submit = Elem
            End If
        Next


        Submit.InvokeMember("Click")
        WaitForPageLoad()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Document.GetElementById("main").ScrollIntoView(True)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ele = WebBrowser1.Document.GetElementById("menuTable")

        If ele IsNot Nothing Then
            ele.Style = "Display:none"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.mySetting = TextBox1.Text
        My.Settings.Save()
        TextBox3.Text = My.Settings.mySetting

    End Sub
End Class

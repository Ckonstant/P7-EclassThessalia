Public Class Form3
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
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.WebBrowser1.Navigate("http://ecourse.uoi.gr/course/view.php?id=1536")
        WaitForPageLoad()
        For Each elem As HtmlElement In Form1.WebBrowser1.Document.All
            If elem.GetAttribute("href").Contains("resource") Then
                ListBox2.Items.Add(elem.GetAttribute("href"))

                ListBox1.Items.Add(elem.GetAttribute("innerText"))


            End If
        Next

        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).ToString.Contains("Πηγή πληροφοριών") Then
                ListBox1.Items(i) = ListBox1.Items(i).ToString.Replace("Πηγή πληροφοριών", "")
            End If
        Next
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).ToString.Contains("L") Then
                ListBox1.Items(i) = ListBox1.Items(i).ToString.Replace("L", "Εργαστήριο:").ToUpper
            End If
        Next


        For i = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.Items(i).ToString().Trim.Length = 0 Then
                ListBox1.Items.RemoveAt(i)
                ListBox2.Items.RemoveAt(i)
            End If
        Next


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub ListBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ΚατέβασμαΑρχείουToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΚατέβασμαΑρχείουToolStripMenuItem.Click

    End Sub

   


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListBox1.SelectedItem <> "") Then
            ListBox2.SetSelected(ListBox1.SelectedIndex, True)
            MessageBox.Show("Επιλέξατε: " & ListBox1.SelectedItem, "Eclass", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.WebBrowser1.Navigate(ListBox2.SelectedItem)
        Else
            MessageBox.Show("You must select an item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        If ListBox1.SelectedItem = "Codes" Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            Dim userLink As String = ("http://eclass.uth.gr/eclass/modules/document/index.php?course=INFS122&openDir=/54f83a95sJs2")

            For Each link As HtmlElement In Form1.WebBrowser1.Document.Links

                If link.GetAttribute("href") = userLink Then
                    link.InvokeMember("click")
                    Exit For
                End If

            Next
            Me.WaitForPageLoad()





            For Each link As HtmlElement In Form1.WebBrowser1.Document.Links


                ListBox1.Items.Add(link.GetAttribute("title"))
                ListBox2.Items.Add(link.GetAttribute("href"))



            Next
            For i = ListBox1.Items.Count - 1 To 0 Step -1
                If ListBox1.Items(i).ToString().Trim.Length = 0 Then
                    ListBox1.Items.RemoveAt(i)
                    ListBox2.Items.RemoveAt(i)
                End If
            Next
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
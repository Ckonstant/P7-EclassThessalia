Imports System.Net

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Dim websiteAlreadyAccessed = False
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)



    End Sub


    Private Property pageready As Boolean = False
    Dim a As Integer
    Private Sub RunNews()
        WebBrowser2.Navigate("http://cs.uoi.gr/index.php?menu=m5")
        WaitForPageLoad2()
        Dim PageElement As HtmlElementCollection = WebBrowser2.Document.GetElementsByTagName("div")
        For Each CurElement As HtmlElement In PageElement
            'ListBox1.Items.Add(CurElement.GetAttribute("className").ToString())


            If CurElement.OuterHtml.Contains("newPaging") Then ' Here is a workaround.
                ListBox1.Items.Add(CurElement.GetAttribute("InnerText"))
            End If
        Next
        For k = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(k).ToString.Contains("ΝΕΑ / ΑΝΑΚΟΙΝΩΣΕΙΣ") Then
                ListBox1.Items(k) = ListBox1.Items(k).ToString.Replace("ΝΕΑ / ΑΝΑΚΟΙΝΩΣΕΙΣ", "")
            End If
        Next
        For Each elem As HtmlElement In WebBrowser2.Document.All
            If elem.GetAttribute("href").Contains("menu=m58") Then
                ListBox2.Items.Add(elem.GetAttribute("href"))



            End If
        Next

        a = ListBox1.Items.Count
        Timer1.Start()
    End Sub
#Region "Page Loading Functions 2"
    Private Sub WaitForPageLoad2()
        AddHandler WebBrowser2.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter2(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser2.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowser2.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region
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

    Private Sub Form1_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Class MyRenderer : Inherits ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)

            If e.Item.Selected Then
                Using br = New SolidBrush(Color.FromArgb(27, 27, 28))
                    Using hi = New Pen(Color.FromArgb(45, 45, 48))

                        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                        'Set the highlight color
                        e.Graphics.FillRectangle(br, rc)
                        e.Graphics.DrawRectangle(hi, 1, 0, rc.Width - 2, rc.Height - 1)
                    End Using
                End Using
            Else
                Using br = New SolidBrush(Color.FromArgb(45, 45, 48))
                    Using hi = New Pen(Color.FromArgb(45, 45, 48))
                        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
                        'Set the default color
                        e.Graphics.FillRectangle(br, rc)
                        e.Graphics.DrawRectangle(hi, 1, 0, rc.Width - 2, rc.Height - 1)
                    End Using
                End Using
            End If
        End Sub

    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New MyRenderer
        RunNews()








    End Sub






    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub












    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        about.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        WebBrowser1.Navigate("http://eclass.uth.gr/eclass/index.php?logout=yes")
        Me.Close()
        Login.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub ΕπικοινωνίαToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΕπικοινωνίαToolStripMenuItem.Click

    End Sub

    Private Sub NewConnecyionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub LinkLabel3_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Dim i As Integer = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If a = i Then
            i = 1
        End If

        Label1.Text = ListBox1.Items(i)
        ListBox1.SetSelected(i, True)
        Label1.Left -= 2
        If Label1.Left < 0 - Label1.Size.Width Then
            Label1.Left = 575
            i = i + 1

        End If



    End Sub




    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ΈξοδοςToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub



    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub HelloThereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelloThereToolStripMenuItem.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ΕνημερώσειςToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ΑυτόματαToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim oForm As Updater
        oForm = New Updater()
        oForm.Show()
    End Sub

    Private Sub ΔοκιμήΣύνδεσηςToolStripMenuItem_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AboutEclassApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutEclassApplicationToolStripMenuItem.Click
        Me.Hide()
        about.Show()
    End Sub

    Private Sub ΕνημερώσειςToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ΕνημερώσειςToolStripMenuItem.Click
        Updater.Show()
    End Sub

    Private Sub ΜεΜαθητέςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΜεΜαθητέςToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ElegantThemeButton1_Click(sender As Object, e As EventArgs)
        Main.Show()
        Me.Hide()
    End Sub




    Private Sub Button1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs)

    End Sub

    



    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub



   

    Private Sub ElegantThemeButton5_Click(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub ElegantThemeButton1_Click_1(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("http://cs.uoi.gr/index.php?menu=m5")
        WaitForPageLoad()
        Dim PageElement As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("div")
        For Each CurElement As HtmlElement In PageElement
            'ListBox1.Items.Add(CurElement.GetAttribute("className").ToString())


            If CurElement.OuterHtml.Contains("newPaging") Then ' Here is a workaround.
                ListBox1.Items.Add(CurElement.GetAttribute("InnerText"))
            End If
        Next
        For k = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(k).ToString.Contains("ΝΕΑ / ΑΝΑΚΟΙΝΩΣΕΙΣ") Then
                ListBox1.Items(k) = ListBox1.Items(k).ToString.Replace("ΝΕΑ / ΑΝΑΚΟΙΝΩΣΕΙΣ", "")
            End If
        Next
        a = ListBox1.Items.Count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ElegantThemeStatusBar1.SecondLabelText = DateTime.Now.ToString
        ElegantThemeStatusBar1.Refresh()
    End Sub





    Private Sub ElegantThemeStatusBar1_Click(sender As Object, e As EventArgs) Handles ElegantThemeStatusBar1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        If (ListBox1.SelectedItem <> "") Then
            ListBox2.SetSelected(ListBox1.SelectedIndex - 1, True)
            MessageBox.Show("You selected: " & ListBox1.SelectedItem, "E-course", MessageBoxButtons.OK, MessageBoxIcon.Information)
            WebBrowser1.Navigate(ListBox2.SelectedItem)
            WaitForPageLoad()
            For Each elem As HtmlElement In WebBrowser1.Document.All
                If elem.GetAttribute("href").Contains("upFiles") Then
                    Label3.Text = (elem.GetAttribute("href"))



                End If
            Next
            WebBrowser1.Navigate(Label3.Text)
        Else
            MessageBox.Show("You must select an item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




    

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub LogInGroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ΣύνδεσηEcourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΣύνδεσηEcourseToolStripMenuItem.Click
        cronos.Show()
        Me.Hide()

    End Sub

    Private Sub CronosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CronosToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub ΕξήγησηΠρογράμματοςToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
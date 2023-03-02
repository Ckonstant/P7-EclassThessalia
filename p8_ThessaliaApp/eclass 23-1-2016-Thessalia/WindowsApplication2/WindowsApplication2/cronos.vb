Public Class cronos

    Private Sub Button1_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub cronos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub ElegantThemeComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ElegantThemeComboBox1.SelectedItem = "p" Then
            ElegantThemeStatusBar1.SecondLabelText = "Επιλεγμένο: Ανάλυση Ι"
            ElegantThemeStatusBar1.Refresh()



        End If
    End Sub

    Private Sub onoff1_ToggleChanged(sender As Object) Handles onoff1.ToggleChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ElegantThemeStatusBar1.FirstLabelText = DateTime.Now.ToString
        ElegantThemeStatusBar1.Refresh()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ElegantThemeComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElegantThemeComboBox3.SelectedIndexChanged
        If ElegantThemeComboBox3.SelectedItem = "2ο Ετος" Then

        End If
    End Sub
End Class
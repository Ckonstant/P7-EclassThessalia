Public Class Form6

    Private Sub ElegantThemeComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ElegantThemeComboBox1.SelectedIndexChanged
        If ElegantThemeComboBox1.SelectedItem = "p" Then
            ElegantThemeStatusBar1.SecondLabelText = "Επιλεγμένο: Ανάλυση Ι"
            ElegantThemeStatusBar1.Refresh()



        End If
    End Sub

    Private Sub ElegantThemeButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeGroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeLabel1_Click(sender As Object, e As EventArgs) Handles ElegantThemeLabel1.Click

    End Sub

    Private Sub ElegantThemeLabel2_Click(sender As Object, e As EventArgs) Handles ElegantThemeLabel2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ElegantThemeButton1_Click(sender As Object, e As EventArgs) Handles ElegantThemeButton1.Click

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub ElegantThemeComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElegantThemeComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ElegantThemeStatusBar1_Click(sender As Object, e As EventArgs) Handles ElegantThemeStatusBar1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ElegantThemeContainer1_Click(sender As Object, e As EventArgs) Handles ElegantThemeContainer1.Click

    End Sub

    Private Sub ElegantThemeTabControlVertical1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElegantThemeTabControlVertical1.SelectedIndexChanged

    End Sub

    Private Sub ElegantThemeButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub onoff1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles onoff1.MouseDoubleClick

    End Sub

    Private Sub onoff1_MouseDown(sender As Object, e As MouseEventArgs) Handles onoff1.MouseDown
        If Not onoff1.Toggled = False Then
            ElegantThemeComboBox1.Visible = False
            ElegantThemeComboBox2.Visible = True
            Label1.Text = "Εαρινο"
        ElseIf onoff1.Toggled = False Then
            Label1.Text = "Χειμερινο"
            ElegantThemeComboBox1.Visible = True
            ElegantThemeComboBox2.Visible = False


        End If
    End Sub


    Private Sub onoff1_ToggleChanged(sender As Object) Handles onoff1.ToggleChanged

    End Sub




    Private Sub ElegantThemeButton3_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub ElegantThemeOnOffSwitch1_ToggleChanged(sender As Object)

    End Sub


    Private Sub ElegantThemeOOffSwitch1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ElegantThemeOOffSwitch1_ToggledChanged(sender As Object)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ElegantThemeStatusBar1.FirstLabelText = DateTime.Now.ToString
        ElegantThemeStatusBar1.Refresh()
    End Sub




    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub ElegantThemeButton2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeButton2_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeButton2_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeButton2_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub ElegantThemeButton2_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class
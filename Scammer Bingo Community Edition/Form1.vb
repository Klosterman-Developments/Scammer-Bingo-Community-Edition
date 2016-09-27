Imports MaterialSkin

Public Class Form1
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MaterialRaisedButton1.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
        MaterialTabSelector1.SendToBack()
        MaterialCheckBox1.Visible = False
        PictureBox2.Visible = False
        MaterialFlatButton1.Text = "score 0/20"

    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub MaterialRaisedButton20_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton20.Click
        PictureBox2.BringToFront()
        PictureBox2.Visible = True
        MaterialCheckBox1.BringToFront()
        MaterialCheckBox1.Visible = True

    End Sub

    Private Sub MaterialRaisedButton19_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton19.Click
        MaterialTabSelector1.SendToBack()
        MaterialCheckBox1.Visible = False
        PictureBox2.Visible = False

    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.CheckState = CheckState.Checked Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK

        End If
    End Sub

    Private Sub MaterialRaisedButton22_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton22.Click
        MaterialRaisedButton22.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        MaterialRaisedButton2.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton21_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton21.Click
        MaterialRaisedButton21.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        MaterialRaisedButton4.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton14_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton14.Click
        MaterialRaisedButton14.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        MaterialRaisedButton3.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton13_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton13.Click
        MaterialRaisedButton13.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        MaterialRaisedButton5.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        MaterialRaisedButton8.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton18_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton18.Click
        MaterialRaisedButton18.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton12_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton12.Click
        MaterialRaisedButton12.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton17_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton17.Click
        MaterialRaisedButton17.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton11_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton11.Click
        MaterialRaisedButton11.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton16_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton16.Click
        MaterialRaisedButton16.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton10.Click
        MaterialRaisedButton10.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton15_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton15.Click
        MaterialRaisedButton15.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton9_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton9.Click
        MaterialRaisedButton9.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton6.Click
        MaterialRaisedButton6.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        MaterialRaisedButton7.Visible = False
        Label1.Text = (Label1.Text + 1)
        MaterialFlatButton1.Text = ("Score " + Label1.Text + "/20")
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        MaterialRaisedButton1.Visible = True
        MaterialRaisedButton2.Visible = True
        MaterialRaisedButton3.Visible = True
        MaterialRaisedButton4.Visible = True
        MaterialRaisedButton5.Visible = True
        MaterialRaisedButton6.Visible = True
        MaterialRaisedButton7.Visible = True
        MaterialRaisedButton8.Visible = True
        MaterialRaisedButton9.Visible = True
        MaterialRaisedButton10.Visible = True
        MaterialRaisedButton11.Visible = True
        MaterialRaisedButton12.Visible = True
        MaterialRaisedButton13.Visible = True
        MaterialRaisedButton14.Visible = True
        MaterialRaisedButton15.Visible = True
        MaterialRaisedButton16.Visible = True
        MaterialRaisedButton17.Visible = True
        MaterialRaisedButton18.Visible = True
        MaterialRaisedButton22.Visible = True
        MaterialRaisedButton21.Visible = True
        Label1.Text = "0"
        MaterialFlatButton1.Text = "score 0/20"
        NotifyIcon1.BalloonTipTitle = "RESET"
        NotifyIcon1.BalloonTipText = "game and score has been reset."
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(30000)




    End Sub
End Class

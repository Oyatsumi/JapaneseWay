Public Class Form26

    Private Sub Form26_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu26 = False
    End Sub
    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu26 = True
        'JPG
        'PictureBox1.Image.Save("C:\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form1.PictureBox8.ImageLocation <> "" Then
            Size = New Size(925, 367)
            MaximumSize = New Size(925, 367)
        Else
            Size = New Size(925, 206)
            MaximumSize = New Size(925, 206)
        End If
        PictureBox1.ImageLocation = Form1.PictureBox1.ImageLocation
        PictureBox2.ImageLocation = Form1.PictureBox2.ImageLocation
        PictureBox3.ImageLocation = Form1.PictureBox3.ImageLocation
        PictureBox4.ImageLocation = Form1.PictureBox4.ImageLocation
        PictureBox5.ImageLocation = Form1.PictureBox5.ImageLocation
        PictureBox6.ImageLocation = Form1.PictureBox6.ImageLocation
        PictureBox7.ImageLocation = Form1.PictureBox7.ImageLocation
        PictureBox8.ImageLocation = Form1.PictureBox8.ImageLocation
        PictureBox9.ImageLocation = Form1.PictureBox9.ImageLocation
        PictureBox10.ImageLocation = Form1.PictureBox10.ImageLocation
        PictureBox11.ImageLocation = Form1.PictureBox11.ImageLocation
        PictureBox12.ImageLocation = Form1.PictureBox12.ImageLocation
        PictureBox13.ImageLocation = Form1.PictureBox13.ImageLocation
        PictureBox14.ImageLocation = Form1.PictureBox14.ImageLocation
        If Form1.japones.Text <> "" Then
            Dim nome As String
            nome = Form1.TextBox1.Text
            Text = "JapaneseWay - Nome: " & nome & " - Pronúncia: " & Form1.japones.Text & "."
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form1.Visible = True Then
            BringToFront()
        End If
    End Sub
End Class
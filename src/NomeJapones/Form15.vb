Public Class Form15

    Private Sub Form15_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu15 = False
    End Sub

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu15 = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ComboBox1.Text <> "Selecione" Then
            If RadioButton1.Checked = True Then
                PictureBox1.ImageLocation = "imagem\ordem\katakana\" & ComboBox1.Text & ".gif"
                AxWindowsMediaPlayer1.URL = "som\kana_" & ComboBox1.Text & ".mp3"
            Else
                PictureBox1.ImageLocation = "imagem\ordem\" & ComboBox1.Text & ".gif"
                AxWindowsMediaPlayer1.URL = "som\kana_" & ComboBox1.Text & ".mp3"
            End If
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "Selecione" Then
            If RadioButton1.Checked = True Then
                PictureBox1.ImageLocation = "imagem\ordem\katakana\" & ComboBox1.Text & ".gif"
                If CheckBox1.Checked = False Then
                    AxWindowsMediaPlayer1.URL = "som\kana_" & ComboBox1.Text & ".mp3"
                End If
            Else
                PictureBox1.ImageLocation = "imagem\ordem\" & ComboBox1.Text & ".gif"
                If CheckBox1.Checked = False Then
                    AxWindowsMediaPlayer1.URL = "som\kana_" & ComboBox1.Text & ".mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox1.Checked = True Then

        End If
    End Sub
End Class
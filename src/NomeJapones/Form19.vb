Public Class Form19

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.SelectedPath <> "" And RadioButton2.Checked = True Then
            Form17.foto.Text = FolderBrowserDialog1.SelectedPath & "\"
            Form17.foto.Tag = "OK"
            If TextBox1.Text <> "" Then
                Form17.nome.Text = TextBox1.Text
                Form17.fototimer.Enabled = True
                Close()
                Form17.Focus()
                Form17.nome.Tag = "OK"
            Else
                MsgBox("Escreva um nome para sua imagem.", MsgBoxStyle.Critical, "JapaneseWay")
                Form17.nome.Tag = ""
            End If
        ElseIf RadioButton2.Checked = True Then
            MsgBox("Selecione o seu diretório ou use o diretório padrão.", MsgBoxStyle.Critical, "JapaneseWay")
        End If
        If RadioButton1.Checked = True Then
            If TextBox1.Text <> "" Then
                Form17.nome.Text = TextBox1.Text
                Form17.fototimer.Enabled = True
                Close()
                Form17.Focus()
                Form17.nome.Tag = "OK"
            Else
                MsgBox("Escreva um nome para sua imagem.", MsgBoxStyle.Critical, "JapaneseWay")
                Form17.nome.Tag = ""
            End If
            Form17.foto.Text = "nomes\"
            Form17.foto.Tag = "OK"
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form17.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If FolderBrowserDialog1.SelectedPath <> "" Then
            Label2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Form19_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        formu19 = False
    End Sub

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu19 = True
    End Sub
    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub
End Class
Public Class Form6

    Private Sub Form6_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        formu6 = False
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If FolderBrowserDialog1.SelectedPath <> "" Then
            Label2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.SelectedPath <> "" And RadioButton2.Checked = True Then
            Form1.foto.Text = FolderBrowserDialog1.SelectedPath & "\"
            Form1.foto.Tag = "OK"
            If TextBox1.Text <> "" Then
                Form1.nome.Text = TextBox1.Text
                Form1.fototimer.Enabled = True
                Close()
                Form1.Focus()
                Form1.nome.Tag = "OK"
            Else
                MsgBox("Escreva um nome para sua imagem.", MsgBoxStyle.Critical, "JapaneseWay")
                Form1.nome.Tag = ""
            End If
        ElseIf RadioButton2.Checked = True Then
            MsgBox("Selecione o seu diretório ou use o diretório padrão.", MsgBoxStyle.Critical, "JapaneseWay")
        End If
        If RadioButton1.Checked = True Then
            If TextBox1.Text <> "" Then
                Form1.nome.Text = TextBox1.Text
                Form1.fototimer.Enabled = True
                Close()
                Form1.Focus()
                Form1.nome.Tag = "OK"
            Else
                MsgBox("Escreva um nome para sua imagem.", MsgBoxStyle.Critical, "JapaneseWay")
                Form1.nome.Tag = ""
            End If
            Form1.foto.Text = "nomes\"
            Form1.foto.Tag = "OK"
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'If RadioButton1.Checked = True Then
        'If TextBox1.Text <> "" Then
        'Form1.nome.Text = TextBox1.Text
        ' Form1.foto.Text = "nomes\"
        'Else
        ' MsgBox("Digite o nome da imagem para salvar", MsgBoxStyle.Critical, "JapaneseWay")
        'End If
        'End If
    End Sub

  

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Form1.Salvarnome.Checked = True
        Else
            Form1.Salvarnome.Checked = False
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu6 = True
        'Form1.Salvarnome.Checked = False
    End Sub
End Class
Public Class Form27

    Private Sub Form27_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu27 = False
    End Sub


    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu27 = True
        'numero randomico
        'Dim rand As New Random()
        'Dim number = rand.Next(1, 100)

        'frases:
        FraseRnd(1) = "acima"
        FraseRnd(2) = "água"
        FraseRnd(3) = "álcool"
        FraseRnd(4) = "amor"
        FraseRnd(5) = "azul"
        FraseRnd(6) = "barulho"
        FraseRnd(7) = "bosque"
        FraseRnd(8) = "branco"
        FraseRnd(9) = "céu"
        FraseRnd(10) = "chuva"
        FraseRnd(11) = "criança"
        FraseRnd(12) = "demônio"
        FraseRnd(13) = "deus"
        FraseRnd(14) = "dia-sol"
        FraseRnd(15) = "eu"
        FraseRnd(16) = "flor"
        FraseRnd(17) = "floresta"
        FraseRnd(18) = "fogo"
        FraseRnd(19) = "força"
        FraseRnd(20) = "grande"
        FraseRnd(21) = "homem"
        FraseRnd(22) = "interior"
        FraseRnd(23) = "ler"
        FraseRnd(24) = "livro"
        FraseRnd(25) = "madeira"
        FraseRnd(26) = "mão"
        FraseRnd(27) = "mau"
        FraseRnd(28) = "mês-lua"
        FraseRnd(29) = "metal"
        FraseRnd(30) = "montanha"
        FraseRnd(31) = "morte"
        FraseRnd(32) = "mulher"
        FraseRnd(33) = "noite"
        FraseRnd(34) = "paraíso"
        FraseRnd(35) = "pequeno"
        FraseRnd(36) = "pessoa"
        FraseRnd(37) = "preto"
        FraseRnd(38) = "relâmpago"
        FraseRnd(39) = "sonho"
        FraseRnd(40) = "terra"
        FraseRnd(41) = "vento"
        FraseRnd(42) = "verde"
        FraseRnd(43) = "vermelho"
        FraseRnd(44) = "vida"
        'FraseRnd(45) = ""
        'FraseRnd(46) = "pu"
        'FraseRnd(47) = "ra"
        'FraseRnd(48) = "re"
        'FraseRnd(49) = "ri"
        'FraseRnd(50) = "ro"
        'FraseRnd(51) = "ru"
        'FraseRnd(52) = "sa"
        'FraseRnd(53) = "se"
        'FraseRnd(54) = "so"
        'FraseRnd(55) = "su"
        'FraseRnd(56) = "ta"
        'FraseRnd(57) = "te"
        'FraseRnd(58) = "to"
        'FraseRnd(59) = "tsu"
        'FraseRnd(60) = "u"
        'FraseRnd(61) = "wa"
        'FraseRnd(62) = "wo"
        'FraseRnd(63) = "ya"
        'FraseRnd(64) = "yo"
        'FraseRnd(65) = "yu"
        'FraseRnd(66) = "za"
        'FraseRnd(67) = "ze"
        'FraseRnd(68) = "zo"
        'FraseRnd(69) = "zu"
        'FraseRnd(70) = "shi"
        'FraseRnd(71) = "fu"
    End Sub
    Private FraseRnd(71)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim letra As String
        Button1.Text = "Gerar novamente!"
        If RadioButton1.Checked = True Then
            Dim rand As New Random()
            Dim number = rand.Next(1, 45)
            letra = FraseRnd(number)
            PictureBox8.ImageLocation = "Imagem\kanji\outros\certo\" & letra & ".jpg"
            'buttons
            Dim botaoum, botaodois, botaotres As String
            Dim numberum = rand.Next(1, 45)
            Do While numberum = number
                numberum = rand.Next(1, 45)
            Loop
            Dim numberdois = rand.Next(1, 45)
            'teste
            Do While numberdois = number
                numberdois = rand.Next(1, 45)
                Do While numberdois = numberum
                    numberdois = rand.Next(1, 45)
                Loop
            Loop
            Do While numberdois = numberum
                numberdois = rand.Next(1, 45)
                Do While numberdois = number
                    numberdois = rand.Next(1, 45)
                Loop
            Loop
            'teste

            Dim combinacao = rand.Next(1, 7)

            If combinacao = "1" Then
                botaoum = FraseRnd(numberum)
                botaodois = FraseRnd(numberdois)
                botaotres = FraseRnd(number)
            ElseIf combinacao = "2" Then
                botaoum = FraseRnd(numberdois)
                botaodois = FraseRnd(numberum)
                botaotres = FraseRnd(number)
            ElseIf combinacao = "3" Then
                botaoum = FraseRnd(numberdois)
                botaodois = FraseRnd(number)
                botaotres = FraseRnd(numberum)
            ElseIf combinacao = "4" Then
                botaoum = FraseRnd(number)
                botaodois = FraseRnd(numberdois)
                botaotres = FraseRnd(numberum)
            ElseIf combinacao = "5" Then
                botaoum = FraseRnd(number)
                botaodois = FraseRnd(numberum)
                botaotres = FraseRnd(numberdois)
            Else
                botaoum = FraseRnd(numberum)
                botaodois = FraseRnd(number)
                botaotres = FraseRnd(numberdois)
            End If

            TextBox2.Text = letra

            Button2.Text = botaoum
            Button3.Text = botaodois
            Button4.Text = botaotres

        Else
            Dim rand As New Random()
            Dim number = rand.Next(1, 45)
            letra = FraseRnd(number)
            PictureBox8.ImageLocation = "Imagem\kanji\outros\certo\" & letra & ".jpg"
            'campo de texto

            TextBox2.Text = letra

        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked = True Then
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Label4.Text = "Selecione a palavra em um" & Chr(13) & "dos botões:"
            TextBox1.Visible = False
            Button5.Visible = False
        Else

            Label4.Text = "Escreva a palavra abaixo" & Chr(13) & "em português:"
            TextBox1.Visible = True
            Button5.Visible = True
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = TextBox2.Text Then
            MsgBox("Sua resposta está correta. Parabéns!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Button1.Text = "Gerar novamente!"

            Label5.Text = TextBox2.Text


        ElseIf Button2.Text = "Botão1" Then
            MsgBox("Primeiro clique em começar!", MsgBoxStyle.Critical, "JapaneseWay")
        Else
            MsgBox("Sua resposta está incorreta. Tente novamente :(", MsgBoxStyle.Critical, "JapaneseWay")
            Button1.Text = "Gerar novamente!"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = TextBox2.Text Then
            MsgBox("Sua resposta está correta. Parabéns!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Button1.Text = "Gerar novamente!"

            Label5.Text = TextBox2.Text


        ElseIf Button3.Text = "Botão2" Then
            MsgBox("Primeiro clique em começar!", MsgBoxStyle.Critical, "JapaneseWay")
        Else
            MsgBox("Sua resposta está incorreta. Tente novamente :(", MsgBoxStyle.Critical, "JapaneseWay")
            Button1.Text = "Gerar novamente!"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = TextBox2.Text Then
            MsgBox("Sua resposta está correta. Parabéns!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Button1.Text = "Gerar novamente!"

            Label5.Text = TextBox2.Text


        ElseIf Button4.Text = "Botão3" Then
            MsgBox("Primeiro clique em começar!", MsgBoxStyle.Critical, "JapaneseWay")
        Else
            MsgBox("Sua resposta está incorreta. Tente novamente :(", MsgBoxStyle.Critical, "JapaneseWay")
            Button1.Text = "Gerar novamente!"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox2.Text = "" Then
            MsgBox("Primeiro clique em começar!", MsgBoxStyle.Critical, "JapaneseWay")
        ElseIf TextBox1.Text = LCase(TextBox2.Text) Then
            MsgBox("Sua resposta está correta. Parabéns!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Button1.Text = "Gerar novamente!"

            Label5.Text = TextBox2.Text

        Else
            MsgBox("Sua resposta está incorreta. Tente novamente :(", MsgBoxStyle.Critical, "JapaneseWay")
            Button1.Text = "Gerar novamente!"
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Label5.Text = "Pronúncia." Then
            MsgBox("Para ver a pronúncia do kanji, primeiro você deve acertar o kanji.", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else
            Form17.Show()
            Form17.Focus()
            Form17.WindowState = FormWindowState.Normal
            Form17.TextBox7.Text = Label5.Text
            Form17.Button1_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form17.Visible = False Then
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button5_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class


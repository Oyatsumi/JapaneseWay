Public Class Form11

    Private Sub Form11_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu11 = False
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu11 = True
        'numero randomico
        'Dim rand As New Random()
        'Dim number = rand.Next(1, 100)

        'frases:
        FraseRnd(1) = "a"
        FraseRnd(2) = "ba"
        FraseRnd(3) = "be"
        FraseRnd(4) = "bi"
        FraseRnd(5) = "bo"
        FraseRnd(6) = "bu"
        FraseRnd(7) = "chi"
        FraseRnd(8) = "da"
        FraseRnd(9) = "de"
        FraseRnd(10) = "dji"
        FraseRnd(11) = "do"
        FraseRnd(12) = "dzu"
        FraseRnd(13) = "e"
        FraseRnd(14) = "fa"
        FraseRnd(15) = "fe"
        FraseRnd(16) = "fi"
        FraseRnd(17) = "fo"
        FraseRnd(18) = "fu"
        FraseRnd(19) = "ga"
        FraseRnd(20) = "ge"
        FraseRnd(21) = "gi"
        FraseRnd(22) = "go"
        FraseRnd(23) = "gu"
        FraseRnd(24) = "ha"
        FraseRnd(25) = "he"
        FraseRnd(26) = "hi"
        FraseRnd(27) = "ho"
        FraseRnd(28) = "i"
        FraseRnd(29) = "ji"
        FraseRnd(30) = "jya"
        FraseRnd(31) = "jye"
        FraseRnd(32) = "jyo"
        FraseRnd(33) = "jyu"
        FraseRnd(34) = "ka"
        FraseRnd(35) = "ke"
        FraseRnd(36) = "ki"
        FraseRnd(37) = "ko"
        FraseRnd(38) = "ku"
        FraseRnd(39) = "ma"
        FraseRnd(40) = "me"
        FraseRnd(41) = "mi"
        FraseRnd(42) = "mo"
        FraseRnd(43) = "mu"
        FraseRnd(44) = "n"
        FraseRnd(45) = "na"
        FraseRnd(46) = "ne"
        FraseRnd(47) = "ni"
        FraseRnd(48) = "no"
        FraseRnd(49) = "nu"
        FraseRnd(50) = "o"
        FraseRnd(51) = "pa"
        FraseRnd(52) = "pe"
        FraseRnd(53) = "pi"
        FraseRnd(54) = "po"
        FraseRnd(55) = "pu"
        FraseRnd(56) = "ra"
        FraseRnd(57) = "re"
        FraseRnd(58) = "ri"
        FraseRnd(59) = "ro"
        FraseRnd(60) = "ru"
        FraseRnd(61) = "sa"
        FraseRnd(62) = "se"
        FraseRnd(63) = "sha"
        FraseRnd(64) = "she"
        FraseRnd(65) = "shi"
        FraseRnd(66) = "sho"
        FraseRnd(67) = "shu"
        FraseRnd(68) = "so"
        FraseRnd(69) = "su"
        FraseRnd(70) = "ta"
        FraseRnd(71) = "te"
        FraseRnd(72) = "to"
        FraseRnd(73) = "tsu"
        FraseRnd(74) = "u"
        FraseRnd(75) = "va"
        FraseRnd(76) = "ve"
        FraseRnd(77) = "vi"
        FraseRnd(78) = "vo"
        FraseRnd(79) = "vu"
        FraseRnd(80) = "wa"
        FraseRnd(81) = "ya"
        FraseRnd(82) = "yo"
        FraseRnd(83) = "yu"
        FraseRnd(84) = "za"
        FraseRnd(85) = "ze"
        FraseRnd(86) = "zo"
        FraseRnd(87) = "zu"
    End Sub
    Private FraseRnd(87)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim letra As String
        Button1.Text = "Gerar novamente!"
        If RadioButton1.Checked = True Then
            Dim rand As New Random()
            Dim number = rand.Next(1, 88)
            letra = FraseRnd(number)
            PictureBox8.ImageLocation = "imagens\" & letra & ".png"
            'buttons
            Dim botaoum, botaodois, botaotres As String
            Dim numberum = rand.Next(1, 88)
            Do While numberum = number
                numberum = rand.Next(1, 88)
            Loop
            Dim numberdois = rand.Next(1, 88)
            'teste
            Do While numberdois = number
                numberdois = rand.Next(1, 88)
                Do While numberdois = numberum
                    numberdois = rand.Next(1, 88)
                Loop
            Loop
            Do While numberdois = numberum
                numberdois = rand.Next(1, 88)
                Do While numberdois = number
                    numberdois = rand.Next(1, 88)
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
            Dim number = rand.Next(1, 88)
            letra = FraseRnd(number)
            PictureBox8.ImageLocation = "imagens\" & letra & ".png"
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
            Label4.Text = "Selecione a sílaba em um" & Chr(13) & "dos botões:"
            TextBox1.Visible = False
            Button5.Visible = False
        Else

            Label4.Text = "Escreva a sílaba abaixo" & Chr(13) & "pela pronúncia Japonesa:"
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
            If TextBox2.Text = "chi" Then
                Label5.Text = "ti"
            ElseIf TextBox2.Text = "ha" Then
                Label5.Text = "rra"
            ElseIf TextBox2.Text = "he" Then
                Label5.Text = "rre"
            ElseIf TextBox2.Text = "hi" Then
                Label5.Text = "rri"
            ElseIf TextBox2.Text = "ho" Then
                Label5.Text = "rro"
            Else
                Label5.Text = TextBox2.Text
            End If
            Label6.Text = TextBox2.Text

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
            If TextBox2.Text = "chi" Then
                Label5.Text = "ti"
            ElseIf TextBox2.Text = "ha" Then
                Label5.Text = "rra"
            ElseIf TextBox2.Text = "he" Then
                Label5.Text = "rre"
            ElseIf TextBox2.Text = "hi" Then
                Label5.Text = "rri"
            ElseIf TextBox2.Text = "ho" Then
                Label5.Text = "rro"
            Else
                Label5.Text = TextBox2.Text
            End If
            Label6.Text = TextBox2.Text
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
            If TextBox2.Text = "chi" Then
                Label5.Text = "ti"
            ElseIf TextBox2.Text = "ha" Then
                Label5.Text = "rra"
            ElseIf TextBox2.Text = "he" Then
                Label5.Text = "rre"
            ElseIf TextBox2.Text = "hi" Then
                Label5.Text = "rri"
            ElseIf TextBox2.Text = "ho" Then
                Label5.Text = "rro"
            Else
                Label5.Text = TextBox2.Text
            End If
            Label6.Text = TextBox2.Text
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
            If TextBox2.Text = "chi" Then
                Label5.Text = "ti"
            ElseIf TextBox2.Text = "ha" Then
                Label5.Text = "rra"
            ElseIf TextBox2.Text = "he" Then
                Label5.Text = "rre"
            ElseIf TextBox2.Text = "hi" Then
                Label5.Text = "rri"
            ElseIf TextBox2.Text = "ho" Then
                Label5.Text = "rro"
            Else
                Label5.Text = TextBox2.Text
            End If
            Label6.Text = TextBox2.Text
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

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button5_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
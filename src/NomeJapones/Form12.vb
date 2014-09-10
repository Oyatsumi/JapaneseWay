Public Class Form12

    Private Sub Form12_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu12 = False
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu12 = True
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
        FraseRnd(14) = "ga"
        FraseRnd(15) = "ge"
        FraseRnd(16) = "gi"
        FraseRnd(17) = "go"
        FraseRnd(18) = "gu"
        FraseRnd(19) = "ha"
        FraseRnd(20) = "he"
        FraseRnd(21) = "hi"
        FraseRnd(22) = "ho"
        FraseRnd(23) = "i"
        FraseRnd(24) = "ji"
        FraseRnd(25) = "ka"
        FraseRnd(26) = "ke"
        FraseRnd(27) = "ki"
        FraseRnd(28) = "ko"
        FraseRnd(29) = "ku"
        FraseRnd(30) = "ma"
        FraseRnd(31) = "me"
        FraseRnd(32) = "mi"
        FraseRnd(33) = "mo"
        FraseRnd(34) = "mu"
        FraseRnd(35) = "n"
        FraseRnd(36) = "na"
        FraseRnd(37) = "ne"
        FraseRnd(38) = "ni"
        FraseRnd(39) = "no"
        FraseRnd(40) = "nu"
        FraseRnd(41) = "o"
        FraseRnd(42) = "pa"
        FraseRnd(43) = "pe"
        FraseRnd(44) = "pi"
        FraseRnd(45) = "po"
        FraseRnd(46) = "pu"
        FraseRnd(47) = "ra"
        FraseRnd(48) = "re"
        FraseRnd(49) = "ri"
        FraseRnd(50) = "ro"
        FraseRnd(51) = "ru"
        FraseRnd(52) = "sa"
        FraseRnd(53) = "se"
        FraseRnd(54) = "so"
        FraseRnd(55) = "su"
        FraseRnd(56) = "ta"
        FraseRnd(57) = "te"
        FraseRnd(58) = "to"
        FraseRnd(59) = "tsu"
        FraseRnd(60) = "u"
        FraseRnd(61) = "wa"
        FraseRnd(62) = "wo"
        FraseRnd(63) = "ya"
        FraseRnd(64) = "yo"
        FraseRnd(65) = "yu"
        FraseRnd(66) = "za"
        FraseRnd(67) = "ze"
        FraseRnd(68) = "zo"
        FraseRnd(69) = "zu"
        FraseRnd(70) = "shi"
        FraseRnd(71) = "fu"
    End Sub
    Private FraseRnd(71)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim letra As String
        Button1.Text = "Gerar novamente!"
        If RadioButton1.Checked = True Then
            Dim rand As New Random()
            Dim number = rand.Next(1, 72)
            letra = FraseRnd(number)
            PictureBox8.ImageLocation = "Hiragana\" & letra & ".png"
            'buttons
            Dim botaoum, botaodois, botaotres As String
            Dim numberum = rand.Next(1, 72)
            Do While numberum = number
                numberum = rand.Next(1, 72)
            Loop
            Dim numberdois = rand.Next(1, 72)
            'teste
            Do While numberdois = number
                numberdois = rand.Next(1, 72)
                Do While numberdois = numberum
                    numberdois = rand.Next(1, 72)
                Loop
            Loop
            Do While numberdois = numberum
                numberdois = rand.Next(1, 72)
                Do While numberdois = number
                    numberdois = rand.Next(1, 72)
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
            Dim number = rand.Next(1, 72)
            letra = FraseRnd(number)
            PictureBox8.ImageLocation = "Hiragana\" & letra & ".png"
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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
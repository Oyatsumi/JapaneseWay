Public Class Form23
    Private FraseRnd(71)
    Private Pasta(2)
    Dim simbolojogador1 As String
    Dim simbolojogador2 As String
    Dim quantasvezes As Integer
    Dim um, dois As Integer
    Dim um1, dois2 As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        quantasvezes = TextBox4.Text
        um = Label6.Text
        dois = Label7.Text
        um1 = Label8.Text
        dois2 = Label9.Text
    End Sub

    Private Sub Form23_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu23 = False
    End Sub

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu23 = True
        quantasvezes = 10
        Pasta(1) = "Hiragana\"
        Pasta(2) = "Imagens\"
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
        FraseRnd(62) = "e"
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

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton2.Checked = True Then '2 jogadores
            GroupBox4.Enabled = True
            GroupBox3.Enabled = True
        End If
        If RadioButton1.Checked = True Then '1 jogador
            GroupBox4.Enabled = False
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then 'seleção de alfabetos
            If CheckBox2.Checked = False Then
                CheckBox1.Checked = True
                MsgBox("Você deve selecionar ao menos um alfabeto!", MsgBoxStyle.Critical, "JapaneseWay")
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = False Then 'seleção de alfabetos
            If CheckBox2.Checked = False Then
                CheckBox1.Checked = True
                MsgBox("Você deve selecionar ao menos um alfabeto!", MsgBoxStyle.Critical, "JapaneseWay")
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
       
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then 'nome do jogador 1
            GroupBox3.Text = TextBox2.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then 'nome do jogador 2
            GroupBox4.Text = TextBox3.Text
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then 'jogador 1 botões
            'botões do jogador 1
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            'botões do jogador 1
            Label10.Visible = False
            TextBox1.Visible = False
            Button4.Visible = False
        Else
            Label10.Visible = True 'jogador 1 caixa de texto
            TextBox1.Visible = True
            'botões do jogador 1
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = True
            'botões do jogador 1

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then ' JOGADOR DOIS BOTÔES
            'botões do jogador 2
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            'botões do jogador 2
            TextBox5.Visible = False
            Label14.Visible = False
            Button5.Visible = False
        Else                           'JOGADOR DOIS CAIXA DE TEXTO
            'botões do jogador 2
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            'botões do jogador 2
            TextBox5.Visible = True
            Label14.Visible = True
            Button5.Visible = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text Like "#" = True Then
            If TextBox4.Text < 1 Then
                TextBox4.Text = "10"
                MsgBox("Só é possível usar números de 1 à 50 na quantidade de vezes!", MsgBoxStyle.Critical, "JapaneseWay")
            ElseIf TextBox4.Text > 50 Then
                TextBox4.Text = "10"
                MsgBox("Só é possível usar números de 1 à 50 na quantidade de vezes!", MsgBoxStyle.Critical, "JapaneseWay")
            End If
            GoTo fim
        Else
            If TextBox4.Text Like "##" = False Then
                TextBox4.Text = "10"
                MsgBox("Só é possível usar números de 1 à 50 na quantidade de vezes!", MsgBoxStyle.Critical, "JapaneseWay")
            Else
                If TextBox4.Text < 1 Then
                    TextBox4.Text = "10"
                    MsgBox("Só é possível usar números de 1 à 50 na quantidade de vezes!", MsgBoxStyle.Critical, "JapaneseWay")
                ElseIf TextBox4.Text > 50 Then
                    TextBox4.Text = "10"
                    MsgBox("Só é possível usar números de 1 à 50 na quantidade de vezes!", MsgBoxStyle.Critical, "JapaneseWay")
                End If
            End If
        End If
        Exit Sub
fim:
    End Sub

    Public Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dificuldade.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        CheckBox3.Enabled = False

        If RadioButton1.Checked = True Then 'COMANDOS PARA UM JOGADOR!
            If CheckBox1.Checked Xor CheckBox2.Checked = True Then 'SOMENTE KATAKANAS E/OU HIRAGANAS
                If RadioButton3.Checked = True Then 'ENTAO É FACIL
                    Dim rand As New Random()
                    Dim number = rand.Next(1, 72)
                    simbolojogador1 = FraseRnd(number)

                    If CheckBox1.Checked = True Then 'SOMENTE KATAKANAS
                        PictureBox10.ImageLocation = "Imagens\" & simbolojogador1 & ".png"
                    ElseIf CheckBox2.Checked = True Then 'SOMENTE HIRAGANAS
                        PictureBox10.ImageLocation = "Hiragana\" & simbolojogador1 & ".png"
                    End If

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

                    Dim botaoum, botaodois, botaotres As String

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

                    Button1.Text = botaoum
                    Button2.Text = botaodois
                    Button3.Text = botaotres

                Else 'DIFICIL, SOMENTE KATAKANAS E/OU HIRAGANA UM JOGADOR

                    Dim rand As New Random()
                    Dim number = rand.Next(1, 72)
                    simbolojogador1 = FraseRnd(number)

                    If CheckBox1.Checked = True Then 'SOMENTE KATAKANAS
                        PictureBox10.ImageLocation = "Imagens\" & simbolojogador1 & ".png"
                    ElseIf CheckBox2.Checked = True Then 'SOMENTE HIRAGANAS
                        PictureBox10.ImageLocation = "Hiragana\" & simbolojogador1 & ".png"
                    End If

                End If


                'HIRAGANA E KATAKANA JUNTOS!!!!
                'HIRAGANA E KATAKANA JUNTOS!!!!
                'HIRAGANA E KATAKANA JUNTOS!!!!
                'HIRAGANA E KATAKANA JUNTOS!!!!
                'HIRAGANA E KATAKANA JUNTOS!!!!
                'HIRAGANA E KATAKANA JUNTOS!!!!
            Else'KATAKANAS E HIRAGANAS JUNTOS!!

                If RadioButton3.Checked = True Then 'ENTAO É FACIL
                    Dim rand As New Random()
                    Dim number = rand.Next(1, 72)
                    simbolojogador1 = FraseRnd(number)

                    Dim pastafrase = rand.Next(1, 3)
                    PictureBox10.ImageLocation = Pasta(pastafrase) & simbolojogador1 & ".png"


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

                    Dim botaoum, botaodois, botaotres As String

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

                    Button1.Text = botaoum
                    Button2.Text = botaodois
                    Button3.Text = botaotres

                Else 'DIFICIL, SOMENTE KATAKANAS E/OU HIRAGANA UM JOGADOR

                    Dim rand As New Random()
                    Dim number = rand.Next(1, 72)
                    simbolojogador1 = FraseRnd(number)

                    Dim pastafrase = rand.Next(1, 3)
                    PictureBox10.ImageLocation = Pasta(pastafrase) & simbolojogador1 & ".png"

                End If
            End If
            tempo.Enabled = True
            Button9.Enabled = False

        End If '1jogador


        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES
        '2 JOGADORES

        If RadioButton2.Checked = True Then '2 JOGADORES
            If CheckBox3.Checked = False Then 'MESMA IMAGEM PRO JOGADOR 1 E 2
                If CheckBox1.Checked Xor CheckBox2.Checked = True Then 'SOMENTE KATAKANAS E/OU HIRAGANAS
                    If RadioButton6.Checked = True Then 'ENTAO É FACIL
                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        simbolojogador2 = FraseRnd(number) 'mesma imagem!

                        If CheckBox1.Checked = True Then 'SOMENTE KATAKANAS
                            PictureBox20.ImageLocation = "Imagens\" & simbolojogador2 & ".png"
                            PictureBox10.ImageLocation = "Imagens\" & simbolojogador1 & ".png"
                        ElseIf CheckBox2.Checked = True Then 'SOMENTE HIRAGANAS
                            PictureBox20.ImageLocation = "Hiragana\" & simbolojogador2 & ".png"
                            PictureBox10.ImageLocation = "Hiragana\" & simbolojogador1 & ".png"
                        End If

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


                        Dim botaoum, botaodois, botaotres As String

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

                        Button1.Text = botaoum
                        Button2.Text = botaodois
                        Button3.Text = botaotres

                        Button8.Text = botaodois
                        Button7.Text = botaoum
                        Button6.Text = botaotres

                    Else 'DIFICIL, SOMENTE KATAKANAS E/OU HIRAGANA UM JOGADOR

                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        simbolojogador2 = FraseRnd(number)

                        If CheckBox1.Checked = True Then 'SOMENTE KATAKANAS
                            PictureBox10.ImageLocation = "Imagens\" & simbolojogador1 & ".png"
                            PictureBox20.ImageLocation = "Imagens\" & simbolojogador2 & ".png"
                        ElseIf CheckBox2.Checked = True Then 'SOMENTE HIRAGANAS
                            PictureBox10.ImageLocation = "Hiragana\" & simbolojogador1 & ".png"
                            PictureBox20.ImageLocation = "Hiragana\" & simbolojogador2 & ".png"
                        End If

                    End If 'dificuldade

                    'HIRAGANA E KATAKANA JUNTOS!!!! 2 JOGADORES
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                Else 'KATAKANAS E HIRAGANAS JUNTOS!!

                    If RadioButton3.Checked = True Then 'ENTAO É FACIL
                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        simbolojogador2 = FraseRnd(number)

                        Dim pastafrase = rand.Next(1, 3)
                        PictureBox10.ImageLocation = Pasta(pastafrase) & simbolojogador1 & ".png"
                        PictureBox20.ImageLocation = Pasta(pastafrase) & simbolojogador2 & ".png"

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


                        Dim botaoum, botaodois, botaotres As String

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

                        Button1.Text = botaoum
                        Button2.Text = botaodois
                        Button3.Text = botaotres

                        Button8.Text = botaoum
                        Button7.Text = botaodois
                        Button6.Text = botaotres

                    Else 'DIFICIL, SOMENTE KATAKANAS E/OU HIRAGANA 2 JOGADOR

                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        simbolojogador2 = FraseRnd(number)

                        Dim pastafrase = rand.Next(1, 3)
                        PictureBox10.ImageLocation = Pasta(pastafrase) & simbolojogador1 & ".png"
                        PictureBox20.ImageLocation = Pasta(pastafrase) & simbolojogador2 & ".png"

                    End If 'dificuldade katakana e hiragana selecionados juntos


                End If 'katakanas e hiraganas

                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2'2 JOGADORES
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
                'IMAGENS DIFERENTES PRO JOGADOR 1 E 2
            Else
                If CheckBox1.Checked Xor CheckBox2.Checked = True Then 'SOMENTE KATAKANAS E/OU HIRAGANAS
                    If RadioButton6.Checked = True Then 'ENTAO É FACIL
                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        Dim numberjog2 = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        Do While numberjog2 = number
                            numberjog2 = rand.Next(1, 72)
                        Loop
                        simbolojogador2 = FraseRnd(numberjog2) 'imagens diferentes


                        If CheckBox1.Checked = True Then 'SOMENTE KATAKANAS
                            PictureBox20.ImageLocation = "Imagens\" & simbolojogador2 & ".png"
                            PictureBox10.ImageLocation = "Imagens\" & simbolojogador1 & ".png"
                        ElseIf CheckBox2.Checked = True Then 'SOMENTE HIRAGANAS
                            PictureBox20.ImageLocation = "Hiragana\" & simbolojogador2 & ".png"
                            PictureBox10.ImageLocation = "Hiragana\" & simbolojogador1 & ".png"
                        End If

                        'para o number do jogador1
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



                        Dim botaoum, botaodois, botaotres As String

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

                        Button1.Text = botaoum
                        Button2.Text = botaodois
                        Button3.Text = botaotres


                        'para numberjog 2 do jogador2
                        'para o numberjog2 do jogador2
                        Dim n1 = rand.Next(1, 72)
                        Do While n1 = numberjog2
                            n1 = rand.Next(1, 72)
                        Loop

                        Dim n2 = rand.Next(1, 72)
                        Do While n2 = numberjog2 And n1
                            n2 = rand.Next(1, 72)
                        Loop


                        Dim b1, b2, b3 As String

                        Dim combinacao2 = rand.Next(1, 7)
                        If combinacao2 = "1" Then
                            b1 = FraseRnd(n1)
                            b2 = FraseRnd(n2)
                            b3 = FraseRnd(numberjog2)
                        ElseIf combinacao2 = "2" Then
                            b1 = FraseRnd(n2)
                            b2 = FraseRnd(n1)
                            b3 = FraseRnd(numberjog2)
                        ElseIf combinacao2 = "3" Then
                            b1 = FraseRnd(n2)
                            b2 = FraseRnd(numberjog2)
                            b3 = FraseRnd(n1)
                        ElseIf combinacao2 = "4" Then
                            b1 = FraseRnd(numberjog2)
                            b2 = FraseRnd(n2)
                            b3 = FraseRnd(n1)
                        ElseIf combinacao2 = "5" Then
                            b1 = FraseRnd(numberjog2)
                            b2 = FraseRnd(n1)
                            b3 = FraseRnd(n2)
                        Else
                            b1 = FraseRnd(n1)
                            b2 = FraseRnd(numberjog2)
                            b3 = FraseRnd(n2)
                        End If


                        Button8.Text = b1
                        Button7.Text = b2
                        Button6.Text = b3

                    Else 'DIFICIL, SOMENTE KATAKANAS E/OU HIRAGANA UM JOGADOR 'imagens diferentes

                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        Dim numberjog2 = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        Do While numberjog2 = number
                            numberjog2 = rand.Next(1, 72)
                        Loop
                        simbolojogador2 = FraseRnd(numberjog2)

                        If CheckBox1.Checked = True Then 'SOMENTE KATAKANAS
                            PictureBox10.ImageLocation = "Imagens\" & simbolojogador1 & ".png"
                            PictureBox20.ImageLocation = "Imagens\" & simbolojogador2 & ".png"
                        ElseIf CheckBox2.Checked = True Then 'SOMENTE HIRAGANAS
                            PictureBox10.ImageLocation = "Hiragana\" & simbolojogador1 & ".png"
                            PictureBox20.ImageLocation = "Hiragana\" & simbolojogador2 & ".png"
                        End If

                    End If 'dificuldade

                    'HIRAGANA E KATAKANA JUNTOS!!!! 2 JOGADORES
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                    'HIRAGANA E KATAKANA JUNTOS!!!!
                Else 'KATAKANAS E HIRAGANAS JUNTOS!!

                    If RadioButton3.Checked = True Then 'ENTAO É FACIL
                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        Dim numberjog2 = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        Do While numberjog2 = number
                            numberjog2 = rand.Next(1, 72)
                        Loop
                        simbolojogador2 = FraseRnd(numberjog2)

                        Dim pastafrase = rand.Next(1, 3)
                        PictureBox10.ImageLocation = Pasta(pastafrase) & simbolojogador1 & ".png"
                        PictureBox20.ImageLocation = Pasta(pastafrase) & simbolojogador2 & ".png"

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

                        Dim botaoum, botaodois, botaotres As String

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

                        Button1.Text = botaoum
                        Button2.Text = botaodois
                        Button3.Text = botaotres


                        'para numberjog 2 do jogador2
                        'para o numberjog2 do jogador2
                        Dim n1 = rand.Next(1, 72)
                        Do While n1 = numberjog2
                            n1 = rand.Next(1, 72)
                        Loop

                        Dim n2 = rand.Next(1, 72)
                        Do While n2 = numberjog2 And n1
                            n2 = rand.Next(1, 72)
                        Loop

                        Dim b1, b2, b3 As String

                        Dim combinacao2 = rand.Next(1, 7)
                        If combinacao2 = "1" Then
                            b1 = FraseRnd(n1)
                            b2 = FraseRnd(n2)
                            b3 = FraseRnd(numberjog2)
                        ElseIf combinacao2 = "2" Then
                            b1 = FraseRnd(n2)
                            b2 = FraseRnd(n1)
                            b3 = FraseRnd(numberjog2)
                        ElseIf combinacao2 = "3" Then
                            b1 = FraseRnd(n2)
                            b2 = FraseRnd(numberjog2)
                            b3 = FraseRnd(n1)
                        ElseIf combinacao2 = "4" Then
                            b1 = FraseRnd(numberjog2)
                            b2 = FraseRnd(n2)
                            b3 = FraseRnd(n1)
                        ElseIf combinacao2 = "5" Then
                            b1 = FraseRnd(numberjog2)
                            b2 = FraseRnd(n1)
                            b3 = FraseRnd(n2)
                        Else
                            b1 = FraseRnd(n1)
                            b2 = FraseRnd(numberjog2)
                            b3 = FraseRnd(n2)
                        End If


                        Button8.Text = b1
                        Button7.Text = b2
                        Button6.Text = b3

                    Else 'DIFICIL, SOMENTE KATAKANAS E/OU HIRAGANA UM JOGADOR

                        Dim rand As New Random()
                        Dim number = rand.Next(1, 72)
                        Dim numberjog2 = rand.Next(1, 72)
                        simbolojogador1 = FraseRnd(number)
                        Do While numberjog2 = number
                            numberjog2 = rand.Next(1, 72)
                        Loop
                        simbolojogador2 = FraseRnd(numberjog2)

                        Dim pastafrase = rand.Next(1, 3)
                        PictureBox10.ImageLocation = Pasta(pastafrase) & simbolojogador1 & ".png"
                        PictureBox20.ImageLocation = Pasta(pastafrase) & simbolojogador2 & ".png"

                    End If 'dificuldade katakana e hiragana selecionados juntos fim


                End If 'katakanas e hiraganas fim


            End If 'mesma imagem pro jogador 1 e 2 fim

            tempo.Enabled = True
            turno1.Text = 0
            turno1_Click(AcceptButton, AcceptButton)
            Button9.Enabled = False
            fimdoisjogadores.Enabled = True
            PictureBox100.Visible = False
            PictureBox200.Visible = True
        End If ' radiobutton 2, dois jogadores






     
    End Sub

    Private Sub tempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tempo.Tick
        If Label15.Text <> 0 Then
            Label15.Text = Label15.Text - 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then 'SOMENTE UM JOGADOR
            If Button1.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                Button9_Click(AcceptButton, AcceptButton)



            ElseIf Button1.Text = "Botão 1" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                Button9_Click(AcceptButton, AcceptButton)
            End If
        End If





        If RadioButton2.Checked = True Then 'DOIS JOGADORES
            If Button1.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)

            ElseIf Button1.Text = "Botão 1" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then 'SOMENTE UM JOGADOR


            If Button2.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                Button9_Click(AcceptButton, AcceptButton)
            ElseIf Button2.Text = "Botão 2" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                Button9_Click(AcceptButton, AcceptButton)

            End If
        End If




        If RadioButton2.Checked = True Then 'DOIS JOGADORES
            If Button2.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)

            ElseIf Button2.Text = "Botão 2" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then 'SOMENTE UM JOGADOR


            If Button3.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                Button9_Click(AcceptButton, AcceptButton)

            ElseIf Button3.Text = "Botão 3" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                Button9_Click(AcceptButton, AcceptButton)

            End If
        End If



        If RadioButton2.Checked = True Then 'DOIS JOGADORES
            If Button3.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)

            ElseIf Button3.Text = "Botão 3" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)
            End If
        End If
    End Sub

    Private Sub jogo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButton1.Checked = True Then
            'textbox4
            Button9_Click(AcceptButton, AcceptButton)
            Label15.Text = "10" 'cronometro
            Label7.Text = Label7.Text + 1
            vezes.Enabled = False
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub ativarvezes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ativarvezes.Tick
        If RadioButton1.Checked = True Then
            If um + dois = quantasvezes Then

                Button10_Click(AcceptButton, AcceptButton)
            End If
            If Label15.Text = 0 Then
                vezes.Enabled = True
            End If
            ativarvezes.Enabled = True
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If RadioButton1.Checked = True Then
            vezes.Enabled = False
            tempo.Enabled = False
            ativarvezes.Enabled = False
            Button1.Text = "Botão 1"
            Button2.Text = "Botão 2"
            Button3.Text = "Botão 3"
            MsgBox("O jogo acabou!" & Chr(13) & "Você obteve:" & Chr(13) & "Acertos: " & Label6.Text & Chr(13) & "Erros: " & Label7.Text & Chr(13) & "Respostas dadas: " & um + dois, MsgBoxStyle.OkOnly, "JapaneseWay")
            Label6.Text = 0
            Label7.Text = 0
            TextBox1.Text = ""
            Label15.Text = "10"

            Dificuldade.Enabled = True
            GroupBox3.Enabled = True
            GroupBox5.Enabled = True
            GroupBox6.Enabled = True
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            CheckBox3.Enabled = True
            PictureBox10.ImageLocation = ""
            PictureBox20.ImageLocation = ""
            Button9.Enabled = True
        End If

        If RadioButton2.Checked = True Then
            tempo.Enabled = False
            PictureBox100.Visible = False
            PictureBox200.Visible = False
            fimdoisjogadores.Enabled = False
            Label15.Text = "10"
            Dim ganhador As String
            If um > um1 Then
                ganhador = "O ganhador é: " & GroupBox3.Text
            ElseIf um1 > um Then
                ganhador = "O ganhador é: " & GroupBox4.Text
            ElseIf um1 = um Then
                ganhador = "Houve um empate entre os jogadores!"
            End If
            MsgBox("O jogo acabou!" & Chr(13) & "Jogador: " & GroupBox3.Text & Chr(13) & "Acertos: " & Label6.Text & Chr(13) & "Erros: " & Label7.Text & Chr(13) & "Respostas dadas: " & um + dois & Chr(13) & Chr(13) & "Jogador: " & GroupBox4.Text & Chr(13) & "Acertos: " & Label8.Text & Chr(13) & "Erros: " & Label9.Text & Chr(13) & "Respostas dadas: " & um1 + dois2 & Chr(13) & Chr(13) & ganhador, MsgBoxStyle.OkOnly, "JapaneseWay")
            turno1.Text = ""
            turno2.Text = ""
            Button1.Text = "Botão 1"
            Button2.Text = "Botão 2"
            Button3.Text = "Botão 3"
            Button8.Text = "Botão 1"
            Button7.Text = "Botão 2"
            Button6.Text = "Botão 3"
            Label8.Text = 0
            Label9.Text = 0
            Label6.Text = 0
            Label7.Text = 0
            TextBox5.Text = ""
            TextBox1.Text = ""

            Dificuldade.Enabled = True
            GroupBox3.Enabled = True
            GroupBox5.Enabled = True
            GroupBox6.Enabled = True
            GroupBox4.Enabled = True
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            CheckBox3.Enabled = True
            PictureBox10.ImageLocation = ""
            PictureBox20.ImageLocation = ""
            Button9.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If RadioButton1.Checked = True Then 'SOMENTE UM JOGADOR



            If TextBox1.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                turno1.Text = 0
                turno2_Click(AcceptButton, AcceptButton)


            ElseIf Button5.Text = "" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                turno1.Text = 0
                turno2_Click(AcceptButton, AcceptButton)
            End If
        End If







        If RadioButton2.Checked = True Then 'DOIS JOGADORES


            If TextBox1.Text = simbolojogador1 Then
                Label6.Text = Label6.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)


            ElseIf Button5.Text = "" Then
            Else
                Label7.Text = Label7.Text + 1
                Label15.Text = "10"
                turno1.Text = 1
                PictureBox100.Visible = True
                PictureBox200.Visible = False
                turno2_Click(AcceptButton, AcceptButton)
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox5.Text = simbolojogador2 Then
            Label8.Text = Label8.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)

        ElseIf TextBox5.Text = "" Then
        Else
            Label9.Text = Label9.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button8.Text = simbolojogador2 Then
            Label8.Text = Label8.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)


        ElseIf Button8.Text = "Botão 1" Then
        Else
            Label9.Text = Label9.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub doisjogadores_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doisjogadores.Tick
        If RadioButton2.Checked = True Then
            If Label15.Text = 0 Then
                If turno1.Text = 1 Then
                    Button9_Click(AcceptButton, AcceptButton)
                    Label15.Text = "10" 'cronometro
                    Label9.Text = Label9.Text + 1
                    turno1.Text = 0
                    PictureBox100.Visible = False
                    PictureBox200.Visible = True
                    turno1_Click(AcceptButton, AcceptButton)
                ElseIf turno1.Text = 0 Then
                    Label15.Text = "10" 'cronometro
                    Label7.Text = Label7.Text + 1
                    turno1.Text = 1
                    PictureBox100.Visible = True
                    PictureBox200.Visible = False
                    turno2_Click(AcceptButton, AcceptButton)
                End If
            End If
        End If
        Exit Sub
    End Sub

    Private Sub turno1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turno1.Click
        GroupBox3.Enabled = True
        GroupBox4.Enabled = False
    End Sub

    Private Sub turno2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turno2.Click
        GroupBox3.Enabled = False
        GroupBox4.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button7.Text = simbolojogador2 Then
            Label8.Text = Label8.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)

        ElseIf Button7.Text = "Botão 2" Then
        Else
            Label9.Text = Label9.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Text = simbolojogador2 Then
            Label8.Text = Label8.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)

        ElseIf Button6.Text = "Botão 3" Then
        Else
            Label9.Text = Label9.Text + 1
            Label15.Text = "10"
            turno1.Text = 0
            PictureBox100.Visible = False
            PictureBox200.Visible = True
            turno1_Click(AcceptButton, AcceptButton)
            Button9_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub vezes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButton1.Checked = True Then
            'textbox4
            Button9_Click(AcceptButton, AcceptButton)
            Label15.Text = "10" 'cronometro
            Label7.Text = Label7.Text + 1
            vezes.Enabled = False
        End If
    End Sub

    Private Sub vezes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vezes.Tick
        If RadioButton1.Checked = True Then
            'textbox4
            Button9_Click(AcceptButton, AcceptButton)
            Label15.Text = "10" 'cronometro
            Label7.Text = Label7.Text + 1
            vezes.Enabled = False
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            Button5_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fimdoisjogadores.Tick
        If RadioButton2.Checked = True Then
            If um1 + dois2 = quantasvezes Then
                fimdoisjogadores.Enabled = False
                Button10_Click(AcceptButton, AcceptButton)
            End If
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button4_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
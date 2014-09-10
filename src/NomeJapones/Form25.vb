Public Class Form25

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            'On Error GoTo fim
            TextBox2.Text = ""
            TextBox3.Text = ""
            Dim contagem As Integer
            Dim contagem2 As Integer
            Dim letra As String
            Dim tsuon As String
            Dim outrasletras As String
            contagem = 1
            contagem2 = 1
            TextBox1.Text = TextBox1.Text & Chr(32)
            Do Until contagem = Len(TextBox1.Text) + 1
                letra = Mid(TextBox1.Text, contagem, contagem2)
                letra = AscW(letra)
                If TextBox3.Text <> "" Then
                    tsuon = Mid(TextBox3.Text, 1, 1)
                    TextBox2.Text = TextBox2.Text & tsuon & TextBox3.Text
                    TextBox3.Text = ""
                    contagem = contagem - 1
                    contagem2 = contagem2 - 1
                    tsucheck.Checked = False



                ElseIf outros.Checked = True Then
                    If Len(TextBox2.Text) > 2 Then
                        If Mid(TextBox2.Text, Len(TextBox2.Text) - 2) = "shi" Then
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 3)
                        ElseIf Mid(TextBox2.Text, Len(TextBox2.Text) - 2) = "tsu" Then
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 3)
                        ElseIf Mid(TextBox2.Text, Len(TextBox2.Text) - 2) = "dzu" Then
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 3)
                        ElseIf Mid(TextBox2.Text, Len(TextBox2.Text)) = "n" Then
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 1)
                        Else
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 2)
                        End If
                    Else
                        If Mid(TextBox2.Text, Len(TextBox2.Text)) = "n" Then
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 1)
                        Else
                            TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 2)
                        End If
                    End If

                    'outros.Text = outrasletras --> isso aqui é o caracter anterior
                    'TextBox4.Text = "a"
                    'TextBox4.Tag = "ゃ"

                    'se nao der certo passar pra ascw
                    If outros.Text = AscW("し") Then
                        TextBox2.Text = TextBox2.Text & "sh" & TextBox4.Text
                    ElseIf outros.Text = AscW("シ") Then
                        TextBox2.Text = TextBox2.Text & "sh" & TextBox4.Text
                    ElseIf outros.Text = AscW("ヴ") Then
                        TextBox2.Text = TextBox2.Text & "v" & TextBox4.Text
                    ElseIf outros.Text = AscW("ふ") Then
                        TextBox2.Text = TextBox2.Text & "f" & TextBox4.Text
                    ElseIf outros.Text = AscW("フ") Then
                        TextBox2.Text = TextBox2.Text & "f" & TextBox4.Text
                    ElseIf outros.Text = AscW("き") Then
                        TextBox2.Text = TextBox2.Text & "ky" & TextBox4.Text
                    ElseIf outros.Text = AscW("キ") Then
                        TextBox2.Text = TextBox2.Text & "ky" & TextBox4.Text
                    ElseIf outros.Text = AscW("チ") Then
                        TextBox2.Text = TextBox2.Text & "ch" & TextBox4.Text
                    ElseIf outros.Text = AscW("ち") Then
                        TextBox2.Text = TextBox2.Text & "ch" & TextBox4.Text
                    ElseIf outros.Text = AscW("に") Then
                        TextBox2.Text = TextBox2.Text & "ny" & TextBox4.Text
                    ElseIf outros.Text = AscW("ニ") Then
                        TextBox2.Text = TextBox2.Text & "ny" & TextBox4.Text
                    ElseIf outros.Text = AscW("ヒ") Then
                        TextBox2.Text = TextBox2.Text & "hy" & TextBox4.Text
                    ElseIf outros.Text = AscW("ひ") Then
                        TextBox2.Text = TextBox2.Text & "hy" & TextBox4.Text
                    ElseIf outros.Text = AscW("ミ") Then
                        TextBox2.Text = TextBox2.Text & "my" & TextBox4.Text
                    ElseIf outros.Text = AscW("み") Then
                        TextBox2.Text = TextBox2.Text & "my" & TextBox4.Text
                    ElseIf outros.Text = AscW("リ") Then
                        TextBox2.Text = TextBox2.Text & "ry" & TextBox4.Text
                    ElseIf outros.Text = AscW("り") Then
                        TextBox2.Text = TextBox2.Text & "ry" & TextBox4.Text
                    ElseIf outros.Text = AscW("ギ") Then
                        TextBox2.Text = TextBox2.Text & "gy" & TextBox4.Text
                    ElseIf outros.Text = AscW("ぎ") Then
                        TextBox2.Text = TextBox2.Text & "gy" & TextBox4.Text
                    ElseIf outros.Text = AscW("ジ") Then
                        TextBox2.Text = TextBox2.Text & "j" & TextBox4.Text
                    ElseIf outros.Text = AscW("じ") Then
                        TextBox2.Text = TextBox2.Text & "j" & TextBox4.Text
                    ElseIf outros.Text = AscW("ビ") Then
                        TextBox2.Text = TextBox2.Text & "by" & TextBox4.Text
                    ElseIf outros.Text = AscW("び") Then
                        TextBox2.Text = TextBox2.Text & "by" & TextBox4.Text
                    ElseIf outros.Text = AscW("ぴ") Then
                        TextBox2.Text = TextBox2.Text & "py" & TextBox4.Text
                    ElseIf outros.Text = AscW("ピ") Then
                        TextBox2.Text = TextBox2.Text & "py" & TextBox4.Text
                    End If

                    contagem = contagem - 1
                    contagem2 = contagem2 - 1
                    outros.Checked = False
                    outros.Text = ""





                ElseIf letra = AscW("ア") Then 'AscW("あ")
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "a"
                    Else
                        TextBox2.Text = TextBox2.Text & "a"
                    End If
                ElseIf letra = AscW("あ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "a"
                    Else
                        TextBox2.Text = TextBox2.Text & "a"
                    End If
                ElseIf letra = AscW("イ") Then '
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "i"
                    Else
                        TextBox2.Text = TextBox2.Text & "i"
                    End If
                ElseIf letra = AscW("い") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "i"
                    Else
                        TextBox2.Text = TextBox2.Text & "i"
                    End If
                ElseIf letra = AscW("う") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "u"
                    Else
                        TextBox2.Text = TextBox2.Text & "u"
                    End If
                ElseIf letra = AscW("ウ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "u"
                    Else
                        TextBox2.Text = TextBox2.Text & "u"
                    End If
                ElseIf letra = AscW("え") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "e"
                    Else
                        TextBox2.Text = TextBox2.Text & "e"
                    End If
                ElseIf letra = AscW("エ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "e"
                    Else
                        TextBox2.Text = TextBox2.Text & "e"
                    End If
                ElseIf letra = AscW("お") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "o"
                    Else
                        TextBox2.Text = TextBox2.Text & "o"
                    End If
                ElseIf letra = AscW("オ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "o"
                    Else
                        TextBox2.Text = TextBox2.Text & "o"
                    End If
                ElseIf letra = AscW("や") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ya"
                    Else
                        TextBox2.Text = TextBox2.Text & "ya"
                    End If
                ElseIf letra = AscW("ヤ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ya"
                    Else
                        TextBox2.Text = TextBox2.Text & "ya"
                    End If
                ElseIf letra = AscW("ゆ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "yu"
                    Else
                        TextBox2.Text = TextBox2.Text & "yu"
                    End If
                ElseIf letra = AscW("ユ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "yu"
                    Else
                        TextBox2.Text = TextBox2.Text & "yu"
                    End If
                ElseIf letra = AscW("よ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "yo"
                    Else
                        TextBox2.Text = TextBox2.Text & "yo"
                    End If
                ElseIf letra = AscW("ヨ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "yo"
                    Else
                        TextBox2.Text = TextBox2.Text & "yo"
                    End If
                ElseIf letra = AscW("カ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ka"
                    Else
                        TextBox2.Text = TextBox2.Text & "ka"
                    End If
                ElseIf letra = AscW("か") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ka"
                    Else
                        TextBox2.Text = TextBox2.Text & "ka"
                    End If
                ElseIf letra = AscW("き") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ki"
                    Else
                        TextBox2.Text = TextBox2.Text & "ki"
                    End If
                ElseIf letra = AscW("キ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ki"
                    Else
                        TextBox2.Text = TextBox2.Text & "ki"
                    End If
                ElseIf letra = AscW("ク") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ku"
                    Else
                        TextBox2.Text = TextBox2.Text & "ku"
                    End If
                ElseIf letra = AscW("く") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ku"
                    Else
                        TextBox2.Text = TextBox2.Text & "ku"
                    End If
                ElseIf letra = AscW("け") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ke"
                    Else
                        TextBox2.Text = TextBox2.Text & "ke"
                    End If
                ElseIf letra = AscW("ケ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ke"
                    Else
                        TextBox2.Text = TextBox2.Text & "ke"
                    End If
                ElseIf letra = AscW("こ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ko"
                    Else
                        TextBox2.Text = TextBox2.Text & "ko"
                    End If
                ElseIf letra = AscW("コ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ko"
                    Else
                        TextBox2.Text = TextBox2.Text & "ko"
                    End If
                ElseIf letra = AscW("わ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "wa"
                    Else
                        TextBox2.Text = TextBox2.Text & "wa"
                    End If
                ElseIf letra = AscW("ワ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "wa"
                    Else
                        TextBox2.Text = TextBox2.Text & "wa"
                    End If
                ElseIf letra = AscW("ヱ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "wi"
                    Else
                        TextBox2.Text = TextBox2.Text & "wi"
                    End If
                ElseIf letra = AscW("ゑ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "wi"
                    Else
                        TextBox2.Text = TextBox2.Text & "wi"
                    End If
                ElseIf letra = AscW("ゐ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "we"
                    Else
                        TextBox2.Text = TextBox2.Text & "we"
                    End If
                ElseIf letra = AscW("ヰ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "we"
                    Else
                        TextBox2.Text = TextBox2.Text & "we"
                    End If
                ElseIf letra = AscW("を") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "wo"
                    Else
                        TextBox2.Text = TextBox2.Text & "wo"
                    End If
                ElseIf letra = AscW("ヲ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "wo"
                    Else
                        TextBox2.Text = TextBox2.Text & "wo"
                    End If
                ElseIf letra = AscW("サ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "sa"
                    Else
                        TextBox2.Text = TextBox2.Text & "sa"
                    End If
                ElseIf letra = AscW("さ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "sa"
                    Else
                        TextBox2.Text = TextBox2.Text & "sa"
                    End If
                ElseIf letra = AscW("セ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "se"
                    Else
                        TextBox2.Text = TextBox2.Text & "se"
                    End If
                ElseIf letra = AscW("せ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "se"
                    Else
                        TextBox2.Text = TextBox2.Text & "se"
                    End If
                ElseIf letra = AscW("し") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "shi"
                    Else
                        TextBox2.Text = TextBox2.Text & "shi"
                    End If
                ElseIf letra = AscW("シ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "shi"
                    Else
                        TextBox2.Text = TextBox2.Text & "shi"
                    End If
                ElseIf letra = AscW("ス") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "su"
                    Else
                        TextBox2.Text = TextBox2.Text & "su"
                    End If
                ElseIf letra = AscW("す") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "su"
                    Else
                        TextBox2.Text = TextBox2.Text & "su"
                    End If
                ElseIf letra = AscW("ソ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "so"
                    Else
                        TextBox2.Text = TextBox2.Text & "so"
                    End If
                ElseIf letra = AscW("そ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "so"
                    Else
                        TextBox2.Text = TextBox2.Text & "so"
                    End If
                ElseIf letra = AscW("タ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ta"
                    Else
                        TextBox2.Text = TextBox2.Text & "ta"
                    End If
                ElseIf letra = AscW("た") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ta"
                    Else
                        TextBox2.Text = TextBox2.Text & "ta"
                    End If
                ElseIf letra = AscW("チ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "chi"
                    Else
                        TextBox2.Text = TextBox2.Text & "chi"
                    End If
                ElseIf letra = AscW("ち") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "chi"
                    Else
                        TextBox2.Text = TextBox2.Text & "chi"
                    End If
                ElseIf letra = AscW("ツ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "tsu"
                    Else
                        TextBox2.Text = TextBox2.Text & "tsu"
                    End If
                ElseIf letra = AscW("つ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "tsu"
                    Else
                        TextBox2.Text = TextBox2.Text & "tsu"
                    End If
                ElseIf letra = AscW("テ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "te"
                    Else
                        TextBox2.Text = TextBox2.Text & "te"
                    End If
                ElseIf letra = AscW("て") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "te"
                    Else
                        TextBox2.Text = TextBox2.Text & "te"
                    End If
                ElseIf letra = AscW("ト") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "to"
                    Else
                        TextBox2.Text = TextBox2.Text & "to"
                    End If
                ElseIf letra = AscW("と") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "to"
                    Else
                        TextBox2.Text = TextBox2.Text & "to"
                    End If
                ElseIf letra = AscW("ナ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "na"
                    Else
                        TextBox2.Text = TextBox2.Text & "na"
                    End If
                ElseIf letra = AscW("な") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "na"
                    Else
                        TextBox2.Text = TextBox2.Text & "na"
                    End If
                ElseIf letra = AscW("ニ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ni"
                    Else
                        TextBox2.Text = TextBox2.Text & "ni"
                    End If
                ElseIf letra = AscW("に") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ni"
                    Else
                        TextBox2.Text = TextBox2.Text & "ni"
                    End If
                ElseIf letra = AscW("ヌ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "nu"
                    Else
                        TextBox2.Text = TextBox2.Text & "nu"
                    End If
                ElseIf letra = AscW("ぬ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "nu"
                    Else
                        TextBox2.Text = TextBox2.Text & "nu"
                    End If
                ElseIf letra = AscW("ネ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ne"
                    Else
                        TextBox2.Text = TextBox2.Text & "ne"
                    End If
                ElseIf letra = AscW("ね") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ne"
                    Else
                        TextBox2.Text = TextBox2.Text & "ne"
                    End If
                ElseIf letra = AscW("の") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "no"
                    Else
                        TextBox2.Text = TextBox2.Text & "no"
                    End If
                ElseIf letra = AscW("ノ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "no"
                    Else
                        TextBox2.Text = TextBox2.Text & "no"
                    End If
                ElseIf letra = AscW("ハ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ha"
                    Else
                        TextBox2.Text = TextBox2.Text & "ha"
                    End If
                ElseIf letra = AscW("は") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ha"
                    Else
                        TextBox2.Text = TextBox2.Text & "ha"
                    End If
                ElseIf letra = AscW("ヒ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "hi"
                    Else
                        TextBox2.Text = TextBox2.Text & "hi"
                    End If
                ElseIf letra = AscW("ひ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "hi"
                    Else
                        TextBox2.Text = TextBox2.Text & "hi"
                    End If
                ElseIf letra = AscW("フ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "fu"
                    Else
                        TextBox2.Text = TextBox2.Text & "fu"
                    End If
                ElseIf letra = AscW("ふ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "fu"
                    Else
                        TextBox2.Text = TextBox2.Text & "fu"
                    End If
                ElseIf letra = AscW("ヘ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "he"
                    Else
                        TextBox2.Text = TextBox2.Text & "he"
                    End If
                ElseIf letra = AscW("へ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "he"
                    Else
                        TextBox2.Text = TextBox2.Text & "he"
                    End If
                ElseIf letra = AscW("ホ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ho"
                    Else
                        TextBox2.Text = TextBox2.Text & "ho"
                    End If
                ElseIf letra = AscW("ほ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ho"
                    Else
                        TextBox2.Text = TextBox2.Text & "ho"
                    End If
                ElseIf letra = AscW("マ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ma"
                    Else
                        TextBox2.Text = TextBox2.Text & "ma"
                    End If
                ElseIf letra = AscW("ま") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ma"
                    Else
                        TextBox2.Text = TextBox2.Text & "ma"
                    End If
                ElseIf letra = AscW("ミ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "mi"
                    Else
                        TextBox2.Text = TextBox2.Text & "mi"
                    End If
                ElseIf letra = AscW("み") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "mi"
                    Else
                        TextBox2.Text = TextBox2.Text & "mi"
                    End If
                ElseIf letra = AscW("ム") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "mu"
                    Else
                        TextBox2.Text = TextBox2.Text & "mu"
                    End If
                ElseIf letra = AscW("む") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "mu"
                    Else
                        TextBox2.Text = TextBox2.Text & "mu"
                    End If
                ElseIf letra = AscW("メ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "me"
                    Else
                        TextBox2.Text = TextBox2.Text & "me"
                    End If
                ElseIf letra = AscW("め") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "me"
                    Else
                        TextBox2.Text = TextBox2.Text & "me"
                    End If
                ElseIf letra = AscW("モ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "mo"
                    Else
                        TextBox2.Text = TextBox2.Text & "mo"
                    End If
                ElseIf letra = AscW("も") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "mo"
                    Else
                        TextBox2.Text = TextBox2.Text & "mo"
                    End If
                ElseIf letra = AscW("ン") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "n"
                    Else
                        TextBox2.Text = TextBox2.Text & "n"
                    End If
                ElseIf letra = AscW("ん") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "n"
                    Else
                        TextBox2.Text = TextBox2.Text & "n"
                    End If
                ElseIf letra = AscW("ラ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ra"
                    Else
                        TextBox2.Text = TextBox2.Text & "ra"
                    End If
                ElseIf letra = AscW("ら") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ra"
                    Else
                        TextBox2.Text = TextBox2.Text & "ra"
                    End If
                ElseIf letra = AscW("り") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ri"
                    Else
                        TextBox2.Text = TextBox2.Text & "ri"
                    End If
                ElseIf letra = AscW("リ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ri"
                    Else
                        TextBox2.Text = TextBox2.Text & "ri"
                    End If
                ElseIf letra = AscW("ル") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ru"
                    Else
                        TextBox2.Text = TextBox2.Text & "ru"
                    End If
                ElseIf letra = AscW("る") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ru"
                    Else
                        TextBox2.Text = TextBox2.Text & "ru"
                    End If
                ElseIf letra = AscW("レ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "re"
                    Else
                        TextBox2.Text = TextBox2.Text & "re"
                    End If
                ElseIf letra = AscW("れ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "re"
                    Else
                        TextBox2.Text = TextBox2.Text & "re"
                    End If
                ElseIf letra = AscW("ロ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ro"
                    Else
                        TextBox2.Text = TextBox2.Text & "ro"
                    End If
                ElseIf letra = AscW("ろ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ro"
                    Else
                        TextBox2.Text = TextBox2.Text & "ro"
                    End If
                ElseIf letra = AscW("ガ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ga"
                    Else
                        TextBox2.Text = TextBox2.Text & "ga"
                    End If
                ElseIf letra = AscW("が") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ga"
                    Else
                        TextBox2.Text = TextBox2.Text & "ga"
                    End If
                ElseIf letra = AscW("ゲ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ge"
                    Else
                        TextBox2.Text = TextBox2.Text & "ge"
                    End If
                ElseIf letra = AscW("げ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ge"
                    Else
                        TextBox2.Text = TextBox2.Text & "ge"
                    End If
                ElseIf letra = AscW("ぎ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "gi"
                    Else
                        TextBox2.Text = TextBox2.Text & "gi"
                    End If
                ElseIf letra = AscW("ギ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "gi"
                    Else
                        TextBox2.Text = TextBox2.Text & "gi"
                    End If
                ElseIf letra = AscW("ご") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "go"
                    Else
                        TextBox2.Text = TextBox2.Text & "go"
                    End If
                ElseIf letra = AscW("ゴ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "go"
                    Else
                        TextBox2.Text = TextBox2.Text & "go"
                    End If
                ElseIf letra = AscW("ぐ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "gu"
                    Else
                        TextBox2.Text = TextBox2.Text & "gu"
                    End If
                ElseIf letra = AscW("グ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "gu"
                    Else
                        TextBox2.Text = TextBox2.Text & "gu"
                    End If
                ElseIf letra = AscW("ザ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "za"
                    Else
                        TextBox2.Text = TextBox2.Text & "za"
                    End If
                ElseIf letra = AscW("ざ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "za"
                    Else
                        TextBox2.Text = TextBox2.Text & "za"
                    End If
                ElseIf letra = AscW("ゼ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ze"
                    Else
                        TextBox2.Text = TextBox2.Text & "ze"
                    End If
                ElseIf letra = AscW("ぜ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ze"
                    Else
                        TextBox2.Text = TextBox2.Text & "ze"
                    End If
                ElseIf letra = AscW("ズ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "zu"
                    Else
                        TextBox2.Text = TextBox2.Text & "zu"
                    End If
                ElseIf letra = AscW("ず") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "zu"
                    Else
                        TextBox2.Text = TextBox2.Text & "zu"
                    End If
                ElseIf letra = AscW("ゾ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "zo"
                    Else
                        TextBox2.Text = TextBox2.Text & "zo"
                    End If
                ElseIf letra = AscW("ぞ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "zo"
                    Else
                        TextBox2.Text = TextBox2.Text & "zo"
                    End If
                ElseIf letra = AscW("ダ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "da"
                    Else
                        TextBox2.Text = TextBox2.Text & "da"
                    End If
                ElseIf letra = AscW("だ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "da"
                    Else
                        TextBox2.Text = TextBox2.Text & "da"
                    End If
                ElseIf letra = AscW("じ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ji"
                    Else
                        TextBox2.Text = TextBox2.Text & "ji"
                    End If
                ElseIf letra = AscW("ジ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ji"
                    Else
                        TextBox2.Text = TextBox2.Text & "ji"
                    End If
                ElseIf letra = AscW("ヅ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "dzu"
                    Else
                        TextBox2.Text = TextBox2.Text & "dzu"
                    End If
                ElseIf letra = AscW("づ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "dzu"
                    Else
                        TextBox2.Text = TextBox2.Text & "dzu"
                    End If
                ElseIf letra = AscW("で") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "de"
                    Else
                        TextBox2.Text = TextBox2.Text & "de"
                    End If
                ElseIf letra = AscW("デ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "de"
                    Else
                        TextBox2.Text = TextBox2.Text & "de"
                    End If
                ElseIf letra = AscW("ド") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "do"
                    Else
                        TextBox2.Text = TextBox2.Text & "do"
                    End If
                ElseIf letra = AscW("ど") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "do"
                    Else
                        TextBox2.Text = TextBox2.Text & "do"
                    End If
                ElseIf letra = AscW("バ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ba"
                    Else
                        TextBox2.Text = TextBox2.Text & "ba"
                    End If
                ElseIf letra = AscW("ば") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "ba"
                    Else
                        TextBox2.Text = TextBox2.Text & "ba"
                    End If
                ElseIf letra = AscW("び") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "bi"
                    Else
                        TextBox2.Text = TextBox2.Text & "bi"
                    End If
                ElseIf letra = AscW("ビ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "bi"
                    Else
                        TextBox2.Text = TextBox2.Text & "bi"
                    End If
                ElseIf letra = AscW("ブ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "bu"
                    Else
                        TextBox2.Text = TextBox2.Text & "bu"
                    End If
                ElseIf letra = AscW("ぶ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "bu"
                    Else
                        TextBox2.Text = TextBox2.Text & "bu"
                    End If
                ElseIf letra = AscW("べ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "be"
                    Else
                        TextBox2.Text = TextBox2.Text & "be"
                    End If
                ElseIf letra = AscW("ベ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "be"
                    Else
                        TextBox2.Text = TextBox2.Text & "be"
                    End If
                ElseIf letra = AscW("ボ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "bo"
                    Else
                        TextBox2.Text = TextBox2.Text & "bo"
                    End If
                ElseIf letra = AscW("ぼ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "bo"
                    Else
                        TextBox2.Text = TextBox2.Text & "bo"
                    End If
                ElseIf letra = AscW("ぱ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pa"
                    Else
                        TextBox2.Text = TextBox2.Text & "pa"
                    End If
                ElseIf letra = AscW("パ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pa"
                    Else
                        TextBox2.Text = TextBox2.Text & "pa"
                    End If
                ElseIf letra = AscW("ピ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pi"
                    Else
                        TextBox2.Text = TextBox2.Text & "pi"
                    End If
                ElseIf letra = AscW("ぴ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pi"
                    Else
                        TextBox2.Text = TextBox2.Text & "pi"
                    End If
                ElseIf letra = AscW("プ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pu"
                    Else
                        TextBox2.Text = TextBox2.Text & "pu"
                    End If
                ElseIf letra = AscW("ぷ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pu"
                    Else
                        TextBox2.Text = TextBox2.Text & "pu"
                    End If
                ElseIf letra = AscW("ペ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pe"
                    Else
                        TextBox2.Text = TextBox2.Text & "pe"
                    End If
                ElseIf letra = AscW("ぺ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "pe"
                    Else
                        TextBox2.Text = TextBox2.Text & "pe"
                    End If
                ElseIf letra = AscW("ぽ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "po"
                    Else
                        TextBox2.Text = TextBox2.Text & "po"
                    End If
                ElseIf letra = AscW("ポ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "po"
                    Else
                        TextBox2.Text = TextBox2.Text & "po"
                    End If
                ElseIf letra = AscW("ぽ") Then
                    If tsucheck.Checked = True Then
                        TextBox3.Text = "po"
                    Else
                        TextBox2.Text = TextBox2.Text & "po"
                    End If
                ElseIf letra = AscW("っ") Then
                    tsucheck.Checked = True
                ElseIf letra = AscW("ッ") Then
                    tsucheck.Checked = True


                ElseIf letra = AscW("。") Then
                    TextBox2.Text = TextBox2.Text & "."
                ElseIf letra = AscW("《") Then
                    TextBox2.Text = TextBox2.Text & "<"
                ElseIf letra = AscW("》") Then
                    TextBox2.Text = TextBox2.Text & ">"
                ElseIf letra = AscW("『") Then
                    TextBox2.Text = TextBox2.Text & "["
                ElseIf letra = AscW("』") Then
                    TextBox2.Text = TextBox2.Text & "]"
                ElseIf letra = AscW("【") Then
                    TextBox2.Text = TextBox2.Text & "{"
                ElseIf letra = AscW("】") Then
                    TextBox2.Text = TextBox2.Text & "}"
                ElseIf letra = AscW("ー") Then
                    'TextBox2.Text = TextBox2.Text & "-"
                    Dim prolongamento As String
                    prolongamento = Mid(TextBox2.Text, Len(TextBox2.Text), Len(TextBox2.Text))
                    TextBox2.Text = TextBox2.Text & prolongamento
                ElseIf letra = AscW("！") Then
                    TextBox2.Text = TextBox2.Text & "!"
                ElseIf letra = AscW("？") Then
                    TextBox2.Text = TextBox2.Text & "?"


                ElseIf letra = AscW("ャ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    outros.Checked = True
                    TextBox4.Text = "a"
                ElseIf letra = AscW("ゃ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "a"
                    outros.Checked = True

                ElseIf letra = AscW("ュ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "u"
                    outros.Checked = True
                ElseIf letra = AscW("ゅ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "u"
                    outros.Checked = True

                ElseIf letra = AscW("ョ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "o"
                    outros.Checked = True
                ElseIf letra = AscW("ょ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "o"
                    outros.Checked = True

                ElseIf letra = AscW("ァ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "a"
                    outros.Checked = True
                ElseIf letra = AscW("ぁ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "a"
                    outros.Checked = True

                ElseIf letra = AscW("ィ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "i"
                    outros.Checked = True
                ElseIf letra = AscW("ぃ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "i"
                    outros.Checked = True

                ElseIf letra = AscW("ェ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "e"
                    outros.Checked = True
                ElseIf letra = AscW("ぇ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "e"
                    outros.Checked = True

                ElseIf letra = AscW("ォ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "o"
                    outros.Checked = True
                ElseIf letra = AscW("ぉ") Then
                    outrasletras = Mid(TextBox1.Text, contagem - 1, contagem2 - 1)
                    outros.Text = AscW(outrasletras)
                    TextBox4.Text = "o"
                    outros.Checked = True

                Else
                    TextBox2.Text = TextBox2.Text & ChrW(letra)
                End If
                contagem = contagem + 1
                contagem2 = contagem2 + 1
            Loop
        Else
            MsgBox("Primeiro cole o texto!", MsgBoxStyle.OkOnly, "JapaneseWay")
        End If
        Exit Sub
fim:
        MsgBox("Houve um erro na tradução do nome.", MsgBoxStyle.Critical, "JapaneseWay")
    End Sub

    Private Sub Form25_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu25 = False
    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu25 = True
    End Sub

    Private Sub InstalarFontesJaponesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalarFontesJaponesasToolStripMenuItem.Click
        Form21.Show()
        Form21.Focus()
        Form21.WindowState = FormWindowState.Normal
        Close()
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
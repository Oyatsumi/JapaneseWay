Public Class Form24
    Dim prolongamento As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TabControl1.Height = (Height - 123)
        TabControl1.Width = (Width - 35)
        TextBox1.Height = (TabControl1.Height - 30)
        TextBox1.Width = (TabControl1.Width - 11)
        TextBox2.Height = (TabControl1.Height - 30)
        TextBox2.Width = (TabControl1.Width - 11)
        PictureBox1.Location = New Size(7, Height - 71)
        Label2.Location = New Size(13, Height - 64)
        Label6.Location = New Size(144, Height - 71)
        Label7.Location = New Size(159, Height - 73)


    End Sub

    Private Sub TextBox1_Enter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter

    End Sub



    Public Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If Label2.Text <> "" Then
            If e.KeyChar = Chr(8) Then 'backspace
                e.KeyChar = ""
                Label2.Text = ""
            End If
            If e.KeyChar = Chr(13) Then 'enter
                TextBox1.Text = TextBox1.Text & Label2.Text
                TextBox1.SelectionStart = TextBox1.Text.Length
                Label2.Text = ""
                e.KeyChar = Chr(0)
            End If
        End If


        If Len(Label2.Text) >= 16 Then
            MsgBox("Você não pode usar mais caracteres!", MsgBoxStyle.Critical, "JapaneseWay")
            Label2.Text = ""
        End If

        'If e.KeyChar = Chr(13) Then
        'e.KeyChar = Chr(0) 'barulho
        'End If

        If e.KeyChar = Chr(1) Then 'ctrl a
            TextBox1.SelectAll()
        End If

        If e.KeyChar <> Chr(8) Then 'backspace
            If e.KeyChar <> Chr(13) Then 'enter
                If e.KeyChar <> Chr(32) Then 'espaço
                    If e.KeyChar <> Chr(3) Then 'ctrl c
                        If e.KeyChar <> Chr(22) Then 'ctrl v
                            If e.KeyChar <> Chr(1) Then 'ctrl a
                                If e.KeyChar <> Chr(24) Then 'ctrl x
                                    If e.KeyChar = LCase(e.KeyChar) Then
                                        'PROLONGAMENTO

                                        'e.Handled = True
                                        Label2.Text = Label2.Text & e.KeyChar
                                        'Label2.Text = Label2.Text & LCase(e.KeyChar)
                                        'SendKeys.Send("Enter")


                                        e.KeyChar = Chr(3)

                                    Else
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


       


        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS


        If Label2.Text = "nn" Then
            e.KeyChar = "ン"
            Label2.Text = ""
            prolongamento = "nn"
        ElseIf Label2.Text Like "n[b-d]" = True Then
            e.KeyChar = "ン"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[f-h]" = True Then
            e.KeyChar = "ン"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[j-n]" = True Then
            e.KeyChar = "ン"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[p-t]" = True Then
            e.KeyChar = "ン"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[v-z]" = True Then
            e.KeyChar = "ン"
            Label2.Text = Mid(Label2.Text, 2)

        ElseIf Label2.Text = "bb" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "cc" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "dd" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "ff" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "gg" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "hh" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "jj" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "kk" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "pp" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "rr" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "ss" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "vv" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "tt" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "xx" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "zz" Then
            e.KeyChar = "ッ"
            Label2.Text = Mid(Label2.Text, 2)

        ElseIf Label2.Text = "." Then
            e.KeyChar = "。"
            Label2.Text = ""
        ElseIf Label2.Text = ";" Then
            e.KeyChar = "・"
            Label2.Text = ""
        ElseIf Label2.Text = "<" Then
            e.KeyChar = "《"
            Label2.Text = ""
        ElseIf Label2.Text = ">" Then
            e.KeyChar = "》"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "[" Then
            e.KeyChar = "『"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "]" Then
            e.KeyChar = "』"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "{" Then
            e.KeyChar = "【"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "}" Then
            e.KeyChar = "】"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "-" Then
            e.KeyChar = "ー"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "!" Then
            e.KeyChar = "！"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "?" Then
            e.KeyChar = "？"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length

        ElseIf Label2.Text = """" Then
            If aspas.Checked = False Then
                e.KeyChar = "「"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = True
            Else
                e.KeyChar = "」"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = False
            End If

        ElseIf Label2.Text = "'" Then
            If aspas.Checked = False Then
                e.KeyChar = "「"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = True
            Else
                e.KeyChar = "」"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = False
            End If



            'SILABAS
            'SILABAS
            'SILABAS
            'SILABAS
            'novos

        ElseIf Label2.Text = "ャ" Then
            e.KeyChar = "ャ"
            Label2.Text = ""
        ElseIf Label2.Text = "kya" Then
            e.KeyChar = "キ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "kya"
        ElseIf Label2.Text = "sha" Then
            e.KeyChar = "シ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "sha"
        ElseIf Label2.Text = "cha" Then
            e.KeyChar = "チ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "cha"
        ElseIf Label2.Text = "nya" Then
            e.KeyChar = "ニ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "nya"
        ElseIf Label2.Text = "hya" Then
            e.KeyChar = "ヒ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "hya"
        ElseIf Label2.Text = "mya" Then
            e.KeyChar = "ミ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "mya"
        ElseIf Label2.Text = "rya" Then
            e.KeyChar = "リ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "rya"
        ElseIf Label2.Text = "gya" Then
            e.KeyChar = "ギ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "gya"
        ElseIf Label2.Text = "ja" Then
            e.KeyChar = "ジ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "ja"
        ElseIf Label2.Text = "jya" Then
            e.KeyChar = "ジ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "jya"
        ElseIf Label2.Text = "bya" Then
            e.KeyChar = "ビ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "bya"
        ElseIf Label2.Text = "pya" Then
            e.KeyChar = "ピ"
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "pya"

        ElseIf Label2.Text = "ュ" Then
            e.KeyChar = "ュ"
            Label2.Text = ""


        ElseIf Label2.Text = "kyu" Then
            e.KeyChar = "キ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "kyu"
        ElseIf Label2.Text = "shu" Then
            e.KeyChar = "シ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "shu"
        ElseIf Label2.Text = "chu" Then
            e.KeyChar = "チ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "chu"
        ElseIf Label2.Text = "nyu" Then
            e.KeyChar = "ニ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "nyu"
        ElseIf Label2.Text = "myu" Then
            e.KeyChar = "ミ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "myu"
        ElseIf Label2.Text = "hyu" Then
            e.KeyChar = "ヒ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "hyu"
        ElseIf Label2.Text = "ryu" Then
            e.KeyChar = "リ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "ryu"
        ElseIf Label2.Text = "gyu" Then
            e.KeyChar = "ギ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "gyu"
        ElseIf Label2.Text = "ju" Then
            e.KeyChar = "ジ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "ju"
        ElseIf Label2.Text = "jyu" Then
            e.KeyChar = "ジ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "jyu"
        ElseIf Label2.Text = "byu" Then
            e.KeyChar = "ビ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "byu"
        ElseIf Label2.Text = "pyu" Then
            e.KeyChar = "ピ"
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "pyu"
        ElseIf Label2.Text = "ョ" Then
            e.KeyChar = "ョ"
            Label2.Text = ""

        ElseIf Label2.Text = "kyo" Then
            e.KeyChar = "キ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "kyo"
        ElseIf Label2.Text = "sho" Then
            e.KeyChar = "シ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "sho"
        ElseIf Label2.Text = "cho" Then
            e.KeyChar = "チ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "cho"
        ElseIf Label2.Text = "nyo" Then
            e.KeyChar = "ニ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "nyo"
        ElseIf Label2.Text = "hyo" Then
            e.KeyChar = "ヒ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "hyo"
        ElseIf Label2.Text = "myo" Then
            e.KeyChar = "ミ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "myo"
        ElseIf Label2.Text = "ryo" Then
            e.KeyChar = "リ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "ryo"
        ElseIf Label2.Text = "gyo" Then
            e.KeyChar = "ギ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "gyo"
        ElseIf Label2.Text = "jo" Then
            e.KeyChar = "ジ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "jo"
        ElseIf Label2.Text = "jyo" Then
            e.KeyChar = "ジ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "jyo"
        ElseIf Label2.Text = "byo" Then
            e.KeyChar = "ビ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "byo"
        ElseIf Label2.Text = "pyo" Then
            e.KeyChar = "ピ"
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "pyo"
        ElseIf Label2.Text = "ァ" Then
            e.KeyChar = "ァ"
            Label2.Text = ""
        ElseIf Label2.Text = "ェ" Then
            e.KeyChar = "ェ"
            Label2.Text = ""
        ElseIf Label2.Text = "ィ" Then
            e.KeyChar = "ィ"
            Label2.Text = ""
        ElseIf Label2.Text = "ォ" Then
            e.KeyChar = "ォ"
            Label2.Text = ""


        ElseIf Label2.Text = "she" Then
            e.KeyChar = "シ"
            SendKeys.Send("ェ")
            Label2.Text = ""
            prolongamento = "she"
        ElseIf Label2.Text = "che" Then
            e.KeyChar = "チ"
            SendKeys.Send("ェ")
            Label2.Text = ""
            prolongamento = "che"
        ElseIf Label2.Text = "va" Then
            e.KeyChar = "ヴ"
            SendKeys.Send("ァ")
            Label2.Text = ""
            prolongamento = "va"
        ElseIf Label2.Text = "ve" Then
            e.KeyChar = "ヴ"
            SendKeys.Send("ェ")
            Label2.Text = ""
            prolongamento = "ve"
        ElseIf Label2.Text = "vi" Then
            e.KeyChar = "ヴ"
            SendKeys.Send("ィ")
            Label2.Text = ""
            prolongamento = "vi"
        ElseIf Label2.Text = "vo" Then
            e.KeyChar = "ヴ"
            SendKeys.Send("ォ")
            Label2.Text = ""
            prolongamento = "vo"
        ElseIf Label2.Text = "vu" Then
            e.KeyChar = "ヴ"
            Label2.Text = ""
            prolongamento = "vu"
        ElseIf Label2.Text = "fa" Then
            e.KeyChar = "フ"
            SendKeys.Send("ァ")
            Label2.Text = ""
        ElseIf Label2.Text = "fe" Then
            e.KeyChar = "フ"
            SendKeys.Send("ェ")
            Label2.Text = ""
            prolongamento = "fe"
        ElseIf Label2.Text = "fi" Then
            e.KeyChar = "フ"
            SendKeys.Send("ィ")
            Label2.Text = ""
            prolongamento = "fi"
        ElseIf Label2.Text = "fo" Then
            e.KeyChar = "フ"
            SendKeys.Send("ォ")
            Label2.Text = ""
            prolongamento = "fo"
        ElseIf Label2.Text = "ッ" Then
            e.KeyChar = "ッ"
            Label2.Text = ""


            'TSU
            'TSU

        ElseIf Label2.Text = "ttt" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "ttt"
        ElseIf Label2.Text = "kkk" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "kkk"
        ElseIf Label2.Text = "bbb" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "bbb"
        ElseIf Label2.Text = "cc" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "cc"
        ElseIf Label2.Text = "ddd" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "ddd"
        ElseIf Label2.Text = "ppp" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "ppp"
        ElseIf Label2.Text = "jjj" Then
            e.KeyChar = "ッ"
            Label2.Text = ""
            prolongamento = "jjj"
        ElseIf Label2.Text = "tta" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ta")
            Label2.Text = ""
            prolongamento = "tta"
        ElseIf Label2.Text = "tte" Then
            e.KeyChar = "ッ"
            SendKeys.Send("te")
            Label2.Text = ""
            prolongamento = "tte"
        ElseIf Label2.Text = "tti" Then
            e.KeyChar = "ッ"
            SendKeys.Send("chi")
            Label2.Text = ""
            prolongamento = "tti"
        ElseIf Label2.Text = "cchi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("chi")
            Label2.Text = ""
            prolongamento = "tti"
        ElseIf Label2.Text = "tto" Then
            e.KeyChar = "ッ"
            SendKeys.Send("to")
            Label2.Text = ""
            prolongamento = "tto"
        ElseIf Label2.Text = "ttu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("tsu")
            Label2.Text = ""
            prolongamento = "ttu"
        ElseIf Label2.Text = "kka" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ka")
            Label2.Text = ""
            prolongamento = "kka"
        ElseIf Label2.Text = "kke" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ke")
            Label2.Text = ""
            prolongamento = "kke"
        ElseIf Label2.Text = "kki" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ki")
            Label2.Text = ""
            prolongamento = "kki"
        ElseIf Label2.Text = "kko" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ko")
            Label2.Text = ""
            prolongamento = "kko"
        ElseIf Label2.Text = "kku" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ku")
            Label2.Text = ""
            prolongamento = "kku"
        ElseIf Label2.Text = "bba" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ba")
            Label2.Text = ""
            prolongamento = "bba"
        ElseIf Label2.Text = "bbe" Then
            e.KeyChar = "ッ"
            SendKeys.Send("be")
            Label2.Text = ""
            prolongamento = "bbe"
        ElseIf Label2.Text = "bbi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("bi")
            Label2.Text = ""
            prolongamento = "bbi"
        ElseIf Label2.Text = "bbo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("bo")
            Label2.Text = ""
            prolongamento = "bbo"
        ElseIf Label2.Text = "bbu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("bu")
            Label2.Text = ""
            prolongamento = "bbu"
        ElseIf Label2.Text = "ppa" Then
            e.KeyChar = "ッ"
            SendKeys.Send("pa")
            Label2.Text = ""
            prolongamento = "ppa"
        ElseIf Label2.Text = "ppe" Then
            e.KeyChar = "ッ"
            SendKeys.Send("pe")
            Label2.Text = ""
            prolongamento = "ppe"
        ElseIf Label2.Text = "ppi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("pi")
            Label2.Text = ""
            prolongamento = "ppi"
        ElseIf Label2.Text = "ppo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("po")
            Label2.Text = ""
            prolongamento = "ppo"
        ElseIf Label2.Text = "ppu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("pu")
            Label2.Text = ""
            prolongamento = "ppu"
        ElseIf Label2.Text = "jja" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "jja"
        ElseIf Label2.Text = "jjya" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            SendKeys.Send("ャ")
            Label2.Text = ""
            prolongamento = "jjya"
        ElseIf Label2.Text = "jje" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            SendKeys.Send("ェ")
            Label2.Text = ""
            prolongamento = "jje"
        ElseIf Label2.Text = "jji" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            Label2.Text = ""
            prolongamento = "jji"
        ElseIf Label2.Text = "jjo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            SendKeys.Send("ョ")
            Label2.Text = ""
            prolongamento = "jjo"
        ElseIf Label2.Text = "jju" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            SendKeys.Send("ュ")
            Label2.Text = ""
            prolongamento = "jju"
        ElseIf Label2.Text = "dda" Then
            e.KeyChar = "ッ"
            SendKeys.Send("da")
            Label2.Text = ""
            prolongamento = "dda"
        ElseIf Label2.Text = "dde" Then
            e.KeyChar = "ッ"
            SendKeys.Send("de")
            Label2.Text = ""
            prolongamento = "dde"
        ElseIf Label2.Text = "ddi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dji")
            SendKeys.Send("ィ")
            Label2.Text = ""
            prolongamento = "ddi"
        ElseIf Label2.Text = "ddo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("do")
            Label2.Text = ""
            prolongamento = "ddo"
        ElseIf Label2.Text = "ddu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("dzu")
            Label2.Text = ""
            prolongamento = "ddu"
        ElseIf Label2.Text = "ffa" Then
            e.KeyChar = "ッ"
            SendKeys.Send("fa")
            Label2.Text = ""
            prolongamento = "ffa"
        ElseIf Label2.Text = "ffe" Then
            e.KeyChar = "ッ"
            SendKeys.Send("fe")
            Label2.Text = ""
            prolongamento = "ffe"
        ElseIf Label2.Text = "ffi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("fi")
            Label2.Text = ""
            prolongamento = "ffi"
        ElseIf Label2.Text = "ffo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("fo")
            Label2.Text = ""
            prolongamento = "ffo"
        ElseIf Label2.Text = "ffu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("fu")
            Label2.Text = ""
            prolongamento = "ffu"
        ElseIf Label2.Text = "gga" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ga")
            Label2.Text = ""
            prolongamento = "gga"
        ElseIf Label2.Text = "gge" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ge")
            Label2.Text = ""
            prolongamento = "gge"
        ElseIf Label2.Text = "ggi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("gi")
            Label2.Text = ""
            prolongamento = "ggi"
        ElseIf Label2.Text = "ggo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("go")
            Label2.Text = ""
            prolongamento = "goo"
        ElseIf Label2.Text = "ggu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("gu")
            Label2.Text = ""
            prolongamento = "ggu"
        ElseIf Label2.Text = "hha" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ha")
            Label2.Text = ""
            prolongamento = "hha"
        ElseIf Label2.Text = "hhe" Then
            e.KeyChar = "ッ"
            SendKeys.Send("he")
            Label2.Text = ""
            prolongamento = "hhe"
        ElseIf Label2.Text = "hhi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("hi")
            Label2.Text = ""
            prolongamento = "hhi"
        ElseIf Label2.Text = "hho" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ho")
            Label2.Text = ""
            prolongamento = "hho"
        ElseIf Label2.Text = "hhu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("hu")
            Label2.Text = ""
            prolongamento = "hhu"
        ElseIf Label2.Text = "rra" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ra")
            Label2.Text = ""
            prolongamento = "rra"
        ElseIf Label2.Text = "rre" Then
            e.KeyChar = "ッ"
            SendKeys.Send("re")
            Label2.Text = ""
            prolongamento = "rre"
        ElseIf Label2.Text = "rri" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ri")
            Label2.Text = ""
            prolongamento = "rri"
        ElseIf Label2.Text = "rro" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ro")
            Label2.Text = ""
            prolongamento = "rro"
        ElseIf Label2.Text = "rru" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ru")
            Label2.Text = ""
            prolongamento = "rru"
        ElseIf Label2.Text = "ssa" Then
            e.KeyChar = "ッ"
            SendKeys.Send("sa")
            Label2.Text = ""
            prolongamento = "ssa"
        ElseIf Label2.Text = "sse" Then
            e.KeyChar = "ッ"
            SendKeys.Send("se")
            Label2.Text = ""
            prolongamento = "sse"
        ElseIf Label2.Text = "ssi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("shi")
            Label2.Text = ""
            prolongamento = "ssi"
        ElseIf Label2.Text = "sso" Then
            e.KeyChar = "ッ"
            SendKeys.Send("so")
            Label2.Text = ""
            prolongamento = "sso"
        ElseIf Label2.Text = "ssu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("su")
            Label2.Text = ""
            prolongamento = "ssu"
        ElseIf Label2.Text = "vva" Then
            e.KeyChar = "ッ"
            SendKeys.Send("va")
            Label2.Text = ""
            prolongamento = "vva"
        ElseIf Label2.Text = "vve" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ve")
            Label2.Text = ""
            prolongamento = "vve"
        ElseIf Label2.Text = "vvi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("vi")
            Label2.Text = ""
            prolongamento = "vvi"
        ElseIf Label2.Text = "vvo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("vo")
            Label2.Text = ""
            prolongamento = "vvo"
        ElseIf Label2.Text = "vvu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("vu")
            Label2.Text = ""
            prolongamento = "vvu"
        ElseIf Label2.Text = "wwa" Then
            e.KeyChar = "ッ"
            SendKeys.Send("wa")
            Label2.Text = ""
            prolongamento = "wwa"
        ElseIf Label2.Text = "wwe" Then
            e.KeyChar = "ッ"
            SendKeys.Send("we")
            Label2.Text = ""
            prolongamento = "wwe"
        ElseIf Label2.Text = "wwi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("wi")
            Label2.Text = ""
            prolongamento = "wwe"
        ElseIf Label2.Text = "wwo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("wo")
            Label2.Text = ""
            prolongamento = "wwo"
        ElseIf Label2.Text = "xxa" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ァ")
            Label2.Text = ""
            prolongamento = "xxa"
        ElseIf Label2.Text = "xxe" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ェ")
            Label2.Text = ""
            prolongamento = "xxe"
        ElseIf Label2.Text = "xxi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ィ")
            Label2.Text = ""
            prolongamento = "xxi"
        ElseIf Label2.Text = "zza" Then
            e.KeyChar = "ッ"
            SendKeys.Send("za")
            Label2.Text = ""
            prolongamento = "zza"
        ElseIf Label2.Text = "zze" Then
            e.KeyChar = "ッ"
            SendKeys.Send("ze")
            Label2.Text = ""
            prolongamento = "zze"
        ElseIf Label2.Text = "zzi" Then
            e.KeyChar = "ッ"
            SendKeys.Send("zi")
            Label2.Text = ""
            prolongamento = "zzi"
        ElseIf Label2.Text = "zzo" Then
            e.KeyChar = "ッ"
            SendKeys.Send("zo")
            Label2.Text = ""
            prolongamento = "zzo"
        ElseIf Label2.Text = "zzu" Then
            e.KeyChar = "ッ"
            SendKeys.Send("zu")
            Label2.Text = ""
            prolongamento = "zzu"
        ElseIf Label2.Text = "zi" Then
            e.KeyChar = "ズ"
            SendKeys.Send("ィ")
            Label2.Text = ""
            prolongamento = "zi"
            'novos





        ElseIf Label2.Text = "we" Then
            e.KeyChar = "ヱ"
            Label2.Text = ""
            prolongamento = "we"
        ElseIf Label2.Text = "wi" Then
            e.KeyChar = "ヰ"
            Label2.Text = ""
            prolongamento = "wi"
        ElseIf Label2.Text = "a" Then

            ' If prolongamento Like "***a" = True Then
            ' e.KeyChar = "ー"
            'Label2.Text = ""
            'prolongamento = ""
            ' Else
            'e.KeyChar = "ア"
            'Label2.Text = ""
            'prolongamento = "a"
            'End If
            e.KeyChar = "ア"
            Label2.Text = ""
            prolongamento = "a"



            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "e" Then

            'If prolongamento Like "***e" = True Then
            'e.KeyChar = "ー"
            ' Label2.Text = ""
            'prolongamento = ""
            ' Else
            ' e.KeyChar = "エ"
            'Label2.Text = ""
            ' prolongamento = "e"
            'End If
            e.KeyChar = "エ"
            Label2.Text = ""
            prolongamento = "e"


            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "i" Then


            'If prolongamento Like "***i" = True Then
            ' e.KeyChar = "ー"
            'Label2.Text = ""
            ' prolongamento = ""
            ' Else
            '  e.KeyChar = "イ"
            ' Label2.Text = ""
            ' prolongamento = "i"
            'End If
            e.KeyChar = "イ"
            Label2.Text = ""
            prolongamento = "i"


            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "o" Then

            ' If prolongamento Like "***o" = True Then
            ' e.KeyChar = "ー"
            'Label2.Text = ""
            'prolongamento = ""
            ' Else
            ' e.KeyChar = "オ"
            ' Label2.Text = ""
            ' prolongamento = "o"
            'End If
            e.KeyChar = "オ"
            Label2.Text = ""
            prolongamento = "o"



            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "u" Then

            'If prolongamento Like "***u" = True Then
            'e.KeyChar = "ー"
            'Label2.Text = ""
            ' prolongamento = ""
            ' Else
            'e.KeyChar = "ウ"
            'Label2.Text = ""
            'prolongamento = "u"
            'End If

            e.KeyChar = "ウ"
            Label2.Text = ""
            prolongamento = "u"

            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ba" Then
            e.KeyChar = "バ"
            Label2.Text = ""
            prolongamento = "ba"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "be" Then
            e.KeyChar = "ベ"
            Label2.Text = ""
            prolongamento = "be"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "bi" Then
            e.KeyChar = "ビ"
            Label2.Text = ""
            prolongamento = "bi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "bo" Then
            e.KeyChar = "ボ"
            Label2.Text = ""
            prolongamento = "bo"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "bu" Then
            e.KeyChar = "ブ"
            Label2.Text = ""
            prolongamento = "bu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "chi" Then
            e.KeyChar = "チ"
            Label2.Text = ""
            prolongamento = "chi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ti" Then
            e.KeyChar = "チ"
            Label2.Text = ""
            prolongamento = "ti"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "da" Then
            e.KeyChar = "ダ"
            Label2.Text = ""
            prolongamento = "da"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "de" Then
            e.KeyChar = "デ"
            Label2.Text = ""
            prolongamento = "de"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "dji" Then
            e.KeyChar = "ヂ"
            Label2.Text = ""
            prolongamento = "dji"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "do" Then
            e.KeyChar = "ド"
            Label2.Text = ""
            prolongamento = "do"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "dzu" Then
            e.KeyChar = "ヅ"
            Label2.Text = ""
            prolongamento = "dzu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ga" Then
            e.KeyChar = "ガ"
            Label2.Text = ""
            prolongamento = "ga"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ge" Then
            e.KeyChar = "ゲ"
            Label2.Text = ""
            prolongamento = "ge"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "gi" Then
            e.KeyChar = "ギ"
            Label2.Text = ""
            prolongamento = "gi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "go" Then
            e.KeyChar = "ゴ"
            Label2.Text = ""
            prolongamento = "go"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "gu" Then
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
            e.KeyChar = "グ"
            prolongamento = "gu"
        ElseIf Label2.Text = "ha" Then
            e.KeyChar = "ハ"
            Label2.Text = ""
            prolongamento = "ha"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "he" Then
            e.KeyChar = "ヘ"
            Label2.Text = ""
            prolongamento = "he"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "hi" Then
            e.KeyChar = "ヒ"
            Label2.Text = ""
            prolongamento = "hi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ho" Then
            e.KeyChar = "ホ"
            Label2.Text = ""
            prolongamento = "ho"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ji" Then
            e.KeyChar = "ジ"
            Label2.Text = ""
            prolongamento = "ji"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ka" Then
            e.KeyChar = "カ"
            Label2.Text = ""
            prolongamento = "ka"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ke" Then
            e.KeyChar = "ケ"
            Label2.Text = ""
            prolongamento = "ke"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ki" Then
            e.KeyChar = "キ"
            Label2.Text = ""
            prolongamento = "ki"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ko" Then
            e.KeyChar = "コ"
            Label2.Text = ""
            prolongamento = "ko"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ku" Then
            e.KeyChar = "ク"
            Label2.Text = ""
            prolongamento = "ku"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ma" Then
            e.KeyChar = "マ"
            Label2.Text = ""
            prolongamento = "ma"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "me" Then
            e.KeyChar = "メ"
            Label2.Text = ""
            prolongamento = "me"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mi" Then
            e.KeyChar = "ミ"
            Label2.Text = ""
            prolongamento = "mi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mo" Then
            e.KeyChar = "モ"
            Label2.Text = ""
            prolongamento = "mo"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mu" Then
            e.KeyChar = "ム"
            Label2.Text = ""
            prolongamento = "mu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "nn" Then
            e.KeyChar = "ン"
            Label2.Text = ""
            prolongamento = "nn"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mm" Then
            e.KeyChar = "ン"
            Label2.Text = ""
            prolongamento = "mm"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "na" Then
            e.KeyChar = "ナ"
            Label2.Text = ""
            prolongamento = "na"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ne" Then
            e.KeyChar = "ネ"
            Label2.Text = ""
            prolongamento = "ne"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ni" Then
            e.KeyChar = "ニ"
            Label2.Text = ""
            prolongamento = "ni"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "no" Then
            e.KeyChar = "ノ"
            Label2.Text = ""
            prolongamento = "no"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "nu" Then
            e.KeyChar = "ヌ"
            Label2.Text = ""
            prolongamento = "nu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pa" Then
            e.KeyChar = "パ"
            Label2.Text = ""
            prolongamento = "pa"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pe" Then
            e.KeyChar = "ペ"
            Label2.Text = ""
            prolongamento = "pe"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pi" Then
            e.KeyChar = "ピ"
            Label2.Text = ""
            prolongamento = "pi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "po" Then
            e.KeyChar = "ポ"
            Label2.Text = ""
            prolongamento = "po"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pu" Then
            e.KeyChar = "プ"
            Label2.Text = ""
            prolongamento = "pu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ra" Then
            e.KeyChar = "ラ"
            Label2.Text = ""
            prolongamento = "ra"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "re" Then
            e.KeyChar = "レ"
            Label2.Text = ""
            prolongamento = "re"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ri" Then
            e.KeyChar = "リ"
            Label2.Text = ""
            prolongamento = "ri"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ro" Then
            e.KeyChar = "ロ"
            Label2.Text = ""
            prolongamento = "ro"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ru" Then
            e.KeyChar = "ル"
            Label2.Text = ""
            prolongamento = "ru"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "sa" Then
            e.KeyChar = "サ"
            Label2.Text = ""
            prolongamento = "sa"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "se" Then
            e.KeyChar = "セ"
            Label2.Text = ""
            prolongamento = "se"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "so" Then
            e.KeyChar = "ソ"
            Label2.Text = ""
            prolongamento = "so"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "su" Then
            e.KeyChar = "ス"
            Label2.Text = ""
            prolongamento = "su"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ta" Then
            e.KeyChar = "タ"
            Label2.Text = ""
            prolongamento = "ta"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "te" Then
            e.KeyChar = "テ"
            Label2.Text = ""
            prolongamento = "te"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "to" Then
            e.KeyChar = "ト"
            Label2.Text = ""
            prolongamento = "to"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "tsu" Then
            e.KeyChar = "ツ"
            Label2.Text = ""
            prolongamento = "tsu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "wa" Then
            e.KeyChar = "ワ"
            Label2.Text = ""
            prolongamento = "wa"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "wo" Then
            e.KeyChar = "ヲ"
            Label2.Text = ""
            prolongamento = "wo"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ya" Then
            e.KeyChar = "ヤ"
            Label2.Text = ""
            prolongamento = "ya"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "yo" Then
            e.KeyChar = "ヨ"
            Label2.Text = ""
            prolongamento = "yo"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "yu" Then
            e.KeyChar = "ユ"
            Label2.Text = ""
            prolongamento = "yu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "za" Then
            e.KeyChar = "ザ"
            Label2.Text = ""
            prolongamento = "za"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ze" Then
            e.KeyChar = "ゼ"
            Label2.Text = ""
            prolongamento = "ze"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "zo" Then
            e.KeyChar = "ゾ"
            Label2.Text = ""
            prolongamento = "zo"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "zu" Then
            e.KeyChar = "ズ"
            Label2.Text = ""
            prolongamento = "zu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "shi" Then
            e.KeyChar = "シ"
            Label2.Text = ""
            prolongamento = "shi"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "fu" Then
            e.KeyChar = "フ"
            Label2.Text = ""
            prolongamento = "fu"
            'TextBox1.SelectionStart = TextBox1.Text.Length
        Else
        End If







        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS


    End Sub


    Public Sub Timer2_Tick(ByVal sender As System.Object, ByVal l As System.EventArgs)

    End Sub

    Private Sub Form24_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu24 = False
    End Sub

    Private Sub Form24_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(8) Then Label2.Text = ""
    End Sub

    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
        formu24 = True
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        'Dim teste As String
        'FileOpen(1, "text.txt", OpenMode.Input)
        'Input(1, teste)
        'FileClose(1)
        'FileOpen(1, "text.text", OpenMode.Output)
        'PrintLine(1, "teste")
        'FileClose(1)
        FolderBrowserDialog1.ShowDialog()
        GroupBox1.Visible = True
        CheckBox1.Checked = False ' ver isso

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo fim
        Dim caracteres As String
        Dim texto As Object
        Dim final As Object
        If TabControl1.SelectedIndex = 0 Then
            caracteres = Len(TextBox1.Text)
            'PrintLine(1, AscW(TextBox1.Text))
            Do While caracteres > 0
                FileOpen(1, FolderBrowserDialog1.SelectedPath & "\" & TextBox3.Text & ".jpw", OpenMode.Output)
                texto = Mid(TextBox1.Text, caracteres)
                If CheckBox1.Checked = False Then
                    final = final & AscW(texto)
                    Print(1, final)
                    CheckBox1.Checked = True
                Else
                    final = final & vbCrLf & AscW(texto)
                    Print(1, final)
                End If
                caracteres = caracteres - 1
                FileClose(1)
            Loop
            GroupBox1.Visible = False
            MsgBox("Arquivo salvo com sucesso!", MsgBoxStyle.OkOnly, "JapaneseWay")

        Else
            caracteres = Len(TextBox2.Text)
            'PrintLine(1, AscW(TextBox2.Text))
            Do While caracteres > 0
                FileOpen(1, FolderBrowserDialog1.SelectedPath & "\" & TextBox3.Text & ".jpw", OpenMode.Output)
                texto = Mid(TextBox2.Text, caracteres)
                If CheckBox1.Checked = False Then
                    final = final & AscW(texto)
                    Print(1, final)
                    CheckBox1.Checked = True
                Else
                    final = final & vbCrLf & AscW(texto)
                    Print(1, final)
                End If
                caracteres = caracteres - 1
                FileClose(1)
            Loop
            GroupBox1.Visible = False
            MsgBox("Arquivo salvo com sucesso!", MsgBoxStyle.OkOnly, "JapaneseWay")
        End If
        Exit Sub
fim:
        MsgBox("Houve um erro ao salvar seu arquivo, verifique se você selecionou o diretório corretamente, ou usou um nome válido para seu arquivo.", MsgBoxStyle.Critical, "JapaneseWay")
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarToolStripMenuItem.Click
        On Error GoTo fim
        OpenFileDialog1.ShowDialog()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        Dim conversao As Object
        Dim conversao2 As Object
        If TabControl1.SelectedIndex = 0 Then
            TextBox1.Text = ""
            Do While Not EOF(1)
                Input(1, conversao)
                conversao2 = ChrW(conversao)
                TextBox1.Text = conversao2 & TextBox1.Text
            Loop
            FileClose(1)
        Else
            TextBox2.Text = ""
            Do While Not EOF(1)
                Input(1, conversao)
                conversao2 = ChrW(conversao)
                TextBox2.Text = conversao2 & TextBox2.Text
            Loop
            FileClose(1)
        End If

        'Input(1, teste)
        'FileClose(1)
        Exit Sub
fim:
        MsgBox("Ocorreu um erro grave. Verifique se o arquivo que você está tentando abrir é um arquivo anteriormente salvo com o programa, um arquivo .jpw.", MsgBoxStyle.OkOnly, "JapaneseWay")
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus

    End Sub







    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            Button4_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error GoTo fim
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Você só pode digitar números!", vbCritical, "JapaneseWay")
        Else
            Dim f As New System.Drawing.Font("MS Mincho", TextBox4.Text)
            TextBox1.Font = f
            TextBox2.Font = f
            GroupBox2.Visible = True

        End If
        Exit Sub
fim:
        MsgBox("Ocorreu um erro inesperado!" & Chr(13) & "Verifique se o tamanho da fonte é um número inteiro não muito grande ou pequeno!", vbCritical, "JapaneseWay")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub FonteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FonteToolStripMenuItem.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox3.Visible = False
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox3.Visible = False
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If RadioButton1.Checked = True Then
            TextBox1.ForeColor = Color.Red
            TextBox2.ForeColor = Color.Red
        ElseIf RadioButton2.Checked = True Then
            TextBox1.ForeColor = Color.Blue
            TextBox2.ForeColor = Color.Blue
        ElseIf RadioButton3.Checked = True Then
            TextBox1.ForeColor = Color.Green
            TextBox2.ForeColor = Color.Green
        ElseIf RadioButton4.Checked = True Then
            TextBox1.ForeColor = Color.Black
            TextBox2.ForeColor = Color.Black
        ElseIf RadioButton5.Checked = True Then
            TextBox1.ForeColor = Color.Yellow
            TextBox2.ForeColor = Color.Yellow
        ElseIf RadioButton6.Checked = True Then
            TextBox1.ForeColor = Color.Pink
            TextBox2.ForeColor = Color.Pink
        End If
        GroupBox3.Visible = False
    End Sub

    Private Sub CorDaFonteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorDaFonteToolStripMenuItem.Click
        GroupBox3.Visible = True
    End Sub


    Private Sub InstalarFontesJaponesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalarFontesJaponesasToolStripMenuItem.Click
        Form21.Show()
        Form21.Focus()
        Form21.WindowState = FormWindowState.Normal
        Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Label2.Text <> "" Then
            If e.KeyChar = Chr(8) Then 'backspace
                e.KeyChar = ""
                Label2.Text = ""
            End If
            If e.KeyChar = Chr(13) Then 'enter
                TextBox2.Text = TextBox2.Text & Label2.Text
                TextBox2.SelectionStart = TextBox2.Text.Length
                Label2.Text = ""
                e.KeyChar = Chr(0)
            End If
        End If


        If Len(Label2.Text) >= 16 Then
            MsgBox("Você não pode usar mais caracteres!", MsgBoxStyle.Critical, "JapaneseWay")
            Label2.Text = ""
        End If

        'If e.KeyChar = Chr(13) Then
        'e.KeyChar = Chr(0) 'barulho
        'End If

        If e.KeyChar = Chr(1) Then 'ctrl a
            TextBox1.SelectAll()
        End If

        If e.KeyChar <> Chr(8) Then 'backspace
            If e.KeyChar <> Chr(13) Then 'enter
                If e.KeyChar <> Chr(32) Then 'espaço
                    If e.KeyChar <> Chr(3) Then 'ctrl c
                        If e.KeyChar <> Chr(22) Then 'ctrl v
                            If e.KeyChar <> Chr(1) Then 'ctrl a
                                If e.KeyChar <> Chr(24) Then 'ctrl x
                                    If e.KeyChar = LCase(e.KeyChar) Then
                                        'e.Handled = True
                                        Label2.Text = Label2.Text & e.KeyChar
                                        'Label2.Text = Label2.Text & LCase(e.KeyChar)
                                        'SendKeys.Send("Enter")
                                        e.KeyChar = Chr(3)
                                    Else
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If





        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS



        If Label2.Text = "nn" Then
            e.KeyChar = "ん"
            Label2.Text = ""
            prolongamento = "nn"
        ElseIf Label2.Text Like "n[b-d]" = True Then
            e.KeyChar = "ん"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[f-h]" = True Then
            e.KeyChar = "ん"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[j-n]" = True Then
            e.KeyChar = "ん"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[p-t]" = True Then
            e.KeyChar = "ん"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text Like "n[v-z]" = True Then
            e.KeyChar = "ん"
            Label2.Text = Mid(Label2.Text, 2)



        ElseIf Label2.Text = "bb" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "cc" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "dd" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "ff" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "gg" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "hh" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "jj" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "kk" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "pp" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "rr" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "ss" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "tt" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "vv" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "xx" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)
        ElseIf Label2.Text = "zz" Then
            e.KeyChar = "っ"
            Label2.Text = Mid(Label2.Text, 2)

        ElseIf Label2.Text = "." Then
            e.KeyChar = "。"
            Label2.Text = ""
        ElseIf Label2.Text = ";" Then
            e.KeyChar = "・"
            Label2.Text = ""
        ElseIf Label2.Text = "<" Then
            e.KeyChar = "《"
            Label2.Text = ""
        ElseIf Label2.Text = ">" Then
            e.KeyChar = "》"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "[" Then
            e.KeyChar = "『"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "]" Then
            e.KeyChar = "』"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "{" Then
            e.KeyChar = "【"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "}" Then
            e.KeyChar = "】"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "-" Then
            e.KeyChar = "ー"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "!" Then
            e.KeyChar = "！"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "?" Then
            e.KeyChar = "？"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length

        ElseIf Label2.Text = """" Then
            If aspas.Checked = False Then
                e.KeyChar = "「"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = True
            Else
                e.KeyChar = "」"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = False
            End If

        ElseIf Label2.Text = "'" Then
            If aspas.Checked = False Then
                e.KeyChar = "「"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = True
            Else
                e.KeyChar = "」"
                Label2.Text = ""
                'TextBox1.SelectionStart = TextBox1.Text.Length
                aspas.Checked = False
            End If



            'SILABAS
            'SILABAS
            'SILABAS
            'SILABAS
            'novos

        ElseIf Label2.Text = "ゃ" Then
            e.KeyChar = "ゃ"
            Label2.Text = ""
        ElseIf Label2.Text = "kya" Then
            e.KeyChar = "き"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "sha" Then
            e.KeyChar = "し"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "cha" Then
            e.KeyChar = "ち"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "nya" Then
            e.KeyChar = "に"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "hya" Then
            e.KeyChar = "ひ"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "mya" Then
            e.KeyChar = "み"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "rya" Then
            e.KeyChar = "り"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "gya" Then
            e.KeyChar = "ぎ"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "ja" Then
            e.KeyChar = "じ"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "jya" Then
            e.KeyChar = "じ"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "bya" Then
            e.KeyChar = "び"
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "pya" Then
            e.KeyChar = "び"
            SendKeys.Send("ゃ")
            Label2.Text = ""

        ElseIf Label2.Text = "ゅ" Then
            e.KeyChar = "ゅ"
            Label2.Text = ""


        ElseIf Label2.Text = "kyu" Then
            e.KeyChar = "き"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "shu" Then
            e.KeyChar = "し"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "chu" Then
            e.KeyChar = "ち"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "nyu" Then
            e.KeyChar = "に"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "myu" Then
            e.KeyChar = "み"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "hyu" Then
            e.KeyChar = "ひ"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "ryu" Then
            e.KeyChar = "り"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "gyu" Then
            e.KeyChar = "ぎ"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "ju" Then
            e.KeyChar = "じ"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "jyu" Then
            e.KeyChar = "じ"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "byu" Then
            e.KeyChar = "び"
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "pyu" Then
            e.KeyChar = "び"
            SendKeys.Send("ゅ")
            Label2.Text = ""

        ElseIf Label2.Text = "ょ" Then
            e.KeyChar = "ょ"
            Label2.Text = ""

        ElseIf Label2.Text = "kyo" Then
            e.KeyChar = "き"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "sho" Then
            e.KeyChar = "し"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "cho" Then
            e.KeyChar = "ち"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "nyo" Then
            e.KeyChar = "に"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "hyo" Then
            e.KeyChar = "ひ"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "myo" Then
            e.KeyChar = "み"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "ryo" Then
            e.KeyChar = "り"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "gyo" Then
            e.KeyChar = "ぎ"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "jo" Then
            e.KeyChar = "じ"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "jyo" Then
            e.KeyChar = "じ"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "byo" Then
            e.KeyChar = "び"
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "pyo" Then
            e.KeyChar = "び"
            SendKeys.Send("ょ")
            Label2.Text = ""

        ElseIf Label2.Text = "ぁ" Then
            e.KeyChar = "ぁ"
            Label2.Text = ""
        ElseIf Label2.Text = "ぇ" Then
            e.KeyChar = "ぇ"
            Label2.Text = ""
        ElseIf Label2.Text = "ぃ" Then
            e.KeyChar = "ぃ"
            Label2.Text = ""
        ElseIf Label2.Text = "ぉ" Then
            e.KeyChar = "ぉ"
            Label2.Text = ""


        ElseIf Label2.Text = "she" Then
            e.KeyChar = "し"
            SendKeys.Send("ぇ")
            Label2.Text = ""
            prolongamento = "she"
        ElseIf Label2.Text = "che" Then
            e.KeyChar = "ち"
            SendKeys.Send("ぇ")
            Label2.Text = ""
            prolongamento = "che"

        ElseIf Label2.Text = "fa" Then
            e.KeyChar = "ふ"
            SendKeys.Send("ぁ")
            Label2.Text = ""
        ElseIf Label2.Text = "fe" Then
            e.KeyChar = "ふ"
            SendKeys.Send("ぇ")
            Label2.Text = ""
            prolongamento = "fe"
        ElseIf Label2.Text = "fi" Then
            e.KeyChar = "ふ"
            SendKeys.Send("ぃ")
            Label2.Text = ""
        ElseIf Label2.Text = "fo" Then
            e.KeyChar = "ふ"
            SendKeys.Send("ぉ")
            Label2.Text = ""

        ElseIf Label2.Text = "っ" Then
            e.KeyChar = "っ"
            Label2.Text = ""


            'TSU
            'TSU

        ElseIf Label2.Text = "ttt" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "kkk" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "bbb" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "cc" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "ddd" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "ppp" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "jjj" Then
            e.KeyChar = "っ"
            Label2.Text = ""
        ElseIf Label2.Text = "tta" Then
            e.KeyChar = "っ"
            SendKeys.Send("ta")
            Label2.Text = ""
        ElseIf Label2.Text = "tte" Then
            e.KeyChar = "っ"
            SendKeys.Send("te")
            Label2.Text = ""
            prolongamento = "tte"
        ElseIf Label2.Text = "tti" Then
            e.KeyChar = "っ"
            SendKeys.Send("chi")
            Label2.Text = ""
        ElseIf Label2.Text = "cchi" Then
            e.KeyChar = "っ"
            SendKeys.Send("chi")
            Label2.Text = ""
        ElseIf Label2.Text = "tto" Then
            e.KeyChar = "っ"
            SendKeys.Send("to")
            Label2.Text = ""
        ElseIf Label2.Text = "ttu" Then
            e.KeyChar = "っ"
            SendKeys.Send("tsu")
            Label2.Text = ""
        ElseIf Label2.Text = "kka" Then
            e.KeyChar = "っ"
            SendKeys.Send("ka")
            Label2.Text = ""
        ElseIf Label2.Text = "kke" Then
            e.KeyChar = "っ"
            SendKeys.Send("ke")
            Label2.Text = ""
            prolongamento = "kke"
        ElseIf Label2.Text = "kki" Then
            e.KeyChar = "っ"
            SendKeys.Send("ki")
            Label2.Text = ""
        ElseIf Label2.Text = "kko" Then
            e.KeyChar = "っ"
            SendKeys.Send("ko")
            Label2.Text = ""
        ElseIf Label2.Text = "kku" Then
            e.KeyChar = "っ"
            SendKeys.Send("ku")
            Label2.Text = ""
        ElseIf Label2.Text = "bba" Then
            e.KeyChar = "っ"
            SendKeys.Send("ba")
            Label2.Text = ""
        ElseIf Label2.Text = "bbe" Then
            e.KeyChar = "っ"
            SendKeys.Send("be")
            Label2.Text = ""
            prolongamento = "bbe"
        ElseIf Label2.Text = "bbi" Then
            e.KeyChar = "っ"
            SendKeys.Send("bi")
            Label2.Text = ""
        ElseIf Label2.Text = "bbo" Then
            e.KeyChar = "っ"
            SendKeys.Send("bo")
            Label2.Text = ""
        ElseIf Label2.Text = "bbu" Then
            e.KeyChar = "っ"
            SendKeys.Send("bu")
            Label2.Text = ""
        ElseIf Label2.Text = "ppa" Then
            e.KeyChar = "っ"
            SendKeys.Send("pa")
            Label2.Text = ""
        ElseIf Label2.Text = "ppe" Then
            e.KeyChar = "っ"
            SendKeys.Send("pe")
            Label2.Text = ""
            prolongamento = "ppe"
        ElseIf Label2.Text = "ppi" Then
            e.KeyChar = "っ"
            SendKeys.Send("pi")
            Label2.Text = ""
        ElseIf Label2.Text = "ppo" Then
            e.KeyChar = "っ"
            SendKeys.Send("po")
            Label2.Text = ""
        ElseIf Label2.Text = "ppu" Then
            e.KeyChar = "っ"
            SendKeys.Send("pu")
            Label2.Text = ""
        ElseIf Label2.Text = "jja" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "jjya" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            SendKeys.Send("ゃ")
            Label2.Text = ""
        ElseIf Label2.Text = "jje" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            SendKeys.Send("ぇ")
            Label2.Text = ""
            prolongamento = "jje"
        ElseIf Label2.Text = "jji" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            Label2.Text = ""
        ElseIf Label2.Text = "jjo" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            SendKeys.Send("ょ")
            Label2.Text = ""
        ElseIf Label2.Text = "jju" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            SendKeys.Send("ゅ")
            Label2.Text = ""
        ElseIf Label2.Text = "dda" Then
            e.KeyChar = "っ"
            SendKeys.Send("da")
            Label2.Text = ""
        ElseIf Label2.Text = "dde" Then
            e.KeyChar = "っ"
            SendKeys.Send("de")
            Label2.Text = ""
            prolongamento = "dde"
        ElseIf Label2.Text = "ddi" Then
            e.KeyChar = "っ"
            SendKeys.Send("dji")
            SendKeys.Send("ぃ")
            Label2.Text = ""
        ElseIf Label2.Text = "ddo" Then
            e.KeyChar = "っ"
            SendKeys.Send("do")
            Label2.Text = ""
        ElseIf Label2.Text = "ddu" Then
            e.KeyChar = "っ"
            SendKeys.Send("dzu")
            Label2.Text = ""
        ElseIf Label2.Text = "ffa" Then
            e.KeyChar = "っ"
            SendKeys.Send("fa")
            Label2.Text = ""
        ElseIf Label2.Text = "ffe" Then
            e.KeyChar = "っ"
            SendKeys.Send("fe")
            Label2.Text = ""
            prolongamento = "ffe"
        ElseIf Label2.Text = "ffi" Then
            e.KeyChar = "っ"
            SendKeys.Send("fi")
            Label2.Text = ""
        ElseIf Label2.Text = "ffo" Then
            e.KeyChar = "っ"
            SendKeys.Send("fo")
            Label2.Text = ""
        ElseIf Label2.Text = "ffu" Then
            e.KeyChar = "っ"
            SendKeys.Send("fu")
            Label2.Text = ""
        ElseIf Label2.Text = "gga" Then
            e.KeyChar = "っ"
            SendKeys.Send("ga")
            Label2.Text = ""
        ElseIf Label2.Text = "gge" Then
            e.KeyChar = "っ"
            SendKeys.Send("ge")
            Label2.Text = ""
            prolongamento = "gge"
        ElseIf Label2.Text = "ggi" Then
            e.KeyChar = "っ"
            SendKeys.Send("gi")
            Label2.Text = ""
        ElseIf Label2.Text = "ggo" Then
            e.KeyChar = "っ"
            SendKeys.Send("go")
            Label2.Text = ""
        ElseIf Label2.Text = "ggu" Then
            e.KeyChar = "っ"
            SendKeys.Send("gu")
            Label2.Text = ""
        ElseIf Label2.Text = "hha" Then
            e.KeyChar = "っ"
            SendKeys.Send("ha")
            Label2.Text = ""
        ElseIf Label2.Text = "hhe" Then
            e.KeyChar = "っ"
            SendKeys.Send("he")
            Label2.Text = ""
            prolongamento = "hhe"
        ElseIf Label2.Text = "hhi" Then
            e.KeyChar = "っ"
            SendKeys.Send("hi")
            Label2.Text = ""
        ElseIf Label2.Text = "hho" Then
            e.KeyChar = "っ"
            SendKeys.Send("ho")
            Label2.Text = ""
        ElseIf Label2.Text = "hhu" Then
            e.KeyChar = "っ"
            SendKeys.Send("hu")
            Label2.Text = ""
        ElseIf Label2.Text = "rra" Then
            e.KeyChar = "っ"
            SendKeys.Send("ra")
            Label2.Text = ""
        ElseIf Label2.Text = "rre" Then
            e.KeyChar = "っ"
            SendKeys.Send("re")
            Label2.Text = ""
            prolongamento = "rre"
        ElseIf Label2.Text = "rri" Then
            e.KeyChar = "っ"
            SendKeys.Send("ri")
            Label2.Text = ""
        ElseIf Label2.Text = "rro" Then
            e.KeyChar = "っ"
            SendKeys.Send("ro")
            Label2.Text = ""
        ElseIf Label2.Text = "rru" Then
            e.KeyChar = "っ"
            SendKeys.Send("ru")
            Label2.Text = ""
        ElseIf Label2.Text = "ssa" Then
            e.KeyChar = "っ"
            SendKeys.Send("sa")
            Label2.Text = ""
        ElseIf Label2.Text = "sse" Then
            e.KeyChar = "っ"
            SendKeys.Send("se")
            Label2.Text = ""
            prolongamento = "sse"
        ElseIf Label2.Text = "ssi" Then
            e.KeyChar = "っ"
            SendKeys.Send("shi")
            Label2.Text = ""
        ElseIf Label2.Text = "sso" Then
            e.KeyChar = "っ"
            SendKeys.Send("so")
            Label2.Text = ""
        ElseIf Label2.Text = "ssu" Then
            e.KeyChar = "っ"
            SendKeys.Send("su")
            Label2.Text = ""
        ElseIf Label2.Text = "vva" Then
            e.KeyChar = "っ"
            SendKeys.Send("va")
            Label2.Text = ""
        ElseIf Label2.Text = "vve" Then
            e.KeyChar = "っ"
            SendKeys.Send("ve")
            Label2.Text = ""
            prolongamento = "vve"
        ElseIf Label2.Text = "vvi" Then
            e.KeyChar = "っ"
            SendKeys.Send("vi")
            Label2.Text = ""
        ElseIf Label2.Text = "vvo" Then
            e.KeyChar = "っ"
            SendKeys.Send("vo")
            Label2.Text = ""
        ElseIf Label2.Text = "vvu" Then
            e.KeyChar = "っ"
            SendKeys.Send("vu")
            Label2.Text = ""
        ElseIf Label2.Text = "wwa" Then
            e.KeyChar = "っ"
            SendKeys.Send("wa")
            Label2.Text = ""
        ElseIf Label2.Text = "wwe" Then
            e.KeyChar = "っ"
            SendKeys.Send("we")
            Label2.Text = ""
            prolongamento = "wwe"
        ElseIf Label2.Text = "wwi" Then
            e.KeyChar = "っ"
            SendKeys.Send("wi")
            Label2.Text = ""
        ElseIf Label2.Text = "wwo" Then
            e.KeyChar = "っ"
            SendKeys.Send("wo")
            Label2.Text = ""
        ElseIf Label2.Text = "xxa" Then
            e.KeyChar = "っ"
            SendKeys.Send("ぁ")
            Label2.Text = ""
        ElseIf Label2.Text = "xxe" Then
            e.KeyChar = "っ"
            SendKeys.Send("ぇ")
            Label2.Text = ""
            prolongamento = "xxe"
        ElseIf Label2.Text = "xxi" Then
            e.KeyChar = "っ"
            SendKeys.Send("ぃ")
            Label2.Text = ""
        ElseIf Label2.Text = "zza" Then
            e.KeyChar = "っ"
            SendKeys.Send("za")
            Label2.Text = ""
        ElseIf Label2.Text = "zze" Then
            e.KeyChar = "っ"
            SendKeys.Send("ze")
            Label2.Text = ""
            prolongamento = "zze"
        ElseIf Label2.Text = "zzi" Then
            e.KeyChar = "っ"
            SendKeys.Send("zi")
            Label2.Text = ""
        ElseIf Label2.Text = "zzo" Then
            e.KeyChar = "っ"
            SendKeys.Send("zo")
            Label2.Text = ""
        ElseIf Label2.Text = "zzu" Then
            e.KeyChar = "っ"
            SendKeys.Send("zu")
            Label2.Text = ""
            'novos





        ElseIf Label2.Text = "we" Then
            e.KeyChar = "ゑ"
            Label2.Text = ""
            prolongamento = "we"
        ElseIf Label2.Text = "wi" Then
            e.KeyChar = "ゐ"
            Label2.Text = ""
        ElseIf Label2.Text = "a" Then
            e.KeyChar = "あ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "e" Then
            e.KeyChar = "え"
            Label2.Text = ""

            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "i" Then
            e.KeyChar = "い"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "o" Then
            e.KeyChar = "お"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "u" Then
            e.KeyChar = "う"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ba" Then
            e.KeyChar = "ば"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "be" Then
            e.KeyChar = "べ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "bi" Then
            e.KeyChar = "び"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "bo" Then
            e.KeyChar = "ぼ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "bu" Then
            e.KeyChar = "ぶ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "chi" Then
            e.KeyChar = "ち"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "da" Then
            e.KeyChar = "だ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "de" Then
            e.KeyChar = "で"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "dji" Then
            e.KeyChar = "ぢ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "do" Then
            e.KeyChar = "ど"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "dzu" Then
            e.KeyChar = "づ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ga" Then
            e.KeyChar = "が"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ge" Then
            e.KeyChar = "げ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "gi" Then
            e.KeyChar = "ぎ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "go" Then
            e.KeyChar = "ご"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "gu" Then
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
            e.KeyChar = "ぐ"
        ElseIf Label2.Text = "ha" Then
            e.KeyChar = "は"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "he" Then
            e.KeyChar = "へ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "hi" Then
            e.KeyChar = "ひ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ho" Then
            e.KeyChar = "ほ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ji" Then
            e.KeyChar = "じ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ka" Then
            e.KeyChar = "か"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ke" Then
            e.KeyChar = "け"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ki" Then
            e.KeyChar = "き"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ko" Then
            e.KeyChar = "こ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ku" Then
            e.KeyChar = "く"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ma" Then
            e.KeyChar = "ま"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "me" Then
            e.KeyChar = "め"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mi" Then
            e.KeyChar = "み"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mo" Then
            e.KeyChar = "も"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mu" Then
            e.KeyChar = "む"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "nn" Then
            e.KeyChar = "ん"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "mm" Then
            e.KeyChar = "ん"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "na" Then
            e.KeyChar = "な"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ne" Then
            e.KeyChar = "ね"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ni" Then
            e.KeyChar = "に"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "no" Then
            e.KeyChar = "の"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "nu" Then
            e.KeyChar = "ぬ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pa" Then
            e.KeyChar = "ぱ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pe" Then
            e.KeyChar = "ぺ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pi" Then
            e.KeyChar = "ぴ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "po" Then
            e.KeyChar = "ぽ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "pu" Then
            e.KeyChar = "ぷ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ra" Then
            e.KeyChar = "ら"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "re" Then
            e.KeyChar = "れ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ri" Then
            e.KeyChar = "り"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ro" Then
            e.KeyChar = "ろ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ru" Then
            e.KeyChar = "る"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "sa" Then
            e.KeyChar = "さ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "se" Then
            e.KeyChar = "せ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "so" Then
            e.KeyChar = "そ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "su" Then
            e.KeyChar = "す"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ta" Then
            e.KeyChar = "た"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "te" Then
            e.KeyChar = "て"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "to" Then
            e.KeyChar = "と"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "tsu" Then
            e.KeyChar = "つ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "wa" Then
            e.KeyChar = "わ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "wo" Then
            e.KeyChar = "を"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ya" Then
            e.KeyChar = "や"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "yo" Then
            e.KeyChar = "よ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "yu" Then
            e.KeyChar = "ゆ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "za" Then
            e.KeyChar = "ザ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "ze" Then
            e.KeyChar = "ぜ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "zo" Then
            e.KeyChar = "ぞ"
            Label2.Text = ""
        ElseIf Label2.Text = "zi" Then
            e.KeyChar = "ず"
            SendKeys.Send("ぃ")
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "zu" Then
            e.KeyChar = "ず"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "shi" Then
            e.KeyChar = "し"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        ElseIf Label2.Text = "fu" Then
            e.KeyChar = "ふ"
            Label2.Text = ""
            'TextBox1.SelectionStart = TextBox1.Text.Length
        Else
        End If








        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS
        'TECLAS PRESSIONADAS

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label6.Tag = "" Then
            Label6.Text = "                   Para escrever N e M com som de HMM, " & vbCrLf & "você precisa digitar duas vezes(dois n's)!"
            Label6.Tag = "1"
        ElseIf Label6.Tag = "1" Then
            Label6.Text = "                   Para escrever com nosso alfabeto, é só " & vbCrLf & "escrever com letras maiúsculas. Aperte o CapsLock!"
            Label6.Tag = "2"
        ElseIf Label6.Tag = "2" Then
            Label6.Tag = ""
            Label6.Text = "                   Para utilizar o prolongamento do alfabeto" & vbCrLf & "katakana, é só utilizar o (-), traço!"
        End If
    End Sub



    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        If TabControl1.SelectedIndex = 1 Then
            TextBox2.Select()
        ElseIf TabControl1.SelectedIndex = 0 Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        If TabControl1.SelectedIndex = 1 Then
            TextBox2.Select()
        ElseIf TabControl1.SelectedIndex = 0 Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(AcceptButton, AcceptButton)
        End If
    End Sub

 
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
Public Class Form17

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ListBox1.Text = "um" Then
            TextBox3.Text = "ichi"
            TextBox5.Text = "hito(tsu)"
            TextBox1.Text = "一"
        ElseIf ListBox1.Text = "zero" Then
            TextBox3.Text = "zero"
            TextBox5.Text = "rei"
            TextBox1.Text = "零"
        ElseIf ListBox1.Text = "dois" Then
            TextBox3.Text = "ni"
            TextBox5.Text = "futa(tsu)"
            TextBox1.Text = "二"
        ElseIf ListBox1.Text = "três" Then
            TextBox3.Text = "san"
            TextBox5.Text = "mi(ttsu)"
            TextBox1.Text = "三"
        ElseIf ListBox1.Text = "quatro" Then
            TextBox3.Text = "shi"
            TextBox5.Text = "yon, yo(ttsu)"
            TextBox1.Text = "四"
        ElseIf ListBox1.Text = "cinco" Then
            TextBox3.Text = "go"
            TextBox5.Text = "itsu(tsu)"
            TextBox1.Text = "五"
        ElseIf ListBox1.Text = "seis" Then
            TextBox3.Text = "roku"
            TextBox5.Text = "mu(ttsu)"
            TextBox1.Text = "六"
        ElseIf ListBox1.Text = "sete" Then
            TextBox3.Text = "shichi"
            TextBox5.Text = "nana(tsu)"
            TextBox1.Text = "七"
        ElseIf ListBox1.Text = "oito" Then
            TextBox3.Text = "hachi"
            TextBox5.Text = "ya(ttsu)"
            TextBox1.Text = "八"
        ElseIf ListBox1.Text = "nove" Then
            TextBox3.Text = "kyuu"
            TextBox5.Text = "kokono(tsu)"
            TextBox1.Text = "九"
        ElseIf ListBox1.Text = "dez" Then
            TextBox3.Text = "jyuu"
            TextBox5.Text = "too"
            TextBox1.Text = "十"
        ElseIf ListBox1.Text = "onze" Then
            TextBox3.Text = "jyuu ichi"
            TextBox5.Text = ""
            TextBox1.Text = "十一"
        ElseIf ListBox1.Text = "quatorze" Then '12
            TextBox3.Text = "jyuu yon"
            TextBox5.Text = ""
            TextBox1.Text = "十四"
        ElseIf ListBox1.Text = "trinta" Then '14
            TextBox3.Text = "san jyuu"
            TextBox5.Text = "miso"
            TextBox1.Text = "三十"
        ElseIf ListBox1.Text = "quarenta" Then '15
            TextBox3.Text = "yon jyuu"
            TextBox5.Text = ""
            TextBox1.Text = "四十"
        ElseIf ListBox1.Text = "quarenta e três" Then '16
            TextBox3.Text = "yon jyuu san"
            TextBox5.Text = ""
            TextBox1.Text = "四十三"
        ElseIf ListBox1.Text = "noventa" Then '17
            TextBox3.Text = "kyuu jyuu"
            TextBox5.Text = "kujyuu"
            TextBox1.Text = "九十"
        ElseIf ListBox1.Text = "Cem" Then '18
            TextBox3.Text = "hyaku"
            TextBox5.Text = "momo"
            TextBox1.Text = "百"
        ElseIf ListBox1.Text = "duzentos" Then '19
            TextBox3.Text = "ni hyaku"
            TextBox5.Text = ""
            TextBox1.Text = "二百"
        ElseIf ListBox1.Text = "trezentos" Then '20
            TextBox3.Text = "san byaku"
            TextBox5.Text = ""
            TextBox1.Text = "三百"
        ElseIf ListBox1.Text = "seiscentos" Then '21
            TextBox3.Text = "roppyaku"
            TextBox5.Text = ""
            TextBox1.Text = "六百"
        ElseIf ListBox1.Text = "oitocentos" Then '22
            TextBox3.Text = "happyaku"
            TextBox5.Text = ""
            TextBox1.Text = "八百"
        ElseIf ListBox1.Text = "mil" Then '23
            TextBox3.Text = "sen"
            TextBox5.Text = "chi"
            TextBox1.Text = "千"
        ElseIf ListBox1.Text = "dois mil" Then '24
            TextBox3.Text = "ni sen"
            TextBox5.Text = ""
            TextBox1.Text = "二千"
        ElseIf ListBox1.Text = "três mil" Then '25
            TextBox3.Text = "san zen"
            TextBox5.Text = ""
            TextBox1.Text = "三千"
        ElseIf ListBox1.Text = "oito mil" Then '26
            TextBox3.Text = "hassen"
            TextBox5.Text = ""
            TextBox1.Text = "八千"
        ElseIf ListBox1.Text = "dez mil" Then '27
            TextBox3.Text = "man"
            TextBox5.Text = "yorozu"
            TextBox1.Text = "万"
        ElseIf ListBox1.Text = "cem milhões" Then '28
            TextBox3.Text = "oku"
            TextBox5.Text = ""
            TextBox1.Text = "億"
        ElseIf ListBox1.Text = "um trilhão" Then '29
            TextBox3.Text = "choo"
            TextBox5.Text = ""
            TextBox1.Text = "兆"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.ImageLocation = "imagem\kanji\contagem\" & ListBox1.SelectedIndex & ".jpg"
        PictureBox3.ImageLocation = "imagem\kanji\contagem\certo\" & ListBox1.SelectedIndex & ".jpg"
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form17_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu17 = False
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu17 = True
    End Sub
    'tirar print screen'
    Public Function GetWindowCapture() As Image

        SendKeys.SendWait("%{PRTSC}")

        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        Return objClipboard.GetData(DataFormats.Bitmap)
    End Function
    'tirar print' % é só pra tela ativa, ^ é pra tela toda.

    Private Sub SalvarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarToolStripMenuItem.Click

    End Sub

    Private Sub ScreenShotimagemDosKanjisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScreenShotimagemDosKanjisToolStripMenuItem.Click

        Form19.Show()
        Form19.Focus()
        Form19.WindowState = FormWindowState.Normal
    End Sub

    Private Sub fototimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fototimer.Tick
        On Error GoTo label
        If foto.Tag = "OK" Then
            If nome.Tag = "OK" Then
                Dim salvar As String
                salvar = foto.Text & nome.Text & ".bmp"
                GetWindowCapture().Save(foto.Text & nome.Text & ".bmp")
                fototimer.Enabled = False
                salvo.Enabled = True
            Else
                MsgBox("Houve um erro com o nome da sua imagem, verifique tudo no Menu.", MsgBoxStyle.Critical, "JapaneseWay")
            End If
        Else
            MsgBox("Selecione um diretório no Menu para salvar sua imagem.", MsgBoxStyle.Critical, "JapaneseWay")
        End If

        Exit Sub

label:
        fototimer.Enabled = False
        foto.Tag = ""
        nome.Tag = ""
        MsgBox("Um erro ocorreu, verifique se você escreveu o nome da imagem ou o caminho do diretório corretamente, remova carateres desnecessários, não foi possível salvar.", MsgBoxStyle.Critical, "JapaneseWay Error")
        Form6.Show()
        fototimer.Enabled = False
    End Sub

    Private Sub salvo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvo.Tick
        salvo.Enabled = False
        MsgBox("Foto salva com sucesso.", MsgBoxStyle.OkOnly, "JapaneseWay")
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        PictureBox2.ImageLocation = "imagem\kanji\outros\" & ListBox2.SelectedItem & ".jpg"
        PictureBox4.ImageLocation = "imagem\kanji\outros\certo\" & ListBox2.SelectedItem & ".jpg"
        imagemb.Checked = False
        imagemc.Checked = False
        mudando.Enabled = False
        TextBox7.Text = ""
        tempo.Enabled = False
        Label13.Text = "Aguarde..."
        Timer5.Enabled = True
        meiotermo2.Checked = False
        meiotermo1.Checked = False
        meiotermo.Checked = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ListBox2.Text = "amor" Then
            TextBox6.Text = "ai"
            TextBox4.Text = ""
            TextBox2.Text = "愛"
        ElseIf ListBox2.Text = "força" Then
            TextBox6.Text = "ryoku/riki/rii"
            TextBox4.Text = "chikara"
            TextBox2.Text = "力"
        ElseIf ListBox2.Text = "pessoa" Then
            TextBox6.Text = "jin/nin"
            TextBox4.Text = "hito"
            TextBox2.Text = "人"
        ElseIf ListBox2.Text = "grande" Then
            TextBox6.Text = "sa/tai"
            TextBox4.Text = "ookii"
            TextBox2.Text = "大"
        ElseIf ListBox2.Text = "dia-sol" Then
            TextBox6.Text = "nichi"
            TextBox4.Text = "hi"
            TextBox2.Text = "日"
        ElseIf ListBox2.Text = "flor" Then
            TextBox6.Text = ""
            TextBox4.Text = "hana"
            TextBox2.Text = "花"
        ElseIf ListBox2.Text = "fogo" Then
            TextBox6.Text = "ka"
            TextBox4.Text = "hi"
            TextBox2.Text = "火"
        ElseIf ListBox2.Text = "água" Then
            TextBox6.Text = "sui"
            TextBox4.Text = "mizu"
            TextBox2.Text = "水"
        ElseIf ListBox2.Text = "terra" Then
            TextBox6.Text = "do"
            TextBox4.Text = "tsuchi"
            TextBox2.Text = "土"
        ElseIf ListBox2.Text = "metal" Then
            TextBox6.Text = "kin"
            TextBox4.Text = "kare"
            TextBox2.Text = "金"
        ElseIf ListBox2.Text = "madeira" Then
            TextBox6.Text = "ki"
            TextBox4.Text = "moku"
            TextBox2.Text = "木"
        ElseIf ListBox2.Text = "bosque" Then
            TextBox6.Text = "rin"
            TextBox4.Text = "hayashi"
            TextBox2.Text = "林"

        ElseIf ListBox2.Text = "céu" Then
            TextBox6.Text = ""
            TextBox4.Text = "sora"
            TextBox2.Text = "空"
        ElseIf ListBox2.Text = "mês-lua" Then
            TextBox6.Text = ""
            TextBox4.Text = "getsu/gatsu"
            TextBox2.Text = "月"
        ElseIf ListBox2.Text = "sonho" Then
            TextBox6.Text = ""
            TextBox4.Text = "yume"
            TextBox2.Text = "夢"
        ElseIf ListBox2.Text = "vida" Then
            TextBox6.Text = "sei"
            TextBox4.Text = ""
            TextBox2.Text = "生"
        ElseIf ListBox2.Text = "morte" Then
            TextBox6.Text = "shi"
            TextBox4.Text = ""
            TextBox2.Text = "死"
        ElseIf ListBox2.Text = "relâmpago" Then
            TextBox6.Text = "rai"
            TextBox4.Text = "kaminari"
            TextBox2.Text = "雷"
        ElseIf ListBox2.Text = "vento" Then
            TextBox6.Text = "fuu"
            TextBox4.Text = "kaze"
            TextBox2.Text = "風"
        ElseIf ListBox2.Text = "deus" Then
            TextBox6.Text = "shin/jin"
            TextBox4.Text = "kami"
            TextBox2.Text = "神"
        ElseIf ListBox2.Text = "barulho" Then
            TextBox6.Text = "re"
            TextBox4.Text = "on/oto"
            TextBox2.Text = "音"
        ElseIf ListBox2.Text = "mau" Then
            TextBox6.Text = ""
            TextBox4.Text = "aku"
            TextBox2.Text = "悪"
        ElseIf ListBox2.Text = "demônio" Then
            TextBox6.Text = "ma"
            TextBox4.Text = ""
            TextBox2.Text = "魔"
        ElseIf ListBox2.Text = "ler" Then
            TextBox6.Text = ""
            TextBox4.Text = "doku"
            TextBox2.Text = "読"
        ElseIf ListBox2.Text = "livro" Then
            TextBox6.Text = "hon"
            TextBox4.Text = ""
            TextBox2.Text = "本"
        ElseIf ListBox2.Text = "acima" Then
            TextBox6.Text = "ue"
            TextBox4.Text = "jou/shou/shan"
            TextBox2.Text = "上"
        ElseIf ListBox2.Text = "álcool" Then
            TextBox6.Text = ""
            TextBox4.Text = "sake"
            TextBox2.Text = "酒"
        ElseIf ListBox2.Text = "criança" Then
            TextBox6.Text = "shi/su/tsu"
            TextBox4.Text = "ko"
            TextBox2.Text = "子"
        ElseIf ListBox2.Text = "pequeno" Then
            TextBox6.Text = "shou"
            TextBox4.Text = "chii(sai)"
            TextBox2.Text = "小"
        ElseIf ListBox2.Text = "mulher" Then
            TextBox6.Text = "sho"
            TextBox4.Text = "onna"
            TextBox2.Text = "女"
        ElseIf ListBox2.Text = "homem" Then
            TextBox6.Text = "dan/nan"
            TextBox4.Text = "otoko"
            TextBox2.Text = "男"
        ElseIf ListBox2.Text = "noite" Then
            TextBox6.Text = "seki"
            TextBox4.Text = "yuu"
            TextBox2.Text = "夕"
        ElseIf ListBox2.Text = "montanha" Then
            TextBox6.Text = "san/sen"
            TextBox4.Text = "yama"
            TextBox2.Text = "山"
        ElseIf ListBox2.Text = "interior" Then
            TextBox6.Text = "chuu"
            TextBox4.Text = "naka"
            TextBox2.Text = "中"
        ElseIf ListBox2.Text = "mão" Then
            TextBox6.Text = "shu/zu"
            TextBox4.Text = "te"
            TextBox2.Text = "手"
        ElseIf ListBox2.Text = "paraíso" Then
            TextBox6.Text = "ten"
            TextBox4.Text = "amatsu/ame/ama"
            TextBox2.Text = "天"
        ElseIf ListBox2.Text = "chuva" Then
            TextBox6.Text = "u"
            TextBox4.Text = "ame"
            TextBox2.Text = "雨"
        ElseIf ListBox2.Text = "floresta" Then ' 37
            TextBox6.Text = "shin"
            TextBox4.Text = "mori"
            TextBox2.Text = "森"
        ElseIf ListBox2.Text = "eu" Then ' 38
            TextBox6.Text = ""
            TextBox4.Text = "watashi"
            TextBox2.Text = "私"
        ElseIf ListBox2.Text = "você" Then '39 ' b
            imagemb.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "anata"
            TextBox2.Text = "貴方"
        ElseIf ListBox2.Text = "hoje" Then '40 'b
            imagemb.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "kyoo"
            TextBox2.Text = "今日"
        ElseIf ListBox2.Text = "amanhã" Then '41 'b
            imagemb.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "ashita"
            TextBox2.Text = "明日"
        ElseIf ListBox2.Text = "ontem" Then '42 'b
            imagemb.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "kinoo"
            TextBox2.Text = "昨日"
        ElseIf ListBox2.Text = "branco" Then '43
            TextBox6.Text = ""
            TextBox4.Text = "shiro|i"
            TextBox2.Text = "白い"
        ElseIf ListBox2.Text = "preto" Then '44
            TextBox6.Text = ""
            TextBox4.Text = "kura|i"
            TextBox2.Text = "暗い"
        ElseIf ListBox2.Text = "vermelho" Then '45
            TextBox6.Text = ""
            TextBox4.Text = "aka|i"
            TextBox2.Text = "赤い"
        ElseIf ListBox2.Text = "azul" Then '46
            TextBox6.Text = ""
            TextBox4.Text = "ao|i"
            TextBox2.Text = "青い"
        ElseIf ListBox2.Text = "verde" Then '47
            TextBox6.Text = ""
            TextBox4.Text = "ao|i"
            TextBox2.Text = "青い"
        ElseIf ListBox2.Text = "amarelo" Then '48 'b
            imagemb.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "kiiro"
            TextBox2.Text = "黄色"
        ElseIf ListBox2.Text = "rosa" Then '49 'b 'c
            imagemc.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "tankooshyoku"
            TextBox2.Text = "淡紅色"
        ElseIf ListBox2.Text = "marrom" Then '50 'b
            imagemb.Checked = True
            mudando.Enabled = True
            tempo.Enabled = True
            TextBox6.Text = ""
            TextBox4.Text = "chyairo"
            TextBox2.Text = "茶色"
        End If
    End Sub

    Private Sub mudando_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mudando.Tick
        If CheckBox1.Checked = False Then
            If imagemb.Checked = True Then
                If meiotermo2.Checked = False Then
                    PictureBox2.ImageLocation = "imagem\kanji\outros\" & ListBox2.SelectedItem & "b" & ".jpg"
                    PictureBox4.ImageLocation = "imagem\kanji\outros\certo\" & ListBox2.SelectedItem & "b" & ".jpg"
                    'meiotermo.Checked = False
                    meiotermo2.Checked = True
                    GoTo continuar
                End If
                If meiotermo2.Checked = True Then
                    PictureBox2.ImageLocation = "imagem\kanji\outros\" & ListBox2.SelectedItem & ".jpg"
                    PictureBox4.ImageLocation = "imagem\kanji\outros\certo\" & ListBox2.SelectedItem & ".jpg"
                    meiotermo2.Checked = False
                    GoTo continuar
                End If
            End If


            If imagemc.Checked = True Then
                If meiotermo.Checked = True Then
                    PictureBox2.ImageLocation = "imagem\kanji\outros\" & ListBox2.SelectedItem & "c" & ".jpg"
                    PictureBox4.ImageLocation = "imagem\kanji\outros\certo\" & ListBox2.SelectedItem & "c" & ".jpg"
                    meiotermo1.Checked = True
                    meiotermo.Checked = False
                    GoTo continuar
                End If


                If meiotermo1.Checked = True Then
                    PictureBox2.ImageLocation = "imagem\kanji\outros\" & ListBox2.SelectedItem & ".jpg"
                    PictureBox4.ImageLocation = "imagem\kanji\outros\certo\" & ListBox2.SelectedItem & ".jpg"
                    meiotermo1.Checked = False
                    meiotermo.Checked = False
                    GoTo continuar
                End If


                If meiotermo.Checked = False Then
                    PictureBox2.ImageLocation = "imagem\kanji\outros\" & ListBox2.SelectedItem & "b" & ".jpg"
                    PictureBox4.ImageLocation = "imagem\kanji\outros\certo\" & ListBox2.SelectedItem & "b" & ".jpg"
                    meiotermo.Checked = True
                End If
            End If
continuar:
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tempo.Tick
        If CheckBox1.Checked = False Then
            If Label13.Text = "Aguarde..." Then
                Label13.Text = 5
            ElseIf Label13.Text = "Aguarde.." Then
                Label13.Text = 5
            ElseIf Label13.Text = "Aguarde." Then
                Label13.Text = 5
            End If
            If Label13.Text > 0 Then
                Label13.Text = Label13.Text - 1
            End If
            If Label13.Text = 0 Then
                Label13.Text = 5
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Label13.Text = "Aguarde..."
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If imagemb.Checked Or imagemc.Checked = True Then
            If Label13.Text = "Aguarde..." Then
                Label13.Text = "Aguarde."
            ElseIf Label13.Text = "Aguarde.." Then
                Label13.Text = "Aguarde..."
            ElseIf Label13.Text = "Aguarde." Then
                Label13.Text = "Aguarde.."
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Timer5_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        On Error GoTo fim
        'contando quantos kanjis tem
        Dim counter As  _
System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        counter = My.Computer.FileSystem.GetFiles("Imagem\kanji\outros\certo\")
        Label3.Text = "Selecione (" & CStr(counter.Count) & " kanjis):"
        Exit Sub
fim:
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo fim
        If TextBox7.Text <> "" Then
            ListBox2.SelectedItem = LCase(TextBox7.Text)
        End If
        Exit Sub
fim:
    End Sub
End Class
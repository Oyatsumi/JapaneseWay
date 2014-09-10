Public Class Form22

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Close()
            Form21.Show()
            Form21.Focus()
            Form21.WindowState = FormWindowState.Normal
        Else
            MsgBox("É necessário que as fontes do Windows estejam instaladas para poder ver os caracteres em Japonês. Caso elas não estejam instaladas, clique novamente no botão.", MsgBoxStyle.OkOnly, "JapaneseWay")
            CheckBox1.Checked = True
            Button1.Text = "Instalar as fontes japonesas!"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox4.Text = ""
        If ListBox1.Text = "a" Then
            TextBox2.Text = "ア"
            Label3.Text = "ア"
        ElseIf ListBox1.Text = "ba" Then
            TextBox2.Text = "バ"
            Label3.Text = "バ"
        ElseIf ListBox1.Text = "be" Then
            TextBox2.Text = "ベ"
            Label3.Text = "ベ"
        ElseIf ListBox1.Text = "bi" Then
            TextBox2.Text = "ビ"
            Label3.Text = "ビ"
        ElseIf ListBox1.Text = "bo" Then
            TextBox2.Text = "ボ"
            Label3.Text = "ボ"
        ElseIf ListBox1.Text = "bu" Then
            TextBox2.Text = "ブ"
            Label3.Text = "ブ"
        ElseIf ListBox1.Text = "chi" Then
            TextBox2.Text = "チ"
            Label3.Text = "チ"
        ElseIf ListBox1.Text = "da" Then
            TextBox2.Text = "ダ"
            Label3.Text = "ダ"
        ElseIf ListBox1.Text = "de" Then
            TextBox2.Text = "デ"
            Label3.Text = "デ"
        ElseIf ListBox1.Text = "dji" Then
            TextBox2.Text = "ヂ"
            Label3.Text = "ヂ"
        ElseIf ListBox1.Text = "do" Then
            TextBox2.Text = "ド"
            Label3.Text = "ド"
        ElseIf ListBox1.Text = "dzu" Then
            TextBox2.Text = "ヅ"
            Label3.Text = "ヅ"
        ElseIf ListBox1.Text = "e" Then
            TextBox2.Text = "エ"
            Label3.Text = "エ"
        ElseIf ListBox1.Text = "ga" Then
            TextBox2.Text = "ガ"
            Label3.Text = "ガ"
        ElseIf ListBox1.Text = "ge" Then
            TextBox2.Text = "ゲ"
            Label3.Text = "ゲ"
        ElseIf ListBox1.Text = "gi" Then
            TextBox2.Text = "ギ"
            Label3.Text = "ギ"
        ElseIf ListBox1.Text = "go" Then
            TextBox2.Text = "ゴ"
            Label3.Text = "ゴ"
        ElseIf ListBox1.Text = "gu" Then
            TextBox2.Text = "グ"
            Label3.Text = "グ"
        ElseIf ListBox1.Text = "ha" Then
            TextBox2.Text = "ハ"
            Label3.Text = "ハ"
        ElseIf ListBox1.Text = "he" Then
            TextBox2.Text = "ヘ"
            Label3.Text = "ヘ"
        ElseIf ListBox1.Text = "hi" Then
            TextBox2.Text = "ヒ"
            Label3.Text = "ヒ"
        ElseIf ListBox1.Text = "ho" Then
            TextBox2.Text = "ホ"
            Label3.Text = "ホ"
        ElseIf ListBox1.Text = "i" Then
            TextBox2.Text = "イ"
            Label3.Text = "イ"
        ElseIf ListBox1.Text = "ji" Then
            TextBox2.Text = "ジ"
            Label3.Text = "ジ"
        ElseIf ListBox1.Text = "ka" Then
            TextBox2.Text = "カ"
            Label3.Text = "カ"
        ElseIf ListBox1.Text = "ke" Then
            TextBox2.Text = "ケ"
            Label3.Text = "ケ"
        ElseIf ListBox1.Text = "ki" Then
            TextBox2.Text = "キ"
            Label3.Text = "キ"
        ElseIf ListBox1.Text = "ko" Then
            TextBox2.Text = "コ"
            Label3.Text = "コ"
        ElseIf ListBox1.Text = "ku" Then
            TextBox2.Text = "ク"
            Label3.Text = "ク"
        ElseIf ListBox1.Text = "ma" Then
            TextBox2.Text = "マ"
            Label3.Text = "マ"
        ElseIf ListBox1.Text = "me" Then
            TextBox2.Text = "メ"
            Label3.Text = "メ"
        ElseIf ListBox1.Text = "mi" Then
            TextBox2.Text = "ミ"
            Label3.Text = "ミ"
        ElseIf ListBox1.Text = "mo" Then
            TextBox2.Text = "モ"
            Label3.Text = "モ"
        ElseIf ListBox1.Text = "mu" Then
            TextBox2.Text = "ム"
            Label3.Text = "ム"
        ElseIf ListBox1.Text = "n" Then
            TextBox2.Text = "ン"
            Label3.Text = "ン"
        ElseIf ListBox1.Text = "na" Then
            TextBox2.Text = "ナ"
            Label3.Text = "ナ"
        ElseIf ListBox1.Text = "ne" Then
            TextBox2.Text = "ネ"
            Label3.Text = "ネ"
        ElseIf ListBox1.Text = "ni" Then
            TextBox2.Text = "ニ"
            Label3.Text = "ニ"
        ElseIf ListBox1.Text = "no" Then
            TextBox2.Text = "ノ"
            Label3.Text = "ノ"
        ElseIf ListBox1.Text = "nu" Then
            TextBox2.Text = "ヌ"
            Label3.Text = "ヌ"
        ElseIf ListBox1.Text = "o" Then
            TextBox2.Text = "オ"
            Label3.Text = "オ"
        ElseIf ListBox1.Text = "pa" Then
            TextBox2.Text = "パ"
            Label3.Text = "パ"
        ElseIf ListBox1.Text = "pe" Then
            TextBox2.Text = "ペ"
            Label3.Text = "ペ"
        ElseIf ListBox1.Text = "pi" Then
            TextBox2.Text = "ピ"
            Label3.Text = "ピ"
        ElseIf ListBox1.Text = "po" Then
            TextBox2.Text = "ポ"
            Label3.Text = "ポ"
        ElseIf ListBox1.Text = "pu" Then
            TextBox2.Text = "プ"
            Label3.Text = "プ"
        ElseIf ListBox1.Text = "ra" Then
            TextBox2.Text = "ラ"
            Label3.Text = "ラ"
        ElseIf ListBox1.Text = "re" Then
            TextBox2.Text = "レ"
            Label3.Text = "レ"
        ElseIf ListBox1.Text = "ri" Then
            TextBox2.Text = "リ"
            Label3.Text = "リ"
        ElseIf ListBox1.Text = "ro" Then
            TextBox2.Text = "ロ"
            Label3.Text = "ロ"
        ElseIf ListBox1.Text = "ru" Then
            TextBox2.Text = "ル"
            Label3.Text = "ル"
        ElseIf ListBox1.Text = "sa" Then
            TextBox2.Text = "サ"
            Label3.Text = "サ"
        ElseIf ListBox1.Text = "se" Then
            TextBox2.Text = "セ"
            Label3.Text = "セ"
        ElseIf ListBox1.Text = "so" Then
            TextBox2.Text = "ソ"
            Label3.Text = "ソ"
        ElseIf ListBox1.Text = "su" Then
            TextBox2.Text = "ス"
            Label3.Text = "ス"
        ElseIf ListBox1.Text = "ta" Then
            TextBox2.Text = "タ"
            Label3.Text = "タ"
        ElseIf ListBox1.Text = "te" Then
            TextBox2.Text = "テ"
            Label3.Text = "テ"
        ElseIf ListBox1.Text = "to" Then
            TextBox2.Text = "ト"
            Label3.Text = "ト"
        ElseIf ListBox1.Text = "tsu" Then
            TextBox2.Text = "ツ"
            Label3.Text = "ツ"
        ElseIf ListBox1.Text = "u" Then
            TextBox2.Text = "ウ"
            Label3.Text = "ウ"
        ElseIf ListBox1.Text = "wa" Then
            TextBox2.Text = "ワ"
            Label3.Text = "ワ"
        ElseIf ListBox1.Text = "wo" Then
            TextBox2.Text = "ヲ"
            Label3.Text = "ヲ"
        ElseIf ListBox1.Text = "ya" Then
            TextBox2.Text = "ヤ"
            Label3.Text = "ヤ"
        ElseIf ListBox1.Text = "yo" Then
            TextBox2.Text = "ヨ"
            Label3.Text = "ヨ"
        ElseIf ListBox1.Text = "yu" Then
            TextBox2.Text = "ユ"
            Label3.Text = "ユ"
        ElseIf ListBox1.Text = "za" Then
            TextBox2.Text = "ザ"
            Label3.Text = "ザ"
        ElseIf ListBox1.Text = "ze" Then
            TextBox2.Text = "ゼ"
            Label3.Text = "ゼ"
        ElseIf ListBox1.Text = "zo" Then
            TextBox2.Text = "ゾ"
            Label3.Text = "ゾ"
        ElseIf ListBox1.Text = "zu" Then
            TextBox2.Text = "ズ"
            Label3.Text = "ズ"
        ElseIf ListBox1.Text = "shi" Then
            TextBox2.Text = "シ"
            Label3.Text = "シ"
        ElseIf ListBox1.Text = "fu" Then
            TextBox2.Text = "フ"
            Label3.Text = "フ"
        ElseIf ListBox1.Text = "a_pequeno" Then
            TextBox2.Text = "ァ"
            Label3.Text = "ァ"
        ElseIf ListBox1.Text = "i_pequeno" Then
            TextBox2.Text = "ィ"
            Label3.Text = "ィ"
        ElseIf ListBox1.Text = "e_pequeno" Then
            TextBox2.Text = "ェ"
            Label3.Text = "ェ"
        ElseIf ListBox1.Text = "o_pequeno" Then
            TextBox2.Text = "ォ"
            Label3.Text = "ォ"
        ElseIf ListBox1.Text = "tsu_pequeno" Then
            TextBox2.Text = "ッ"
            Label3.Text = "ッ"
        ElseIf ListBox1.Text = "ya_pequeno" Then
            TextBox2.Text = "ャ"
            Label3.Text = "ャ"
        ElseIf ListBox1.Text = "yu_pequeno" Then
            TextBox2.Text = "ュ"
            Label3.Text = "ュ"
        ElseIf ListBox1.Text = "yo_pequeno" Then
            TextBox2.Text = "ョ"
            Label3.Text = "ョ"
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox4.Text = ""
        If ListBox2.Text = "a" Then
            TextBox3.Text = "あ"
            Label7.Text = "あ"
        ElseIf ListBox2.Text = "ba" Then
            TextBox3.Text = "ば"
            Label7.Text = "ば"
        ElseIf ListBox2.Text = "be" Then
            TextBox3.Text = "べ"
            Label7.Text = "べ"
        ElseIf ListBox2.Text = "bi" Then
            TextBox3.Text = "び"
            Label7.Text = "び"
        ElseIf ListBox2.Text = "bo" Then
            TextBox3.Text = "ぼ"
            Label7.Text = "ぼ"
        ElseIf ListBox2.Text = "bu" Then
            TextBox3.Text = "ぶ"
            Label7.Text = "ぶ"
        ElseIf ListBox2.Text = "chi" Then
            TextBox3.Text = "ち"
            Label7.Text = "ち"
        ElseIf ListBox2.Text = "da" Then
            TextBox3.Text = "だ"
            Label7.Text = "だ"
        ElseIf ListBox2.Text = "de" Then
            TextBox3.Text = "で"
            Label7.Text = "で"
        ElseIf ListBox2.Text = "dji" Then
            TextBox3.Text = "ぢ"
            Label7.Text = "ぢ"
        ElseIf ListBox2.Text = "do" Then
            TextBox3.Text = "ど"
            Label7.Text = "ど"
        ElseIf ListBox2.Text = "dzu" Then
            TextBox3.Text = "づ"
            Label7.Text = "づ"
        ElseIf ListBox2.Text = "e" Then
            TextBox3.Text = "え"
            Label7.Text = "え"
        ElseIf ListBox2.Text = "ga" Then
            TextBox3.Text = "が"
            Label7.Text = "が"
        ElseIf ListBox2.Text = "ge" Then
            TextBox3.Text = "げ"
            Label7.Text = "げ"
        ElseIf ListBox2.Text = "gi" Then
            TextBox3.Text = "ぎ"
            Label7.Text = "ぎ"
        ElseIf ListBox2.Text = "go" Then
            TextBox3.Text = "ご"
            Label7.Text = "ご"
        ElseIf ListBox2.Text = "gu" Then
            TextBox3.Text = "ぐ"
            Label7.Text = "ぐ"
        ElseIf ListBox2.Text = "ha" Then
            TextBox3.Text = "は"
            Label7.Text = "は"
        ElseIf ListBox2.Text = "he" Then
            TextBox3.Text = "へ"
            Label7.Text = "へ"
        ElseIf ListBox2.Text = "hi" Then
            TextBox3.Text = "ひ"
            Label7.Text = "ひ"
        ElseIf ListBox2.Text = "ho" Then
            TextBox3.Text = "ほ"
            Label7.Text = "ほ"
        ElseIf ListBox2.Text = "i" Then
            TextBox3.Text = "い"
            Label7.Text = "い"
        ElseIf ListBox2.Text = "ji" Then
            TextBox3.Text = "じ"
            Label7.Text = "じ"
        ElseIf ListBox2.Text = "ka" Then
            TextBox3.Text = "か"
            Label7.Text = "か"
        ElseIf ListBox2.Text = "ke" Then
            TextBox3.Text = "け"
            Label7.Text = "け"
        ElseIf ListBox2.Text = "ki" Then
            TextBox3.Text = "き"
            Label7.Text = "き"
        ElseIf ListBox2.Text = "ko" Then
            TextBox3.Text = "こ"
            Label7.Text = "こ"
        ElseIf ListBox2.Text = "ku" Then
            TextBox3.Text = "く"
            Label7.Text = "く"
        ElseIf ListBox2.Text = "ma" Then
            TextBox3.Text = "ま"
            Label7.Text = "ま"
        ElseIf ListBox2.Text = "me" Then
            TextBox3.Text = "め"
            Label7.Text = "め"
        ElseIf ListBox2.Text = "mi" Then
            TextBox3.Text = "み"
            Label7.Text = "み"
        ElseIf ListBox2.Text = "mo" Then
            TextBox3.Text = "も"
            Label7.Text = "も"
        ElseIf ListBox2.Text = "mu" Then
            TextBox3.Text = "む"
            Label7.Text = "む"
        ElseIf ListBox2.Text = "n" Then
            TextBox3.Text = "ん"
            Label7.Text = "ん"
        ElseIf ListBox2.Text = "na" Then
            TextBox3.Text = "な"
            Label7.Text = "な"
        ElseIf ListBox2.Text = "ne" Then
            TextBox3.Text = "ね"
            Label7.Text = "ね"
        ElseIf ListBox2.Text = "ni" Then
            TextBox3.Text = "に"
            Label7.Text = "に"
        ElseIf ListBox2.Text = "no" Then
            TextBox3.Text = "の"
            Label7.Text = "の"
        ElseIf ListBox2.Text = "nu" Then
            TextBox3.Text = "ぬ"
            Label7.Text = "ぬ"
        ElseIf ListBox2.Text = "o" Then
            TextBox3.Text = "お"
            Label7.Text = "お"
        ElseIf ListBox2.Text = "pa" Then
            TextBox3.Text = "ぱ"
            Label7.Text = "ぱ"
        ElseIf ListBox2.Text = "pe" Then
            TextBox3.Text = "ぺ"
            Label7.Text = "ぺ"
        ElseIf ListBox2.Text = "pi" Then
            TextBox3.Text = "ぴ"
            Label7.Text = "ぴ"
        ElseIf ListBox2.Text = "po" Then
            TextBox3.Text = "ぽ"
            Label7.Text = "ぽ"
        ElseIf ListBox2.Text = "pu" Then
            TextBox3.Text = "ぷ"
            Label7.Text = "ぷ"
        ElseIf ListBox2.Text = "ra" Then
            TextBox3.Text = "ら"
            Label7.Text = "ら"
        ElseIf ListBox2.Text = "re" Then
            TextBox3.Text = "れ"
            Label7.Text = "れ"
        ElseIf ListBox2.Text = "ri" Then
            TextBox3.Text = "り"
            Label7.Text = "り"
        ElseIf ListBox2.Text = "ro" Then
            TextBox3.Text = "ろ"
            Label7.Text = "ろ"
        ElseIf ListBox2.Text = "ru" Then
            TextBox3.Text = "る"
            Label7.Text = "る"
        ElseIf ListBox2.Text = "sa" Then
            TextBox3.Text = "さ"
            Label7.Text = "さ"
        ElseIf ListBox2.Text = "se" Then
            TextBox3.Text = "せ"
            Label7.Text = "せ"
        ElseIf ListBox2.Text = "so" Then
            TextBox3.Text = "そ"
            Label7.Text = "そ"
        ElseIf ListBox2.Text = "su" Then
            TextBox3.Text = "す"
            Label7.Text = "す"
        ElseIf ListBox2.Text = "ta" Then
            TextBox3.Text = "た"
            Label7.Text = "た"
        ElseIf ListBox2.Text = "te" Then
            TextBox3.Text = "て"
            Label7.Text = "て"
        ElseIf ListBox2.Text = "to" Then
            TextBox3.Text = "と"
            Label7.Text = "と"
        ElseIf ListBox2.Text = "tsu" Then
            TextBox3.Text = "つ"
            Label7.Text = "つ"
        ElseIf ListBox2.Text = "u" Then
            TextBox3.Text = "う"
            Label7.Text = "う"
        ElseIf ListBox2.Text = "wa" Then
            TextBox3.Text = "わ"
            Label7.Text = "わ"
        ElseIf ListBox2.Text = "wo" Then
            TextBox3.Text = "を"
            Label7.Text = "を"
        ElseIf ListBox2.Text = "ya" Then
            TextBox3.Text = "や"
            Label7.Text = "や"
        ElseIf ListBox2.Text = "yo" Then
            TextBox3.Text = "よ"
            Label7.Text = "よ"
        ElseIf ListBox2.Text = "yu" Then
            TextBox3.Text = "ゆ"
            Label7.Text = "ゆ"
        ElseIf ListBox2.Text = "za" Then
            TextBox3.Text = "ざ"
            Label7.Text = "ざ"
        ElseIf ListBox2.Text = "ze" Then
            TextBox3.Text = "ぜ"
            Label7.Text = "ぜ"
        ElseIf ListBox2.Text = "zo" Then
            TextBox3.Text = "ぞ"
            Label7.Text = "ぞ"
        ElseIf ListBox2.Text = "zu" Then
            TextBox3.Text = "ず"
            Label7.Text = "ず"
        ElseIf ListBox2.Text = "shi" Then
            TextBox3.Text = "し"
            Label7.Text = "し"
        ElseIf ListBox2.Text = "fu" Then
            TextBox3.Text = "ふ"
            Label7.Text = "ふ"
        ElseIf ListBox2.Text = "a_pequeno" Then
            TextBox3.Text = "ぁ"
            Label7.Text = "ぁ"
        ElseIf ListBox2.Text = "i_pequeno" Then
            TextBox3.Text = "ぃ"
            Label7.Text = "ぃ"
        ElseIf ListBox2.Text = "e_pequeno" Then
            TextBox3.Text = "ぇ"
            Label7.Text = "ぇ"
        ElseIf ListBox2.Text = "o_pequeno" Then
            TextBox3.Text = "ぉ"
            Label7.Text = "ぉ"
        ElseIf ListBox2.Text = "tsu_pequeno" Then
            TextBox3.Text = "っ"
            Label7.Text = "っ"
        ElseIf ListBox2.Text = "ya_pequeno" Then
            TextBox3.Text = "ゃ"
            Label7.Text = "ゃ"
        ElseIf ListBox2.Text = "yu_pequeno" Then
            TextBox3.Text = "ゅ"
            Label7.Text = "ゅ"
        ElseIf ListBox2.Text = "yo_pequeno" Then
            TextBox3.Text = "ょ"
            Label7.Text = "ょ"
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button2_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Text = LCase(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox2.Text = LCase(TextBox4.Text)
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            Button3_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Form22_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu22 = False
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu22 = True
    End Sub
End Class
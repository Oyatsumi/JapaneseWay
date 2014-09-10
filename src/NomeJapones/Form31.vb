Public Class Form31
    Dim contagem As Double
    Dim frasecerta As String
    Dim frasedois As String
    Dim frasetres As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frase As String
        FileOpen(1, "frases_particula.jp", OpenMode.Input)
        Do Until contagem = 0
            Input(1, frase)
            Label1.Text = frase
            contagem = contagem - 1
        Loop
        FileClose(1)
    End Sub

    Private Sub Form31_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu31 = False
    End Sub

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu31 = True
        contagem = 1
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = 1 Then
            contagem = ComboBox1.SelectedItem
        ElseIf ComboBox1.SelectedItem = 2 Then
            contagem = 5
        ElseIf ComboBox1.SelectedItem = 3 Then
            contagem = 9
        ElseIf ComboBox1.SelectedItem = 4 Then
            contagem = 13
        ElseIf ComboBox1.SelectedItem > 4 Then
            contagem = ComboBox1.SelectedItem * 4 - 3
        End If

        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True

        Dim frase As String
        FileOpen(1, "arquivos_jp\dia_a_dia.jp", OpenMode.Input)
        Do Until contagem = 0
            Input(1, frase)
            Label1.Text = frase
            contagem = contagem - 1
        Loop
        Input(1, frasecerta)
        Input(1, frasedois)
        Input(1, frasetres)
        FileClose(1)


        Dim rand As New Random
        Dim combinacao = rand.Next(1, 7)
        Dim botaoum, botaodois, botaotres As String

        If combinacao = "1" Then
            botaoum = frasedois
            botaodois = frasetres
            botaotres = frasecerta
        ElseIf combinacao = "2" Then
            botaoum = frasetres
            botaodois = frasedois
            botaotres = frasecerta
        ElseIf combinacao = "3" Then
            botaoum = frasetres
            botaodois = frasecerta
            botaotres = frasedois
        ElseIf combinacao = "4" Then
            botaoum = frasecerta
            botaodois = frasetres
            botaotres = frasedois
        ElseIf combinacao = "5" Then
            botaoum = frasecerta
            botaodois = frasedois
            botaotres = frasetres
        Else
            botaoum = frasedois
            botaodois = frasecerta
            botaotres = frasetres
        End If

        Button4.Text = botaoum
        Button5.Text = botaodois
        Button6.Text = botaotres


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If frasecerta = "" Then
            MsgBox("Primeiro escolha uma frase!", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else
            MsgBox("A resposta certa é: " & frasecerta, MsgBoxStyle.OkOnly, "JapaneseWay")
        End If
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form29_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim rand As New Random()
        Dim number = rand.Next(0, 44)
        ComboBox1.SelectedIndex = number
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form30.Show()
        Form30.Focus()
        Form30.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form30.Visible = False Then
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "" Then
            MsgBox("Primeiro escolha uma frase!", MsgBoxStyle.Critical, "JapaneseWay")
        ElseIf Button4.Text = frasecerta Then
            MsgBox("Parabéns! Sua resposta está correta!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Label2.Text = Label2.Text + 1
            Label8.Text = Label8.Text + 1
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
        Else
            MsgBox("Sua resposta está errada. Tente novamente!", MsgBoxStyle.Critical, "JapaneseWay")
            Label3.Text = Label3.Text + 1
            Label8.Text = Label8.Text + 1
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "" Then
            MsgBox("Primeiro escolha uma frase!", MsgBoxStyle.Critical, "JapaneseWay")
        ElseIf Button5.Text = frasecerta Then
            MsgBox("Parabéns! Sua resposta está correta!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Label2.Text = Label2.Text + 1
            Label8.Text = Label8.Text + 1
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
        Else
            MsgBox("Sua resposta está errada. Tente novamente!", MsgBoxStyle.Critical, "JapaneseWay")
            Label3.Text = Label3.Text + 1
            Label8.Text = Label8.Text + 1
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Text = "" Then
            MsgBox("Primeiro escolha uma frase!", MsgBoxStyle.Critical, "JapaneseWay")
        ElseIf Button6.Text = frasecerta Then
            MsgBox("Parabéns! Sua resposta está correta!", MsgBoxStyle.OkOnly, "JapaneseWay")
            Label2.Text = Label2.Text + 1
            Label8.Text = Label8.Text + 1
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
        Else
            MsgBox("Sua resposta está errada. Tente novamente!", MsgBoxStyle.Critical, "JapaneseWay")
            Label3.Text = Label3.Text + 1
            Label8.Text = Label8.Text + 1
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
        End If
    End Sub
End Class
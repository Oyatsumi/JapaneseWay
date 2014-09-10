Public Class Form30
    Dim contagem As String
    Dim numero As Double
    Dim editar As Boolean

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        TextBox2.Text = ListBox2.Text
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button2_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(AcceptButton, AcceptButton)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
        TextBox3.Text = ListBox1.Text
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox3.Text = "" Then
            MsgBox("Primeiro selecione alguma palavra!", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else


            Form17.Show()
            Form17.Focus()
            Form17.WindowState = FormWindowState.Normal
            Form17.TextBox7.Text = ListBox2.Text
            Form17.Button1_Click(AcceptButton, AcceptButton)
            Timer1.Enabled = True
         

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form17.TextBox7.Text = "" Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = False
            Form17.Close()
            MsgBox("Esse kanji não existe ou ainda não foi adicionado.", MsgBoxStyle.Critical, "JapaneseWay")
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form17.Visible = False Then
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Form30_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu30 = False
    End Sub



    Private Sub Form30_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu30 = True


        If dicionario = True Then
            TextBox4.Select()
            TextBox4.Text = dicionario2
            Button1_Click(AcceptButton, AcceptButton)
            dicionario2 = ""
        Else
            TextBox1.Select()
            TextBox1.Text = dicionario2
            Button2_Click(AcceptButton, AcceptButton)
            dicionario2 = ""
        End If
        Dim contagem As Integer
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        numero = 1
       


        If numero = 1 Then
            If ListBox2.SelectedItem = TextBox4.Text Then
                Dim nome, numero, numero2, nome2 As String
                nome = ListBox1.SelectedItem
                numero = ListBox1.SelectedIndex
                numero2 = ListBox2.SelectedIndex
                nome2 = ListBox2.SelectedItem
                ListBox1.Items.Remove(nome)
                ListBox2.Items.Remove(nome2)

                ListBox2.SelectedItem = LCase(TextBox4.Text)
                If ListBox2.SelectedItem <> LCase(TextBox4.Text) Then

                    dicionario = True
                    dicionario2 = TextBox4.Text

                    Close()
                    Form10.Button25_Click(AcceptButton, AcceptButton)

                End If
                If ListBox2.SelectedItem = LCase(TextBox4.Text) Then
                    TextBox4.Text = ""
                End If


                'ListBox1.Items.Insert(numero, nome)
                'ListBox2.Items.Insert(numero2, nome2)
            Else
                ListBox2.SelectedItem = LCase(TextBox4.Text)
                If ListBox2.SelectedItem = LCase(TextBox4.Text) Then
                    TextBox4.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        numero = 1
        



        If numero = 1 Then
            If ListBox1.SelectedItem = TextBox1.Text Then
                Dim nome, numero, numero2, nome2 As String
                nome = ListBox1.SelectedItem
                numero = ListBox1.SelectedIndex
                numero2 = ListBox2.SelectedIndex
                nome2 = ListBox2.SelectedItem
                ListBox1.Items.Remove(nome)
                ListBox2.Items.Remove(nome2)

                ListBox1.SelectedItem = LCase(TextBox1.Text)
                If ListBox1.SelectedItem <> LCase(TextBox1.Text) Then
                    dicionario = False
                    dicionario2 = TextBox1.Text
                    Close()
                    Form10.Button25_Click(AcceptButton, AcceptButton)


                End If
                If ListBox1.SelectedItem = LCase(TextBox1.Text) Then
                    TextBox1.Text = ""
                End If


                'ListBox1.Items.Insert(numero, nome)
                'ListBox2.Items.Insert(numero2, nome2)
            Else
                ListBox1.SelectedItem = LCase(TextBox1.Text)
                If ListBox1.SelectedItem = LCase(TextBox1.Text) Then
                    TextBox1.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Then
            MsgBox("Primeiro selecione alguma palavra!", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else

            If editar = False Then
                MsgBox("Não esqueça de editar corretamente os prolongamentos!", MsgBoxStyle.OkOnly, "JapaneseWay")
                editar = True
            End If
            Form24.Show()
            Form24.Focus()
            Form24.WindowState = FormWindowState.Normal
            Form24.TextBox1.Focus()
            Form24.TextBox1.Select()
            Form24.TabControl1.SelectedIndex = 0

            Dim passando As String
            passando = 1

            Do Until passando = Len(TextBox3.Text) + 1
                Form24.TextBox1.Focus()
                Form24.TextBox1.Select()
                Dim comparar As Boolean

                If Mid(TextBox3.Text, passando + 1, 1) = "a" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "e" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "i" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "o" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "u" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = Chr(0) Then
                    comparar = True
                Else
                    comparar = False
                End If

                If comparar = False Then
                    If Mid(TextBox3.Text, passando, 1) = "n" Then
                        SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                        SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                    Else
                        SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                    End If
                Else
                    SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                End If
                passando = passando + 1
            Loop

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Then
            MsgBox("Primeiro selecione alguma palavra!", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else

            If editar = False Then
                MsgBox("Não esqueça de editar corretamente os prolongamentos!", MsgBoxStyle.OkOnly, "JapaneseWay")
                editar = True
            End If
            Form24.Show()
            Form24.Focus()
            Form24.WindowState = FormWindowState.Normal
            Form24.TextBox2.Focus()
            Form24.TextBox2.Select()
            Form24.TabControl1.SelectedIndex = 1

            Dim passando As String
            passando = 1

            Do Until passando = Len(TextBox3.Text) + 1
                Form24.TextBox2.Focus()
                Form24.TextBox2.Select()

                Dim comparar As Boolean

                If Mid(TextBox3.Text, passando + 1, 1) = "a" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "e" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "i" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "o" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = "u" Then
                    comparar = True
                ElseIf Mid(TextBox3.Text, passando + 1, 1) = Chr(0) Then
                    comparar = True
                Else
                    comparar = False
                End If

                If comparar = False Then
                    If Mid(TextBox3.Text, passando, 1) = "n" Then
                        SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                        SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                    Else
                        SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                    End If
                Else
                    SendKeys.Send(Mid(TextBox3.Text, passando, 1))
                End If
                passando = passando + 1

            Loop



        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
        Form10.Button25_Click(AcceptButton, AcceptButton)
    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        contagem = ListBox1.Items.Count
        Label4.Text = "Procurar (" & contagem & " palavras):"
        Label1.Text = "Procurar (" & contagem & " palavras):"
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
Public Class Form10


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form11.Show()
        Form11.Focus()
        Form11.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Form1.Focus()
        Form1.WindowState = FormWindowState.Normal

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tamanho As Double
        'Mostrar informações, aulas, explicações e instalar fontes >>
        If Button2.Text = "Mostrar informações, aulas e explicações >>" Then
            tamanho = 348
            Do Until tamanho >= 658
                tamanho = tamanho + 50
                Height = 574
                Width = tamanho
                MaximumSize = New Size(658, 574)
            Loop
            MaximumSize = New Size(658, 574)
            Button2.Text = "Fechar informações, aulas e explicações <<"
        ElseIf Button2.Text = "Fechar informações, aulas e explicações <<" Then
            tamanho = 658
            Do Until tamanho <= 348
                tamanho = tamanho - 50
                Height = 574
                Width = tamanho
                MaximumSize = New Size(tamanho, 574)

            Loop

            MaximumSize = New Size(348, 574)
            Size = New Size(348, 574)
            Button2.Text = "Mostrar informações, aulas e explicações >>"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.Show()
        Form4.Focus()
        Form4.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()
        Form3.Focus()
        Form3.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form8.Show()
        Form8.Focus()
        Form8.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form9.Show()
        Form9.Focus()
        Form9.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tamanho As Double
        tamanho = 350
        '341; 252 final
        '341; 176 inicial
        Do Until tamanho = 338
            tamanho = tamanho - 2
            Height = tamanho
            Width = 338
            MaximumSize = New Size(338, 338)
        Loop
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button10.Visible = True
        Button12.Visible = True
        Button14.Visible = True
        Button15.Visible = True
        Button19.Visible = True
        Button18.Visible = True
        Button20.Visible = True
        Button21.Visible = True
        GroupBox1.Visible = True
    End Sub

    Private Sub Form10_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form10_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form37.Close()
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form12.Show()
        Form12.Focus()
        Form12.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form13.Show()
        Form13.Focus()
        Form13.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form14.Show()
        Form14.Focus()
        Form14.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form16.Show()
        Form16.Focus()
        Form16.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form15.Show()
        Form15.Focus()
        Form15.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Form17.Show()
        Form17.Focus()
        Form17.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Form20.Show()
        Form20.Focus()
        Form20.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Form21.Show()
        Form21.Focus()
        Form21.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If System.IO.File.Exists("fonts\kochi-gothic-subst.ttf") = True Then
            Button2.ForeColor = Color.Red
            Button17.ForeColor = Color.Red

        Else

        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Form22.Show()
        Form22.Focus()
        Form22.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form23.Show()
        Form23.Focus()
        Form23.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Form24.Show()
        Form24.Focus()
        Form24.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form25.Show()
        Form25.Focus()
        Form25.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form27.Show()
        Form27.Focus()
        Form27.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Form28.Show()
        Form28.Focus()
        Form28.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Form29.Show()
        Form29.Focus()
        Form29.WindowState = FormWindowState.Normal
    End Sub

    Public Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Form30.Show()
        Form30.Focus()
        Form30.WindowState = FormWindowState.Normal
    End Sub

    Private Sub topmostall_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click


        If formu1 = True Then
            Form1.BringToFront()
            Form1.WindowState = FormWindowState.Normal
        End If
        If formu2 = True Then
            Form2.BringToFront()
            Form2.WindowState = FormWindowState.Normal
        End If
        If formu3 = True Then
            Form3.BringToFront()
            Form3.WindowState = FormWindowState.Normal
        End If
        If formu4 = True Then
            Form4.BringToFront()
            Form4.WindowState = FormWindowState.Normal
        End If
        If formu5 = True Then
            Form5.BringToFront()
            Form5.WindowState = FormWindowState.Normal
        End If
        If formu6 = True Then
            Form6.BringToFront()
            Form6.WindowState = FormWindowState.Normal
        End If
        If formu7 = True Then
            Form7.BringToFront()
            Form7.WindowState = FormWindowState.Normal
        End If
        If formu8 = True Then
            Form8.BringToFront()
            Form8.WindowState = FormWindowState.Normal
        End If
        If formu9 = True Then
            Form9.BringToFront()
            Form9.WindowState = FormWindowState.Normal
        End If
        If formu11 = True Then
            Form11.BringToFront()
            Form11.WindowState = FormWindowState.Normal
        End If
        If formu12 = True Then
            Form12.BringToFront()
            Form12.WindowState = FormWindowState.Normal
        End If
        If formu13 = True Then
            Form13.BringToFront()
            Form13.WindowState = FormWindowState.Normal
        End If
        If formu14 = True Then
            Form14.BringToFront()
            Form14.WindowState = FormWindowState.Normal
        End If
        If formu15 = True Then
            Form15.BringToFront()
            Form15.WindowState = FormWindowState.Normal
        End If
        If formu16 = True Then
            Form16.BringToFront()
            Form16.WindowState = FormWindowState.Normal
        End If
        If formu17 = True Then
            Form17.BringToFront()
            Form17.WindowState = FormWindowState.Normal
        End If
        If formu19 = True Then
            Form19.BringToFront()
            Form19.WindowState = FormWindowState.Normal
        End If
        If formu20 = True Then
            Form20.BringToFront()
            Form20.WindowState = FormWindowState.Normal
        End If
        If formu21 = True Then
            Form21.BringToFront()
            Form21.WindowState = FormWindowState.Normal
        End If
        If formu22 = True Then
            Form22.BringToFront()
            Form22.WindowState = FormWindowState.Normal
        End If
        If formu23 = True Then
            Form23.BringToFront()
            Form23.WindowState = FormWindowState.Normal
        End If
        If formu24 = True Then
            Form24.BringToFront()
            Form24.WindowState = FormWindowState.Normal
        End If
        If formu25 = True Then
            Form25.BringToFront()
            Form25.WindowState = FormWindowState.Normal
        End If
        If formu26 = True Then
            Form26.BringToFront()
            Form26.WindowState = FormWindowState.Normal
        End If
        If formu27 = True Then
            Form27.BringToFront()
            Form27.WindowState = FormWindowState.Normal
        End If
        If formu28 = True Then
            Form28.BringToFront()
            Form28.WindowState = FormWindowState.Normal
        End If
        If formu29 = True Then
            Form29.BringToFront()
            Form29.WindowState = FormWindowState.Normal
        End If
        If formu30 = True Then
            Form30.BringToFront()
            Form30.WindowState = FormWindowState.Normal
        End If
        If formu31 = True Then
            Form31.BringToFront()
            Form31.WindowState = FormWindowState.Normal
        End If
        If formu32 = True Then
            Form32.BringToFront()
            Form32.WindowState = FormWindowState.Normal
        End If
        If formu33 = True Then
            Form33.BringToFront()
            Form33.WindowState = FormWindowState.Normal
        End If
        If formu34 = True Then
            Form34.BringToFront()
            Form34.WindowState = FormWindowState.Normal
        End If
        If formu35 = True Then
            Form35.BringToFront()
            Form35.WindowState = FormWindowState.Normal
        End If
        If formu36 = True Then
            Form36.BringToFront()
            Form36.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Form31.Show()
        Form31.Focus()
        Form31.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Form32.Show()
        Form32.Focus()
        Form32.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Form34.Show()
        Form34.Focus()
        Form34.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Form33.Show()
        Form33.Focus()
        Form33.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form35.Show()
        Form35.Focus()
        Form35.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form36.Show()
        Form36.Focus()
        Form36.WindowState = FormWindowState.Normal
    End Sub
End Class
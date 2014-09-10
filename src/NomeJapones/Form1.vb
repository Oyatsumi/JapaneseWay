Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Form1

    Inherits System.Windows.Forms.Form
    Dim pnumeros As Integer
    Dim nomecompleto As String
    Dim ultimo As Integer
    Dim primeiro As Boolean
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        PictureBox1.ImageLocation = ""
        PictureBox2.ImageLocation = ""
        PictureBox3.ImageLocation = ""
        PictureBox4.ImageLocation = ""
        PictureBox5.ImageLocation = ""
        PictureBox6.ImageLocation = ""
        PictureBox7.ImageLocation = ""
        PictureBox8.ImageLocation = ""
        PictureBox9.ImageLocation = ""
        PictureBox10.ImageLocation = ""
        PictureBox11.ImageLocation = ""
        PictureBox12.ImageLocation = ""
        PictureBox13.ImageLocation = ""
        PictureBox14.ImageLocation = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        primeiro = False
        japones.Text = ""
        PictureBox1.ImageLocation = ""
        PictureBox2.ImageLocation = ""
        PictureBox3.ImageLocation = ""
        PictureBox4.ImageLocation = ""
        PictureBox5.ImageLocation = ""
        PictureBox6.ImageLocation = ""
        PictureBox7.ImageLocation = ""
        PictureBox8.ImageLocation = ""
        PictureBox9.ImageLocation = ""
        PictureBox10.ImageLocation = ""
        PictureBox11.ImageLocation = ""
        PictureBox12.ImageLocation = ""
        PictureBox13.ImageLocation = ""
        PictureBox14.ImageLocation = ""
        p1.Text = ""
        p2.Text = ""
        p3.Text = ""
        p4.Text = ""
        p5.Text = ""
        p6.Text = ""
        p7.Text = ""
        p8.Text = ""
        p9.Text = ""
        p10.Text = ""
        p11.Text = ""
        p12.Text = ""
        p13.Text = ""
        p14.Text = ""

        pnumeros = 1

        Timer1.Enabled = True
        CheckBox1.Checked = True




















        On Error GoTo erro
        Dim texto As String
        Dim imagem As String
        Dim imagemdois As String
        Dim contagem As Integer
        Dim contagem2 As Integer
        contagem = 1
        contagem2 = 3
        texto = Mid(TextBox1.Text, contagem, contagem2)
        Do Until texto = ""
            texto = Mid(TextBox1.Text, contagem, contagem2)
            'MsgBox(texto)

            'NOVOS
            'On Error GoTo ha
            If Len(texto) <> 1 Then
                If Mid(texto, 1, 1) = Mid(texto, 2, 1) Then
                    If Mid(texto, 1, 1) = Mid(texto, 3, 1) Then
                        texto = Mid(texto, 1, 1)
                    Else
                        texto = Mid(texto, 2)
                    End If
                ElseIf Mid(texto, 2, 1) = Mid(texto, 3, 1) Then
                    If Mid(texto, 2, 1) = Mid(texto, 1, 1) Then
                        texto = Mid(texto, 1, 1)
                    Else
                        texto = Mid(texto, 1, Len(texto) - 1)
                    End If
                End If
            End If
            'ha:




            If texto = "a" Then
                CheckBox1.Checked = False
                imagem = "imagens\a.png"

                'acentos
            ElseIf texto = "crá" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ra.png"
            ElseIf texto = "cré" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\re.png"
            ElseIf texto = "crí" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "cró" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "crú" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ru.png"
            ElseIf texto = "brá" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ra.png"
            ElseIf texto = "bré" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\re.png"
            ElseIf texto = "brí" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "bró" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "brú" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ru.png"


            ElseIf texto = "é" Then
                CheckBox1.Checked = False
                imagem = "imagens\e.png"
            ElseIf texto = "h" Then
                CheckBox1.Checked = False
            ElseIf texto = "â" Then
                CheckBox1.Checked = False
                imagem = "imagens\a.png"
            ElseIf texto = "ô" Then
                CheckBox1.Checked = False
                imagem = "imagens\o.png"

            ElseIf texto = "á" Then
                CheckBox1.Checked = False
                imagem = "imagens\a.png"
            ElseIf texto = "e" Then
                CheckBox1.Checked = False
                imagem = "imagens\e.png"
            ElseIf texto = "i" Then
                CheckBox1.Checked = False
                imagem = "imagens\i.png"
            ElseIf texto = "o" Then
                CheckBox1.Checked = False
                imagem = "imagens\o.png"
            ElseIf texto = "u" Then
                CheckBox1.Checked = False
                imagem = "imagens\u.png"
            ElseIf texto = "ó" Then
                CheckBox1.Checked = False
                imagem = "imagens\o.png"
            ElseIf texto = "ú" Then
                CheckBox1.Checked = False
                imagem = "imagens\u.png"
            ElseIf texto = "sh" Then
                CheckBox1.Checked = False
                imagem = "imagens\shi.png"
            ElseIf texto = "ch" Then
                CheckBox1.Checked = False
                imagem = "imagens\shi.png"









                'ç
            ElseIf texto = "ça" Then
                CheckBox1.Checked = False
                imagem = "imagens\sa.png"
            ElseIf texto = "çe" Then
                CheckBox1.Checked = False
                imagem = "imagens\se.png"
            ElseIf texto = "çi" Then
                CheckBox1.Checked = False
                imagem = "imagens\si.png"
            ElseIf texto = "ço" Then
                imagem = "imagens\so.png"
                CheckBox1.Checked = False
            ElseIf texto = "çu" Then
                CheckBox1.Checked = False
                imagem = "imagens\su.png"
            ElseIf texto = "ç" Then
                CheckBox1.Checked = False
                imagem = "imagens\sa.png"
                'ç


                'l depois da silaba



                'com r depois das silabas
                'nhanho
            ElseIf texto = "nha" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\a.png"
            ElseIf texto = "nhe" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\e.png"
            ElseIf texto = "nhi" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\i.png"
            ElseIf texto = "nho" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\o.png"
            ElseIf texto = "nhu" Then
                CheckBox1.Checked = False
                imagem = "imagens\n.png"
                imagemdois = "imagens\u.png"





                'com r no meio
            ElseIf texto = "bra" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "bre" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "bri" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "bro" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "bru" Then
                CheckBox1.Checked = False
                imagem = "imagens\bu.png"
                imagemdois = "imagens\ru.png"
            ElseIf texto = "cra" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ra.png"
            ElseIf texto = "cre" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\re.png"
            ElseIf texto = "cri" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "cro" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "cru" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                imagemdois = "imagens\ru.png"
            ElseIf texto = "dra" Then
                CheckBox1.Checked = False
                imagem = "imagens\dzu.png"
                imagemdois = "imagens\ra.png"
            ElseIf texto = "dre" Then
                CheckBox1.Checked = False
                imagem = "imagens\duz.png"
                imagemdois = "imagens\re.png"
            ElseIf texto = "dri" Then
                CheckBox1.Checked = False
                imagem = "imagens\dzu.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "dro" Then
                CheckBox1.Checked = False
                imagem = "imagens\dzu.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "dru" Then
                CheckBox1.Checked = False
                imagem = "imagens\dzu.png"
                imagemdois = "imagens\ru.png"
            ElseIf texto = "fra" Then
                CheckBox1.Checked = False
                imagem = "imagens\fu.png"
                imagemdois = "imagens\ra.png"
            ElseIf texto = "fre" Then
                CheckBox1.Checked = False
                imagem = "imagens\fu.png"
                imagemdois = "imagens\re.png"
            ElseIf texto = "fri" Then
                CheckBox1.Checked = False
                imagem = "imagens\fu.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "fro" Then
                CheckBox1.Checked = False
                imagem = "imagens\fu.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "fru" Then
                CheckBox1.Checked = False
                imagem = "imagens\fu.png"
                imagemdois = "imagens\ru.png"
            ElseIf texto = "gra" Then
                CheckBox1.Checked = False
                imagem = "imagens\ga.png"
                imagemdois = "imagens\ra.png"
            ElseIf texto = "gre" Then
                CheckBox1.Checked = False
                imagem = "imagens\ge.png"
                imagemdois = "imagens\re.png"
            ElseIf texto = "gri" Then
                CheckBox1.Checked = False
                imagem = "imagens\gi.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "gro" Then
                CheckBox1.Checked = False
                imagem = "imagens\go.png"
                imagemdois = "imagens\ro.png"
            ElseIf texto = "gru" Then
                imagem = "imagens\gu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "jra" Then
                imagem = "imagens\jyu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "jre" Then
                imagem = "imagens\jyu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "jri" Then
                imagem = "imagens\jyu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "jro" Then
                imagem = "imagens\jyu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "jru" Then
                imagem = "imagens\jyu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "kra" Then
                imagem = "imagens\ka.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "kre" Then
                imagem = "imagens\ke.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "kri" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "kro" Then
                imagem = "imagens\ko.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "kru" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "mra" Then
                imagem = "imagens\ma.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "mre" Then
                imagem = "imagens\me.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "mri" Then
                imagem = "imagens\mi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "mro" Then
                imagem = "imagens\mo.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "mru" Then
                imagem = "imagens\mu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "nra" Then
                imagem = "imagens\na.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "nre" Then
                imagem = "imagens\ne.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "nri" Then
                imagem = "imagens\ni.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "nro" Then
                imagem = "imagens\no.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "nru" Then
                imagem = "imagens\nu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "pra" Then
                imagem = "imagens\pa.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "pre" Then
                imagem = "imagens\pe.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "pri" Then
                imagem = "imagens\pi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "pro" Then
                imagem = "imagens\po.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "pru" Then
                imagem = "imagens\pu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "tra" Then
                imagem = "imagens\ta.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "tre" Then
                imagem = "imagens\te.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "tri" Then
                imagem = "imagens\chi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "try" Then
                CheckBox1.Checked = False
                imagem = "imagens\chi.png"
                imagemdois = "imagens\ri.png"
            ElseIf texto = "tro" Then
                imagem = "imagens\to.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "tru" Then
                imagem = "imagens\tu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "vra" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "vre" Then
                imagem = "imagens\ve.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "vri" Then
                imagem = "imagens\vi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "vro" Then
                imagem = "imagens\vo.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "vru" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"

            ElseIf texto = "xra" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "xre" Then
                imagem = "imagens\shi.png"
                imagemdois = "imagens\re.png"
                CheckBox1.Checked = False
            ElseIf texto = "xri" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "xro" Then
                imagem = "imagens\shi.png"
                imagemdois = "imagens\ro.png"
                CheckBox1.Checked = False
            ElseIf texto = "xru" Then
                imagem = "imagens\shi.png"
                imagemdois = "imagens\ru.png"
                'com n
                CheckBox1.Checked = False

                'COLOCADOS DEPOIS DE TUDO
            ElseIf texto = "b" Then
                imagem = "imagens\be.png"
                CheckBox1.Checked = False

            ElseIf texto = "d" Then
                CheckBox1.Checked = False
                imagem = "imagens\dji.png"
            ElseIf texto = "t" Then
                CheckBox1.Checked = False
                imagem = "imagens\te.png"
            ElseIf texto = "w" Then
                CheckBox1.Checked = False
                imagem = "imagens\u.png"
            ElseIf texto = "bla" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "ble" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "bli" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "blo" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "blu" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "cla" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "cle" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "cli" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "clo" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "clu" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "fla" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "fle" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "fli" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "flo" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "flu" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "gla" Then
                imagem = "imagens\ga.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "gle" Then
                imagem = "imagens\ge.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "gli" Then
                imagem = "imagens\gi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "glo" Then
                imagem = "imagens\go.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "glu" Then
                imagem = "imagens\gu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "pla" Then
                imagem = "imagens\pa.png"
                imagemdois = "imagens\ra.png"
                CheckBox1.Checked = False
            ElseIf texto = "ple" Then
                imagem = "imagens\pe.png"
                imagemdois = "imagens\re.png"
                CheckBox1.Checked = False
            ElseIf texto = "pli" Then
                imagem = "imagens\pi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "plo" Then
                imagem = "imagens\po.png"
                imagemdois = "imagens\ro.png"
                CheckBox1.Checked = False
            ElseIf texto = "plu" Then
                imagem = "imagens\pu.png"
                imagemdois = "imagens\ru.png"
                CheckBox1.Checked = False
            ElseIf texto = "tla" Then
                imagem = "imagens\ta.png"
                imagemdois = "imagens\ra.png"

                CheckBox1.Checked = False
            ElseIf texto = "vla" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "vle" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "vli" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "vlo" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "vlu" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ru.png"
            ElseIf texto = "xla" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ra.png"
            ElseIf texto = "xle" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\re.png"
            ElseIf texto = "xli" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ri.png"
            ElseIf texto = "xlo" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\ro.png"
            ElseIf texto = "xlu" Then
                imagem = "imagens\shi.png"
                imagemdois = "imagens\ru.png"
                CheckBox1.Checked = False
            ElseIf texto = "by" Then
                imagem = "imagens\bi.png"
                CheckBox1.Checked = False
            ElseIf texto = "cy" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "dy" Then
                imagem = "imagens\dji.png"
                CheckBox1.Checked = False
            ElseIf texto = "fy" Then
                imagem = "imagens\fi.png"
                CheckBox1.Checked = False
            ElseIf texto = "gy" Then
                imagem = "imagens\ji.png"
                CheckBox1.Checked = False
            ElseIf texto = "hy" Then
                imagem = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "jy" Then
                imagem = "imagens\ji.png"
                CheckBox1.Checked = False
            ElseIf texto = "ky" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
            ElseIf texto = "ly" Then
                imagem = "imagens\ri.png"
                CheckBox1.Checked = False
            ElseIf texto = "my" Then
                imagem = "imagens\mi.png"
                CheckBox1.Checked = False
            ElseIf texto = "ny" Then
                imagem = "imagens\ni.png"
                CheckBox1.Checked = False
            ElseIf texto = "py" Then
                imagem = "imagens\pi.png"
                CheckBox1.Checked = False
            ElseIf texto = "ry" Then
                imagem = "imagens\ri.png"
                CheckBox1.Checked = False
            ElseIf texto = "sy" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "ty" Then
                imagem = "imagens\chi.png"
                CheckBox1.Checked = False
            ElseIf texto = "vy" Then
                imagem = "imagens\vi.png"
                CheckBox1.Checked = False
            ElseIf texto = "wi" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\i.png"
            ElseIf texto = "xy" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "zy" Then
                CheckBox1.Checked = False
                imagem = "imagens\ji.png"
            ElseIf texto = "ai" Then
                imagem = "imagens\a.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\i.png"
            ElseIf texto = "ei" Then
                imagem = "imagens\e.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\i.png"
            ElseIf texto = "ui" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\i.png"
            ElseIf texto = "ia" Then
                imagem = "imagens\i.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\a.png"
            ElseIf texto = "ie" Then
                imagem = "imagens\i.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\e.png"
            ElseIf texto = "iu" Then
                imagem = "imagens\i.png"
                imagemdois = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "ou" Then
                imagem = "imagens\o.png"
                imagemdois = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "ei" Then
                imagem = "imagens\e.png"
                imagemdois = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "oi" Then
                imagem = "imagens\o.png"
                imagemdois = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "oe" Then
                imagem = "imagens\o.png"
                imagemdois = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "l" Then
                imagem = "imagens\ru.png"
                CheckBox1.Checked = False
            ElseIf texto = "f" Then
                imagem = "imagens\fi.png"
                CheckBox1.Checked = False
            ElseIf texto = "g" Then
                imagem = "imagens\ge.png"
                CheckBox1.Checked = False
            ElseIf texto = "j" Then
                imagem = "imagens\ji.png"
                CheckBox1.Checked = False
            ElseIf texto = "v" Then
                imagem = "imagens\ve.png"
                CheckBox1.Checked = False
            ElseIf texto = "q" Then
                imagem = "imagens\ke.png"
                CheckBox1.Checked = False
            ElseIf texto = "t" Then
                imagem = "imagens\te.png"
                CheckBox1.Checked = False
            ElseIf texto = "z" Then
                imagem = "imagens\su.png"
                CheckBox1.Checked = False


                'colocados agora 2


            ElseIf texto = "ck" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
            ElseIf texto = "c" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
            ElseIf texto = "cko" Then
                imagem = "imagens\ko.png"
                CheckBox1.Checked = False
            ElseIf texto = "cka" Then
                imagem = "imagens\ka.png"
                CheckBox1.Checked = False
            ElseIf texto = "cke" Then
                imagem = "imagens\ke.png"
                CheckBox1.Checked = False
            ElseIf texto = "cki" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
            ElseIf texto = "cku" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
            ElseIf texto = "p" Then
                imagem = "imagens\pe.png"
                CheckBox1.Checked = False
            ElseIf texto = "k" Then
                imagem = "imagens\ka.png"
                CheckBox1.Checked = False
            ElseIf texto = "m" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
            ElseIf texto = "n" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
            ElseIf texto = "r" Then
                imagem = "imagens\ru.png"
                CheckBox1.Checked = False
            ElseIf texto = "s" Then
                imagem = "imagens\su.png"
                CheckBox1.Checked = False

            ElseIf texto = "x" Then
                imagem = "imagens\ki.png"
                imagemdois = "imagens\shi.png"
                CheckBox1.Checked = False

            ElseIf texto = "e" Then
                imagem = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "i" Then
                imagem = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "o" Then
                imagem = "imagens\o.png"
                CheckBox1.Checked = False
            ElseIf texto = "u" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "e" Then
                imagem = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "y" Then
                imagem = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "m" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
            ElseIf texto = "n" Then
                imagem = "imagens\n.png"
                CheckBox1.Checked = False
            ElseIf texto = "ba" Then
                imagem = "imagens\ba.png"
                CheckBox1.Checked = False
            ElseIf texto = "be" Then
                imagem = "imagens\be.png"
                CheckBox1.Checked = False
            ElseIf texto = "bi" Then
                imagem = "imagens\bi.png"
                CheckBox1.Checked = False
            ElseIf texto = "bo" Then
                imagem = "imagens\bo.png"
                CheckBox1.Checked = False
            ElseIf texto = "bu" Then
                imagem = "imagens\bu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ca" Then
                imagem = "imagens\ka.png"
                CheckBox1.Checked = False
            ElseIf texto = "ce" Then
                imagem = "imagens\se.png"
                CheckBox1.Checked = False
            ElseIf texto = "ci" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "co" Then
                imagem = "imagens\ko.png"
                CheckBox1.Checked = False
            ElseIf texto = "cu" Then
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
            ElseIf texto = "da" Then
                imagem = "imagens\da.png"
                CheckBox1.Checked = False
            ElseIf texto = "de" Then
                imagem = "imagens\de.png"
                CheckBox1.Checked = False
            ElseIf texto = "di" Then
                imagem = "imagens\dji.png"
                CheckBox1.Checked = False
            ElseIf texto = "do" Then
                imagem = "imagens\do.png"
                CheckBox1.Checked = False
            ElseIf texto = "du" Then
                imagem = "imagens\dzu.png"
                CheckBox1.Checked = False
            ElseIf texto = "fa" Then
                imagem = "imagens\fa.png"
                CheckBox1.Checked = False
            ElseIf texto = "fe" Then
                imagem = "imagens\fe.png"
                CheckBox1.Checked = False
            ElseIf texto = "fi" Then
                imagem = "imagens\fi.png"
                CheckBox1.Checked = False
            ElseIf texto = "fo" Then
                imagem = "imagens\fo.png"
                CheckBox1.Checked = False
            ElseIf texto = "fu" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ga" Then
                imagem = "imagens\ga.png"
                CheckBox1.Checked = False
            ElseIf texto = "ge" Then
                imagem = "imagens\jye.png"
                CheckBox1.Checked = False
            ElseIf texto = "gi" Then
                imagem = "imagens\ji.png"
                CheckBox1.Checked = False
            ElseIf texto = "go" Then
                imagem = "imagens\go.png"
                CheckBox1.Checked = False
            ElseIf texto = "gu" Then
                imagem = "imagens\gu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ha" Then
                imagem = "imagens\ra.png"
                CheckBox1.Checked = False
            ElseIf texto = "he" Then
                imagem = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "hi" Then
                imagem = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "ho" Then
                imagem = "imagens\o.png"
                CheckBox1.Checked = False
            ElseIf texto = "hu" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "ja" Then
                imagem = "imagens\jya.png"
                CheckBox1.Checked = False
            ElseIf texto = "je" Then
                imagem = "imagens\jye.png"
                CheckBox1.Checked = False
            ElseIf texto = "ji" Then
                imagem = "imagens\ji.png"
                CheckBox1.Checked = False
            ElseIf texto = "jo" Then
                imagem = "imagens\jyo.png"
                CheckBox1.Checked = False
            ElseIf texto = "ju" Then
                imagem = "imagens\jyu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ka" Then
                imagem = "imagens\ka.png"
                CheckBox1.Checked = False
            ElseIf texto = "ke" Then
                imagem = "imagens\ke.png"
                CheckBox1.Checked = False
            ElseIf texto = "ki" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
            ElseIf texto = "ko" Then
                imagem = "imagens\ko.png"
                CheckBox1.Checked = False
            ElseIf texto = "ku" Then
                CheckBox1.Checked = False
                imagem = "imagens\ku.png"
                CheckBox1.Checked = False
            ElseIf texto = "la" Then
                imagem = "imagens\ra.png"
                CheckBox1.Checked = False
            ElseIf texto = "le" Then
                imagem = "imagens\re.png"
                CheckBox1.Checked = False
            ElseIf texto = "li" Then
                imagem = "imagens\ri.png"
                CheckBox1.Checked = False
            ElseIf texto = "lo" Then
                imagem = "imagens\ro.png"
                CheckBox1.Checked = False
            ElseIf texto = "lu" Then
                imagem = "imagens\ru.png"
                CheckBox1.Checked = False
            ElseIf texto = "ma" Then
                imagem = "imagens\ma.png"
                CheckBox1.Checked = False
            ElseIf texto = "me" Then
                imagem = "imagens\me.png"
                CheckBox1.Checked = False
            ElseIf texto = "mi" Then
                imagem = "imagens\mi.png"
                CheckBox1.Checked = False
            ElseIf texto = "mo" Then
                imagem = "imagens\mo.png"
                CheckBox1.Checked = False
            ElseIf texto = "mu" Then
                imagem = "imagens\mu.png"
                CheckBox1.Checked = False
            ElseIf texto = "na" Then
                imagem = "imagens\na.png"
                CheckBox1.Checked = False
            ElseIf texto = "ne" Then
                imagem = "imagens\ne.png"
                CheckBox1.Checked = False
            ElseIf texto = "ni" Then
                imagem = "imagens\ni.png"
                CheckBox1.Checked = False
            ElseIf texto = "no" Then
                imagem = "imagens\no.png"
                CheckBox1.Checked = False
            ElseIf texto = "nu" Then
                imagem = "imagens\nu.png"
                CheckBox1.Checked = False
            ElseIf texto = "pa" Then
                imagem = "imagens\pa.png"
                CheckBox1.Checked = False
            ElseIf texto = "pe" Then
                imagem = "imagens\pe.png"
                CheckBox1.Checked = False
            ElseIf texto = "pi" Then
                imagem = "imagens\pi.png"
                CheckBox1.Checked = False
            ElseIf texto = "po" Then
                imagem = "imagens\po.png"
                CheckBox1.Checked = False
            ElseIf texto = "pu" Then
                imagem = "imagens\pu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ra" Then
                imagem = "imagens\ra.png"
                CheckBox1.Checked = False
            ElseIf texto = "re" Then
                imagem = "imagens\re.png"
                CheckBox1.Checked = False
            ElseIf texto = "ri" Then
                imagem = "imagens\ri.png"
                CheckBox1.Checked = False
            ElseIf texto = "ro" Then
                imagem = "imagens\ro.png"
                CheckBox1.Checked = False
            ElseIf texto = "ru" Then
                imagem = "imagens\ru.png"
                CheckBox1.Checked = False
            ElseIf texto = "sa" Then
                imagem = "imagens\za.png"
                CheckBox1.Checked = False
            ElseIf texto = "se" Then
                imagem = "imagens\ze.png"
                CheckBox1.Checked = False
            ElseIf texto = "si" Then
                imagem = "imagens\ji.png"
                CheckBox1.Checked = False
            ElseIf texto = "se" Then
                imagem = "imagens\ze.png"
                CheckBox1.Checked = False
            ElseIf texto = "so" Then
                imagem = "imagens\zo.png"
                CheckBox1.Checked = False
            ElseIf texto = "su" Then
                imagem = "imagens\su.png"
                CheckBox1.Checked = False
            ElseIf texto = "ta" Then
                imagem = "imagens\ta.png"
                CheckBox1.Checked = False
            ElseIf texto = "ti" Then
                imagem = "imagens\chi.png"
                CheckBox1.Checked = False
            ElseIf texto = "tu" Then
                imagem = "imagens\tsu.png"
                CheckBox1.Checked = False
            ElseIf texto = "te" Then
                imagem = "imagens\te.png"
                CheckBox1.Checked = False
            ElseIf texto = "to" Then
                imagem = "imagens\to.png"
                CheckBox1.Checked = False
            ElseIf texto = "va" Then
                imagem = "imagens\va.png"
                CheckBox1.Checked = False
            ElseIf texto = "ve" Then
                imagem = "imagens\ve.png"
                CheckBox1.Checked = False
            ElseIf texto = "vi" Then
                imagem = "imagens\vi.png"
                CheckBox1.Checked = False
            ElseIf texto = "vo" Then
                imagem = "imagens\vo.png"
                CheckBox1.Checked = False
            ElseIf texto = "vu" Then
                imagem = "imagens\vu.png"
                CheckBox1.Checked = False
            ElseIf texto = "wa" Then
                imagem = "imagens\wa.png"
                CheckBox1.Checked = False
            ElseIf texto = "we" Then
                imagem = "imagens\u.png"
                imagemdois = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "wi" Then
                imagem = "imagens\u.png"
                imagemdois = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "wo" Then
                imagem = "imagens\u.png"
                imagemdois = "imagens\o.png"
                CheckBox1.Checked = False
            ElseIf texto = "wu" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "wu" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "wu" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "xa" Then
                imagem = "imagens\sha.png"
                CheckBox1.Checked = False
            ElseIf texto = "xe" Then
                imagem = "imagens\she.png"
                CheckBox1.Checked = False
            ElseIf texto = "xi" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "xo" Then
                imagem = "imagens\sho.png"
                CheckBox1.Checked = False
            ElseIf texto = "xu" Then
                imagem = "imagens\shu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ya" Then
                imagem = "imagens\ya.png"
                CheckBox1.Checked = False
            ElseIf texto = "ye" Then
                imagem = "imagens\i.png"
                imagemdois = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "yu" Then
                imagem = "imagens\yu.png"
                CheckBox1.Checked = False
            ElseIf texto = "yo" Then
                imagem = "imagens\yo.png"
                CheckBox1.Checked = False
            ElseIf texto = "za" Then
                imagem = "imagens\za.png"
                CheckBox1.Checked = False
            ElseIf texto = "ze" Then
                imagem = "imagens\ze.png"
                CheckBox1.Checked = False
            ElseIf texto = "zi" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "zo" Then
                imagem = "imagens\zo.png"
                CheckBox1.Checked = False
            ElseIf texto = "zu" Then
                imagem = "imagens\zu.png"
                CheckBox1.Checked = False
            ElseIf texto = "za" Then
                imagem = "imagens\za.png"
                CheckBox1.Checked = False

                'com tres letras

            ElseIf texto = "cha" Then
                imagem = "imagens\sha.png"
                CheckBox1.Checked = False
            ElseIf texto = "che" Then
                imagem = "imagens\she.png"
                CheckBox1.Checked = False
            ElseIf texto = "chi" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "cho" Then
                imagem = "imagens\sho.png"
                CheckBox1.Checked = False
            ElseIf texto = "chu" Then
                imagem = "imagens\shu.png"
                CheckBox1.Checked = False
            ElseIf texto = "dah" Then
                imagem = "imagens\da.png"
                CheckBox1.Checked = False
            ElseIf texto = "deh" Then
                imagem = "imagens\de.png"
                CheckBox1.Checked = False
            ElseIf texto = "dih" Then
                CheckBox1.Checked = False
                imagem = "imagens\dji.png"
            ElseIf texto = "doh" Then
                imagem = "imagens\do.png"
                CheckBox1.Checked = False
            ElseIf texto = "du" Then
                imagem = "imagens\dzu.png"
                CheckBox1.Checked = False
            ElseIf texto = "dha" Then
                imagem = "imagens\da.png"
                CheckBox1.Checked = False
            ElseIf texto = "dhe" Then
                imagem = "imagens\de.png"
                CheckBox1.Checked = False
            ElseIf texto = "dhi" Then
                imagem = "imagens\dji.png"
                CheckBox1.Checked = False
            ElseIf texto = "dho" Then
                imagem = "imagens\do.png"
                CheckBox1.Checked = False
            ElseIf texto = "dhu" Then
                imagem = "imagens\dzu.png"
                CheckBox1.Checked = False
            ElseIf texto = "gua" Then
                imagem = "imagens\ga.png"
                CheckBox1.Checked = False
            ElseIf texto = "gue" Then
                imagem = "imagens\ge.png"
                CheckBox1.Checked = False
            ElseIf texto = "gui" Then
                imagem = "imagens\gi.png"
                CheckBox1.Checked = False
            ElseIf texto = "guo" Then
                imagem = "imagens\gu.png"
                CheckBox1.Checked = False
                imagemdois = "imagens\o.png"
            ElseIf texto = "lha" Then
                imagem = "imagens\ri.png"
                imagemdois = "imagens\a.png"
                CheckBox1.Checked = False
            ElseIf texto = "lhe" Then
                imagem = "imagens\ri.png"
                imagemdois = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "lhi" Then
                imagem = "imagens\ri.png"
                CheckBox1.Checked = False
            ElseIf texto = "lho" Then
                imagem = "imagens\ri.png"
                imagemdois = "imagens\o.png"
                CheckBox1.Checked = False
            ElseIf texto = "lhu" Then
                imagem = "imagens\ri.png"
                imagemdois = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "qua" Then
                imagem = "imagens\ka.png"
                CheckBox1.Checked = False
            ElseIf texto = "que" Then
                imagem = "imagens\ke.png"
                CheckBox1.Checked = False
            ElseIf texto = "qui" Then
                imagem = "imagens\ki.png"
                CheckBox1.Checked = False
            ElseIf texto = "quo" Then
                imagem = "imagens\ku.png"
                imagemdois = "imagens\o.png"
                CheckBox1.Checked = False
            ElseIf texto = "rha" Then
                imagem = "imagens\ha.png"
                CheckBox1.Checked = False
            ElseIf texto = "rhe" Then
                imagem = "imagens\he.png"
                CheckBox1.Checked = False
            ElseIf texto = "rhi" Then
                imagem = "imagens\hi.png"
                CheckBox1.Checked = False
            ElseIf texto = "rho" Then
                imagem = "imagens\ho.png"
                CheckBox1.Checked = False
            ElseIf texto = "rhu" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
            ElseIf texto = "rra" Then
                imagem = "imagens\ha.png"
                CheckBox1.Checked = False
            ElseIf texto = "rre" Then
                imagem = "imagens\he.png"
                CheckBox1.Checked = False
            ElseIf texto = "rri" Then
                imagem = "imagens\hi.png"
                CheckBox1.Checked = False
            ElseIf texto = "rro" Then
                imagem = "imagens\ho.png"
                CheckBox1.Checked = False
            ElseIf texto = "rru" Then
                imagem = "imagens\fu.png"
                CheckBox1.Checked = False
            ElseIf texto = "sha" Then
                imagem = "imagens\sha.png"
                CheckBox1.Checked = False
            ElseIf texto = "she" Then
                imagem = "imagens\she.png"
                CheckBox1.Checked = False
            ElseIf texto = "shi" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "sho" Then
                imagem = "imagens\sho.png"
                CheckBox1.Checked = False
            ElseIf texto = "shu" Then
                imagem = "imagens\shu.png"
                CheckBox1.Checked = False
            ElseIf texto = "ssa" Then
                imagem = "imagens\sa.png"
                CheckBox1.Checked = False
            ElseIf texto = "sse" Then
                imagem = "imagens\se.png"
                CheckBox1.Checked = False
            ElseIf texto = "ssi" Then
                imagem = "imagens\shi.png"
                CheckBox1.Checked = False
            ElseIf texto = "sso" Then
                imagem = "imagens\so.png"
                CheckBox1.Checked = False
            ElseIf texto = "ssu" Then
                imagem = "imagens\su.png"
                CheckBox1.Checked = False
            ElseIf texto = "tha" Then
                imagem = "imagens\ta.png"
                CheckBox1.Checked = False
            ElseIf texto = "the" Then
                imagem = "imagens\te.png"
                CheckBox1.Checked = False
            ElseIf texto = "thi" Then
                imagem = "imagens\chi.png"
                CheckBox1.Checked = False
            ElseIf texto = "tho" Then
                imagem = "imagens\to.png"
                CheckBox1.Checked = False
            ElseIf texto = "thu" Then
                imagem = "imagens\tu.png"
                CheckBox1.Checked = False
            ElseIf texto = "wha" Then
                imagem = "imagens\wa.png"
                CheckBox1.Checked = False
            ElseIf texto = "whe" Then
                imagem = "imagens\u.png"
                imagemdois = "imagens\e.png"
                CheckBox1.Checked = False
            ElseIf texto = "whi" Then
                imagem = "imagens\u.png"
                imagemdois = "imagens\i.png"
                CheckBox1.Checked = False
            ElseIf texto = "who" Then
                imagem = "imagens\u.png"
                imagemdois = "imagens\o.png"
                CheckBox1.Checked = False
            ElseIf texto = "whu" Then
                imagem = "imagens\u.png"
                CheckBox1.Checked = False
            ElseIf texto = "a" Then
                imagem = "imagens\a.png"
                CheckBox1.Checked = False


            ElseIf TextBox1.Text = "" Then
                CheckBox1.Checked = False
            Else

                If Len(texto) <> 1 Then
                    'MsgBox(ultimo)
                    ultimo = ultimo + contagem2
                    If contagem2 = 3 Then
                        contagem2 = 2
                    ElseIf contagem2 = 2 Then
                        contagem2 = 1
                    End If
                    'contagem2 = contagem2 - 1
                    CheckBox1.Checked = True
                    'topmostf.Enabled = False
                Else
                    GoTo erro
                End If

            End If



            If CheckBox1.Checked = False Then


                contagem = contagem + contagem2
                contagem2 = 3


                If pnumeros = 1 Then
                    PictureBox1.ImageLocation = imagem
                ElseIf pnumeros = 2 Then
                    PictureBox2.ImageLocation = imagem
                ElseIf pnumeros = 3 Then
                    PictureBox3.ImageLocation = imagem
                ElseIf pnumeros = 4 Then
                    PictureBox4.ImageLocation = imagem
                ElseIf pnumeros = 5 Then
                    PictureBox5.ImageLocation = imagem
                ElseIf pnumeros = 6 Then
                    PictureBox6.ImageLocation = imagem
                ElseIf pnumeros = 7 Then
                    PictureBox7.ImageLocation = imagem
                ElseIf pnumeros = 8 Then
                    PictureBox8.ImageLocation = imagem
                ElseIf pnumeros = 9 Then
                    PictureBox9.ImageLocation = imagem
                ElseIf pnumeros = 10 Then
                    PictureBox10.ImageLocation = imagem
                ElseIf pnumeros = 11 Then
                    PictureBox11.ImageLocation = imagem
                ElseIf pnumeros = 12 Then
                    PictureBox12.ImageLocation = imagem
                ElseIf pnumeros = 13 Then
                    PictureBox13.ImageLocation = imagem
                ElseIf pnumeros = 14 Then
                    PictureBox14.ImageLocation = imagem
                End If
                'ProgressBar1.Value = ProgressBar1.Value + 14

                'pronuncia
                Dim jp, jpdois As String
                If Len(imagem) = 15 Then
                    jp = VB.Right(imagem, 7)
                    jpdois = VB.Left(jp, 3)
                ElseIf Len(imagem) = 14 Then
                    jp = VB.Right(imagem, 6)
                    jpdois = VB.Left(jp, 2)
                ElseIf Len(imagem) = 13 Then
                    jp = VB.Right(imagem, 5)
                    jpdois = VB.Left(jp, 1)
                End If
                japones.Text = japones.Text & jpdois
                If imagemdois <> "" Then
                    If Len(imagemdois) = 15 Then
                        jp = VB.Right(imagemdois, 7)
                        jpdois = VB.Left(jp, 3)
                        japones.Text = japones.Text & jpdois
                    ElseIf Len(imagemdois) = 14 Then
                        jp = VB.Right(imagemdois, 6)
                        jpdois = VB.Left(jp, 2)
                        japones.Text = japones.Text & jpdois
                    ElseIf Len(imagemdois) = 13 Then
                        jp = VB.Right(imagemdois, 5)
                        jpdois = VB.Left(jp, 1)
                        japones.Text = japones.Text & jpdois
                    End If
                End If

                'pronuncia





                'FONTE COLOCANDO A FONTE NO PROGRAMA
                If Len(imagem) = 15 Then
                    jp = VB.Right(imagem, 7)
                    jpdois = VB.Left(jp, 3)
                ElseIf Len(imagem) = 14 Then
                    jp = VB.Right(imagem, 6)
                    jpdois = VB.Left(jp, 2)
                ElseIf Len(imagem) = 13 Then
                    jp = VB.Right(imagem, 5)
                    jpdois = VB.Left(jp, 1)
                End If

                'MUDAR AUQIIII
                If pnumeros = 1 Then
                    p1.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p1.Text
                ElseIf pnumeros = 2 Then
                    p2.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p2.Text
                ElseIf pnumeros = 3 Then
                    p3.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p3.Text
                ElseIf pnumeros = 4 Then
                    p4.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p4.Text
                ElseIf pnumeros = 5 Then
                    p5.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p5.Text
                ElseIf pnumeros = 6 Then
                    p6.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p6.Text
                ElseIf pnumeros = 7 Then
                    p7.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p7.Text
                ElseIf pnumeros = 8 Then
                    p8.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p8.Text
                ElseIf pnumeros = 9 Then
                    p9.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p9.Text
                ElseIf pnumeros = 10 Then
                    p10.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p10.Text
                ElseIf pnumeros = 11 Then
                    p11.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p11.Text
                ElseIf pnumeros = 12 Then
                    p12.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p12.Text
                ElseIf pnumeros = 13 Then
                    p13.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p13.Text
                ElseIf pnumeros = 14 Then
                    p14.Text = jpdois
                    pnumeros = pnumeros + 1
                    nomecompleto = nomecompleto & p14.Text
                End If


                If imagemdois <> "" Then
                    If Len(imagemdois) = 15 Then
                        jp = VB.Right(imagemdois, 7)
                        jpdois = VB.Left(jp, 3)
                    ElseIf Len(imagemdois) = 14 Then
                        jp = VB.Right(imagemdois, 6)
                        jpdois = VB.Left(jp, 2)
                    ElseIf Len(imagemdois) = 13 Then
                        jp = VB.Right(imagemdois, 5)
                        jpdois = VB.Left(jp, 1)
                    End If


                    If pnumeros = 1 Then
                        PictureBox1.ImageLocation = imagemdois
                    ElseIf pnumeros = 2 Then
                        PictureBox2.ImageLocation = imagemdois
                    ElseIf pnumeros = 3 Then
                        PictureBox3.ImageLocation = imagemdois
                    ElseIf pnumeros = 4 Then
                        PictureBox4.ImageLocation = imagemdois
                    ElseIf pnumeros = 5 Then
                        PictureBox5.ImageLocation = imagemdois
                    ElseIf pnumeros = 6 Then
                        PictureBox6.ImageLocation = imagemdois
                    ElseIf pnumeros = 7 Then
                        PictureBox7.ImageLocation = imagemdois
                    ElseIf pnumeros = 8 Then
                        PictureBox8.ImageLocation = imagemdois
                    ElseIf pnumeros = 9 Then
                        PictureBox9.ImageLocation = imagemdois
                    ElseIf pnumeros = 10 Then
                        PictureBox10.ImageLocation = imagemdois
                    ElseIf pnumeros = 11 Then
                        PictureBox11.ImageLocation = imagemdois
                    ElseIf pnumeros = 12 Then
                        PictureBox12.ImageLocation = imagemdois
                    ElseIf pnumeros = 13 Then
                        PictureBox13.ImageLocation = imagemdois
                    ElseIf pnumeros = 14 Then
                        PictureBox14.ImageLocation = imagemdois
                    End If


                    If pnumeros = 1 Then
                        p1.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p1.Text
                    ElseIf pnumeros = 2 Then
                        p2.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p2.Text
                    ElseIf pnumeros = 3 Then
                        p3.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p3.Text
                    ElseIf pnumeros = 4 Then
                        p4.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p4.Text
                    ElseIf pnumeros = 5 Then
                        p5.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p5.Text
                    ElseIf pnumeros = 6 Then
                        p6.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p6.Text
                    ElseIf pnumeros = 7 Then
                        p7.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p7.Text
                    ElseIf pnumeros = 8 Then
                        p8.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p8.Text
                    ElseIf pnumeros = 9 Then
                        p9.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p9.Text
                    ElseIf pnumeros = 10 Then
                        p10.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p10.Text
                    ElseIf pnumeros = 11 Then
                        p11.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p11.Text
                    ElseIf pnumeros = 12 Then
                        p12.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p12.Text
                    ElseIf pnumeros = 13 Then
                        p13.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p13.Text
                    ElseIf pnumeros = 14 Then
                        p14.Text = jpdois
                        pnumeros = pnumeros + 1
                        nomecompleto = nomecompleto & p14.Text
                    End If

                    
                    'If PictureBox2.ImageLocation = "" Then
                    '    pnumeros = pnumeros - 1
                    ' End If

                End If
                'TERMINA AQUI






                'If imagemdois = "" Then

                'If primeiro = False Then
                'pnumeros = pnumeros - 1
                '  Else
                'If PictureBox2.ImageLocation = "" Then
                'pnumeros = pnumeros - 1
                'End If
                'End If
                'Else


            End If 'check box

            imagem = ""
            imagemdois = ""


            primeiro = True
        Loop
        Timer1.Enabled = False
        ProgressBar1.Value = 100
        Exit Sub
erro:
        Timer1.Enabled = False
        MsgBox("A caixa de texto possui algum erro de digitação, espaços, acentos... Por favor tente escrever novamente.", MsgBoxStyle.Critical, "JapaneseWay 1.0")

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RegrasParaItilizaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
        Form2.WindowState = FormWindowState.Normal
        Form2.Focus()
        abrirjanela.Text = "form2"
        'topmostf.Enabled = False
    End Sub

    Public Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       
    End Sub



    Private Sub AjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjudaToolStripMenuItem.Click

    End Sub











    Private Sub CuidadosParaSeremTomadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()
        Form3.WindowState = FormWindowState.Normal
        Form3.Focus()
        abrirjanela.Text = "form3"
        'topmostf.Enabled = False
    End Sub

    Private Sub CréditosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
        Form4.WindowState = FormWindowState.Normal
        'topmostf.Enabled = False
        abrirjanela.Text = "form4"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form5.Show()
        Form5.WindowState = FormWindowState.Normal
        Form5.Focus()
        Form5.Timer1.Enabled = True
        abrirjanela.Text = "form5"
        'topmostf.Enabled = False
    End Sub

    Private Sub SalvarImagemDoNomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarImagemDoNomeToolStripMenuItem.Click
        Form6.Show()
        Form6.WindowState = FormWindowState.Normal
        'GetWindowCapture().Save("nomes\")
        abrirjanela.Text = "form6"
        'topmostf.Enabled = False
    End Sub
    'tirar print screen'
    Public Function GetWindowCapture() As Image

        SendKeys.SendWait("%{PRTSC}")

        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        Return objClipboard.GetData(DataFormats.Bitmap)
    End Function
    'tirar print' % é só pra tela ativa, ^ é pra tela toda.

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form5.Close()
        Form6.Close()
        Form7.Close()
        formu1 = False
    End Sub

    Private Sub fototimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fototimer.Tick
        On Error GoTo label
        If foto.Tag = "OK" Then
            If nome.Tag = "OK" Then
                Dim salvar As String
                salvar = foto.Text & nome.Text & ".bmp"
                If Salvarnome.Checked = True Then
                    Form26.Show()
                    Form26.WindowState = FormWindowState.Normal
                    Form26.Focus()
                    'topmostf.Enabled = False
                    abrirjanela.Text = "form26"

                    fototimer.Enabled = False
                    salvo.Enabled = True

                Else
                    Me.Focus()
                    Me.WindowState = FormWindowState.Normal
                    GetWindowCapture().Save(foto.Text & nome.Text & ".bmp")
                    fototimer.Enabled = False
                    salvo.Enabled = True
                End If
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
        If Salvarnome.Checked = False Then
            salvo.Enabled = False
            MsgBox("Foto salva com sucesso.", MsgBoxStyle.OkOnly, "JapaneseWay")
        Else
            Form26.Show()
            Form26.Focus()
            Form26.WindowState = FormWindowState.Normal
            GetWindowCapture().Save(foto.Text & nome.Text & ".bmp")
            salvo.Enabled = False
            MsgBox("Foto salva com sucesso.", MsgBoxStyle.OkOnly, "JapaneseWay")
            Form26.Close()
        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form7.Show()
        Form7.WindowState = FormWindowState.Normal
        Form7.Focus()
        abrirjanela.Text = "form7"
        'topmostf.Enabled = False
    End Sub

    Private Sub ComoFuncionamAssílabasJaponesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComoFuncionamAssílabasJaponesasToolStripMenuItem.Click
        Form8.Show()
        Form8.WindowState = FormWindowState.Normal
        Form8.Focus()
        abrirjanela.Text = "form8"
        'topmostf.Enabled = False
    End Sub

    Private Sub OQueÉnomeRomanizadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OQueÉnomeRomanizadoToolStripMenuItem.Click
        Form9.Show()
        Form9.WindowState = FormWindowState.Normal
        Form9.Focus()
        abrirjanela.Text = "form9"
        'topmostf.Enabled = False
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
























































    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form11.Show()
    End Sub

    Private Sub topmost_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub topmost_Tick_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu1 = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button2_Click(AcceptButton, AcceptButton)
        End If
    End Sub




    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub mudardetexto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Len(TextBox1.Text) <> 3 Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Button2_Click(AcceptButton, AcceptButton)
        End If
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Button2_Click(AcceptButton, AcceptButton)
        End If
    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Button2_Click(AcceptButton, AcceptButton)
        End If
    End Sub





    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub mostrartudo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrartudo.Tick
        If PictureBox8.ImageLocation = "" Then
            Size = New Size(945, 404)
            MaximumSize = New Size(945, 404)
        Else
            Size = New Size(945, 572)
            MaximumSize = New Size(945, 572)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "juliana" Then
            TextBox1.Text = "lucas"
        ElseIf TextBox1.Text = "lucas" Then
            TextBox1.Text = "amanda"
        ElseIf TextBox1.Text = "amanda" Then
            TextBox1.Text = "juscelino"
        ElseIf TextBox1.Text = "juscelino" Then
            TextBox1.Text = "alex"
        ElseIf TextBox1.Text = "alex" Then
            TextBox1.Text = "erick"
        ElseIf TextBox1.Text = "erick" Then
            TextBox1.Text = "juliana"
        ElseIf TextBox1.Text = "" Then
            TextBox1.Text = "erick"
        Else
            TextBox1.Text = ""
        End If
    End Sub
End Class

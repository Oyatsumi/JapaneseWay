Public Class Form5

    Private Sub Form5_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        formu5 = False
        'Form1.topmostf.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form1.japones.Text <> "" Then
            Label2.Text = Form1.japones.Text
            Timer1.Enabled = False
        Else
            Timer1.Enabled = False
            MsgBox("Preencha seu nome nos campos e em seguida passe ele para japonês, de modo que as imagens das letras japonesas apareçam na tela, logo após você ver como é a pronuncia do seu nome.", MsgBoxStyle.Critical, "JapaneseWay")
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form1.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu5 = True
    End Sub
End Class
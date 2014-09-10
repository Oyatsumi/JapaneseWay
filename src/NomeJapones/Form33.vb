Public Class Form33

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim arquivo As String
        'FileOpen(1, "C:\doc.rtf", OpenMode.Input)
        'Do While Not EOF(1)
        '  Input(1, arquivo)
        'RichTextBox1.Text = RichTextBox1.Text & RichTextBox1.Paste(arquivo)
        'Loop
        'FileClose(1)

    End Sub

    Private Sub Form33_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu33 = False
    End Sub

    Private Sub Form33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(Mid(Application.ExecutablePath, 1, Len(Application.ExecutablePath) - (Len(Form10.Text) + 5)) & "\Imagem\aulas\paginas\verbo.htm")
        formu33 = True

    End Sub
End Class
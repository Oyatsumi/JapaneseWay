Public Class Form21

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Private Sub Command1_Click()
        'Dim fs As New FileSystemObject, f As File
        'f = fs.GetFile(App.Path & "\test.exe")
        'f.Copy("C:\test.exe")
        'fs = Nothing
        'End Sub
        On Error GoTo erro
        FolderBrowserDialog1.ShowDialog()
        If System.IO.File.Exists(FolderBrowserDialog1.SelectedPath & "\Fonts\kochi-gothic-subst.ttf") = False Then
            FileCopy("fonts\kochi-gothic-subst.ttf", FolderBrowserDialog1.SelectedPath & "\Fonts\kochi-gothic-subst.ttf")
        End If
        If System.IO.File.Exists(FolderBrowserDialog1.SelectedPath & "\Fonts\kochi-mincho-subst.ttf") = False Then
            FileCopy("fonts\kochi-mincho-subst.ttf", FolderBrowserDialog1.SelectedPath & "\Fonts\kochi-mincho-subst.ttf")
        End If
        MsgBox("Instalação das fontes realizada com sucesso!" & Chr(13) & "Lembrando que essa instalação só faz sentido no Windows XP e anteriores, o Windows Vista e 7 já possuem as fontes japonesas instaladas." & Chr(13) & "É aconselhável que você reinicie o computador para as fontes funcionarem.", MsgBoxStyle.OkOnly, "JapaneseWay")
        Exit Sub
erro:
        MsgBox("Ocorreu um erro durante a instalação das suas fontes, verifique se você selecionou corretamente o diretório do Windows.", MsgBoxStyle.Critical, "JapaneseWay")
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If System.IO.File.Exists("fonts\kochi-gothic-subst.ttf") = True Then
            Button1.Visible = True
            Label3.Visible = True
            Size = New Size(399, 352)
            MaximumSize = New Size(399, 352)
        Else
            Size = New Size(399, 272)
            MaximumSize = New Size(399, 272)
        End If
    End Sub

    Private Sub Form21_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu21 = False
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu21 = True
    End Sub
End Class
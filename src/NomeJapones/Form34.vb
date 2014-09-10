Public Class Form34

    Private Sub Form34_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu34 = False
    End Sub

    Private Sub Form34_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu34 = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form33.Show()
        Form33.Focus()
        Form33.WindowState = FormWindowState.Normal
    End Sub
End Class
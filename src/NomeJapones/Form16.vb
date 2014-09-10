Public Class Form16

    Private Sub Form16_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu16 = False
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu16 = True
    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub
End Class
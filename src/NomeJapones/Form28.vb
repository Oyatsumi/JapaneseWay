Public Class Form28

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Form28_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu28 = False
    End Sub

    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu28 = True
    End Sub
End Class
Public Class Form8

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form1.Visible Or Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Form8_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        formu8 = False
        'Form1.topmostf.Enabled = True
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu8 = True
    End Sub
End Class
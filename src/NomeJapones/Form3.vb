Public Class Form3

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form1.Visible Or Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Form3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        ' Form1.topmostf.Enabled = True
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        formu3 = False
        'Form1.topmostf.Enabled = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu3 = True
    End Sub
End Class
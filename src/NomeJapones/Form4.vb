Public Class Form4

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form1.Visible Or Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub Form4_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        formu4 = False
        'Form1.topmostf.Enabled = True
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu4 = True
    End Sub
End Class
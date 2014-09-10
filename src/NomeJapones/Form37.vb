Public Class Form37

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Label2.Text = "....." Then
            Label2.Text = "."
        ElseIf Label2.Text = "." Then
            Label2.Text = ".."
        ElseIf Label2.Text = ".." Then
            Label2.Text = "..."
        ElseIf Label2.Text = "..." Then
            Label2.Text = "...."
        ElseIf Label2.Text = "...." Then
            Label2.Text = "....."
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Form10.Show()
        Hide()
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick



    End Sub

    Private Sub Form37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class Form14

    Private Sub topmost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Form10.Visible = True Then
            BringToFront()
        End If
    End Sub

    Private Sub TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem.Click
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
    End Sub

    Private Sub ApenasOQueForVisualizadoNaJanelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApenasOQueForVisualizadoNaJanelaToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub

    Private Sub VisualizarAImpressãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizarAImpressãoToolStripMenuItem.Click
        PrintForm2.Print()
    End Sub

    Private Sub Form14_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        formu14 = False
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formu14 = True
    End Sub
End Class
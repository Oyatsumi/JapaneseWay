<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArquivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApenasOQueForVisualizadoNaJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisualizarAImpressãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tabela Simples (Primeiro Hiragana e depois Katakana):"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(488, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem1
        '
        Me.ArquivoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem1, Me.VisualizarAImpressãoToolStripMenuItem})
        Me.ArquivoToolStripMenuItem1.Name = "ArquivoToolStripMenuItem1"
        Me.ArquivoToolStripMenuItem1.Size = New System.Drawing.Size(73, 20)
        Me.ArquivoToolStripMenuItem1.Text = "Impressão"
        '
        'ImprimirToolStripMenuItem1
        '
        Me.ImprimirToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem, Me.ApenasOQueForVisualizadoNaJanelaToolStripMenuItem})
        Me.ImprimirToolStripMenuItem1.Name = "ImprimirToolStripMenuItem1"
        Me.ImprimirToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ImprimirToolStripMenuItem1.Text = "Imprimir"
        '
        'TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem
        '
        Me.TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem.Name = "TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem"
        Me.TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem.Size = New System.Drawing.Size(417, 22)
        Me.TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem.Text = "Todo o conteúdo mesmo que não seja todo vizualizado na janela"
        '
        'ApenasOQueForVisualizadoNaJanelaToolStripMenuItem
        '
        Me.ApenasOQueForVisualizadoNaJanelaToolStripMenuItem.Name = "ApenasOQueForVisualizadoNaJanelaToolStripMenuItem"
        Me.ApenasOQueForVisualizadoNaJanelaToolStripMenuItem.Size = New System.Drawing.Size(417, 22)
        Me.ApenasOQueForVisualizadoNaJanelaToolStripMenuItem.Text = "Apenas o que for visualizado na janela."
        '
        'VisualizarAImpressãoToolStripMenuItem
        '
        Me.VisualizarAImpressãoToolStripMenuItem.Name = "VisualizarAImpressãoToolStripMenuItem"
        Me.VisualizarAImpressãoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VisualizarAImpressãoToolStripMenuItem.Text = "Visualizar a impressão"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tabela Complementar (Primeiro Hiragana e depois Katakana):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 494)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tabela Composta (Primeiro Hiragana e depois Katakana):"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 781)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.ImageLocation = "imagem\tabelacomposta.jpg"
        Me.PictureBox3.Location = New System.Drawing.Point(33, 510)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(435, 268)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ImageLocation = "imagem\tabelacomplementar.jpg"
        Me.PictureBox2.Location = New System.Drawing.Point(33, 350)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(429, 127)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "imagem\tabela1.jpg"
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 267)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 523)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form14"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabela Hiragana e Katakana"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ArquivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizarAImpressãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents TodoOConteúdoMesmoQueNãoSejaTodoVizualizadoNaJanelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApenasOQueForVisualizadoNaJanelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

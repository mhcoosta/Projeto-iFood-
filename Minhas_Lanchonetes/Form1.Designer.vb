<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTdelete = New System.Windows.Forms.Button()
        Me.TBespecialidade = New System.Windows.Forms.TextBox()
        Me.MTcontato = New System.Windows.Forms.MaskedTextBox()
        Me.TBestabelecimento = New System.Windows.Forms.TextBox()
        Me.TBposicao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTdeleteALL = New System.Windows.Forms.Button()
        Me.BTsave = New System.Windows.Forms.Button()
        Me.BTproximo = New System.Windows.Forms.Button()
        Me.BTanterior = New System.Windows.Forms.Button()
        Me.BTedit = New System.Windows.Forms.Button()
        Me.BTnew = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTlocalizaProc = New System.Windows.Forms.Button()
        Me.TBlocalizaProc = New System.Windows.Forms.TextBox()
        Me.MTcontatoProc = New System.Windows.Forms.MaskedTextBox()
        Me.TBestabelecimentoProc = New System.Windows.Forms.TextBox()
        Me.TBposicaoProc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTproximoProc = New System.Windows.Forms.Button()
        Me.BTanteriorProc = New System.Windows.Forms.Button()
        Me.RBespecialidade = New System.Windows.Forms.RadioButton()
        Me.RBnome = New System.Windows.Forms.RadioButton()
        Me.TBdexProc = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(428, 387)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTdelete)
        Me.TabPage1.Controls.Add(Me.TBespecialidade)
        Me.TabPage1.Controls.Add(Me.MTcontato)
        Me.TabPage1.Controls.Add(Me.TBestabelecimento)
        Me.TabPage1.Controls.Add(Me.TBposicao)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.BTdeleteALL)
        Me.TabPage1.Controls.Add(Me.BTsave)
        Me.TabPage1.Controls.Add(Me.BTproximo)
        Me.TabPage1.Controls.Add(Me.BTanterior)
        Me.TabPage1.Controls.Add(Me.BTedit)
        Me.TabPage1.Controls.Add(Me.BTnew)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(420, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modo Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BTdelete
        '
        Me.BTdelete.Enabled = False
        Me.BTdelete.ForeColor = System.Drawing.Color.DarkRed
        Me.BTdelete.Location = New System.Drawing.Point(16, 110)
        Me.BTdelete.Name = "BTdelete"
        Me.BTdelete.Size = New System.Drawing.Size(60, 21)
        Me.BTdelete.TabIndex = 23
        Me.BTdelete.Text = "Delete"
        Me.BTdelete.UseVisualStyleBackColor = True
        '
        'TBespecialidade
        '
        Me.TBespecialidade.Enabled = False
        Me.TBespecialidade.Location = New System.Drawing.Point(95, 260)
        Me.TBespecialidade.Name = "TBespecialidade"
        Me.TBespecialidade.Size = New System.Drawing.Size(172, 20)
        Me.TBespecialidade.TabIndex = 22
        '
        'MTcontato
        '
        Me.MTcontato.Enabled = False
        Me.MTcontato.Location = New System.Drawing.Point(68, 229)
        Me.MTcontato.Mask = "(99) 0000-0000"
        Me.MTcontato.Name = "MTcontato"
        Me.MTcontato.Size = New System.Drawing.Size(85, 20)
        Me.MTcontato.TabIndex = 21
        '
        'TBestabelecimento
        '
        Me.TBestabelecimento.Enabled = False
        Me.TBestabelecimento.Location = New System.Drawing.Point(134, 198)
        Me.TBestabelecimento.Name = "TBestabelecimento"
        Me.TBestabelecimento.Size = New System.Drawing.Size(172, 20)
        Me.TBestabelecimento.TabIndex = 20
        '
        'TBposicao
        '
        Me.TBposicao.Location = New System.Drawing.Point(181, 319)
        Me.TBposicao.Name = "TBposicao"
        Me.TBposicao.Size = New System.Drawing.Size(22, 20)
        Me.TBposicao.TabIndex = 19
        Me.TBposicao.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "/     5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Especialidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Contato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nome Estabelicimento:"
        '
        'BTdeleteALL
        '
        Me.BTdeleteALL.BackColor = System.Drawing.Color.Gold
        Me.BTdeleteALL.Enabled = False
        Me.BTdeleteALL.ForeColor = System.Drawing.Color.DarkRed
        Me.BTdeleteALL.Location = New System.Drawing.Point(344, 16)
        Me.BTdeleteALL.Name = "BTdeleteALL"
        Me.BTdeleteALL.Size = New System.Drawing.Size(60, 21)
        Me.BTdeleteALL.TabIndex = 13
        Me.BTdeleteALL.Text = "Delete All"
        Me.BTdeleteALL.UseVisualStyleBackColor = False
        '
        'BTsave
        '
        Me.BTsave.Enabled = False
        Me.BTsave.Location = New System.Drawing.Point(16, 83)
        Me.BTsave.Name = "BTsave"
        Me.BTsave.Size = New System.Drawing.Size(60, 21)
        Me.BTsave.TabIndex = 12
        Me.BTsave.Text = "Save"
        Me.BTsave.UseVisualStyleBackColor = True
        '
        'BTproximo
        '
        Me.BTproximo.Location = New System.Drawing.Point(265, 322)
        Me.BTproximo.Name = "BTproximo"
        Me.BTproximo.Size = New System.Drawing.Size(69, 23)
        Me.BTproximo.TabIndex = 11
        Me.BTproximo.Text = "Próximo"
        Me.BTproximo.UseVisualStyleBackColor = True
        '
        'BTanterior
        '
        Me.BTanterior.Location = New System.Drawing.Point(98, 322)
        Me.BTanterior.Name = "BTanterior"
        Me.BTanterior.Size = New System.Drawing.Size(62, 23)
        Me.BTanterior.TabIndex = 10
        Me.BTanterior.Text = "Anterior"
        Me.BTanterior.UseVisualStyleBackColor = True
        '
        'BTedit
        '
        Me.BTedit.Enabled = False
        Me.BTedit.Location = New System.Drawing.Point(16, 56)
        Me.BTedit.Name = "BTedit"
        Me.BTedit.Size = New System.Drawing.Size(60, 21)
        Me.BTedit.TabIndex = 7
        Me.BTedit.Text = "Edit"
        Me.BTedit.UseVisualStyleBackColor = True
        '
        'BTnew
        '
        Me.BTnew.Location = New System.Drawing.Point(16, 29)
        Me.BTnew.Name = "BTnew"
        Me.BTnew.Size = New System.Drawing.Size(60, 21)
        Me.BTnew.TabIndex = 6
        Me.BTnew.Text = "New"
        Me.BTnew.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TBdexProc)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.BTlocalizaProc)
        Me.TabPage2.Controls.Add(Me.TBlocalizaProc)
        Me.TabPage2.Controls.Add(Me.MTcontatoProc)
        Me.TabPage2.Controls.Add(Me.TBestabelecimentoProc)
        Me.TabPage2.Controls.Add(Me.TBposicaoProc)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.BTproximoProc)
        Me.TabPage2.Controls.Add(Me.BTanteriorProc)
        Me.TabPage2.Controls.Add(Me.RBespecialidade)
        Me.TabPage2.Controls.Add(Me.RBnome)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(420, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modo Pesquisa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "/ "
        '
        'BTlocalizaProc
        '
        Me.BTlocalizaProc.Location = New System.Drawing.Point(328, 34)
        Me.BTlocalizaProc.Name = "BTlocalizaProc"
        Me.BTlocalizaProc.Size = New System.Drawing.Size(69, 23)
        Me.BTlocalizaProc.TabIndex = 34
        Me.BTlocalizaProc.Text = "Localizar"
        Me.BTlocalizaProc.UseVisualStyleBackColor = True
        '
        'TBlocalizaProc
        '
        Me.TBlocalizaProc.Location = New System.Drawing.Point(150, 34)
        Me.TBlocalizaProc.Name = "TBlocalizaProc"
        Me.TBlocalizaProc.Size = New System.Drawing.Size(172, 20)
        Me.TBlocalizaProc.TabIndex = 33
        '
        'MTcontatoProc
        '
        Me.MTcontatoProc.Enabled = False
        Me.MTcontatoProc.Location = New System.Drawing.Point(71, 267)
        Me.MTcontatoProc.Mask = "(99) 0000-0000"
        Me.MTcontatoProc.Name = "MTcontatoProc"
        Me.MTcontatoProc.Size = New System.Drawing.Size(85, 20)
        Me.MTcontatoProc.TabIndex = 31
        '
        'TBestabelecimentoProc
        '
        Me.TBestabelecimentoProc.Enabled = False
        Me.TBestabelecimentoProc.Location = New System.Drawing.Point(137, 236)
        Me.TBestabelecimentoProc.Name = "TBestabelecimentoProc"
        Me.TBestabelecimentoProc.Size = New System.Drawing.Size(172, 20)
        Me.TBestabelecimentoProc.TabIndex = 30
        '
        'TBposicaoProc
        '
        Me.TBposicaoProc.Location = New System.Drawing.Point(165, 300)
        Me.TBposicaoProc.Name = "TBposicaoProc"
        Me.TBposicaoProc.Size = New System.Drawing.Size(22, 20)
        Me.TBposicaoProc.TabIndex = 29
        Me.TBposicaoProc.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Contato:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Nome Estabelicimento:"
        '
        'BTproximoProc
        '
        Me.BTproximoProc.Location = New System.Drawing.Point(265, 322)
        Me.BTproximoProc.Name = "BTproximoProc"
        Me.BTproximoProc.Size = New System.Drawing.Size(69, 23)
        Me.BTproximoProc.TabIndex = 24
        Me.BTproximoProc.Text = "Próximo"
        Me.BTproximoProc.UseVisualStyleBackColor = True
        '
        'BTanteriorProc
        '
        Me.BTanteriorProc.Location = New System.Drawing.Point(98, 322)
        Me.BTanteriorProc.Name = "BTanteriorProc"
        Me.BTanteriorProc.Size = New System.Drawing.Size(62, 23)
        Me.BTanteriorProc.TabIndex = 23
        Me.BTanteriorProc.Text = "Anterior"
        Me.BTanteriorProc.UseVisualStyleBackColor = True
        '
        'RBespecialidade
        '
        Me.RBespecialidade.AutoSize = True
        Me.RBespecialidade.Location = New System.Drawing.Point(16, 54)
        Me.RBespecialidade.Name = "RBespecialidade"
        Me.RBespecialidade.Size = New System.Drawing.Size(113, 17)
        Me.RBespecialidade.TabIndex = 1
        Me.RBespecialidade.Text = "Por Especialidade:"
        Me.RBespecialidade.UseVisualStyleBackColor = True
        '
        'RBnome
        '
        Me.RBnome.AutoSize = True
        Me.RBnome.Location = New System.Drawing.Point(16, 22)
        Me.RBnome.Name = "RBnome"
        Me.RBnome.Size = New System.Drawing.Size(75, 17)
        Me.RBnome.TabIndex = 0
        Me.RBnome.Text = "Por Nome:"
        Me.RBnome.UseVisualStyleBackColor = True
        '
        'TBdexProc
        '
        Me.TBdexProc.Location = New System.Drawing.Point(214, 300)
        Me.TBdexProc.Name = "TBdexProc"
        Me.TBdexProc.Size = New System.Drawing.Size(22, 20)
        Me.TBdexProc.TabIndex = 36
        Me.TBdexProc.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 419)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "AiFood"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TBespecialidade As TextBox
    Friend WithEvents MTcontato As MaskedTextBox
    Friend WithEvents TBestabelecimento As TextBox
    Friend WithEvents TBposicao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTdeleteALL As Button
    Friend WithEvents BTsave As Button
    Friend WithEvents BTproximo As Button
    Friend WithEvents BTanterior As Button
    Friend WithEvents BTedit As Button
    Friend WithEvents BTnew As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BTdelete As Button
    Friend WithEvents BTlocalizaProc As Button
    Friend WithEvents TBlocalizaProc As TextBox
    Friend WithEvents MTcontatoProc As MaskedTextBox
    Friend WithEvents TBestabelecimentoProc As TextBox
    Friend WithEvents TBposicaoProc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTproximoProc As Button
    Friend WithEvents BTanteriorProc As Button
    Friend WithEvents RBespecialidade As RadioButton
    Friend WithEvents RBnome As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TBdexProc As TextBox
End Class

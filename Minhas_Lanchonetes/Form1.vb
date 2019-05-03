Public Class Form1
    Dim posicao As Integer = 1
    Dim posicao_ As Integer = 1
    Dim numeroestabelecimentos As Integer = 5

    Dim estabelecimento(numeroestabelecimentos) As String
    Dim estabelecimento_(numeroestabelecimentos) As String

    Dim contato(numeroestabelecimentos) As String
    Dim contato_(numeroestabelecimentos) As String

    Dim especialidade(numeroestabelecimentos) As String
    Dim especialidade_(numeroestabelecimentos) As String

    Dim controle_salvamento As Integer
    Dim deX As Integer
    Dim controle As Integer
    Dim palavra As String
    Dim achou As Boolean

    Private Sub atualizatela()
        TBposicao.Text = posicao
        MTcontato.Text = contato(posicao)
        TBespecialidade.Text = especialidade(posicao)
        TBestabelecimento.Text = estabelecimento(posicao)
    End Sub

    Private Sub atualizatela_()
        TBposicaoProc.Text = posicao_
        MTcontatoProc.Text = contato(posicao_)
        TBestabelecimentoProc.Text = estabelecimento(posicao_)
        TBdexProc.Text = deX
    End Sub


    Private Sub trava()
        BTsave.Enabled = False
        BTedit.Enabled = True
        BTdelete.Enabled = True
        BTdeleteALL.Enabled = True
        TBestabelecimento.Enabled = False
        MTcontato.Enabled = False
        TBespecialidade.Enabled = False
        BTanterior.Enabled = True
        BTproximo.Enabled = True
        BTnew.Enabled = True
    End Sub


    Private Sub destrava()
        BTsave.Enabled = True
        BTedit.Enabled = False
        BTdelete.Enabled = False
        BTdeleteALL.Enabled = False
        TBestabelecimento.Enabled = True
        MTcontato.Enabled = True
        TBespecialidade.Enabled = True
        BTanterior.Enabled = False
        BTproximo.Enabled = False
        BTnew.Enabled = False
    End Sub

    Private Sub destravaProc()
        BTlocalizaProc.Enabled = True
        BTanteriorProc.Enabled = True
        BTproximoProc.Enabled = True
    End Sub

    Private Sub BTnew_Click(sender As Object, e As EventArgs) Handles BTnew.Click
        For cont As Integer = 1 To numeroestabelecimentos
            If achou = False Then
                If estabelecimento(cont) = "" Then
                    achou = True
                    posicao = cont
                End If
            End If
        Next
        If achou = False Then
            MsgBox("Não há espaço em memória.", MsgBoxStyle.Critical)
        Else
            atualizatela()
            destrava()
        End If
        achou = False
    End Sub

    Private Sub BTedit_Click(sender As Object, e As EventArgs) Handles BTedit.Click
        destrava()
    End Sub

    Private Sub BTsave_Click(sender As Object, e As EventArgs) Handles BTsave.Click
        controle_salvamento = 0
        For cont As Integer = 1 To numeroestabelecimentos
            If TBestabelecimento.Text = estabelecimento(cont) Or TBestabelecimento.Text = "" Or MTcontato.Text = contato(cont) Or MTcontato.Text = "" Or TBespecialidade.Text = "" Or Len(MTcontato.Text) < 13 Then
                controle_salvamento = 1
            End If
        Next
        If controle_salvamento = 1 Then
            MsgBox("Estabelecimento já cadastrado, ou com algum espaço NÃO PREENCHIDO!", MsgBoxStyle.Critical)
        Else
            estabelecimento(posicao) = TBestabelecimento.Text
            contato(posicao) = MTcontato.Text
            especialidade(posicao) = TBespecialidade.Text
            trava()
        End If


    End Sub

    Private Sub BTanterior_Click(sender As Object, e As EventArgs) Handles BTanterior.Click
        If posicao = 1 Then
            posicao = numeroestabelecimentos
        Else
            posicao = posicao - 1
        End If

        atualizatela()

    End Sub

    Private Sub BTproximo_Click(sender As Object, e As EventArgs) Handles BTproximo.Click
        If posicao = 5 Then
            posicao = 1
        Else
            posicao = posicao + 1
        End If

        atualizatela()
    End Sub

    Private Sub BTdelete_Click(sender As Object, e As EventArgs) Handles BTdelete.Click
        If MsgBox("Apagar esse estabelecimento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TBestabelecimento.Text = ""
            MTcontato.Text = ""
            TBespecialidade.Text = ""
            estabelecimento(posicao) = ""
            contato(posicao) = ""
            especialidade(posicao) = ""
        End If
    End Sub

    Private Sub BTdeleteALL_Click(sender As Object, e As EventArgs) Handles BTdeleteALL.Click
        If MsgBox("Tem certeza que deseja apagar TODOS os seus estabelecimentos?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("Depois que apagar, não terá mais volta. Tem certeza?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For cont As Integer = 1 To numeroestabelecimentos
                    TBestabelecimento.Text = ""
                    MTcontato.Text = ""
                    TBespecialidade.Text = ""
                    estabelecimento(cont) = ""
                    contato(cont) = ""
                    especialidade(cont) = ""
                Next
            End If
        End If
    End Sub

    Private Sub BTlocalizaProc_Click(sender As Object, e As EventArgs) Handles BTlocalizaProc.Click
        controle = 0
        deX = 0
        destravaProc()

        If RBespecialidade.Checked = False And RBnome.Checked = False Then


        Else
            'Para buscar Por Nome - RBnome
            If RBnome.Checked Then
                For cont As Integer = 1 To 5
                    If TBlocalizaProc.Text = estabelecimento(cont) Then
                        achou = True
                        TBestabelecimentoProc.Text = estabelecimento(cont)
                        MTcontatoProc.Text = contato(cont)
                        BTanteriorProc.Enabled = False
                        BTproximoProc.Enabled = False
                    End If
                Next
                If achou = False Then
                    TBestabelecimentoProc.Text = "Estabelecimento não cadastrado!"
                    MTcontatoProc.Text = "00000000000"
                End If
                achou = False
                TBlocalizaProc.Text = ""
            End If

            'Para buscar Por Especialidade - RBespecialidade
            If RBespecialidade.Checked Then
                For cont As Integer = 1 To numeroestabelecimentos
                    palavra = TBlocalizaProc.Text
                    If palavra = especialidade(cont) Then
                        achou = True
                        deX = deX + 1
                        controle = controle + 1
                        estabelecimento_(controle) = estabelecimento(cont)
                        contato_(controle) = contato(cont)
                        atualizatela_()
                    End If
                Next
                If achou = False Then
                    TBestabelecimentoProc.Text = "Estabelecimento não cadastrado!"
                    MTcontatoProc.Text = "00000000000"
                End If
            End If
        End If


    End Sub

    Private Sub BTanteriorProc_Click(sender As Object, e As EventArgs) Handles BTanteriorProc.Click
        If posicao_ = controle Then
            posicao_ = 1
        Else
            posicao = posicao_ + 1
        End If
        atualizatela_()
    End Sub

    Private Sub BTproximoProc_Click(sender As Object, e As EventArgs) Handles BTproximoProc.Click
        If posicao_ = controle Then
            posicao_ = 1
        Else
            posicao_ = posicao_ + 1
        End If
        atualizatela_()
    End Sub
End Class



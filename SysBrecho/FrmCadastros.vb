Public Class FrmCadastros
    ReadOnly validacoes As New Validacoes
    Public novoCadastro As Boolean = False

    Public ReadOnly Property Validacoes1 As Validacoes
        Get
            Return validacoes
        End Get
    End Property

    Private Sub FrmCadastros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta linha de código carrega dados na tabela 'BancoSysBrechoDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            Me.FornecedoresTableAdapter.Fill(Me.BancoSysBrechoDataSet.Fornecedores)
            Me.ClientesTableAdapter.Fill(Me.BancoSysBrechoDataSet.Clientes)
            EmpresasTableAdapter.Fill(Me.BancoSysBrechoDataSet.Empresas)
            'mtxtNomeRazao.Enabled = False
            'btnOK.Visible = False
            'btnEditar.Visible = False
            'BtnExcluir.Visible = False
            'WindowState = FormWindowState.Maximized
            ModuloCadastros.MainFroms("Cadastro de " & CadastroSelecionado)
        Catch ex As Exception
            MsgBox("Erro informe a menssagem abaixo." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Torna o menu de opções visivel novamente e fecha o form que esta aberto.
        Validacoes.Fecha_o_Formulario(Me)
    End Sub

    Private Sub CbxTpDocumentos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxTpDocumentos.SelectionChangeCommitted
        'Chama a função que altera o nome das labels conforme o tipo de documento selecionado na combobox
        Validacoes.CPFCNPJ(cbxTpDocumentos, mtxtNumDocumento, lblTipoDoc, lblNome)
    End Sub

    Public Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try
            ModuloCadastros.ConsultarCadastro(CadastroSelecionado)
        Catch ex As Exception
            MsgBox("Erro ao realizar a consulta. Informe a menssagem abaixo" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de controle")
        End Try
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            ModuloCadastros.SalvaInformacoes(CadastroSelecionado, novoCadastro)
        Catch ex As Exception
            MsgBox("Erro ao salvar contate o desenvolvedor e informe o codigo abaixo." & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub BtnEditar_Click() Handles btnEditar.Click
        Try
            ModuloCadastros.EditarInformacoes(CadastroSelecionado)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub cbxWhats_DrawItem(sender As Object, e As DrawItemEventArgs)
        Validacoes.SelecionaCbx(cbxWhats, e)
    End Sub

    Private Sub cbxTpDocumentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTpDocumentos.SelectedIndexChanged
        'Chama a função que altera o nome das labels conforme o tipo de documento selecionado na combobox
        Validacoes.CPFCNPJ(cbxTpDocumentos, mtxtNumDocumento, lblTipoDoc, lblNome)
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        BtnNovo.Visible = False
        Me.Close()
        Select Case CadastroSelecionado
            Case Is = "Fornecedores"
                mdiTelaPrinciapal.CadastrarFornecedorMenu_Click(sender, e)
            Case Is = "Clientes"
                mdiTelaPrinciapal.CadastrarClientes_Click(sender, e)
            Case Is = "Empresas"
                mdiTelaPrinciapal.CadastrarEmpresasMenu_Click(sender, e)
        End Select
    End Sub

    Private Sub MtxtNumDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtNumDocumento.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            BtnConsultar_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Public Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            ModuloCadastros.ExcluirCadastros(CadastroSelecionado)
            BtnNovo_Click(sender, e)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

End Class
Public Class FrmProdutos
    Dim novo As Boolean = False

    Private Sub ComboBox()
        'Busca as informações de cadastro de fornecedores e empresas para preencher os combobox respectivos
        Dim empresas = FrmCadastros.EmpresasTableAdapter.GetComboBox()
        If FrmCadastros.EmpresasTableAdapter.SelectComboBox(BancoSysBrechoDataSet.Empresas) > 0 Then
            For Each emp As DataRow In empresas
                Me.cbxEmpresa.Items.Add(String.Concat("cod: ", emp(0), " - Nome: ", emp(3)))
            Next
            cbxEmpresa.Enabled = True
            cbxEmpresa.Refresh()
            cbxEmpresa.Text = ""
        Else
            Me.cbxEmpresa.Text = "Nenhuma Empresa Cadastrada F6 para cadastrar, cadastre antes do produto!"
            Me.cbxEmpresa.Enabled = False
        End If
        Dim fornecedores = FrmCadastros.FornecedoresTableAdapter.GetData()
        If FrmCadastros.FornecedoresTableAdapter.Fill(BancoSysBrechoDataSet.Fornecedores) > 0 Then
            For Each forne As DataRow In fornecedores
                Me.cbxFornecedor.Items.Add(String.Concat("cod: ", forne(0), " - Nome: ", forne(3)))
            Next
            cbxFornecedor.Enabled = True
            cbxFornecedor.Refresh()
            cbxFornecedor.Text = ""
        Else
            Me.cbxFornecedor.Text = "Nenhum Fornecedor Cadastrado F5 para cadastrar, cadastre antes do produto!"
            Me.cbxFornecedor.Enabled = False
        End If
    End Sub

    Private Function CalculaMargem(text As TextBox)
        Select Case TxtValorCusto.Text
            Case Is <> "", Is > 0
                Select Case TxtValorVenda.Text
                    Case Is <> "", Is > 0
                        Try
                            TxtMargen.Text = FormatPercent(TxtValorVenda.Text / TxtValorCusto.Text - 1, 2)
                        Catch
                            text.Text = ""
                            'MsgBox("Selecione todo o valor e apague para não dar erro!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle!")
                        Catch ex As Exception
                            MsgBox("Selecione todo o valor e apague para não dar erro!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle!")
                        End Try
                End Select
        End Select
    End Function

    Private Function SalvaProdutos()
        Dim existe As Boolean = ProdutosTableAdapter.SelectExiste(txtCodProduto.Text)
        Dim entrada As Date = FormatDateTime(Now, DateFormat.ShortDate)
        Dim saida = Validacoes.ConvertDatas(txtDataSaida, "Saída")
        Dim emp As Boolean, fornec As Boolean, categ As Boolean, datas As Boolean

        'If FormatDateTime(saida, 1) = FormatDateTime("01/01/2200", 1) Or FormatDateTime(entrada, 1) = FormatDateTime("01/01/2200", 1) Then
        '    datas = True
        'End If
        Try
            If cbxCategoria.Text = "Selecione uma Categoria" Then
                categ = True
                lblCategoria.Visible = True
            End If

            If String.IsNullOrEmpty(cbxEmpresa.Text) Then
                emp = True
                lblEmpresas.Visible = True
            End If

            If String.IsNullOrEmpty(cbxFornecedor.Text) Then
                fornec = True
                lblFornecedor.Visible = True
            End If

            If emp Or fornec Or categ Or datas Then
                Exit Function
            End If

            Dim codEmp As String() = Split(cbxEmpresa.Text)
            Dim codForn As String() = Split(cbxFornecedor.Text)

            If existe Then
                Try
                    Dim margem As Decimal = TxtMargen.Text.Trim("%")

                    Dim valorVenda = CDbl(Replace(TxtValorVenda.Text, "R$", ""))
                    Dim valorcusto = CDbl(Replace(TxtValorCusto.Text, "R$", ""))

                    ProdutosTableAdapter.UpdateQuery(cbxCategoria.Text, txtNomeProduto.Text, txtModelo.Text,
                                            txtMarca.Text, txtCor.Text, cbxTamanho.Text, entrada, saida,
                                            txtQuantidade.Text, valorcusto, valorVenda, CDbl(TxtMargen.Text.Trim("%")), txtDesconto.Text,
                                            txtLucro.Text, codForn(1), codEmp(1), txtObservacoesProduto.Text, txtCodProduto.Text)

                    Me.lblMsgSalva.Visible = True
                    Me.Panel1.Enabled = False
                    Me.btnSalvarProd.Enabled = False
                    Me.btnNovoProd.Enabled = True
                    BtnExcluir.Enabled = False
                Catch ex As Exception
                    MsgBox("Ero ao salvar" & vbCrLf & ex.Message)
                End Try

            Else
                Try
                    ' Dim margem As Decimal = FormatNumber(Replace(TxtMargen.Text, "%", "") / 100, 2)
                    Dim margem = CDbl(TxtMargen.Text.Trim("%"))
                    Dim valorVenda = CDbl(Replace(TxtValorVenda.Text, "R$", ""))
                    Dim valorcusto = CDbl(Replace(TxtValorCusto.Text, "R$", ""))

                    ProdutosTableAdapter.InsertQuery(txtCodProduto.Text, cbxCategoria.Text, txtNomeProduto.Text, txtModelo.Text,
                                        txtMarca.Text, txtCor.Text, cbxTamanho.Text, entrada, saida,
                                        txtQuantidade.Text, valorcusto, valorVenda, CDbl(TxtMargen.Text.Trim("%")), txtDesconto.Text,
                                        txtLucro.Text, codForn(1), codEmp(1), txtObservacoesProduto.Text)

                    Me.lblMsgSalva.Visible = True
                    Me.Panel1.Enabled = False
                    Me.btnSalvarProd.Enabled = False
                    Me.btnNovoProd.Enabled = True
                    BtnExcluir.Enabled = False
                Catch ex As Exception
                    MsgBox("Erro ao salvar" & vbCrLf & ex.Message)
                End Try

            End If
        Catch ex As Exception
            MsgBox("ERRO! Favor contatar o desenvolverdor." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try

    End Function

    Private Function ConsultaProdutos()
        'Função que retornar as informações contidas no banco de dados produtos
        Try
            Dim existe = Me.ProdutosTableAdapter.SelectExiste(txtCodProduto.Text)

            If String.IsNullOrEmpty(txtCodProduto.Text) Then
                lblCodigo.Visible = True
                Me.txtCodProduto.Select()
                Exit Function
            End If
            txtCodProduto.Enabled = False

            If existe = 1 Then
                Me.Panel1.Visible = True
                Me.PanelBotoes.Visible = True
                Me.btnSalvarProd.Enabled = False

                Dim Consultaprod As EnumerableRowCollection = From produto In BancoSysBrechoDataSet.Produtos
                                                              Where (produto.Codigo_Interno = Me.txtCodProduto.Text)
                                                              Select produto.Categoria, produto.Nome, produto.Marca, produto.Modelo, produto.Cor,
                               produto.Tamanho, produto.Data_Entrada, produto.Data_Saida, produto.Quantiade, produto.Valor_Custo,
                               produto.Valor_Venda, produto.Margem, produto.Desconto, produto.Lucro, produto.Fornecedor, produto.Empresa,
                               produto.Observacoes

                For Each dados In Consultaprod
                    Dim Fornecedor As String = FornecedoresTableAdapter.SelectNomeFornecedor(dados.fornecedor)
                    Dim Empresa As String = EmpresasTableAdapter.SelectEmpresaNome(dados.empresa)
                    With dados
                        cbxCategoria.Text = .Categoria
                        txtNomeProduto.Text = .Nome
                        txtModelo.Text = .Modelo
                        txtMarca.Text = .Marca
                        txtCor.Text = .Cor
                        cbxTamanho.Text = .Tamanho
                        txtDataEntrada.Text = .Data_Entrada
                        txtDataSaida.Text = .Data_Saida
                        txtQuantidade.Text = .Quantiade
                        TxtValorCusto.Text = FormatNumber(.Valor_Custo, 2)
                        TxtValorVenda.Text = FormatNumber(.Valor_Venda, 2)
                        TxtMargen.Text = FormatPercent(.Margem / 100, 2)
                        txtDesconto.Text = .Desconto
                        txtLucro.Text = .Lucro
                        cbxFornecedor.Text = String.Concat("Cod. ", .Fornecedor, " - Nome: ", Fornecedor)
                        cbxEmpresa.Text = String.Concat("Cod. ", .Empresa, " - Nome: ", Empresa)
                        txtObservacoesProduto.Text = .Observacoes
                    End With
                Next
                Me.Panel1.Enabled = False
                Me.btnEditarProd.Enabled = True
                BtnExcluir.Enabled = True

            Else
                'Me.PanelBotoes.Visible = True
                Me.Panel1.Visible = True
                Me.PanelBotoes.Visible = True
                Me.btnEditarProd.Enabled = False
                Me.btnNovoProd.Enabled = False
                Me.btnSalvarProd.Enabled = True
                BtnExcluir.Enabled = False
            End If
            Dim PosicaoX = PanelBotoes.Location.X
            Dim PosiçãoY = PanelBotoes.Location.Y

            Me.BtnConsultar.Location = New Point(PosicaoX - 176, PosiçãoY + 11)
            Me.BtnConsultar.Enabled = False
            Me.btnCancelarProd.Location = New Point(PosicaoX - 74, PosiçãoY + 11)
        Catch ex As Exception
            MsgBox("Erro critico contate o desenvolvedor!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try
    End Function

    Private Function TextBoxGotFocus(ByVal sender As Object, ByVal e As EventArgs)
        'TODO: esta função muda a cor do objeto selecionado
        Dim mTextBox As TextBox = CType(sender, TextBox)
        mTextBox.BackColor = Color.FromName("LemonChiffon")
    End Function

    Private Function MaskedBoxGotFocus(ByVal sender As Object, ByVal e As EventArgs)
        'TODO: esta função muda a cor do objeto selecionado
        Dim mTextBox As MaskedTextBox = CType(sender, MaskedTextBox)
        mTextBox.BackColor = Color.FromName("LemonChiffon")
    End Function

    Private Function CbxBoxGotFocus(ByVal sender As Object, ByVal e As EventArgs)
        'TODO: esta função muda a cor do objeto selecionado
        Dim mTextBox As ComboBox = CType(sender, ComboBox)
        mTextBox.BackColor = Color.FromName("LemonChiffon")
    End Function

    Private Function MaskedBoxLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        'TODO: esta função muda a cor do objeto ao sair da seleção
        Dim mTextBox As MaskedTextBox = CType(sender, MaskedTextBox)
        mTextBox.BackColor = Color.FromName("White")
    End Function

    Private Function TextBoxLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        'TODO: esta função muda a cor do objeto ao sair da seleção
        Dim mTextBox As TextBox = CType(sender, TextBox)
        mTextBox.BackColor = Color.FromName("White")
    End Function

    Private Function comboBoxLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        'TODO: esta função muda a cor do objeto ao sair da seleção
        Dim mTextBox As ComboBox = CType(sender, ComboBox)
        mTextBox.BackColor = Color.FromName("White")
    End Function

    Private Sub FrmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Try

            'TODO: esta linha de código carrega dados na tabela 'BancoSysBrechoDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            FornecedoresTableAdapter.Fill(BancoSysBrechoDataSet.Fornecedores)
            'TODO: esta linha de código carrega dados na tabela 'BancoSysBrechoDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            ProdutosTableAdapter.Fill(BancoSysBrechoDataSet.Produtos)
            'TODO: esta linha de código carrega dados na tabela 'BancoSysBrechoDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            EmpresasTableAdapter.Fill(BancoSysBrechoDataSet.Empresas)

            cbxCategoria.SelectedIndex = 0
            cbxTamanho.SelectedIndex = 0

            'ComboBox()
            Me.Panel1.Visible = False
            'Me.PanelBotoes.Visible = False
            Me.btnCancelarProd.Visible = True
            'Me.btnCancelarProd.Location = New Point(444, 37)
            'Me.BtnConsultar.Location = New Point(350, 37)

            AddHandler txtCodProduto.GotFocus, AddressOf MaskedBoxGotFocus
            AddHandler txtCor.GotFocus, AddressOf TextBoxGotFocus
            AddHandler cbxCategoria.GotFocus, AddressOf CbxBoxGotFocus
            AddHandler txtDataEntrada.GotFocus, AddressOf TextBoxGotFocus
            AddHandler txtNomeProduto.GotFocus, AddressOf TextBoxGotFocus
            AddHandler txtMarca.GotFocus, AddressOf TextBoxGotFocus
            AddHandler txtModelo.GotFocus, AddressOf TextBoxGotFocus
            AddHandler cbxTamanho.GotFocus, AddressOf CbxBoxGotFocus
            AddHandler txtQuantidade.GotFocus, AddressOf TextBoxGotFocus
            AddHandler TxtValorCusto.GotFocus, AddressOf TextBoxGotFocus
            AddHandler TxtValorVenda.GotFocus, AddressOf TextBoxGotFocus
            AddHandler TxtMargen.GotFocus, AddressOf TextBoxGotFocus
            AddHandler txtObservacoesProduto.GotFocus, AddressOf TextBoxGotFocus
            AddHandler cbxFornecedor.GotFocus, AddressOf CbxBoxGotFocus
            AddHandler cbxEmpresa.GotFocus, AddressOf CbxBoxGotFocus
            AddHandler txtCodProduto.LostFocus, AddressOf MaskedBoxLostFocus
            AddHandler txtCor.LostFocus, AddressOf TextBoxLostFocus
            AddHandler cbxCategoria.LostFocus, AddressOf comboBoxLostFocus
            AddHandler txtDataEntrada.LostFocus, AddressOf TextBoxLostFocus
            AddHandler txtNomeProduto.LostFocus, AddressOf TextBoxLostFocus
            AddHandler txtMarca.LostFocus, AddressOf TextBoxLostFocus
            AddHandler txtModelo.LostFocus, AddressOf TextBoxLostFocus
            AddHandler cbxTamanho.LostFocus, AddressOf comboBoxLostFocus
            AddHandler txtQuantidade.LostFocus, AddressOf TextBoxLostFocus
            AddHandler TxtValorCusto.LostFocus, AddressOf TextBoxLostFocus
            AddHandler TxtValorVenda.LostFocus, AddressOf TextBoxLostFocus
            AddHandler TxtMargen.LostFocus, AddressOf TextBoxLostFocus
            AddHandler txtObservacoesProduto.LostFocus, AddressOf TextBoxLostFocus
            AddHandler cbxFornecedor.LostFocus, AddressOf comboBoxLostFocus
            AddHandler cbxEmpresa.LostFocus, AddressOf comboBoxLostFocus

        Catch ex As Exception
            MsgBox("Erro critico contate o desenvolvedor!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try
    End Sub

    Public Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Me.ConsultaProdutos()
    End Sub

    Private Sub BtnSalvarProd_Click(sender As Object, e As EventArgs) Handles btnSalvarProd.Click
        Me.SalvaProdutos()
    End Sub

    Public Sub BtnEditarProd_Click(sender As Object, e As EventArgs) Handles btnEditarProd.Click
        Validate()
        ProdutosBindingSource.EndEdit()
        BancoSysBrechoDataSet.AcceptChanges()
        btnSalvarProd.Enabled = True
        Panel1.Enabled = True
        lblMsgSalva.Visible = False
    End Sub

    Private Sub TxtCodProduto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProduto.TextChanged
        lblCodigo.Visible = False
    End Sub

    Private Sub CbxFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFornecedor.SelectedIndexChanged
        lblFornecedor.Visible = False
    End Sub

    Private Sub CbxEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmpresa.SelectedIndexChanged
        lblEmpresas.Visible = False
    End Sub

    Private Sub CbxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategoria.SelectedIndexChanged
        lblCategoria.Visible = False
    End Sub

    Private Sub BtnNovoProd_Click(sender As Object, e As EventArgs) Handles btnNovoProd.Click
        Validacoes.Fecha_o_Formulario(Me)
        mdiTelaPrinciapal.MenuCadastrarProd_Click(sender, e)
    End Sub

    Private Sub BtnCancelarProd_Click(sender As Object, e As EventArgs) Handles btnCancelarProd.Click
        Validacoes.Fecha_o_Formulario(Me)
    End Sub

    Private Sub TxtCodProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProduto.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            ConsultaProdutos()
            Me.txtNomeProduto.Select()
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDataEntrada_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtDataEntrada.MaskInputRejected
        Me.lblDataError.Visible = False
    End Sub

    Private Sub TxtDataSaida_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtDataSaida.MaskInputRejected
        Me.lblDataError.Visible = False
    End Sub

    Private Sub TxtValorCusto_Leave(sender As Object, e As EventArgs) Handles TxtValorCusto.Leave
        TxtValorCusto.Text = FormatNumber(TxtValorCusto.Text, 2, TriState.True, TriState.True, TriState.True)
    End Sub

    Private Sub TxtValorVenda_Leave(sender As Object, e As EventArgs) Handles TxtValorVenda.Leave
        TxtValorVenda.Text = FormatNumber(TxtValorVenda.Text, 2, TriState.True, TriState.True, TriState.True) 'Format(TxtValorVenda.Text, "Currency")
    End Sub

    Private Sub TxtMargen_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtMargen.KeyUp
        Try
            TxtValorVenda.Text = FormatNumber(TxtValorCusto.Text + TxtValorCusto.Text * (Replace(TxtMargen.Text, "%", "") / 100), 2)
        Catch ex As Exception
            MsgBox("Erro ao calcular a margem, Contate o desenvolvedor e informe a mensagem abaixo." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub TxtValorCusto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtValorCusto.KeyUp
        CalculaMargem(TxtValorCusto)
    End Sub

    Private Sub TxtValorVenda_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtValorVenda.KeyUp
        CalculaMargem(TxtValorVenda)
    End Sub

    Private Sub TxtMargen_Leave(sender As Object, e As EventArgs) Handles TxtMargen.Leave
        Try
            TxtMargen.Text = Replace(TxtMargen.Text, "%", "")
            TxtMargen.Text = FormatPercent(TxtMargen.Text / 100, 2)
        Catch ex As Exception
            MsgBox("Erro ao converter o valor para percentual." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema Brecho.")
        End Try
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja realmente excluir o prodtuo " & txtCodProduto.Text & " - " & txtNomeProduto.Text, MsgBoxStyle.YesNo, "Sistema de controle") = MsgBoxResult.Yes Then
            ProdutosTableAdapter.DeleteQuery(txtCodProduto.Text)
            MsgBox("Produto apagado com sucesso!", MsgBoxStyle.Information, "Sistema de controle")
            Validacoes.Fecha_o_Formulario(Me)
            mdiTelaPrinciapal.MenuCadastrarProd_Click(sender, e)
        End If
    End Sub

    Private Sub FrmProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            e.Handled = True
            FrmCadastros.Show()
            ModuloCadastros.CadastroSelecionado = "Fornecedores"
            ComboBox()
        ElseIf e.KeyCode = keys.f6 Then
            e.Handled = True
            FrmCadastros.Show()
            ModuloCadastros.CadastroSelecionado = "Empresas"
            ComboBox()
        End If
    End Sub

    Private Sub FrmProdutos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Validate()
        FornecedoresBindingSource.EndEdit()
        EmpresasBindingSource.EndEdit()
        BancoSysBrechoDataSet.AcceptChanges()
        cbxFornecedor.Items.Clear()
        cbxEmpresa.Items.Clear()
        ComboBox()
    End Sub
End Class
Public Class FrmVendas

    ' Variveis
    Public CodigoVenda As Integer


    ' Funções e Procedimentos
    Private Function CodVenda() As Integer
        Dim CodigoVenda = VendasTableAdapter.SelectCodigoUltimaVenda()

        If CodigoVenda Is Nothing Then
            CodigoVenda = 1
        End If

        Return CodigoVenda
    End Function

    Private Sub NewMethodVendas()
        Me.VendasTableAdapter.Fill(Me.BancoSysBrechoDataSet.Vendas)
    End Sub

    Private Sub NewMethodSubVendas()
        Me.Sub_VendasTableAdapter.Fill(Me.BancoSysBrechoDataSet.Sub_Vendas)
    End Sub

    Private Sub NewMethodClientes()
        Me.ClientesTableAdapter.Fill(Me.BancoSysBrechoDataSet.Clientes)
    End Sub

    Private Sub NewMethodProdutos()
        Me.ProdutosTableAdapter.Fill(Me.BancoSysBrechoDataSet.Produtos)
    End Sub

    Private Function AddLinhaGrid()
        DtvProdutos.Rows.Add()
    End Function

    Private Function MsErro()
        LblErroCodigo.Visible = True
    End Function

    Public Function NovaVenda()
        VendasTableAdapter.NovaVendaInsertQuery(FormatDateTime(Now, DateFormat.ShortDate))
        CodigoVenda = CodVenda()
    End Function

    Private Function SubVendaInsert(CodCli As Integer, CodProd As Integer, CodFor As Integer, CodEmp As Integer, ValorVenda As Decimal, DataVenda As Date)
        Sub_VendasTableAdapter.InsertQuerySubVendas(CodigoVenda, CodCli, CodProd, CodFor, CodEmp, ValorVenda, DataVenda)
    End Function

    Private Function Venda()
        Dim Index As Integer
        Dim CodProd As String
        Dim CodRegistProd As Integer
        Dim DescProd As String
        Dim ValorVenda As Decimal
        Dim CodFor As Integer
        Dim CodEmp As Integer
        Dim DataVenda As Date
        Dim CodCli As Integer = 1

        Validate()
        ProdutosBindingSource.EndEdit()
        BancoSysBrechoDataSet.AcceptChanges()

        Try
            ''substituir pelo de baixo
            'Dim tabela = ProdutosTableAdapter.GetDataVendasNovas(TxtCodProdBusca.Text)
            'For Each prod In tabela
            '    MsgBox(prod.Nome & prod.Valor_Venda)
            'Next
            Dim Produto = ProdutosTableAdapter.GetDataVendasNovas(TxtCodProdBusca.Text)

            If Produto.Count() = 0 Then
                MsErro()
                Exit Function
            End If

            AddLinhaGrid()
            Index = DtvProdutos.Rows.Count - 1
            CodProd = TxtCodProdBusca.Text

            For Each Prod In Produto
                DescProd = Prod.Nome
                ValorVenda = Prod.Valor_Venda
                CodFor = Prod.Fornecedor
                CodEmp = Prod.Empresa
                CodRegistProd = Prod._Cod_
            Next

            DtvProdutos.Rows(Index).Cells(0).Value = Index + 1
            DtvProdutos.Rows(Index).Cells(1).Value = TxtCodProdBusca.Text
            DtvProdutos.Rows(Index).Cells(2).Value = TxtQtd.Text
            DtvProdutos.Rows(Index).Cells(3).Value = DescProd
            DtvProdutos.Rows(Index).Cells(4).Value = FormatCurrency(ValorVenda, 2)
            DtvProdutos.Rows(Index).Cells(5).Value = FormatCurrency(ValorVenda * TxtQtd.Text, 2)
            Valor += ValorVenda * TxtQtd.Text
            TxtTotalCompra.Text = FormatCurrency(Valor, 2)
            TxtCodProdBusca.Text = ""
            TxtQtd.Text = 1
            DataVenda = FormatDateTime(Now, DateFormat.ShortDate)

            SubVendaInsert(CodCli, CodRegistProd, CodFor, CodEmp, Valor, DataVenda)

        Catch ex As Exception
            MsgBox("Erro ao Adicionar o produto!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Controle de Produtos")
        End Try
    End Function

    Private Function DeletaProduto()
        Dim CodProdDel As Integer = DtvProdutos.CurrentRow().Cells(1).Value
        Dim Resp = MsgBox("Deseja excluir o Produto " & DtvProdutos.CurrentRow().Cells(3).Value & " ?", MsgBoxStyle.YesNo, "Sistema de Controle")

        If Resp = 6 Then
            Try
                Validate()
                SubVendasBindingSource.EndEdit()
                BancoSysBrechoDataSet.AcceptChanges()
                DtvProdutos.Rows.RemoveAt(DtvProdutos.CurrentRow().Index)
                Sub_VendasTableAdapter.DeleteProdutoQuery(CodigoVenda, CodProdDel, FormatDateTime(Now, DateFormat.ShortDate))
                TxtTotalCompra.Text = FormatCurrency(TxtTotalCompra.Text - DtvProdutos.CurrentRow().Cells(5).Value, 2)
            Catch ex As Exception
                MsgBox("Erro ao apagar registro!" & ex.Message, MsgBoxStyle.Information, "Erro. Sistema de Controle")
            End Try
        End If
    End Function

    ' Inicio de funcionamento do Sistema
    Private Sub FrmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NewMethodClientes()
        NewMethodSubVendas()
        NewMethodVendas()
        NewMethodProdutos()
        TxtCaixa.Text = "Caixa Fechado"
        TxtCaixa.BackColor = Color.Red
        TxtCaixa.ForeColor = Color.White
        BtnAbrirFecharCx.Enabled = True
        BtnFechar.Enabled = True
        PanelVendas.Enabled = False
        TxtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        WindowState = FormWindowState.Maximized
        DtvProdutos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DtvProdutos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DtvProdutos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DtvProdutos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DtvProdutos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DtvProdutos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'NovaVenda()
        'CodigoVenda = CodVenda()
        LblCopy.Text = Chr(169) & "Copyright by Rogerio Cordeiro"
    End Sub

    Private Sub TxtCodProdBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodProdBusca.KeyPress
        Validate()
        ProdutosBindingSource.EndEdit()
        BancoSysBrechoDataSet.AcceptChanges()

        If e.KeyChar() = Chr(Keys.Enter) Then
            Venda()
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCodProdBusca_TextChanged(sender As Object, e As EventArgs) Handles TxtCodProdBusca.TextChanged
        LblErroCodigo.Visible = False
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Try
            Validate()
            VendasBindingSource.EndEdit()
            SubVendasBindingSource.EndEdit()
            BancoSysBrechoDataSet.AcceptChanges()
            Dim VendaAndamento As Integer = DtvProdutos.Rows.Count()
            If VendaAndamento > 0 Then
                MsgBox("Finalize a venda antes de fechar o caixa!", MsgBoxStyle.Information, "Sistema de Controle")
            Else
                Validacoes.Fecha_o_Formulario(Me)
            End If
        Catch ex As Exception
            MsgBox("Erro ao fechar o caixa!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try

    End Sub

    Private Sub BtnReceber_Click(sender As Object, e As EventArgs) Handles BtnReceber.Click
        If TxtTotalCompra.Text IsNot "" Then
            DtvPesq.Visible = False
            TxtPesqDesc.Visible = False
            FormFinalizarVenda.Show()
        End If
    End Sub

    Private Sub DtvProdutos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvProdutos.CellContentDoubleClick
        If DtvProdutos.SelectedRows.Count > 0 Then ' AndAlso Not DtvProdutos.SelectedRows(0).Index = DtvProdutos.Rows.Count - 1 Then
            DeletaProduto()
        End If
    End Sub

    Private Sub BtnAbrirFecharCx_Click(sender As Object, e As EventArgs) Handles BtnAbrirFecharCx.Click
        CodigoVenda = CodVenda()

        Dim VendaNova = VendasTableAdapter.SelectVendaVazia(CodigoVenda)
        ' MsgBox(VendaNova)
        If TxtCaixa.Text = "Caixa Fechado" And DtvProdutos.Rows().Count = 0 Then
            'Finalizada = False
            If CInt(VendaNova) > 0 Or VendaNova = Nothing Then
                NovaVenda()
                CodigoVenda = CodVenda()
            End If
            PanelVendas.Enabled = True
            TxtCaixa.Text = "Caixa Aberto"
            TxtCaixa.BackColor = Color.Green
            TxtCaixa.ForeColor = Color.White
            BtnFechar.Enabled = False
            BtnAbrirFecharCx.Text = "Fechar Caixa"
            'BtnAbrirFecharCx.BackColor = Color.Red
        ElseIf TxtCaixa.Text = "Caixa Aberto" And DtvProdutos.Rows().Count = 0 Then
            mdiTelaPrinciapal.VendaAndamento = False
            DtvProdutos.Rows().Clear()
            Validate()
            VendasBindingSource.EndEdit()
            SubVendasBindingSource.EndEdit()
            ProdutosBindingSource.EndEdit()
            BancoSysBrechoDataSet.AcceptChanges()
            TxtCaixa.Text = "Caixa Fechado"
            TxtCaixa.BackColor = Color.Red
            TxtCaixa.ForeColor = Color.White
            PanelVendas.Enabled = False
            BtnFechar.Enabled = True
            DtvPesq.Visible = False
            TxtPesqDesc.Visible = False
            BtnAbrirFecharCx.Text = "Abrir Caixa"
            'BtnAbrirFecharCx.BackColor = Color.Blue
            BtnNovaVenda.Enabled = False
        End If
    End Sub

    Private Sub FrmVendas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Validate()
        VendasBindingSource.EndEdit()
        BancoSysBrechoDataSet.AcceptChanges()
    End Sub

    Private Sub TxtPesqDesc_TextChanged(sender As Object, e As EventArgs) Handles TxtPesqDesc.TextChanged
        Try
            Dim pesquisa As DataTable = ProdutosTableAdapter.GetDataByPesquisa(TxtPesqDesc.Text)
            If TxtPesqDesc.Text IsNot "" Then

                DtvPesq.DataSource = pesquisa
                DtvPesq.Columns(1).HeaderText = "Codigo Produto"
                DtvPesq.Columns(3).HeaderText = "Descrição do Produto"
                DtvPesq.Columns(11).DefaultCellStyle.Format = "C2"

                For col = 0 To pesquisa.Columns().Count - 1
                    Select Case col
                        Case Is = 1, Is = 3, Is = 11

                        Case Else
                            MdRelatorios.OcultaColunasDtvg(Dtvg:=DtvPesq, Coluna:=col)
                    End Select
                Next
                DtvPesq.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DtvPesq.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DtvPesq.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Else
                DtvPesq.DataSource = ""
            End If
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical, "Sistema de controle")
        End Try
    End Sub

    Private Sub DtvPesq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvPesq.CellContentClick
        TxtCodProdBusca.Text = DtvPesq.CurrentRow().Cells(1).Value
        DtvPesq.Visible = False
        TxtPesqDesc.Visible = False
        BtnFecharPesq.Visible = False
        Venda()
    End Sub

    Private Sub BtnBusca_Click(sender As Object, e As EventArgs) Handles BtnBusca.Click
        TxtPesqDesc.Visible = True
        TxtPesqDesc.Text = ""
        TxtPesqDesc.Select()
        DtvPesq.Visible = True
        DtvPesq.DataSource = vbNull
        BtnFecharPesq.Visible = True
        'DtvPesq.Rows.Clear()
    End Sub

    Private Sub BtnFecharPesq_Click(sender As Object, e As EventArgs) Handles BtnFecharPesq.Click
        DtvPesq.Visible = False
        TxtPesqDesc.Visible = False
        BtnFecharPesq.Visible = False
    End Sub

    Private Sub BtnNovaVenda_Click(sender As Object, e As EventArgs) Handles BtnNovaVenda.Click
        CodigoVenda = CodVenda()

        Dim VendaNova = VendasTableAdapter.SelectVendaVazia(CodigoVenda)

        'Finalizada = False
        If VendaNova > 0 Or VendaNova = Nothing Then
            NovaVenda()
            CodigoVenda = CodVenda()
        End If

        PanelVendas.Enabled = True
        TxtCaixa.Text = "Caixa Aberto"
        TxtCaixa.BackColor = Color.Blue
        TxtCaixa.ForeColor = Color.White
        BtnFechar.Enabled = False
        BtnAbrirFecharCx.Text = "Fechar Caixa"

    End Sub

    Private Sub FrmVendas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            e.Handled = True
            BtnReceber_Click(sender, e)
        ElseIf e.Keycode = keys.F10 And TxtCaixa.Text = "Caixa Aberto" Then 'Realizar cadastro de um produto
            e.Handled = True
            mdiTelaPrinciapal.VendaAndamento = True
            FrmProdutos.Show()
            Validate()
            ProdutosBindingSource.EndEdit()
            BancoSysBrechoDataSet.AcceptChanges()
        ElseIf e.keycode = keys.F2 And TxtCaixa.Text = "Caixa Aberto" Then 'Realiza pesquisa de produtos
            Try
                If TxtCodProdBusca.Text = "" Then
                    MsgBox("Digitar um codigo para buscar o produto", MsgBoxStyle.ApplicationModal, "Sistema de Vendas")
                Else
                    TxtCodProdBusca.Text = DtvPesq.CurrentRow().Cells(1).Value
                    DtvPesq.Visible = False
                    TxtPesqDesc.Visible = False
                    BtnFecharPesq.Visible = False
                    Venda()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
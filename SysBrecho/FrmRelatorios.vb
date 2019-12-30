Public Class FrmRelatorios
    Dim Selecao As String
    Dim OqueFazer As String
    Public CodAlterar As String

    Private Sub NomeFornecedoresEEmpresas(DataTablePRod As DataTable)
        Dim CodFor As Integer, CodEmp As Integer
        Dim NomeFor As String, NomeEmp As String

        DtvRelacao.Columns.Add("Fornecedor", "Nome Fornecedor")
        DtvRelacao.Columns.Add("Empresa", "Nome da Empresa")

        For Linha = 0 To DataTablePRod.Rows().Count - 1
            CodFor = DtvRelacao.Rows(Linha).Cells(15).Value
            CodEmp = DtvRelacao.Rows(Linha).Cells(16).Value
            NomeEmp = EmpresasTableAdapter.SelectEmpresaNome(CodEmp)
            NomeFor = FornecedoresTableAdapter.SelectNomeFornecedor(CodFor)

            DtvRelacao.Rows(Linha).Cells(19).Value = NomeFor
            DtvRelacao.Rows(Linha).Cells(20).Value = NomeEmp

        Next

    End Sub
    Private Sub OcultaColunas(TabelaDtv As DataTable)
        DtvRelacao.Columns(1).HeaderText = "Codigo Produto"
        DtvRelacao.Columns(3).HeaderText = "Descrição do Produto"
        DtvRelacao.Columns(10).DefaultCellStyle.Format = "C2"
        DtvRelacao.Columns(11).DefaultCellStyle.Format = "C2"

        For col = 0 To TabelaDtv.Columns().Count - 1
            Select Case col
                Case Is = 1, Is = 3, Is = 10, Is = 11, Is = 2, Is = 12, Is = 9, Is = 17 ', Is = 15, Is = 16
                    ' DtvRelacao.Columns(col).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case Else
                    MdRelatorios.OcultaColunasDtvg(Dtvg:=DtvRelacao, Coluna:=col)
            End Select
        Next
        DtvRelacao.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DtvRelacao.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        For Each columns As DataGridViewColumn In DtvRelacao.Columns
            ' Define as propriedades para todas as colunas;
            DtvRelacao.Columns(columns.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub CarregarProdutos()

        Dim DataTableProd As DataTable = Me.ProdutosTableAdapter.GetData()
        Me.DtvRelacao.DataSource = DataTableProd
        OcultaColunas(DataTableProd)
        NomeFornecedoresEEmpresas(DataTableProd)

    End Sub
    Private Sub CarregarCategorias()

        Dim DataTableCateg As DataTable = ProdutosTableAdapter.GetDataBySelectCategoria()
        LtbCategoria.ValueMember = "Categoria"
        LtbCategoria.DisplayMember = "Categoria"
        Me.LtbCategoria.DataSource = DataTableCateg

    End Sub
    Private Sub FrmRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpresasTableAdapter.Fill(Me.BancoSysBrechoDataSet.Empresas)
        Me.ClientesTableAdapter.Fill(Me.BancoSysBrechoDataSet.Clientes)
        Me.FornecedoresTableAdapter.Fill(Me.BancoSysBrechoDataSet.Fornecedores)
        FrmProdutos.ProdutosTableAdapter.Fill(FrmProdutos.BancoSysBrechoDataSet.Produtos)

        CarregarCategorias()
        LtbCategoria.SelectedIndex = -1
        WindowState = FormWindowState.Maximized
        'DtvRelacao.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    'Private Sub PosicoesGrupBox(x, y, wigth, height)
    '    GboxGriedRelacoes.Location = New Point(x, y)
    '    GboxGriedRelacoes.Size = New Size(wigth, height)

    'End Sub

    Private Sub CarregaConformeCategoriaSelect()

        Dim DataTableSelect As DataTable = ProdutosTableAdapter.GetDataByCategSelecionada(LtbCategoria.SelectedValue)
        DtvRelacao.DataSource = DataTableSelect
        OcultaColunas(DataTableSelect)
        NomeFornecedoresEEmpresas(DataTableSelect)
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Validacoes.Fecha_o_Formulario(Me)
    End Sub

    Private Sub LtbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtbCategoria.SelectedIndexChanged
        DtvRelacao.DataSource = Nothing
        DtvRelacao.Rows.Clear()
        DtvRelacao.Columns.Clear()
        DtvRelacao.Refresh()
        CarregaConformeCategoriaSelect()
    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        LtbCategoria.SelectedIndex = -1
        DtvRelacao.DataSource = Nothing
        DtvRelacao.Rows.Clear()
        DtvRelacao.Columns.Clear()
        DtvRelacao.Refresh()
        CarregarProdutos()

    End Sub

    Private Sub RbProdutos_CheckedChanged(sender As Object, e As EventArgs) Handles RbProdutos.CheckedChanged
        DtvRelacao.DataSource = Nothing
        DtvRelacao.Rows.Clear()
        DtvRelacao.Columns.Clear()
        DtvRelacao.Refresh()
        GboxGriedRelacoes.Text = "Relação de Produtos"
        GboxCategoria.Visible = True

        CarregarProdutos()

        'CarregarCategorias()
        'Dim PosX = Panel1.Location.X
        'PosicoesGrupBox(PosX + 186, 76, 811, 542)
        BtnTodos.Visible = True
        For Each columns As DataGridViewColumn In DtvRelacao.Columns
            ' Define as propriedades para todas as colunas;
            DtvRelacao.Columns(columns.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        Selecao = RbProdutos.Text
    End Sub

    Private Sub RbClientes_CheckedChanged(sender As Object, e As EventArgs) Handles RbClientes.CheckedChanged
        DtvRelacao.DataSource = Nothing
        DtvRelacao.Rows.Clear()
        DtvRelacao.Columns.Clear()
        DtvRelacao.Refresh()
        GboxGriedRelacoes.Text = "Relação de Clientes"
        Dim clientes As DataTable = FrmCadastros.ClientesTableAdapter.GetData()
        DtvRelacao.DataSource = clientes
        'Dim PosX = Panel1.Location.X
        'PosicoesGrupBox(PosX, 76, 995, 542)
        GboxCategoria.Visible = False
        BtnTodos.Visible = False
        For Each columns As DataGridViewColumn In DtvRelacao.Columns
            ' Define as propriedades para todas as colunas;
            DtvRelacao.Columns(columns.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For col = 0 To clientes.Columns().Count - 1
            Select Case col
                Case Is = 1, Is = 2, Is = 3, Is = 4, Is = 5, Is = 11, Is = 12, Is = 13, Is = 15

                Case Else
                    MdRelatorios.OcultaColunasDtvg(Dtvg:=DtvRelacao, Coluna:=col)
            End Select
        Next
        Selecao = RbClientes.Text
    End Sub

    Private Sub RbFornecedores_CheckedChanged(sender As Object, e As EventArgs) Handles RbFornecedores.CheckedChanged
        DtvRelacao.DataSource = Nothing
        DtvRelacao.Rows.Clear()
        DtvRelacao.Columns.Clear()
        DtvRelacao.Refresh()
        GboxGriedRelacoes.Text = "Relação de Fornecedores"
        Dim fornecedores As DataTable = FrmCadastros.FornecedoresTableAdapter.GetData()
        DtvRelacao.DataSource = fornecedores
        'Dim PosX = Panel1.Location.X
        'PosicoesGrupBox(PosX, 76, 995, 542)
        GboxCategoria.Visible = False
        BtnTodos.Visible = False
        For Each columns As DataGridViewColumn In DtvRelacao.Columns
            ' Define as propriedades para todas as colunas;
            DtvRelacao.Columns(columns.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For col = 0 To fornecedores.Columns().Count - 1
            Select Case col
                Case Is = 1, Is = 2, Is = 3, Is = 4, Is = 5, Is = 11, Is = 12, Is = 13, Is = 15

                Case Else
                    MdRelatorios.OcultaColunasDtvg(Dtvg:=DtvRelacao, Coluna:=col)
            End Select
        Next
        Selecao = RbFornecedores.Text
    End Sub

    Private Sub RbEmpresas_CheckedChanged(sender As Object, e As EventArgs) Handles RbEmpresas.CheckedChanged
        DtvRelacao.DataSource = Nothing
        DtvRelacao.Rows.Clear()
        DtvRelacao.Columns.Clear()
        DtvRelacao.Refresh()
        GboxGriedRelacoes.Text = "Relação de Empresas"
        Dim empresas As DataTable = FrmCadastros.EmpresasTableAdapter.GetData()
        DtvRelacao.DataSource = empresas
        GboxCategoria.Visible = False
        BtnTodos.Visible = False
        For Each columns As DataGridViewColumn In DtvRelacao.Columns
            ' Define as propriedades para todas as colunas;
            DtvRelacao.Columns(columns.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For col = 0 To empresas.Columns().Count - 1
            Select Case col
                Case Is = 1, Is = 2, Is = 3, Is = 4, Is = 5, Is = 11, Is = 12, Is = 13, Is = 15

                Case Else
                    MdRelatorios.OcultaColunasDtvg(Dtvg:=DtvRelacao, Coluna:=col)
            End Select
        Next
        Selecao = RbEmpresas.Text
    End Sub
    Private Function Mensagem(text As String) As MsgBoxResult
        Dim resp As MsgBoxResult = MsgBox(text, MsgBoxStyle.YesNo, "Sistema de controle")
        Return resp
    End Function
    Private Function InputMsgBox(Text As String) As String
        OqueFazer = InputBox("O que deseja fazer com  " & Text & Chr(13) & Chr(10) & "Digite uma das opções abaixo:" & Chr(13) _
                    & Chr(10) _
                    & "1 - Para Alterar " _
                    & Chr(13) & Chr(10) & "2 - Para Excluir", "Sistema de Controle", "1")
        Return OqueFazer
    End Function

    Private Sub DtvRelacao_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvRelacao.CellContentDoubleClick
        Select Case Selecao
            Case Is = "Consulta Produtos"
                OqueFazer = InputMsgBox("o produto Cod " & DtvRelacao.CurrentRow.Cells(1).Value & " - " & DtvRelacao.CurrentRow.Cells(3).Value)
                Select Case OqueFazer
                    Case Is = 1
                        CodAlterar = DtvRelacao.CurrentRow.Cells(1).Value
                        mdiTelaPrinciapal.MenuCadastrarProd_Click(sender, e)
                        FrmProdutos.txtCodProduto.Text = CodAlterar
                        FrmProdutos.BtnConsultar_Click(sender, e)
                        FrmProdutos.BtnEditarProd_Click(sender, e)
                    Case Is = 2
                        If Mensagem("Deseja apagar o Produto selecionado? Cod " & DtvRelacao.CurrentRow.Cells(1).Value & " - " & DtvRelacao.CurrentRow.Cells(3).Value) = MsgBoxResult.Yes Then
                            ProdutosTableAdapter.DeleteQuery(DtvRelacao.CurrentRow.Cells(1).Value)
                            RbProdutos_CheckedChanged(sender, e)
                        End If
                End Select
            Case Is = "Consulta Fornecedores"
                OqueFazer = InputMsgBox("o Fornecedor Cod " & DtvRelacao.CurrentRow.Cells(2).Value & " - " & DtvRelacao.CurrentRow.Cells(3).Value)
                Select Case OqueFazer
                    Case Is = 1
                        CodAlterar = DtvRelacao.CurrentRow.Cells(2).Value
                        mdiTelaPrinciapal.CadastrarFornecedorMenu_Click(sender, e)
                        FrmCadastros.cbxTpDocumentos.Text = DtvRelacao.CurrentRow.Cells(1).Value
                        FrmCadastros.mtxtNumDocumento.Text = CodAlterar
                        FrmCadastros.BtnConsultar_Click(sender, e)
                        FrmCadastros.BtnEditar_Click()
                    Case Is = 2
                        If Mensagem("Deseja apagar o Produto selecionado? Cod " & DtvRelacao.CurrentRow.Cells(1).Value & " - " & DtvRelacao.CurrentRow.Cells(3).Value) = MsgBoxResult.Yes Then
                            FornecedoresTableAdapter.DeleteQuery(DtvRelacao.CurrentRow.Cells(2).Value)
                            RbFornecedores_CheckedChanged(sender, e)
                        End If
                End Select
        End Select
    End Sub

End Class
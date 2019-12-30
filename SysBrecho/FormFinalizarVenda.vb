Public Class FormFinalizarVenda
    Private CodVenda As Integer
    Private TotalProdutos As Integer

    Private Sub TxtPago_TextChanged(sender As Object, e As EventArgs) Handles TxtPago.TextChanged
        If TxtPago.Text Is "" Then
            Return
        End If
        Try
            TxtTroco.Text = "R$ " & FormatNumber(TxtPago.Text - TxtAReceber.Text, 2)
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub FormFinalizarVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BancoSysBrechoDataSet.Sub_Vendas'. Você pode movê-la ou removê-la conforme necessário.
        Me.Sub_VendasTableAdapter.Fill(Me.BancoSysBrechoDataSet.Sub_Vendas)
        Me.VendasTableAdapter.Fill(Me.BancoSysBrechoDataSet.Vendas)
        Try
            TxtAReceber.Text = "R$ " & FormatNumber(FrmVendas.TxtTotalCompra.Text, 2)
            CbFormaPgto.SelectedIndex = 0
        Catch
            Exit Sub
        End Try
        CodVenda = FrmVendas.CodigoVenda
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Validate()
        VendasBindingSource.EndEdit()
        SubVendasBindingSource.EndEdit()
        BancoSysBrechoDataSet.AcceptChanges()
        TotalProdutos = Sub_VendasTableAdapter.ContaProdutos(CodVenda)
        VendasTableAdapter.VendasSubVendasUpdateQuery(TxtAReceber.Text, FormatDateTime(Now, DateFormat.ShortDate), TotalProdutos, CbFormaPgto.Text, 1, CodVenda)
        Me.Close()
        Finalizada = True
        FrmVendas.DtvProdutos.Rows.Clear()
        FrmVendas.TxtTotalCompra.Text = ""
        'FrmVendas.NovaVenda()
        FrmVendas.Select()
        Valor = 0
        FrmVendas.PanelVendas.Enabled = False
        FrmVendas.BtnNovaVenda.Enabled = True
        'Validacoes.Fecha_o_Formulario(FrmVendas)
        'mdiTelaPrinciapal.VendaToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub BtnCancela_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        Me.Close()
    End Sub

    Private Sub TxtPago_Leave(sender As Object, e As EventArgs) Handles TxtPago.Leave
        If IsNumeric(TxtPago.Text) Then
            TxtPago.Text = FormatCurrency(TxtPago.Text, 2)
        End If
    End Sub
End Class
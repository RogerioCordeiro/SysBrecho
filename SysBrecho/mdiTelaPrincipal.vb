Imports System.ComponentModel

Public Class mdiTelaPrinciapal
    Public Cadastrar As Boolean
    Public Consultar As Boolean
    Public Alterar As Boolean
    Public VendaAndamento As Boolean = False
    ReadOnly Validas As New Validacoes

    Private Sub AlterarEmpresasMenu_Click(sender As Object, e As EventArgs) Handles AlterarEmpresasMenu.Click
        ModuloCadastros.CadastroSelecionado = "Empresas"
        Alterar = Validas.AbrirCadastro(FrmCadastros)
    End Sub

    Private Sub ConsultarEmpresasMenu_Click(sender As Object, e As EventArgs) Handles ConsultarEmpresasMenu.Click
        Consultar = Validas.AbrirCadastro(FrmRelatorios)
        FrmRelatorios.RbEmpresas.Checked = True
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarFonecedorMenu.Click
        ModuloCadastros.CadastroSelecionado = "Fornecedores"
        Alterar = Validas.AbrirCadastro(FrmCadastros)
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarFornecedorMenu.Click
        Consultar = Validas.AbrirCadastro(FrmRelatorios)
        FrmRelatorios.RbFornecedores.Checked = True
    End Sub

    Private Sub AlterarClientes_Click(sender As Object, e As EventArgs) Handles AlterarClientes.Click
        ModuloCadastros.CadastroSelecionado = "Clientes"
        Alterar = Validas.AbrirCadastro(FrmCadastros)
    End Sub

    Public Sub CadastrarClientes_Click(sender As Object, e As EventArgs) Handles CadastrarClientes.Click
        ModuloCadastros.CadastroSelecionado = "Clientes"
        Cadastrar = Validas.AbrirCadastro(FrmCadastros)

    End Sub

    Private Sub ConsultaClientes_Click(sender As Object, e As EventArgs) Handles ConsultaClientes.Click
        Consultar = Validas.AbrirCadastro(FrmRelatorios)
        FrmRelatorios.RbClientes.Checked = True
    End Sub

    Public Sub MenuCadastrarProd_Click(sender As Object, e As EventArgs) Handles MenuCadastrarProd.Click
        MainMenuStrip.Enabled = False
        FrmProdutos.MdiParent = Me
        FrmProdutos.Show()
        Cadastrar = True

    End Sub

    Private Sub MenuAlterarProd_Click(sender As Object, e As EventArgs) Handles MenuAlterarProd.Click
        MainMenuStrip.Enabled = False
        FrmProdutos.MdiParent = Me
        FrmProdutos.Show()
        Alterar = True
    End Sub

    Private Sub MenuConsultarProd_Click(sender As Object, e As EventArgs) Handles MenuConsultarProd.Click
        MainMenuStrip.Enabled = False
        FrmRelatorios.MdiParent = Me
        FrmRelatorios.Show()
        FrmRelatorios.RbProdutos.Checked = True
        Consultar = True
    End Sub

    Private Sub TodosOsProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmRelatorios.MdiParent = Me
        FrmRelatorios.Show()
    End Sub

    Public Sub CadastrarEmpresasMenu_Click(sender As Object, e As EventArgs) Handles CadastrarEmpresasMenu.Click
        ModuloCadastros.CadastroSelecionado = "Empresas"
        Cadastrar = Validas.AbrirCadastro(FrmCadastros)

    End Sub

    Public Sub VendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendaToolStripMenuItem.Click
        MainMenuStrip.Enabled = False
        FrmVendas.MdiParent = Me
        FrmVendas.Show()
    End Sub

    Public Sub CadastrarFornecedorMenu_Click(sender As Object, e As EventArgs) Handles CadastrarFornecedorMenu.Click
        ModuloCadastros.CadastroSelecionado = "Fornecedores"
        Cadastrar = Validas.AbrirCadastro(FrmCadastros)

    End Sub

    Private Sub MdiTelaPrinciapal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenuStrip.Enabled = False
        FrmLogin.MdiParent = Me

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        StatusBarCopy.Text = Chr(169) & "Copyright by Rogerio Cordeiro"
        FrmLogin.Show()
    End Sub



    Private Sub mdiTelaPrinciapal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MsgBox("Deseja realmente sair?", MsgBoxStyle.OkCancel, "Sistema de Controle") = MsgBoxResult.Cancel) Then
            e.Cancel = True
        End If
    End Sub
End Class

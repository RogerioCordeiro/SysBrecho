<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiTelaPrinciapal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiTelaPrinciapal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAlterarProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCadastrarProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuConsultarProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarFonecedorMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarFornecedorMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarFornecedorMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarEmpresasMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarEmpresasMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEmpresasMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusBarCopy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuProdutos, Me.FornecedoresToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.ToolStripMenuItem1, Me.VendaToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuProdutos
        '
        Me.MenuProdutos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAlterarProd, Me.MenuCadastrarProd, Me.MenuConsultarProd})
        Me.MenuProdutos.Image = CType(resources.GetObject("MenuProdutos.Image"), System.Drawing.Image)
        Me.MenuProdutos.Name = "MenuProdutos"
        Me.MenuProdutos.Size = New System.Drawing.Size(113, 34)
        Me.MenuProdutos.Text = "Produtos"
        '
        'MenuAlterarProd
        '
        Me.MenuAlterarProd.Image = CType(resources.GetObject("MenuAlterarProd.Image"), System.Drawing.Image)
        Me.MenuAlterarProd.Name = "MenuAlterarProd"
        Me.MenuAlterarProd.Size = New System.Drawing.Size(160, 36)
        Me.MenuAlterarProd.Text = "Alterar"
        '
        'MenuCadastrarProd
        '
        Me.MenuCadastrarProd.Image = CType(resources.GetObject("MenuCadastrarProd.Image"), System.Drawing.Image)
        Me.MenuCadastrarProd.Name = "MenuCadastrarProd"
        Me.MenuCadastrarProd.Size = New System.Drawing.Size(160, 36)
        Me.MenuCadastrarProd.Text = "Cadastrar"
        '
        'MenuConsultarProd
        '
        Me.MenuConsultarProd.Image = CType(resources.GetObject("MenuConsultarProd.Image"), System.Drawing.Image)
        Me.MenuConsultarProd.Name = "MenuConsultarProd"
        Me.MenuConsultarProd.Size = New System.Drawing.Size(160, 36)
        Me.MenuConsultarProd.Text = "Consultar"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarFonecedorMenu, Me.CadastrarFornecedorMenu, Me.ConsultarFornecedorMenu})
        Me.FornecedoresToolStripMenuItem.Image = CType(resources.GetObject("FornecedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(148, 34)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'AlterarFonecedorMenu
        '
        Me.AlterarFonecedorMenu.Image = CType(resources.GetObject("AlterarFonecedorMenu.Image"), System.Drawing.Image)
        Me.AlterarFonecedorMenu.Name = "AlterarFonecedorMenu"
        Me.AlterarFonecedorMenu.Size = New System.Drawing.Size(160, 36)
        Me.AlterarFonecedorMenu.Text = "Alterar"
        '
        'CadastrarFornecedorMenu
        '
        Me.CadastrarFornecedorMenu.Image = CType(resources.GetObject("CadastrarFornecedorMenu.Image"), System.Drawing.Image)
        Me.CadastrarFornecedorMenu.Name = "CadastrarFornecedorMenu"
        Me.CadastrarFornecedorMenu.Size = New System.Drawing.Size(160, 36)
        Me.CadastrarFornecedorMenu.Text = "Cadastrar"
        '
        'ConsultarFornecedorMenu
        '
        Me.ConsultarFornecedorMenu.Image = CType(resources.GetObject("ConsultarFornecedorMenu.Image"), System.Drawing.Image)
        Me.ConsultarFornecedorMenu.Name = "ConsultarFornecedorMenu"
        Me.ConsultarFornecedorMenu.Size = New System.Drawing.Size(160, 36)
        Me.ConsultarFornecedorMenu.Text = "Consultar"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarEmpresasMenu, Me.CadastrarEmpresasMenu, Me.ConsultarEmpresasMenu})
        Me.EmpresasToolStripMenuItem.Image = CType(resources.GetObject("EmpresasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(122, 34)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'AlterarEmpresasMenu
        '
        Me.AlterarEmpresasMenu.Image = CType(resources.GetObject("AlterarEmpresasMenu.Image"), System.Drawing.Image)
        Me.AlterarEmpresasMenu.Name = "AlterarEmpresasMenu"
        Me.AlterarEmpresasMenu.Size = New System.Drawing.Size(160, 36)
        Me.AlterarEmpresasMenu.Text = "Alterar"
        '
        'CadastrarEmpresasMenu
        '
        Me.CadastrarEmpresasMenu.Image = CType(resources.GetObject("CadastrarEmpresasMenu.Image"), System.Drawing.Image)
        Me.CadastrarEmpresasMenu.Name = "CadastrarEmpresasMenu"
        Me.CadastrarEmpresasMenu.Size = New System.Drawing.Size(160, 36)
        Me.CadastrarEmpresasMenu.Text = "Cadastrar"
        '
        'ConsultarEmpresasMenu
        '
        Me.ConsultarEmpresasMenu.Image = CType(resources.GetObject("ConsultarEmpresasMenu.Image"), System.Drawing.Image)
        Me.ConsultarEmpresasMenu.Name = "ConsultarEmpresasMenu"
        Me.ConsultarEmpresasMenu.Size = New System.Drawing.Size(160, 36)
        Me.ConsultarEmpresasMenu.Text = "Consultar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarClientes, Me.CadastrarClientes, Me.ConsultaClientes})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 34)
        Me.ToolStripMenuItem1.Text = "Clientes"
        '
        'AlterarClientes
        '
        Me.AlterarClientes.Image = CType(resources.GetObject("AlterarClientes.Image"), System.Drawing.Image)
        Me.AlterarClientes.Name = "AlterarClientes"
        Me.AlterarClientes.Size = New System.Drawing.Size(160, 36)
        Me.AlterarClientes.Text = "Alterar"
        '
        'CadastrarClientes
        '
        Me.CadastrarClientes.Image = CType(resources.GetObject("CadastrarClientes.Image"), System.Drawing.Image)
        Me.CadastrarClientes.Name = "CadastrarClientes"
        Me.CadastrarClientes.Size = New System.Drawing.Size(160, 36)
        Me.CadastrarClientes.Text = "Cadastrar"
        '
        'ConsultaClientes
        '
        Me.ConsultaClientes.Image = CType(resources.GetObject("ConsultaClientes.Image"), System.Drawing.Image)
        Me.ConsultaClientes.Name = "ConsultaClientes"
        Me.ConsultaClientes.Size = New System.Drawing.Size(160, 36)
        Me.ConsultaClientes.Text = "Consultar"
        '
        'VendaToolStripMenuItem
        '
        Me.VendaToolStripMenuItem.Image = Global.SysBrecho.My.Resources.Resources.icons8_finalizar_pedido_64
        Me.VendaToolStripMenuItem.Name = "VendaToolStripMenuItem"
        Me.VendaToolStripMenuItem.Size = New System.Drawing.Size(95, 34)
        Me.VendaToolStripMenuItem.Text = "Venda"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = Global.SysBrecho.My.Resources.Resources.icons8_pesquisa_paga_96
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(121, 34)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarCopy})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 705)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusBarCopy
        '
        Me.StatusBarCopy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StatusBarCopy.Name = "StatusBarCopy"
        Me.StatusBarCopy.Size = New System.Drawing.Size(140, 19)
        Me.StatusBarCopy.Text = "ToolStripStatusLabel1"
        '
        'mdiTelaPrinciapal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "mdiTelaPrinciapal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sistema Controle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarFonecedorMenu As ToolStripMenuItem
    Friend WithEvents CadastrarFornecedorMenu As ToolStripMenuItem
    Friend WithEvents ConsultarFornecedorMenu As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarEmpresasMenu As ToolStripMenuItem
    Friend WithEvents CadastrarEmpresasMenu As ToolStripMenuItem
    Friend WithEvents ConsultarEmpresasMenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlterarClientes As ToolStripMenuItem
    Friend WithEvents CadastrarClientes As ToolStripMenuItem
    Friend WithEvents ConsultaClientes As ToolStripMenuItem
    Friend WithEvents MenuProdutos As ToolStripMenuItem
    Friend WithEvents MenuAlterarProd As ToolStripMenuItem
    Friend WithEvents MenuCadastrarProd As ToolStripMenuItem
    Friend WithEvents MenuConsultarProd As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusBarCopy As ToolStripStatusLabel
End Class

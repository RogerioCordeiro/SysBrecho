<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DtvRelacao = New System.Windows.Forms.DataGridView()
        Me.GboxGriedRelacoes = New System.Windows.Forms.GroupBox()
        Me.GboxCategoria = New System.Windows.Forms.GroupBox()
        Me.LtbCategoria = New System.Windows.Forms.ListBox()
        Me.BtnTodos = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbEmpresas = New System.Windows.Forms.RadioButton()
        Me.RbFornecedores = New System.Windows.Forms.RadioButton()
        Me.RbProdutos = New System.Windows.Forms.RadioButton()
        Me.RbClientes = New System.Windows.Forms.RadioButton()
        Me.BancoSysBrechoDataSet = New SysBrecho.BancoSysBrechoDataSet()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.ProdutosTableAdapter()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.FornecedoresTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.ClientesTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.EmpresasTableAdapter()
        CType(Me.DtvRelacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxGriedRelacoes.SuspendLayout()
        Me.GboxCategoria.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtvRelacao
        '
        Me.DtvRelacao.AllowUserToAddRows = False
        Me.DtvRelacao.AllowUserToDeleteRows = False
        Me.DtvRelacao.AllowUserToResizeColumns = False
        Me.DtvRelacao.AllowUserToResizeRows = False
        Me.DtvRelacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtvRelacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DtvRelacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtvRelacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvRelacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtvRelacao.Location = New System.Drawing.Point(3, 22)
        Me.DtvRelacao.Name = "DtvRelacao"
        Me.DtvRelacao.ReadOnly = True
        Me.DtvRelacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DtvRelacao.RowHeadersVisible = False
        Me.DtvRelacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvRelacao.Size = New System.Drawing.Size(761, 651)
        Me.DtvRelacao.TabIndex = 0
        '
        'GboxGriedRelacoes
        '
        Me.GboxGriedRelacoes.Controls.Add(Me.DtvRelacao)
        Me.GboxGriedRelacoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GboxGriedRelacoes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboxGriedRelacoes.Location = New System.Drawing.Point(241, 53)
        Me.GboxGriedRelacoes.Name = "GboxGriedRelacoes"
        Me.GboxGriedRelacoes.Size = New System.Drawing.Size(767, 676)
        Me.GboxGriedRelacoes.TabIndex = 1
        Me.GboxGriedRelacoes.TabStop = False
        Me.GboxGriedRelacoes.Text = "Relação de Produtos"
        '
        'GboxCategoria
        '
        Me.GboxCategoria.Controls.Add(Me.LtbCategoria)
        Me.GboxCategoria.Controls.Add(Me.BtnTodos)
        Me.GboxCategoria.Dock = System.Windows.Forms.DockStyle.Left
        Me.GboxCategoria.Location = New System.Drawing.Point(0, 53)
        Me.GboxCategoria.Name = "GboxCategoria"
        Me.GboxCategoria.Size = New System.Drawing.Size(241, 676)
        Me.GboxCategoria.TabIndex = 2
        Me.GboxCategoria.TabStop = False
        Me.GboxCategoria.Text = "Categorias"
        Me.GboxCategoria.Visible = False
        '
        'LtbCategoria
        '
        Me.LtbCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LtbCategoria.FormattingEnabled = True
        Me.LtbCategoria.ItemHeight = 20
        Me.LtbCategoria.Location = New System.Drawing.Point(3, 74)
        Me.LtbCategoria.Name = "LtbCategoria"
        Me.LtbCategoria.Size = New System.Drawing.Size(235, 599)
        Me.LtbCategoria.TabIndex = 0
        '
        'BtnTodos
        '
        Me.BtnTodos.BackColor = System.Drawing.Color.OldLace
        Me.BtnTodos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTodos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTodos.Location = New System.Drawing.Point(3, 22)
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(235, 52)
        Me.BtnTodos.TabIndex = 4
        Me.BtnTodos.Text = "Mostar todos os produtos"
        Me.BtnTodos.UseVisualStyleBackColor = False
        Me.BtnTodos.Visible = False
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.ForeColor = System.Drawing.Color.Red
        Me.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFechar.Location = New System.Drawing.Point(901, 0)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(107, 53)
        Me.BtnFechar.TabIndex = 3
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbEmpresas)
        Me.Panel1.Controls.Add(Me.BtnFechar)
        Me.Panel1.Controls.Add(Me.RbFornecedores)
        Me.Panel1.Controls.Add(Me.RbProdutos)
        Me.Panel1.Controls.Add(Me.RbClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 53)
        Me.Panel1.TabIndex = 9
        '
        'RbEmpresas
        '
        Me.RbEmpresas.AutoSize = True
        Me.RbEmpresas.Location = New System.Drawing.Point(659, 14)
        Me.RbEmpresas.Name = "RbEmpresas"
        Me.RbEmpresas.Size = New System.Drawing.Size(143, 24)
        Me.RbEmpresas.TabIndex = 13
        Me.RbEmpresas.TabStop = True
        Me.RbEmpresas.Text = "Consulta Empresas"
        Me.RbEmpresas.UseVisualStyleBackColor = True
        '
        'RbFornecedores
        '
        Me.RbFornecedores.AutoSize = True
        Me.RbFornecedores.Location = New System.Drawing.Point(441, 14)
        Me.RbFornecedores.Name = "RbFornecedores"
        Me.RbFornecedores.Size = New System.Drawing.Size(167, 24)
        Me.RbFornecedores.TabIndex = 12
        Me.RbFornecedores.TabStop = True
        Me.RbFornecedores.Text = "Consulta Fornecedores"
        Me.RbFornecedores.UseVisualStyleBackColor = True
        '
        'RbProdutos
        '
        Me.RbProdutos.AutoSize = True
        Me.RbProdutos.Location = New System.Drawing.Point(73, 14)
        Me.RbProdutos.Name = "RbProdutos"
        Me.RbProdutos.Size = New System.Drawing.Size(136, 24)
        Me.RbProdutos.TabIndex = 11
        Me.RbProdutos.TabStop = True
        Me.RbProdutos.Text = "Consulta Produtos"
        Me.RbProdutos.UseVisualStyleBackColor = True
        '
        'RbClientes
        '
        Me.RbClientes.AutoSize = True
        Me.RbClientes.Location = New System.Drawing.Point(260, 14)
        Me.RbClientes.Name = "RbClientes"
        Me.RbClientes.Size = New System.Drawing.Size(130, 24)
        Me.RbClientes.TabIndex = 10
        Me.RbClientes.TabStop = True
        Me.RbClientes.Text = "Consulta Clientes"
        Me.RbClientes.UseVisualStyleBackColor = True
        '
        'BancoSysBrechoDataSet
        '
        Me.BancoSysBrechoDataSet.DataSetName = "BancoSysBrechoDataSet"
        Me.BancoSysBrechoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'FrmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.GboxGriedRelacoes)
        Me.Controls.Add(Me.GboxCategoria)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de fonecedores, produtos, empresas e clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DtvRelacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxGriedRelacoes.ResumeLayout(False)
        Me.GboxCategoria.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DtvRelacao As DataGridView
    Friend WithEvents GboxGriedRelacoes As GroupBox
    Friend WithEvents GboxCategoria As GroupBox
    Friend WithEvents BancoSysBrechoDataSet As BancoSysBrechoDataSet
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As BancoSysBrechoDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents BtnFechar As Button
    Friend WithEvents LtbCategoria As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbClientes As RadioButton
    Friend WithEvents RbProdutos As RadioButton
    Friend WithEvents RbEmpresas As RadioButton
    Friend WithEvents RbFornecedores As RadioButton
    Friend WithEvents BtnTodos As Button
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents FornecedoresTableAdapter As BancoSysBrechoDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BancoSysBrechoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As BancoSysBrechoDataSetTableAdapters.EmpresasTableAdapter
End Class

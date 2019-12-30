<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendas
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendas))
        Me.PanelVendas = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPesqDesc = New System.Windows.Forms.TextBox()
        Me.DtvPesq = New System.Windows.Forms.DataGridView()
        Me.LblCopy = New System.Windows.Forms.Label()
        Me.BtnReceber = New System.Windows.Forms.Button()
        Me.LblErroCodigo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotalCompra = New System.Windows.Forms.TextBox()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxCliente = New System.Windows.Forms.ComboBox()
        Me.DtvProdutos = New System.Windows.Forms.DataGridView()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIÇÃO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇOUNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇOTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtQtd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtCaixa = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodProdBusca = New System.Windows.Forms.TextBox()
        Me.BtnFecharPesq = New System.Windows.Forms.PictureBox()
        Me.BtnBusca = New System.Windows.Forms.PictureBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnAbrirFecharCx = New System.Windows.Forms.Button()
        Me.BancoSysBrechoDataSet = New SysBrecho.BancoSysBrechoDataSet()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.ProdutosTableAdapter()
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.VendasTableAdapter()
        Me.SubVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_VendasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.Sub_VendasTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.ClientesTableAdapter()
        Me.ToolTipBtnBusca = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnNovaVenda = New System.Windows.Forms.Button()
        Me.PanelVendas.SuspendLayout()
        CType(Me.DtvPesq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFecharPesq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelVendas
        '
        Me.PanelVendas.BackColor = System.Drawing.SystemColors.Window
        Me.PanelVendas.Controls.Add(Me.BtnNovaVenda)
        Me.PanelVendas.Controls.Add(Me.Label6)
        Me.PanelVendas.Controls.Add(Me.TxtPesqDesc)
        Me.PanelVendas.Controls.Add(Me.DtvPesq)
        Me.PanelVendas.Controls.Add(Me.LblCopy)
        Me.PanelVendas.Controls.Add(Me.BtnReceber)
        Me.PanelVendas.Controls.Add(Me.LblErroCodigo)
        Me.PanelVendas.Controls.Add(Me.Label5)
        Me.PanelVendas.Controls.Add(Me.TxtTotalCompra)
        Me.PanelVendas.Controls.Add(Me.TxtData)
        Me.PanelVendas.Controls.Add(Me.Label4)
        Me.PanelVendas.Controls.Add(Me.CbxCliente)
        Me.PanelVendas.Controls.Add(Me.DtvProdutos)
        Me.PanelVendas.Controls.Add(Me.Label3)
        Me.PanelVendas.Controls.Add(Me.TxtQtd)
        Me.PanelVendas.Controls.Add(Me.Label1)
        Me.PanelVendas.Controls.Add(Me.PictureBox2)
        Me.PanelVendas.Controls.Add(Me.TxtCaixa)
        Me.PanelVendas.Controls.Add(Me.PictureBox1)
        Me.PanelVendas.Controls.Add(Me.Label2)
        Me.PanelVendas.Controls.Add(Me.TxtCodProdBusca)
        Me.PanelVendas.Controls.Add(Me.BtnFecharPesq)
        Me.PanelVendas.Controls.Add(Me.BtnBusca)
        Me.PanelVendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVendas.Location = New System.Drawing.Point(0, 0)
        Me.PanelVendas.Name = "PanelVendas"
        Me.PanelVendas.Size = New System.Drawing.Size(1008, 692)
        Me.PanelVendas.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(228, 647)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(552, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Atalhos: F2 - Pequisa Produto | F5 - Finaliza a Venda | F10 - Cadastra Produto"
        '
        'TxtPesqDesc
        '
        Me.TxtPesqDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPesqDesc.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPesqDesc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesqDesc.Location = New System.Drawing.Point(307, 137)
        Me.TxtPesqDesc.Name = "TxtPesqDesc"
        Me.TxtPesqDesc.Size = New System.Drawing.Size(414, 29)
        Me.TxtPesqDesc.TabIndex = 30
        Me.TxtPesqDesc.Visible = False
        '
        'DtvPesq
        '
        Me.DtvPesq.AllowUserToAddRows = False
        Me.DtvPesq.AllowUserToDeleteRows = False
        Me.DtvPesq.AllowUserToResizeColumns = False
        Me.DtvPesq.AllowUserToResizeRows = False
        Me.DtvPesq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtvPesq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtvPesq.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DtvPesq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtvPesq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DtvPesq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtvPesq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DtvPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvPesq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtvPesq.GridColor = System.Drawing.SystemColors.Info
        Me.DtvPesq.Location = New System.Drawing.Point(12, 191)
        Me.DtvPesq.Name = "DtvPesq"
        Me.DtvPesq.ReadOnly = True
        Me.DtvPesq.RowHeadersVisible = False
        Me.DtvPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvPesq.Size = New System.Drawing.Size(984, 308)
        Me.DtvPesq.TabIndex = 29
        Me.DtvPesq.Visible = False
        '
        'LblCopy
        '
        Me.LblCopy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCopy.AutoSize = True
        Me.LblCopy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LblCopy.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCopy.ForeColor = System.Drawing.Color.Black
        Me.LblCopy.Location = New System.Drawing.Point(427, 571)
        Me.LblCopy.Name = "LblCopy"
        Me.LblCopy.Size = New System.Drawing.Size(154, 16)
        Me.LblCopy.TabIndex = 28
        Me.LblCopy.Text = "Copyrigth @ Rogerio Cordeiro"
        Me.LblCopy.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnReceber
        '
        Me.BtnReceber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnReceber.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnReceber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReceber.Location = New System.Drawing.Point(328, 594)
        Me.BtnReceber.Name = "BtnReceber"
        Me.BtnReceber.Size = New System.Drawing.Size(125, 34)
        Me.BtnReceber.TabIndex = 3
        Me.BtnReceber.Text = "Receber"
        Me.BtnReceber.UseVisualStyleBackColor = False
        '
        'LblErroCodigo
        '
        Me.LblErroCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblErroCodigo.AutoSize = True
        Me.LblErroCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LblErroCodigo.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblErroCodigo.ForeColor = System.Drawing.Color.Red
        Me.LblErroCodigo.Location = New System.Drawing.Point(274, 93)
        Me.LblErroCodigo.Name = "LblErroCodigo"
        Me.LblErroCodigo.Size = New System.Drawing.Size(460, 23)
        Me.LblErroCodigo.TabIndex = 27
        Me.LblErroCodigo.Text = "Produto não localizado! Se desejar pode cadastrar ou pesquisar!"
        Me.LblErroCodigo.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(766, 512)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Total da Compra"
        '
        'TxtTotalCompra
        '
        Me.TxtTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTotalCompra.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCompra.Location = New System.Drawing.Point(724, 551)
        Me.TxtTotalCompra.Name = "TxtTotalCompra"
        Me.TxtTotalCompra.ReadOnly = True
        Me.TxtTotalCompra.Size = New System.Drawing.Size(272, 44)
        Me.TxtTotalCompra.TabIndex = 24
        Me.TxtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtData
        '
        Me.TxtData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtData.BackColor = System.Drawing.SystemColors.Window
        Me.TxtData.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtData.Location = New System.Drawing.Point(238, 12)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.ReadOnly = True
        Me.TxtData.Size = New System.Drawing.Size(483, 29)
        Me.TxtData.TabIndex = 22
        Me.TxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Cliente"
        '
        'CbxCliente
        '
        Me.CbxCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CbxCliente.FormattingEnabled = True
        Me.CbxCliente.Location = New System.Drawing.Point(238, 75)
        Me.CbxCliente.Name = "CbxCliente"
        Me.CbxCliente.Size = New System.Drawing.Size(483, 28)
        Me.CbxCliente.TabIndex = 2
        '
        'DtvProdutos
        '
        Me.DtvProdutos.AllowUserToAddRows = False
        Me.DtvProdutos.AllowUserToDeleteRows = False
        Me.DtvProdutos.AllowUserToResizeColumns = False
        Me.DtvProdutos.AllowUserToResizeRows = False
        Me.DtvProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DtvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.COD, Me.QTD, Me.DESCRIÇÃO, Me.PREÇOUNIT, Me.PREÇOTOTAL})
        Me.DtvProdutos.Location = New System.Drawing.Point(12, 191)
        Me.DtvProdutos.Name = "DtvProdutos"
        Me.DtvProdutos.ReadOnly = True
        Me.DtvProdutos.RowHeadersVisible = False
        Me.DtvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtvProdutos.Size = New System.Drawing.Size(984, 308)
        Me.DtvProdutos.TabIndex = 5
        '
        'ITEM
        '
        Me.ITEM.FillWeight = 40.0!
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.ReadOnly = True
        '
        'COD
        '
        Me.COD.HeaderText = "COD"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        '
        'QTD
        '
        Me.QTD.FillWeight = 40.0!
        Me.QTD.HeaderText = "QTD"
        Me.QTD.Name = "QTD"
        Me.QTD.ReadOnly = True
        '
        'DESCRIÇÃO
        '
        Me.DESCRIÇÃO.FillWeight = 270.0!
        Me.DESCRIÇÃO.HeaderText = "DESCRIÇÃO"
        Me.DESCRIÇÃO.Name = "DESCRIÇÃO"
        Me.DESCRIÇÃO.ReadOnly = True
        '
        'PREÇOUNIT
        '
        Me.PREÇOUNIT.HeaderText = "PREÇO UNIT."
        Me.PREÇOUNIT.Name = "PREÇOUNIT"
        Me.PREÇOUNIT.ReadOnly = True
        '
        'PREÇOTOTAL
        '
        Me.PREÇOTOTAL.HeaderText = "PREÇO TOTAL"
        Me.PREÇOTOTAL.Name = "PREÇOTOTAL"
        Me.PREÇOTOTAL.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Código do Produto"
        '
        'TxtQtd
        '
        Me.TxtQtd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtQtd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(238, 137)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(44, 29)
        Me.TxtQtd.TabIndex = 1
        Me.TxtQtd.Text = "1"
        Me.TxtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Qtd"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.SysBrecho.My.Resources.Resources.shopping_girl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(189, 157)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'TxtCaixa
        '
        Me.TxtCaixa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCaixa.BackColor = System.Drawing.Color.DodgerBlue
        Me.TxtCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCaixa.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaixa.ForeColor = System.Drawing.Color.White
        Me.TxtCaixa.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TxtCaixa.Location = New System.Drawing.Point(12, 525)
        Me.TxtCaixa.Name = "TxtCaixa"
        Me.TxtCaixa.ReadOnly = True
        Me.TxtCaixa.Size = New System.Drawing.Size(441, 35)
        Me.TxtCaixa.TabIndex = 8
        Me.TxtCaixa.Text = "Caixa Aberto"
        Me.TxtCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.SysBrecho.My.Resources.Resources.Compras___mulher_com_sacolas___bem_colorido_____
        Me.PictureBox1.Location = New System.Drawing.Point(807, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "X"
        '
        'TxtCodProdBusca
        '
        Me.TxtCodProdBusca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCodProdBusca.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProdBusca.Location = New System.Drawing.Point(307, 137)
        Me.TxtCodProdBusca.Name = "TxtCodProdBusca"
        Me.TxtCodProdBusca.Size = New System.Drawing.Size(414, 29)
        Me.TxtCodProdBusca.TabIndex = 0
        '
        'BtnFecharPesq
        '
        Me.BtnFecharPesq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnFecharPesq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFecharPesq.Image = Global.SysBrecho.My.Resources.Resources.Private_80_icon_icons_com_57286
        Me.BtnFecharPesq.Location = New System.Drawing.Point(727, 132)
        Me.BtnFecharPesq.Name = "BtnFecharPesq"
        Me.BtnFecharPesq.Size = New System.Drawing.Size(44, 44)
        Me.BtnFecharPesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnFecharPesq.TabIndex = 31
        Me.BtnFecharPesq.TabStop = False
        Me.ToolTipBtnBusca.SetToolTip(Me.BtnFecharPesq, "Pesquisa na lista de produtos pelo nome. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caso não consiga localizar pelo codigo" &
        ". " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ao clicar no nome do produto já ira inclui-lo na lista.")
        Me.BtnFecharPesq.Visible = False
        '
        'BtnBusca
        '
        Me.BtnBusca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBusca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBusca.Image = CType(resources.GetObject("BtnBusca.Image"), System.Drawing.Image)
        Me.BtnBusca.Location = New System.Drawing.Point(727, 132)
        Me.BtnBusca.Name = "BtnBusca"
        Me.BtnBusca.Size = New System.Drawing.Size(44, 44)
        Me.BtnBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBusca.TabIndex = 15
        Me.BtnBusca.TabStop = False
        Me.ToolTipBtnBusca.SetToolTip(Me.BtnBusca, "Pesquisa na lista de produtos pelo nome. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caso não consiga localizar pelo codigo" &
        ". " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ao clicar no nome do produto já ira inclui-lo na lista.")
        '
        'BtnFechar
        '
        Me.BtnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnFechar.BackColor = System.Drawing.Color.Red
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFechar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.ForeColor = System.Drawing.Color.White
        Me.BtnFechar.Location = New System.Drawing.Point(798, 631)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(125, 34)
        Me.BtnFechar.TabIndex = 4
        Me.BtnFechar.Text = "Sair"
        Me.BtnFechar.UseVisualStyleBackColor = False
        '
        'BtnAbrirFecharCx
        '
        Me.BtnAbrirFecharCx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAbrirFecharCx.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAbrirFecharCx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbrirFecharCx.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrirFecharCx.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAbrirFecharCx.Location = New System.Drawing.Point(12, 594)
        Me.BtnAbrirFecharCx.Name = "BtnAbrirFecharCx"
        Me.BtnAbrirFecharCx.Size = New System.Drawing.Size(125, 34)
        Me.BtnAbrirFecharCx.TabIndex = 28
        Me.BtnAbrirFecharCx.Text = "Abrir Caixa"
        Me.BtnAbrirFecharCx.UseVisualStyleBackColor = False
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
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "Vendas"
        Me.VendasBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'SubVendasBindingSource
        '
        Me.SubVendasBindingSource.DataMember = "Sub Vendas"
        Me.SubVendasBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'Sub_VendasTableAdapter
        '
        Me.Sub_VendasTableAdapter.ClearBeforeFill = True
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
        'ToolTipBtnBusca
        '
        Me.ToolTipBtnBusca.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ToolTipBtnBusca.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipBtnBusca.ToolTipTitle = "Pesquisa por nome do produto"
        '
        'BtnNovaVenda
        '
        Me.BtnNovaVenda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnNovaVenda.BackColor = System.Drawing.SystemColors.Control
        Me.BtnNovaVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovaVenda.Enabled = False
        Me.BtnNovaVenda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovaVenda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNovaVenda.Location = New System.Drawing.Point(163, 594)
        Me.BtnNovaVenda.Name = "BtnNovaVenda"
        Me.BtnNovaVenda.Size = New System.Drawing.Size(125, 34)
        Me.BtnNovaVenda.TabIndex = 29
        Me.BtnNovaVenda.Text = "Nova Venda"
        Me.BtnNovaVenda.UseVisualStyleBackColor = False
        '
        'FrmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnAbrirFecharCx)
        Me.Controls.Add(Me.PanelVendas)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frente de Caixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelVendas.ResumeLayout(False)
        Me.PanelVendas.PerformLayout()
        CType(Me.DtvPesq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFecharPesq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBusca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelVendas As Panel
    Friend WithEvents BtnFechar As Button
    Friend WithEvents TxtCaixa As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtvProdutos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtQtd As TextBox
    Friend WithEvents BtnBusca As PictureBox
    Friend WithEvents TxtCodProdBusca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BancoSysBrechoDataSet As BancoSysBrechoDataSet
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As BancoSysBrechoDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotalCompra As TextBox
    Friend WithEvents TxtData As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbxCliente As ComboBox
    Friend WithEvents VendasBindingSource As BindingSource
    Friend WithEvents VendasTableAdapter As BancoSysBrechoDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents SubVendasBindingSource As BindingSource
    Friend WithEvents Sub_VendasTableAdapter As BancoSysBrechoDataSetTableAdapters.Sub_VendasTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BancoSysBrechoDataSetTableAdapters.ClientesTableAdapter
    Public WithEvents LblErroCodigo As Label
    Friend WithEvents ITEM As DataGridViewTextBoxColumn
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents QTD As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIÇÃO As DataGridViewTextBoxColumn
    Friend WithEvents PREÇOUNIT As DataGridViewTextBoxColumn
    Friend WithEvents PREÇOTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents BtnReceber As Button
    Friend WithEvents BtnAbrirFecharCx As Button
    Public WithEvents LblCopy As Label
    Friend WithEvents DtvPesq As DataGridView
    Friend WithEvents TxtPesqDesc As TextBox
    Friend WithEvents ToolTipBtnBusca As ToolTip
    Friend WithEvents BtnFecharPesq As PictureBox
    Friend WithEvents BtnNovaVenda As Button
    Public WithEvents Label6 As Label
End Class

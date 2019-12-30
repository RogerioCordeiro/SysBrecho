<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProdutos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProdutos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMsgSalva = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtCodProduto = New System.Windows.Forms.MaskedTextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.txtObservacoesProduto = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtCor = New System.Windows.Forms.TextBox()
        Me.cbxTamanho = New System.Windows.Forms.ComboBox()
        Me.txtLucro = New System.Windows.Forms.TextBox()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.TxtValorCusto = New System.Windows.Forms.TextBox()
        Me.TxtValorVenda = New System.Windows.Forms.TextBox()
        Me.TxtMargen = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.cbxFornecedor = New System.Windows.Forms.ComboBox()
        Me.cbxEmpresa = New System.Windows.Forms.ComboBox()
        Me.txtDataSaida = New System.Windows.Forms.MaskedTextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblDataError = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblEmpresas = New System.Windows.Forms.Label()
        Me.btnSalvarProd = New System.Windows.Forms.Button()
        Me.btnEditarProd = New System.Windows.Forms.Button()
        Me.btnNovoProd = New System.Windows.Forms.Button()
        Me.btnCancelarProd = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.PanelBotoes = New System.Windows.Forms.Panel()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BancoSysBrechoDataSet = New SysBrecho.BancoSysBrechoDataSet()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.ProdutosTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.EmpresasTableAdapter()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.FornecedoresTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelBotoes.SuspendLayout()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(692, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'lblMsgSalva
        '
        Me.lblMsgSalva.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMsgSalva.AutoSize = True
        Me.lblMsgSalva.Cursor = System.Windows.Forms.Cursors.No
        Me.lblMsgSalva.ForeColor = System.Drawing.Color.Blue
        Me.lblMsgSalva.Location = New System.Drawing.Point(594, 591)
        Me.lblMsgSalva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMsgSalva.Name = "lblMsgSalva"
        Me.lblMsgSalva.Size = New System.Drawing.Size(186, 16)
        Me.lblMsgSalva.TabIndex = 4
        Me.lblMsgSalva.Text = "Dados Salvos com sucesso!"
        Me.lblMsgSalva.Visible = False
        '
        'Label51
        '
        Me.Label51.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label51.AutoSize = True
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label51.Location = New System.Drawing.Point(26, 114)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(53, 16)
        Me.Label51.TabIndex = 7
        Me.Label51.Text = "Código"
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCodProduto.BackColor = System.Drawing.Color.White
        Me.txtCodProduto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodProduto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProduto.Location = New System.Drawing.Point(157, 109)
        Me.txtCodProduto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(163, 26)
        Me.txtCodProduto.TabIndex = 0
        Me.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.Location = New System.Drawing.Point(351, 112)
        Me.BtnConsultar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(78, 27)
        Me.BtnConsultar.TabIndex = 5
        Me.BtnConsultar.Text = "C&onsultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'cbxCategoria
        '
        Me.cbxCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategoria.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Items.AddRange(New Object() {"Selecione uma Categoria", "Baby (0-2 anos)", "Bermudas e Shorts", "Blusas e Camisetas", "Body e Culote", "Calçados", "Calças", "Calças Jeans", "Camisas", "Cardigans e Suéters", "Casacos e Jaquetas", "Conjunto", "Fantasia", "Jaquetas", "Lingerie", "Macacão e Macaquinho", "Macaquinhos e Macacões", "Malhas e Sueters", "Meias", "Moda Praia", "Moletom", "Partes de Baixo", "Partes de Cima", "Pijamas e Camisolas", "Plus Size", "Polo", "Roupa de Banho", "Roupas Esportivas", "Saias", "Shorts e Bermudas", "Social", "Underwear", "Vestidos"})
        Me.cbxCategoria.Location = New System.Drawing.Point(155, 60)
        Me.cbxCategoria.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(164, 28)
        Me.cbxCategoria.TabIndex = 1
        '
        'txtObservacoesProduto
        '
        Me.txtObservacoesProduto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtObservacoesProduto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservacoesProduto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacoesProduto.Location = New System.Drawing.Point(155, 340)
        Me.txtObservacoesProduto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtObservacoesProduto.Name = "txtObservacoesProduto"
        Me.txtObservacoesProduto.Size = New System.Drawing.Size(517, 26)
        Me.txtObservacoesProduto.TabIndex = 12
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNomeProduto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomeProduto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeProduto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProduto.Location = New System.Drawing.Point(155, 21)
        Me.txtNomeProduto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(517, 26)
        Me.txtNomeProduto.TabIndex = 0
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMarca.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(833, 294)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(164, 26)
        Me.txtMarca.TabIndex = 2
        Me.txtMarca.Visible = False
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtModelo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(833, 333)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(164, 26)
        Me.txtModelo.TabIndex = 3
        Me.txtModelo.Visible = False
        '
        'txtCor
        '
        Me.txtCor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCor.Location = New System.Drawing.Point(833, 372)
        Me.txtCor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(164, 26)
        Me.txtCor.TabIndex = 4
        Me.txtCor.Visible = False
        '
        'cbxTamanho
        '
        Me.cbxTamanho.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxTamanho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbxTamanho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTamanho.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTamanho.FormattingEnabled = True
        Me.cbxTamanho.Items.AddRange(New Object() {"Selecione o Tamanho", "PP", "P", "M", "G", "GG", "XG", "XXG", "1GG", "2", "2xg", "3", "4", "4 - G", "6", "8", "10", "12", "13", "14", "16", "18", "24", "25", "27", "28", "28/30", "29", "31/33", "32", "33", "33/34", "33/36", "34", "34 a 38", "34 ao 39", "34 a 39", "34 a 36", "34 ao 38", "34-36", "34-38", "34-39", "34/35", "34/38", "34/39", "34B", "34C", "35", "35 a 38", "35/36", "36", "36 ao 40", "36-39", "36/37", "36B", "36C", "37", "37 ao 40", "37 a 44", "37 ao 43", "37-39", "37/38", "38", "38 a 43", "38 a 42", "38 ao 42", "38 a 41", "38/39", "38B", "38C", "39", "39 a 43", "39 a 42", "39-43", "39/40", "40", "40 ao 43", "40 ao 42", "40 a 42", "40-42", "40A", "40B", "40C", "40D", "40DD", "40F", "41", "41 a 46", "41/42", "42", "42 a 44", "42/43", "42A", "42B", "42C", "42D", "42DD", "42F", "42G", "43", "43-45", "43/44", "44", "44A", "44B", "44C", "44D", "44DD", "45", "46", "46A", "46B", "46C", "46D", "48", "48A", "48B", "48C", "48D", "50", "50B", "50C", "52", "52b", "52c", "54", "54B", "56", "58", "60", "62", "64", "66", "68", "70", "90", "100", "992", "993", "994", "995", "15662", "15667", "15668", "15669", "A1", "A2", "A3", "E1", "E2", "EE", "EEG", "EG", "EGG", "EM", "EP", "ex", "EXG", "exgg", "g", "G+", "G - 40 ao 43", "G/GG", "G1", "G2", "G3", "G4", "G5", "G6", "GB", "GG2", "GG3", "GGG", "GGGG", "L/XL", "M/G", "P/M", "PP/P", "p´", "RN", "XS", "S", "L", "S/M", "SG", "U", "UN", "XGG", "xg     ", "XL", "XP", "XPP", "XXL", "XXXG", "zgg", "Único"})
        Me.cbxTamanho.Location = New System.Drawing.Point(833, 414)
        Me.cbxTamanho.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxTamanho.Name = "cbxTamanho"
        Me.cbxTamanho.Size = New System.Drawing.Size(164, 28)
        Me.cbxTamanho.TabIndex = 5
        Me.cbxTamanho.Visible = False
        '
        'txtLucro
        '
        Me.txtLucro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLucro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLucro.Location = New System.Drawing.Point(833, 254)
        Me.txtLucro.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.Size = New System.Drawing.Size(164, 23)
        Me.txtLucro.TabIndex = 13
        Me.txtLucro.Text = "0,00"
        Me.txtLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLucro.Visible = False
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDataEntrada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataEntrada.Location = New System.Drawing.Point(833, 135)
        Me.txtDataEntrada.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDataEntrada.Mask = "00/00/0000"
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.Size = New System.Drawing.Size(77, 23)
        Me.txtDataEntrada.TabIndex = 6
        Me.txtDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataEntrada.ValidatingType = GetType(Date)
        Me.txtDataEntrada.Visible = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantidade.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(155, 105)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(164, 26)
        Me.txtQuantidade.TabIndex = 6
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorCusto
        '
        Me.TxtValorCusto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtValorCusto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtValorCusto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorCusto.Location = New System.Drawing.Point(155, 144)
        Me.TxtValorCusto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtValorCusto.Name = "TxtValorCusto"
        Me.TxtValorCusto.Size = New System.Drawing.Size(164, 26)
        Me.TxtValorCusto.TabIndex = 7
        Me.TxtValorCusto.Text = "0,00"
        Me.TxtValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorVenda
        '
        Me.TxtValorVenda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtValorVenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtValorVenda.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorVenda.Location = New System.Drawing.Point(155, 183)
        Me.TxtValorVenda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtValorVenda.Name = "TxtValorVenda"
        Me.TxtValorVenda.Size = New System.Drawing.Size(164, 26)
        Me.TxtValorVenda.TabIndex = 8
        Me.TxtValorVenda.Text = "0,00"
        Me.TxtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMargen
        '
        Me.TxtMargen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtMargen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMargen.Location = New System.Drawing.Point(155, 222)
        Me.TxtMargen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtMargen.Name = "TxtMargen"
        Me.TxtMargen.Size = New System.Drawing.Size(164, 23)
        Me.TxtMargen.TabIndex = 9
        Me.TxtMargen.Text = "0,00"
        Me.TxtMargen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesconto
        '
        Me.txtDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDesconto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesconto.Location = New System.Drawing.Point(833, 194)
        Me.txtDesconto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(164, 23)
        Me.txtDesconto.TabIndex = 12
        Me.txtDesconto.Text = "0,00"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDesconto.Visible = False
        '
        'cbxFornecedor
        '
        Me.cbxFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxFornecedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFornecedor.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFornecedor.FormattingEnabled = True
        Me.cbxFornecedor.Location = New System.Drawing.Point(155, 258)
        Me.cbxFornecedor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxFornecedor.Name = "cbxFornecedor"
        Me.cbxFornecedor.Size = New System.Drawing.Size(353, 28)
        Me.cbxFornecedor.TabIndex = 10
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxEmpresa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEmpresa.FormattingEnabled = True
        Me.cbxEmpresa.Location = New System.Drawing.Point(155, 299)
        Me.cbxEmpresa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Size = New System.Drawing.Size(353, 28)
        Me.cbxEmpresa.TabIndex = 11
        '
        'txtDataSaida
        '
        Me.txtDataSaida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDataSaida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataSaida.Location = New System.Drawing.Point(920, 135)
        Me.txtDataSaida.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDataSaida.Mask = "00/00/0000"
        Me.txtDataSaida.Name = "txtDataSaida"
        Me.txtDataSaida.Size = New System.Drawing.Size(77, 23)
        Me.txtDataSaida.TabIndex = 7
        Me.txtDataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataSaida.ValidatingType = GetType(Date)
        Me.txtDataSaida.Visible = False
        '
        'Label60
        '
        Me.Label60.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label60.AutoSize = True
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.Location = New System.Drawing.Point(25, 66)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(70, 16)
        Me.Label60.TabIndex = 18
        Me.Label60.Text = "Categoria"
        '
        'Label59
        '
        Me.Label59.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label59.AutoSize = True
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.Location = New System.Drawing.Point(703, 338)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(54, 16)
        Me.Label59.TabIndex = 21
        Me.Label59.Text = "Modelo"
        Me.Label59.Visible = False
        '
        'Label58
        '
        Me.Label58.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label58.AutoSize = True
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.Location = New System.Drawing.Point(25, 26)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(71, 16)
        Me.Label58.TabIndex = 19
        Me.Label58.Text = "Descrição"
        '
        'Label57
        '
        Me.Label57.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label57.AutoSize = True
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.Location = New System.Drawing.Point(703, 299)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(47, 16)
        Me.Label57.TabIndex = 20
        Me.Label57.Text = "Marca"
        Me.Label57.Visible = False
        '
        'Label56
        '
        Me.Label56.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label56.AutoSize = True
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.Location = New System.Drawing.Point(26, 185)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(109, 16)
        Me.Label56.TabIndex = 29
        Me.Label56.Text = "Preço de Venda"
        '
        'Label55
        '
        Me.Label55.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label55.AutoSize = True
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Location = New System.Drawing.Point(25, 107)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(95, 16)
        Me.Label55.TabIndex = 27
        Me.Label55.Text = "Estoque Atual"
        '
        'Label54
        '
        Me.Label54.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label54.AutoSize = True
        Me.Label54.Cursor = System.Windows.Forms.Cursors.No
        Me.Label54.Location = New System.Drawing.Point(830, 116)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(92, 16)
        Me.Label54.TabIndex = 25
        Me.Label54.Text = "Data Entrada"
        Me.Label54.Visible = False
        '
        'Label53
        '
        Me.Label53.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label53.AutoSize = True
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.Location = New System.Drawing.Point(703, 418)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(66, 16)
        Me.Label53.TabIndex = 23
        Me.Label53.Text = "Tamanho"
        Me.Label53.Visible = False
        '
        'Label52
        '
        Me.Label52.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label52.AutoSize = True
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.Location = New System.Drawing.Point(703, 377)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(31, 16)
        Me.Label52.TabIndex = 22
        Me.Label52.Text = "Cor"
        Me.Label52.Visible = False
        '
        'Label50
        '
        Me.Label50.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label50.AutoSize = True
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.Location = New System.Drawing.Point(25, 341)
        Me.Label50.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(92, 16)
        Me.Label50.TabIndex = 37
        Me.Label50.Text = "Observações"
        '
        'Label49
        '
        Me.Label49.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label49.AutoSize = True
        Me.Label49.Cursor = System.Windows.Forms.Cursors.No
        Me.Label49.Location = New System.Drawing.Point(829, 235)
        Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(44, 16)
        Me.Label49.TabIndex = 32
        Me.Label49.Text = "Lucro"
        Me.Label49.Visible = False
        '
        'Label48
        '
        Me.Label48.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label48.AutoSize = True
        Me.Label48.Cursor = System.Windows.Forms.Cursors.No
        Me.Label48.Location = New System.Drawing.Point(829, 175)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 16)
        Me.Label48.TabIndex = 31
        Me.Label48.Text = "Desconto"
        Me.Label48.Visible = False
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label47.AutoSize = True
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.Location = New System.Drawing.Point(26, 224)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(59, 16)
        Me.Label47.TabIndex = 30
        Me.Label47.Text = "Margem"
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label46.AutoSize = True
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.Location = New System.Drawing.Point(26, 146)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(106, 16)
        Me.Label46.TabIndex = 28
        Me.Label46.Text = "Preço de Custo"
        '
        'Label61
        '
        Me.Label61.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label61.AutoSize = True
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.Location = New System.Drawing.Point(25, 263)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(82, 16)
        Me.Label61.TabIndex = 34
        Me.Label61.Text = "Fornecedor"
        '
        'Label62
        '
        Me.Label62.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label62.AutoSize = True
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.Location = New System.Drawing.Point(25, 302)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(64, 16)
        Me.Label62.TabIndex = 36
        Me.Label62.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label2.Location = New System.Drawing.Point(918, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Data Saída"
        Me.Label2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.lblDataError)
        Me.Panel1.Controls.Add(Me.lblFornecedor)
        Me.Panel1.Controls.Add(Me.lblEmpresas)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label62)
        Me.Panel1.Controls.Add(Me.Label61)
        Me.Panel1.Controls.Add(Me.Label46)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Controls.Add(Me.Label48)
        Me.Panel1.Controls.Add(Me.Label49)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.Label52)
        Me.Panel1.Controls.Add(Me.Label53)
        Me.Panel1.Controls.Add(Me.Label54)
        Me.Panel1.Controls.Add(Me.Label55)
        Me.Panel1.Controls.Add(Me.Label56)
        Me.Panel1.Controls.Add(Me.Label57)
        Me.Panel1.Controls.Add(Me.Label58)
        Me.Panel1.Controls.Add(Me.Label59)
        Me.Panel1.Controls.Add(Me.Label60)
        Me.Panel1.Controls.Add(Me.txtDataSaida)
        Me.Panel1.Controls.Add(Me.cbxEmpresa)
        Me.Panel1.Controls.Add(Me.cbxFornecedor)
        Me.Panel1.Controls.Add(Me.txtDesconto)
        Me.Panel1.Controls.Add(Me.TxtMargen)
        Me.Panel1.Controls.Add(Me.TxtValorVenda)
        Me.Panel1.Controls.Add(Me.TxtValorCusto)
        Me.Panel1.Controls.Add(Me.txtQuantidade)
        Me.Panel1.Controls.Add(Me.txtDataEntrada)
        Me.Panel1.Controls.Add(Me.txtLucro)
        Me.Panel1.Controls.Add(Me.cbxTamanho)
        Me.Panel1.Controls.Add(Me.txtCor)
        Me.Panel1.Controls.Add(Me.txtModelo)
        Me.Panel1.Controls.Add(Me.txtMarca)
        Me.Panel1.Controls.Add(Me.txtNomeProduto)
        Me.Panel1.Controls.Add(Me.txtObservacoesProduto)
        Me.Panel1.Controls.Add(Me.cbxCategoria)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 133)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1007, 530)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(11, 486)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 32)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Atalhos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F5 - Cadastrar Fornecedor | F6 - Cadastrar Empresas"
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Cursor = System.Windows.Forms.Cursors.No
        Me.lblCategoria.ForeColor = System.Drawing.Color.Red
        Me.lblCategoria.Location = New System.Drawing.Point(324, 66)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(152, 16)
        Me.lblCategoria.TabIndex = 17
        Me.lblCategoria.Text = "Escolha uma categoria"
        Me.lblCategoria.Visible = False
        '
        'lblDataError
        '
        Me.lblDataError.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDataError.AutoSize = True
        Me.lblDataError.Cursor = System.Windows.Forms.Cursors.No
        Me.lblDataError.ForeColor = System.Drawing.Color.Red
        Me.lblDataError.Location = New System.Drawing.Point(830, 98)
        Me.lblDataError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDataError.Name = "lblDataError"
        Me.lblDataError.Size = New System.Drawing.Size(167, 16)
        Me.lblDataError.TabIndex = 24
        Me.lblDataError.Text = "Formato de Data Invalido"
        Me.lblDataError.Visible = False
        '
        'lblFornecedor
        '
        Me.lblFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Cursor = System.Windows.Forms.Cursors.No
        Me.lblFornecedor.ForeColor = System.Drawing.Color.Red
        Me.lblFornecedor.Location = New System.Drawing.Point(519, 270)
        Me.lblFornecedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(154, 16)
        Me.lblFornecedor.TabIndex = 33
        Me.lblFornecedor.Text = "Escolha um fornecedor"
        Me.lblFornecedor.Visible = False
        '
        'lblEmpresas
        '
        Me.lblEmpresas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmpresas.AutoSize = True
        Me.lblEmpresas.Cursor = System.Windows.Forms.Cursors.No
        Me.lblEmpresas.ForeColor = System.Drawing.Color.Red
        Me.lblEmpresas.Location = New System.Drawing.Point(519, 311)
        Me.lblEmpresas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpresas.Name = "lblEmpresas"
        Me.lblEmpresas.Size = New System.Drawing.Size(148, 16)
        Me.lblEmpresas.TabIndex = 35
        Me.lblEmpresas.Text = "Escolha uma empresa"
        Me.lblEmpresas.Visible = False
        '
        'btnSalvarProd
        '
        Me.btnSalvarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarProd.Location = New System.Drawing.Point(298, 14)
        Me.btnSalvarProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSalvarProd.Name = "btnSalvarProd"
        Me.btnSalvarProd.Size = New System.Drawing.Size(78, 27)
        Me.btnSalvarProd.TabIndex = 0
        Me.btnSalvarProd.Text = "&Salvar"
        Me.btnSalvarProd.UseVisualStyleBackColor = True
        '
        'btnEditarProd
        '
        Me.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarProd.Location = New System.Drawing.Point(114, 13)
        Me.btnEditarProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEditarProd.Name = "btnEditarProd"
        Me.btnEditarProd.Size = New System.Drawing.Size(78, 27)
        Me.btnEditarProd.TabIndex = 2
        Me.btnEditarProd.Text = "&Editar"
        Me.btnEditarProd.UseVisualStyleBackColor = True
        '
        'btnNovoProd
        '
        Me.btnNovoProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoProd.Location = New System.Drawing.Point(206, 14)
        Me.btnNovoProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNovoProd.Name = "btnNovoProd"
        Me.btnNovoProd.Size = New System.Drawing.Size(78, 27)
        Me.btnNovoProd.TabIndex = 1
        Me.btnNovoProd.Text = "&Novo"
        Me.btnNovoProd.UseVisualStyleBackColor = True
        '
        'btnCancelarProd
        '
        Me.btnCancelarProd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarProd.Location = New System.Drawing.Point(445, 112)
        Me.btnCancelarProd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancelarProd.Name = "btnCancelarProd"
        Me.btnCancelarProd.Size = New System.Drawing.Size(78, 27)
        Me.btnCancelarProd.TabIndex = 6
        Me.btnCancelarProd.Text = "&Cancelar"
        Me.btnCancelarProd.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Cursor = System.Windows.Forms.Cursors.No
        Me.lblCodigo.ForeColor = System.Drawing.Color.Red
        Me.lblCodigo.Location = New System.Drawing.Point(134, 90)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(208, 16)
        Me.lblCodigo.TabIndex = 6
        Me.lblCodigo.Text = "Digite um codigo para consultar"
        Me.lblCodigo.Visible = False
        '
        'PanelBotoes
        '
        Me.PanelBotoes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelBotoes.Controls.Add(Me.BtnExcluir)
        Me.PanelBotoes.Controls.Add(Me.btnSalvarProd)
        Me.PanelBotoes.Controls.Add(Me.btnNovoProd)
        Me.PanelBotoes.Controls.Add(Me.btnEditarProd)
        Me.PanelBotoes.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelBotoes.Location = New System.Drawing.Point(514, 596)
        Me.PanelBotoes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PanelBotoes.Name = "PanelBotoes"
        Me.PanelBotoes.Size = New System.Drawing.Size(396, 44)
        Me.PanelBotoes.TabIndex = 3
        Me.PanelBotoes.Visible = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.Location = New System.Drawing.Point(22, 13)
        Me.BtnExcluir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(78, 27)
        Me.BtnExcluir.TabIndex = 3
        Me.BtnExcluir.Text = "E&xcluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
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
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.BancoSysBrechoDataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
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
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(397, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(215, 24)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Cadastro de Produtos"
        '
        'FrmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.txtCodProduto)
        Me.Controls.Add(Me.lblMsgSalva)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.btnCancelarProd)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.PanelBotoes)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "FrmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelBotoes.ResumeLayout(False)
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoSysBrechoDataSet As BancoSysBrechoDataSet
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosTableAdapter As BancoSysBrechoDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMsgSalva As Label
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As BancoSysBrechoDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents Label51 As Label
    Friend WithEvents txtCodProduto As MaskedTextBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents txtObservacoesProduto As TextBox
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtCor As TextBox
    Friend WithEvents cbxTamanho As ComboBox
    Friend WithEvents txtLucro As TextBox
    Friend WithEvents txtDataEntrada As MaskedTextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents TxtValorCusto As TextBox
    Friend WithEvents TxtValorVenda As TextBox
    Friend WithEvents TxtMargen As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents cbxFornecedor As ComboBox
    Friend WithEvents cbxEmpresa As ComboBox
    Friend WithEvents txtDataSaida As MaskedTextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalvarProd As Button
    Friend WithEvents btnEditarProd As Button
    Friend WithEvents btnNovoProd As Button
    Friend WithEvents btnCancelarProd As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblEmpresas As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents PanelBotoes As Panel
    Friend WithEvents lblDataError As Label
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents FornecedoresTableAdapter As BancoSysBrechoDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadastros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastros))
        Me.lblMsgSalva = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxtNomeRazao = New System.Windows.Forms.MaskedTextBox()
        Me.cbxTpDocumentos = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.mtxtNumDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.BancoSysBrechoDataSet = New SysBrecho.BancoSysBrechoDataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.EmpresasTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtxtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxWhats = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtxtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtxtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mtxtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtxtCidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtxtBairro = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtxtComplemento = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtNumEnd = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxtEndereço = New System.Windows.Forms.MaskedTextBox()
        Me.cbxEstadoUF = New System.Windows.Forms.ComboBox()
        Me.LblErroNumero = New System.Windows.Forms.Label()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.LblTituloTela = New System.Windows.Forms.Label()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.ClientesTableAdapter()
        Me.EmpresasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedoresTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.FornecedoresTableAdapter()
        Me.imagemCadastro = New System.Windows.Forms.PictureBox()
        Me.imagemCadastro2 = New System.Windows.Forms.PictureBox()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagemCadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagemCadastro2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMsgSalva
        '
        Me.lblMsgSalva.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMsgSalva.AutoSize = True
        Me.lblMsgSalva.ForeColor = System.Drawing.Color.Blue
        Me.lblMsgSalva.Location = New System.Drawing.Point(693, 539)
        Me.lblMsgSalva.Name = "lblMsgSalva"
        Me.lblMsgSalva.Size = New System.Drawing.Size(207, 18)
        Me.lblMsgSalva.TabIndex = 7
        Me.lblMsgSalva.Text = "Dados Salvos com sucesso!"
        Me.lblMsgSalva.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(690, 560)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'lblNome
        '
        Me.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(74, 229)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(50, 18)
        Me.lblNome.TabIndex = 48
        Me.lblNome.Text = "Nome"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(74, 189)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(61, 18)
        Me.lblTipoDoc.TabIndex = 46
        Me.lblTipoDoc.Text = "Nº Doc."
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tipo Doc."
        '
        'mtxtNomeRazao
        '
        Me.mtxtNomeRazao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mtxtNomeRazao.Location = New System.Drawing.Point(187, 221)
        Me.mtxtNomeRazao.Name = "mtxtNomeRazao"
        Me.mtxtNomeRazao.Size = New System.Drawing.Size(409, 26)
        Me.mtxtNomeRazao.TabIndex = 2
        '
        'cbxTpDocumentos
        '
        Me.cbxTpDocumentos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxTpDocumentos.FormattingEnabled = True
        Me.cbxTpDocumentos.Items.AddRange(New Object() {"CPF", "CNPJ"})
        Me.cbxTpDocumentos.Location = New System.Drawing.Point(187, 141)
        Me.cbxTpDocumentos.Name = "cbxTpDocumentos"
        Me.cbxTpDocumentos.Size = New System.Drawing.Size(92, 26)
        Me.cbxTpDocumentos.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageKey = "(nenhum/a)"
        Me.btnCancel.Location = New System.Drawing.Point(74, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'mtxtNumDocumento
        '
        Me.mtxtNumDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mtxtNumDocumento.Location = New System.Drawing.Point(187, 181)
        Me.mtxtNumDocumento.Name = "mtxtNumDocumento"
        Me.mtxtNumDocumento.Size = New System.Drawing.Size(184, 26)
        Me.mtxtNumDocumento.TabIndex = 0
        Me.mtxtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.ImageKey = "(nenhum/a)"
        Me.btnOK.Location = New System.Drawing.Point(800, 560)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 30)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Salvar"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Location = New System.Drawing.Point(239, 261)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 30)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'BancoSysBrechoDataSet
        '
        Me.BancoSysBrechoDataSet.DataSetName = "BancoSysBrechoDataSet"
        Me.BancoSysBrechoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.mtxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbxWhats)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.mtxtCelular)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mtxtTelefone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.mtxtCEP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mtxtCidade)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mtxtBairro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mtxtComplemento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mtxtNumEnd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mtxtEndereço)
        Me.GroupBox1.Controls.Add(Me.cbxEstadoUF)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 353)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 18)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "E-Mail"
        '
        'mtxtEmail
        '
        Me.mtxtEmail.Location = New System.Drawing.Point(175, 240)
        Me.mtxtEmail.Name = "mtxtEmail"
        Me.mtxtEmail.Size = New System.Drawing.Size(397, 26)
        Me.mtxtEmail.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 18)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "WhatsApp"
        '
        'cbxWhats
        '
        Me.cbxWhats.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxWhats.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbxWhats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxWhats.FormattingEnabled = True
        Me.cbxWhats.Items.AddRange(New Object() {"SIM", "NÃO"})
        Me.cbxWhats.Location = New System.Drawing.Point(175, 200)
        Me.cbxWhats.Name = "cbxWhats"
        Me.cbxWhats.Size = New System.Drawing.Size(92, 27)
        Me.cbxWhats.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Celular"
        '
        'mtxtCelular
        '
        Me.mtxtCelular.Location = New System.Drawing.Point(175, 160)
        Me.mtxtCelular.Mask = "(00) 90000-0000"
        Me.mtxtCelular.Name = "mtxtCelular"
        Me.mtxtCelular.Size = New System.Drawing.Size(128, 26)
        Me.mtxtCelular.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Telefone"
        '
        'mtxtTelefone
        '
        Me.mtxtTelefone.Location = New System.Drawing.Point(175, 120)
        Me.mtxtTelefone.Mask = "(00) 90000-0000"
        Me.mtxtTelefone.Name = "mtxtTelefone"
        Me.mtxtTelefone.Size = New System.Drawing.Size(128, 26)
        Me.mtxtTelefone.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(850, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 18)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "CEP"
        Me.Label8.Visible = False
        '
        'mtxtCEP
        '
        Me.mtxtCEP.Location = New System.Drawing.Point(850, 70)
        Me.mtxtCEP.Mask = "99999-999"
        Me.mtxtCEP.Name = "mtxtCEP"
        Me.mtxtCEP.Size = New System.Drawing.Size(106, 26)
        Me.mtxtCEP.TabIndex = 6
        Me.mtxtCEP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(801, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Estado / UF"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(808, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Cidade"
        Me.Label6.Visible = False
        '
        'mtxtCidade
        '
        Me.mtxtCidade.Location = New System.Drawing.Point(799, 110)
        Me.mtxtCidade.Name = "mtxtCidade"
        Me.mtxtCidade.Size = New System.Drawing.Size(185, 26)
        Me.mtxtCidade.TabIndex = 4
        Me.mtxtCidade.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(802, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Bairro"
        Me.Label5.Visible = False
        '
        'mtxtBairro
        '
        Me.mtxtBairro.Location = New System.Drawing.Point(802, 209)
        Me.mtxtBairro.Name = "mtxtBairro"
        Me.mtxtBairro.Size = New System.Drawing.Size(182, 26)
        Me.mtxtBairro.TabIndex = 3
        Me.mtxtBairro.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(803, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Complemento"
        Me.Label4.Visible = False
        '
        'mtxtComplemento
        '
        Me.mtxtComplemento.Location = New System.Drawing.Point(803, 21)
        Me.mtxtComplemento.Name = "mtxtComplemento"
        Me.mtxtComplemento.Size = New System.Drawing.Size(153, 26)
        Me.mtxtComplemento.TabIndex = 2
        Me.mtxtComplemento.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Número"
        '
        'mtxtNumEnd
        '
        Me.mtxtNumEnd.Location = New System.Drawing.Point(175, 80)
        Me.mtxtNumEnd.Name = "mtxtNumEnd"
        Me.mtxtNumEnd.Size = New System.Drawing.Size(128, 26)
        Me.mtxtNumEnd.TabIndex = 1
        Me.mtxtNumEnd.Text = "0"
        Me.mtxtNumEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "End.( Rua, Av.)"
        '
        'mtxtEndereço
        '
        Me.mtxtEndereço.Location = New System.Drawing.Point(175, 40)
        Me.mtxtEndereço.Name = "mtxtEndereço"
        Me.mtxtEndereço.Size = New System.Drawing.Size(409, 26)
        Me.mtxtEndereço.TabIndex = 0
        '
        'cbxEstadoUF
        '
        Me.cbxEstadoUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxEstadoUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxEstadoUF.FormattingEnabled = True
        Me.cbxEstadoUF.Items.AddRange(New Object() {"Acre / AC", "Alagoas / AL ", "Amapá / AP", "Amazonas / AM", "Bahia / BA", "Ceará / CE", "Distrito Federal / DF", "Espírito Santo / ES", "Goiás / GO", "Maranhão / MA", "Mato Grosso / MT", "Mato Grosso do Sul / MS", "Minas Gerais / MG", "Pará / PA", "Paraíba / PB", "Paraná / PR ", "Pernambuco / PE ", "Piauí / PI ", "Rio de Janeiro / RJ ", "Rio Grande do Norte / RN", "Rio Grande do Sul / RS ", "Rondônia / RO ", "Roraima / RR ", "Santa Catarina / SC ", "São Paulo / SP ", "Sergipe / SE ", "Tocantins / TO"})
        Me.cbxEstadoUF.Location = New System.Drawing.Point(802, 160)
        Me.cbxEstadoUF.Name = "cbxEstadoUF"
        Me.cbxEstadoUF.Size = New System.Drawing.Size(167, 26)
        Me.cbxEstadoUF.TabIndex = 5
        Me.cbxEstadoUF.Visible = False
        '
        'LblErroNumero
        '
        Me.LblErroNumero.AutoSize = True
        Me.LblErroNumero.ForeColor = System.Drawing.Color.Red
        Me.LblErroNumero.Location = New System.Drawing.Point(815, 130)
        Me.LblErroNumero.Name = "LblErroNumero"
        Me.LblErroNumero.Size = New System.Drawing.Size(191, 36)
        Me.LblErroNumero.TabIndex = 100
        Me.LblErroNumero.Text = "Preencha um numero! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Caso não tenha numero."
        Me.LblErroNumero.Visible = False
        '
        'BtnNovo
        '
        Me.BtnNovo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNovo.ImageKey = "(nenhum/a)"
        Me.BtnNovo.Location = New System.Drawing.Point(800, 560)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(100, 30)
        Me.BtnNovo.TabIndex = 10
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        Me.BtnNovo.Visible = False
        '
        'LblTituloTela
        '
        Me.LblTituloTela.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTituloTela.AutoSize = True
        Me.LblTituloTela.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloTela.Location = New System.Drawing.Point(392, 15)
        Me.LblTituloTela.Name = "LblTituloTela"
        Me.LblTituloTela.Size = New System.Drawing.Size(225, 24)
        Me.LblTituloTela.TabIndex = 79
        Me.LblTituloTela.Text = "Cadastro de Empresas"
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.Location = New System.Drawing.Point(580, 560)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(100, 30)
        Me.BtnExcluir.TabIndex = 101
        Me.BtnExcluir.Text = "E&xcluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
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
        'EmpresasBindingSource1
        '
        Me.EmpresasBindingSource1.DataMember = "Empresas"
        Me.EmpresasBindingSource1.DataSource = Me.BancoSysBrechoDataSet
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
        'imagemCadastro
        '
        Me.imagemCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imagemCadastro.Image = CType(resources.GetObject("imagemCadastro.Image"), System.Drawing.Image)
        Me.imagemCadastro.Location = New System.Drawing.Point(806, 15)
        Me.imagemCadastro.Name = "imagemCadastro"
        Me.imagemCadastro.Size = New System.Drawing.Size(100, 100)
        Me.imagemCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemCadastro.TabIndex = 74
        Me.imagemCadastro.TabStop = False
        '
        'imagemCadastro2
        '
        Me.imagemCadastro2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imagemCadastro2.Image = CType(resources.GetObject("imagemCadastro2.Image"), System.Drawing.Image)
        Me.imagemCadastro2.Location = New System.Drawing.Point(690, 15)
        Me.imagemCadastro2.Name = "imagemCadastro2"
        Me.imagemCadastro2.Size = New System.Drawing.Size(100, 100)
        Me.imagemCadastro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemCadastro2.TabIndex = 73
        Me.imagemCadastro2.TabStop = False
        '
        'FrmCadastros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.LblErroNumero)
        Me.Controls.Add(Me.LblTituloTela)
        Me.Controls.Add(Me.imagemCadastro)
        Me.Controls.Add(Me.imagemCadastro2)
        Me.Controls.Add(Me.lblMsgSalva)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxtNomeRazao)
        Me.Controls.Add(Me.cbxTpDocumentos)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.mtxtNumDocumento)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCadastros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empresas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagemCadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagemCadastro2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMsgSalva As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblNome As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxtNomeRazao As MaskedTextBox
    Friend WithEvents cbxTpDocumentos As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents mtxtNumDocumento As MaskedTextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents BancoSysBrechoDataSet As BancoSysBrechoDataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As BancoSysBrechoDataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblErroNumero As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents mtxtEmail As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbxWhats As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents mtxtCelular As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mtxtTelefone As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mtxtCEP As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mtxtCidade As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mtxtBairro As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mtxtComplemento As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mtxtNumEnd As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxtEndereço As MaskedTextBox
    Friend WithEvents cbxEstadoUF As ComboBox
    Friend WithEvents BtnNovo As Button
    Friend WithEvents LblTituloTela As Label
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BancoSysBrechoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents EmpresasBindingSource1 As BindingSource
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents FornecedoresTableAdapter As BancoSysBrechoDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents imagemCadastro As PictureBox
    Friend WithEvents imagemCadastro2 As PictureBox
End Class

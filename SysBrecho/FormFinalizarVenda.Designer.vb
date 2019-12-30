<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinalizarVenda
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbFormaPgto = New System.Windows.Forms.ComboBox()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.TxtAReceber = New System.Windows.Forms.TextBox()
        Me.TxtTroco = New System.Windows.Forms.TextBox()
        Me.BtnCancela = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.BancoSysBrechoDataSet = New SysBrecho.BancoSysBrechoDataSet()
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.VendasTableAdapter()
        Me.SubVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_VendasTableAdapter = New SysBrecho.BancoSysBrechoDataSetTableAdapters.Sub_VendasTableAdapter()
        Me.VendasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor a Receber"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor Recebido"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Forma de Pagamento"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Troco"
        '
        'CbFormaPgto
        '
        Me.CbFormaPgto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CbFormaPgto.BackColor = System.Drawing.SystemColors.Window
        Me.CbFormaPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFormaPgto.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFormaPgto.FormattingEnabled = True
        Me.CbFormaPgto.Items.AddRange(New Object() {"Dinheiro", "Débito", "Credito", "Parcelado"})
        Me.CbFormaPgto.Location = New System.Drawing.Point(52, 266)
        Me.CbFormaPgto.Name = "CbFormaPgto"
        Me.CbFormaPgto.Size = New System.Drawing.Size(298, 40)
        Me.CbFormaPgto.TabIndex = 1
        '
        'TxtPago
        '
        Me.TxtPago.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPago.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPago.Location = New System.Drawing.Point(52, 190)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.Size = New System.Drawing.Size(298, 38)
        Me.TxtPago.TabIndex = 0
        Me.TxtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtAReceber
        '
        Me.TxtAReceber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAReceber.BackColor = System.Drawing.SystemColors.Window
        Me.TxtAReceber.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAReceber.Location = New System.Drawing.Point(52, 114)
        Me.TxtAReceber.Name = "TxtAReceber"
        Me.TxtAReceber.ReadOnly = True
        Me.TxtAReceber.Size = New System.Drawing.Size(298, 38)
        Me.TxtAReceber.TabIndex = 4
        Me.TxtAReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTroco
        '
        Me.TxtTroco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTroco.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTroco.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTroco.Location = New System.Drawing.Point(52, 344)
        Me.TxtTroco.Name = "TxtTroco"
        Me.TxtTroco.ReadOnly = True
        Me.TxtTroco.Size = New System.Drawing.Size(298, 38)
        Me.TxtTroco.TabIndex = 5
        Me.TxtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnCancela
        '
        Me.BtnCancela.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancela.Location = New System.Drawing.Point(52, 402)
        Me.BtnCancela.Name = "BtnCancela"
        Me.BtnCancela.Size = New System.Drawing.Size(90, 40)
        Me.BtnCancela.TabIndex = 3
        Me.BtnCancela.Text = "Cancela"
        Me.BtnCancela.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.SysBrecho.My.Resources.Resources.icons8_moedas_100
        Me.PictureBox2.Location = New System.Drawing.Point(286, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.SysBrecho.My.Resources.Resources.icons8_maquina_de_cartão_641
        Me.PictureBox1.Location = New System.Drawing.Point(52, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFinalizar.ImageKey = "(nenhum/a)"
        Me.BtnFinalizar.Location = New System.Drawing.Point(260, 402)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(90, 40)
        Me.BtnFinalizar.TabIndex = 2
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'BancoSysBrechoDataSet
        '
        Me.BancoSysBrechoDataSet.DataSetName = "BancoSysBrechoDataSet"
        Me.BancoSysBrechoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'VendasBindingSource1
        '
        Me.VendasBindingSource1.DataMember = "Vendas"
        Me.VendasBindingSource1.DataSource = Me.BancoSysBrechoDataSet
        '
        'FormFinalizarVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.BtnCancela)
        Me.Controls.Add(Me.TxtTroco)
        Me.Controls.Add(Me.TxtAReceber)
        Me.Controls.Add(Me.TxtPago)
        Me.Controls.Add(Me.CbFormaPgto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(420, 530)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 530)
        Me.Name = "FormFinalizarVenda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalizando a Venda"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoSysBrechoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbFormaPgto As ComboBox
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents TxtAReceber As TextBox
    Friend WithEvents TxtTroco As TextBox
    Friend WithEvents BtnCancela As Button
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents BancoSysBrechoDataSet As BancoSysBrechoDataSet
    Friend WithEvents VendasBindingSource As BindingSource
    Friend WithEvents VendasTableAdapter As BancoSysBrechoDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents SubVendasBindingSource As BindingSource
    Friend WithEvents Sub_VendasTableAdapter As BancoSysBrechoDataSetTableAdapters.Sub_VendasTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents VendasBindingSource1 As BindingSource
End Class

Module ModuloCadastros
    Public CadastroSelecionado As String

    Public Function MainFroms(TextoTitulo As String)
        Try
            FrmCadastros.LblTituloTela.Text = TextoTitulo
            FrmCadastros.mtxtNomeRazao.Enabled = False
            FrmCadastros.btnOK.Visible = False
            FrmCadastros.btnEditar.Visible = False
            FrmCadastros.BtnExcluir.Visible = False
            FrmCadastros.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox("Erro informe a menssagem abaixo." & vbCrLf & ex.Message)
        End Try
    End Function

    Private Sub PreencheDados(ByRef QualCadastro As String)
        Dim ConsultaTabela
        Select Case QualCadastro
            Case Is = "Fornecedores"

                ConsultaTabela = From empresa In FrmCadastros.BancoSysBrechoDataSet.Fornecedores
                                 Where (empresa.Numero_Documento = FrmCadastros.mtxtNumDocumento.Text)
                                 Select empresa.Nome, empresa.Bairro, empresa.Celular, empresa.CEP, empresa.Cidade, empresa.Complemento,
                                            empresa.Endereco, empresa.Numero, empresa.Telefone, empresa.WhatsApp, empresa._E_mail, empresa.UF

            Case Is = "Clientes"
                ConsultaTabela = From empresa In FrmCadastros.BancoSysBrechoDataSet.Clientes
                                 Where (empresa.Numero_Documento = FrmCadastros.mtxtNumDocumento.Text)
                                 Select empresa.Nome, empresa.Bairro, empresa.Celular, empresa.CEP, empresa.Cidade, empresa.Complemento,
                                        empresa.Endereco, empresa.Numero, empresa.Telefone, empresa.WhatsApp, empresa._E_mail, empresa.UF

            Case Is = "Empresas"
                ConsultaTabela = From empresa In FrmCadastros.BancoSysBrechoDataSet.Empresas
                                 Where (empresa.Numero_Documento = FrmCadastros.mtxtNumDocumento.Text)
                                 Select empresa.Nome, empresa.Bairro, empresa.Celular, empresa.CEP, empresa.Cidade, empresa.Complemento,
                                        empresa.Endereco, empresa.Numero, empresa.Telefone, empresa.WhatsApp, empresa._E_mail, empresa.UF

        End Select

        For Each nome In ConsultaTabela
            With nome
                FrmCadastros.mtxtNomeRazao.Text = .Nome
                FrmCadastros.mtxtEndereço.Text = .Endereco
                FrmCadastros.mtxtNumEnd.Text = CInt(.Numero)
                FrmCadastros.mtxtComplemento.Text = .Complemento
                FrmCadastros.mtxtBairro.Text = .Bairro
                FrmCadastros.mtxtCidade.Text = .Cidade
                FrmCadastros.cbxEstadoUF.Text = .UF
                FrmCadastros.mtxtCEP.Text = .CEP
                FrmCadastros.mtxtCelular.Text = .Celular
                FrmCadastros.mtxtTelefone.Text = .Telefone
                FrmCadastros.cbxWhats.Text = .WhatsApp
                FrmCadastros.mtxtEmail.Text = ._E_mail
            End With
        Next

        ConsultaTabela = Nothing

    End Sub

    Public Sub ConsultarCadastro(ByRef QualCadastro As String)

        Dim existe As String
        Try

            Select Case QualCadastro
                Case Is = "Fornecedores"
                    existe = FrmCadastros.FornecedoresTableAdapter.SelectExiste(FrmCadastros.mtxtNumDocumento.Text)
                Case Is = "Clientes"
                    existe = FrmCadastros.ClientesTableAdapter.SelectExiste(FrmCadastros.mtxtNumDocumento.Text)
                Case Is = "Empresas"
                    existe = FrmCadastros.EmpresasTableAdapter.SelectExiste(FrmCadastros.mtxtNumDocumento.Text)
            End Select

            If existe = 1 Then
                FrmCadastros.GroupBox1.Visible = True
                FrmCadastros.cbxTpDocumentos.Enabled = False
                FrmCadastros.mtxtNumDocumento.Enabled = False
                FrmCadastros.mtxtNomeRazao.Enabled = False
                FrmCadastros.btnConsultar.Visible = False
                FrmCadastros.GroupBox1.Enabled = False
                FrmCadastros.lblMsgSalva.Visible = False
                FrmCadastros.btnOK.Visible = False
                FrmCadastros.BtnNovo.Visible = True
                FrmCadastros.BtnExcluir.Visible = True
                FrmCadastros.btnEditar.Visible = True
                Dim PosicaoX = FrmCadastros.BtnExcluir.Location.X
                FrmCadastros.btnCancel.Location = New Point(PosicaoX - 110, 560)
                PreencheDados(QualCadastro)
                FrmCadastros.GroupBox1.Enabled = False

            ElseIf existe = 0 Then 'And (cbxTpDocumentos.Text = "CPF" And Len(ndocument) = 11) Or (cbxTpDocumentos.Text = "CNPJ" And Len(ndocument) = 14) Then
                Dim resposta As MsgBoxResult
                If (mdiTelaPrinciapal.Cadastrar) Then
                    resposta = vbYes
                Else
                    resposta = MsgBox("Cadastro não encontrado deseja cadastrar?", vbYesNo, "Cadastro Empresas")
                End If
                If resposta = vbYes Then
                    FrmCadastros.mtxtNumDocumento.Enabled = False
                    FrmCadastros.mtxtNomeRazao.Enabled = True
                    FrmCadastros.btnConsultar.Visible = False
                    FrmCadastros.btnOK.Visible = True
                    FrmCadastros.btnEditar.Visible = False
                    FrmCadastros.cbxTpDocumentos.Enabled = False
                    FrmCadastros.GroupBox1.Visible = True
                    'Call EditarInformacoes(QualCadastro)
                    FrmCadastros.novoCadastro = True
                    FrmCadastros.mtxtNomeRazao.Select()
                    Dim PosicaoX = FrmCadastros.BtnExcluir.Location.X
                    FrmCadastros.btnCancel.Location = New Point(PosicaoX - 110, 560)
                End If
            Else
                MsgBox("Favor digitar um documento valido!", vbCritical, "Erro de Preenchimento")
            End If
        Catch ex As Exception
            MsgBox("Erro ao realizar a consulta. Informe a menssagem abaixo" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Sistema de controle")
        End Try
    End Sub

    Private Sub InsertUpdate(OqueFazer As String, QualCadastro As String, numero As Integer)
        Try
            If OqueFazer = "Update" Then
                Select Case QualCadastro
                    Case Is = "Empresas"
                        FrmCadastros.Validate()
                        FrmCadastros.EmpresasBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.EmpresasTableAdapter.UpdateQuery(StrConv(FrmCadastros.mtxtNomeRazao.Text, vbProperCase), StrConv(FrmCadastros.mtxtEndereço.Text, vbProperCase), numero, StrConv(FrmCadastros.mtxtComplemento.Text, vbProperCase),
                                                                      StrConv(FrmCadastros.mtxtBairro.Text, vbProperCase), StrConv(FrmCadastros.mtxtCidade.Text, vbProperCase), FrmCadastros.cbxEstadoUF.Text, FrmCadastros.mtxtCEP.Text,
                                                                      FrmCadastros.mtxtTelefone.Text, FrmCadastros.mtxtCelular.Text, FrmCadastros.cbxWhats.Text, FrmCadastros.mtxtEmail.Text, FrmCadastros.mtxtNumDocumento.Text)
                    Case Is = "Fornecedores"
                        FrmCadastros.Validate()
                        FrmCadastros.FornecedoresBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.FornecedoresTableAdapter.UpdateFornecedor(StrConv(FrmCadastros.mtxtNomeRazao.Text, vbProperCase), StrConv(FrmCadastros.mtxtEndereço.Text, vbProperCase), numero, StrConv(FrmCadastros.mtxtComplemento.Text, vbProperCase),
                                                                      StrConv(FrmCadastros.mtxtBairro.Text, vbProperCase), StrConv(FrmCadastros.mtxtCidade.Text, vbProperCase), FrmCadastros.cbxEstadoUF.Text, FrmCadastros.mtxtCEP.Text,
                                                                      FrmCadastros.mtxtTelefone.Text, FrmCadastros.mtxtCelular.Text, FrmCadastros.cbxWhats.Text, FrmCadastros.mtxtEmail.Text, FrmCadastros.mtxtNumDocumento.Text)
                    Case Is = "Clientes"
                        FrmCadastros.Validate()
                        FrmCadastros.ClientesBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.ClientesTableAdapter.UpdateQuery(StrConv(FrmCadastros.mtxtNomeRazao.Text, vbProperCase), StrConv(FrmCadastros.mtxtEndereço.Text, vbProperCase), numero, StrConv(FrmCadastros.mtxtComplemento.Text, vbProperCase),
                                                                      StrConv(FrmCadastros.mtxtBairro.Text, vbProperCase), StrConv(FrmCadastros.mtxtCidade.Text, vbProperCase), FrmCadastros.cbxEstadoUF.Text, FrmCadastros.mtxtCEP.Text,
                                                                      FrmCadastros.mtxtTelefone.Text, FrmCadastros.mtxtCelular.Text, FrmCadastros.cbxWhats.Text, FrmCadastros.mtxtEmail.Text, FrmCadastros.mtxtNumDocumento.Text)

                End Select

            ElseIf OqueFazer = "Insert" Then
                Select Case QualCadastro
                    Case Is = "Empresas"
                        FrmCadastros.Validate()
                        FrmCadastros.EmpresasBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.EmpresasTableAdapter.InsertNovoRegistro(FrmCadastros.cbxTpDocumentos.Text, FrmCadastros.mtxtNumDocumento.Text, StrConv(FrmCadastros.mtxtNomeRazao.Text, vbProperCase), StrConv(FrmCadastros.mtxtEndereço.Text, vbProperCase),
                                                                             numero, StrConv(FrmCadastros.mtxtComplemento.Text, vbProperCase), StrConv(FrmCadastros.mtxtBairro.Text, vbProperCase),
                                                                     StrConv(FrmCadastros.mtxtCidade.Text, vbProperCase), FrmCadastros.cbxEstadoUF.Text, FrmCadastros.mtxtCEP.Text, FrmCadastros.mtxtTelefone.Text, FrmCadastros.mtxtCelular.Text, FrmCadastros.cbxWhats.Text,
                                                                     FrmCadastros.mtxtEmail.Text)
                    Case Is = "Fornecedores"
                        FrmCadastros.Validate()
                        FrmCadastros.FornecedoresBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.FornecedoresTableAdapter.InsertNovoRegistro(FrmCadastros.cbxTpDocumentos.Text, FrmCadastros.mtxtNumDocumento.Text, StrConv(FrmCadastros.mtxtNomeRazao.Text, vbProperCase), StrConv(FrmCadastros.mtxtEndereço.Text, vbProperCase),
                                                                             numero, StrConv(FrmCadastros.mtxtComplemento.Text, vbProperCase), StrConv(FrmCadastros.mtxtBairro.Text, vbProperCase),
                                                                     StrConv(FrmCadastros.mtxtCidade.Text, vbProperCase), FrmCadastros.cbxEstadoUF.Text, FrmCadastros.mtxtCEP.Text, FrmCadastros.mtxtTelefone.Text, FrmCadastros.mtxtCelular.Text, FrmCadastros.cbxWhats.Text,
                                                                     FrmCadastros.mtxtEmail.Text)
                    Case Is = "Clientes"
                        FrmCadastros.Validate()
                        FrmCadastros.ClientesBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.ClientesTableAdapter.InsertNovoRegistro(FrmCadastros.cbxTpDocumentos.Text, FrmCadastros.mtxtNumDocumento.Text, StrConv(FrmCadastros.mtxtNomeRazao.Text, vbProperCase), StrConv(FrmCadastros.mtxtEndereço.Text, vbProperCase),
                                                                             numero, StrConv(FrmCadastros.mtxtComplemento.Text, vbProperCase), StrConv(FrmCadastros.mtxtBairro.Text, vbProperCase),
                                                                     StrConv(FrmCadastros.mtxtCidade.Text, vbProperCase), FrmCadastros.cbxEstadoUF.Text, FrmCadastros.mtxtCEP.Text, FrmCadastros.mtxtTelefone.Text, FrmCadastros.mtxtCelular.Text, FrmCadastros.cbxWhats.Text,
                                                                     FrmCadastros.mtxtEmail.Text)
                End Select
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try
    End Sub


    Public Sub SalvaInformacoes(QualCadastro As String, NovoCadastro As Boolean)
        Try
            Dim numero = Validacoes.VerificaInteriro(FrmCadastros.mtxtNumEnd, FrmCadastros.LblErroNumero)
            If IsNumeric(FrmCadastros.mtxtNumEnd.Text) Then
                FrmCadastros.LblErroNumero.Visible = False
            Else
                FrmCadastros.mtxtNumEnd.Text = 0
            End If

            If NovoCadastro Then
                InsertUpdate("Insert", QualCadastro, numero)
                NovoCadastro = False
                FrmCadastros.cbxTpDocumentos.Enabled = False
                FrmCadastros.mtxtNumDocumento.Enabled = False
                FrmCadastros.mtxtNomeRazao.Enabled = False
                FrmCadastros.GroupBox1.Enabled = False
                FrmCadastros.lblMsgSalva.Visible = True
                FrmCadastros.btnEditar.Visible = True
                FrmCadastros.btnOK.Visible = False
                FrmCadastros.BtnNovo.Visible = True
                FrmCadastros.BtnExcluir.Visible = True
            Else
                InsertUpdate("Update", QualCadastro, numero)
                FrmCadastros.cbxTpDocumentos.Enabled = False
                FrmCadastros.mtxtNumDocumento.Enabled = False
                FrmCadastros.mtxtNomeRazao.Enabled = False
                FrmCadastros.GroupBox1.Enabled = False
                FrmCadastros.lblMsgSalva.Visible = True
                FrmCadastros.btnOK.Visible = False
                FrmCadastros.BtnNovo.Visible = True
                FrmCadastros.BtnExcluir.Visible = True
                FrmCadastros.btnEditar.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao salvar contate o desenvolvedor e informe o codigo abaixo." & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub EditarInformacoes(QualCadastro As String)

        Try
            Select Case QualCadastro
                Case Is = "Empresas"
                    FrmCadastros.Validate()
                    FrmCadastros.EmpresasBindingSource.EndEdit()
                    FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()

                Case Is = "Fornecedores"
                    FrmCadastros.Validate()
                    FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                    FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()

                Case Is = "Clientes"
                    FrmCadastros.Validate()
                    FrmCadastros.ClientesBindingSource.EndEdit()
                    FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
            End Select

            FrmCadastros.lblMsgSalva.Visible = False
            FrmCadastros.cbxTpDocumentos.Enabled = False
            FrmCadastros.mtxtNumDocumento.Enabled = False
            FrmCadastros.mtxtNomeRazao.Enabled = True
            FrmCadastros.GroupBox1.Enabled = True
            FrmCadastros.btnOK.Visible = True
            FrmCadastros.btnEditar.Visible = False
            FrmCadastros.BtnNovo.Visible = False
            FrmCadastros.BtnExcluir.Visible = False

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try
    End Sub


    Public Sub ExcluirCadastros(QualCadastro As String)

        Try
            If MsgBox("Deseja a pagar o registro da empresa " & FrmCadastros.mtxtNomeRazao.Text & "?", MsgBoxStyle.YesNo, "Controle de cadastro") = vbYes Then
                Select Case QualCadastro
                    Case Is = "Empresas"
                        FrmCadastros.Validate()
                        FrmCadastros.EmpresasBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.EmpresasTableAdapter.DeleteQuery(FrmCadastros.mtxtNumDocumento.Text)
                        MsgBox("Empresa " & FrmCadastros.mtxtNomeRazao.Text & ", apagada com sucesso!", MsgBoxStyle.Information, "Controle de cadastro")

                    Case Is = "Fornecedores"
                        FrmCadastros.Validate()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.FornecedoresTableAdapter.DeleteQuery(FrmCadastros.mtxtNumDocumento.Text)
                        MsgBox("Empresa " & FrmCadastros.mtxtNomeRazao.Text & ", apagada com sucesso!", MsgBoxStyle.Information, "Controle de cadastro")

                    Case Is = "Clientes"
                        FrmCadastros.Validate()
                        FrmCadastros.ClientesBindingSource.EndEdit()
                        FrmCadastros.BancoSysBrechoDataSet.AcceptChanges()
                        FrmCadastros.ClientesTableAdapter.DeleteQuery(FrmCadastros.mtxtNumDocumento.Text)
                        MsgBox("Empresa " & FrmCadastros.mtxtNomeRazao.Text & ", apagada com sucesso!", MsgBoxStyle.Information, "Controle de cadastro")
                End Select
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical, "Sistema de Controle")
        End Try


    End Sub

End Module

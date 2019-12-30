Public Class Validacoes

    'Funçao que preenche com o tipo de documento selecionado pela usuario os nomes das label e as mascaras
    Public Shared Function CPFCNPJ(cbx As ComboBox, mskcpf As MaskedTextBox, lbltipodoc As Label, lblnome As Label)
        If cbx.Text = "CPF" Then
            'mskcpf.Mask = "000.000.000-00"
            lblnome.Text = "Nome"
            lbltipodoc.Text = "CPF"
            mskcpf.Enabled = True
            mskcpf.Select()
            'cbx.Enabled = False
        ElseIf cbx.Text = "CNPJ" Then
            'mskcpf.Mask = "00.000.000/0000-00"
            lblnome.Text = "Razão Social"
            lbltipodoc.Text = "CNPJ"
            mskcpf.Enabled = True
            mskcpf.Select()
            'cbx.Enabled = False
        End If

    End Function

    'Funcao que preenche o combobox com o tipo de selecao da lista 
    Public Shared Function SelecionaCbx(combobox As ComboBox, e As DrawItemEventArgs)
        Dim text As String = combobox.GetItemText(combobox.Items(e.Index))

        Using br As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(text, e.Font, br, e.Bounds)
        End Using
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected AndAlso combobox.DroppedDown Then
            combobox.Text = text
        End If
        e.DrawFocusRectangle()
    End Function

    Public Shared Sub Fecha_o_Formulario(formulario As Form)
        If mdiTelaPrinciapal.VendaAndamento Then
            formulario.Close()
        Else
            formulario.MdiParent.MainMenuStrip.Enabled = True
            formulario.MdiParent.MdiChildren(0).Close()
        End If

    End Sub

    Public Shared Sub ExibeTextBox(textlist As MaskedTextBox)
        textlist.Visible = True
        textlist.Enabled = False
    End Sub

    Public Shared Function ValidarCPFCNPJ(tipo As ComboBox, doc As MaskedTextBox) As Boolean
        'Função que faz a validaçao do documento antes de salvar as informações
        Dim document As String
        Dim valido As Boolean

        If tipo.Text = "CPF" Then
            document = Len(Trim(Replace(Replace(doc.Text, ",", ""), "-", "")))
        ElseIf tipo.Text = "CNPJ" Then
            document = Len(Trim(Replace(Replace(Replace(doc.Text, ",", ""), "/", ""), "-", "")))
        End If

        Select Case document
            Case 11, 14
                valido = True
            Case Else
                valido = False
                'MsgBox("Digite um documento com a extenção valida, CPF = 11 digitos e CNPJ = 14 digito")
        End Select

        Return valido
    End Function
    Public Shared Sub IsNotDBNull(strTextMas As MaskedTextBox)
        If strTextMas.Text IsNot DBNull.Value Then
            strTextMas.Text = strTextMas.Text
        Else
            strTextMas.Text = String.Empty
        End If
    End Sub
    Public Shared Function VerificaInteriro(textMask As MaskedTextBox, Lblalert As Label) As Integer
        Dim numero As Integer

        If textMask.Text <> "" Then
            If IsNumeric(textMask.Text) Then
                numero = textMask.Text
            Else
                Lblalert.Visible = True
                textMask.Select()
                numero = vbEmpty
            End If

        Else
            Lblalert.Visible = True
            textMask.Select()
            numero = vbEmpty
        End If

        Return numero

    End Function

    Public Shared Function ConvertDatas(data As MaskedTextBox, texto As String) As Date
        Dim entrada As Date
        Dim test As String = Trim(Replace(data.Text, "/", ""))
        If String.IsNullOrEmpty(test) Then
            entrada = CDate("01/01/2200")
        Else
            Try
                entrada = CDate(data.Text)
#Disable Warning CA1031 ' Do not catch general exception types
            Catch
                entrada = ("01/01/2200")
                FrmProdutos.lblDataError.Visible = True
                FrmProdutos.lblDataError.Text = String.Concat("Formato da data de ", texto, " Inválido!")
#Enable Warning CA1031 ' Do not catch general exception types
            End Try
        End If
        Return entrada
    End Function

    Public Shared Function AbrirCadastro(formulario As Form) As Boolean
        mdiTelaPrinciapal.MainMenuStrip.Enabled = False
        formulario.MdiParent = mdiTelaPrinciapal
        formulario.Show()
        Return True
    End Function

    Public Shared Function TextBoxGotFocus(ByVal sender As Object, ByVal e As EventArgs)
        Dim mTextBox As TextBox = CType(sender, TextBox)
        mTextBox.BackColor = Color.FromName("LemonChiffon")
    End Function

    Public Shared Function TextBoxLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        Dim mTextBox As TextBox = CType(sender, TextBox)
        mTextBox.BackColor = Color.FromName("White")
    End Function
End Class

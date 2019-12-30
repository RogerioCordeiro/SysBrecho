Module MdRelatorios

    'Variaveis global
    Public Finalizada As Boolean
    Public Valor As Decimal

    Public Function OcultaColunasDtvg(ByVal Dtvg As DataGridView, ByRef Coluna As Integer)
        Dtvg.Columns(Coluna).Visible = False
    End Function
End Module

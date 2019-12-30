Public Class ClassMdiprincipal
    Public Shared Function DesativaMenu(menu As Object, formulario As Form) As Boolean
        Dim continua As Boolean
        menu.Enabled = False
        formulario.MdiParent = menu
        formulario.Show()
        Return continua = True
    End Function
End Class

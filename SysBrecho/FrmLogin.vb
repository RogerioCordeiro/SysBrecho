Public Class FrmLogin

    Private Sub mktSenha_Enter(sender As Object, e As EventArgs) Handles mktSenha.Enter
        mktSenha.Text = ""
        mktSenha.PasswordChar = "*"
        lblMsgErro.Visible = False
        picbErro.Visible = False
    End Sub

    Private Sub mktLogin_Enter(sender As Object, e As EventArgs) Handles mktLogin.Enter
        mktLogin.Text = ""
        lblMsgErro.Visible = False
        picbErro.Visible = False
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PictureBox1.Select()
        mktLogin.Text = "Login"
    End Sub

    Private Sub MktLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktLogin.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            mktSenha.Select()
            e.Handled = True
        End If
    End Sub

    Private Sub MktSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mktSenha.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            BtnOk_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If mktLogin.Text = "" And mktSenha.Text = "" Then
            Me.MdiParent.MainMenuStrip.Enabled = True
            Me.MdiParent.MdiChildren(0).Close()
            mdiTelaPrinciapal.VendaToolStripMenuItem_Click(sender, e)
        Else
            lblMsgErro.Visible = True
            picbErro.Visible = True
        End If
    End Sub

    Private Sub btnCancela_Click_1(sender As Object, e As EventArgs) Handles btnCancela.Click
        mktSenha.Text = "Password"
        mktLogin.Text = "Login"
        mktSenha.PasswordChar = ""
        lblMsgErro.Visible = False
        picbErro.Visible = False
    End Sub
End Class
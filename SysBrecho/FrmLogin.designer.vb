<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picbErro = New System.Windows.Forms.PictureBox()
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.mktSenha = New System.Windows.Forms.MaskedTextBox()
        Me.mktLogin = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picbErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMsgErro)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.btnCancela)
        Me.GroupBox1.Controls.Add(Me.mktSenha)
        Me.GroupBox1.Controls.Add(Me.mktLogin)
        Me.GroupBox1.Controls.Add(Me.picbErro)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 729)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'picbErro
        '
        Me.picbErro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picbErro.Enabled = False
        Me.picbErro.Image = CType(resources.GetObject("picbErro.Image"), System.Drawing.Image)
        Me.picbErro.Location = New System.Drawing.Point(444, 229)
        Me.picbErro.Name = "picbErro"
        Me.picbErro.Size = New System.Drawing.Size(121, 129)
        Me.picbErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbErro.TabIndex = 20
        Me.picbErro.TabStop = False
        Me.picbErro.UseWaitCursor = True
        Me.picbErro.Visible = False
        '
        'lblMsgErro
        '
        Me.lblMsgErro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMsgErro.AutoSize = True
        Me.lblMsgErro.ForeColor = System.Drawing.Color.Red
        Me.lblMsgErro.Location = New System.Drawing.Point(407, 402)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.Size = New System.Drawing.Size(194, 18)
        Me.lblMsgErro.TabIndex = 4
        Me.lblMsgErro.Text = "Usuário ou senha incorreto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgErro.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOk.Location = New System.Drawing.Point(515, 474)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 26)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancela.Location = New System.Drawing.Point(400, 474)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(100, 26)
        Me.btnCancela.TabIndex = 3
        Me.btnCancela.Text = "Cancel"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'mktSenha
        '
        Me.mktSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mktSenha.Location = New System.Drawing.Point(400, 423)
        Me.mktSenha.Name = "mktSenha"
        Me.mktSenha.Size = New System.Drawing.Size(208, 26)
        Me.mktSenha.TabIndex = 1
        Me.mktSenha.Text = "Password"
        Me.mktSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mktLogin
        '
        Me.mktLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mktLogin.Location = New System.Drawing.Point(400, 372)
        Me.mktLogin.Name = "mktLogin"
        Me.mktLogin.Size = New System.Drawing.Size(208, 26)
        Me.mktLogin.TabIndex = 0
        Me.mktLogin.Text = "Login"
        Me.mktLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(444, 229)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picbErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents lblMsgErro As Label
    Private WithEvents btnOk As Button
    Private WithEvents btnCancela As Button
    Private WithEvents mktSenha As MaskedTextBox
    Private WithEvents mktLogin As MaskedTextBox
    Private WithEvents picbErro As PictureBox
    Private WithEvents PictureBox1 As PictureBox
End Class

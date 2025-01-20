<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadProprietario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHolder = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCancelar = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlProp = New System.Windows.Forms.Panel()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtRG = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.cbxCpfCnpj = New System.Windows.Forms.CheckBox()
        Me.txtCcB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAgB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPpB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNmB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNovo = New System.Windows.Forms.Label()
        Me.txtSalvar = New System.Windows.Forms.Label()
        Me.txtDeletar = New System.Windows.Forms.Label()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnNv = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.lblO = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.cdfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corrente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.popanca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHolder.SuspendLayout()
        Me.pnlProp.SuspendLayout()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHolder
        '
        Me.pnlHolder.AutoScroll = True
        Me.pnlHolder.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlHolder.Controls.Add(Me.Button2)
        Me.pnlHolder.Controls.Add(Me.txtCancelar)
        Me.pnlHolder.Controls.Add(Me.btnCancelar)
        Me.pnlHolder.Controls.Add(Me.pnlProp)
        Me.pnlHolder.Controls.Add(Me.txtNovo)
        Me.pnlHolder.Controls.Add(Me.txtSalvar)
        Me.pnlHolder.Controls.Add(Me.txtDeletar)
        Me.pnlHolder.Controls.Add(Me.btnDeletar)
        Me.pnlHolder.Controls.Add(Me.btnNv)
        Me.pnlHolder.Controls.Add(Me.btnSalvar)
        Me.pnlHolder.Controls.Add(Me.TxtTexto)
        Me.pnlHolder.Controls.Add(Me.lblO)
        Me.pnlHolder.Controls.Add(Me.DgdGrade)
        Me.pnlHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHolder.Location = New System.Drawing.Point(0, 0)
        Me.pnlHolder.Name = "pnlHolder"
        Me.pnlHolder.Size = New System.Drawing.Size(1253, 680)
        Me.pnlHolder.TabIndex = 63
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SGI.My.Resources.Resources.IcoVoltar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 26)
        Me.Button2.TabIndex = 170
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCancelar
        '
        Me.txtCancelar.AutoSize = True
        Me.txtCancelar.BackColor = System.Drawing.Color.Transparent
        Me.txtCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelar.ForeColor = System.Drawing.Color.Black
        Me.txtCancelar.Location = New System.Drawing.Point(229, 550)
        Me.txtCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtCancelar.Name = "txtCancelar"
        Me.txtCancelar.Size = New System.Drawing.Size(51, 13)
        Me.txtCancelar.TabIndex = 168
        Me.txtCancelar.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoDeletar
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(238, 514)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(32, 32)
        Me.btnCancelar.TabIndex = 167
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pnlProp
        '
        Me.pnlProp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProp.Controls.Add(Me.txtTel)
        Me.pnlProp.Controls.Add(Me.txtRG)
        Me.pnlProp.Controls.Add(Me.txtCpf)
        Me.pnlProp.Controls.Add(Me.cbxCpfCnpj)
        Me.pnlProp.Controls.Add(Me.txtCcB)
        Me.pnlProp.Controls.Add(Me.Label6)
        Me.pnlProp.Controls.Add(Me.txtPix)
        Me.pnlProp.Controls.Add(Me.Label5)
        Me.pnlProp.Controls.Add(Me.txtAgB)
        Me.pnlProp.Controls.Add(Me.Label3)
        Me.pnlProp.Controls.Add(Me.txtPpB)
        Me.pnlProp.Controls.Add(Me.Label12)
        Me.pnlProp.Controls.Add(Me.txtNmB)
        Me.pnlProp.Controls.Add(Me.Label13)
        Me.pnlProp.Controls.Add(Me.Label4)
        Me.pnlProp.Controls.Add(Me.Label18)
        Me.pnlProp.Controls.Add(Me.Label7)
        Me.pnlProp.Controls.Add(Me.txtNome)
        Me.pnlProp.Controls.Add(Me.Label8)
        Me.pnlProp.Controls.Add(Me.Label9)
        Me.pnlProp.Controls.Add(Me.txtEmail)
        Me.pnlProp.Controls.Add(Me.Label10)
        Me.pnlProp.Controls.Add(Me.Label11)
        Me.pnlProp.Location = New System.Drawing.Point(3, 566)
        Me.pnlProp.Name = "pnlProp"
        Me.pnlProp.Size = New System.Drawing.Size(1189, 552)
        Me.pnlProp.TabIndex = 159
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(432, 183)
        Me.txtTel.Mask = "(00) 000000000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(149, 29)
        Me.txtTel.TabIndex = 287
        '
        'txtRG
        '
        Me.txtRG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRG.Location = New System.Drawing.Point(431, 74)
        Me.txtRG.Mask = "00.000.000-A"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(149, 29)
        Me.txtRG.TabIndex = 286
        '
        'txtCpf
        '
        Me.txtCpf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(66, 128)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(149, 29)
        Me.txtCpf.TabIndex = 285
        '
        'cbxCpfCnpj
        '
        Me.cbxCpfCnpj.AutoSize = True
        Me.cbxCpfCnpj.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxCpfCnpj.Location = New System.Drawing.Point(263, 111)
        Me.cbxCpfCnpj.Name = "cbxCpfCnpj"
        Me.cbxCpfCnpj.Size = New System.Drawing.Size(162, 46)
        Me.cbxCpfCnpj.TabIndex = 284
        Me.cbxCpfCnpj.Text = "CPF (Marque para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "alterar para CNPJ)"
        Me.cbxCpfCnpj.UseVisualStyleBackColor = True
        '
        'txtCcB
        '
        Me.txtCcB.BackColor = System.Drawing.SystemColors.Window
        Me.txtCcB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCcB.ForeColor = System.Drawing.Color.Black
        Me.txtCcB.Location = New System.Drawing.Point(67, 352)
        Me.txtCcB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCcB.Name = "txtCcB"
        Me.txtCcB.Size = New System.Drawing.Size(285, 29)
        Me.txtCcB.TabIndex = 191
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(63, 329)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "Conta Corrente"
        '
        'txtPix
        '
        Me.txtPix.BackColor = System.Drawing.SystemColors.Window
        Me.txtPix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPix.ForeColor = System.Drawing.Color.Black
        Me.txtPix.Location = New System.Drawing.Point(67, 410)
        Me.txtPix.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPix.Name = "txtPix"
        Me.txtPix.Size = New System.Drawing.Size(285, 29)
        Me.txtPix.TabIndex = 189
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(62, 385)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 21)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "Pix"
        '
        'txtAgB
        '
        Me.txtAgB.BackColor = System.Drawing.SystemColors.Window
        Me.txtAgB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgB.ForeColor = System.Drawing.Color.Black
        Me.txtAgB.Location = New System.Drawing.Point(362, 296)
        Me.txtAgB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtAgB.Name = "txtAgB"
        Me.txtAgB.Size = New System.Drawing.Size(262, 29)
        Me.txtAgB.TabIndex = 187
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(357, 273)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Agência"
        '
        'txtPpB
        '
        Me.txtPpB.BackColor = System.Drawing.SystemColors.Window
        Me.txtPpB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPpB.ForeColor = System.Drawing.Color.Black
        Me.txtPpB.Location = New System.Drawing.Point(361, 352)
        Me.txtPpB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPpB.Name = "txtPpB"
        Me.txtPpB.Size = New System.Drawing.Size(263, 29)
        Me.txtPpB.TabIndex = 185
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(356, 329)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 21)
        Me.Label12.TabIndex = 184
        Me.Label12.Text = "Poupança"
        '
        'txtNmB
        '
        Me.txtNmB.BackColor = System.Drawing.SystemColors.Window
        Me.txtNmB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmB.ForeColor = System.Drawing.Color.Black
        Me.txtNmB.Location = New System.Drawing.Point(67, 296)
        Me.txtNmB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNmB.Name = "txtNmB"
        Me.txtNmB.Size = New System.Drawing.Size(285, 29)
        Me.txtNmB.TabIndex = 183
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(62, 273)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 21)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "Nome do Banco"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 25)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "Informações Bancárias"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(28, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(253, 30)
        Me.Label18.TabIndex = 180
        Me.Label18.Text = "Cadastro de Proprietário"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(62, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(66, 74)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(359, 29)
        Me.txtNome.TabIndex = 170
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(427, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 21)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "RG"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(62, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "CPF/CNPJ"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(66, 183)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(360, 29)
        Me.txtEmail.TabIndex = 175
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(427, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 21)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "Telefone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(63, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 21)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "E-Mail"
        '
        'txtNovo
        '
        Me.txtNovo.AutoSize = True
        Me.txtNovo.BackColor = System.Drawing.Color.Transparent
        Me.txtNovo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovo.ForeColor = System.Drawing.Color.Black
        Me.txtNovo.Location = New System.Drawing.Point(34, 547)
        Me.txtNovo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtNovo.Name = "txtNovo"
        Me.txtNovo.Size = New System.Drawing.Size(36, 13)
        Me.txtNovo.TabIndex = 158
        Me.txtNovo.Text = "Novo"
        '
        'txtSalvar
        '
        Me.txtSalvar.AutoSize = True
        Me.txtSalvar.BackColor = System.Drawing.Color.Transparent
        Me.txtSalvar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalvar.ForeColor = System.Drawing.Color.Black
        Me.txtSalvar.Location = New System.Drawing.Point(103, 549)
        Me.txtSalvar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtSalvar.Name = "txtSalvar"
        Me.txtSalvar.Size = New System.Drawing.Size(38, 13)
        Me.txtSalvar.TabIndex = 157
        Me.txtSalvar.Text = "Salvar"
        '
        'txtDeletar
        '
        Me.txtDeletar.AutoSize = True
        Me.txtDeletar.BackColor = System.Drawing.Color.Transparent
        Me.txtDeletar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeletar.ForeColor = System.Drawing.Color.Black
        Me.txtDeletar.Location = New System.Drawing.Point(167, 549)
        Me.txtDeletar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtDeletar.Name = "txtDeletar"
        Me.txtDeletar.Size = New System.Drawing.Size(44, 13)
        Me.txtDeletar.TabIndex = 156
        Me.txtDeletar.Text = "Deletar"
        '
        'btnDeletar
        '
        Me.btnDeletar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoLixo
        Me.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeletar.FlatAppearance.BorderSize = 0
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Location = New System.Drawing.Point(172, 514)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(32, 32)
        Me.btnDeletar.TabIndex = 153
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnNv
        '
        Me.btnNv.BackgroundImage = Global.SGI.My.Resources.Resources.IcoAdd
        Me.btnNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNv.FlatAppearance.BorderSize = 0
        Me.btnNv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNv.Location = New System.Drawing.Point(36, 514)
        Me.btnNv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNv.Name = "btnNv"
        Me.btnNv.Size = New System.Drawing.Size(32, 32)
        Me.btnNv.TabIndex = 154
        Me.btnNv.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoSalvar
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(105, 514)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(32, 32)
        Me.btnSalvar.TabIndex = 155
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'TxtTexto
        '
        Me.TxtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTexto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTexto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(36, 90)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1165, 35)
        Me.TxtTexto.TabIndex = 80
        '
        'lblO
        '
        Me.lblO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblO.AutoSize = True
        Me.lblO.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblO.ForeColor = System.Drawing.Color.Black
        Me.lblO.Location = New System.Drawing.Point(31, 52)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(470, 30)
        Me.lblO.TabIndex = 81
        Me.lblO.Text = "Digite o nome do proprietário para localizá-lo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AllowUserToResizeRows = False
        Me.DgdGrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgdGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgdGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgdGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgdGrade.ColumnHeadersHeight = 35
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdfun, Me.nmfun, Me.rg, Me.cpf, Me.email, Me.tel, Me.nmBanco, Me.agencia, Me.corrente, Me.popanca, Me.pix})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(36, 156)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1165, 350)
        Me.DgdGrade.TabIndex = 79
        '
        'cdfun
        '
        Me.cdfun.HeaderText = "codigo"
        Me.cdfun.Name = "cdfun"
        Me.cdfun.ReadOnly = True
        Me.cdfun.Visible = False
        '
        'nmfun
        '
        Me.nmfun.HeaderText = "Nome"
        Me.nmfun.Name = "nmfun"
        Me.nmfun.ReadOnly = True
        '
        'rg
        '
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF/CNPJ"
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        '
        'email
        '
        Me.email.HeaderText = "E-Mail"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'tel
        '
        Me.tel.HeaderText = "Telefone"
        Me.tel.Name = "tel"
        Me.tel.ReadOnly = True
        '
        'nmBanco
        '
        Me.nmBanco.HeaderText = "Nome do Banco"
        Me.nmBanco.Name = "nmBanco"
        Me.nmBanco.ReadOnly = True
        '
        'agencia
        '
        Me.agencia.HeaderText = "Agencia"
        Me.agencia.Name = "agencia"
        Me.agencia.ReadOnly = True
        '
        'corrente
        '
        Me.corrente.HeaderText = "Conta Corrente"
        Me.corrente.Name = "corrente"
        Me.corrente.ReadOnly = True
        '
        'popanca
        '
        Me.popanca.HeaderText = "Poupança"
        Me.popanca.Name = "popanca"
        Me.popanca.ReadOnly = True
        '
        'pix
        '
        Me.pix.HeaderText = "Pix"
        Me.pix.Name = "pix"
        Me.pix.ReadOnly = True
        '
        'CadProprietario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1253, 680)
        Me.Controls.Add(Me.pnlHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadProprietario"
        Me.Text = "CadProprietario"
        Me.pnlHolder.ResumeLayout(False)
        Me.pnlHolder.PerformLayout()
        Me.pnlProp.ResumeLayout(False)
        Me.pnlProp.PerformLayout()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHolder As Panel
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents lblO As Label
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents txtNovo As Label
    Friend WithEvents txtSalvar As Label
    Friend WithEvents txtDeletar As Label
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnNv As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents pnlProp As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCcB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAgB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPpB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNmB As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCancelar As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cdfun As DataGridViewTextBoxColumn
    Friend WithEvents nmfun As DataGridViewTextBoxColumn
    Friend WithEvents rg As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents tel As DataGridViewTextBoxColumn
    Friend WithEvents nmBanco As DataGridViewTextBoxColumn
    Friend WithEvents agencia As DataGridViewTextBoxColumn
    Friend WithEvents corrente As DataGridViewTextBoxColumn
    Friend WithEvents popanca As DataGridViewTextBoxColumn
    Friend WithEvents pix As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents txtRG As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents cbxCpfCnpj As CheckBox
End Class

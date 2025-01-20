<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadInquilino
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.pnlHolder = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCancelar = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlProp = New System.Windows.Forms.Panel()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtRG = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.cbxCpfCnpj = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNovo = New System.Windows.Forms.Label()
        Me.txtSalvar = New System.Windows.Forms.Label()
        Me.txtDeletar = New System.Windows.Forms.Label()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnNv = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.cbxOcultar = New System.Windows.Forms.CheckBox()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.atiInq = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.pnlHolder.Controls.Add(Me.cbxOcultar)
        Me.pnlHolder.Controls.Add(Me.TxtTexto)
        Me.pnlHolder.Controls.Add(Me.Label7)
        Me.pnlHolder.Controls.Add(Me.DgdGrade)
        Me.pnlHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHolder.Location = New System.Drawing.Point(0, 0)
        Me.pnlHolder.Name = "pnlHolder"
        Me.pnlHolder.Size = New System.Drawing.Size(1254, 680)
        Me.pnlHolder.TabIndex = 85
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SGI.My.Resources.Resources.IcoVoltar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 26)
        Me.Button2.TabIndex = 174
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCancelar
        '
        Me.txtCancelar.AutoSize = True
        Me.txtCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelar.ForeColor = System.Drawing.Color.Black
        Me.txtCancelar.Location = New System.Drawing.Point(230, 559)
        Me.txtCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtCancelar.Name = "txtCancelar"
        Me.txtCancelar.Size = New System.Drawing.Size(51, 13)
        Me.txtCancelar.TabIndex = 173
        Me.txtCancelar.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoDeletar
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(238, 523)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(32, 32)
        Me.btnCancelar.TabIndex = 172
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
        Me.pnlProp.Controls.Add(Me.Label8)
        Me.pnlProp.Controls.Add(Me.Label4)
        Me.pnlProp.Controls.Add(Me.Label2)
        Me.pnlProp.Controls.Add(Me.Label1)
        Me.pnlProp.Controls.Add(Me.txtEmail)
        Me.pnlProp.Controls.Add(Me.Label5)
        Me.pnlProp.Controls.Add(Me.txtNome)
        Me.pnlProp.Controls.Add(Me.Label3)
        Me.pnlProp.Location = New System.Drawing.Point(3, 581)
        Me.pnlProp.Name = "pnlProp"
        Me.pnlProp.Size = New System.Drawing.Size(1185, 384)
        Me.pnlProp.TabIndex = 168
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(39, 250)
        Me.txtTel.Mask = "(00) 000000000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(149, 29)
        Me.txtTel.TabIndex = 283
        '
        'txtRG
        '
        Me.txtRG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRG.Location = New System.Drawing.Point(39, 192)
        Me.txtRG.Mask = "00.000.000-A"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(149, 29)
        Me.txtRG.TabIndex = 282
        '
        'txtCpf
        '
        Me.txtCpf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(39, 136)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(149, 29)
        Me.txtCpf.TabIndex = 281
        '
        'cbxCpfCnpj
        '
        Me.cbxCpfCnpj.AutoSize = True
        Me.cbxCpfCnpj.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxCpfCnpj.Location = New System.Drawing.Point(194, 119)
        Me.cbxCpfCnpj.Name = "cbxCpfCnpj"
        Me.cbxCpfCnpj.Size = New System.Drawing.Size(162, 46)
        Me.cbxCpfCnpj.TabIndex = 280
        Me.cbxCpfCnpj.Text = "CPF (Marque para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "alterar para CNPJ)"
        Me.cbxCpfCnpj.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(35, 224)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 166
        Me.Label8.Tag = "1"
        Me.Label8.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 164
        Me.Label4.Tag = "1"
        Me.Label4.Text = "CPF/CNPJ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 168)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 21)
        Me.Label2.TabIndex = 162
        Me.Label2.Tag = "1"
        Me.Label2.Text = "RG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 282)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 160
        Me.Label1.Tag = "1"
        Me.Label1.Text = "E-Mail"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(39, 305)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(317, 29)
        Me.txtEmail.TabIndex = 159
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 21)
        Me.Label5.TabIndex = 158
        Me.Label5.Tag = "1"
        Me.Label5.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(39, 76)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(317, 29)
        Me.txtNome.TabIndex = 157
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 30)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Cadastro de Inquilino"
        '
        'txtNovo
        '
        Me.txtNovo.AutoSize = True
        Me.txtNovo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovo.ForeColor = System.Drawing.Color.Black
        Me.txtNovo.Location = New System.Drawing.Point(30, 560)
        Me.txtNovo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtNovo.Name = "txtNovo"
        Me.txtNovo.Size = New System.Drawing.Size(36, 13)
        Me.txtNovo.TabIndex = 167
        Me.txtNovo.Text = "Novo"
        '
        'txtSalvar
        '
        Me.txtSalvar.AutoSize = True
        Me.txtSalvar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalvar.ForeColor = System.Drawing.Color.Black
        Me.txtSalvar.Location = New System.Drawing.Point(95, 559)
        Me.txtSalvar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtSalvar.Name = "txtSalvar"
        Me.txtSalvar.Size = New System.Drawing.Size(38, 13)
        Me.txtSalvar.TabIndex = 166
        Me.txtSalvar.Text = "Salvar"
        '
        'txtDeletar
        '
        Me.txtDeletar.AutoSize = True
        Me.txtDeletar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeletar.ForeColor = System.Drawing.Color.Black
        Me.txtDeletar.Location = New System.Drawing.Point(162, 559)
        Me.txtDeletar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtDeletar.Name = "txtDeletar"
        Me.txtDeletar.Size = New System.Drawing.Size(44, 13)
        Me.txtDeletar.TabIndex = 165
        Me.txtDeletar.Text = "Deletar"
        '
        'btnDeletar
        '
        Me.btnDeletar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoLixo
        Me.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeletar.FlatAppearance.BorderSize = 0
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Location = New System.Drawing.Point(167, 523)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(32, 32)
        Me.btnDeletar.TabIndex = 162
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnNv
        '
        Me.btnNv.BackgroundImage = Global.SGI.My.Resources.Resources.IcoAdd
        Me.btnNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNv.FlatAppearance.BorderSize = 0
        Me.btnNv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNv.Location = New System.Drawing.Point(31, 523)
        Me.btnNv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNv.Name = "btnNv"
        Me.btnNv.Size = New System.Drawing.Size(32, 32)
        Me.btnNv.TabIndex = 163
        Me.btnNv.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoSalvar
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(100, 523)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(32, 32)
        Me.btnSalvar.TabIndex = 164
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'cbxOcultar
        '
        Me.cbxOcultar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxOcultar.AutoSize = True
        Me.cbxOcultar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOcultar.ForeColor = System.Drawing.Color.Black
        Me.cbxOcultar.Location = New System.Drawing.Point(33, 127)
        Me.cbxOcultar.Name = "cbxOcultar"
        Me.cbxOcultar.Size = New System.Drawing.Size(545, 25)
        Me.cbxOcultar.TabIndex = 90
        Me.cbxOcultar.Text = "Marque esse campo para ocultar inquilinos que não estão alugando"
        Me.cbxOcultar.UseVisualStyleBackColor = True
        '
        'TxtTexto
        '
        Me.TxtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTexto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTexto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.ForeColor = System.Drawing.Color.Black
        Me.TxtTexto.Location = New System.Drawing.Point(33, 86)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1191, 35)
        Me.TxtTexto.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(28, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(441, 30)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Digite o nome do inquilino para localizá-lo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AllowUserToResizeRows = False
        Me.DgdGrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgdGrade.ColumnHeadersHeight = 35
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.rg, Me.cpf, Me.email, Me.telefone, Me.atiInq})
        Me.DgdGrade.Location = New System.Drawing.Point(31, 166)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.Size = New System.Drawing.Size(1193, 350)
        Me.DgdGrade.TabIndex = 83
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'rg
        '
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        '
        'email
        '
        Me.email.HeaderText = "E-Mail"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'telefone
        '
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        Me.telefone.ReadOnly = True
        '
        'atiInq
        '
        Me.atiInq.HeaderText = "Está Alugando?"
        Me.atiInq.Name = "atiInq"
        Me.atiInq.ReadOnly = True
        '
        'CadInquilino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1254, 680)
        Me.Controls.Add(Me.pnlHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadInquilino"
        Me.Text = "CadInquilino"
        Me.pnlHolder.ResumeLayout(False)
        Me.pnlHolder.PerformLayout()
        Me.pnlProp.ResumeLayout(False)
        Me.pnlProp.PerformLayout()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlHolder As Panel
    Friend WithEvents cbxOcultar As CheckBox
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents rg As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents atiInq As DataGridViewCheckBoxColumn
    Friend WithEvents txtNovo As Label
    Friend WithEvents txtSalvar As Label
    Friend WithEvents txtDeletar As Label
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnNv As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents pnlProp As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCancelar As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbxCpfCnpj As CheckBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents txtRG As MaskedTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadLocacao
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
        Me.pnlHolder = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCancelar = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlProp = New System.Windows.Forms.Panel()
        Me.txtDP = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPag = New System.Windows.Forms.NumericUpDown()
        Me.cbxAtiva = New System.Windows.Forms.CheckBox()
        Me.lblFim = New System.Windows.Forms.Label()
        Me.dtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btImo = New System.Windows.Forms.Button()
        Me.lblmo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblInq = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNovo = New System.Windows.Forms.Label()
        Me.txtSalvar = New System.Windows.Forms.Label()
        Me.txtDeletar = New System.Windows.Forms.Label()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnNv = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.cbxOcultar = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.codigoDoImovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruaImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codinquilino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomInq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsAtivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dtp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagloc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdproprietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHolder.SuspendLayout()
        Me.pnlProp.SuspendLayout()
        CType(Me.txtDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPag, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHolder.Controls.Add(Me.ComboBox2)
        Me.pnlHolder.Controls.Add(Me.Label2)
        Me.pnlHolder.Controls.Add(Me.TxtTexto)
        Me.pnlHolder.Controls.Add(Me.DgdGrade)
        Me.pnlHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHolder.Location = New System.Drawing.Point(0, 0)
        Me.pnlHolder.Name = "pnlHolder"
        Me.pnlHolder.Size = New System.Drawing.Size(1254, 680)
        Me.pnlHolder.TabIndex = 62
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
        Me.Button2.TabIndex = 169
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCancelar
        '
        Me.txtCancelar.AutoSize = True
        Me.txtCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelar.ForeColor = System.Drawing.Color.Black
        Me.txtCancelar.Location = New System.Drawing.Point(241, 548)
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
        Me.btnCancelar.Location = New System.Drawing.Point(251, 512)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(32, 32)
        Me.btnCancelar.TabIndex = 167
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pnlProp
        '
        Me.pnlProp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProp.Controls.Add(Me.txtDP)
        Me.pnlProp.Controls.Add(Me.Panel1)
        Me.pnlProp.Controls.Add(Me.txtPag)
        Me.pnlProp.Controls.Add(Me.cbxAtiva)
        Me.pnlProp.Controls.Add(Me.lblFim)
        Me.pnlProp.Controls.Add(Me.dtpFim)
        Me.pnlProp.Controls.Add(Me.Label9)
        Me.pnlProp.Controls.Add(Me.dtpIni)
        Me.pnlProp.Controls.Add(Me.Label8)
        Me.pnlProp.Controls.Add(Me.Label6)
        Me.pnlProp.Controls.Add(Me.Label11)
        Me.pnlProp.Controls.Add(Me.btImo)
        Me.pnlProp.Controls.Add(Me.lblmo)
        Me.pnlProp.Controls.Add(Me.Label3)
        Me.pnlProp.Controls.Add(Me.Label7)
        Me.pnlProp.Controls.Add(Me.Button1)
        Me.pnlProp.Controls.Add(Me.lblInq)
        Me.pnlProp.Controls.Add(Me.Label4)
        Me.pnlProp.Controls.Add(Me.Label18)
        Me.pnlProp.Controls.Add(Me.Label5)
        Me.pnlProp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProp.ForeColor = System.Drawing.Color.Black
        Me.pnlProp.Location = New System.Drawing.Point(3, 566)
        Me.pnlProp.Name = "pnlProp"
        Me.pnlProp.Size = New System.Drawing.Size(1202, 448)
        Me.pnlProp.TabIndex = 153
        '
        'txtDP
        '
        Me.txtDP.BackColor = System.Drawing.SystemColors.Window
        Me.txtDP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDP.ForeColor = System.Drawing.Color.Black
        Me.txtDP.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDP.Location = New System.Drawing.Point(423, 109)
        Me.txtDP.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
        Me.txtDP.Name = "txtDP"
        Me.txtDP.Size = New System.Drawing.Size(215, 29)
        Me.txtDP.TabIndex = 261
        Me.txtDP.ThousandsSeparator = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(395, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 373)
        Me.Panel1.TabIndex = 260
        '
        'txtPag
        '
        Me.txtPag.BackColor = System.Drawing.SystemColors.Window
        Me.txtPag.DecimalPlaces = 2
        Me.txtPag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPag.ForeColor = System.Drawing.Color.Black
        Me.txtPag.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPag.Location = New System.Drawing.Point(423, 180)
        Me.txtPag.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtPag.Name = "txtPag"
        Me.txtPag.Size = New System.Drawing.Size(215, 29)
        Me.txtPag.TabIndex = 256
        Me.txtPag.ThousandsSeparator = True
        '
        'cbxAtiva
        '
        Me.cbxAtiva.AutoSize = True
        Me.cbxAtiva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAtiva.ForeColor = System.Drawing.Color.Black
        Me.cbxAtiva.Location = New System.Drawing.Point(652, 315)
        Me.cbxAtiva.Name = "cbxAtiva"
        Me.cbxAtiva.Size = New System.Drawing.Size(76, 25)
        Me.cbxAtiva.TabIndex = 172
        Me.cbxAtiva.Text = "Ativa?"
        Me.cbxAtiva.UseVisualStyleBackColor = True
        '
        'lblFim
        '
        Me.lblFim.AutoSize = True
        Me.lblFim.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFim.ForeColor = System.Drawing.Color.Black
        Me.lblFim.Location = New System.Drawing.Point(421, 358)
        Me.lblFim.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFim.Name = "lblFim"
        Me.lblFim.Size = New System.Drawing.Size(176, 21)
        Me.lblFim.TabIndex = 170
        Me.lblFim.Text = "Data de fim da locação"
        '
        'dtpFim
        '
        Me.dtpFim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFim.Location = New System.Drawing.Point(425, 382)
        Me.dtpFim.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpFim.Name = "dtpFim"
        Me.dtpFim.Size = New System.Drawing.Size(213, 29)
        Me.dtpFim.TabIndex = 171
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(407, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 25)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Locação"
        '
        'dtpIni
        '
        Me.dtpIni.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIni.Location = New System.Drawing.Point(424, 315)
        Me.dtpIni.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(214, 29)
        Me.dtpIni.TabIndex = 168
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(420, 292)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 21)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Data de Início da locação"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(419, 157)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Pagamento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(65, 85)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 21)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "Código do imóvel:"
        '
        'btImo
        '
        Me.btImo.BackColor = System.Drawing.SystemColors.Window
        Me.btImo.BackgroundImage = Global.SGI.My.Resources.Resources.pesquisarcodigodoimovel_303_45
        Me.btImo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btImo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImo.ForeColor = System.Drawing.Color.Black
        Me.btImo.Location = New System.Drawing.Point(69, 138)
        Me.btImo.Name = "btImo"
        Me.btImo.Size = New System.Drawing.Size(303, 50)
        Me.btImo.TabIndex = 157
        Me.btImo.UseVisualStyleBackColor = False
        '
        'lblmo
        '
        Me.lblmo.AutoSize = True
        Me.lblmo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmo.ForeColor = System.Drawing.Color.Black
        Me.lblmo.Location = New System.Drawing.Point(66, 106)
        Me.lblmo.Name = "lblmo"
        Me.lblmo.Size = New System.Drawing.Size(306, 17)
        Me.lblmo.TabIndex = 158
        Me.lblmo.Text = "Pesquise o código do imóvel pelo botão abaixo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(65, 227)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 21)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Código do Inquilino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(419, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 21)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Dia do mês do pagamento"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.BackgroundImage = Global.SGI.My.Resources.Resources.pesquisarcodigodoinquilino_303_45
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(69, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(303, 51)
        Me.Button1.TabIndex = 160
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblInq
        '
        Me.lblInq.AutoSize = True
        Me.lblInq.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInq.ForeColor = System.Drawing.Color.Black
        Me.lblInq.Location = New System.Drawing.Point(66, 248)
        Me.lblInq.Name = "lblInq"
        Me.lblInq.Size = New System.Drawing.Size(320, 17)
        Me.lblInq.TabIndex = 161
        Me.lblInq.Text = "Pesquise o código do inquilino pelo botão abaixo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 25)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Informações Básicas"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(37, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(214, 30)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "Cadastro de Locação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(407, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Pagamento"
        '
        'txtNovo
        '
        Me.txtNovo.AutoSize = True
        Me.txtNovo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovo.ForeColor = System.Drawing.Color.Black
        Me.txtNovo.Location = New System.Drawing.Point(44, 548)
        Me.txtNovo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtNovo.Name = "txtNovo"
        Me.txtNovo.Size = New System.Drawing.Size(36, 13)
        Me.txtNovo.TabIndex = 152
        Me.txtNovo.Text = "Novo"
        '
        'txtSalvar
        '
        Me.txtSalvar.AutoSize = True
        Me.txtSalvar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalvar.ForeColor = System.Drawing.Color.Black
        Me.txtSalvar.Location = New System.Drawing.Point(112, 550)
        Me.txtSalvar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtSalvar.Name = "txtSalvar"
        Me.txtSalvar.Size = New System.Drawing.Size(38, 13)
        Me.txtSalvar.TabIndex = 151
        Me.txtSalvar.Text = "Salvar"
        '
        'txtDeletar
        '
        Me.txtDeletar.AutoSize = True
        Me.txtDeletar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeletar.ForeColor = System.Drawing.Color.Black
        Me.txtDeletar.Location = New System.Drawing.Point(177, 550)
        Me.txtDeletar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtDeletar.Name = "txtDeletar"
        Me.txtDeletar.Size = New System.Drawing.Size(44, 13)
        Me.txtDeletar.TabIndex = 150
        Me.txtDeletar.Text = "Deletar"
        '
        'btnDeletar
        '
        Me.btnDeletar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoLixo
        Me.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeletar.FlatAppearance.BorderSize = 0
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Location = New System.Drawing.Point(181, 512)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(32, 32)
        Me.btnDeletar.TabIndex = 147
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnNv
        '
        Me.btnNv.BackgroundImage = Global.SGI.My.Resources.Resources.IcoAdd
        Me.btnNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNv.FlatAppearance.BorderSize = 0
        Me.btnNv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNv.Location = New System.Drawing.Point(45, 512)
        Me.btnNv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNv.Name = "btnNv"
        Me.btnNv.Size = New System.Drawing.Size(32, 32)
        Me.btnNv.TabIndex = 148
        Me.btnNv.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoSalvar
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(114, 512)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(32, 32)
        Me.btnSalvar.TabIndex = 149
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'cbxOcultar
        '
        Me.cbxOcultar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxOcultar.AutoSize = True
        Me.cbxOcultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOcultar.ForeColor = System.Drawing.Color.Black
        Me.cbxOcultar.Location = New System.Drawing.Point(45, 122)
        Me.cbxOcultar.Name = "cbxOcultar"
        Me.cbxOcultar.Size = New System.Drawing.Size(257, 24)
        Me.cbxOcultar.TabIndex = 100
        Me.cbxOcultar.Text = "Mostrar ocupações inativas?"
        Me.cbxOcultar.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Nome do inquilino", "Rua do imovel", "Nome do proprietário"})
        Me.ComboBox2.Location = New System.Drawing.Point(280, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(268, 29)
        Me.ComboBox2.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 30)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Pesquisar locação por:"
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
        Me.TxtTexto.Location = New System.Drawing.Point(45, 76)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1160, 35)
        Me.TxtTexto.TabIndex = 97
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoDoImovel, Me.ruaImo, Me.codinquilino, Me.nomInq, Me.dtLoc, Me.IsAtivo, Me.dtp, Me.dtf, Me.pagloc, Me.cdproprietario, Me.NomeProp})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(45, 154)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1160, 350)
        Me.DgdGrade.TabIndex = 96
        '
        'codigoDoImovel
        '
        Me.codigoDoImovel.HeaderText = "cdImo"
        Me.codigoDoImovel.Name = "codigoDoImovel"
        Me.codigoDoImovel.ReadOnly = True
        Me.codigoDoImovel.Visible = False
        '
        'ruaImo
        '
        Me.ruaImo.HeaderText = "Rua do Imovel"
        Me.ruaImo.Name = "ruaImo"
        Me.ruaImo.ReadOnly = True
        '
        'codinquilino
        '
        Me.codinquilino.HeaderText = "Codigo do inquilino"
        Me.codinquilino.Name = "codinquilino"
        Me.codinquilino.ReadOnly = True
        Me.codinquilino.Visible = False
        '
        'nomInq
        '
        Me.nomInq.HeaderText = "Nome do inquilino"
        Me.nomInq.Name = "nomInq"
        Me.nomInq.ReadOnly = True
        '
        'dtLoc
        '
        Me.dtLoc.HeaderText = "Data de inicio"
        Me.dtLoc.Name = "dtLoc"
        Me.dtLoc.ReadOnly = True
        '
        'IsAtivo
        '
        Me.IsAtivo.HeaderText = "Ativa?"
        Me.IsAtivo.Name = "IsAtivo"
        Me.IsAtivo.ReadOnly = True
        '
        'dtp
        '
        Me.dtp.HeaderText = "Dia do mês do pagamento"
        Me.dtp.Name = "dtp"
        Me.dtp.ReadOnly = True
        Me.dtp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dtf
        '
        Me.dtf.HeaderText = "Data do fim"
        Me.dtf.Name = "dtf"
        Me.dtf.ReadOnly = True
        '
        'pagloc
        '
        Me.pagloc.HeaderText = "Pagamento acordado"
        Me.pagloc.Name = "pagloc"
        Me.pagloc.ReadOnly = True
        '
        'cdproprietario
        '
        Me.cdproprietario.HeaderText = "Column1"
        Me.cdproprietario.Name = "cdproprietario"
        Me.cdproprietario.ReadOnly = True
        Me.cdproprietario.Visible = False
        '
        'NomeProp
        '
        Me.NomeProp.HeaderText = "Nome do Proprietário"
        Me.NomeProp.Name = "NomeProp"
        Me.NomeProp.ReadOnly = True
        '
        'CadLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1254, 680)
        Me.Controls.Add(Me.pnlHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadLocacao"
        Me.Text = "CadLocacao"
        Me.pnlHolder.ResumeLayout(False)
        Me.pnlHolder.PerformLayout()
        Me.pnlProp.ResumeLayout(False)
        Me.pnlProp.PerformLayout()
        CType(Me.txtDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlHolder As Panel
    Friend WithEvents cbxOcultar As CheckBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents codigoDoImovel As DataGridViewTextBoxColumn
    Friend WithEvents ruaImo As DataGridViewTextBoxColumn
    Friend WithEvents codinquilino As DataGridViewTextBoxColumn
    Friend WithEvents nomInq As DataGridViewTextBoxColumn
    Friend WithEvents dtLoc As DataGridViewTextBoxColumn
    Friend WithEvents IsAtivo As DataGridViewCheckBoxColumn
    Friend WithEvents dtp As DataGridViewTextBoxColumn
    Friend WithEvents dtf As DataGridViewTextBoxColumn
    Friend WithEvents pagloc As DataGridViewTextBoxColumn
    Friend WithEvents cdproprietario As DataGridViewTextBoxColumn
    Friend WithEvents NomeProp As DataGridViewTextBoxColumn
    Friend WithEvents pnlProp As Panel
    Friend WithEvents txtNovo As Label
    Friend WithEvents txtSalvar As Label
    Friend WithEvents txtDeletar As Label
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnNv As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btImo As Button
    Friend WithEvents lblmo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblInq As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpIni As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFim As Label
    Friend WithEvents dtpFim As DateTimePicker
    Friend WithEvents cbxAtiva As CheckBox
    Friend WithEvents txtCancelar As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtPag As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDP As NumericUpDown
End Class

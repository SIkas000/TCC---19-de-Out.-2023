<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vistorias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.codigoDaVistoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruaImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NmImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtVist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docVist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpVist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descVist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.txtNovo = New System.Windows.Forms.Label()
        Me.txtSalvar = New System.Windows.Forms.Label()
        Me.txtDeletar = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btAbrir = New System.Windows.Forms.Button()
        Me.btCaminho = New System.Windows.Forms.Button()
        Me.lblCaminho = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rtbObs = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.dtpVist = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btImo = New System.Windows.Forms.Button()
        Me.lblImo = New System.Windows.Forms.Label()
        Me.pnlHolder = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btEve = New System.Windows.Forms.Button()
        Me.txtCancelar = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnNv = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.cbxOcultar = New System.Windows.Forms.CheckBox()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(43, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 30)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Pesquisar vistoria pela rua do imóvel"
        '
        'TxtTexto
        '
        Me.TxtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTexto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTexto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(48, 60)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1157, 35)
        Me.TxtTexto.TabIndex = 87
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoDaVistoria, Me.cdImo, Me.ruaImo, Me.NmImo, Me.compImo, Me.dtVist, Me.docVist, Me.tpVist, Me.descVist})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(48, 112)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1157, 369)
        Me.DgdGrade.TabIndex = 86
        '
        'codigoDaVistoria
        '
        Me.codigoDaVistoria.HeaderText = "cdVist"
        Me.codigoDaVistoria.Name = "codigoDaVistoria"
        Me.codigoDaVistoria.ReadOnly = True
        Me.codigoDaVistoria.Visible = False
        '
        'cdImo
        '
        Me.cdImo.HeaderText = "CodigoDoImovel"
        Me.cdImo.Name = "cdImo"
        Me.cdImo.ReadOnly = True
        Me.cdImo.Visible = False
        '
        'ruaImo
        '
        Me.ruaImo.HeaderText = "Rua do Imovel"
        Me.ruaImo.Name = "ruaImo"
        Me.ruaImo.ReadOnly = True
        '
        'NmImo
        '
        Me.NmImo.HeaderText = "Numero do imovel"
        Me.NmImo.Name = "NmImo"
        Me.NmImo.ReadOnly = True
        '
        'compImo
        '
        Me.compImo.HeaderText = "Complemento do imovel"
        Me.compImo.Name = "compImo"
        Me.compImo.ReadOnly = True
        '
        'dtVist
        '
        Me.dtVist.HeaderText = "Data da vistoria"
        Me.dtVist.Name = "dtVist"
        Me.dtVist.ReadOnly = True
        '
        'docVist
        '
        Me.docVist.HeaderText = "Caminho do documento"
        Me.docVist.Name = "docVist"
        Me.docVist.ReadOnly = True
        Me.docVist.Visible = False
        '
        'tpVist
        '
        Me.tpVist.HeaderText = "Tipo de vistoria"
        Me.tpVist.Name = "tpVist"
        Me.tpVist.ReadOnly = True
        '
        'descVist
        '
        Me.descVist.HeaderText = "Descrição da vistoria"
        Me.descVist.Name = "descVist"
        Me.descVist.ReadOnly = True
        Me.descVist.Visible = False
        '
        'OFD
        '
        Me.OFD.FileName = "OFD"
        '
        'txtNovo
        '
        Me.txtNovo.AutoSize = True
        Me.txtNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovo.ForeColor = System.Drawing.Color.Black
        Me.txtNovo.Location = New System.Drawing.Point(210, 521)
        Me.txtNovo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtNovo.Name = "txtNovo"
        Me.txtNovo.Size = New System.Drawing.Size(33, 13)
        Me.txtNovo.TabIndex = 152
        Me.txtNovo.Text = "Novo"
        '
        'txtSalvar
        '
        Me.txtSalvar.AutoSize = True
        Me.txtSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalvar.ForeColor = System.Drawing.Color.Black
        Me.txtSalvar.Location = New System.Drawing.Point(276, 523)
        Me.txtSalvar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtSalvar.Name = "txtSalvar"
        Me.txtSalvar.Size = New System.Drawing.Size(37, 13)
        Me.txtSalvar.TabIndex = 151
        Me.txtSalvar.Text = "Salvar"
        '
        'txtDeletar
        '
        Me.txtDeletar.AutoSize = True
        Me.txtDeletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeletar.ForeColor = System.Drawing.Color.Black
        Me.txtDeletar.Location = New System.Drawing.Point(341, 523)
        Me.txtDeletar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtDeletar.Name = "txtDeletar"
        Me.txtDeletar.Size = New System.Drawing.Size(41, 13)
        Me.txtDeletar.TabIndex = 150
        Me.txtDeletar.Text = "Deletar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(17, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(256, 30)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "Cadastro de Funcionários"
        '
        'btAbrir
        '
        Me.btAbrir.BackColor = System.Drawing.Color.White
        Me.btAbrir.BackgroundImage = Global.SGI.My.Resources.Resources.abrirdocumento_165_45
        Me.btAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btAbrir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAbrir.ForeColor = System.Drawing.Color.Black
        Me.btAbrir.Location = New System.Drawing.Point(225, 196)
        Me.btAbrir.Name = "btAbrir"
        Me.btAbrir.Size = New System.Drawing.Size(165, 47)
        Me.btAbrir.TabIndex = 166
        Me.btAbrir.UseVisualStyleBackColor = False
        '
        'btCaminho
        '
        Me.btCaminho.BackColor = System.Drawing.Color.White
        Me.btCaminho.BackgroundImage = Global.SGI.My.Resources.Resources.pesquisarcaminho_165_45
        Me.btCaminho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btCaminho.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCaminho.ForeColor = System.Drawing.Color.Black
        Me.btCaminho.Location = New System.Drawing.Point(45, 196)
        Me.btCaminho.Name = "btCaminho"
        Me.btCaminho.Size = New System.Drawing.Size(171, 47)
        Me.btCaminho.TabIndex = 164
        Me.btCaminho.UseVisualStyleBackColor = False
        '
        'lblCaminho
        '
        Me.lblCaminho.AutoSize = True
        Me.lblCaminho.BackColor = System.Drawing.Color.Transparent
        Me.lblCaminho.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaminho.ForeColor = System.Drawing.Color.Black
        Me.lblCaminho.Location = New System.Drawing.Point(51, 167)
        Me.lblCaminho.Name = "lblCaminho"
        Me.lblCaminho.Size = New System.Drawing.Size(349, 17)
        Me.lblCaminho.TabIndex = 165
        Me.lblCaminho.Text = "Selecione o caminho do documento pelo botão abaixo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(632, 56)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 20)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "Observações"
        '
        'rtbObs
        '
        Me.rtbObs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbObs.Location = New System.Drawing.Point(636, 88)
        Me.rtbObs.Name = "rtbObs"
        Me.rtbObs.Size = New System.Drawing.Size(301, 127)
        Me.rtbObs.TabIndex = 162
        Me.rtbObs.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(444, 161)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Tipo de vistoria"
        '
        'cbxTipo
        '
        Me.cbxTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"saida", "pre-disponibilização", "pre-entrega"})
        Me.cbxTipo.Location = New System.Drawing.Point(448, 187)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(167, 29)
        Me.cbxTipo.TabIndex = 159
        '
        'dtpVist
        '
        Me.dtpVist.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVist.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVist.Location = New System.Drawing.Point(448, 92)
        Me.dtpVist.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpVist.Name = "dtpVist"
        Me.dtpVist.Size = New System.Drawing.Size(167, 29)
        Me.dtpVist.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(444, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 23)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Data da vistoria"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(30, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 23)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Código do imóvel:"
        '
        'btImo
        '
        Me.btImo.BackColor = System.Drawing.Color.White
        Me.btImo.BackgroundImage = Global.SGI.My.Resources.Resources.pesquisarcodigodoimovel_303_45
        Me.btImo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btImo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImo.ForeColor = System.Drawing.Color.Black
        Me.btImo.Location = New System.Drawing.Point(56, 111)
        Me.btImo.Name = "btImo"
        Me.btImo.Size = New System.Drawing.Size(310, 45)
        Me.btImo.TabIndex = 155
        Me.btImo.UseVisualStyleBackColor = False
        '
        'lblImo
        '
        Me.lblImo.AutoSize = True
        Me.lblImo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImo.ForeColor = System.Drawing.Color.Black
        Me.lblImo.Location = New System.Drawing.Point(50, 82)
        Me.lblImo.Name = "lblImo"
        Me.lblImo.Size = New System.Drawing.Size(330, 20)
        Me.lblImo.TabIndex = 156
        Me.lblImo.Text = "Pesquise o código do imóvel pelo botão abaixo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlHolder
        '
        Me.pnlHolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHolder.Controls.Add(Me.Label3)
        Me.pnlHolder.Controls.Add(Me.Panel1)
        Me.pnlHolder.Controls.Add(Me.Label18)
        Me.pnlHolder.Controls.Add(Me.btAbrir)
        Me.pnlHolder.Controls.Add(Me.lblImo)
        Me.pnlHolder.Controls.Add(Me.btCaminho)
        Me.pnlHolder.Controls.Add(Me.btImo)
        Me.pnlHolder.Controls.Add(Me.lblCaminho)
        Me.pnlHolder.Controls.Add(Me.Label11)
        Me.pnlHolder.Controls.Add(Me.Label17)
        Me.pnlHolder.Controls.Add(Me.Label5)
        Me.pnlHolder.Controls.Add(Me.rtbObs)
        Me.pnlHolder.Controls.Add(Me.dtpVist)
        Me.pnlHolder.Controls.Add(Me.cbxTipo)
        Me.pnlHolder.Controls.Add(Me.Label1)
        Me.pnlHolder.Location = New System.Drawing.Point(26, 539)
        Me.pnlHolder.Name = "pnlHolder"
        Me.pnlHolder.Size = New System.Drawing.Size(1179, 282)
        Me.pnlHolder.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(50, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 261
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(418, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 240)
        Me.Panel1.TabIndex = 260
        '
        'btEve
        '
        Me.btEve.BackColor = System.Drawing.Color.White
        Me.btEve.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEve.ForeColor = System.Drawing.Color.Black
        Me.btEve.Location = New System.Drawing.Point(48, 488)
        Me.btEve.Name = "btEve"
        Me.btEve.Size = New System.Drawing.Size(137, 48)
        Me.btEve.TabIndex = 214
        Me.btEve.Text = "Ver próximas vistorias"
        Me.btEve.UseVisualStyleBackColor = False
        '
        'txtCancelar
        '
        Me.txtCancelar.AutoSize = True
        Me.txtCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelar.ForeColor = System.Drawing.Color.Black
        Me.txtCancelar.Location = New System.Drawing.Point(404, 524)
        Me.txtCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtCancelar.Name = "txtCancelar"
        Me.txtCancelar.Size = New System.Drawing.Size(50, 13)
        Me.txtCancelar.TabIndex = 216
        Me.txtCancelar.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoDeletar
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(413, 488)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(32, 32)
        Me.btnCancelar.TabIndex = 215
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoLixo
        Me.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeletar.FlatAppearance.BorderSize = 0
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Location = New System.Drawing.Point(346, 488)
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
        Me.btnNv.Location = New System.Drawing.Point(210, 488)
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
        Me.btnSalvar.Location = New System.Drawing.Point(279, 488)
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
        Me.cbxOcultar.Location = New System.Drawing.Point(444, 24)
        Me.cbxOcultar.Name = "cbxOcultar"
        Me.cbxOcultar.Size = New System.Drawing.Size(249, 24)
        Me.cbxOcultar.TabIndex = 217
        Me.cbxOcultar.Text = "Ocultar vistorias passadas?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cbxOcultar.UseVisualStyleBackColor = True
        '
        'Vistorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1330, 788)
        Me.Controls.Add(Me.cbxOcultar)
        Me.Controls.Add(Me.txtCancelar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btEve)
        Me.Controls.Add(Me.pnlHolder)
        Me.Controls.Add(Me.txtNovo)
        Me.Controls.Add(Me.txtSalvar)
        Me.Controls.Add(Me.txtDeletar)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnNv)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.DgdGrade)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vistorias"
        Me.Text = "Vistorias"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHolder.ResumeLayout(False)
        Me.pnlHolder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents codigoDaVistoria As DataGridViewTextBoxColumn
    Friend WithEvents cdImo As DataGridViewTextBoxColumn
    Friend WithEvents ruaImo As DataGridViewTextBoxColumn
    Friend WithEvents NmImo As DataGridViewTextBoxColumn
    Friend WithEvents compImo As DataGridViewTextBoxColumn
    Friend WithEvents dtVist As DataGridViewTextBoxColumn
    Friend WithEvents docVist As DataGridViewTextBoxColumn
    Friend WithEvents tpVist As DataGridViewTextBoxColumn
    Friend WithEvents descVist As DataGridViewTextBoxColumn
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents txtNovo As Label
    Friend WithEvents txtSalvar As Label
    Friend WithEvents txtDeletar As Label
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnNv As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents btAbrir As Button
    Friend WithEvents btCaminho As Button
    Friend WithEvents lblCaminho As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents rtbObs As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents dtpVist As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btImo As Button
    Friend WithEvents lblImo As Label
    Friend WithEvents pnlHolder As Panel
    Friend WithEvents btEve As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCancelar As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxOcultar As CheckBox
End Class

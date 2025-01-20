<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDt = New System.Windows.Forms.DateTimePicker()
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.lblNm = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.cdEve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtEve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmEve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descEve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpEve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImoEve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruaImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcEve = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblEve = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.cbxTp = New System.Windows.Forms.ComboBox()
        Me.rtbDesc = New System.Windows.Forms.RichTextBox()
        Me.btImo = New System.Windows.Forms.Button()
        Me.lblmo = New System.Windows.Forms.Label()
        Me.lblImo = New System.Windows.Forms.Label()
        Me.txtNovo = New System.Windows.Forms.Label()
        Me.txtEdSv = New System.Windows.Forms.Label()
        Me.txtExc = New System.Windows.Forms.Label()
        Me.txtConc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxR = New System.Windows.Forms.ComboBox()
        Me.txtCancelar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btConc = New System.Windows.Forms.Button()
        Me.btExc = New System.Windows.Forms.Button()
        Me.btnNv = New System.Windows.Forms.Button()
        Me.btEdSv = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecione o tipo de evento:"
        '
        'dtpDt
        '
        Me.dtpDt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDt.Location = New System.Drawing.Point(26, 44)
        Me.dtpDt.Name = "dtpDt"
        Me.dtpDt.Size = New System.Drawing.Size(134, 29)
        Me.dtpDt.TabIndex = 7
        '
        'txtNm
        '
        Me.txtNm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm.ForeColor = System.Drawing.Color.Black
        Me.txtNm.Location = New System.Drawing.Point(26, 99)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(394, 29)
        Me.txtNm.TabIndex = 8
        '
        'lblNm
        '
        Me.lblNm.AutoSize = True
        Me.lblNm.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNm.ForeColor = System.Drawing.Color.Black
        Me.lblNm.Location = New System.Drawing.Point(24, 76)
        Me.lblNm.Name = "lblNm"
        Me.lblNm.Size = New System.Drawing.Size(138, 21)
        Me.lblNm.TabIndex = 9
        Me.lblNm.Text = "Nome do evento:"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDt.ForeColor = System.Drawing.Color.Black
        Me.lblDt.Location = New System.Drawing.Point(22, 20)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(126, 21)
        Me.lblDt.TabIndex = 10
        Me.lblDt.Text = "Data do evento:"
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdEve, Me.dtEve, Me.nmEve, Me.descEve, Me.tpEve, Me.ImoEve, Me.ruaImo, Me.ConcEve})
        Me.DgdGrade.Location = New System.Drawing.Point(51, 64)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersVisible = False
        Me.DgdGrade.Size = New System.Drawing.Size(1231, 408)
        Me.DgdGrade.TabIndex = 0
        '
        'cdEve
        '
        Me.cdEve.HeaderText = "Codigo do evento"
        Me.cdEve.Name = "cdEve"
        Me.cdEve.ReadOnly = True
        Me.cdEve.Visible = False
        '
        'dtEve
        '
        Me.dtEve.HeaderText = "Data"
        Me.dtEve.Name = "dtEve"
        Me.dtEve.ReadOnly = True
        '
        'nmEve
        '
        Me.nmEve.HeaderText = "Nome do Evento"
        Me.nmEve.Name = "nmEve"
        Me.nmEve.ReadOnly = True
        '
        'descEve
        '
        Me.descEve.HeaderText = "Descrição do evento"
        Me.descEve.Name = "descEve"
        Me.descEve.ReadOnly = True
        Me.descEve.Visible = False
        '
        'tpEve
        '
        Me.tpEve.HeaderText = "Tipo do evento"
        Me.tpEve.Name = "tpEve"
        Me.tpEve.ReadOnly = True
        '
        'ImoEve
        '
        Me.ImoEve.HeaderText = "Codigo do imovel"
        Me.ImoEve.Name = "ImoEve"
        Me.ImoEve.ReadOnly = True
        Me.ImoEve.Visible = False
        '
        'ruaImo
        '
        Me.ruaImo.HeaderText = "Rua do imovel relacionado"
        Me.ruaImo.Name = "ruaImo"
        Me.ruaImo.ReadOnly = True
        '
        'ConcEve
        '
        Me.ConcEve.HeaderText = "Concluido?"
        Me.ConcEve.Name = "ConcEve"
        Me.ConcEve.ReadOnly = True
        Me.ConcEve.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConcEve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ConcEve.Visible = False
        '
        'lblEve
        '
        Me.lblEve.AutoSize = True
        Me.lblEve.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEve.ForeColor = System.Drawing.Color.Black
        Me.lblEve.Location = New System.Drawing.Point(162, 20)
        Me.lblEve.Name = "lblEve"
        Me.lblEve.Size = New System.Drawing.Size(125, 21)
        Me.lblEve.TabIndex = 12
        Me.lblEve.Text = "Tipo de evento:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Black
        Me.lblDesc.Location = New System.Drawing.Point(22, 131)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(160, 21)
        Me.lblDesc.TabIndex = 14
        Me.lblDesc.Text = "Descrição do evento"
        '
        'cbxTp
        '
        Me.cbxTp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTp.ForeColor = System.Drawing.Color.Black
        Me.cbxTp.FormattingEnabled = True
        Me.cbxTp.Items.AddRange(New Object() {"Vistoria", "Pagamento", "Outro"})
        Me.cbxTp.Location = New System.Drawing.Point(166, 44)
        Me.cbxTp.Name = "cbxTp"
        Me.cbxTp.Size = New System.Drawing.Size(254, 29)
        Me.cbxTp.TabIndex = 15
        '
        'rtbDesc
        '
        Me.rtbDesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDesc.ForeColor = System.Drawing.Color.Black
        Me.rtbDesc.Location = New System.Drawing.Point(26, 155)
        Me.rtbDesc.Name = "rtbDesc"
        Me.rtbDesc.Size = New System.Drawing.Size(394, 88)
        Me.rtbDesc.TabIndex = 16
        Me.rtbDesc.Text = ""
        '
        'btImo
        '
        Me.btImo.BackColor = System.Drawing.SystemColors.Window
        Me.btImo.BackgroundImage = Global.SGI.My.Resources.Resources.pesquisarcodigodoimovel_313_50
        Me.btImo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btImo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImo.ForeColor = System.Drawing.Color.Black
        Me.btImo.Location = New System.Drawing.Point(463, 76)
        Me.btImo.Name = "btImo"
        Me.btImo.Size = New System.Drawing.Size(313, 52)
        Me.btImo.TabIndex = 160
        Me.btImo.UseVisualStyleBackColor = False
        '
        'lblmo
        '
        Me.lblmo.AutoSize = True
        Me.lblmo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmo.ForeColor = System.Drawing.Color.Black
        Me.lblmo.Location = New System.Drawing.Point(470, 44)
        Me.lblmo.Name = "lblmo"
        Me.lblmo.Size = New System.Drawing.Size(306, 17)
        Me.lblmo.TabIndex = 161
        Me.lblmo.Text = "Pesquise o código do imóvel pelo botão abaixo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblImo
        '
        Me.lblImo.AutoSize = True
        Me.lblImo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImo.ForeColor = System.Drawing.Color.Black
        Me.lblImo.Location = New System.Drawing.Point(459, 20)
        Me.lblImo.Name = "lblImo"
        Me.lblImo.Size = New System.Drawing.Size(146, 21)
        Me.lblImo.TabIndex = 162
        Me.lblImo.Text = "Código do imóvel"
        '
        'txtNovo
        '
        Me.txtNovo.AutoSize = True
        Me.txtNovo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovo.ForeColor = System.Drawing.Color.Black
        Me.txtNovo.Location = New System.Drawing.Point(50, 515)
        Me.txtNovo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtNovo.Name = "txtNovo"
        Me.txtNovo.Size = New System.Drawing.Size(35, 13)
        Me.txtNovo.TabIndex = 168
        Me.txtNovo.Text = "Novo"
        '
        'txtEdSv
        '
        Me.txtEdSv.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdSv.ForeColor = System.Drawing.Color.Black
        Me.txtEdSv.Location = New System.Drawing.Point(110, 515)
        Me.txtEdSv.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtEdSv.Name = "txtEdSv"
        Me.txtEdSv.Size = New System.Drawing.Size(39, 14)
        Me.txtEdSv.TabIndex = 167
        Me.txtEdSv.Text = "Editar"
        '
        'txtExc
        '
        Me.txtExc.AutoSize = True
        Me.txtExc.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExc.ForeColor = System.Drawing.Color.Black
        Me.txtExc.Location = New System.Drawing.Point(176, 514)
        Me.txtExc.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtExc.Name = "txtExc"
        Me.txtExc.Size = New System.Drawing.Size(40, 13)
        Me.txtExc.TabIndex = 166
        Me.txtExc.Text = "Excluir"
        '
        'txtConc
        '
        Me.txtConc.AutoSize = True
        Me.txtConc.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConc.ForeColor = System.Drawing.Color.Black
        Me.txtConc.Location = New System.Drawing.Point(236, 514)
        Me.txtConc.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtConc.Name = "txtConc"
        Me.txtConc.Size = New System.Drawing.Size(48, 13)
        Me.txtConc.TabIndex = 170
        Me.txtConc.Text = "Concluir"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblDt)
        Me.Panel1.Controls.Add(Me.dtpDt)
        Me.Panel1.Controls.Add(Me.txtNm)
        Me.Panel1.Controls.Add(Me.lblNm)
        Me.Panel1.Controls.Add(Me.lblEve)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.cbxTp)
        Me.Panel1.Controls.Add(Me.rtbDesc)
        Me.Panel1.Controls.Add(Me.lblmo)
        Me.Panel1.Controls.Add(Me.btImo)
        Me.Panel1.Controls.Add(Me.lblImo)
        Me.Panel1.Location = New System.Drawing.Point(24, 531)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1258, 256)
        Me.Panel1.TabIndex = 171
        '
        'cbxR
        '
        Me.cbxR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxR.Enabled = False
        Me.cbxR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxR.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxR.FormattingEnabled = True
        Me.cbxR.Items.AddRange(New Object() {"Qualquer tipo", "Vistoria", "Pagamento", "Outro", "Pagamento de aluguel pendente"})
        Me.cbxR.Location = New System.Drawing.Point(332, 17)
        Me.cbxR.Name = "cbxR"
        Me.cbxR.Size = New System.Drawing.Size(226, 29)
        Me.cbxR.TabIndex = 172
        '
        'txtCancelar
        '
        Me.txtCancelar.AutoSize = True
        Me.txtCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelar.ForeColor = System.Drawing.Color.Black
        Me.txtCancelar.Location = New System.Drawing.Point(306, 518)
        Me.txtCancelar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtCancelar.Name = "txtCancelar"
        Me.txtCancelar.Size = New System.Drawing.Size(50, 13)
        Me.txtCancelar.TabIndex = 174
        Me.txtCancelar.Text = "Cancelar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(564, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(442, 17)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Aviso: Mostrando apenas eventos relacionado com o imovel de codigo "
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.SGI.My.Resources.Resources.IcoDeletar
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(315, 479)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(32, 32)
        Me.btnCancelar.TabIndex = 173
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btConc
        '
        Me.btConc.BackgroundImage = Global.SGI.My.Resources.Resources.IcoSalvar
        Me.btConc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btConc.FlatAppearance.BorderSize = 0
        Me.btConc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConc.Location = New System.Drawing.Point(244, 479)
        Me.btConc.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btConc.Name = "btConc"
        Me.btConc.Size = New System.Drawing.Size(32, 32)
        Me.btConc.TabIndex = 169
        Me.btConc.UseVisualStyleBackColor = True
        '
        'btExc
        '
        Me.btExc.BackgroundImage = Global.SGI.My.Resources.Resources.IcoLixo
        Me.btExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btExc.FlatAppearance.BorderSize = 0
        Me.btExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExc.Location = New System.Drawing.Point(179, 479)
        Me.btExc.Name = "btExc"
        Me.btExc.Size = New System.Drawing.Size(32, 32)
        Me.btExc.TabIndex = 163
        Me.btExc.UseVisualStyleBackColor = True
        '
        'btnNv
        '
        Me.btnNv.BackgroundImage = Global.SGI.My.Resources.Resources.IcoAdd
        Me.btnNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNv.FlatAppearance.BorderSize = 0
        Me.btnNv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNv.Location = New System.Drawing.Point(51, 479)
        Me.btnNv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNv.Name = "btnNv"
        Me.btnNv.Size = New System.Drawing.Size(32, 32)
        Me.btnNv.TabIndex = 164
        Me.btnNv.UseVisualStyleBackColor = True
        '
        'btEdSv
        '
        Me.btEdSv.BackgroundImage = Global.SGI.My.Resources.Resources.icoEditar
        Me.btEdSv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btEdSv.FlatAppearance.BorderSize = 0
        Me.btEdSv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEdSv.Location = New System.Drawing.Point(113, 479)
        Me.btEdSv.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btEdSv.Name = "btEdSv"
        Me.btEdSv.Size = New System.Drawing.Size(32, 32)
        Me.btEdSv.TabIndex = 165
        Me.btEdSv.UseVisualStyleBackColor = True
        '
        'Calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1330, 788)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCancelar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.cbxR)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtConc)
        Me.Controls.Add(Me.btConc)
        Me.Controls.Add(Me.txtNovo)
        Me.Controls.Add(Me.txtEdSv)
        Me.Controls.Add(Me.txtExc)
        Me.Controls.Add(Me.btExc)
        Me.Controls.Add(Me.btnNv)
        Me.Controls.Add(Me.btEdSv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calendario"
        Me.Text = "Calendario"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDt As DateTimePicker
    Friend WithEvents txtNm As TextBox
    Friend WithEvents lblNm As Label
    Friend WithEvents lblDt As Label
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents lblEve As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents cbxTp As ComboBox
    Friend WithEvents rtbDesc As RichTextBox
    Friend WithEvents btImo As Button
    Friend WithEvents lblmo As Label
    Friend WithEvents lblImo As Label
    Friend WithEvents cdEve As DataGridViewTextBoxColumn
    Friend WithEvents dtEve As DataGridViewTextBoxColumn
    Friend WithEvents nmEve As DataGridViewTextBoxColumn
    Friend WithEvents descEve As DataGridViewTextBoxColumn
    Friend WithEvents tpEve As DataGridViewTextBoxColumn
    Friend WithEvents ImoEve As DataGridViewTextBoxColumn
    Friend WithEvents ruaImo As DataGridViewTextBoxColumn
    Friend WithEvents ConcEve As DataGridViewCheckBoxColumn
    Friend WithEvents txtNovo As Label
    Friend WithEvents txtEdSv As Label
    Friend WithEvents txtExc As Label
    Friend WithEvents btExc As Button
    Friend WithEvents btnNv As Button
    Friend WithEvents btEdSv As Button
    Friend WithEvents txtConc As Label
    Friend WithEvents btConc As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbxR As ComboBox
    Friend WithEvents txtCancelar As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label2 As Label
End Class

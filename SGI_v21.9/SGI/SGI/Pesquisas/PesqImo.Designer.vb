<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PesqImo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.cdfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sabesp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aluguel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valPref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorVen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.regIPTU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valIPTU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdprop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeProp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Rua", "CEP", "Nome do Proprietário"})
        Me.ComboBox2.Location = New System.Drawing.Point(253, 17)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(210, 29)
        Me.ComboBox2.TabIndex = 81
        '
        'TxtTexto
        '
        Me.TxtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTexto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTexto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(38, 60)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1285, 35)
        Me.TxtTexto.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(33, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 30)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Pesquisar imóvel por:"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgdGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgdGrade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgdGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdfun, Me.cep, Me.num, Me.comp, Me.sabesp, Me.enel, Me.aluguel, Me.valPref, Me.valorVen, Me.regIPTU, Me.valIPTU, Me.Obs, Me.rua, Me.bairro, Me.cidade, Me.Uf, Me.estado, Me.cdprop, Me.nomeProp})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(38, 102)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1285, 469)
        Me.DgdGrade.TabIndex = 82
        '
        'cdfun
        '
        Me.cdfun.HeaderText = "codigo"
        Me.cdfun.Name = "cdfun"
        Me.cdfun.ReadOnly = True
        Me.cdfun.Visible = False
        '
        'cep
        '
        Me.cep.FillWeight = 120.0074!
        Me.cep.HeaderText = "CEP"
        Me.cep.Name = "cep"
        Me.cep.ReadOnly = True
        '
        'num
        '
        Me.num.FillWeight = 72.59808!
        Me.num.HeaderText = "Número"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        '
        'comp
        '
        Me.comp.FillWeight = 92.38582!
        Me.comp.HeaderText = "Complemento"
        Me.comp.Name = "comp"
        Me.comp.ReadOnly = True
        '
        'sabesp
        '
        Me.sabesp.FillWeight = 67.39197!
        Me.sabesp.HeaderText = "Sabesp"
        Me.sabesp.Name = "sabesp"
        Me.sabesp.ReadOnly = True
        '
        'enel
        '
        Me.enel.FillWeight = 70.0628!
        Me.enel.HeaderText = "Enel"
        Me.enel.Name = "enel"
        Me.enel.ReadOnly = True
        '
        'aluguel
        '
        Me.aluguel.FillWeight = 120.0074!
        Me.aluguel.HeaderText = "Aluguel "
        Me.aluguel.Name = "aluguel"
        Me.aluguel.ReadOnly = True
        '
        'valPref
        '
        Me.valPref.HeaderText = "Valor na prefeitura"
        Me.valPref.Name = "valPref"
        Me.valPref.ReadOnly = True
        '
        'valorVen
        '
        Me.valorVen.FillWeight = 120.0074!
        Me.valorVen.HeaderText = "Valor de venda"
        Me.valorVen.Name = "valorVen"
        Me.valorVen.ReadOnly = True
        '
        'regIPTU
        '
        Me.regIPTU.HeaderText = "Registro do IPTU"
        Me.regIPTU.Name = "regIPTU"
        Me.regIPTU.ReadOnly = True
        '
        'valIPTU
        '
        Me.valIPTU.HeaderText = "Valor do IPTU"
        Me.valIPTU.Name = "valIPTU"
        Me.valIPTU.ReadOnly = True
        '
        'Obs
        '
        Me.Obs.HeaderText = "Observações"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Visible = False
        '
        'rua
        '
        Me.rua.FillWeight = 120.0074!
        Me.rua.HeaderText = "Rua"
        Me.rua.Name = "rua"
        Me.rua.ReadOnly = True
        '
        'bairro
        '
        Me.bairro.FillWeight = 120.0074!
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.Name = "bairro"
        Me.bairro.ReadOnly = True
        '
        'cidade
        '
        Me.cidade.FillWeight = 120.0074!
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.Name = "cidade"
        Me.cidade.ReadOnly = True
        '
        'Uf
        '
        Me.Uf.FillWeight = 37.5023!
        Me.Uf.HeaderText = "UF"
        Me.Uf.Name = "Uf"
        Me.Uf.ReadOnly = True
        '
        'estado
        '
        Me.estado.FillWeight = 120.0074!
        Me.estado.HeaderText = "Estado atual"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'cdprop
        '
        Me.cdprop.HeaderText = "cdprop"
        Me.cdprop.Name = "cdprop"
        Me.cdprop.ReadOnly = True
        Me.cdprop.Visible = False
        '
        'nomeProp
        '
        Me.nomeProp.FillWeight = 120.0074!
        Me.nomeProp.HeaderText = "Nome do Proprietário"
        Me.nomeProp.Name = "nomeProp"
        Me.nomeProp.ReadOnly = True
        '
        'PesqImo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1355, 613)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.Label2)
        Me.Name = "PesqImo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa de Imóveis"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents cdfun As DataGridViewTextBoxColumn
    Friend WithEvents cep As DataGridViewTextBoxColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents comp As DataGridViewTextBoxColumn
    Friend WithEvents sabesp As DataGridViewTextBoxColumn
    Friend WithEvents enel As DataGridViewTextBoxColumn
    Friend WithEvents aluguel As DataGridViewTextBoxColumn
    Friend WithEvents valPref As DataGridViewTextBoxColumn
    Friend WithEvents valorVen As DataGridViewTextBoxColumn
    Friend WithEvents regIPTU As DataGridViewTextBoxColumn
    Friend WithEvents valIPTU As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents rua As DataGridViewTextBoxColumn
    Friend WithEvents bairro As DataGridViewTextBoxColumn
    Friend WithEvents cidade As DataGridViewTextBoxColumn
    Friend WithEvents Uf As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents cdprop As DataGridViewTextBoxColumn
    Friend WithEvents nomeProp As DataGridViewTextBoxColumn
End Class

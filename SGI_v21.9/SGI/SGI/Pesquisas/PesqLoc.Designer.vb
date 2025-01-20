<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PesqLoc
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
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Nome do inquilino", "Rua do imovel", "Nome do proprietário"})
        Me.ComboBox2.Location = New System.Drawing.Point(250, 31)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(322, 29)
        Me.ComboBox2.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 30)
        Me.Label2.TabIndex = 103
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
        Me.TxtTexto.Location = New System.Drawing.Point(17, 73)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1207, 35)
        Me.TxtTexto.TabIndex = 102
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
        Me.DgdGrade.ColumnHeadersHeight = 35
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoDoImovel, Me.ruaImo, Me.codinquilino, Me.nomInq, Me.dtLoc, Me.IsAtivo, Me.dtp, Me.dtf, Me.pagloc, Me.cdproprietario, Me.NomeProp})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(17, 131)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1207, 497)
        Me.DgdGrade.TabIndex = 101
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
        'PesqLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1238, 641)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.DgdGrade)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PesqLoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa de Locação"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
End Class

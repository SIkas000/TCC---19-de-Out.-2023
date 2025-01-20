<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.dtp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagloc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoDoImovel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruaImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codinquilino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomInq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdproprietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btAlugueis = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtp, Me.pagloc, Me.codigoDoImovel, Me.ruaImo, Me.codinquilino, Me.nomInq, Me.dtLoc, Me.cdproprietario, Me.NomeProp})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(12, 186)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1160, 391)
        Me.DgdGrade.TabIndex = 163
        '
        'dtp
        '
        Me.dtp.HeaderText = "Dia do mês do pagamento"
        Me.dtp.Name = "dtp"
        Me.dtp.ReadOnly = True
        Me.dtp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pagloc
        '
        Me.pagloc.HeaderText = "Pagamento acordado"
        Me.pagloc.Name = "pagloc"
        Me.pagloc.ReadOnly = True
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
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 30)
        Me.Label2.TabIndex = 165
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
        Me.TxtTexto.Location = New System.Drawing.Point(12, 130)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1160, 35)
        Me.TxtTexto.TabIndex = 164
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Nome do inquilino", "Rua do imovel", "Nome do proprietário"})
        Me.ComboBox2.Location = New System.Drawing.Point(241, 92)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(259, 28)
        Me.ComboBox2.TabIndex = 166
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.SGI.My.Resources.Resources.btnEstatisticas
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(302, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 59)
        Me.Button1.TabIndex = 162
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btAlugueis
        '
        Me.btAlugueis.BackColor = System.Drawing.Color.White
        Me.btAlugueis.BackgroundImage = Global.SGI.My.Resources.Resources.btnCadPag
        Me.btAlugueis.FlatAppearance.BorderSize = 0
        Me.btAlugueis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlugueis.ForeColor = System.Drawing.Color.Black
        Me.btAlugueis.Location = New System.Drawing.Point(12, 12)
        Me.btAlugueis.Name = "btAlugueis"
        Me.btAlugueis.Size = New System.Drawing.Size(280, 60)
        Me.btAlugueis.TabIndex = 161
        Me.btAlugueis.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1209, 642)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btAlugueis)
        Me.Name = "Status"
        Me.Text = "Status"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAlugueis As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents dtp As DataGridViewTextBoxColumn
    Friend WithEvents pagloc As DataGridViewTextBoxColumn
    Friend WithEvents codigoDoImovel As DataGridViewTextBoxColumn
    Friend WithEvents ruaImo As DataGridViewTextBoxColumn
    Friend WithEvents codinquilino As DataGridViewTextBoxColumn
    Friend WithEvents nomInq As DataGridViewTextBoxColumn
    Friend WithEvents dtLoc As DataGridViewTextBoxColumn
    Friend WithEvents cdproprietario As DataGridViewTextBoxColumn
    Friend WithEvents NomeProp As DataGridViewTextBoxColumn
End Class

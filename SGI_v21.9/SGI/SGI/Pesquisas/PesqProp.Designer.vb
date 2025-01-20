<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesqProp
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
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTexto
        '
        Me.TxtTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTexto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTexto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(33, 68)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(1050, 35)
        Me.TxtTexto.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(28, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(470, 30)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Digite o nome do proprietário para localizá-lo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdfun, Me.nmfun, Me.rg, Me.cpf, Me.email, Me.tel, Me.nmBanco, Me.agencia, Me.corrente, Me.popanca, Me.pix})
        Me.DgdGrade.GridColor = System.Drawing.Color.Black
        Me.DgdGrade.Location = New System.Drawing.Point(33, 130)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.RowHeadersWidth = 20
        Me.DgdGrade.Size = New System.Drawing.Size(1050, 394)
        Me.DgdGrade.TabIndex = 72
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
        Me.nmfun.FillWeight = 149.9682!
        Me.nmfun.HeaderText = "Nome"
        Me.nmfun.Name = "nmfun"
        Me.nmfun.ReadOnly = True
        '
        'rg
        '
        Me.rg.FillWeight = 124.1605!
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        '
        'cpf
        '
        Me.cpf.FillWeight = 124.1605!
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        '
        'email
        '
        Me.email.FillWeight = 124.1605!
        Me.email.HeaderText = "E-Mail"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'tel
        '
        Me.tel.FillWeight = 124.1605!
        Me.tel.HeaderText = "Telefone"
        Me.tel.Name = "tel"
        Me.tel.ReadOnly = True
        '
        'nmBanco
        '
        Me.nmBanco.FillWeight = 92.09708!
        Me.nmBanco.HeaderText = "Nome do Banco"
        Me.nmBanco.Name = "nmBanco"
        Me.nmBanco.ReadOnly = True
        '
        'agencia
        '
        Me.agencia.FillWeight = 58.04177!
        Me.agencia.HeaderText = "Agencia"
        Me.agencia.Name = "agencia"
        Me.agencia.ReadOnly = True
        '
        'corrente
        '
        Me.corrente.FillWeight = 54.50601!
        Me.corrente.HeaderText = "Conta Corrente"
        Me.corrente.Name = "corrente"
        Me.corrente.ReadOnly = True
        '
        'popanca
        '
        Me.popanca.FillWeight = 65.98983!
        Me.popanca.HeaderText = "Poupança"
        Me.popanca.Name = "popanca"
        Me.popanca.ReadOnly = True
        '
        'pix
        '
        Me.pix.FillWeight = 82.75492!
        Me.pix.HeaderText = "Pix"
        Me.pix.Name = "pix"
        Me.pix.ReadOnly = True
        '
        'PesqProp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1113, 550)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgdGrade)
        Me.Name = "PesqProp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa de Proprietário"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgdGrade As DataGridView
    Friend WithEvents cdfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nmfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nmBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents agencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents corrente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents popanca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pix As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistPag
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
        Me.cdpag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdInq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruaImo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmInq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtIniLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCalc = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdpag, Me.cdInq, Me.cdImo, Me.ruaImo, Me.nmInq, Me.dtIniLoc, Me.dtPag})
        Me.DgdGrade.Location = New System.Drawing.Point(15, 34)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.Size = New System.Drawing.Size(870, 292)
        Me.DgdGrade.TabIndex = 203
        '
        'cdpag
        '
        Me.cdpag.HeaderText = "Codigo do pagamento"
        Me.cdpag.Name = "cdpag"
        Me.cdpag.ReadOnly = True
        Me.cdpag.Visible = False
        '
        'cdInq
        '
        Me.cdInq.HeaderText = "Codigo do inquilino"
        Me.cdInq.Name = "cdInq"
        Me.cdInq.ReadOnly = True
        Me.cdInq.Visible = False
        '
        'cdImo
        '
        Me.cdImo.HeaderText = "Codigo do imovel"
        Me.cdImo.Name = "cdImo"
        Me.cdImo.ReadOnly = True
        Me.cdImo.Visible = False
        '
        'ruaImo
        '
        Me.ruaImo.HeaderText = "Rua do imovel"
        Me.ruaImo.Name = "ruaImo"
        Me.ruaImo.ReadOnly = True
        '
        'nmInq
        '
        Me.nmInq.HeaderText = "Nome do inquilino"
        Me.nmInq.Name = "nmInq"
        Me.nmInq.ReadOnly = True
        '
        'dtIniLoc
        '
        Me.dtIniLoc.HeaderText = "Data de início da locação"
        Me.dtIniLoc.Name = "dtIniLoc"
        Me.dtIniLoc.ReadOnly = True
        '
        'dtPag
        '
        Me.dtPag.HeaderText = "Data do pagamento"
        Me.dtPag.Name = "dtPag"
        Me.dtPag.ReadOnly = True
        '
        'dtpIni
        '
        Me.dtpIni.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIni.Location = New System.Drawing.Point(91, 393)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(122, 29)
        Me.dtpIni.TabIndex = 204
        '
        'dtpFim
        '
        Me.dtpFim.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFim.Location = New System.Drawing.Point(91, 424)
        Me.dtpFim.Name = "dtpFim"
        Me.dtpFim.Size = New System.Drawing.Size(122, 29)
        Me.dtpFim.TabIndex = 205
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(833, 50)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Quanto foi coletado de aluguel entre: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Obs: os alugueis sempre são registrados " &
    "no primeiro dia do mês que o pagamento foi efetuado)"
        '
        'btCalc
        '
        Me.btCalc.BackColor = System.Drawing.Color.White
        Me.btCalc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalc.Location = New System.Drawing.Point(219, 401)
        Me.btCalc.Name = "btCalc"
        Me.btCalc.Size = New System.Drawing.Size(185, 47)
        Me.btCalc.TabIndex = 207
        Me.btCalc.Text = "Calcular"
        Me.btCalc.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Início:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 21)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Final:"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.ForeColor = System.Drawing.Color.Black
        Me.lblR.Location = New System.Drawing.Point(15, 466)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(83, 20)
        Me.lblR.TabIndex = 210
        Me.lblR.Text = "Resultado:"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SGI.My.Resources.Resources.iconSetaEsquerda
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 26)
        Me.Button2.TabIndex = 211
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HistPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(897, 567)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFim)
        Me.Controls.Add(Me.dtpIni)
        Me.Controls.Add(Me.DgdGrade)
        Me.Name = "HistPag"
        Me.Text = "HistPag"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents cdpag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdInq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdImo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruaImo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nmInq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtIniLoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtPag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpIni As DateTimePicker
    Friend WithEvents dtpFim As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btCalc As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Button2 As Button
End Class

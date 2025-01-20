<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boleto
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
        Me.cbxM = New System.Windows.Forms.CheckBox()
        Me.txtNum = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.NumericUpDown()
        Me.txtObs = New System.Windows.Forms.RichTextBox()
        Me.btCepValidate = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.btnGerarPDF = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        CType(Me.txtNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxM
        '
        Me.cbxM.AutoSize = True
        Me.cbxM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbxM.Location = New System.Drawing.Point(254, 34)
        Me.cbxM.Name = "cbxM"
        Me.cbxM.Size = New System.Drawing.Size(182, 25)
        Me.cbxM.TabIndex = 298
        Me.cbxM.Text = "Cobrar multa de 20%"
        Me.cbxM.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.ForeColor = System.Drawing.Color.Black
        Me.txtNum.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNum.Location = New System.Drawing.Point(254, 143)
        Me.txtNum.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(196, 29)
        Me.txtNum.TabIndex = 296
        Me.txtNum.ThousandsSeparator = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(253, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 295
        Me.Label2.Tag = "1"
        Me.Label2.Text = "Complemento"
        '
        'txtComp
        '
        Me.txtComp.BackColor = System.Drawing.SystemColors.Window
        Me.txtComp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComp.ForeColor = System.Drawing.Color.Black
        Me.txtComp.Location = New System.Drawing.Point(254, 203)
        Me.txtComp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(196, 29)
        Me.txtComp.TabIndex = 294
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(253, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 293
        Me.Label3.Tag = "1"
        Me.Label3.Text = "Número "
        '
        'mskCep
        '
        Me.mskCep.BackColor = System.Drawing.SystemColors.Window
        Me.mskCep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCep.ForeColor = System.Drawing.Color.Black
        Me.mskCep.Location = New System.Drawing.Point(15, 88)
        Me.mskCep.Mask = "00000-999"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(166, 29)
        Me.mskCep.TabIndex = 291
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 21)
        Me.Label5.TabIndex = 290
        Me.Label5.Tag = "1"
        Me.Label5.Text = "CEP do pagante"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 236)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 21)
        Me.Label6.TabIndex = 289
        Me.Label6.Tag = "1"
        Me.Label6.Text = "Observações"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 21)
        Me.Label4.TabIndex = 288
        Me.Label4.Tag = "1"
        Me.Label4.Text = "CPF/CNPJ do pagante"
        '
        'txtCpf
        '
        Me.txtCpf.BackColor = System.Drawing.SystemColors.Window
        Me.txtCpf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.ForeColor = System.Drawing.Color.Black
        Me.txtCpf.Location = New System.Drawing.Point(15, 203)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(199, 29)
        Me.txtCpf.TabIndex = 287
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 286
        Me.Label1.Tag = "1"
        Me.Label1.Text = "Nome do pagante"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.SystemColors.Window
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.ForeColor = System.Drawing.Color.Black
        Me.txtNom.Location = New System.Drawing.Point(15, 148)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(199, 29)
        Me.txtNom.TabIndex = 285
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(14, 9)
        Me.Label37.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(124, 21)
        Me.Label37.TabIndex = 284
        Me.Label37.Tag = "1"
        Me.Label37.Text = "Valor do boleto"
        '
        'txtVal
        '
        Me.txtVal.DecimalPlaces = 2
        Me.txtVal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVal.ForeColor = System.Drawing.Color.Black
        Me.txtVal.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVal.Location = New System.Drawing.Point(15, 33)
        Me.txtVal.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(199, 29)
        Me.txtVal.TabIndex = 283
        Me.txtVal.ThousandsSeparator = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(15, 260)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(435, 96)
        Me.txtObs.TabIndex = 282
        Me.txtObs.Text = ""
        '
        'btCepValidate
        '
        Me.btCepValidate.BackgroundImage = Global.SGI.My.Resources.Resources.IcoProcurar
        Me.btCepValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btCepValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCepValidate.ForeColor = System.Drawing.Color.Black
        Me.btCepValidate.Location = New System.Drawing.Point(187, 88)
        Me.btCepValidate.Name = "btCepValidate"
        Me.btCepValidate.Size = New System.Drawing.Size(27, 27)
        Me.btCepValidate.TabIndex = 292
        Me.btCepValidate.UseVisualStyleBackColor = True
        '
        'BtnLoc
        '
        Me.BtnLoc.BackColor = System.Drawing.Color.White
        Me.BtnLoc.BackgroundImage = Global.SGI.My.Resources.Resources.btnLocacao
        Me.BtnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLoc.FlatAppearance.BorderSize = 0
        Me.BtnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.ForeColor = System.Drawing.Color.Black
        Me.BtnLoc.Location = New System.Drawing.Point(316, 375)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(134, 50)
        Me.BtnLoc.TabIndex = 281
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.White
        Me.BtnImprimir.BackgroundImage = Global.SGI.My.Resources.Resources.btnImprimir
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.ForeColor = System.Drawing.Color.Black
        Me.BtnImprimir.Location = New System.Drawing.Point(170, 375)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(134, 50)
        Me.BtnImprimir.TabIndex = 280
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'btnGerarPDF
        '
        Me.btnGerarPDF.BackColor = System.Drawing.Color.White
        Me.btnGerarPDF.BackgroundImage = Global.SGI.My.Resources.Resources.btnPDF
        Me.btnGerarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGerarPDF.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGerarPDF.FlatAppearance.BorderSize = 0
        Me.btnGerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerarPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerarPDF.ForeColor = System.Drawing.Color.Black
        Me.btnGerarPDF.Location = New System.Drawing.Point(15, 375)
        Me.btnGerarPDF.Name = "btnGerarPDF"
        Me.btnGerarPDF.Size = New System.Drawing.Size(140, 50)
        Me.btnGerarPDF.TabIndex = 279
        Me.btnGerarPDF.UseVisualStyleBackColor = False
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Boleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 517)
        Me.Controls.Add(Me.cbxM)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btCepValidate)
        Me.Controls.Add(Me.mskCep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.btnGerarPDF)
        Me.Name = "Boleto"
        Me.Text = "Boleto"
        CType(Me.txtNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxM As CheckBox
    Friend WithEvents txtNum As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtComp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btCepValidate As Button
    Friend WithEvents mskCep As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtVal As NumericUpDown
    Friend WithEvents txtObs As RichTextBox
    Friend WithEvents BtnLoc As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents btnGerarPDF As Button
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents OFD As OpenFileDialog
End Class

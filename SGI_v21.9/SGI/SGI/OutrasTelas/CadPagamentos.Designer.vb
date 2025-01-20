<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadPagamentos
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpPag = New System.Windows.Forms.DateTimePicker()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.lblInq = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btLoc = New System.Windows.Forms.Button()
        Me.lblImo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btTransação = New System.Windows.Forms.Button()
        Me.btHist = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(88, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 25)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Data do pagamento de aluguel"
        '
        'dtpPag
        '
        Me.dtpPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPag.Location = New System.Drawing.Point(126, 214)
        Me.dtpPag.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpPag.Name = "dtpPag"
        Me.dtpPag.Size = New System.Drawing.Size(224, 26)
        Me.dtpPag.TabIndex = 193
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDt.ForeColor = System.Drawing.Color.Black
        Me.lblDt.Location = New System.Drawing.Point(41, 426)
        Me.lblDt.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(334, 17)
        Me.lblDt.TabIndex = 181
        Me.lblDt.Text = "Utilize o botão a baixo para selecionar as informações"
        '
        'lblInq
        '
        Me.lblInq.AutoSize = True
        Me.lblInq.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInq.ForeColor = System.Drawing.Color.Black
        Me.lblInq.Location = New System.Drawing.Point(41, 368)
        Me.lblInq.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblInq.Name = "lblInq"
        Me.lblInq.Size = New System.Drawing.Size(334, 17)
        Me.lblInq.TabIndex = 180
        Me.lblInq.Text = "Utilize o botão a baixo para selecionar as informações"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 406)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Data de início:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 348)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 21)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Código do inquilino:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(29, 284)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 21)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "Código do imóvel:"
        '
        'btLoc
        '
        Me.btLoc.BackColor = System.Drawing.Color.White
        Me.btLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLoc.ForeColor = System.Drawing.Color.Black
        Me.btLoc.Location = New System.Drawing.Point(33, 463)
        Me.btLoc.Margin = New System.Windows.Forms.Padding(5)
        Me.btLoc.Name = "btLoc"
        Me.btLoc.Size = New System.Drawing.Size(410, 58)
        Me.btLoc.TabIndex = 176
        Me.btLoc.Text = "Pesquisar informações da locação"
        Me.btLoc.UseVisualStyleBackColor = False
        '
        'lblImo
        '
        Me.lblImo.AutoSize = True
        Me.lblImo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImo.ForeColor = System.Drawing.Color.Black
        Me.lblImo.Location = New System.Drawing.Point(41, 312)
        Me.lblImo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblImo.Name = "lblImo"
        Me.lblImo.Size = New System.Drawing.Size(334, 17)
        Me.lblImo.TabIndex = 177
        Me.lblImo.Text = "Utilize o botão a baixo para selecionar as informações"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 245)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Informações sobre a locação"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SGI.My.Resources.Resources.iconSetaEsquerda
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 26)
        Me.Button2.TabIndex = 202
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btTransação
        '
        Me.btTransação.BackgroundImage = Global.SGI.My.Resources.Resources.btnPagCad
        Me.btTransação.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTransação.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btTransação.Location = New System.Drawing.Point(243, 64)
        Me.btTransação.Margin = New System.Windows.Forms.Padding(5)
        Me.btTransação.Name = "btTransação"
        Me.btTransação.Size = New System.Drawing.Size(200, 60)
        Me.btTransação.TabIndex = 199
        Me.btTransação.UseVisualStyleBackColor = True
        '
        'btHist
        '
        Me.btHist.BackgroundImage = Global.SGI.My.Resources.Resources.btnMosHis
        Me.btHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btHist.Location = New System.Drawing.Point(33, 64)
        Me.btHist.Margin = New System.Windows.Forms.Padding(5)
        Me.btHist.Name = "btHist"
        Me.btHist.Size = New System.Drawing.Size(200, 60)
        Me.btHist.TabIndex = 177
        Me.btHist.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 34)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "(Obs: os alugueis sempre são registrados no primeiro dia do mês " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que o pagamento" &
    " foi efetuado)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CadPagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(818, 571)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblInq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btTransação)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btLoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblImo)
        Me.Controls.Add(Me.dtpPag)
        Me.Controls.Add(Me.btHist)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "CadPagamentos"
        Me.Text = "Financeiro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btHist As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpPag As DateTimePicker
    Friend WithEvents btTransação As Button
    Friend WithEvents lblDt As Label
    Friend WithEvents lblInq As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btLoc As Button
    Friend WithEvents lblImo As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

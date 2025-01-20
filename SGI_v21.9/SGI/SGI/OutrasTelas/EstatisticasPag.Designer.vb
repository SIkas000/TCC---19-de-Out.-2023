<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EstatisticasPag
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotP = New System.Windows.Forms.Label()
        Me.lblTotN = New System.Windows.Forms.Label()
        Me.lblPag = New System.Windows.Forms.Label()
        Me.lblPagP = New System.Windows.Forms.Label()
        Me.lblPagN = New System.Windows.Forms.Label()
        Me.lblPL = New System.Windows.Forms.Label()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chrLoc = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrPag = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chrLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrPag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estatisiticas das locações:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(28, 99)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(144, 21)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total de locações: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTotP
        '
        Me.lblTotP.AutoSize = True
        Me.lblTotP.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotP.ForeColor = System.Drawing.Color.Black
        Me.lblTotP.Location = New System.Drawing.Point(28, 140)
        Me.lblTotP.Name = "lblTotP"
        Me.lblTotP.Size = New System.Drawing.Size(279, 21)
        Me.lblTotP.TabIndex = 12
        Me.lblTotP.Text = "Total de locações com aluguel pago: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTotN
        '
        Me.lblTotN.AutoSize = True
        Me.lblTotN.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotN.ForeColor = System.Drawing.Color.Black
        Me.lblTotN.Location = New System.Drawing.Point(28, 193)
        Me.lblTotN.Name = "lblTotN"
        Me.lblTotN.Size = New System.Drawing.Size(310, 21)
        Me.lblTotN.TabIndex = 13
        Me.lblTotN.Text = "Total de locações com aluguel não pago: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPag
        '
        Me.lblPag.AutoSize = True
        Me.lblPag.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPag.ForeColor = System.Drawing.Color.Black
        Me.lblPag.Location = New System.Drawing.Point(534, 99)
        Me.lblPag.Name = "lblPag"
        Me.lblPag.Size = New System.Drawing.Size(162, 42)
        Me.lblPag.TabIndex = 16
        Me.lblPag.Text = "Total devido do mês:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'lblPagP
        '
        Me.lblPagP.AutoSize = True
        Me.lblPagP.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagP.ForeColor = System.Drawing.Color.Black
        Me.lblPagP.Location = New System.Drawing.Point(534, 140)
        Me.lblPagP.Name = "lblPagP"
        Me.lblPagP.Size = New System.Drawing.Size(95, 21)
        Me.lblPagP.TabIndex = 17
        Me.lblPagP.Text = "Total pago: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPagN
        '
        Me.lblPagN.AutoSize = True
        Me.lblPagN.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagN.ForeColor = System.Drawing.Color.Black
        Me.lblPagN.Location = New System.Drawing.Point(534, 193)
        Me.lblPagN.Name = "lblPagN"
        Me.lblPagN.Size = New System.Drawing.Size(129, 42)
        Me.lblPagN.TabIndex = 18
        Me.lblPagN.Text = "Total a ser pago:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'lblPL
        '
        Me.lblPL.AutoSize = True
        Me.lblPL.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPL.ForeColor = System.Drawing.Color.Black
        Me.lblPL.Location = New System.Drawing.Point(30, 242)
        Me.lblPL.Name = "lblPL"
        Me.lblPL.Size = New System.Drawing.Size(308, 21)
        Me.lblPL.TabIndex = 19
        Me.lblPL.Text = "Porcentagem das locações que pagaram:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPP
        '
        Me.lblPP.AutoSize = True
        Me.lblPP.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPP.ForeColor = System.Drawing.Color.Black
        Me.lblPP.Location = New System.Drawing.Point(534, 242)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(372, 21)
        Me.lblPP.TabIndex = 20
        Me.lblPP.Text = "Porcentagem entre o total devido e o total pago: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SGI.My.Resources.Resources.IcoVoltar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 26)
        Me.Button2.TabIndex = 170
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chrLoc
        '
        Me.chrLoc.BorderlineColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.chrLoc.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrLoc.Legends.Add(Legend1)
        Me.chrLoc.Location = New System.Drawing.Point(19, 300)
        Me.chrLoc.Name = "chrLoc"
        Me.chrLoc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.LabelBackColor = System.Drawing.Color.Gainsboro
        Series1.LabelBorderColor = System.Drawing.Color.Gainsboro
        Series1.Legend = "Legend1"
        Series1.Name = "Loc"
        Me.chrLoc.Series.Add(Series1)
        Me.chrLoc.Size = New System.Drawing.Size(402, 413)
        Me.chrLoc.TabIndex = 178
        Me.chrLoc.Text = "Chart1"
        '
        'chrPag
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrPag.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrPag.Legends.Add(Legend2)
        Me.chrPag.Location = New System.Drawing.Point(538, 300)
        Me.chrPag.Name = "chrPag"
        Me.chrPag.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.BorderColor = System.Drawing.Color.Black
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Pag"
        Me.chrPag.Series.Add(Series2)
        Me.chrPag.Size = New System.Drawing.Size(402, 413)
        Me.chrPag.TabIndex = 179
        Me.chrPag.Text = "Chart2"
        '
        'EstatisticasPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 734)
        Me.Controls.Add(Me.chrPag)
        Me.Controls.Add(Me.chrLoc)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblPP)
        Me.Controls.Add(Me.lblPL)
        Me.Controls.Add(Me.lblPagN)
        Me.Controls.Add(Me.lblPagP)
        Me.Controls.Add(Me.lblPag)
        Me.Controls.Add(Me.lblTotN)
        Me.Controls.Add(Me.lblTotP)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EstatisticasPag"
        Me.Text = "EstatisticasPag"
        CType(Me.chrLoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrPag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotP As Label
    Friend WithEvents lblTotN As Label
    Friend WithEvents lblPag As Label
    Friend WithEvents lblPagP As Label
    Friend WithEvents lblPagN As Label
    Friend WithEvents lblPL As Label
    Friend WithEvents lblPP As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents chrLoc As DataVisualization.Charting.Chart
    Friend WithEvents chrPag As DataVisualization.Charting.Chart
End Class

Public Class EstatisticasPag
    Dim objBanco As New ClsBanco
    Private Sub EstatisticasPag_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim d As Date = Today.Date.AddDays(-Today.Day + 1)
        Dim a As Double
        Dim b As Double 'locações pagas está nessa variavel
        Dim c As Double 'locações não pagas está nessa variavel
        Dim g As Double
        Dim h As Double 'total de dinheiro dos alugueis pago
        Dim i As Double 'total de dinheiro dos alugueis não pago
        Dim f As Double
        'total de locações
        a = objBanco.InfoIndividual("SELECT COUNT(pagloc) FROM tabloc WHERE atiloc = TRUE")
        lblTotal.Text = lblTotal.Text & a
        'total de locações pagas
        b = objBanco.InfoIndividual("SELECT COUNT(tabloc.pagloc) FROM tabloc INNER JOIN tabPagamento ON (tabloc.dtloc = tabPagamento.dtInipag) AND (tabloc.inqloc = tabPagamento.inqpag) AND (tabloc.imoloc = tabPagamento.imopag) WHERE tabloc.atiloc = TRUE AND tabPagamento.dtpag=datevalue('" & Today.Date.AddDays(-Today.Day + 1) & "')")
        lblTotP.Text = lblTotP.Text & b
        'total de locações n pagas (LNP)
        c = a - b
        lblTotN.Text = lblTotN.Text & c

        'porcentagem locações
        lblPL.Text = lblPL.Text & Format((b / a) * 100, "0.00") & "%"
        'total devido
        g = objBanco.InfoIndividual("SELECT SUM(pagloc) FROM tabloc WHERE atiloc = TRUE")
        lblPag.Text = lblPag.Text & "R$" & g
        'total pago
        h = objBanco.InfoIndividual("SELECT SUM(tabloc.pagloc) FROM tabloc INNER JOIN tabPagamento ON (tabloc.dtloc = tabPagamento.dtInipag) AND (tabloc.inqloc = tabPagamento.inqpag) AND (tabloc.imoloc = tabPagamento.imopag) WHERE tabloc.atiloc = TRUE AND tabPagamento.dtpag=datevalue('" & Today.Date.AddDays(-Today.Day + 1) & "')")
        lblPagP.Text = lblPagP.Text & "R$" & h
        'total não pago
        i = g - h
        lblPagN.Text = lblPagN.Text & "R$" & i
        'porcentagem pagamento
        lblPP.Text = lblPP.Text & Format((h / g) * 100, "0.00") & "%"
        Dim escura As Color = Color.FromArgb(47, 95, 152)
        Dim clara As Color = Color.FromArgb(45, 139, 186)
        chrLoc.Series("Loc").Points.Add(b).Name = "pago"
        chrLoc.Series("Loc").Points.Add(c).Name = "nPago"

        chrLoc.Series("Loc").Points(0).LegendText = "pagos"
        chrLoc.Series("Loc").Points(0).Color = escura

        chrLoc.Series("Loc").Points(1).LegendText = "Não pagos"
        chrLoc.Series("Loc").Points(1).Color = clara

        chrPag.Series("Pag").Points.Add(h).Name = "pago"
        chrPag.Series("Pag").Points.Add(i).Name = "nPago"

        chrPag.Series("Pag").Points(0).LegendText = "pagos"
        chrPag.Series("Pag").Points(0).Color = escura

        chrPag.Series("Pag").Points(1).LegendText = "Não pagos"
        chrPag.Series("Pag").Points(1).Color = clara

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Status
        ActivateMdiChild(form)
        PaginaInicial.OpenChildForm(form)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
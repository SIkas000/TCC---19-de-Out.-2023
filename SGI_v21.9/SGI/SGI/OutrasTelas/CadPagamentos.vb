Public Class CadPagamentos
    Public dPag As Integer = 32
    Dim objBanco As New ClsBanco
    Dim objPag As New ClsFinanceiro
    Private Sub btLoc_Click(sender As Object, e As EventArgs) Handles btLoc.Click
        PesqLoc.Show()
        PesqLoc.from = "fin"
    End Sub

    Private Sub btHist_Click(sender As Object, e As EventArgs) Handles btHist.Click
        Dim form As New HistPag
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub btV_Click(sender As Object, e As EventArgs)
        Dim form As New Status
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub btTransação_Click(sender As Object, e As EventArgs) Handles btTransação.Click
        Dim padrao As String = "Utilize o botão a baixo para selecionar as informações"
        If Not (lblImo.Text = padrao) Then
            objPag.Codigo = objBanco.Loc_ultimo("cdpag", "tabpagamento")
            objPag.CdImo = lblImo.Text
            objPag.cdInq = lblInq.Text
            objPag.DtIni = lblDt.Text
            objPag.Dt = dtpPag.Value.Date.AddDays(-dtpPag.Value.Day + 1)

            objPag.Gravar_dados()

            lblDt.Text = padrao
            lblImo.Text = padrao
            lblInq.Text = padrao
            dtpPag.Value = Date.Today
            dPag = 32
            MessageBox.Show("Pagamento cadastrado do mes " & objPag.Dt.Month & " do ano " & objPag.Dt.Year)
        Else
            MessageBox.Show("Por favor selecione uma locação para cadastrar um pagamento de aluguel")
        End If
    End Sub

    Private Sub CadPagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Status
        PaginaInicial.defAtiForm(form)
    End Sub
End Class
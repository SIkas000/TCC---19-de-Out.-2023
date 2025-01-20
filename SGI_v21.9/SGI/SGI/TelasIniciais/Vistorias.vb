Imports System.IO
Imports Microsoft.Office.Interop

Public Class Vistorias
    Dim objVist As New ClsVis
    Dim objDT As DataTable
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim novo As Boolean
    Dim objBanco As New ClsBanco

    Private Sub Vistorias_Load(sender As Object, e As EventArgs) Handles Me.Load
        objVist.BuscarDadosTd(cbxOcultar.Checked)

        pnlHolder.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btAbrir.Visible = False
        btnCancelar.Visible = False
        txtCancelar.Visible = False
        Me.Width = PaginaInicial.resX
        Me.Height = PaginaInicial.resY

        ' Set the DataGridView's background color
        DgdGrade.BackgroundColor = Color.White

        ' Style the column headers
        Dim headerStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(52, 58, 64) ' Dark gray background
        headerStyle.ForeColor = Color.White ' White text
        headerStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold) ' Bold font
        DgdGrade.ColumnHeadersDefaultCellStyle = headerStyle
        DgdGrade.BorderStyle = BorderStyle.None
        DgdGrade.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
        DgdGrade.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DgdGrade.EnableHeadersVisualStyles = False

        ' Style the cell content
        Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        cellStyle.BackColor = Color.FromArgb(240, 240, 240) ' Light gray background
        cellStyle.Font = New Font("Segoe UI", 11) ' Regular font
        DgdGrade.DefaultCellStyle = cellStyle

        ' Set row height and alternate row color
        DgdGrade.RowTemplate.Height = 30
        DgdGrade.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255) ' White background for alternate rows
    End Sub

    Private Sub TxtTexto_TextChanged(sender As Object, e As EventArgs) Handles TxtTexto.TextChanged
        DgdGrade.Rows.Clear()
        objVist.BuscarDadosEsp(TxtTexto.Text, cbxOcultar.Checked)
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick

        objVist.Codigo = DgdGrade.CurrentRow.Cells(0).Value
        objVist.Imovel = DgdGrade.CurrentRow.Cells(1).Value
        objVist.Data = DgdGrade.CurrentRow.Cells(5).Value
        objVist.Documento = DgdGrade.CurrentRow.Cells(6).Value
        objVist.Tipo = DgdGrade.CurrentRow.Cells(7).Value
        objVist.Descricao = DgdGrade.CurrentRow.Cells(8).Value

        lblImo.Text = objVist.Imovel
        dtpVist.Value = objVist.Data.Date
        cbxTipo.Text = objVist.Tipo
        lblCaminho.Text = objVist.Documento
        rtbObs.Text = objVist.Descricao

        novo = False

        pnlHolder.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        btnDeletar.Visible = True
        txtDeletar.Visible = True
        btAbrir.Visible = True
        btnCancelar.Visible = True
        txtCancelar.Visible = True
        Me.ScrollControlIntoView(pnlHolder)
    End Sub

    Private Sub btNv_Click(sender As Object, e As EventArgs) Handles btnNv.Click
        pnlHolder.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btAbrir.Visible = False
        btnCancelar.Visible = True
        txtCancelar.Visible = True
        Me.ScrollControlIntoView(pnlHolder)

        cbxTipo.Text = ""
        dtpVist.Value = Date.Today.Date
        rtbObs.Text = ""
        lblImo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
        lblCaminho.Text = "Selecione o caminho do documento pelo botão abaixo"

        novo = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If novo Then
            objVist.Codigo = objBanco.Loc_ultimo("cdvist", "tabvist")
        Else
            MessageBox.Show("AVISO: alterações na vistoria não alterarão a tarefa gerada automaticamente no calendário")
        End If

        objVist.Descricao = rtbObs.Text
        objVist.Tipo = cbxTipo.Text
        objVist.Documento = lblCaminho.Text
        objVist.Data = dtpVist.Value.Date
        objVist.Imovel = lblImo.Text

        objVist.Gravar_dados(novo)
        novo = False
        TxtTexto.Text = ""

        DgdGrade.Rows.Clear()
        objVist.BuscarDadosTd(cbxOcultar.Checked)


        'ajustes apos selecao

        cbxTipo.Text = ""
        dtpVist.Value = Date.Today.Date
        rtbObs.Text = ""
        lblImo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
        lblCaminho.Text = "Selecione o caminho do documento pelo botão abaixo"

        'desing
        pnlHolder.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btAbrir.Visible = False
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        objVist.Excluir()

        cbxTipo.Text = ""
        dtpVist.Value = Date.Today.Date
        rtbObs.Text = ""
        lblImo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
        lblCaminho.Text = "Selecione o caminho do documento pelo botão abaixo"

        pnlHolder.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False

        'recarregar planilha
        If TxtTexto.Text <> "" Then
            DgdGrade.Rows.Clear()
            objVist.BuscarDadosEsp(TxtTexto.Text, cbxOcultar.Checked)
        Else
            DgdGrade.Rows.Clear()
            objVist.BuscarDadosTd(cbxOcultar.Checked)
        End If
    End Sub

    Private Sub btImo_Click(sender As Object, e As EventArgs) Handles btImo.Click
        PesqImo.from = "vist"
        PesqImo.Show()
    End Sub

    Private Sub btCaminho_Click(sender As Object, e As EventArgs) Handles btCaminho.Click
        OFD.Filter = "Microsoft Word files (*.docx)|*.docx|All files (*.*)|*.*"
        OFD.ShowDialog()
        lblCaminho.Text = Path.GetFullPath(OFD.FileName)
        btAbrir.Visible = True
    End Sub

    Private Sub btAbrir_Click(sender As Object, e As EventArgs) Handles btAbrir.Click
        Try
            Dim word As Word.Application
            Dim doc As Word.Document
            word = CreateObject("Word.Application")
            doc = word.Documents.Open(lblCaminho.Text)
            word.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btEve_Click(sender As Object, e As EventArgs) Handles btEve.Click
        Dim form As New Calendario
        PaginaInicial.defAtiForm(form)
        form.cbxR.Text = "Vistoria"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Design
        pnlHolder.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btnNv.Visible = True
        txtNovo.Visible = True
        btnCancelar.Visible = False
        txtCancelar.Visible = False
        pnlHolder.ScrollControlIntoView(Label2)
    End Sub

    Private Sub cbxOcultar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOcultar.CheckedChanged
        DgdGrade.Rows.Clear()

        If TxtTexto.Text <> "" Then
            objVist.BuscarDadosEsp(TxtTexto.Text, cbxOcultar.Checked)
        Else
            objVist.BuscarDadosTd(cbxOcultar.Checked)
        End If
    End Sub
End Class
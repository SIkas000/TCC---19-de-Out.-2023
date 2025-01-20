Imports System.ComponentModel.Design.Serialization

Public Class Calendario
    Dim objEve As New ClsEvento
    Dim objBanco As New ClsBanco
    Dim novo As Boolean = False
    Dim edit As Boolean = True
    Dim HasLoad As Boolean = False

    Dim img1 As Image
    Dim img2 As Image
    Dim img3 As Image
    Dim img4 As Image

    Dim temp As Integer
    Dim temp2 As String

    Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
    Dim cSAtrasado As DataGridViewCellStyle = New DataGridViewCellStyle()
    Dim cSdia As DataGridViewCellStyle = New DataGridViewCellStyle()

    Public From As String = ""

    Public Sub preencher(objDt As DataTable)

        For i = 0 To objDt.Rows.Count - 1
            If objDt.Rows(i).Item(5) <> 0 Then
                Try
                    temp2 = objBanco.LocalizarCampo("ruaimo", "tabimov", "cdimo", objDt.Rows(i).Item(5))
                Catch ex As Exception
                    temp2 = "não há imovel relacionado"
                End Try

            Else
                temp2 = "não há imovel relacionado"
            End If
            DgdGrade.Rows.Add(objDt.Rows(i).Item(0), objDt.Rows(i).Item(1), objDt.Rows(i).Item(2), objDt.Rows(i).Item(3), objDt.Rows(i).Item(4), objDt.Rows(i).Item(5), temp2, objDt.Rows(i).Item(6))
            temp2 = ""
        Next
    End Sub
    Private Sub Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxR.Text = "Qualquer tipo"

        If From <> "" Then
            Label2.Text = Label2.Text & From
        Else
            Label2.Visible = False
        End If
        DgdGrade.Rows.Clear()
        preencher(objEve.BuscarDadosEsp(cbxR.Text, From))
        dtpDt.Visible = False
        txtNm.Visible = False
        rtbDesc.Visible = False
        cbxTp.Visible = False
        btImo.Visible = False
        lblDesc.Visible = False
        lblDt.Visible = False
        lblEve.Visible = False
        lblImo.Visible = False
        lblmo.Visible = False
        lblNm.Visible = False

        Panel1.Visible = False
        btExc.Visible = False
        txtExc.Visible = False
        btEdSv.Visible = False
        txtEdSv.Visible = False
        btConc.Visible = False
        txtConc.Visible = False
        HasLoad = True
        cbxR.Enabled = True
        btnCancelar.Visible = False
        txtCancelar.Visible = False

        Me.Width = PaginaInicial.resX
        Me.Height = PaginaInicial.resY

        img1 = btnNv.Image
        img2 = btEdSv.Image
        img3 = btExc.Image
        img4 = btConc.Image

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

        'formatação da celula caso a data da tarefa seja antes de hoje
        cellStyle.BackColor = Color.FromArgb(213, 255, 196) ' green
        cellStyle.Font = New Font("Segoe UI", 11) ' Regular font
        DgdGrade.DefaultCellStyle = cellStyle

        'formatação da celula caso a tarefa esteja atrasada
        cSAtrasado.BackColor = Color.FromArgb(255, 182, 184) 'red
        cSAtrasado.Font = New Font("Segoe UI", 11) ' Regular font

        'formatação da celula caso a data da tarefa seja hoje
        cSdia.BackColor = Color.FromArgb(254, 236, 138) 'yellow
        cSdia.Font = New Font("Segoe UI", 11) ' Regular font

        ' Set row height and alternate row color
        DgdGrade.RowTemplate.Height = 30
    End Sub

    Private Sub btImo_Click(sender As Object, e As EventArgs) Handles btImo.Click
        PesqImo.Show()
        PesqImo.from = "eve"
    End Sub

    Private Sub btNv_Click(sender As Object, e As EventArgs) Handles btnNv.Click
        dtpDt.Visible = True
        txtNm.Visible = True
        rtbDesc.Visible = True
        cbxTp.Visible = True
        btImo.Visible = True
        lblDesc.Visible = True
        lblDt.Visible = True
        lblEve.Visible = True
        lblImo.Visible = True
        lblmo.Visible = True
        lblNm.Visible = True
        Panel1.Visible = True


        lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
        txtNm.Text = ""
        cbxTp.Text = "Outro"
        dtpDt.Value = Date.Today.Date
        rtbDesc.Text = ""
        txtEdSv.Text = "Salvar"
        btEdSv.Image = img4
        novo = True

        btImo.Enabled = True
        txtNm.Enabled = True
        cbxTp.Enabled = True
        dtpDt.Enabled = True
        rtbDesc.Enabled = True
        Panel1.Visible = True

        btExc.Visible = False
        txtExc.Visible = False
        btEdSv.Visible = True
        txtEdSv.Visible = True
        edit = False
        btConc.Visible = False
        txtConc.Visible = False
        btnCancelar.Visible = True
        txtCancelar.Visible = True
        Me.ScrollControlIntoView(Panel1)

    End Sub



    Private Sub btConc_Click(sender As Object, e As EventArgs) Handles btConc.Click
        objEve.defCon()
        DgdGrade.Rows.Clear()
        preencher(objEve.BuscarDadosEsp(cbxR.Text, From))

        dtpDt.Visible = False
        txtNm.Visible = False
        rtbDesc.Visible = False
        cbxTp.Visible = False
        btImo.Visible = False
        lblDesc.Visible = False
        lblDt.Visible = False
        lblEve.Visible = False
        lblImo.Visible = False
        lblmo.Visible = False
        lblNm.Visible = False
        Panel1.Visible = False

        btnCancelar.Visible = False
        txtCancelar.Visible = False
        btExc.Visible = False
        txtExc.Visible = False
        btEdSv.Visible = False
        txtEdSv.Visible = False
        btConc.Visible = False
        txtConc.Visible = False
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick
        novo = False
        btExc.Visible = True
        txtExc.Visible = True
        btEdSv.Visible = True
        btEdSv.Image = img2
        txtEdSv.Visible = True
        btConc.Visible = True
        txtConc.Visible = True
        Me.ScrollControlIntoView(Panel1)

        dtpDt.Visible = True
        txtNm.Visible = True
        rtbDesc.Visible = True
        cbxTp.Visible = True
        btImo.Visible = True
        lblDesc.Visible = True
        lblDt.Visible = True
        lblEve.Visible = True
        lblImo.Visible = True
        lblmo.Visible = True
        lblNm.Visible = True
        Panel1.Visible = True

        btImo.Enabled = False
        txtNm.Enabled = False
        cbxTp.Enabled = False
        dtpDt.Enabled = False
        rtbDesc.Enabled = False
        btnCancelar.Visible = True
        txtCancelar.Visible = True

        edit = True

        objEve.Codigo = DgdGrade.CurrentRow.Cells(0).Value
        objEve.Data = DgdGrade.CurrentRow.Cells(1).Value.date
        objEve.Nome = DgdGrade.CurrentRow.Cells(2).Value
        objEve.Descricao = DgdGrade.CurrentRow.Cells(3).Value
        objEve.Tipo = DgdGrade.CurrentRow.Cells(4).Value
        objEve.Imovel = DgdGrade.CurrentRow.Cells(5).Value
        objEve.Concluido = DgdGrade.CurrentRow.Cells(7).Value

        dtpDt.Value = objEve.Data.Date
        txtNm.Text = objEve.Nome
        rtbDesc.Text = objEve.Descricao
        cbxTp.Text = objEve.Tipo
        lblmo.Text = objEve.Imovel
        txtEdSv.Text = "Editar"

        'a fazer coisas
    End Sub



    Private Sub btExc_Click(sender As Object, e As EventArgs) Handles btExc.Click
        dtpDt.Visible = False
        txtNm.Visible = False
        rtbDesc.Visible = False
        cbxTp.Visible = False
        btImo.Visible = False
        lblDesc.Visible = False
        lblDt.Visible = False
        lblEve.Visible = False
        lblImo.Visible = False
        lblmo.Visible = False
        lblNm.Visible = False
        Panel1.Visible = False
        btExc.Visible = False
        txtExc.Visible = False
        btEdSv.Visible = False
        txtEdSv.Visible = False
        btConc.Visible = False
        txtConc.Visible = False
        txtCancelar.Visible = False
        btnCancelar.Visible = False

        objEve.Excluir()

        DgdGrade.Rows.Clear()
        preencher(objEve.BuscarDadosEsp(cbxR.Text, From))
    End Sub

    Private Sub btEdSv_Click(sender As Object, e As EventArgs) Handles btEdSv.Click
        If edit Then
            edit = False

            btImo.Enabled = True
            txtNm.Enabled = True
            cbxTp.Enabled = True
            dtpDt.Enabled = True
            rtbDesc.Enabled = True
            Panel1.Visible = True

            btConc.Visible = False
            txtConc.Visible = False
            btExc.Visible = False
            txtExc.Visible = False
            txtEdSv.Text = "Salvar"
        Else
            edit = True

            If novo Then
                objEve.Codigo = objBanco.Loc_ultimo("cdeve", "tabeve")
            End If

            objEve.Data = dtpDt.Value.Date
            objEve.Nome = txtNm.Text
            objEve.Descricao = rtbDesc.Text
            objEve.Tipo = cbxTp.Text
            Try
                objEve.Imovel = lblmo.Text
            Catch ex As Exception

            End Try
            objEve.Gravar_dados(novo)

            'ajustes pre seleção

            DgdGrade.Rows.Clear()
            preencher(objEve.BuscarDadosEsp(cbxR.Text, From))

            lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
            txtNm.Text = ""
            cbxTp.Text = "Outro"
            dtpDt.Value = Date.Today.Date
            rtbDesc.Text = ""

            dtpDt.Visible = False
            txtNm.Visible = False
            rtbDesc.Visible = False
            cbxTp.Visible = False
            btImo.Visible = False
            lblDesc.Visible = False
            lblDt.Visible = False
            lblEve.Visible = False
            lblImo.Visible = False
            lblmo.Visible = False
            lblNm.Visible = False

            btExc.Visible = False
            txtExc.Visible = False
            btEdSv.Visible = False
            txtEdSv.Visible = False
            btConc.Visible = False
            txtConc.Visible = False
            txtEdSv.Text = "Editar"
        End If
    End Sub

    Private Sub cbxR_TextChanged(sender As Object, e As EventArgs) Handles cbxR.TextChanged
        If HasLoad Then
            DgdGrade.Rows.Clear()
            preencher(objEve.BuscarDadosEsp(cbxR.Text, From))
        End If
    End Sub


    Private Sub DgdGrade_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgdGrade.CellFormatting
        If DgdGrade.Rows.Item(e.RowIndex).Cells(1).Value < Today Then
            e.CellStyle = cSAtrasado
        ElseIf DgdGrade.Rows.Item(e.RowIndex).Cells(1).Value.date = Today.Date Then
            e.CellStyle = cSdia
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Design
        Panel1.Visible = False
        btEdSv.Visible = False
        txtEdSv.Visible = False
        btConc.Visible = False
        txtConc.Visible = False
        btExc.Visible = False
        txtExc.Visible = False
        btnNv.Visible = True
        txtNovo.Visible = True
        btnCancelar.Visible = False
        txtCancelar.Visible = False
        Panel1.ScrollControlIntoView(Label1)
    End Sub
End Class
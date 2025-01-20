Imports System.Linq.Expressions

Public Class CadLocacao

    Dim objLoc As New ClsLoc
    Dim objDT As DataTable

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim novo As Boolean

    Dim objBanco As New ClsBanco

    Dim temp1 As String
    Dim temp2 As String
    Dim temp3 As String
    Dim temp4 As String

    Dim erro As String

    Public codProp As Integer
    Public codImo As Integer
    Public codInq As Integer

    Private Function VerificarCad() As Boolean
        Dim dtDate As DataTable
        Dim dtInq As DataTable
        Dim dtImov As DataTable

        If Not (novo) Then
            Return True
        End If
        'verifica se a locação já foi cadastrada
        dtDate = objBanco.Localizar("select dtloc from tabloc order by imoloc, inqloc, dtloc")
        dtInq = objBanco.Localizar("select inqloc from tabloc order by imoloc, inqloc, dtloc")
        dtImov = objBanco.Localizar("select imoloc, atiloc from tabloc order by imoloc, inqloc, dtloc")
        For i = 0 To dtDate.Rows.Count - 1
            If dtDate.Rows(i).Item(0) = objLoc.dtInLoc And dtInq.Rows(i).Item(0) = lblInq.Text And dtImov.Rows(i).Item(0) = lblmo.Text Then
                erro = "Essa locação já foi cadastrada"
                lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
                lblInq.Text = "Pesquise o codigo do inquilino pelo botão abaixo"
                dtpIni.Value = Date.Today.Date
                Return False
            End If
        Next

        'verifica se o imovel já está sendo usado em outra locação
        For i = 0 To dtImov.Rows.Count - 1
            If dtImov.Rows(i).Item(1) = True And dtImov.Rows(i).Item(0) = lblmo.Text Then
                erro = "Esse imóvel já está alugado"
                lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub CadLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxOcultar.Checked = True
        DgdGrade.Rows.Clear()
        objDT = objLoc.BuscarDadosTd(cbxOcultar.Checked)
        For i = 0 To objDT.Rows.Count - 1
            DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2).date, objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
        Next

        'Design
        TxtTexto.Visible = False
        pnlProp.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        dtpIni.Enabled = False
        btImo.Enabled = False
        Button1.Enabled = False
        btnCancelar.Visible = False
        txtCancelar.Visible = False

        'desing tusita
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

    Private Sub TopTab_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TopTab_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TopTab_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnNv_Click(sender As Object, e As EventArgs) Handles btnNv.Click
        'Design
        pnlProp.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        pnlHolder.ScrollControlIntoView(pnlProp)
        dtpIni.Enabled = True
        btImo.Enabled = True
        Button1.Enabled = True
        btnCancelar.Visible = True
        txtCancelar.Visible = True

        cbxAtiva.Visible = False
        lblFim.Visible = False
        dtpFim.Visible = False

        'esvaziar
        lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
        lblInq.Text = "Pesquise o codigo do inquilino pelo botão abaixo"
        txtDP.Text = ""
        txtPag.Text = ""
        cbxAtiva.Checked = True
        dtpFim.Value = Date.Today.Date
        dtpIni.Value = Date.Today.Date

        objLoc.atiChanged = True
        novo = True
    End Sub

    Private Sub btnSalvar_Click_1(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If lblmo.Text <> "Pesquise o codigo do imovel pelo botão abaixo" And lblInq.Text <> "Pesquise o codigo do inquilino pelo botão abaixo" Then
            'verificações para realizar registro
            If VerificarCad() Then
                If novo Then
                    cbxAtiva.Checked = True
                ElseIf cbxAtiva.Checked = False And dtpIni.Value > dtpFim.value Then
                    MessageBox.Show("A data do final da locação deve ser depois da data de inicio")
                    dtpFim.Value = dtpIni.Value.AddDays(1)
                    dtpFim.Focus()
                    Exit Sub
                End If

                objLoc.Pag = txtPag.Text
                objLoc.diaDoPag = txtDP.Text
                objLoc.Ativo = cbxAtiva.Checked
                objLoc.CodImo = lblmo.Text
                objLoc.CodInq = lblInq.Text
                objLoc.DtFimLoc = dtpFim.Value.Date
                objLoc.dtInLoc = dtpIni.Value.Date

                objLoc.Gravar_dados(novo)

                objLoc.atiChanged = False
                novo = False
                TxtTexto.Text = ""

                DgdGrade.Rows.Clear()
                objDT = objLoc.BuscarDadosTd(cbxOcultar.Checked)
                For i = 0 To objDT.Rows.Count - 1
                    DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
                Next

                'ajustes apos selecao

                lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
                lblInq.Text = "Pesquise o codigo do inquilino pelo botão abaixo"
                txtDP.Text = ""
                txtPag.Text = ""
                cbxAtiva.Checked = True
                dtpFim.Value = Date.Today.Date
                dtpIni.Value = Date.Today.Date


                'Design
                pnlProp.Visible = False
                btnSalvar.Visible = False
                txtSalvar.Visible = False
                btnDeletar.Visible = False
                txtDeletar.Visible = False
                btnNv.Visible = True
                txtNovo.Visible = True
                dtpIni.Enabled = False
                btImo.Enabled = False
                Button1.Enabled = False
                btnCancelar.Visible = False
                txtCancelar.Visible = False

            Else
                MessageBox.Show(erro)
            End If
        Else
            MessageBox.Show("você deve selecionar um código para salvar")
        End If
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        objLoc.Excluir()

        lblmo.Text = "Pesquise o codigo do imovel pelo botão abaixo"
        lblInq.Text = "Pesquise o codigo do inquilino pelo botão abaixo"
        txtDP.Text = ""
        txtPag.Text = ""
        cbxAtiva.Checked = True
        dtpFim.Value = Date.Today.Date
        dtpIni.Value = Date.Today.Date

        'Design
        pnlProp.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btnNv.Visible = True
        txtNovo.Visible = True
        dtpIni.Enabled = False
        btImo.Enabled = False
        Button1.Enabled = False
        btnCancelar.Visible = False
        txtCancelar.Visible = False

        'recarregar planilha
        If TxtTexto.Text <> "" Then
            objDT = objLoc.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, cbxOcultar.Checked)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        Else
            DgdGrade.Rows.Clear()
            objDT = objLoc.BuscarDadosTd(cbxOcultar.Checked)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        End If
    End Sub

    Private Sub cbxOcultar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOcultar.CheckedChanged
        If TxtTexto.Text <> "" Then
            DgdGrade.Rows.Clear()
            objDT = objLoc.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, cbxOcultar.Checked)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        Else
            DgdGrade.Rows.Clear()
            objDT = objLoc.BuscarDadosTd(cbxOcultar.Checked)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        End If
    End Sub

    Private Sub txtPag_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            MessageBox.Show("Esse campo aceita apenas Letras")
        End If
    End Sub

    Private Sub txtDP_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            MessageBox.Show("Esse campo aceita apenas Letras")
        End If
    End Sub

    Private Sub cbxAtiva_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAtiva.CheckedChanged
        dtpFim.Value = Date.Today.Date
        If cbxAtiva.Checked Then
            dtpFim.Visible = False
            lblFim.Visible = False
        Else
            dtpFim.Visible = True
            lblFim.Visible = True
        End If

        objLoc.atiChanged = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PesqInq.Show()
    End Sub

    Private Sub btImo_Click(sender As Object, e As EventArgs) Handles btImo.Click
        PesqImo.Show()
        PesqImo.from = "loc"
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick
        'entidade
        objLoc.CodImo = DgdGrade.CurrentRow.Cells(0).Value
        objLoc.CodInq = DgdGrade.CurrentRow.Cells(2).Value
        objLoc.dtInLoc = DgdGrade.CurrentRow.Cells(4).Value.Date
        objLoc.Ativo = DgdGrade.CurrentRow.Cells(5).Value
        objLoc.diaDoPag = DgdGrade.CurrentRow.Cells(6).Value
        If Not (IsDBNull(DgdGrade.CurrentRow.Cells(7).Value)) Then
            objLoc.DtFimLoc = DgdGrade.CurrentRow.Cells(7).Value.Date
        End If
        objLoc.Pag = DgdGrade.CurrentRow.Cells(8).Value
        'txts
        lblmo.Text = objLoc.CodImo
        lblInq.Text = objLoc.CodInq
        txtDP.Text = objLoc.diaDoPag
        txtPag.Text = objLoc.Pag
        dtpIni.Value = objLoc.dtInLoc
        cbxAtiva.Checked = objLoc.Ativo

        If Not (objLoc.Ativo) Then
            dtpFim.Value = objLoc.DtFimLoc
            dtpFim.Visible = True
        Else
            dtpFim.Visible = False
        End If
        novo = False

        'Design

        cbxAtiva.Visible = True
        pnlProp.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        btnDeletar.Visible = True
        txtDeletar.Visible = True
        btnNv.Visible = False
        txtNovo.Visible = False
        pnlHolder.ScrollControlIntoView(pnlProp)
        dtpIni.Enabled = False
        btImo.Enabled = False
        Button1.Enabled = False
        btnCancelar.Visible = True
        txtCancelar.Visible = True
        lblFim.Visible = False
    End Sub

    Private Sub TxtTexto_TextChanged(sender As Object, e As EventArgs) Handles TxtTexto.TextChanged
        DgdGrade.Rows.Clear()
        objDT = objLoc.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, cbxOcultar.Checked)
        For i = 0 To objDT.Rows.Count - 1
            DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TxtTexto.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Design
        pnlProp.Visible = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New CadastrosConsultas
        ActivateMdiChild(form)
        PaginaInicial.OpenChildForm(form)
    End Sub

    Private Sub pnlProp_Paint(sender As Object, e As PaintEventArgs) Handles pnlProp.Paint

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class
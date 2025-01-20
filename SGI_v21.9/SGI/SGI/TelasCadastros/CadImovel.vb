Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class CadImovel

    Dim objImo As New ClsImo
    Dim objDT As DataTable

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim novo As Boolean

    Dim objBanco As New ClsBanco
    Dim temporario As String
    Dim hasL As Boolean = False
    Public codProp As Integer

    Dim ds As New DataSet
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
    Public Sub Preencher(i As Integer)
        temporario = objBanco.LocalizarCampo("nmprop", "tabprop", "cdprop", objDT.Rows(i).Item(17))
        DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), temporario)
    End Sub

    Private Sub CadImovel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxRestringir.Text = "Qualquer estado"

        DgdGrade.Rows.Clear()
        objDT = objImo.BuscarDadosTd(cbxRestringir.Text)
        For i = 0 To objDT.Rows.Count - 1
            Preencher(i)
        Next


        'Design
        TxtTexto.Visible = False
        pnlProp.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btEve.Visible = False
        btnCancelar.Visible = False
        txtCancelar.Visible = False
        hasL = True


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

    Private Sub btnNv_Click_1(sender As Object, e As EventArgs) Handles btnNv.Click
        'esvaziar
        txtAlu.Text = ""
        txtBai.Text = ""
        mskCep.Text = ""
        txtCid.Text = ""
        txtComp.Text = ""
        txtEne.Text = ""
        lblProp.Text = "Pesquise o codigo do proprietário pelo botão abaixo"
        txtNum.Text = ""
        txtRua.Text = ""
        txtSab.Text = ""
        txtVal.Text = ""
        txtValP.Text = ""
        txtRegIPTU.Text = ""
        txtIptu.Text = ""
        rtbObs.Text = ""
        cbxEst.SelectedText = ""
        cbxUf.SelectedText = ""

        'Design
        pnlProp.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        btEve.Visible = False
        btnCancelar.Visible = True
        txtCancelar.Visible = True
        pnlHolder.ScrollControlIntoView(pnlProp)

        novo = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If lblProp.Text <> "Pesquise o codigo do proprietário pelo botão abaixo" And txtAlu.Value <> 0 And txtBai.Text <> "" And mskCep.Text <> "" And txtNum.Text <> "" And txtCid.Text <> "" And cbxEst.Text <> "" And cbxUf.Text <> "" And txtRua.Text <> "" Then
            If novo Then
                objImo.codigoImo = objBanco.Loc_ultimo("cdimo", "tabimov")
            End If

            objImo.bairro = txtBai.Text
            objImo.obs = rtbObs.Text
            objImo.aluguel = txtAlu.Value
            objImo.CEP = mskCep.Text
            objImo.numero = txtNum.Text
            objImo.cidade = txtCid.Text
            objImo.complemento = txtComp.Text
            objImo.estado = cbxEst.Text
            objImo.proprietario = lblProp.Text
            objImo.rua = txtRua.Text
            objImo.sabesp = txtSab.Text
            objImo.valorV = txtVal.Value
            objImo.valorP = txtValP.Value
            objImo.ValIptu = txtIptu.Value
            objImo.RegIptu = txtRegIPTU.Text
            objImo.UF = cbxUf.Text
            objImo.enel = txtEne.Text

            objImo.Gravar_dados(novo)

            novo = False
            TxtTexto.Text = ""

            DgdGrade.Rows.Clear()
            objDT = objImo.BuscarDadosTd(cbxRestringir.Text)
            For i = 0 To objDT.Rows.Count - 1
                Preencher(i)
            Next

            'ajustes apos selecao

            txtAlu.Text = ""
            txtBai.Text = ""
            mskCep.Text = ""
            txtCid.Text = ""
            txtComp.Text = ""
            txtEne.Text = ""
            lblProp.Text = "Pesquise o codigo do proprietário pelo botão abaixo"
            txtNum.Text = ""
            txtRua.Text = ""
            txtSab.Text = ""
            txtVal.Text = ""
            txtValP.Text = ""
            txtIptu.Text = ""
            txtRegIPTU.Text = ""
            rtbObs.Text = ""
            cbxEst.SelectedText = ""
            cbxUf.SelectedText = ""


            'desing
            btnSalvar.Visible = False
            txtSalvar.Visible = False
            btnDeletar.Visible = False
            txtDeletar.Visible = False
            btnCancelar.Visible = False
            txtCancelar.Visible = False
            btnNv.Visible = True
            txtNovo.Visible = True

            pnlProp.Visible = False
            pnlHolder.ScrollControlIntoView(Label2)

        Else
            MessageBox.Show("você deve preencher os campos obrigatórios")
        End If
    End Sub

    Private Sub btnDeletar_Click_1(sender As Object, e As EventArgs) Handles btnDeletar.Click
        objImo.Excluir()

        txtAlu.Text = ""
        txtBai.Text = ""
        mskCep.Text = ""
        txtCid.Text = ""
        txtComp.Text = ""
        txtEne.Text = ""
        lblProp.Text = "Pesquise o codigo do proprietário pelo botão abaixo"
        txtNum.Text = ""
        txtRua.Text = ""
        txtSab.Text = ""
        txtVal.Text = ""
        txtValP.Text = ""
        txtRegIPTU.Text = ""
        txtIptu.Text = ""
        rtbObs.Text = ""
        cbxEst.SelectedText = ""
        cbxUf.SelectedText = ""
        cbxEst.SelectedText = ""
        cbxUf.SelectedText = ""

        'Design
        pnlProp.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        btnNv.Visible = True
        txtNovo.Visible = True
        btEve.Visible = False
        btnCancelar.Visible = False
        txtCancelar.Visible = False
        txtDeletar.Visible = False


        pnlHolder.ScrollControlIntoView(Label2)

        'recarregar planilha
        If TxtTexto.Text <> "" Then
            objImo.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, cbxRestringir.Text)
        Else
            DgdGrade.Rows.Clear()
            objDT = objImo.BuscarDadosTd(cbxRestringir.Text)
            For i = 0 To objDT.Rows.Count - 1
                Preencher(i)
            Next
        End If
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick
        'entidade
        objImo.codigoImo = DgdGrade.CurrentRow.Cells(0).Value
        objImo.CEP = DgdGrade.CurrentRow.Cells(1).Value
        objImo.numero = DgdGrade.CurrentRow.Cells(2).Value
        If Not (IsDBNull(DgdGrade.CurrentRow.Cells(3).Value)) Then
            objImo.complemento = DgdGrade.CurrentRow.Cells(3).Value
        End If
        objImo.sabesp = DgdGrade.CurrentRow.Cells(4).Value
        objImo.enel = DgdGrade.CurrentRow.Cells(5).Value
        objImo.aluguel = DgdGrade.CurrentRow.Cells(6).Value
        If Not (IsDBNull(DgdGrade.CurrentRow.Cells(7).Value)) Then
            objImo.valorP = DgdGrade.CurrentRow.Cells(7).Value
        End If
        If Not (IsDBNull(DgdGrade.CurrentRow.Cells(8).Value)) Then
            objImo.valorV = DgdGrade.CurrentRow.Cells(8).Value
        End If
        objImo.RegIptu = DgdGrade.CurrentRow.Cells(9).Value
        objImo.ValIptu = DgdGrade.CurrentRow.Cells(10).Value
        If Not (IsDBNull(DgdGrade.CurrentRow.Cells(11).Value)) Then
            objImo.obs = DgdGrade.CurrentRow.Cells(11).Value
        End If
        objImo.rua = DgdGrade.CurrentRow.Cells(12).Value
        objImo.bairro = DgdGrade.CurrentRow.Cells(13).Value
        objImo.cidade = DgdGrade.CurrentRow.Cells(14).Value
        objImo.UF = DgdGrade.CurrentRow.Cells(15).Value
        objImo.estado = DgdGrade.CurrentRow.Cells(16).Value
        objImo.proprietario = DgdGrade.CurrentRow.Cells(17).Value

        'txts
        txtAlu.Text = objImo.aluguel
        txtBai.Text = objImo.bairro
        mskCep.Text = objImo.CEP
        txtCid.Text = objImo.cidade
        txtComp.Text = objImo.complemento
        txtEne.Text = objImo.enel
        lblProp.Text = objImo.proprietario
        txtNum.Text = objImo.numero
        txtRua.Text = objImo.rua
        txtSab.Text = objImo.sabesp
        txtVal.Text = objImo.valorV
        txtIptu.Text = objImo.ValIptu
        txtRegIPTU.Text = objImo.RegIptu
        txtValP.Text = objImo.valorP
        rtbObs.Text = objImo.obs
        cbxEst.Text = objImo.estado
        cbxUf.Text = objImo.UF

        novo = False

        'Design
        pnlProp.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        btnDeletar.Visible = True
        txtDeletar.Visible = True
        btnNv.Visible = False
        txtNovo.Visible = False
        btEve.Visible = True
        btnCancelar.Visible = True
        txtCancelar.Visible = True
        pnlHolder.ScrollControlIntoView(pnlProp)

    End Sub

    Private Sub cbxRestringir_TextChanged(sender As Object, e As EventArgs) Handles cbxRestringir.TextChanged
        If hasL Then
            If TxtTexto.Text <> "" Then
                DgdGrade.Rows.Clear()
                objImo.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, cbxRestringir.Text)
            Else
                DgdGrade.Rows.Clear()
                objDT = objImo.BuscarDadosTd(cbxRestringir.Text)
                For i = 0 To objDT.Rows.Count - 1
                    Preencher(i)
                Next
            End If
        End If
    End Sub

    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            MessageBox.Show("Esse campo aceita apenas Letras")
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=" & Trim(mskCep.Text.Replace("-", "")) & "&formato=xml"
        ds.Clear()
        ds.ReadXml(xml)

        If ds.Tables(0).Rows(0)("resultado") = 1 Then
            txtRua.Text = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
            txtBai.Text = ds.Tables(0).Rows(0)("bairro")
            txtCid.Text = ds.Tables(0).Rows(0)("cidade")
            cbxUf.Text = ds.Tables(0).Rows(0)("uf")
            txtNum.Focus()
        Else
            MessageBox.Show("CEP NÃO LOCALIZADO")
            mskCep.Clear()
            mskCep.Focus()
            txtRua.Clear()
            txtNum.Clear()
            txtBai.Clear()
            txtCid.Clear()
            cbxUf.Text = ""
        End If
    End Sub

    Private Sub btProp_Click(sender As Object, e As EventArgs) Handles btProp.Click
        PesqProp.Show()
    End Sub

    Private Sub mskCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCep.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 32 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtTexto_TextChanged(sender As Object, e As EventArgs) Handles TxtTexto.TextChanged
        objImo.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, cbxRestringir.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New CadastrosConsultas
        ActivateMdiChild(form)
        PaginaInicial.OpenChildForm(form)
    End Sub
    Private Sub btEve_Click_1(sender As Object, e As EventArgs) Handles btEve.Click
        Dim form As New Calendario With {
            .From = objImo.codigoImo
        }
        ActivateMdiChild(form)
        PaginaInicial.OpenChildForm(form)

    End Sub
End Class
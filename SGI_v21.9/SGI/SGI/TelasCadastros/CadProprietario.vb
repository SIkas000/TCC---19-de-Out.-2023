Imports System.Net.Security
Imports System.Runtime.ConstrainedExecution

Public Class CadProprietario
    Dim finVis As Boolean = False
    Dim objProp As New ClsProp
    Dim objDT As DataTable
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim novo As Boolean
    Dim objBanco As New ClsBanco

    Public Function SoEmail(str As String) As Boolean
        Dim valido = True
        Dim I As Integer
        Dim arrobas As Integer
        If Len(str) < 5 Then
            valido = False
            MessageBox.Show("O email deve ter pelo menos 5 caracteres")
        ElseIf InStr(str, "@") = 1 Or InStr(str, ".") = 1 Then
            valido = False
            MessageBox.Show("O email não pode começar com '@' ou com '.'")
        ElseIf InStr(str, "@") = Len(str) Or InStr(str, ".") = Len(str) Then
            valido = False
            MessageBox.Show("O email não pode terminar com '@' ou com '.'")
        ElseIf InStr(str, ".") = 0 Then
            valido = False
            MessageBox.Show("O email não pode deve ter ao menos 1 '@' ou com '.'")
        ElseIf InStr(str, "..") > 0 Then
            valido = False
            MessageBox.Show("O email não pode ter 2 '.' seguidos")
        Else
            arrobas = 0
            For I = 1 To Len(str)
                If Mid(str, I, 1) = "@" Then
                    arrobas = arrobas + 1
                End If
            Next
            If arrobas <> 1 Then
                valido = False
                MessageBox.Show("O email só pode ter 1 '@'")
            End If
        End If
        If valido = True Then
            arrobas = 0
            For I = InStr(str, "@") To Len(str)
                If Mid(str, I, 1) = "." Then
                    arrobas = arrobas + 1
                End If
            Next
            If arrobas > 2 Then
                valido = False
                MessageBox.Show("O email deve ter 1 '.' depois do '@'")
            End If
        End If
        If valido = True Then
            Dim Letra As String
            For I = 1 To Len(str)
                Letra = Mid(str, I, 1)
                If Not (LCase(Letra) Like "[a-z]" Or Letra = "@" Or Letra = "." Or Letra = "-" Or Letra = "_" Or IsNumeric(Letra)) Then
                    valido = False
                    MessageBox.Show("Email invalido")
                    Exit For
                End If
            Next
        End If

        Return valido
    End Function

    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtRG_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            MessageBox.Show("Esse campo aceita apenas numeros e letras")
            e.KeyChar = ""
        End If
    End Sub



    Private Sub CadProprietario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objDT = objProp.BuscarDadosTd()
        For i = 0 To objDT.Rows.Count - 1
            DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
        Next

        'Design
        pnlProp.Visible = False
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btnCancelar.Visible = False
        txtCancelar.Visible = False

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
        objDT = objProp.BuscarDadosEsp(TxtTexto.Text)
        For i = 0 To objDT.Rows.Count - 1
            DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
        Next
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick
        'entidade
        objProp.codigoProp = DgdGrade.CurrentRow.Cells(0).Value
        objProp.nome = DgdGrade.CurrentRow.Cells(1).Value
        objProp.rg = DgdGrade.CurrentRow.Cells(2).Value
        objProp.cpf = DgdGrade.CurrentRow.Cells(3).Value
        objProp.email = DgdGrade.CurrentRow.Cells(4).Value
        objProp.tel = DgdGrade.CurrentRow.Cells(5).Value
        objProp.BancoNm = DgdGrade.CurrentRow.Cells(6).Value
        objProp.BancoAgencia = DgdGrade.CurrentRow.Cells(7).Value
        objProp.BancoCorrente = DgdGrade.CurrentRow.Cells(8).Value
        objProp.bancoPoupanca = DgdGrade.CurrentRow.Cells(9).Value
        objProp.pix = DgdGrade.CurrentRow.Cells(10).Value
        'txts
        txtNome.Text = objProp.nome
        txtRG.Text = objProp.rg
        txtCPF.Text = objProp.cpf
        txtEmail.Text = objProp.email
        txtTel.Text = objProp.tel
        txtNmB.Text = objProp.BancoNm
        txtAgB.Text = objProp.BancoAgencia
        txtCcB.Text = objProp.BancoCorrente
        txtPpB.Text = objProp.bancoPoupanca
        txtPix.Text = objProp.pix

        novo = False

        'Design
        pnlProp.Visible = True
        btnSalvar.Visible = True
        txtSalvar.Visible = True
        btnDeletar.Visible = True
        txtDeletar.Visible = True
        btnNv.Visible = False
        txtNovo.Visible = False
        pnlHolder.ScrollControlIntoView(pnlProp)
        btnCancelar.Visible = True
        txtCancelar.Visible = True
    End Sub

    'ja copiei pra adiantar teu trabalho @tusita :)


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
        btnCancelar.Visible = True
        txtCancelar.Visible = True

        txtCPF.Text = ""
        txtNome.Text = ""
        txtRG.Text = ""
        txtEmail.Text = ""
        txtTel.Text = ""
        txtNmB.Text = ""
        txtAgB.Text = ""
        txtCcB.Text = ""
        txtPpB.Text = ""
        txtPix.Text = ""

        novo = True
    End Sub

    Private Sub btnSalvar_Click_1(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If Len(txtCpf.Text) = Len("00.000.000/0000-00") Or Len(txtCpf.Text) = Len("000.000.000/00") Then
            If Not (objBanco.validar_CPF(txtCpf.Text, Not (cbxCpfCnpj.Checked))) Then
                txtCpf.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("O tamanho do CPF ou CNPJ informado está incorreto")
            txtCpf.Focus()
            Exit Sub
        End If

        If txtEmail.Text <> "" Then
            If Not (SoEmail(txtEmail.Text)) Then
                txtEmail.Focus()
                Exit Sub
            End If
        End If
        If txtNome.Text = "" Or txtRG.Text = "" Or txtCPF.Text = "" Or txtEmail.Text = "" Or txtTel.Text = "" Then
            MessageBox.Show("Preencha os campos básicos antes de salvar")
            Exit Sub
        End If
        If novo Then
            objProp.codigoProp = objBanco.Loc_ultimo("cdprop", "tabprop")
        End If

        objProp.nome = txtNome.Text
        objProp.rg = txtRG.Text
        objProp.cpf = txtCPF.Text
        objProp.email = txtEmail.Text
        objProp.tel = txtTel.Text
        objProp.BancoNm = txtNmB.Text
        objProp.BancoAgencia = txtAgB.Text
        objProp.BancoCorrente = txtCcB.Text
        objProp.bancoPoupanca = txtPpB.Text
        objProp.pix = txtPix.Text

        objProp.Gravar_dados(novo)
        novo = False
        TxtTexto.Text = ""

        DgdGrade.Rows.Clear()
        objDT = objProp.BuscarDadosTd()
        For i = 0 To objDT.Rows.Count - 1
            DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
        Next

        'ajustes apos selecao

        txtCPF.Text = ""
        txtNome.Text = ""
        txtRG.Text = ""
        txtEmail.Text = ""
        txtTel.Text = ""
        txtNmB.Text = ""
        txtAgB.Text = ""
        txtCcB.Text = ""
        txtPpB.Text = ""
        txtPix.Text = ""

        'Design
        pnlProp.Visible = True
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btnNv.Visible = True
        txtNovo.Visible = True
        btnCancelar.Visible = False
        txtCancelar.Visible = False

        pnlProp.Visible = False
        pnlHolder.ScrollControlIntoView(lblO)
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        objProp.Excluir()

        txtCPF.Text = ""
        txtNome.Text = ""
        txtRG.Text = ""
        txtEmail.Text = ""
        txtTel.Text = ""
        txtNmB.Text = ""
        txtAgB.Text = ""
        txtCcB.Text = ""
        txtPpB.Text = ""
        txtPix.Text = ""
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

        pnlProp.Visible = False
        pnlHolder.ScrollControlIntoView(lblO)

        'recarregar planilha
        If TxtTexto.Text <> "" Then
            DgdGrade.Rows.Clear()
            objDT = objProp.BuscarDadosEsp(TxtTexto.Text)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        Else
            DgdGrade.Rows.Clear()
            objDT = objProp.BuscarDadosTd()
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Design
        btnSalvar.Visible = False
        txtSalvar.Visible = False
        btnDeletar.Visible = False
        txtDeletar.Visible = False
        btnNv.Visible = True
        txtNovo.Visible = True
        btnCancelar.Visible = False
        txtCancelar.Visible = False

        pnlProp.Visible = False
        pnlHolder.ScrollControlIntoView(lblO)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New CadastrosConsultas
        ActivateMdiChild(form)
        PaginaInicial.OpenChildForm(form)
    End Sub

    Private Sub pnlProp_Paint(sender As Object, e As PaintEventArgs) Handles pnlProp.Paint

    End Sub

    Private Sub cbxCpfCnpj_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCpfCnpj.CheckedChanged
        If cbxCpfCnpj.Checked Then
            txtCpf.Mask = "00.000.000/0000-00"
            cbxCpfCnpj.Text = "CNPJ (Marque para alterar para CPF)"
        Else
            txtCpf.Mask = "000.000.000-00"
            cbxCpfCnpj.Text = "CPF (Marque para alterar para CNPJ)"
        End If
    End Sub
End Class
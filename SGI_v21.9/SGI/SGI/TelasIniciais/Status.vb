Imports System.Security.Cryptography.X509Certificates

Public Class Status

    Dim objLoc As New ClsLoc
    Dim objDT As DataTable
    Dim objDT2 As DataTable

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

    Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
    Dim cSAtrasado As DataGridViewCellStyle = New DataGridViewCellStyle()
    Dim cSdia As DataGridViewCellStyle = New DataGridViewCellStyle()

    Private Function PagoMes(imo As Integer, inq As Integer, dt As Date) As Boolean
        Dim ret As Boolean = True

        objDT2 = objBanco.Localizar("SELECT * FROM TABPAGAMENTO WHERE imopag=" & imo & " and inqpag=" & inq & " and dtinipag=datevalue('" & dt & "') and dtpag=datevalue('" & Today.Date.AddDays(-Today.Day + 1) & "')")
        If objDT2.Rows.Count <> 0 Then
            ret = False
        End If
        Return ret
    End Function
    Private Sub btAlugueis_Click(sender As Object, e As EventArgs) Handles btAlugueis.Click
        Dim form As New CadPagamentos
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New EstatisticasPag
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub Status_Load(sender As Object, e As EventArgs) Handles Me.Load
        DoubleBuffered = True

        DgdGrade.Rows.Clear()
        objDT = objLoc.BuscarDadosTd(False)
        For i = 0 To objDT.Rows.Count - 1
            If PagoMes(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2)) Then
                DgdGrade.Rows.Add(objDT.Rows(i).Item(4), objDT.Rows(i).Item(6), objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2).date, objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            End If
        Next
        TxtTexto.Visible = False

        'formatação da celula caso a data do pagamento seja a mais de 5 dias
        cellStyle.BackColor = Color.FromArgb(213, 255, 196) ' green
        cellStyle.Font = New Font("Segoe UI", 11) ' Regular font
        DgdGrade.DefaultCellStyle = cellStyle

        'formatação da celula caso o pagamento esteja atrasado
        cSAtrasado.BackColor = Color.FromArgb(255, 182, 184) 'red
        cSAtrasado.Font = New Font("Segoe UI", 11) ' Regular font

        'formatação da celula caso a data do pagamento seja daqui 5 dias
        cSdia.BackColor = Color.FromArgb(254, 236, 138) 'yellow
        cSdia.Font = New Font("Segoe UI", 11) ' Regular font

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

        ' Set row height and alternate row color
        DgdGrade.RowTemplate.Height = 30
        DgdGrade.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255) ' White background for alternate rows
    End Sub

    Private Sub TxtTexto_TextChanged(sender As Object, e As EventArgs) Handles TxtTexto.TextChanged
        DgdGrade.Rows.Clear()
        objDT = objLoc.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, False)
        For i = 0 To objDT.Rows.Count - 1
            If PagoMes(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2)) Then
                DgdGrade.Rows.Add(objDT.Rows(i).Item(4), objDT.Rows(i).Item(6), objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2).date, objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            End If
        Next


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TxtTexto.Visible = True
    End Sub

    Private Sub DgdGrade_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgdGrade.CellFormatting

        If DgdGrade.Rows.Item(e.RowIndex).Cells(0).Value < Today.Day Then
            e.CellStyle = cSAtrasado
        ElseIf DgdGrade.Rows.Item(e.RowIndex).Cells(0).Value <= 5 Or DgdGrade.Rows.Item(e.RowIndex).Cells(0).Value - 5 <= Today.Day Then
            e.CellStyle = cSdia
        Else
            e.CellStyle = cellStyle
        End If

    End Sub
End Class
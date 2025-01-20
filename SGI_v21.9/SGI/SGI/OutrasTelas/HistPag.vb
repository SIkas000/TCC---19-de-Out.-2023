Public Class HistPag
    Dim objFin As New ClsFinanceiro
    Dim objBanco As New ClsBanco
    Dim objDt As New DataTable
    Private Sub btV_Click(sender As Object, e As EventArgs)
        Dim form As New CadPagamentos
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub HistPag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objDt = objFin.BuscarDadosTd()
        For i = 0 To objDt.Rows.Count - 1

            DgdGrade.Rows.Add(objDt.Rows(i).Item(0), objDt.Rows(i).Item(1), objDt.Rows(i).Item(2), objDt.Rows(i).Item(7), objDt.Rows(i).Item(6), objDt.Rows(i).Item(3).date, objDt.Rows(i).Item(4).date)
        Next

        dtpIni.Value = Today.AddMonths(-1)

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

    Private Sub btCalc_Click(sender As Object, e As EventArgs) Handles btCalc.Click
        lblR.Text = "Resultado: " & objBanco.InfoIndividual("SELECT sum(valpag) from tabpagamento where dtpag between datevalue('" & dtpIni.Value.Date & "') and datevalue('" & dtpFim.Value.Date & "')")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New CadPagamentos
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class
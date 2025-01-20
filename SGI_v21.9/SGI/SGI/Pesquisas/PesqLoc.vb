Public Class PesqLoc
    Public from As String
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

    Private Sub PesqLoc_Load(sender As Object, e As EventArgs) Handles Me.Load
        DgdGrade.Rows.Clear()
        objDT = objLoc.BuscarDadosTd(False)
        For i = 0 To objDT.Rows.Count - 1
            DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
        Next
        TxtTexto.Visible = False

        ' Set the DataGridView's background color
        DgdGrade.BackgroundColor = Color.White

        ' Style the column headers
        Dim headerStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(52, 58, 64) ' Dark gray background
        headerStyle.ForeColor = Color.White ' White text
        headerStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold) ' Bold font
        DgdGrade.ColumnHeadersDefaultCellStyle = headerStyle
        DgdGrade.BorderStyle = BorderStyle.None
        DgdGrade.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220)
        DgdGrade.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
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
        objLoc.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, True)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TxtTexto.Visible = True
    End Sub

    Private Sub cbxOcultar_CheckedChanged(sender As Object, e As EventArgs)
        If TxtTexto.Text <> "" Then
            DgdGrade.Rows.Clear()
            objLoc.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, True)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        Else
            DgdGrade.Rows.Clear()
            objDT = objLoc.BuscarDadosTd(True)
            For i = 0 To objDT.Rows.Count - 1
                DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(7), objDT.Rows(i).Item(1), objDT.Rows(i).Item(8), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10))
            Next
        End If
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick
        If from = "fin" Then
            Dim form As CadPagamentos
            form = PaginaInicial.ActiveMdiChild
            form.lblDt.Text = DgdGrade.CurrentRow.Cells(4).Value
            form.lblImo.Text = DgdGrade.CurrentRow.Cells(0).Value
            form.lblInq.Text = DgdGrade.CurrentRow.Cells(2).Value
            form.dPag = DgdGrade.CurrentRow.Cells(6).Value
        End If
        Me.Close()
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class
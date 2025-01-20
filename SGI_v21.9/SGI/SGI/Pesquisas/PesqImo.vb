
Public Class PesqImo
    Dim objImo As New ClsImo
    Dim objDT As DataTable

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim novo As Boolean

    Dim objBanco As New ClsBanco
    Dim temporario As String

    Public from As String
    Public Sub Preencher(i As Integer)
        temporario = objBanco.LocalizarCampo("nmprop", "tabprop", "cdprop", objDT.Rows(i).Item(17))
        DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), temporario)
    End Sub

    Private Sub PesqImo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If from = "loc" Then
            objDT = objImo.BuscarDadosTd("desocupado")
            For i = 0 To objDT.Rows.Count - 1
                Preencher(i)
            Next
        Else
            objDT = objImo.BuscarDadosTd("qualquer estado")
            For i = 0 To objDT.Rows.Count - 1
                Preencher(i)
            Next
        End If


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
        If from = "loc" Then
            objImo.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, "qualquer estado")
        Else
            objImo.BuscarDadosEsp(TxtTexto.Text, ComboBox2.Text, "qualquer estado")
        End If
    End Sub

    Private Sub DgdGrade_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgdGrade.CellMouseDoubleClick
        If from = "loc" Then
            Dim form As CadLocacao
            form = PaginaInicial.ActiveMdiChild

            form.codImo = DgdGrade.CurrentRow.Cells(0).Value
            form.lblmo.Text = DgdGrade.CurrentRow.Cells(0).Value
            form.codProp = DgdGrade.CurrentRow.Cells(17).Value
            form.txtPag.Value = DgdGrade.CurrentRow.Cells(6).Value
        ElseIf from = "vist" Then
            Dim vistorias As Vistorias
            vistorias = PaginaInicial.ActiveMdiChild
            vistorias.lblImo.Text = DgdGrade.CurrentRow.Cells(0).Value
        ElseIf from = "eve" Then
            Dim cal As Calendario
            cal = PaginaInicial.ActiveMdiChild
            cal.lblmo.Text = DgdGrade.CurrentRow.Cells(0).Value
        Else
            MessageBox.Show("ocorreu um problema")
        End If
        Me.Close()
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

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class
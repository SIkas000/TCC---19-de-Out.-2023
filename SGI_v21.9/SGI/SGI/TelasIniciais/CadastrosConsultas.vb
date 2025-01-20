Public Class CadastrosConsultas
    Public currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.Controls.Add(childForm)
        Me.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnInq_Click(sender As Object, e As EventArgs) Handles btnInq.Click
        Dim form As New CadInquilino
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        Dim form As New CadLocacao
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub btnImo_Click(sender As Object, e As EventArgs) Handles btnImo.Click
        Dim form As New CadImovel
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub btnPro_Click(sender As Object, e As EventArgs) Handles btnPro.Click
        Dim form As New CadProprietario
        PaginaInicial.defAtiForm(form)
    End Sub

    Private Sub CadastrosConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
    End Sub


    Private Sub btnImo_MouseHover(sender As Object, e As EventArgs) Handles btnImo.MouseHover
        btnImo.Image = My.Resources.imoveis2
    End Sub

    Private Sub btnImo_MouseLeave(sender As Object, e As EventArgs) Handles btnImo.MouseLeave
        btnImo.Image = My.Resources.imoveis1
    End Sub

    Private Sub btnInq_MouseHover(sender As Object, e As EventArgs) Handles btnInq.MouseHover
        btnInq.Image = My.Resources.inquilinos2
    End Sub

    Private Sub btnInq_MouseLeave(sender As Object, e As EventArgs) Handles btnInq.MouseLeave
        btnInq.Image = My.Resources.inquilinos1
    End Sub

    Private Sub btnLoc_MouseHover(sender As Object, e As EventArgs) Handles btnLoc.MouseHover
        btnLoc.Image = My.Resources.locacoes2
    End Sub

    Private Sub btnLoc_MouseLeave(sender As Object, e As EventArgs) Handles btnLoc.MouseLeave
        btnLoc.Image = My.Resources.locacoes1
    End Sub

    Private Sub btnPro_MouseHover(sender As Object, e As EventArgs) Handles btnPro.MouseHover
        btnPro.Image = My.Resources.proprietarios2
    End Sub
    Private Sub btnPro_MouseLeave(sender As Object, e As EventArgs) Handles btnPro.MouseLeave
        btnPro.Image = My.Resources.proprietarios1
    End Sub
End Class
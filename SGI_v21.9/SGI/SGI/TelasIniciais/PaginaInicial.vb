Imports System.IO
Imports System.Net.Mime.MediaTypeNames

Public Class PaginaInicial
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public resX As Integer
    Public resY As Integer
    Dim objBanco As New ClsBanco
    Dim dataEve As Date
    Dim exists As Boolean
    Dim sql As String
    Dim objDtLoc As DataTable
    Dim objDtEve As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 50)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(34, 60, 97)
            currentBtn.ForeColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'Current Form Icon
            IconCurrentForm.Image = currentBtn.Image
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(29, 53, 87)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.Overlay
        End If
    End Sub
    Public Sub OpenChildForm(childForm As Form)
        'Open Only 1 Form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = currentBtn.Text
        ActivateMdiChild(childForm)
    End Sub
    Private Sub reset()
        DisableButton()
        leftBorderBtn.Visible = False
        lblFormTitle.Text = "Página Inicial"
        IconCurrentForm.Image = My.Resources.home
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TopTab_MouseDown(sender As Object, e As MouseEventArgs) Handles TopTab.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TopTab_MouseMove(sender As Object, e As MouseEventArgs) Handles TopTab.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TopTab_MouseUp(sender As Object, e As MouseEventArgs) Handles TopTab.MouseUp
        drag = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        reset()
    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        ActivateButton(sender, RGBColors.color1)
        Dim form As New Calendario
        ActivateMdiChild(form)
        OpenChildForm(form)
    End Sub

    Private Sub btnCadCon_Click(sender As Object, e As EventArgs) Handles btnCadCon.Click
        ActivateButton(sender, RGBColors.color2)
        Dim form As New CadastrosConsultas
        ActivateMdiChild(form)
        OpenChildForm(form)
    End Sub

    Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color3)
        Dim form As New CadPagamentos
        ActivateMdiChild(form)
        OpenChildForm(form)
    End Sub


    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnSta.Click
        ActivateButton(sender, RGBColors.color4)
        Dim Form As New Status
        ActivateMdiChild(Form)
        OpenChildForm(Form)
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        ActivateButton(sender, RGBColors.color5)
        Dim Form As New Boleto
        ActivateMdiChild(Form)
        OpenChildForm(Form)
    End Sub

    Private Sub btnVis_Click(sender As Object, e As EventArgs) Handles btnVis.Click
        ActivateButton(sender, RGBColors.color7)
        Dim form As New Vistorias
        ActivateMdiChild(form)
        OpenChildForm(form)

    End Sub


    Private Sub btnMan_Click(sender As Object, e As EventArgs) Handles btnMan.Click
        Dim PDF As Byte() = My.Resources.Manual_SGI_v1 'mudar esse resource
        Using tmp As New FileStream("manual.pdf", FileMode.Create)
            tmp.Write(PDF, 0, PDF.Length)
        End Using
        Process.Start("manual.pdf")
    End Sub


    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.Image = My.Resources.closeRed
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = My.Resources.close
    End Sub

    Private Sub btnSair_MouseHover(sender As Object, e As EventArgs) Handles btnSair.MouseHover
        btnSair.ForeColor = Color.FromArgb(222, 75, 75)
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.ForeColor = Color.Gainsboro
    End Sub

    Private Sub CadPagEve()

        objDtLoc = objBanco.Localizar("SELECT inqloc,atiloc,dtploc,pagloc,imoloc FROM tabloc")
        objDtEve = objBanco.Localizar("SELECT nmeve FROM tabeve where tpeve='Pagamento de aluguel pendente'")

        For i = 0 To objDtLoc.Rows.Count - 1
            If objDtLoc.Rows(i).Item(1) = True Then
                If objDtLoc.Rows(i).Item(2) <= Date.Today.AddDays(5).Day Then
                    For j = 0 To objDtEve.Rows.Count - 1
                        exists = False
                        If objDtEve.Rows(j).Item(0) = "Aluguel do imovel " & objDtLoc.Rows(i).Item(4).value & " no mês " & Today.Month & " de " & Today.Year Then
                            exists = True
                        End If
                    Next
                    If exists = True Then
                        dataEve = Convert.ToDateTime(objDtLoc.Rows(i).Item(2).value & "/" & Date.Today.Month & "/" & Date.Today.Year)
                        sql = "insert into tabeve " &
                       "(cdeve" &
                       ",imoeve" &
                       ",dteve" &
                       ",tpeve" &
                       ",desceve" &
                       ",conceve" &
                       ",nmeve" &
                       ") values " &
                       "(" & objBanco.Loc_ultimo("cdeve", "tabeve") & "" &
                       "," & objDtLoc.Rows(i).Item(4) & "" &
                       ",'" & dataEve & "'" &
                       ",'" & "Pagamento de aluguel pendente" & "'" &
                       ",'" & "O inquilino de codigo " & objDtLoc.Rows(i).Item(0) & " e de nome " & objBanco.LocalizarCampo("nminq", "tabinq", "cdinq", objDtLoc.Rows(i).Item(0)) & " está com o pagamento de R$" & objDtLoc.Rows(i).Item(0) & " pendente. Assim que ele pagar, marque está tarefa como concluida ou vá na tela de status de pagamento e aperte o botão 'Atualizar situação do pagamento'." & "'" &
                       "," & False & "" &
                       ",'" & "Aluguel do imovel " & objDtLoc.Rows(i).Item(4) & " no mês " & Today.Month & " de " & Today.Year & "'" &
                       ")"
                        objBanco.Executar_comando(sql)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub PaginaInicial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        DoubleBuffered = True
        resX = PanelDesktop.Width
        resY = PanelDesktop.Height
        CadPagEve()

    End Sub

    Public Sub defAtiForm(form As Form)
        ActivateMdiChild(form)
        OpenChildForm(form)
    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class

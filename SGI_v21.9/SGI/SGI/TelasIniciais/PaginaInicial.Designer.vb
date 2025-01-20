<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaginaInicial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaginaInicial))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMan = New System.Windows.Forms.Button()
        Me.btnVis = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSta = New System.Windows.Forms.Button()
        Me.btnCadCon = New System.Windows.Forms.Button()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMain = New System.Windows.Forms.PictureBox()
        Me.TopTab = New System.Windows.Forms.Panel()
        Me.IconCurrentForm = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopTab.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnImp)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Controls.Add(Me.btnMan)
        Me.PanelMenu.Controls.Add(Me.btnVis)
        Me.PanelMenu.Controls.Add(Me.btnSair)
        Me.PanelMenu.Controls.Add(Me.btnSta)
        Me.PanelMenu.Controls.Add(Me.btnCadCon)
        Me.PanelMenu.Controls.Add(Me.btnCal)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 720)
        Me.PanelMenu.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Location = New System.Drawing.Point(0, 658)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(45, 1)
        Me.Panel2.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(210, 658)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(40, 1)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(46, 649)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Desenvolvido por TechBridge"
        '
        'btnMan
        '
        Me.btnMan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMan.BackgroundImage = Global.SGI.My.Resources.Resources.manual
        Me.btnMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMan.FlatAppearance.BorderSize = 0
        Me.btnMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMan.Location = New System.Drawing.Point(214, 683)
        Me.btnMan.Name = "btnMan"
        Me.btnMan.Size = New System.Drawing.Size(30, 30)
        Me.btnMan.TabIndex = 9
        Me.btnMan.UseVisualStyleBackColor = True
        '
        'btnVis
        '
        Me.btnVis.FlatAppearance.BorderSize = 0
        Me.btnVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVis.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVis.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVis.Image = Global.SGI.My.Resources.Resources.checklist
        Me.btnVis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVis.Location = New System.Drawing.Point(0, 389)
        Me.btnVis.Name = "btnVis"
        Me.btnVis.Size = New System.Drawing.Size(250, 50)
        Me.btnVis.TabIndex = 8
        Me.btnVis.Text = "Vistorias"
        Me.btnVis.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSair.Image = Global.SGI.My.Resources.Resources.exit__2_
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(0, 676)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 41)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSta
        '
        Me.btnSta.FlatAppearance.BorderSize = 0
        Me.btnSta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSta.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSta.Image = Global.SGI.My.Resources.Resources.status
        Me.btnSta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSta.Location = New System.Drawing.Point(0, 333)
        Me.btnSta.Name = "btnSta"
        Me.btnSta.Size = New System.Drawing.Size(250, 50)
        Me.btnSta.TabIndex = 4
        Me.btnSta.Text = "Status Imóveis"
        Me.btnSta.UseVisualStyleBackColor = True
        '
        'btnCadCon
        '
        Me.btnCadCon.FlatAppearance.BorderSize = 0
        Me.btnCadCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadCon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadCon.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCadCon.Image = Global.SGI.My.Resources.Resources.register
        Me.btnCadCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadCon.Location = New System.Drawing.Point(0, 227)
        Me.btnCadCon.Name = "btnCadCon"
        Me.btnCadCon.Size = New System.Drawing.Size(250, 50)
        Me.btnCadCon.TabIndex = 2
        Me.btnCadCon.Text = "Cadastros | Consultas"
        Me.btnCadCon.UseVisualStyleBackColor = True
        '
        'btnCal
        '
        Me.btnCal.FlatAppearance.BorderSize = 0
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCal.Image = Global.SGI.My.Resources.Resources.calendar
        Me.btnCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCal.Location = New System.Drawing.Point(0, 171)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(250, 50)
        Me.btnCal.TabIndex = 1
        Me.btnCal.Text = "Calendário"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMain)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 150)
        Me.Panel3.TabIndex = 0
        '
        'btnMain
        '
        Me.btnMain.Image = Global.SGI.My.Resources.Resources.logoTinaBrancoAzul
        Me.btnMain.Location = New System.Drawing.Point(0, 0)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(250, 150)
        Me.btnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMain.TabIndex = 1
        Me.btnMain.TabStop = False
        '
        'TopTab
        '
        Me.TopTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TopTab.Controls.Add(Me.IconCurrentForm)
        Me.TopTab.Controls.Add(Me.lblFormTitle)
        Me.TopTab.Controls.Add(Me.btnMin)
        Me.TopTab.Controls.Add(Me.btnClose)
        Me.TopTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopTab.Location = New System.Drawing.Point(250, 0)
        Me.TopTab.Name = "TopTab"
        Me.TopTab.Size = New System.Drawing.Size(1030, 50)
        Me.TopTab.TabIndex = 1
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.Image = Global.SGI.My.Resources.Resources.home
        Me.IconCurrentForm.Location = New System.Drawing.Point(8, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(30, 30)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(44, 12)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(144, 30)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "Página Inicial"
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.Location = New System.Drawing.Point(965, 12)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 20)
        Me.btnMin.TabIndex = 1
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(998, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackgroundImage = Global.SGI.My.Resources.Resources.bg_techbridge
        Me.PanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(250, 50)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1030, 670)
        Me.PanelDesktop.TabIndex = 2
        '
        'btnImp
        '
        Me.btnImp.FlatAppearance.BorderSize = 0
        Me.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImp.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnImp.Image = Global.SGI.My.Resources.Resources.printer
        Me.btnImp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImp.Location = New System.Drawing.Point(0, 277)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(250, 50)
        Me.btnImp.TabIndex = 13
        Me.btnImp.Text = "Impressão"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'PaginaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.TopTab)
        Me.Controls.Add(Me.PanelMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaginaInicial"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopTab.ResumeLayout(False)
        Me.TopTab.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TopTab As Panel
    Friend WithEvents btnMain As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnSta As Button
    Friend WithEvents btnCadCon As Button
    Friend WithEvents btnCal As Button
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As PictureBox
    Friend WithEvents btnVis As Button
    Friend WithEvents btnMan As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImp As Button
End Class

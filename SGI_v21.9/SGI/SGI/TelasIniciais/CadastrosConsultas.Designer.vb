<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastrosConsultas
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
        Me.btnImo = New System.Windows.Forms.Button()
        Me.btnInq = New System.Windows.Forms.Button()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnPro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnImo
        '
        Me.btnImo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnImo.BackgroundImage = Global.SGI.My.Resources.Resources.imoveis1
        Me.btnImo.FlatAppearance.BorderSize = 0
        Me.btnImo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImo.Location = New System.Drawing.Point(293, 180)
        Me.btnImo.Name = "btnImo"
        Me.btnImo.Size = New System.Drawing.Size(321, 195)
        Me.btnImo.TabIndex = 1
        Me.btnImo.UseVisualStyleBackColor = True
        '
        'btnInq
        '
        Me.btnInq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInq.BackgroundImage = Global.SGI.My.Resources.Resources.inquilinos1
        Me.btnInq.FlatAppearance.BorderSize = 0
        Me.btnInq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInq.Location = New System.Drawing.Point(645, 180)
        Me.btnInq.Name = "btnInq"
        Me.btnInq.Size = New System.Drawing.Size(321, 195)
        Me.btnInq.TabIndex = 2
        Me.btnInq.UseVisualStyleBackColor = True
        '
        'btnLoc
        '
        Me.btnLoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLoc.BackgroundImage = Global.SGI.My.Resources.Resources.locacoes1
        Me.btnLoc.FlatAppearance.BorderSize = 0
        Me.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoc.Location = New System.Drawing.Point(293, 404)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(321, 195)
        Me.btnLoc.TabIndex = 3
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnPro
        '
        Me.btnPro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPro.BackgroundImage = Global.SGI.My.Resources.Resources.proprietarios1
        Me.btnPro.FlatAppearance.BorderSize = 0
        Me.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPro.Location = New System.Drawing.Point(645, 404)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(321, 195)
        Me.btnPro.TabIndex = 4
        Me.btnPro.UseVisualStyleBackColor = True
        '
        'CadastrosConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGI.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 783)
        Me.Controls.Add(Me.btnPro)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.btnInq)
        Me.Controls.Add(Me.btnImo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadastrosConsultas"
        Me.Text = "CadastrosConsultas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImo As Button
    Friend WithEvents btnInq As Button
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnPro As Button
End Class

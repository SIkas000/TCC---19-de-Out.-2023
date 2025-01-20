Imports System.Diagnostics.Eventing.Reader
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TelaLogin

    Dim Pos As Point

    Private Sub TelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        txtPassword.UseSystemPasswordChar = True
        txtError.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String = "usuario"
        Dim currentTime As String = DateTime.Now.Minute
        Dim password As String = "tech"
        Dim enteredPassword As String = txtPassword.Text
        Dim passwordCheck As String = currentTime + password + currentTime

        If enteredPassword = passwordCheck And txtUser.Text = user Then
            PaginaInicial.Show()
            Me.Hide()
        Else
            txtError.Visible = True
            txtPassword.Text = ""
            txtPassword.Focus()
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


        If CheckBox1.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
            CheckBox1.BackgroundImage = My.Resources.olho_cruzado
        Else
            txtPassword.UseSystemPasswordChar = True
            CheckBox1.BackgroundImage = My.Resources.olho
        End If

    End Sub


End Class
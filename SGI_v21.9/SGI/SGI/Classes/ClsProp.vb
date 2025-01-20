Public Class ClsProp
    Dim i_cd As Integer
    Dim i_nm As String
    Dim i_rg As String
    Dim i_cpf As String
    Dim i_eml As String
    Dim i_tel As String
    Dim i_bcnm As String
    Dim i_bcag As String
    Dim i_bccrt As String
    Dim i_bcpp As String
    Dim i_pix As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDT As New DataTable
    Public Property codigoProp As Integer
        Get
            Return i_cd
        End Get
        Set(value As Integer)
            i_cd = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return i_nm
        End Get
        Set(value As String)
            i_nm = value
        End Set
    End Property

    Public Property rg As String
        Get
            Return i_rg
        End Get
        Set(value As String)
            i_rg = value
        End Set
    End Property

    Public Property cpf As String
        Get
            Return i_cpf
        End Get
        Set(value As String)
            i_cpf = value
        End Set
    End Property

    Public Property tel As String
        Get
            Return i_tel
        End Get
        Set(value As String)
            i_tel = value
        End Set
    End Property

    Public Property email As String
        Get
            Return i_eml
        End Get
        Set(value As String)
            i_eml = value
        End Set
    End Property

    Public Property BancoNm As String
        Get
            Return i_bcnm
        End Get
        Set(value As String)
            i_bcnm = value
        End Set
    End Property

    Public Property BancoAgencia As String
        Get
            Return i_bcag
        End Get
        Set(value As String)
            i_bcag = value
        End Set
    End Property

    Public Property BancoCorrente As String
        Get
            Return i_bccrt
        End Get
        Set(value As String)
            i_bccrt = value
        End Set
    End Property

    Public Property bancoPoupanca As String
        Get
            Return i_bcpp
        End Get
        Set(value As String)
            i_bcpp = value
        End Set
    End Property

    Public Property pix As String
        Get
            Return i_pix
        End Get
        Set(value As String)
            i_pix = value
        End Set
    End Property

    'funções
    Public Function BuscarDadosEsp(campo As String) As DataTable
        sql = "select * from tabprop where nmprop like '" & campo & "%' order by nmprop"
        objDT = objBanco.Localizar(Sql)
        Return objDT
    End Function

    Public Function BuscarDadosTd() As DataTable
        sql = "select * from tabprop order by nmprop"
        objDT = objBanco.Localizar(Sql)
        Return objDT
    End Function

    Public Sub Gravar_dados(novo As Boolean)
        If novo = True Then
            'mudar
            sql = "insert into tabprop " &
                  "(cdprop" &
                  ",nmprop" &
                  ",rgprop" &
                  ",cpfprop" &
                  ",emlprop" &
                  ",telprop" &
                  ",bcnmprop" &
                  ",bcagprop" &
                  ",bccrtprop" &
                  ",bcppprop" &
                  ",bcpixprop" &
                  ") values " &
                  "('" & i_cd & "'" &
                  ",'" & i_nm & "'" &
                  ",'" & i_rg & "'" &
                  ",'" & i_cpf & "'" &
                  ",'" & i_eml & "'" &
                  ",'" & i_tel & "'" &
                  ",'" & i_bcnm & "'" &
                  ",'" & i_bcag & "'" &
                  ",'" & i_bccrt & "'" &
                  ",'" & i_bcpp & "'" &
                  ",'" & i_pix & "'" &
                  ")"
            objBanco.Executar_comando(sql)
        Else
            'mudar
            sql = "update tabprop set " &
                  " nmprop='" & i_nm & "'" &
                  ",rgprop='" & i_rg & "'" &
                  ",cpfprop='" & i_cpf & "'" &
                  ",emlprop='" & i_eml & "'" &
                  ",telprop='" & i_tel & "'" &
                  ",bcnmprop='" & i_bcnm & "'" &
                  ",bcagprop='" & i_bcag & "'" &
                  ",bccrtprop='" & i_bccrt & "'" &
                  ",bcppprop='" & i_bcpp & "'" &
                  ",bcpixprop='" & i_pix & "'" &
                  " where cdprop=" & i_cd
            objBanco.Executar_comando(Sql)
        End If

    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabprop where cdprop=" & codigoProp
            objBanco.Executar_comando(sql)
            Return True
        End If
        Return False
    End Function
End Class

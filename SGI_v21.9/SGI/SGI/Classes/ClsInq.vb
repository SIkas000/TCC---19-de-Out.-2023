Public Class ClsInq
    Dim i_cd As Integer
    Dim i_nom As String
    Dim i_rg As String
    Dim i_cpf As String
    Dim i_email As String
    Dim i_tel As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDT As New DataTable

    Public Property codigoInq As Integer
        Get
            Return i_cd
        End Get
        Set(value As Integer)
            i_cd = value
        End Set
    End Property
    Public Property NomeInq As String
        Get
            Return i_nom
        End Get
        Set(value As String)
            i_nom = value
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

    Public Property CPF As String
        Get
            Return i_cpf
        End Get
        Set(value As String)
            i_cpf = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return i_email
        End Get
        Set(value As String)
            i_email = value
        End Set
    End Property

    Public Property telefone As String
        Get
            Return i_tel
        End Get
        Set(value As String)
            i_tel = value
        End Set
    End Property

    Public Function BuscarDadosEsp(campo As String, rest As Boolean, x As Boolean) As DataTable
        If rest Then
            sql = "select * from tabinq where nminq like '" & campo & "%' and atiinq=" & x & " order by nminq"
            objDT = objBanco.Localizar(sql)
            Return objDT
        End If
        sql = "select * from tabinq where nminq like '" & campo & "%' order by nminq"
        objDT = objBanco.Localizar(sql)
        Return objDT
    End Function

    Public Function BuscarDadosTd(rest As Boolean, x As Boolean) As DataTable
        If rest Then
            sql = "select * from tabinq where atiinq=" & x & " order by nminq"
            objDT = objBanco.Localizar(sql)
            Return objDT
        End If
        sql = "select * from tabinq order by nminq"
        objDT = objBanco.Localizar(sql)
        Return objDT
    End Function

    Public Sub Gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "insert into tabinq " &
                  "(cdinq" &
                  ",nminq" &
                  ",rginq" &
                  ",cpfinq" &
                  ",emlinq" &
                  ",telinq" &
                  ",atiinq" &
                  ") values " &
                  "('" & i_cd & "'" &
                  ",'" & i_nom & "'" &
                  ",'" & i_rg & "'" &
                  ",'" & i_cpf & "'" &
                  ",'" & i_email & "'" &
                  ",'" & i_tel & "'" &
                  ",false" &
                  ")"
            objBanco.Executar_comando(sql)
        Else
            sql = "update tabinq set " &
                  " nminq='" & i_nom & "'" &
                  ",rginq='" & i_rg & "'" &
                  ",cpfinq='" & i_cpf & "'" &
                  ",emlinq='" & i_email & "'" &
                  ",telinq='" & i_tel & "'" &
                  " where cdinq=" & i_cd
            objBanco.Executar_comando(sql)
        End If

    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabinq where cdinq=" & codigoInq
            objBanco.Executar_comando(sql)
            Return True
        End If
        Return False
    End Function

End Class

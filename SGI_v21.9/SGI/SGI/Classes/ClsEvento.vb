Public Class ClsEvento
    Dim i_cd As Integer
    Dim i_nm As String
    Dim i_desc As String
    Dim i_dt As Date
    Dim i_imo As Integer
    Dim i_tp As String
    Dim i_conc As Boolean
    Dim i_rec As Boolean


    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDT As New DataTable
    Dim temp As String
    Public Property Nome() As String
        Get
            Return i_nm
        End Get
        Set(value As String)
            i_nm = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return i_desc
        End Get
        Set(value As String)
            i_desc = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return i_tp
        End Get
        Set(value As String)
            i_tp = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return i_cd
        End Get
        Set(value As Integer)
            i_cd = value
        End Set
    End Property

    Public Property Imovel() As Integer
        Get
            Return i_imo
        End Get
        Set(value As Integer)
            i_imo = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return i_dt
        End Get
        Set(value As Date)
            i_dt = value
        End Set
    End Property

    Public Property Concluido() As Boolean
        Get
            Return i_conc
        End Get
        Set(value As Boolean)
            i_conc = value
        End Set
    End Property

    Public Property Rec() As Boolean
        Get
            Return i_conc
        End Get
        Set(value As Boolean)
            i_conc = value
        End Set
    End Property

    Public Function BuscarDadosEsp(rest As String, cdimo As String)
        If cdimo = "" Then
            If rest = "Qualquer tipo" Then
                sql = "select * from tabeve where conceve=false order by dteve"
            Else
                sql = "select * from tabeve where tpeve='" & rest & "' and conceve=false order by dteve"
            End If
        Else
            If rest = "Qualquer tipo" Then
                sql = "select * from tabeve where conceve=false and imoeve=" & cdimo & " order by dteve"
            Else
                sql = "select * from tabeve where tpeve='" & rest & "' and conceve=false and imoeve=" & cdimo & " order by dteve"
            End If
        End If
        objDT = objBanco.Localizar(sql)
        Return objDT
    End Function

    Public Sub Gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "insert into tabeve " &
                   "(cdeve" &
                   ",imoeve" &
                   ",dteve" &
                   ",tpeve" &
                   ",desceve" &
                   ",conceve" &
                   ",nmeve" &
                   ") values " &
                   "(" & i_cd & "" &
                   "," & i_imo & "" &
                   ",'" & i_dt & "'" &
                   ",'" & i_tp & "'" &
                   ",'" & i_desc & "'" &
                   "," & False & "" &
                   ",'" & i_nm & "'" &
                   ")"
        Else
            sql = "update tabeve set " &
                  " imoeve=" & i_imo & "" &
                  " ,dteve='" & i_dt & "'" &
                  " ,tpeve='" & i_tp & "'" &
                  " ,desceve='" & i_desc & "'" &
                  " ,nmeve='" & i_nm & "'" &
                  " where cdeve=" & i_cd
        End If
        objBanco.Executar_comando(sql)

    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabeve where cdeve=" & i_cd
            objBanco.Executar_comando(sql)
            Return True
        End If
        Return False
    End Function

    Public Sub defCon()
        If MessageBox.Show("Deseja Concluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "update tabeve set " &
                  " conceve=" & True &
                  " where cdeve=" & i_cd
            objBanco.Executar_comando(sql)
        End If
    End Sub
End Class

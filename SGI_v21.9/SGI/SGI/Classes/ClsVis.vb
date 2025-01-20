Imports System.Xml

Public Class ClsVis
    Dim i_cd As Integer
    Dim i_imo As Integer
    Dim i_dt As Date
    Dim i_doc As String
    Dim i_tp As String
    Dim i_desc As String

    Dim objBanco As New ClsBanco
    Dim objDtT As New DataTable
    Dim objDt As New DataTable
    Dim temp1 As String
    Dim temp2 As String
    Dim temp3 As String
    Dim Sql As String
    Dim Sql2 As String


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

    Public Property Documento() As String
        Get
            Return i_doc
        End Get
        Set(value As String)
            i_doc = value
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

    Public Property Descricao() As String
        Get
            Return i_desc
        End Get
        Set(value As String)
            i_desc = value
        End Set
    End Property

    Public Sub BuscarDadosEsp(campo As String, rest As Boolean)
        Dim vistorias As Vistorias
        vistorias = PaginaInicial.ActiveMdiChild
        vistorias.DgdGrade.Rows.Clear()
        objDtT = objBanco.Loc_coluna("cdimo", "tabimov", "ruaimo like '" & campo & "%'")
        For x = 0 To objDtT.Rows.Count - 1
            Sql = "select * from tabvist where imovist= " & objDtT.Rows(x).Item(0)
            objDt = objBanco.Localizar(Sql)
            For i = 0 To objDt.Rows.Count - 1
                temp1 = objBanco.LocalizarCampo("ruaimo", "tabimov", "cdimo", objDt.Rows(i).Item(1))
                temp2 = objBanco.LocalizarCampo("nmimo", "tabimov", "cdimo", objDt.Rows(i).Item(1))
                temp3 = objBanco.LocalizarCampo("cmpimo", "tabimov", "cdimo", objDt.Rows(i).Item(1))
                vistorias.DgdGrade.Rows.Add(objDt.Rows(i).Item(0), objDt.Rows(i).Item(1), temp1, temp2, temp3, objDt.Rows(i).Item(2), objDt.Rows(i).Item(3), objDt.Rows(i).Item(4), objDt.Rows(i).Item(5))
            Next
        Next
    End Sub

    Public Sub BuscarDadosTd(rest As Boolean)
        Dim vistorias As Vistorias
        vistorias = PaginaInicial.ActiveMdiChild
        If Not (rest) Then
            Sql = "select * from tabvist order by dtvist"
        Else
            Sql = "select * from tabvist where dtvist >datevalue('" & Date.Today.Date & "') order by dtvist"
        End If

        objDt = objBanco.Localizar(Sql)
        For i = 0 To objDt.Rows.Count - 1
            temp1 = objBanco.LocalizarCampo("ruaimo", "tabimov", "cdimo", objDt.Rows(i).Item(1))
            temp2 = objBanco.LocalizarCampo("nmimo", "tabimov", "cdimo", objDt.Rows(i).Item(1))
            temp3 = objBanco.LocalizarCampo("cmpimo", "tabimov", "cdimo", objDt.Rows(i).Item(1))
            vistorias.DgdGrade.Rows.Add(objDt.Rows(i).Item(0), objDt.Rows(i).Item(1), temp1, temp2, temp3, objDt.Rows(i).Item(2), objDt.Rows(i).Item(3), objDt.Rows(i).Item(4), objDt.Rows(i).Item(5))
        Next
    End Sub

    Public Sub Gravar_dados(novo As Boolean)
        If novo = True Then
            Sql = "insert into tabvist " &
                   "(cdvist" &
                   ",imovist" &
                   ",dtvist" &
                   ",docvist" &
                   ",tpvist" &
                   ",descvist" &
                   ") values " &
                   "(" & i_cd & "" &
                   "," & i_imo & "" &
                   ",'" & i_dt & "'" &
                   ",'" & i_doc & "'" &
                   ",'" & i_tp & "'" &
                   ",'" & i_desc & "'" &
                   ")"
            temp1 = objBanco.Loc_ultimo("cdEve", "tabEve")
            Sql2 = "insert into tabeve " &
                   "(cdeve" &
                   ",dteve" &
                   ",nmeve" &
                   ",desceve" &
                   ",tpeve" &
                   ",imoeve" &
                   ",conceve" &
                   ") values " &
                   "(" & temp1 & "" &
                   ",'" & i_dt & "'" &
                   ",'Vistoria gerada automaticamente'" &
                   ",'Vistoria no logradouro: " & objBanco.LocalizarCampo("ruaimo", "tabimov", "cdimo", i_imo) & "'" &
                   ",'vistoria'" &
                   "," & i_imo & "" &
                   ",false" &
                   ")"

        Else
            Sql = "update tabvist set " &
                  " imovist=" & i_imo & "" &
                  " ,dtvist='" & i_dt & "'" &
                  " ,docvist='" & i_doc & "'" &
                  " ,tpvist='" & i_tp & "'" &
                  " ,descvist='" & i_desc & "'" &
                  " where cdvist=" & i_cd
        End If
        objBanco.Executar_comando(Sql)
        objBanco.Executar_comando(Sql2)
    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Sql = "Delete from tabvist where cdvist=" & i_cd
            objBanco.Executar_comando(Sql)
            Return True
        End If
        Return False
    End Function
End Class
Imports System.Windows.Forms.VisualStyles

Public Class ClsLoc
    Dim i_imo As Integer
    Dim i_inq As Integer
    Dim i_dtLoc As Date
    Dim i_ati As Boolean
    Dim i_dtF As Date
    Dim i_dPag As Integer
    Dim i_pag As Single

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDT As New DataTable

    Public atiChanged As Boolean


    Public Property CodImo() As Integer
        Get
            Return i_imo
        End Get
        Set(value As Integer)
            i_imo = value
        End Set
    End Property

    Public Property CodInq() As Integer
        Get
            Return i_inq
        End Get
        Set(value As Integer)
            i_inq = value
        End Set
    End Property

    Public Property dtInLoc() As Date
        Get
            Return i_dtLoc
        End Get
        Set(value As Date)
            i_dtLoc = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return i_ati
        End Get
        Set(value As Boolean)
            i_ati = value
        End Set
    End Property

    Public Property DtFimLoc() As Date
        Get
            Return i_dtF
        End Get
        Set(value As Date)
            i_dtF = value
        End Set
    End Property

    Public Property diaDoPag() As Integer
        Get
            Return i_dPag
        End Get
        Set(value As Integer)
            i_dPag = value
        End Set
    End Property

    Public Property Pag() As Single
        Get
            Return i_pag
        End Get
        Set(value As Single)
            i_pag = value
        End Set
    End Property

    Public Function BuscarDadosEsp(campo As String, campoP As String, Rest As Boolean) As DataTable

        If Rest Then
            If campoP = "Nome do inquilino" Then
                sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo ,tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabinq.nminq like '" & campo & "%'"
            ElseIf campoP = "Rua do imovel" Then
                sql = "Select tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo, tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabimov.ruaimo like '" & campo & "%'"
            ElseIf campoP = "Nome do proprietário" Then
                sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo, tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabprop.nmprop like '" & campo & "%'"
            End If
        Else
            If campoP = "Nome do inquilino" Then
                sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo, tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabloc.ATILOC = true and tabinq.nminq like '" & campo & "%'"
            ElseIf campoP = "Rua do imovel" Then
                sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo, tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabloc.ATILOC = true and tabimov.ruaimo like '" & campo & "%'"
            ElseIf campoP = "Nome do proprietário" Then
                sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo, tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabloc.ATILOC = true and tabprop.nmprop like '" & campo & "%'"
            End If
        End If
        objDT = objBanco.Localizar(sql)
        Return objDT
    End Function

    Public Function BuscarDadosTd(Rest As Boolean) As DataTable
        If Rest Then
            sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo ,tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo"
        Else
            sql = "SELECT tabloc.*, tabimov.ruaimo, tabinq.nminq, tabimov.propimo, tabprop.nmprop From tabprop INNER Join (tabinq INNER Join (tabimov INNER Join tabloc On tabimov.cdimo = tabloc.imoloc) ON tabinq.cdinq = tabloc.inqloc) ON tabprop.cdprop = tabimov.propimo WHERE tabloc.ATILOC = true"
        End If
        objDT = objBanco.Localizar(sql)
        Return objDT
    End Function

    Public Sub Gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "insert into tabloc " &
                   "(imoloc" &
                   ",inqloc" &
                   ",dtloc" &
                   ",atiloc" &
                   ",dtploc" &
                   ",pagloc" &
                   ") values " &
                   "('" & i_imo & "'" &
                   ",'" & i_inq & "'" &
                   ",'" & i_dtLoc.Date & "'" &
                   ",true" &
                   "," & i_dPag & "" &
                   ",'" & i_pag & "'" &
                   ")"
        Else
            If i_ati Then
                sql = "update tabloc set " &
                  " atiloc=true" &
                  " ,dtploc=" & i_dPag & "" &
                  " ,dtfloc=NULL" &
                  " ,pagloc='" & i_pag & "'" &
                  " where imoloc=" & i_imo & " and inqloc=" & i_inq & "and dtloc=datevalue('" & dtInLoc & "')"
            Else
                sql = "update tabloc set " &
                  " atiloc=false" &
                  " ,dtploc=" & i_dPag & "" &
                  " ,dtfloc='" & i_dtF & "'" &
                  " ,pagloc='" & i_pag & "'" &
                  " where imoloc=" & i_imo & " and inqloc=" & i_inq & "and dtloc=datevalue('" & dtInLoc & "')"
            End If
        End If
        objBanco.Executar_comando(sql)

        'mudanças em outras tabelas
        If atiChanged Then
            If i_ati Then
                sql = "update tabimov set" &
                " estimo='alugado'" &
                " where cdimo=" & i_imo
            Else
                sql = "update tabimov set" &
                " estimo='desocupado'" &
                " where cdimo=" & i_imo
            End If
            objBanco.Executar_comando(sql)

            sql = "update tabinq set" &
            " atiinq=" & i_ati &
            " where cdinq=" & i_inq
            objBanco.Executar_comando(sql)
        End If
        sql = ""
    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabloc where imoloc=" & i_imo & " And inqloc=" & i_inq & " And dtloc='" & i_dtLoc.Date & "'"
            objBanco.Executar_comando(sql)
            Return True
        End If
        Return False
    End Function
End Class

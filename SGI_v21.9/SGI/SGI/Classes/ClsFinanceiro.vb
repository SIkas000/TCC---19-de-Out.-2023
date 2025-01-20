Public Class ClsFinanceiro

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDT As New DataTable

    Dim i_cd As Integer
    Dim i_imo As Integer
    Dim i_inq As Integer
    Dim i_dtIni As Date
    Dim i_dt As Date

    Public Property Codigo As Integer
        Get
            Return i_cd
        End Get
        Set(value As Integer)
            i_cd = value
        End Set
    End Property

    Public Property CdImo As Integer
        Get
            Return i_imo
        End Get
        Set(value As Integer)
            i_imo = value
        End Set
    End Property
    Public Property cdInq As Integer
        Get
            Return i_inq
        End Get
        Set(value As Integer)
            i_inq = value
        End Set
    End Property
    Public Property DtIni As Date
        Get
            Return i_dtIni
        End Get
        Set(value As Date)
            i_dtIni = value
        End Set
    End Property
    Public Property Dt As Date
        Get
            Return i_dt
        End Get
        Set(value As Date)
            i_dt = value
        End Set
    End Property

    Public Function BuscarDadosTd() As DataTable
        sql = "SELECT tabPagamento.*, tabinq.nminq, tabimov.ruaimo FROM (tabPagamento INNER JOIN tabimov ON tabPagamento.imopag = tabimov.cdimo) INNER JOIN tabinq ON tabPagamento.inqpag = tabinq.cdinq;"
        objDT = objBanco.Localizar(sql)
        Return objDT
    End Function

    Public Sub Gravar_dados()
        sql = "insert into tabpagamento " &
                  "(cdpag" &
                  ",imopag" &
                  ",inqpag" &
                  ",dtinipag" &
                  ",dtpag" &
                  ",valpag" &
                  ") values " &
                  "('" & i_cd & "'" &
                  ",'" & i_imo & "'" &
                  ",'" & i_inq & "'" &
                  ",'" & i_dtIni.Date & "'" &
                  ",'" & i_dt.Date & "'" &
                  ",'" & objBanco.InfoIndividual("SELECT pagloc from tabloc where imoloc = " & i_imo & "and inqloc =" & i_inq) & "'" &
                  ")"
        objBanco.Executar_comando(sql)
    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabpagamento where cdpag=" & Codigo
            objBanco.Executar_comando(sql)
            Return True
        End If
        Return False
    End Function
End Class

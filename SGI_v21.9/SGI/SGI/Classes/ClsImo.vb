Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ClsImo
    Dim i_cd As Integer
    Dim i_cep As String
    Dim i_nm As Integer
    Dim i_cmp As String
    Dim i_sb As String
    Dim i_en As String
    Dim i_alu As Double
    Dim i_iptuV As Double
    Dim i_valV As Double
    Dim i_valP As Double
    Dim i_iptuR As String
    Dim i_obs As String
    Dim i_rua As String
    Dim i_bai As String
    Dim i_cid As String
    Dim i_uf As String
    Dim i_est As String
    Dim i_prop As Integer

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDT As New DataTable
    Dim temp As String
    Dim objDtT As New DataTable
    Public Property codigoImo As Integer
        Get
            Return i_cd
        End Get
        Set(value As Integer)
            i_cd = value
        End Set
    End Property

    Public Property CEP As String
        Get
            Return i_cep
        End Get
        Set(value As String)
            i_cep = value
        End Set
    End Property

    Public Property RegIptu As String
        Get
            Return i_iptuR
        End Get
        Set(value As String)
            i_iptuR = value
        End Set
    End Property


    Public Property numero As Integer
        Get
            Return i_nm
        End Get
        Set(value As Integer)
            i_nm = value
        End Set
    End Property

    Public Property complemento As String
        Get
            Return i_cmp
        End Get
        Set(value As String)
            i_cmp = value
        End Set
    End Property

    Public Property sabesp As String
        Get
            Return i_sb
        End Get
        Set(value As String)
            i_sb = value
        End Set
    End Property

    Public Property enel As String
        Get
            Return i_en
        End Get
        Set(value As String)
            i_en = value
        End Set
    End Property

    Public Property aluguel As Double
        Get
            Return i_alu
        End Get
        Set(value As Double)
            i_alu = value
        End Set
    End Property

    Public Property valorV As Double
        Get
            Return i_valV
        End Get
        Set(value As Double)
            i_valV = value
        End Set
    End Property

    Public Property valorP As Double
        Get
            Return i_valP
        End Get
        Set(value As Double)
            i_valP = value
        End Set
    End Property

    Public Property ValIptu As Double
        Get
            Return i_iptuV
        End Get
        Set(value As Double)
            i_iptuV = value
        End Set
    End Property

    Public Property obs As String
        Get
            Return i_obs
        End Get
        Set(value As String)
            i_obs = value
        End Set
    End Property

    Public Property rua As String
        Get
            Return i_rua
        End Get
        Set(value As String)
            i_rua = value
        End Set
    End Property

    Public Property bairro As String
        Get
            Return i_bai
        End Get
        Set(value As String)
            i_bai = value
        End Set
    End Property

    Public Property cidade As String
        Get
            Return i_cid
        End Get
        Set(value As String)
            i_cid = value
        End Set
    End Property

    Public Property UF As String
        Get
            Return i_uf
        End Get
        Set(value As String)
            i_uf = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return i_est
        End Get
        Set(value As String)
            i_est = value
        End Set
    End Property

    Public Property proprietario As Integer
        Get
            Return i_prop
        End Get
        Set(value As Integer)
            i_prop = value
        End Set
    End Property

    Public Sub BuscarDadosEsp(campo As String, campoP As String, rest As String)

        Dim Cadimovel As CadImovel
        Cadimovel = PaginaInicial.ActiveMdiChild
        Cadimovel.DgdGrade.Rows.Clear()
        If rest = "Qualquer estado" Then
            If campoP = "Rua" Then
                sql = "select i.*, p.nmprop from tabimov i inner join tabprop p on i.propimo = p.cdprop where i.ruaimo like '" & campo & "%' order by i.ruaimo"
                objDT = objBanco.Localizar(sql)
                For i = 0 To objDT.Rows.Count - 1
                    Cadimovel.DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), objDT.Rows(i).Item(18))
                Next
            ElseIf campoP = "CEP" Then
                sql = "select i.*, p.nmprop from tabimov i inner join tabprop p on i.propimo = p.cdprop where i.cepimo like '" & campo & "%' order by i.ruaimo"
                objDT = objBanco.Localizar(sql)
                For i = 0 To objDT.Rows.Count - 1
                    Cadimovel.DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), objDT.Rows(i).Item(18))
                Next
            ElseIf campoP = "Nome do Proprietário" Then
                sql = "select i.*, p.nmprop from tabimov i inner join tabprop p on i.propimo = p.cdprop where i.propimo in (select cdprop from tabprop where nmprop like '" & campo & "%') order by i.ruaimo"
                objDT = objBanco.Localizar(sql)
                For i = 0 To objDT.Rows.Count - 1
                    Cadimovel.DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), objDT.Rows(i).Item(18))
                Next
            End If
        Else
            If campoP = "Rua" Then
                sql = "select i.*, p.nmprop from tabimov i inner join tabprop p on i.propimo = p.cdprop where i.ruaimo like '" & campo & "%' and i.estimo='" & rest & "' order by i.ruaimo"
                objDT = objBanco.Localizar(sql)
                For i = 0 To objDT.Rows.Count - 1
                    Cadimovel.DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), objDT.Rows(i).Item(18))
                Next
            ElseIf campoP = "CEP" Then
                sql = "select i.*, p.nmprop from tabimov i inner join tabprop p on i.propimo = p.cdprop where i.cepimo like '" & campo & "%' and i.estimo='" & rest & "' order by i.ruaimo"
                objDT = objBanco.Localizar(sql)
                For i = 0 To objDT.Rows.Count - 1
                    Cadimovel.DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), objDT.Rows(i).Item(18))
                Next
            ElseIf campoP = "Nome do Proprietário" Then
                sql = "select i.*, p.nmprop from tabimov i inner join tabprop p on i.propimo = p.cdprop where i.propimo in (select cdprop from tabprop where nmprop like '" & campo & "%') and i.estimo='" & rest & "' order by i.ruaimo"
                objDT = objBanco.Localizar(sql)
                For i = 0 To objDT.Rows.Count - 1
                    Cadimovel.DgdGrade.Rows.Add(objDT.Rows(i).Item(0), objDT.Rows(i).Item(1), objDT.Rows(i).Item(2), objDT.Rows(i).Item(3), objDT.Rows(i).Item(4), objDT.Rows(i).Item(5), objDT.Rows(i).Item(6), objDT.Rows(i).Item(7), objDT.Rows(i).Item(8), objDT.Rows(i).Item(9), objDT.Rows(i).Item(10), objDT.Rows(i).Item(11), objDT.Rows(i).Item(12), objDT.Rows(i).Item(13), objDT.Rows(i).Item(14), objDT.Rows(i).Item(15), objDT.Rows(i).Item(16), objDT.Rows(i).Item(17), objDT.Rows(i).Item(18))
                Next
            End If
        End If

    End Sub

    Public Function BuscarDadosTd(rest As String) As DataTable
        If rest = "Qualquer estado" Then
            sql = "select * from tabimov order by ruaimo"
            objDT = objBanco.Localizar(sql)
            Return objDT
        Else
            sql = "select * from tabimov where estimo='" & rest & "' order by ruaimo"
            objDT = objBanco.Localizar(sql)
            Return objDT
        End If
    End Function

    Public Sub Gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "insert into tabimov " &
                  "(cdimo" &
                  ",cepimo" &
                  ",nmimo" &
                  ",cmpimo" &
                  ",sbimo" &
                  ",eneimo" &
                  ",aluimo" &
                  ",valprefimo" &
                  ",valmercimo" &
                  ",cdiptuimo" &
                  ",valiptuimo" &
                  ",obsimo" &
                  ",ruaimo" &
                  ",baiimo" &
                  ",cidimo" &
                  ",ufimo" &
                  ",estimo" &
                  ",propimo" &
                  ") values " &
                  "('" & i_cd & "'" &
                  ",'" & i_cep & "'" &
                  ",'" & i_nm & "'" &
                  ",'" & i_cmp & "'" &
                  ",'" & i_sb & "'" &
                  ",'" & i_en & "'" &
                  ",'" & i_alu & "'" &
                  ",'" & i_valP & "'" &
                  ",'" & i_valV & "'" &
                  ",'" & i_iptuR & "'" &
                  ",'" & i_iptuV & "'" &
                  ",'" & i_obs & "'" &
                  ",'" & i_rua & "'" &
                  ",'" & i_bai & "'" &
                  ",'" & i_cid & "'" &
                  ",'" & i_uf & "'" &
                  ",'" & i_est & "'" &
                  ",'" & i_prop & "'" &
                  ")"
            objBanco.Executar_comando(sql)
        Else
            sql = "update tabimov set " &
                  " cepimo='" & i_cep & "'" &
                  " ,nmimo='" & i_nm & "'" &
                  " ,cmpimo='" & i_cmp & "'" &
                  " ,sbimo='" & i_sb & "'" &
                  " ,eneimo='" & i_en & "'" &
                  " ,aluimo='" & i_alu & "'" &
                  " ,valprefimo='" & i_valP & "'" &
                  " ,valmercimo='" & i_valV & "'" &
                  " ,cdiptuimo='" & i_iptuR & "'" &
                  " ,valiptuimo='" & i_iptuV & "'" &
                  " ,obsimo='" & i_obs & "'" &
                  " ,ruaimo='" & i_rua & "'" &
                  " ,baiimo='" & i_bai & "'" &
                  " ,cidimo='" & i_cid & "'" &
                  " ,ufimo='" & i_uf & "'" &
                  " ,estimo='" & i_est & "'" &
                  " ,propimo='" & i_prop & "'" &
                  " where cdimo=" & i_cd
            objBanco.Executar_comando(sql)
        End If

    End Sub

    Public Function Excluir() As Boolean
        If MessageBox.Show("Deseja Excluir? Isso levará ao apagamento de todos os cadastros relacionados.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabimov where cdimo=" & codigoImo
            objBanco.Executar_comando(sql)
            Return True
        End If
        Return False
    End Function
End Class

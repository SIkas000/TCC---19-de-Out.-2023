Imports System.IO
Imports System.Runtime.ConstrainedExecution
Imports System.Web.UI

Public Class ClsBanco
    Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=BancoTinaImoveis.accdb"
    Dim objcon As New OleDb.OleDbConnection(conexao)
    Dim sqlLoc As String
    Private Sub Abrir_banco()
        objcon.Open()
    End Sub

    Public Function validar_CPF(cpfTest As String, cpf As Boolean) As Boolean
        Dim ger
        Dim tot
        Dim multi
        Dim parte
        Dim resto
        Dim digito1
        Dim digito2
        Dim DoisdigitosDigitado
        Dim DoisDigitosCalculado
        Dim t1
        Dim t2
        Dim cpfTest2
        If cpf Then
            'primeiro digito
            multi = 10
            For X = 1 To 12
                If X <> 4 And X <> 8 And X <> 12 Then 'local onde tem . e -
                    parte = (Mid(cpfTest, X, 1))
                    tot = parte * multi
                    multi = multi - 1
                    ger = ger + tot
                End If
            Next
            resto = ger Mod 11
            If resto = 0 Or resto = 1 Then
                digito1 = 0
            Else
                digito1 = 11 - resto
            End If

            'segundo dígito
            cpfTest2 = Mid(cpfTest, 1, 13)
            tot = 0
            ger = 0
            multi = 11

            For X = 1 To 13
                If X <> 4 And X <> 8 And X <> 12 Then 'local onde tem . e -
                    parte = (Mid(cpfTest2, X, 1))
                    tot = parte * multi
                    multi = multi - 1
                    ger = ger + tot
                End If
            Next
            resto = ger Mod 11
            If resto = 0 Or resto = 1 Then
                digito2 = 0
            Else
                digito2 = 11 - resto
            End If
            DoisDigitosCalculado = digito1 & digito2
            DoisdigitosDigitado = Mid(cpfTest, 13, 2)
            If DoisdigitosDigitado = DoisDigitosCalculado Then
                Return True
            Else
                MessageBox.Show("CPF inválido, digite novamente")
                Return False
            End If
        Else

            For X = 1 To 15
                If X <> 3 And X <> 7 And X <> 11 And X <> 16 Then 'local onde tem . e -
                    parte = (Mid(cpfTest, X, 1))
                    If X >= 1 And X <= 5 Then
                        If X = 1 Then
                            tot = 0
                            multi = 5
                        End If
                        tot = parte * multi
                        multi = multi - 1
                        t1 = t1 + tot
                    ElseIf X >= 6 And X <= 18 Then
                        If X = 6 Then
                            tot = 0
                            multi = 9
                        End If
                        tot = parte * multi
                        multi = multi - 1
                        t2 = t2 + tot
                    End If
                    ger = t1 + t2
                End If
            Next
            resto = ger Mod 11
            If resto < 2 Then
                digito1 = 0
            Else
                digito1 = 11 - resto
            End If

            'segundo dígito
            t1 = 0
            t2 = 0
            tot = 0
            ger = 0
            multi = 11

            For X = 1 To 17
                If X <> 3 And X <> 7 And X <> 11 And X <> 16 Then 'local onde tem . e -
                    parte = (Mid(cpfTest, X, 1))
                    If X >= 1 And X <= 6 Then
                        If X = 1 Then
                            tot = 0
                            multi = 6
                        End If
                        tot = parte * multi
                        multi = multi - 1
                        t1 = t1 + tot
                    ElseIf X >= 7 And X <= 18 Then

                        If X = 8 Then
                            tot = 0
                            multi = 9
                        End If

                        tot = parte * multi
                        multi = multi - 1
                        t2 = t2 + tot

                    End If
                    ger = t1 + t2
                End If
            Next
            resto = ger Mod 11
            If resto < 2 Then
                digito2 = 0
            Else
                digito2 = 11 - resto
            End If
            DoisDigitosCalculado = digito1 & digito2
            DoisdigitosDigitado = Mid(cpfTest, 17, 2)
            If DoisdigitosDigitado = DoisDigitosCalculado Then
                Return True
            Else
                MessageBox.Show("CNPJ inválido, digite novamente")
                Return False
            End If
        End If
    End Function
    Private Sub Fechar_banco()
        If objcon.State = ConnectionState.Open Then
            objcon.Close()
        End If
    End Sub
    Public Sub Executar_comando(sql As String)
        Abrir_banco()
        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        objcmd.ExecuteNonQuery()
        Fechar_banco()
    End Sub

    Public Function Localizar(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function InfoIndividual(sql As String) As String
        Dim objDTLocal As DataTable
        objDTLocal = Localizar(sql)
        Try
            Return objDTLocal.Rows(0).Item(0)
        Catch
            Return "0"
        End Try
    End Function

    Public Function Loc_ultimo(cod As String, tab As String) As Integer
        Dim objDTLocal As DataTable
        sqlLoc = "select max(" & cod & ") from " & tab
        objDTLocal = Localizar(sqlLoc)
        Try
            Return Val(objDTLocal.Rows(0).Item(0)) + 1
        Catch
            Return 0
        End Try
    End Function

    Public Function LocalizarCampo(campo As String, tab As String, campoP As String, pesq As String) As String
        Dim objDTLocal As DataTable
        sqlLoc = "select " & campo & " from " & tab & " where " & campoP & " = " & pesq
        objDTLocal = Localizar(sqlLoc)
        Return objDTLocal.Rows(0).Item(0)
    End Function

    Public Function Loc_coluna(campo As String, tab As String, rest As String) As DataTable
        Dim objDTLocal As DataTable
        If rest <> "" Then
            sqlLoc = "select " & campo & " from " & tab & " where " & rest
        Else
            sqlLoc = "select " & campo & " from " & tab
        End If
        objDTLocal = Localizar(sqlLoc)
        Return objDTLocal
    End Function
End Class
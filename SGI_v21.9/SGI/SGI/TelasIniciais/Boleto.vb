'BOLETOS QUE DA PARA GERAR :

'Banrisul  conta.CarteiraPadrao = "1"

'Bradesco conta.CarteiraPadrao = "09"

'Brasil conta.CarteiraPadrao = "17" onta.VariacaoCarteiraPadrao = "019" OU "027" 

'Caixa Econômica Federal - conta.CarteiraPadrao = "SIG14" 

'Itau  conta.CarteiraPadrao = "109" OU 112

'Santander conta.CarteiraPadrao = "101" 

'Sicoob conta.CarteiraPadrao = "1 " conta.VariacaoCarteiraPadrao = "01" 

'Install-Package NReco.PdfGenerator -Version 1.1.15

Imports Boleto2Net
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes
Imports System.Security.Cryptography

Public Class Boleto
    Dim objBoletos As New Boletos
    Dim strImpressora As String = Nothing
    Dim blnImprimir As Boolean = False
    Dim intCopias As Short = 1
    Dim ds As New DataSet

    Private caminho As String = ""
    Public bai As String
    Public uf As String
    Public cid As String
    Public rua As String

    Public CpfValidated As Boolean = False
    Private Sub GerarPDF(path As String)
        Try
            ''CRIAÇÃO DA PARTE DO CEDENTE
            'Cabeçalho do Banco
            'essas informações são da TinaImoveis
            objBoletos.Banco = Banco.Instancia(237) 'Codigo da Agencia (Pega pesquisando ou na pasta Banco.cs da extenção)
            objBoletos.Banco.Cedente = New Cedente
            objBoletos.Banco.Cedente.CPFCNPJ = "24.368.434/0001-07"
            objBoletos.Banco.Cedente.Nome = "TINA IMOVEIS"

            Dim conta As New ContaBancaria
            conta.Agencia = "1234"
            conta.DigitoAgencia = "0"
            conta.OperacaoConta = String.Empty
            conta.Conta = "12345"
            conta.DigitoConta = "0"

            conta.CarteiraPadrao = "09" 'Numero da Carteira

            conta.VariacaoCarteiraPadrao = "" 'coloca apenas quando tem um "-" no carteira exemplo do Sicoob que é 1-01
            conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples
            conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro
            conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa
            conta.TipoDocumento = TipoDocumento.Tradicional

            'AQUI É O ENDEREÇO DA TINAIMOVEIS
            Dim ender As New Endereco
            ender.LogradouroEndereco = "ENDEREÇO"
            ender.LogradouroNumero = "0"
            ender.LogradouroComplemento = "COMPLEMENTO"
            ender.Bairro = "BAIRRO"
            ender.Cidade = "CIDADE"
            ender.UF = "UF"
            ender.CEP = "000"

            'Essas informações dependem de banco para banco, pfv de uma olhada dps pra ver como fazer isso aqui
            objBoletos.Banco.Cedente.Codigo = "123456"
            objBoletos.Banco.Cedente.CodigoDV = "6"
            objBoletos.Banco.Cedente.CodigoTransmissao = "000000"
            objBoletos.Banco.Cedente.ContaBancaria = conta
            objBoletos.Banco.Cedente.Endereco = ender

            objBoletos.Banco.FormataCedente()

            For I As Integer = 1 To 1

                'CRIAÇÃO DO TITULO
                'essas sao as informações de quem irá pagar o boleto
                Dim Titulo As New Boleto2Net.Boleto(objBoletos.Banco)
                Titulo.Sacado = New Sacado With {
                    .CPFCNPJ = txtCpf.Text,
                    .Endereco = New Boleto2Net.Endereco With {
                    .Bairro = "(" & bai & ")",
                    .CEP = mskCep.Text,
                    .Cidade = "(" & cid & ")",
                    .LogradouroComplemento = txtComp.Text,
                    .LogradouroEndereco = "(" & rua & " - " & bai & ", " & cid & " - " & uf & ", " & mskCep.Text & ")",
                    .LogradouroNumero = txtNum.Value,
                    .uf = "(" & uf & ")"},
                    .Nome = "(" & txtNom.Text & ")",
                    .Observacoes = "(" & txtObs.Text & ")"
                }
                'não verificado
                Titulo.CodigoOcorrencia = "01"
                Titulo.DescricaoOcorrencia = "(teste 14)"
                Titulo.NumeroDocumento = I
                Titulo.NumeroControleParticipante = "12"
                Titulo.NossoNumero = "123456" & I
                'verificado
                Titulo.DataEmissao = Now.Date
                Titulo.DataVencimento = Now.Date.AddDays(15)
                Titulo.ValorTitulo = txtVal.Value 'valor do boleto
                Titulo.Aceite = "N"

                Titulo.CodigoProtesto = TipoCodigoProtesto.NaoProtestar
                Titulo.DiasProtesto = 0
                Titulo.CodigoBaixaDevolucao = TipoCodigoBaixaDevolucao.NaoBaixarNaoDevolver
                Titulo.DiasBaixaDevolucao = 0
                Titulo.ValidarDados()
                objBoletos.Add(Titulo)
            Next

            'não sei oq essa parte faz
            '
            If File.Exists(Application.StartupPath & "\remessa.txt") Then
                File.Delete(Application.StartupPath & "\remessa.txt")
            End If

            'GERA ARQUIVO DE REMESSA

            Dim st As New MemoryStream

            'Para gerar um boleto de agencia diferente tera que muadar "TipoArquivo.CNAB400"

            Dim remessa = New ArquivoRemessa(objBoletos.Banco, TipoArquivo.CNAB400, 4)
            remessa.GerarArquivoRemessa(objBoletos, st)
            Dim arquivo As New FileStream(Application.StartupPath & "\remessa.txt", FileMode.Create, FileAccess.ReadWrite)

            st.WriteTo(arquivo)
            arquivo.Close()
            st.Close()


            Dim LerArquivo As New StreamReader(Application.StartupPath & "\remessa.txt")

            Dim RefazArquivo As New StreamWriter(Application.StartupPath & "\remessa2.txt") 'Arquivo verificado para ser enviado ao banco
            Dim strTexto As String = Nothing
            Dim conta1 As Integer = 0
            Do While LerArquivo.Peek <> -1
                strTexto = LerArquivo.ReadLine
                conta1 = strTexto.Length
                If conta1 < 240 Then
                    conta1 = 240 - conta1
                    Dim strEspaco As String = Nothing
                    For I As Integer = 1 To conta1
                        strEspaco = strEspaco & " "
                    Next
                    RefazArquivo.WriteLine(strTexto & strEspaco)
                Else
                    RefazArquivo.WriteLine(strTexto)
                End If

            Loop
            RefazArquivo.Close()
            LerArquivo.Close()

            'Gera boletos
            Dim numBoletos As Integer = 0
            For Each linha In objBoletos
                numBoletos += 1
                Dim NovoBoleto = New BoletoBancario
                NovoBoleto.Boleto = linha
                Dim pdf = NovoBoleto.MontaBytesPDF(False)
                File.WriteAllBytes(path, pdf)
            Next

            'outras alterações

            CpfValidated = False

            bai = ""
            rua = ""
            cid = ""
            uf = ""

            txtCpf.Text = ""
            txtNom.Text = ""
            txtVal.Value = 0
            mskCep.Text = ""
            txtNum.Value = 0
            txtComp.Text = ""
            txtObs.Text = ""


            MessageBox.Show("Boleto Gerado.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnGerarPDF.Click
        If CpfValidated And txtVal.Value <> 0 And txtNom.Text <> "" Then
            SFD.Filter = "pdf files (*.PDF)|*.PDF"
            SFD.ShowDialog()
            caminho = SFD.FileName
            GerarPDF(Path.GetFullPath(SFD.FileName))
        Else
            MessageBox.Show("Por favor, mostre os campos")
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        PesqLoc.Show()
        PesqLoc.from = "bol"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCepValidate.Click
        Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=" & Trim(mskCep.Text.Replace("-", "")) & "&formato=xml"
        ds.Clear()
        ds.ReadXml(xml)

        If ds.Tables(0).Rows(0)("resultado") = 1 Then
            rua = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
            bai = ds.Tables(0).Rows(0)("bairro")
            cid = ds.Tables(0).Rows(0)("cidade")
            uf = ds.Tables(0).Rows(0)("uf")
            CpfValidated = True
            MessageBox.Show("CEP validado para " & rua)
        Else
            MessageBox.Show("CEP NÃO LOCALIZADO")
            mskCep.Clear()
            mskCep.Focus()
            bai = ""
            rua = ""
            cid = ""
            uf = ""
            CpfValidated = False
        End If
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        If caminho = "" Then
            OFD.Filter = "pdf files (*.PDF)|*.PDF"
            OFD.ShowDialog()
            caminho = OFD.FileName
        End If
        Try
            Process.Start(caminho)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbxM_CheckedChanged(sender As Object, e As EventArgs) Handles cbxM.CheckedChanged
        If cbxM.Checked Then
            txtVal.Value = txtVal.Value * 1.2
        Else
            txtVal.Value = txtVal.Value * 5 / 6
        End If
    End Sub
End Class
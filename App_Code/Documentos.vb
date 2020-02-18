﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Text
Imports System
Imports System.Security
Imports Microsoft.VisualBasic.CompilerServices

Public Class Documentos

    Private CI02_ID_DOCUMENTOS As Integer
    Private CI01_ID_ALUNO As Integer
    Private CI02_NM_MAE As String
    Private CI02_NU_CPF_MAE As String
    Private CI02_NM_PAI As String
    Private CI02_NU_CPF_PAI As String
    Private CI02_NU_TELEFONE_RESPONSAVEL As String
    Private CI02_NU_RG_ALUNO As String
    Private CI02_DT_EMISSAO_RG_ALUNO As String
    Private CI02_DT_NASCIMENTO_ALUNO As String
    Private CI02_TP_SEXO_ALUNO As String
    Private CI02_DH_CADASTRO As String

    Public Property IdDocumentos As Integer
        Get
            Return CI02_ID_DOCUMENTOS
        End Get
        Set(value As Integer)
            CI02_ID_DOCUMENTOS = value
        End Set
    End Property

    Public Property NomeMae As String
        Get
            Return CI02_NM_MAE
        End Get
        Set(value As String)
            CI02_NM_MAE = value
        End Set
    End Property

    Public Property CpfMae As String
        Get
            Return CI02_NU_CPF_MAE
        End Get
        Set(value As String)
            CI02_NU_CPF_MAE = value
        End Set
    End Property

    Public Property NomePai As String
        Get
            Return CI02_NM_PAI
        End Get
        Set(value As String)
            CI02_NM_PAI = value
        End Set
    End Property

    Public Property CpfPai As String
        Get
            Return CI02_NU_CPF_PAI
        End Get
        Set(value As String)
            CI02_NU_CPF_PAI = value
        End Set
    End Property

    Public Property TelefoneResponsavel As String
        Get
            Return CI02_NU_TELEFONE_RESPONSAVEL
        End Get
        Set(value As String)
            CI02_NU_TELEFONE_RESPONSAVEL = value
        End Set
    End Property

    Public Property RgAluno As String
        Get
            Return CI02_NU_RG_ALUNO
        End Get
        Set(value As String)
            CI02_NU_RG_ALUNO = value
        End Set
    End Property

    Public Property EmissaoRgAluno As String
        Get
            Return CI02_DT_EMISSAO_RG_ALUNO
        End Get
        Set(value As String)
            CI02_DT_EMISSAO_RG_ALUNO = value
        End Set
    End Property

    Public Property NascimentoAluno As String
        Get
            Return CI02_DT_NASCIMENTO_ALUNO
        End Get
        Set(value As String)
            CI02_DT_NASCIMENTO_ALUNO = value
        End Set
    End Property

    Public Property SexoAluno As String
        Get
            Return CI02_TP_SEXO_ALUNO
        End Get
        Set(value As String)
            CI02_TP_SEXO_ALUNO = value
        End Set
    End Property

    Public Property DataHoraCadastro As String
        Get
            Return CI02_DH_CADASTRO
        End Get
        Set(value As String)
            CI02_DH_CADASTRO = value
        End Set
    End Property

    Public Property Codigo As Integer
        Get
            Return CI01_ID_ALUNO
        End Get
        Set(value As Integer)
            CI01_ID_ALUNO = value
        End Set
    End Property




    Public Sub Obter(ByVal Codigo As Integer)
        Dim cnn As New Conexao
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSQL As New StringBuilder

        strSQL.Append(" select * ")
        strSQL.Append(" from CI02_DOCUMENTOS ")
        strSQL.Append(" where CI02_ID_DOCUMENTOS =" & IdDocumentos)

        dt = cnn.AbrirDataTable(strSQL.ToString)

        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)

            CI02_ID_DOCUMENTOS = DoBanco(dr("CI02_ID_DOCUMENTOS"), eTipoValor.CHAVE)
            CI01_ID_ALUNO = DoBanco(dr("CI01_ID_ALUNO"), eTipoValor.CHAVE)
            CI02_NM_MAE = DoBanco(dr("CI02_NM_MAE"), eTipoValor.TEXTO)
            CI02_NU_CPF_MAE = DoBanco(dr("CI02_NU_CPF_MAE"), eTipoValor.TEXTO_LIVRE)
            CI02_NM_PAI = DoBanco(dr(" CI02_NM_PAI"), eTipoValor.TEXTO)
            CI02_NU_CPF_PAI = DoBanco(dr("CI02_NU_CPF_PAI"), eTipoValor.TEXTO_LIVRE)
            CI02_NU_TELEFONE_RESPONSAVEL = DoBanco(dr("CI02_NU_TELEFONE_RESPONSAVEL"), eTipoValor.TEXTO)
            CI02_NU_RG_ALUNO = DoBanco(dr("CI02_NU_RG_ALUNO"), eTipoValor.TEXTO)
            CI02_DT_EMISSAO_RG_ALUNO = DoBanco(dr("CI02_DT_EMISSAO_RG_ALUNO"), eTipoValor.DATA)
            CI02_DT_NASCIMENTO_ALUNO = DoBanco(dr("CI02_DT_NASCIMENTO_ALUNO"), eTipoValor.DATA)
            CI02_TP_SEXO_ALUNO = DoBanco(dr("CI02_TP_SEXO_ALUNO"), eTipoValor.TEXTO_LIVRE)
            CI02_DH_CADASTRO = DoBanco(dr("CI02_DH_CADASTRO"), eTipoValor.DATA_COMPLETA)
        End If

        cnn = Nothing
    End Sub

    Public Sub New(Optional ByVal IdDocumentos As Integer = 0)
        If IdDocumentos > 0 Then
            Obter(IdDocumentos)
        End If
    End Sub


    Public Sub Salvar()
        Dim cnn As New Conexao
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSQL As New StringBuilder

        strSQL.Append(" select * ")
        strSQL.Append(" from CI02_DOCUMENTOS")
        strSQL.Append(" where CI01_ID_ALUNO =" & Codigo)


        dt = cnn.EditarDataTable(strSQL.ToString)

        If dt.Rows.Count = 0 Then
            dr = dt.NewRow
        Else
            dr = dt.Rows(0)
        End If

        dr("CI02_ID_DOCUMENTOS") = ProBanco(CI02_ID_DOCUMENTOS, eTipoValor.CHAVE)
        dr("CI01_ID_ALUNO") = ProBanco(CI01_ID_ALUNO, eTipoValor.CHAVE)
        dr("CI02_NM_MAE") = ProBanco(CI02_NM_MAE, eTipoValor.TEXTO)
        dr("CI02_NU_CPF_MAE") = ProBanco(CI02_NU_CPF_MAE, eTipoValor.TEXTO_LIVRE)
        dr("CI02_NM_PAI") = ProBanco(CI02_NM_PAI, eTipoValor.TEXTO)
        dr("CI02_NU_CPF_PAI") = ProBanco(CI02_NU_CPF_PAI, eTipoValor.TEXTO_LIVRE)
        dr("CI02_NU_TELEFONE_RESPONSAVEL") = ProBanco(CI02_NU_TELEFONE_RESPONSAVEL, eTipoValor.TEXTO)
        dr("CI02_NU_RG_ALUNO") = ProBanco(CI02_NU_RG_ALUNO, eTipoValor.TEXTO)
        dr("CI02_DT_EMISSAO_RG_ALUNO") = ProBanco(CI02_DT_EMISSAO_RG_ALUNO, eTipoValor.DATA)
        dr("CI02_DT_NASCIMENTO_ALUNO") = ProBanco(CI02_DT_NASCIMENTO_ALUNO, eTipoValor.DATA)
        dr("CI02_TP_SEXO_ALUNO") = ProBanco(CI02_TP_SEXO_ALUNO, eTipoValor.TEXTO_LIVRE)
        dr("CI02_DH_CADASTRO") = ProBanco(CI02_DH_CADASTRO, eTipoValor.DATA_COMPLETA)

        cnn.SalvarDataTable(dr)

        dt.Dispose()
        dt = Nothing

        cnn = Nothing
    End Sub





    Public Function Pesquisar(Optional ByVal Sort As String = "",
                              Optional ByVal IdDocumentos As Integer = 0,
                              Optional ByVal Codigo As Integer = 0,
                              Optional ByVal NomeMae As String = "",
                              Optional ByVal CpfMae As String = "",
                              Optional ByVal NomePai As String = "",
                              Optional ByVal CpfPai As String = "",
                              Optional ByVal TelefoneResponsavel As String = "",
                              Optional ByVal RgAluno As String = "",
                              Optional ByVal EmissaoRgAluno As String = "",
                              Optional ByVal NascimentoAluno As String = "",
                              Optional ByVal SexoAluno As String = "",
                              Optional ByVal DataHoraCadastro As String = "") As DataTable
        Dim cnn As New Conexao
        Dim strSQL As New StringBuilder


        strSQL.Append(" select * ")
        strSQL.Append(" from CI02_DOCUMENTOS")
        strSQL.Append(" where CI02_ID_DOCUMENTOS Is Not null")


        If IdDocumentos > 0 Then
            strSQL.Append(" And CI02_ID_DOCUMENTOS = " & IdDocumentos)
        End If

        If Codigo > 0 Then
            strSQL.Append(" And CI01_ID_ALUNO = " & Codigo)
        End If

        If NomeMae <> "" Then
            strSQL.Append(" And upper(CI02_NM_MAE) Like '%" & NomeMae.ToUpper & "%'")
        End If

        If CpfMae <> "" Then
            strSQL.Append(" and upper(CI02_NU_CPF_MAE) like '%" & CpfMae.ToUpper & "%'")
        End If

        If NomePai <> "" Then
            strSQL.Append(" and upper( CI02_NM_PAI) like '%" & NomePai.ToUpper & "%'")
        End If

        If CpfPai <> "" Then
            strSQL.Append(" and upper( CI02_NU_CPF_PAI) like '%" & CpfPai.ToUpper & "%'")
        End If

        If TelefoneResponsavel <> "" Then
            strSQL.Append(" and upper(CI02_NU_TELEFONE_RESPONSAVEL) like '%" & TelefoneResponsavel.ToUpper & "%'")
        End If

        If RgAluno <> "" Then
            strSQL.Append(" and upper(CI02_NU_RG_ALUNO) like '%" & RgAluno.ToUpper & "%'")
        End If

        If EmissaoRgAluno <> "" Then
            strSQL.Append(" and upper(CI02_DT_EMISSAO_RG_ALUNO) like '%" & EmissaoRgAluno.ToUpper & "%'")
        End If

        If NascimentoAluno <> "" Then
            strSQL.Append(" and upper(CI02_DT_NASCIMENTO_ALUNO) like '%" & NascimentoAluno.ToUpper & "%'")
        End If

        If SexoAluno <> "" Then
            strSQL.Append(" and upper(CI02_TP_SEXO_ALUNO) like '%" & SexoAluno.ToUpper & "%'")
        End If

        If SexoAluno <> "" Then
            strSQL.Append(" and upper(CI02_DH_CADASTRO) like '%" & DataHoraCadastro.ToUpper & "%'")
        End If

        strSQL.Append(" Order By " & IIf(Sort = "", "CI02_NM_MAE", Sort))

        Return cnn.AbrirDataTable(strSQL.ToString)
    End Function



    Public Function ObterTabela() As DataTable
        Dim cnn As New Conexao
        Dim dt As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append(" select CI02_ID_DOCUMENTOS as CODIGO, CI01_NM_ALUNO as DESCRICAO")
        strSQL.Append(" from CI02_DOCUMENTOS")

        dt = cnn.AbrirDataTable(strSQL.ToString)

        '
        cnn = Nothing

        Return dt
    End Function

    Public Function ObterUltimo() As Integer
        Dim cnn As New Conexao
        Dim strSQL As New StringBuilder
        Dim CodigoUltimo As Integer

        strSQL.Append(" select max(CI02_ID_DOCUMENTOS) from CI02_DOCUMENTOS")

        With cnn.AbrirDataTable(strSQL.ToString)
            If Not IsDBNull(.Rows(0)(0)) Then
                CodigoUltimo = .Rows(0)(0)
            Else
                CodigoUltimo = 0
            End If
        End With

        '
        cnn = Nothing

        Return CodigoUltimo

    End Function
    Public Function Inserir(ByVal Codigo As Integer) As Integer
        Dim cnn As New Conexao
        Dim strSQL As New StringBuilder
        Dim LinhasAfetadas As Integer

        strSQL.Append(" select ")
        strSQL.Append(" from CI02_ALUNO")
        strSQL.Append(" where CI01_ID_ALUNO = " & Codigo)

        LinhasAfetadas = cnn.ExecutarSQL(strSQL.ToString)

        '
        cnn = Nothing

        Return LinhasAfetadas
    End Function


End Class

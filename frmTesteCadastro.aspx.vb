
Partial Class frmTesteCadastro
    Inherits System.Web.UI.Page
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdAluno.Text = Request.QueryString("id")
        Validacao.Outros(txtCpfMae, False, "CPF",, Validacao.eFormato.CPF)
        Validacao.Outros(txtCpfPai, False, "CPF",, Validacao.eFormato.CPF)
        Validacao.Outros(txtTelefoneResponsavel, False, "CPF",, Validacao.eFormato.CELULAR)
        Validacao.Outros(txtRgAluno, False, "RG",, Validacao.eFormato.RG)
        JavaScript.ExibirConfirmacao(btnSalvar, eTipoConfirmacao.SALVAR)
    End Sub

    Private Function VerificarRgAluno() As Boolean
        Dim objDocumentos As New Documentos
        Dim Existe As Boolean = False

        With objDocumentos.Pesquisar(,,, Replace(Replace(txtRgAluno.Text, ".", ""), "-", ""))

            If .Rows.Count > 0 Then
                MsgBox("RG já Cadastrado", eCategoriaMensagem.ALERTA)
                Existe = True
            End If
        End With

        objDocumentos = Nothing
        Return Existe
    End Function

    Public Sub Salvar()
        Dim objDocumentos As New Documentos(ViewState("IdDocumentos"))
        With objDocumentos
            If VerificarRgAluno() = True Then
                Exit Sub
            End If
            .Codigo = IdAluno.Text
            .NomeMae = txtNomeMae.Text
            .CpfMae = txtCpfMae.Text
            .NomePai = txtNomePai.Text
            .CpfPai = txtCpfPai.Text
            .RgAluno = Replace(Replace(txtRgAluno.Text, ".", ""), "-", "")
            .EmissaoRgAluno = txtEmissaoRgAluno.Text
            .NascimentoAluno = txtNascimentoAluno.Text
            .SexoAluno = txtSexoAluno.Text
            .TelefoneResponsavel = txtTelefoneResponsavel.Text
            .DataHoraCadastro = DateTime.Now




            .Salvar()
        End With
        objDocumentos = Nothing
    End Sub

    Private Sub LimparCampos()

        txtNomeMae.Text = ""
        txtCpfMae.Text = ""
        txtNomePai.Text = ""
        txtCpfPai.Text = ""
        txtRgAluno.Text = ""
        txtEmissaoRgAluno.Text = ""
        txtSexoAluno.Text = ""
        txtTelefoneResponsavel.Text = ""
        txtNascimentoAluno.Text = ""


        txtNomeMae.Focus()
    End Sub

    Private Sub Voltar()
        Response.Redirect(Request.Url.ToString)

        LimparCampos()
    End Sub

#Region "Eventos de Listagem"


#End Region
    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()
        LimparCampos()
    End Sub
End Class

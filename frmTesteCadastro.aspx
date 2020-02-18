<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmTesteCadastro.aspx.vb" Inherits="frmTesteCadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="content-header">

    </section>
    <section class="content">
           <h4 class="page-header">Atualizar Cadastro</h4>
           <div class="box-body">
               <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="NomeMae">Nome Mae:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtNomeMae" name="NomeMae" placeholder="Ex.: Socorro" maxlength="50"/>
                            <label for="NomePai">Nome Pai:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtNomePai" name="NomePai" placeholder="Ex.: João" maxlength="50"/>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="CpfMae">CPF Mãe:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtCpfMae" name="CpfMae" placeholder="Ex.: 010.011.111-00" maxlength="250"/>
                            <label for="CpfPai">CPF Pai:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtCpfPai" name="CpfPai" placeholder="Ex.: 010.011.111-00" maxlength="250"/>
                        </div>
                    </div>
                   
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="RgAluno">RG do Aluno:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtRgAluno" name="RgAluno" placeholder="Ex.: 010010101010-0" maxlength="250"/>
                            <label for="EmissaoRgAluno">Data de Emissão do RG:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtEmissaoRgAluno" name="EmissaoRgAluno" placeholder="Ex.: 01/11/2000" maxlength="250"/>
                        </div>
                    </div>
                    
                    <div class="col-md-4">
                        <div class="form-group">
                            <label for="NascimentoAluno">Data de Nascimento:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtNascimentoAluno" name="NascimentoAluno" maxlength="50" placeholder="Ex.: 01/11/1990"/>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="SexoAluno">Sexo do Aluno:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtSexoAluno" name="SexoAluno" placeholder="Ex.: Masculino" maxlength="100"/>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="TelefoneResponsavel">Telefone Responsável:</label>
                            <asp:TextBox runat="server" required="required" type="tel" class="form-control" id="txtTelefoneResponsavel" name="TelefoneResponsavel" placeholder="Ex.: (11) 2020-3030" maxlength="15"/>
                        </div>
                    </div>
                </div>
                 <asp:Label ID="DataHoraCadastro" Font-Names ="DataHoraCadastro" runat="server" type ="date" Text=""></asp:Label>
               <asp:Label ID="IdAluno" Font-Names ="IdAluno" runat="server" Visible="false" type ="text" Text="" ></asp:Label>
        
        <div class="box-footer">
            <div class="col-md-6">
                <asp:Button class="btn btn-primary" runat="server" ID="btnSalvar" Text="Salvar" />
            </div>
           
        </div>
           </div>
    </section>
</asp:Content>

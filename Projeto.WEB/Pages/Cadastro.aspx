<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto.WEB.Pages.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPrincipal" runat="server">

    <h4>Criar conta de usuário</h4>
    <a href="/Default.aspx">Página inicial</a>
    <hr />

    <div class="row">
        <div class="col-md-4">

            <label>Nome do usuário:</label>
            <asp:TextBox ID="txtNome" runat="server"
                CssClass="form-control" placeholder="Digite aqui" />
            <asp:RequiredFieldValidator
                ID="requiredNome"
                runat="server"
                ControlToValidate="txtNome"
                ErrorMessage="Por favor, informe o nome do usuário."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioCadastro"
            />
            <br />

            <label>Login de acesso:</label>
            <asp:TextBox ID="txtLogin" runat="server"
                CssClass="form-control" placeholder="Digite aqui" />
            <asp:RequiredFieldValidator
                ID="requiredLogin"
                runat="server"
                ControlToValidate="txtLogin"
                ErrorMessage="Por favor, informe o login do usuário."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioCadastro"
            />
            <br />

            <label>Senha de acesso:</label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"
                CssClass="form-control" placeholder="Digite aqui" />
            <asp:RequiredFieldValidator
                ID="requiredSenha"
                runat="server"
                ControlToValidate="txtSenha"
                ErrorMessage="Por favor, informe o senha do usuário."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioCadastro"
            />
            <br />

            <label>Confirme a senha:</label>
            <asp:TextBox ID="txtSenhaConfirm" runat="server" TextMode="Password"
                CssClass="form-control" placeholder="Digite aqui" />
            <asp:RequiredFieldValidator
                ID="requiredSenhaConfirm"
                runat="server"
                ControlToValidate="txtSenhaConfirm"
                ErrorMessage="Por favor, confirme o senha do usuário."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioCadastro"
            />
            <asp:CompareValidator
                ID="comnpareSenha"
                runat="server"
                ControlToValidate="txtSenhaConfirm"
                ControlToCompare="txtSenha"
                ErrorMessage="Senhas não conferem."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioCadastro"
            />
            <br />

            <label>Envie a foto:</label>
            <asp:FileUpload ID="txtFoto" runat="server"
                CssClass="form-control" />
            <asp:RequiredFieldValidator
                ID="requiredFoto"
                runat="server"
                ControlToValidate="txtFoto"
                ErrorMessage="Por favor, envie a foto do usuário."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioCadastro"
            />
            <br />

            <asp:Button ID="btnCadastro" runat="server"
                Text="Cadastrar Usuário" CssClass="btn btn-success"
                OnClick="btnCadastro_Click"
                ValidationGroup="formularioCadastro"/>
            <br />
            <br />

            <asp:Label ID="lblMensagem" runat="server" />

        </div>
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto.WEB.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPrincipal" runat="server">

    <h4>Autenticar</h4>
    <a href="/Default.aspx">Página inicial</a>
    <hr />

    <div class="row">
        <div class="col-md-4">

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
                ValidationGroup="formularioLogin"/>
            <br />

            <label>Senha de acesso:</label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"
                CssClass="form-control" placeholder="Digite aqui" />
            
            <asp:RequiredFieldValidator
                ID="requiredSenha"
                runat="server"
                ControlToValidate="txtSenha"
                ErrorMessage="Por favor, informe o senha de acesso."
                ForeColor="Red"
                Display="Dynamic"
                ValidationGroup="formularioLogin"/>
            <br />

            <asp:Button ID="btnAcesso" runat="server"
                Text="Acessar Sistema" CssClass="btn btn-primary" OnClick="btnAcesso_Click" />
            <br />
            <br />

            <asp:Label ID="lblMensagem" runat="server"/>
        </div>
    </div>

</asp:Content>

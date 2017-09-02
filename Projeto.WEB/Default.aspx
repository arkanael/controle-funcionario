<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.WEB.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPrincipal" runat="server">

    <h4>Seja bem vindo ao projeto</h4>
    <hr />

    Selecione a ação desejada:

    <ul>
        <li> <a href="/Pages/Login.aspx">Autenticar</a> </li>
        <li> <a href="/Pages/Cadastro.aspx">Criar conta de acesso</a> </li>
    </ul>

</asp:Content>

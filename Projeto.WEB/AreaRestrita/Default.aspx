<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.WEB.AreaRestrita.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body>
    <h2>Área Restrita do Sistema</h2>
    <hr />

    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-3 text-center">

                <asp:Image ID="imgUsuario" runat="server"
                    Width="120" CssClass="img-circle" />
                <br />

                <asp:Label ID="lblNome" runat="server" Font-Size="Large" />
                <br />

                <asp:Label ID="lblLogin" runat="server" />
                <br />
                <br />

                <asp:Button ID="btnLogout" runat="server" Text="Sair do Sistema"
                    CssClass="btn btn-danger btn-sm" OnClick="btnLogout_Click"/>
            </div>
        </div>
    </form>
</body>
</html>

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;
using System.Web.Security;

namespace Projeto.WEB.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciar a camada de negócio
                UsuarioBusiness business = new UsuarioBusiness();
                Usuario u = business.Autenticar(txtLogin.Text, txtSenha.Text);

                //armazenar os dados do usuário em sessão
                Session["usuario"] = u;

                //criando o ticket de acesso
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(u.Login, false, 5);

                //gravando o ticket no navegador 
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));

                //redirecionar para página de acesso restrito
                Response.Redirect("/AreaRestrita/Default.aspx");


                //redirecionar para a paágina de acesso restrito
                Response.Redirect("/AreaRestrita/Default.aspx");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
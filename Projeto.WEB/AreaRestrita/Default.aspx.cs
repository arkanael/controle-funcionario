using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;

namespace Projeto.WEB.AreaRestrita
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //evento executado quando a página é carregada
            if (!IsPostBack)
            {
                //Verificar se o usuario está gravado na sessão
                if (Session["usuario"] != null)
                {
                    //resgatar o usuario da sessão
                    Usuario u = Session["usuario"] as Usuario;

                    //exibir os dados do usuario
                    imgUsuario.ImageUrl = "/imagens" + u.Foto;
                    lblNome.Text = u.Nome;
                    lblLogin.Text = u.Login;

                }
                
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //remover a sessão
            Session.Remove("usuario");
            Session.Abandon();

            //redirecionar de volta para a página de login
            Response.Redirect("/Pages/Login.aspx");
        }
    }
}
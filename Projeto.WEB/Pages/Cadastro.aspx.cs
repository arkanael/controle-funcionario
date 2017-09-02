using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Projeto.Entidades;
using Projeto.BLL;

namespace Projeto.WEB.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        //evento executado quando a página é carregada..
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //evento executado quando o botão é clicado..
        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarUpload())
                {
                    //resgatar os dados do usuário
                    Usuario u = new Usuario();

                    u.Nome = txtNome.Text;
                    u.Login = txtLogin.Text;
                    u.Senha = txtSenha.Text;
                    u.Foto = Guid.NewGuid().ToString() + Path.GetExtension(txtFoto.FileName);

                    //gravando o usuario
                    UsuarioBusiness business = new UsuarioBusiness();
                    business.CriarConta(u);

                    //upload da foto
                    string path = HttpContext.Current.Server.MapPath("/imagens/");
                    txtFoto.SaveAs(path + u.Foto);

                    lblMensagem.Text = $"Usuário {u.Login} cadastrado com sucesso";
                    lblMensagem.ForeColor = System.Drawing.Color.Black;

                    //upload da foto
                    txtNome.Text = string.Empty;
                    txtLogin.Text = string.Empty;

                }
                else
                {
                    throw new Exception("Envie apenas imagens jpg gif ou png de até 1MB");
                }
            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro
                lblMensagem.Text = ex.Message;
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
        }

        //método para validar o campo de upload
        private bool ValidarUpload()
        {
            //obter a extensão do arquivo enviado para o upload
            string extensao = Path.GetExtension(txtFoto.FileName);

            //obter o tamanho do arquivo
            int tamanho = txtFoto.PostedFile.ContentLength;

            //validação
            //somente arquivo de extensao jpg ou png de até 1mb de tamanho
            return (extensao.Equals(".jpg") || extensao.Equals(".png") || extensao.Equals(".gif")) && tamanho <= Math.Pow(1024,2);

        }
    }
}
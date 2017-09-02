using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades; //classes de entidade..
using Projeto.DAL; //acesso a dados..
using Projeto.BLL.Security; //criptografia..

namespace Projeto.BLL
{
    public class UsuarioBusiness
    {
        //método para criar a conta do usuario..
        public void CriarConta(Usuario u)
        {
            //acessar a camada de repositorio (DAL)
            UsuarioRepository rep = new UsuarioRepository();

            //verificar se o login não esta ja cadastrado..
            if( ! rep.HasLogin(u.Login) )
            {
                Criptografia c = new Criptografia();
                u.Senha = c.EncriptarSenha(u.Senha);

                //gravar no banco de dados..
                rep.Insert(u);
            }
            else
            {
                throw new Exception("Este login já encontra-se cadastrado. Tente outro.");
            }
        }

        //método para buscar 1 usuario..
        public Usuario Autenticar(string login, string senha)
        {
            Criptografia c = new Criptografia();

            UsuarioRepository rep = new UsuarioRepository();
            Usuario u = rep.Find(login, c.EncriptarSenha(senha));

            if(u != null) //se foi encontrado..
            {
                return u; //retornando o usuario
            }
            else
            {
                throw new Exception("Acesso Negado.");
            }
        }
    }
}

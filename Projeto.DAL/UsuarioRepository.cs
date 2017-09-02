using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;

namespace Projeto.DAL
{
    public class UsuarioRepository : Conexao
    {
        //método para inserir um usuario no banco de dados..
        public void Insert(Usuario u)
        {
            OpenConnection();

            //escrever o comando SQL (query)
            string query = "insert into Usuario(Nome, Login, Senha, Foto, DataCadastro) "
                         + "values(@Nome, @Login, @Senha, @Foto, GetDate())";

            //executando o comando SQL..
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", u.Nome);
            cmd.Parameters.AddWithValue("@Login", u.Login);
            cmd.Parameters.AddWithValue("@Senha", u.Senha);
            cmd.Parameters.AddWithValue("@Foto", u.Foto);
            cmd.ExecuteNonQuery(); //executando..

            CloseConnection();
        }

        //método para buscar 1 usuario pelo login e senha..
        public Usuario Find(string login, string senha)
        {
            OpenConnection();

            string query = "select * from Usuario where Login = @Login and Senha = @Senha";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);
            dr = cmd.ExecuteReader(); //executa e lê o resultado da consulta..

            Usuario u = null; //vazio..

            //verificar se algum registro foi encontrado..
            if(dr.Read())
            {
                u = new Usuario(); //instanciando..

                u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                u.Nome = Convert.ToString(dr["Nome"]);
                u.Login = Convert.ToString(dr["Login"]);
                u.Foto = Convert.ToString(dr["Foto"]);
                u.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);
            }

            CloseConnection();
            return u; //retornando o usuario..
        }

        //método para verificar se o login de um usuario ja esta cadastrado..
        public bool HasLogin(string login)
        {
            OpenConnection();

            string query = "select count(*) from Usuario where Login = @Login";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            CloseConnection();
            return count > 0;            
        }

    }
}

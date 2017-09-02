using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SqlServer..

namespace Projeto.DAL
{
    public class Conexao
    {
        //atributos..
        protected SqlConnection con; //conexão com o banco de dados..
        protected SqlCommand cmd; //executar comandos SQL..
        protected SqlDataReader dr; //ler resultados de consultas..
        protected SqlTransaction tr; //transações (commit, rollback)

        //método para abrir conexão com o banco de dados..
        protected void OpenConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\COTI\Desktop\Aula07\controle-funcionario\Projeto.WEB\App_Data\Banco.mdf;Integrated Security=True");
            con.Open(); //conexão aberta..
        }

        //método para fechar conexão com o banco de dados..
        protected void CloseConnection()
        {
            con.Close(); //conexão fechada..
        }
    }
}

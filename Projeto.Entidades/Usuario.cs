using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Usuario
    {
        //propriedades encapsuladas..
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public DateTime DataCadastro { get; set; }

        //construtor default..
        public Usuario()
        {
            //vazio..
        }

        //sobrecarga de construtores (overloading)
        public Usuario(int idUsuario, string nome, string login, string senha, string foto, DateTime dataCadastro)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Login = login;
            Senha = senha;
            Foto = foto;
            DataCadastro = dataCadastro;
        }

        //sobrescrita do método ToString()
        public override string ToString()
        {
            return $"Id: {IdUsuario}, Nome: {Nome}, Login: {Login}, Data de Cadastro: {DataCadastro}";
        }
    }
}

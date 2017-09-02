using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; //criptografia em .NET

namespace Projeto.BLL.Security
{
    public class Criptografia
    {
        //método para encriptar a senha do usuário..
        public string EncriptarSenha(string senha)
        {
            //algoritmo de encriptação: MD5
            MD5 md5 = new MD5CryptoServiceProvider();

            //converter a senha em bytes (binario)..
            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);

            //criptografar a senha..
            byte[] hash = md5.ComputeHash(senhaBytes);

            string resultado = string.Empty; //vazio..

            foreach(byte b in hash) //varrendo cada byte do hash..
            {
                resultado += b.ToString("X"); //X -> Hexadecimal
            }

            return resultado; //retornando..
        }
    }
}

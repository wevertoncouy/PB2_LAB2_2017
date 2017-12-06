using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApProva2Lab2WevertonCouy.Models
{
    public class Endereco
    {
        public int EnderecoId{ get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public  string CEP { get; set; }
        public string Numero { get; set; }


        public Aluno Aluno { get; set; }
    }
}
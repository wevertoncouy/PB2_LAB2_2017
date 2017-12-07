using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApProva2Lab2WevertonCouy.Models
{
    public class Endereco
    {
        [ForeignKey("Aluno")]
        public int EnderecoId{ get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public  string CEP { get; set; }
        public string Numero { get; set; }


        public Aluno Aluno { get; set; }
    }
}
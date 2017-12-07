using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApProva2Lab2WevertonCouy.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }


        public virtual List<Protocolo> Protocolos{ get; set; }

    public Endereco Endereco { get; set; }



    }

}
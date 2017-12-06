using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApProva2Lab2WevertonCouy.Models
{
    public class Protocolo
    {
        public int ProtocoloId { get; set; }
        public int Numero { get; set; }
        public  DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int AlunoId { get; set; }

        public Aluno Aluno  { get; set; }
        public List<Historico> Historicos { get; set; } 

    }
}
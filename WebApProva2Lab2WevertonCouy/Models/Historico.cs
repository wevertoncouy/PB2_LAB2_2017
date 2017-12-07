using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApProva2Lab2WevertonCouy.Models
{
    public class Historico
    {
        public int HistoricoId { get; set; }
        public string Detalhes { get; set; }
        public DateTime DataHora { get; set; }

        public virtual List<Protocolo> Protocolos { get; set; }
    }
}
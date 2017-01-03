using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaisGamers.Model.Locacao
{
    [Table("Locacao")]
    public class mLocacao
    {
        [Key]
        public int IDLocacao { get; set; }

        public mClienteLocacao IDClienteLocacao { get; set; }

        public DateTime DataLocacao { get; set; }

        public DateTime DataLocacaoEntrega { get; set; }

        public double ValorPagoInicial { get; set; }

        public double ValorPagoFinal { get; set; }

        public mStatusLocacao StatusLocacao { get; set; }
    }
}

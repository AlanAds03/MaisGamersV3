using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Orcamento
{
    [Table("Orcamento")]
    public class mOrcamento
    {
        [Key]
        public int IDOrcamento { get; set; }

        public mTipoOrcamento IDTipoOrcamento { get; set; }

        public mClienteLocacao IDClienteLocacao { get; set; }

        public string NumeroSerie { get; set; }
        public string Observacao { get; set; }

        public decimal ValorOrcamento { get; set; }

        public decimal ValorPago     { get; set; }

        public mTipoOrcamentoStatus IDTipoOrcamentoStatus { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime DataRetirada { get; set; }

        public int Garantia { get; set; }

        public byte[] Foto { get; set; }


    }
}

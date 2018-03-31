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

        public mStatusOrcamento StatusOrcamento { get; set; }

        [NotMapped]
        public int IdStatusOrcamento { get; set; }

        public string NomeCliente { get; set; }

        public string Produto { get; set; }

        public string NumeroSerie { get; set; }
        public string Defeito { get; set; }

        public DateTime Data_Entrada { get; set; }
        public DateTime? Data_Retorno { get; set; }
        public DateTime? Data_Entrega { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Observacao { get; set; }
        public decimal ValorOrcamento { get; set; }
        public int Garantia { get; set; }



    }
}

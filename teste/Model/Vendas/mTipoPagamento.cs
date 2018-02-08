using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Vendas
{
    [Table("TipoPagamento")]
    public class mTipoPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTipoPagamento { get; set; }
        public string TipoPagamento { get; set; }
        public decimal Taxa { get; set; }
       

    }
}

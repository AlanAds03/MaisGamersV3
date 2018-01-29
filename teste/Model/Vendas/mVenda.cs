using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Vendas
{
    [Table("Vendas")]
    public class mVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDVenda { get; set; }
        public DateTime dVenda { get; set; }
        public string rCliente { get; set; }
        public double vValorTotal { get; set; }
        public double vValorPago { get; set; }

        public virtual ICollection<mVendaProduto> VendaProduto { get; set; }



        //public virtual ICollection<mProduto> Produto { get; set; }
        //public virtual ICollection<mJogo> Jogo { get; set; }

    }
}

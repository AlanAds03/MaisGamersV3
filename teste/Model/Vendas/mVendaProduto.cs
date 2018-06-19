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
    [Table("VendaProduto")]
    public class mVendaProduto
    {
        [Key]
        public int IDVendaProduto { get; set; }
        public mVenda Venda { get; set; }
        //public mProduto Produto { get; set; }
        
        public int IDOrigem { get; set; }

        public string Descricao { get; set; }
        

    }
}

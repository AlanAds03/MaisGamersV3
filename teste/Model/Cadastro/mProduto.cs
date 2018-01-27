using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Cadastro
{
    [Table("Produto")]
    public class mProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProduto { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double Unitario { get; set; }
        public double Custo { get; set; }
        public string Fornecedor { get; set; }

        [NotMapped]
        public string ColunasGrid { get; set; }



    }
}

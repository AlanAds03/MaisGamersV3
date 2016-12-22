using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaisGamers.Model.Locacao;

namespace MaisGamers.Model.Cadastro
{
    [Table("Caixa")]
    public class mCaixa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCaixa { get; set; }

        public int TipoEntradas { get; set; }

        public int Valor { get; set; }

        public mClienteLocacao ClienteLocacao { get; set; }


    }
}

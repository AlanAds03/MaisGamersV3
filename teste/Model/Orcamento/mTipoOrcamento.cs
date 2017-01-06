using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MaisGamers.Model.Orcamento
{
    [Table("TipoOrcamento")]
    public class mTipoOrcamento
    {
        [Key]
        public int IDTipoOrcamento { get; set; }

        public string TipoOrcamento { get; set; }

    }
}

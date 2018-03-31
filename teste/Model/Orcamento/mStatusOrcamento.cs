using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Orcamento
{
    [Table("StatusOrcamento")]
    public class mStatusOrcamento
    {
        [Key]
        public int IDStatusOrcamento { get; set; }

        public string StatusOrcamento { get; set; }

    }
}

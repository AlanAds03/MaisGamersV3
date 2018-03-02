using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Anotacao
{
    [Table("StatusAnotacao")]
    public class mStatusAnotacao
    {
        [Key]
        public int ID_StatusAnotacao { get; set; }
        public string StatusAnotacao { get; set; }
    }
}

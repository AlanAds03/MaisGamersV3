using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Anotacao
{
    [Table("Anotacao")]
    public class mAnotacao
    {
        [Key]
        public int IDAnotacao { get; set; }
        public DateTime DataAnotacao { get; set; }
        public string Descricao { get; set; }
        public mStatusAnotacao StatusAnotacao { get; set; }

        [NotMapped]
        public int idStatusAnotacao { get; set; }
    }
}

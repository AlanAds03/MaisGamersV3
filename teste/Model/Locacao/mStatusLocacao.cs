using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Locacao
{
    [Table("StatusLocacao")]
    public class mStatusLocacao
    {
        [Key]
        public int IDStatus { get; set; }

        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model
{
    [Table("Estado")]
    public class mEstado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cEstado { get; set; }

        public string rEstado { get; set; }

    }
}

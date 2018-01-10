using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Locacao
{
    public class mStatusCliente
    {
        [Key]
        public int ID_StatusCliente { get; set; }
        public string DescricaoStatusCliente { get; set; }
    }
}

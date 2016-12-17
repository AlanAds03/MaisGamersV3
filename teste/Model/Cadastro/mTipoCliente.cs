using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaisGamers.DAL.Cadastro
{
    
    [Table("TipoCliente")]
    public class mTipoCliente
    {
        [Key]
        public int IDTipoCliente { get; set; }
        public string TipoCliente { get; set; }
    }
}

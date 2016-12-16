using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MaisGamers.Model.Cadastro
{
    [Table("Console")]
    public class mConsole
    {
        [Key]
        public int IDConsole { get; set; }

        public string NomeConsole { get; set; }
    }
}

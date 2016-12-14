using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Cadastro
{
    [Table("Jogo")]
    public class mJogo
    {
        [Key]
        public int idJogo { get; set; }
        public string Jogo { get; set; }
        public mConsole Console { get; set; }
    }
}

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
        public int IDJogo { get; set; }
        public int NomeJogo { get; set; }
        public mConsole IDConsole { get; set; }
        public mTipoJogo IDTipoJogo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Quantidade { get; set; }
        public double PrecoPago { get; set; }
        public double PrecoVenda { get; set; }


    }
}

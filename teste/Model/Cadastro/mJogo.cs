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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDJogo { get; set; }
        public string NomeJogo { get; set; }
        public mConsole IDConsole { get; set; }
        [NotMapped]
        public int cIdConsole { get; set; }

        [NotMapped]
        public string NomeConsolexx { get; set; }

        public mTipoJogo IDTipoJogo { get; set; }
        [NotMapped]
        public int cIDTipoJogo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Quantidade { get; set; }
        public double PrecoPago { get; set; }
        public double PrecoVenda { get; set; }


    }
}

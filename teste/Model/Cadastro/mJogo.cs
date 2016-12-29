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

        [Display(Description = "Jogo", ShortName ="200")]
        public string NomeJogo { get; set; }
        public mConsole IDConsole { get; set; }
        [NotMapped]
        public int cIdConsole { get; set; }

        [NotMapped]
        [Display(Description ="Console",ShortName = "100")]
        public string NomeConsolexx { get; set; }

        [NotMapped]
        [Display(Description = "Tipo de Jogo", ShortName = "100")]
        public string rTipoJogo { get; set; }

        public mTipoJogo IDTipoJogo { get; set; }
        [NotMapped]
        public int cIDTipoJogo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Quantidade { get; set; }
        public double PrecoPago { get; set; }
        [Display(Description = "Preço", ShortName = "80",Prompt = "decimal")]
        public double PrecoVenda { get; set; }

        [NotMapped]
        public string ColunasGrid { get; set; }


    }
}

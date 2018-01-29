using MaisGamers.Model.Vendas;
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

        [Display(Description = "Jogo", ShortName = "200")]
        public string NomeJogo { get; set; }
        public mConsole IDConsole { get; set; }
        [NotMapped]
        public int cIdConsole { get; set; }

        [NotMapped]
        [Display(Description = "Console", ShortName = "100")]
        public string NomeConsolexx { get; set; }

        [NotMapped]
        [Display(Description = "Tipo de Jogo", ShortName = "100")]
        public string rTipoJogo { get; set; }

        public mTipoJogo IDTipoJogo { get; set; }
        [NotMapped]
        public int cIDTipoJogo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public string SenhaPSN { get; set; }
        public int Quantidade { get; set; }
        public double PrecoPago { get; set; }
        [Display(Description = "Preço", ShortName = "80", Prompt = "decimal")]
        public double PrecoVenda { get; set; }


        [Display(Description = "Data Nascimento Conta", ShortName = "80", Prompt = "Nome")]
        public DateTime? DataNascimentoConta { get; set; }
        public string ContaPai { get; set; }
        public string PrimariaVendidoPara { get; set; }
        public string SecundariaVendidoPara { get; set; }
        public DateTime? DataVendaPrimaria { get; set; }

        public DateTime? DataVendaSecundaria { get; set; }

        public double? ValorVendaPrimaria { get; set; }

        public double? ValorVendaSecundaria { get; set; }

        public bool Lacrado { get; set; }

       
        public virtual ICollection<mVenda> Venda { get; set; }



        [NotMapped]
        public string ColunasGrid { get; set; }


        public double PrecoPrimaria { get; set; }

        public double PrecoSecundaria { get; set; }



    }
}

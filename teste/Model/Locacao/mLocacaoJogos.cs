using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Locacao
{
    [Table("LocacaoJogo")]
    public class mLocacaoJogos
    {

        [Key]
        public int IDLocacaoJogo { get; set; }

        public mLocacao IDLocacao { get; set; }

        public mJogo IDJogo { get; set; }

    }
}

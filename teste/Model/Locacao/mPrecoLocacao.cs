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
    [Table("PrecoLocacao")]
    public class mPrecoLocacao
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPrecoLocacao { get; set; }


        public mConsole IDConsole { get; set; }

        public decimal PrecoDia1 { get; set; }
        public decimal PrecoDia2 { get; set; }
        public decimal PrecoDia3 { get; set; }

        public mTipoJogo IDTipoJogo { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Cadastro
{
    [Table("Anotacao")]
    public class mAnotacao
    {
        [Key]
        public int IDAnotacao { get; set; }

        public string  Nome { get; set; }

        public string Observacao { get; set; }

        public string DataObservacao { get; set; }

        public int StatusAnotacao { get; set; }




    }
}

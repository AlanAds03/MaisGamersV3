using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Orcamento
{
    [Table("FotosOrcamento")]
    public class mFotosOrcamento
    {

        [Key]
        public int IDFotosOrcamento { get; set; }
        public Byte[]  Foto { get; set; }
        public DateTime DataCriacao { get; set; }

        public mOrcamento IDOrcamento { get; set; }
        
    }
}

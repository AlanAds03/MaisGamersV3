using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisGamers.Model.Orcamento
{
    [Table("TipoOrcamentoStatus")]
    public class mTipoOrcamentoStatus
    {

        [Key]
        public int IDTipoOrcamentoStatus { get; set; }

        public string TipoOrcamentoStatus { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MaisGamers.Model.Cadastro
{
    [Table("Console")]
    public class mConsole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDConsole { get; set; }

        [MaxLength(100,ErrorMessage = "Máximo de 100 caracteres") , Required(ErrorMessage ="Necessário informar o Console")]
        public string NomeConsole { get; set; }
    }
}

using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Hora
{
    [Table("Hora")]
    public class mHora
    {
        [Key]
        public int idPrecoConsoleHora { get; set; }
        public mConsole Console { get; set; }
        public string Descricao { get; set; }
        public double vPreco { get; set; }

        
        
    }
}

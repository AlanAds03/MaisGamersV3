using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameworks;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MaisGamers.Model.Locacao
{
    [Table("ClienteLocacao")]
    public class mClienteLocacao
    {
        //[Atributos("rNome",200)]
        [Key]
        public int idClienteLocacao { get; set; }
        public string  Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public DateTime DataNascimento{ get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }
        [NotMapped]
        public int cEstado { get; set; }
        public mEstado Estado { get; set; }

        [NotMapped]
        public int cCidade { get; set; }
        public mCidade Cidade { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string NomeFilho{ get; set; }

        public string CPFFilho { get; set; }

        public string RGFilho { get; set; }






        //       @Nome VARCHAR(300) = NULL,
        //@DataNascimento DATETIME = NULL,
        //   @Telefone VARCHAR(12) = NULL,
        //@Rg VARCHAR(20) = NULL,
        //@Cpf VARCHAR(30) = NULL,
        //@Rua VARCHAR(500) = NULL,
        //@Numero INT = NULL,
        //   @Bairro VARCHAR(300) = NULL,
        //@codEstado INT = NULL,
        //   @codCidade INT = NULL,
        //@NomeResposnavel VARCHAR(300) = NULL,
        //@RgResponsavel VARCHAR(30) = NULL,
        //@CpfResponsavel VARCHAR(30) = NULL

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameworks;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MaisGamers.Modulos;
using MaisGamers.DAL.Cadastro;

namespace MaisGamers.Model.Locacao
{
    [Table("ClienteLocacao")]
    public class mClienteLocacao
    {
        //[Atributos("rNome",200)]
        [Key]
        public int idClienteLocacao { get; set; }

        [Display(Description = "Nome", ShortName = "350")]
        public string  Nome { get; set; }

        public string NomeMae { get; set; }

        public string NomePai { get; set; }

        [Display(Description = "CPF", ShortName = "150")]
        public string CPF { get; set; }

        [Display(Description = "RG", ShortName = "150")]
        public string RG { get; set; }

        public DateTime? DataExpedicao { get; set; }

        [CustomAttibuteDate(ShortDate = true)]
        public DateTime DataNascimento{ get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }
        [NotMapped]
        public int cEstado { get; set; }
        public mEstado Estado { get; set; }

        [NotMapped]
        public int cCidade { get; set; }
        public mCidade Cidade { get; set; }

        [NotMapped]
        public int IDTipoCliente { get; set; }

        [NotMapped]
        [Display(Description = "Tipo de Cliente", ShortName = "150")]
        public string strTipoCliente { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string NomeFilho{ get; set; }

        public string CPFFilho { get; set; }

        public string RGFilho { get; set; }

        public string JsonGRID { get; set; }


        public string Telefone { get; set; }
        public string Telefone2 { get; set; }

        public int cSexo { get; set; }

        [NotMapped]
        public string ColunasGrid { get; set; }

        public mTipoCliente TipoCliente { get; set; }

        public byte[] FotoLocatario { get; set; }

        public byte[] FotoAutorizado { get; set; }


        public byte[] DocumentoAssinado { get; set; }
    
        public byte [] AnexoRG { get; set; }

        public byte[] AnexoComprovanteEndereco { get; set; }

        public DateTime DataCadastrado { get; set; }


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

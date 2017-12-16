using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Documento
{
    public class mDocumento
    {
        public int idDOcumento { get; set; }
        public string extensaoArquivo { get; set; }
        public byte[] documentos { get; set; }
    }
}

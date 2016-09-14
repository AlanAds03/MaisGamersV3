using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model
{
    public class Contexto : DbContext
    {
        public DbSet<mClienteLocacao> ClienteLocacao { get; set; }


    }
}

using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model
{
    public class Contexto : DbContext
    {
        public DbSet<mClienteLocacao> ClienteLocacao { get; set; }

        public DbSet<mEstado> Estado { get; set; }

        public DbSet<mCidade> Cidade { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}

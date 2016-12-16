namespace teste.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MaisGamers.Model.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MaisGamers.Model.Contexto";
        }

        protected override void Seed(MaisGamers.Model.Contexto context)
        {

            context.TipoCliente.AddOrUpdate(
                p=> p.IDTipoCliente, 
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 1 ,  TipoCliente = "Locacao"},
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 2, TipoCliente = "Orcamento" },
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 3, TipoCliente = "Vendedor" },
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 4, TipoCliente = "Comprador" }

                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

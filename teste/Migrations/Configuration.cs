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

            context.Console.AddOrUpdate(
                p=> p.idConsole, 
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 1 , NomeConsole = "PS4"},
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 4, NomeConsole = "PS3" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 3, NomeConsole = "PS2" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 2 , NomeConsole = "Xone"},
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 3 , NomeConsole  = "Xbox 360"}
                

                );

            context.TipoJogo.AddOrUpdate(
                p => p.IDTipoJogo , 
                new MaisGamers.Model.Cadastro.mTipoJogo { IDTipoJogo = 1 ,NomeTipoJogo= "F�sica"},
                new MaisGamers.Model.Cadastro.mTipoJogo { IDTipoJogo = 2 , NomeTipoJogo = "Digital" }
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

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
                p => p.IDTipoCliente,
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 1, TipoCliente = "Locacao" },
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 2, TipoCliente = "Orcamento" },
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 3, TipoCliente = "Vendedor" },
                new MaisGamers.DAL.Cadastro.mTipoCliente { IDTipoCliente = 4, TipoCliente = "Comprador" }

                );

            context.Console.AddOrUpdate(
                p => p.idConsole,
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 1, NomeConsole = "PS4" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 4, NomeConsole = "PS3" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 5, NomeConsole = "PS2" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 2, NomeConsole = "Xone" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 3, NomeConsole = "Xbox 360" },
                new MaisGamers.Model.Cadastro.mConsole { idConsole = 6, NomeConsole = "PS VR" }

                );

            context.TipoJogo.AddOrUpdate(
                p => p.IDTipoJogo,
                new MaisGamers.Model.Cadastro.mTipoJogo { IDTipoJogo = 1, NomeTipoJogo = "Física" },
                new MaisGamers.Model.Cadastro.mTipoJogo { IDTipoJogo = 2, NomeTipoJogo = "Digital" }
                );

            

            context.StatusOrcamento.AddOrUpdate(

                p => p.IDStatusOrcamento,
                new MaisGamers.Model.Orcamento.mStatusOrcamento { IDStatusOrcamento = 1 ,StatusOrcamento = "Em aberto"},
                new MaisGamers.Model.Orcamento.mStatusOrcamento { IDStatusOrcamento = 2, StatusOrcamento = "Em análise" },
                new MaisGamers.Model.Orcamento.mStatusOrcamento { IDStatusOrcamento = 3, StatusOrcamento = "Aguardando aprovação do cliente" },
                new MaisGamers.Model.Orcamento.mStatusOrcamento { IDStatusOrcamento = 5, StatusOrcamento = "Devolvido" },
                new MaisGamers.Model.Orcamento.mStatusOrcamento { IDStatusOrcamento = 6, StatusOrcamento = "Concluído" }

                );

            context.StatusLocacao.AddOrUpdate(
                p => p.IDStatus,
                new MaisGamers.Model.Locacao.mStatusLocacao { IDStatus = 1, Status = "Em Aberto" },
                new MaisGamers.Model.Locacao.mStatusLocacao { IDStatus = 2, Status = "Alugado" },
                new MaisGamers.Model.Locacao.mStatusLocacao { IDStatus = 3, Status = "Concluído" },
                new MaisGamers.Model.Locacao.mStatusLocacao { IDStatus = 4, Status = "Processo Judicial" }
                );

            //context.Database.Connection.Open();
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT PrecoLocacao ON");

            context.PrecoLocacao.AddOrUpdate(
                p => p.IDPrecoLocacao,
                new MaisGamers.Model.Locacao.mPrecoLocacao { IDPrecoLocacao = 1,  PrecoDia1 =8,PrecoDia2 = 13, PrecoDia3 = 18, IDConsole = context.Console.Find(1),IDTipoJogo= context.TipoJogo.Find(1)},
                new MaisGamers.Model.Locacao.mPrecoLocacao { IDPrecoLocacao = 2, PrecoDia1 = 8, PrecoDia2 = 13, PrecoDia3 = 18, IDConsole = context.Console.Find(2), IDTipoJogo = context.TipoJogo.Find(1) },
                new MaisGamers.Model.Locacao.mPrecoLocacao { IDPrecoLocacao = 3, PrecoDia1 = 5, PrecoDia2 = 8, PrecoDia3 = 11, IDConsole = context.Console.Find(3), IDTipoJogo = context.TipoJogo.Find(1) },
                new MaisGamers.Model.Locacao.mPrecoLocacao { IDPrecoLocacao = 4, PrecoDia1 = 5, PrecoDia2 = 8, PrecoDia3 = 11, IDConsole = context.Console.Find(4), IDTipoJogo = context.TipoJogo.Find(1) },
                new MaisGamers.Model.Locacao.mPrecoLocacao { IDPrecoLocacao = 5, PrecoDia1 = Convert.ToDecimal(2.5), PrecoDia2 = Convert.ToDecimal(2.5), PrecoDia3 = Convert.ToDecimal(2.5), IDConsole = context.Console.Find(1), IDTipoJogo = context.TipoJogo.Find(2) },
                new MaisGamers.Model.Locacao.mPrecoLocacao { IDPrecoLocacao = 6, PrecoDia1 = Convert.ToDecimal(2.5), PrecoDia2 = Convert.ToDecimal(2.5), PrecoDia3 = Convert.ToDecimal(2.5), IDConsole = context.Console.Find(2), IDTipoJogo = context.TipoJogo.Find(2) }



                //5.00    10.00   15.00   1   2
                //5.00    10.00   15.00   2   2

                );


            context.StatusCliente.AddOrUpdate(
               p => p.ID_StatusCliente,
               new MaisGamers.Model.Locacao.mStatusCliente {  ID_StatusCliente = 1 , DescricaoStatusCliente = "Ativo"},
               new MaisGamers.Model.Locacao.mStatusCliente { ID_StatusCliente = 2, DescricaoStatusCliente = "Inativo" }
               


               );

            context.TipoPagamento.AddOrUpdate(
              p => p.IDTipoPagamento,
              new MaisGamers.Model.Vendas.mTipoPagamento { IDTipoPagamento = 1, TipoPagamento="Dinheiro", Taxa = 0 },
              new MaisGamers.Model.Vendas.mTipoPagamento { IDTipoPagamento = 2, TipoPagamento = "Debito", Taxa = 2.49M },
              new MaisGamers.Model.Vendas.mTipoPagamento { IDTipoPagamento = 3, TipoPagamento = "Cartao", Taxa = 4.19M },
              new MaisGamers.Model.Vendas.mTipoPagamento { IDTipoPagamento = 4, TipoPagamento = "Parcelado", Taxa = 2.49M }

              );

            context.Hora.AddOrUpdate(
             p => p.idPrecoConsoleHora,
             new MaisGamers.Model.Hora.mHora { idPrecoConsoleHora = 1, Console = context.Console.Find(1), Descricao = "30 Minutos", vPreco = 3.00},
             new MaisGamers.Model.Hora.mHora { idPrecoConsoleHora = 2, Console = context.Console.Find(1), Descricao = "1 Hora", vPreco = 5.00 },
             new MaisGamers.Model.Hora.mHora { idPrecoConsoleHora = 3, Console = context.Console.Find(1), Descricao = "1 Hora e Meia", vPreco = 7.00 },
             new MaisGamers.Model.Hora.mHora { idPrecoConsoleHora = 4, Console = context.Console.Find(1), Descricao = "2 Horas", vPreco = 9.00 },
             new MaisGamers.Model.Hora.mHora { idPrecoConsoleHora = 5, Console = context.Console.Find(1), Descricao = "2 Horas e Meia", vPreco = 12.00 },
             new MaisGamers.Model.Hora.mHora { idPrecoConsoleHora = 6, Console = context.Console.Find(1), Descricao = "3 Horas", vPreco = 14.00 }

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

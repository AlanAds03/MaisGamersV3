namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TodasTabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anotacao",
                c => new
                    {
                        IDAnotacao = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Observacao = c.String(),
                        DataObservacao = c.String(),
                        StatusAnotacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDAnotacao);
            
            CreateTable(
                "dbo.Caixa",
                c => new
                    {
                        IdCaixa = c.Int(nullable: false, identity: true),
                        TipoEntradas = c.Int(nullable: false),
                        Valor = c.Int(nullable: false),
                        ClienteLocacao_idClienteLocacao = c.Int(),
                    })
                .PrimaryKey(t => t.IdCaixa)
                .ForeignKey("dbo.ClienteLocacao", t => t.ClienteLocacao_idClienteLocacao)
                .Index(t => t.ClienteLocacao_idClienteLocacao);
            
            CreateTable(
                "dbo.ClienteLocacao",
                c => new
                    {
                        idClienteLocacao = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NomeMae = c.String(),
                        NomePai = c.String(),
                        CPF = c.String(),
                        RG = c.String(),
                        DataExpedicao = c.DateTime(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Rua = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        CEP = c.String(),
                        NomeFilho = c.String(),
                        CPFFilho = c.String(),
                        RGFilho = c.String(),
                        JsonGRID = c.String(),
                        Telefone = c.String(),
                        Telefone2 = c.String(),
                        cSexo = c.Int(nullable: false),
                        FotoLocatario = c.Binary(),
                        FotoAutorizado = c.Binary(),
                        DocumentoAssinado = c.Binary(),
                        AnexoRG = c.Binary(),
                        AnexoComprovanteEndereco = c.Binary(),
                        Cidade_cCidade = c.Int(),
                        Estado_cEstado = c.Int(),
                        TipoCliente_IDTipoCliente = c.Int(),
                    })
                .PrimaryKey(t => t.idClienteLocacao)
                .ForeignKey("dbo.Cidade", t => t.Cidade_cCidade)
                .ForeignKey("dbo.Estado", t => t.Estado_cEstado)
                .ForeignKey("dbo.TipoCliente", t => t.TipoCliente_IDTipoCliente)
                .Index(t => t.Cidade_cCidade)
                .Index(t => t.Estado_cEstado)
                .Index(t => t.TipoCliente_IDTipoCliente);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        cCidade = c.Int(nullable: false),
                        rCidade = c.String(),
                        cEstado_cEstado = c.Int(),
                    })
                .PrimaryKey(t => t.cCidade)
                .ForeignKey("dbo.Estado", t => t.cEstado_cEstado)
                .Index(t => t.cEstado_cEstado);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        cEstado = c.Int(nullable: false),
                        rEstado = c.String(),
                        UF = c.String(),
                    })
                .PrimaryKey(t => t.cEstado);
            
            CreateTable(
                "dbo.TipoCliente",
                c => new
                    {
                        IDTipoCliente = c.Int(nullable: false, identity: true),
                        TipoCliente = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoCliente);
            
            CreateTable(
                "dbo.Console",
                c => new
                    {
                        idConsole = c.Int(nullable: false, identity: true),
                        NomeConsole = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.idConsole);
            
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        IDJogo = c.Int(nullable: false, identity: true),
                        NomeJogo = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Quantidade = c.Int(nullable: false),
                        PrecoPago = c.Double(nullable: false),
                        PrecoVenda = c.Double(nullable: false),
                        PrecoPrimaria = c.Double(nullable: false),
                        PrecoSecundaria = c.Double(nullable: false),
                        IDConsole_idConsole = c.Int(),
                        IDTipoJogo_IDTipoJogo = c.Int(),
                    })
                .PrimaryKey(t => t.IDJogo)
                .ForeignKey("dbo.Console", t => t.IDConsole_idConsole)
                .ForeignKey("dbo.TipoJogo", t => t.IDTipoJogo_IDTipoJogo)
                .Index(t => t.IDConsole_idConsole)
                .Index(t => t.IDTipoJogo_IDTipoJogo);
            
            CreateTable(
                "dbo.TipoJogo",
                c => new
                    {
                        IDTipoJogo = c.Int(nullable: false, identity: true),
                        NomeTipoJogo = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoJogo);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        IDLocacao = c.Int(nullable: false, identity: true),
                        DataLocacao = c.DateTime(nullable: false),
                        DataLocacaoEntrega = c.DateTime(nullable: false),
                        ValorPagoInicial = c.Double(nullable: false),
                        ValorPagoFinal = c.Double(nullable: false),
                        IDClienteLocacao_idClienteLocacao = c.Int(),
                        StatusLocacao_IDStatus = c.Int(),
                    })
                .PrimaryKey(t => t.IDLocacao)
                .ForeignKey("dbo.ClienteLocacao", t => t.IDClienteLocacao_idClienteLocacao)
                .ForeignKey("dbo.StatusLocacao", t => t.StatusLocacao_IDStatus)
                .Index(t => t.IDClienteLocacao_idClienteLocacao)
                .Index(t => t.StatusLocacao_IDStatus);
            
            CreateTable(
                "dbo.StatusLocacao",
                c => new
                    {
                        IDStatus = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.IDStatus);
            
            CreateTable(
                "dbo.LocacaoJogo",
                c => new
                    {
                        IDLocacaoJogo = c.Int(nullable: false, identity: true),
                        IDJogo_IDJogo = c.Int(),
                        IDLocacao_IDLocacao = c.Int(),
                    })
                .PrimaryKey(t => t.IDLocacaoJogo)
                .ForeignKey("dbo.Jogo", t => t.IDJogo_IDJogo)
                .ForeignKey("dbo.Locacao", t => t.IDLocacao_IDLocacao)
                .Index(t => t.IDJogo_IDJogo)
                .Index(t => t.IDLocacao_IDLocacao);
            
            CreateTable(
                "dbo.PrecoLocacao",
                c => new
                    {
                        IDPrecoLocacao = c.Int(nullable: false, identity: true),
                        PrecoDia1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoDia2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoDia3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IDConsole_idConsole = c.Int(),
                    })
                .PrimaryKey(t => t.IDPrecoLocacao)
                .ForeignKey("dbo.Console", t => t.IDConsole_idConsole)
                .Index(t => t.IDConsole_idConsole);
            
            CreateTable(
                "dbo.TipoOrcamento",
                c => new
                    {
                        IDTipoOrcamento = c.Int(nullable: false, identity: true),
                        TipoOrcamento = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoOrcamento);
            
            CreateTable(
                "dbo.TipoOrcamentoStatus",
                c => new
                    {
                        IDTipoOrcamentoStatus = c.Int(nullable: false, identity: true),
                        TipoOrcamentoStatus = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoOrcamentoStatus);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecoLocacao", "IDConsole_idConsole", "dbo.Console");
            DropForeignKey("dbo.LocacaoJogo", "IDLocacao_IDLocacao", "dbo.Locacao");
            DropForeignKey("dbo.LocacaoJogo", "IDJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.Locacao", "StatusLocacao_IDStatus", "dbo.StatusLocacao");
            DropForeignKey("dbo.Locacao", "IDClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao");
            DropForeignKey("dbo.Jogo", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo");
            DropForeignKey("dbo.Jogo", "IDConsole_idConsole", "dbo.Console");
            DropForeignKey("dbo.Caixa", "ClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao");
            DropForeignKey("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente", "dbo.TipoCliente");
            DropForeignKey("dbo.ClienteLocacao", "Estado_cEstado", "dbo.Estado");
            DropForeignKey("dbo.ClienteLocacao", "Cidade_cCidade", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "cEstado_cEstado", "dbo.Estado");
            DropIndex("dbo.PrecoLocacao", new[] { "IDConsole_idConsole" });
            DropIndex("dbo.LocacaoJogo", new[] { "IDLocacao_IDLocacao" });
            DropIndex("dbo.LocacaoJogo", new[] { "IDJogo_IDJogo" });
            DropIndex("dbo.Locacao", new[] { "StatusLocacao_IDStatus" });
            DropIndex("dbo.Locacao", new[] { "IDClienteLocacao_idClienteLocacao" });
            DropIndex("dbo.Jogo", new[] { "IDTipoJogo_IDTipoJogo" });
            DropIndex("dbo.Jogo", new[] { "IDConsole_idConsole" });
            DropIndex("dbo.Cidade", new[] { "cEstado_cEstado" });
            DropIndex("dbo.ClienteLocacao", new[] { "TipoCliente_IDTipoCliente" });
            DropIndex("dbo.ClienteLocacao", new[] { "Estado_cEstado" });
            DropIndex("dbo.ClienteLocacao", new[] { "Cidade_cCidade" });
            DropIndex("dbo.Caixa", new[] { "ClienteLocacao_idClienteLocacao" });
            DropTable("dbo.TipoOrcamentoStatus");
            DropTable("dbo.TipoOrcamento");
            DropTable("dbo.PrecoLocacao");
            DropTable("dbo.LocacaoJogo");
            DropTable("dbo.StatusLocacao");
            DropTable("dbo.Locacao");
            DropTable("dbo.TipoJogo");
            DropTable("dbo.Jogo");
            DropTable("dbo.Console");
            DropTable("dbo.TipoCliente");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
            DropTable("dbo.ClienteLocacao");
            DropTable("dbo.Caixa");
            DropTable("dbo.Anotacao");
        }
    }
}

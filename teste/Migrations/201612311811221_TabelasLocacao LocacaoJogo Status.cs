namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasLocacaoLocacaoJogoStatus : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LocacaoJogo", "IDLocacao_IDLocacao", "dbo.Locacao");
            DropForeignKey("dbo.LocacaoJogo", "IDJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.Locacao", "StatusLocacao_IDStatus", "dbo.StatusLocacao");
            DropForeignKey("dbo.Locacao", "IDClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao");
            DropIndex("dbo.LocacaoJogo", new[] { "IDLocacao_IDLocacao" });
            DropIndex("dbo.LocacaoJogo", new[] { "IDJogo_IDJogo" });
            DropIndex("dbo.Locacao", new[] { "StatusLocacao_IDStatus" });
            DropIndex("dbo.Locacao", new[] { "IDClienteLocacao_idClienteLocacao" });
            DropTable("dbo.LocacaoJogo");
            DropTable("dbo.StatusLocacao");
            DropTable("dbo.Locacao");
        }
    }
}

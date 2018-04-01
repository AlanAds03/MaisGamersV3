namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajusteOrcamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orcamento",
                c => new
                    {
                        IDOrcamento = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(),
                        Produto = c.String(),
                        NumeroSerie = c.String(),
                        Defeito = c.String(),
                        Data_Entrada = c.DateTime(nullable: false),
                        Data_Retorno = c.DateTime(),
                        Data_Entrega = c.DateTime(),
                        Telefone1 = c.String(),
                        Telefone2 = c.String(),
                        Observacao = c.String(),
                        ValorOrcamento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Garantia = c.Int(nullable: false),
                        StatusOrcamento_IDStatusOrcamento = c.Int(),
                    })
                .PrimaryKey(t => t.IDOrcamento)
                .ForeignKey("dbo.StatusOrcamento", t => t.StatusOrcamento_IDStatusOrcamento)
                .Index(t => t.StatusOrcamento_IDStatusOrcamento);
            
            CreateTable(
                "dbo.StatusOrcamento",
                c => new
                    {
                        IDStatusOrcamento = c.Int(nullable: false, identity: true),
                        StatusOrcamento = c.String(),
                    })
                .PrimaryKey(t => t.IDStatusOrcamento);
            
            DropTable("dbo.TipoOrcamento");
            DropTable("dbo.TipoOrcamentoStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TipoOrcamentoStatus",
                c => new
                    {
                        IDTipoOrcamentoStatus = c.Int(nullable: false, identity: true),
                        TipoOrcamentoStatus = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoOrcamentoStatus);
            
            CreateTable(
                "dbo.TipoOrcamento",
                c => new
                    {
                        IDTipoOrcamento = c.Int(nullable: false, identity: true),
                        TipoOrcamento = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoOrcamento);
            
            DropForeignKey("dbo.Orcamento", "StatusOrcamento_IDStatusOrcamento", "dbo.StatusOrcamento");
            DropIndex("dbo.Orcamento", new[] { "StatusOrcamento_IDStatusOrcamento" });
            DropTable("dbo.StatusOrcamento");
            DropTable("dbo.Orcamento");
        }
    }
}

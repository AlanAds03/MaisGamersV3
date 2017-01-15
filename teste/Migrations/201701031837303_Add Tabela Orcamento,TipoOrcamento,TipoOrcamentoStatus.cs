namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTabelaOrcamentoTipoOrcamentoTipoOrcamentoStatus : DbMigration
    {
        public override void Up()
        {
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
            DropTable("dbo.TipoOrcamentoStatus");
            DropTable("dbo.TipoOrcamento");
        }
    }
}

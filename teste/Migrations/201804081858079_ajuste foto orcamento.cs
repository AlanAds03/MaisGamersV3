namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustefotoorcamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento", c => c.Int());
            CreateIndex("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento");
            AddForeignKey("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento", "dbo.Orcamento", "IDOrcamento");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento", "dbo.Orcamento");
            DropIndex("dbo.FotosOrcamento", new[] { "IDOrcamento_IDOrcamento" });
            DropColumn("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento");
        }
    }
}

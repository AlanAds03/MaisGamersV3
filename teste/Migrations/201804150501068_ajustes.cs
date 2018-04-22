namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FotosOrcamento",
                c => new
                    {
                        IDFotosOrcamento = c.Int(nullable: false, identity: true),
                        Foto = c.Binary(),
                        DataCriacao = c.DateTime(nullable: false),
                        IDOrcamento_IDOrcamento = c.Int(),
                    })
                .PrimaryKey(t => t.IDFotosOrcamento)
                .ForeignKey("dbo.Orcamento", t => t.IDOrcamento_IDOrcamento)
                .Index(t => t.IDOrcamento_IDOrcamento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento", "dbo.Orcamento");
            DropIndex("dbo.FotosOrcamento", new[] { "IDOrcamento_IDOrcamento" });
            DropTable("dbo.FotosOrcamento");
        }
    }
}

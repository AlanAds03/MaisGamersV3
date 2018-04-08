namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionarFotoOrcamento : DbMigration
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
                    })
                .PrimaryKey(t => t.IDFotosOrcamento);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FotosOrcamento");
        }
    }
}

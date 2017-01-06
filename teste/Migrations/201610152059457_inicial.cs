namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
           



            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClienteLocacao", "Estado_cEstado", "dbo.Estado");
            DropForeignKey("dbo.ClienteLocacao", "Cidade_cCidade", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "cEstado_cEstado", "dbo.Estado");
            DropIndex("dbo.ClienteLocacao", new[] { "Estado_cEstado" });
            DropIndex("dbo.ClienteLocacao", new[] { "Cidade_cCidade" });
            DropIndex("dbo.Cidade", new[] { "cEstado_cEstado" });
            DropTable("dbo.ClienteLocacao");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
        }
    }
}

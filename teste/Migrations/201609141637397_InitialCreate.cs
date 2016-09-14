namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteLocacao",
                c => new
                    {
                        idClienteLocacao = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.idClienteLocacao);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteLocacao");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrecoLocacao : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecoLocacao", "IDConsole_idConsole", "dbo.Console");
            DropIndex("dbo.PrecoLocacao", new[] { "IDConsole_idConsole" });
            DropTable("dbo.PrecoLocacao");
        }
    }
}

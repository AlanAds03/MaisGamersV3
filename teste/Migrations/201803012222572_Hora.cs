namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hora : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hora",
                c => new
                    {
                        idPrecoConsoleHora = c.Int(nullable: false, identity: true),
                        vMeiaHora = c.Double(nullable: false),
                        vUmaHora = c.Double(nullable: false),
                        vDuasHoras = c.Double(nullable: false),
                        Console_idConsole = c.Int(),
                    })
                .PrimaryKey(t => t.idPrecoConsoleHora)
                .ForeignKey("dbo.Console", t => t.Console_idConsole)
                .Index(t => t.Console_idConsole);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hora", "Console_idConsole", "dbo.Console");
            DropIndex("dbo.Hora", new[] { "Console_idConsole" });
            DropTable("dbo.Hora");
        }
    }
}

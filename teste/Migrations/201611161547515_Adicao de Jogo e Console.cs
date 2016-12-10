namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaodeJogoeConsole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Console",
                c => new
                    {
                        idConsole = c.Int(nullable: false, identity: true),
                        NomeConsole = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.idConsole);
            
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        idJogo = c.Int(nullable: false, identity: true),
                        Jogo = c.String(),
                        Console_idConsole = c.Int(),
                    })
                .PrimaryKey(t => t.idJogo)
                .ForeignKey("dbo.Console", t => t.Console_idConsole)
                .Index(t => t.Console_idConsole);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogo", "Console_idConsole", "dbo.Console");
            DropIndex("dbo.Jogo", new[] { "Console_idConsole" });
            DropTable("dbo.Jogo");
            DropTable("dbo.Console");
        }
    }
}

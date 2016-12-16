namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JOgoeConsole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Console",
                c => new
                    {
                        IDConsole = c.Int(nullable: false, identity: true),
                        NomeConsole = c.String(),
                    })
                .PrimaryKey(t => t.IDConsole);
            
            CreateTable(
                "dbo.Jogo",
                c => new
                    {
                        IDJogo = c.Int(nullable: false, identity: true),
                        NomeJogo = c.Int(nullable: false),
                        IDTipoJogo_IDTipoJogo = c.Int(nullable: false),
                        IDTipoJogo_NomeTipoJogo = c.Int(nullable: false),
                        IDConsole_IDConsole = c.Int(),
                    })
                .PrimaryKey(t => t.IDJogo)
                .ForeignKey("dbo.Console", t => t.IDConsole_IDConsole)
                .Index(t => t.IDConsole_IDConsole);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogo", "IDConsole_IDConsole", "dbo.Console");
            DropIndex("dbo.Jogo", new[] { "IDConsole_IDConsole" });
            DropTable("dbo.Jogo");
            DropTable("dbo.Console");
        }
    }
}

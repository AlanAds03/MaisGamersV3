namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaJogo : DbMigration
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
                        IDJogo = c.Int(nullable: false, identity: true),
                        NomeJogo = c.Int(nullable: false),
                        IDTipoJogo_IDTipoJogo = c.Int(nullable: false),
                        IDTipoJogo_NomeTipoJogo = c.Int(nullable: false),
                        Email = c.String(),
                        Senha = c.String(),
                        Quantidade = c.Int(nullable: false),
                        PrecoPago = c.Double(nullable: false),
                        PrecoVenda = c.Double(nullable: false),
                        IDConsole_idConsole = c.Int(),
                    })
                .PrimaryKey(t => t.IDJogo)
                .ForeignKey("dbo.Console", t => t.IDConsole_idConsole)
                .Index(t => t.IDConsole_idConsole);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogo", "IDConsole_idConsole", "dbo.Console");
            DropIndex("dbo.Jogo", new[] { "IDConsole_idConsole" });
            DropTable("dbo.Jogo");
            DropTable("dbo.Console");
        }
    }
}

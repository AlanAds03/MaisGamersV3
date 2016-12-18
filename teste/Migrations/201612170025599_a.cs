namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Jogo", new[] { "IDConsole_IDConsole" });
            AddColumn("dbo.Jogo", "Email", c => c.String());
            AddColumn("dbo.Jogo", "Senha", c => c.String());
            AddColumn("dbo.Jogo", "Quantidade", c => c.Int(nullable: false));
            AddColumn("dbo.Jogo", "PrecoPago", c => c.Double(nullable: false));
            AddColumn("dbo.Jogo", "PrecoVenda", c => c.Double(nullable: false));
            AlterColumn("dbo.Console", "NomeConsole", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Jogo", "IDConsole_idConsole");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Jogo", new[] { "IDConsole_idConsole" });
            AlterColumn("dbo.Console", "NomeConsole", c => c.String());
            DropColumn("dbo.Jogo", "PrecoVenda");
            DropColumn("dbo.Jogo", "PrecoPago");
            DropColumn("dbo.Jogo", "Quantidade");
            DropColumn("dbo.Jogo", "Senha");
            DropColumn("dbo.Jogo", "Email");
            CreateIndex("dbo.Jogo", "IDConsole_IDConsole");
        }
    }
}

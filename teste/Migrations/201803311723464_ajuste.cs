namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajuste : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hora", "Console_idConsole", "dbo.Console");
            DropForeignKey("dbo.Jogo", "IDConsole_idConsole", "dbo.Console");
            DropForeignKey("dbo.PrecoLocacao", "IDConsole_idConsole", "dbo.Console");
            DropPrimaryKey("dbo.Console");
            AlterColumn("dbo.Console", "idConsole", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Console", "idConsole");
            AddForeignKey("dbo.Hora", "Console_idConsole", "dbo.Console", "idConsole");
            AddForeignKey("dbo.Jogo", "IDConsole_idConsole", "dbo.Console", "idConsole");
            AddForeignKey("dbo.PrecoLocacao", "IDConsole_idConsole", "dbo.Console", "idConsole");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecoLocacao", "IDConsole_idConsole", "dbo.Console");
            DropForeignKey("dbo.Jogo", "IDConsole_idConsole", "dbo.Console");
            DropForeignKey("dbo.Hora", "Console_idConsole", "dbo.Console");
            DropPrimaryKey("dbo.Console");
            AlterColumn("dbo.Console", "idConsole", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Console", "idConsole");
            AddForeignKey("dbo.PrecoLocacao", "IDConsole_idConsole", "dbo.Console", "idConsole");
            AddForeignKey("dbo.Jogo", "IDConsole_idConsole", "dbo.Console", "idConsole");
            AddForeignKey("dbo.Hora", "Console_idConsole", "dbo.Console", "idConsole");
        }
    }
}

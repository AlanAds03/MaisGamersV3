namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addprecoJogo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jogo", "PrecoPrimaria", c => c.Double(nullable: false));
            AddColumn("dbo.Jogo", "PrecoSecundaria", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogo", "PrecoSecundaria");
            DropColumn("dbo.Jogo", "PrecoPrimaria");
        }
    }
}

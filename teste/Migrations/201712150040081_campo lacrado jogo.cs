namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campolacradojogo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jogo", "Lacrado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogo", "Lacrado");
        }
    }
}

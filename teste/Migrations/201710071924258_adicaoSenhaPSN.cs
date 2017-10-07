namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicaoSenhaPSN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jogo", "SenhaPSN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogo", "SenhaPSN");
        }
    }
}

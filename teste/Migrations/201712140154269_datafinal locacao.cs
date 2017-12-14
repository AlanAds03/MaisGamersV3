namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datafinallocacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "DataPrevisaoEntrega", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "DataPrevisaoEntrega");
        }
    }
}

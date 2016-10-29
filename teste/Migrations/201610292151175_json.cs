namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class json : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "JsonGRID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "JsonGRID");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSexo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "cSexo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "cSexo");
        }
    }
}

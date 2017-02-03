namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class telefone2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "Telefone2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "Telefone2");
        }
    }
}

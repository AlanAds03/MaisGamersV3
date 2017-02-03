namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddataexpedicao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "NomePai", c => c.String());
            AddColumn("dbo.ClienteLocacao", "DataExpedicao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "DataExpedicao");
            DropColumn("dbo.ClienteLocacao", "NomePai");
        }
    }
}

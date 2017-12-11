namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataexpedicaoCliente11122017AlanNote : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClienteLocacao", "DataExpedicao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClienteLocacao", "DataExpedicao", c => c.DateTime(nullable: false));
        }
    }
}

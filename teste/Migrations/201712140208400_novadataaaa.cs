namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novadataaaa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locacao", "DataLocacaoEntrega", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locacao", "DataLocacaoEntrega", c => c.DateTime(nullable: false));
        }
    }
}

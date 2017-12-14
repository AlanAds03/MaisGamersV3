namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataCadastroclienteLocacao13122017 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "DataCadastrado", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "DataCadastrado");
        }
    }
}

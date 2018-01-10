namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionaremailcliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "Email");
        }
    }
}

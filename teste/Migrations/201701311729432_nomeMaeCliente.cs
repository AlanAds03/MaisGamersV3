namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nomeMaeCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "NomeMae", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "NomeMae");
        }
    }
}

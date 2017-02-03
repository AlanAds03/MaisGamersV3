namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoFotoCLiente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "FotoLocatario", c => c.Binary());
            AddColumn("dbo.ClienteLocacao", "FotoAutorizado", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "FotoAutorizado");
            DropColumn("dbo.ClienteLocacao", "FotoLocatario");
        }
    }
}

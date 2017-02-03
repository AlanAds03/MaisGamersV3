namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class documentosAnexados : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "DocumentoAssinado", c => c.Binary());
            AddColumn("dbo.ClienteLocacao", "AnexoRG", c => c.Binary());
            AddColumn("dbo.ClienteLocacao", "AnexoComprovanteEndereco", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "AnexoComprovanteEndereco");
            DropColumn("dbo.ClienteLocacao", "AnexoRG");
            DropColumn("dbo.ClienteLocacao", "DocumentoAssinado");
        }
    }
}

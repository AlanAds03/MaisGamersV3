namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class documentos16122017 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClienteLocacao", "extensaoDocumentoAssinado", c => c.String());
            AddColumn("dbo.ClienteLocacao", "extensaoAnexoRG", c => c.String());
            AddColumn("dbo.ClienteLocacao", "extensaoComprovanteEndereco", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClienteLocacao", "extensaoComprovanteEndereco");
            DropColumn("dbo.ClienteLocacao", "extensaoAnexoRG");
            DropColumn("dbo.ClienteLocacao", "extensaoDocumentoAssinado");
        }
    }
}

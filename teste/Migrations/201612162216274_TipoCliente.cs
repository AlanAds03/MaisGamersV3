namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoCliente",
                c => new
                    {
                        IDTipoCliente = c.Int(nullable: false, identity: true),
                        TipoCliente = c.String(),
                    })
                .PrimaryKey(t => t.IDTipoCliente);
            
            AddColumn("dbo.ClienteLocacao", "Telefone", c => c.String());
            AddColumn("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente", c => c.Int());
            CreateIndex("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente");
            AddForeignKey("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente", "dbo.TipoCliente", "IDTipoCliente");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente", "dbo.TipoCliente");
            DropIndex("dbo.ClienteLocacao", new[] { "TipoCliente_IDTipoCliente" });
            DropColumn("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente");
            DropColumn("dbo.ClienteLocacao", "Telefone");
            DropTable("dbo.TipoCliente");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adicionarstatuscliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mStatusCliente",
                c => new
                    {
                        ID_StatusCliente = c.Int(nullable: false, identity: true),
                        DescricaoStatusCliente = c.String(),
                    })
                .PrimaryKey(t => t.ID_StatusCliente);
            
            AddColumn("dbo.ClienteLocacao", "DescricaoInativo", c => c.String());
            AddColumn("dbo.ClienteLocacao", "StatusCliente_ID_StatusCliente", c => c.Int());
            CreateIndex("dbo.ClienteLocacao", "StatusCliente_ID_StatusCliente");
            AddForeignKey("dbo.ClienteLocacao", "StatusCliente_ID_StatusCliente", "dbo.mStatusCliente", "ID_StatusCliente");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClienteLocacao", "StatusCliente_ID_StatusCliente", "dbo.mStatusCliente");
            DropIndex("dbo.ClienteLocacao", new[] { "StatusCliente_ID_StatusCliente" });
            DropColumn("dbo.ClienteLocacao", "StatusCliente_ID_StatusCliente");
            DropColumn("dbo.ClienteLocacao", "DescricaoInativo");
            DropTable("dbo.mStatusCliente");
        }
    }
}

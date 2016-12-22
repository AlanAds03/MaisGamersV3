namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaCaixa21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixa", "ClienteLocacao_idClienteLocacao", c => c.Int());
            CreateIndex("dbo.Caixa", "ClienteLocacao_idClienteLocacao");
            AddForeignKey("dbo.Caixa", "ClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao", "idClienteLocacao");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Caixa", "ClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao");
            DropIndex("dbo.Caixa", new[] { "ClienteLocacao_idClienteLocacao" });
            DropColumn("dbo.Caixa", "ClienteLocacao_idClienteLocacao");
        }
    }
}

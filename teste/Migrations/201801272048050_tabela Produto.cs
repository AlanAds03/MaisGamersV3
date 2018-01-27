namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        IDProduto = c.Int(nullable: false, identity: true),
                        Produto = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Unitario = c.Double(nullable: false),
                        Custo = c.Double(nullable: false),
                        Fornecedor = c.String(),
                    })
                .PrimaryKey(t => t.IDProduto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produto");
        }
    }
}

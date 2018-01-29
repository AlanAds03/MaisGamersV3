namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VendaProduto",
                c => new
                    {
                        IDVendaProduto = c.Int(nullable: false, identity: true),
                        Produto_IDProduto = c.Int(),
                        Venda_IDVenda = c.Int(),
                    })
                .PrimaryKey(t => t.IDVendaProduto)
                .ForeignKey("dbo.Produto", t => t.Produto_IDProduto)
                .ForeignKey("dbo.Vendas", t => t.Venda_IDVenda)
                .Index(t => t.Produto_IDProduto)
                .Index(t => t.Venda_IDVenda);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendaProduto", "Venda_IDVenda", "dbo.Vendas");
            DropForeignKey("dbo.VendaProduto", "Produto_IDProduto", "dbo.Produto");
            DropIndex("dbo.VendaProduto", new[] { "Venda_IDVenda" });
            DropIndex("dbo.VendaProduto", new[] { "Produto_IDProduto" });
            DropTable("dbo.VendaProduto");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposrestantes : DbMigration
    {
        public override void Up()
        {
           
            
          
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "mJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.VendaProduto", "Venda_IDVenda", "dbo.Vendas");
            DropForeignKey("dbo.VendaProduto", "Produto_IDProduto", "dbo.Produto");
            DropIndex("dbo.VendaProduto", new[] { "Venda_IDVenda" });
            DropIndex("dbo.VendaProduto", new[] { "Produto_IDProduto" });
            DropIndex("dbo.Vendas", new[] { "mJogo_IDJogo" });
            DropTable("dbo.VendaProduto");
            DropTable("dbo.Vendas");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajusteproduto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VendaProduto", "mProduto_IDProduto", "dbo.Produto");
            DropIndex("dbo.VendaProduto", new[] { "mProduto_IDProduto" });
            DropColumn("dbo.VendaProduto", "mProduto_IDProduto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VendaProduto", "mProduto_IDProduto", c => c.Int());
            CreateIndex("dbo.VendaProduto", "mProduto_IDProduto");
            AddForeignKey("dbo.VendaProduto", "mProduto_IDProduto", "dbo.Produto", "IDProduto");
        }
    }
}

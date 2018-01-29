namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removentonvendaproduto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.mVendamJogo", "mVenda_IDVenda", "dbo.Vendas");
            DropForeignKey("dbo.mVendamJogo", "mJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.mProdutomVenda", "mProduto_IDProduto", "dbo.Produto");
            DropForeignKey("dbo.mProdutomVenda", "mVenda_IDVenda", "dbo.Vendas");
            DropIndex("dbo.mVendamJogo", new[] { "mVenda_IDVenda" });
            DropIndex("dbo.mVendamJogo", new[] { "mJogo_IDJogo" });
            DropIndex("dbo.mProdutomVenda", new[] { "mProduto_IDProduto" });
            DropIndex("dbo.mProdutomVenda", new[] { "mVenda_IDVenda" });
            AddColumn("dbo.Vendas", "mJogo_IDJogo", c => c.Int());
            CreateIndex("dbo.Vendas", "mJogo_IDJogo");
            AddForeignKey("dbo.Vendas", "mJogo_IDJogo", "dbo.Jogo", "IDJogo");
            DropTable("dbo.mVendamJogo");
            DropTable("dbo.mProdutomVenda");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.mProdutomVenda",
                c => new
                    {
                        mProduto_IDProduto = c.Int(nullable: false),
                        mVenda_IDVenda = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.mProduto_IDProduto, t.mVenda_IDVenda });
            
            CreateTable(
                "dbo.mVendamJogo",
                c => new
                    {
                        mVenda_IDVenda = c.Int(nullable: false),
                        mJogo_IDJogo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.mVenda_IDVenda, t.mJogo_IDJogo });
            
            DropForeignKey("dbo.Vendas", "mJogo_IDJogo", "dbo.Jogo");
            DropIndex("dbo.Vendas", new[] { "mJogo_IDJogo" });
            DropColumn("dbo.Vendas", "mJogo_IDJogo");
            CreateIndex("dbo.mProdutomVenda", "mVenda_IDVenda");
            CreateIndex("dbo.mProdutomVenda", "mProduto_IDProduto");
            CreateIndex("dbo.mVendamJogo", "mJogo_IDJogo");
            CreateIndex("dbo.mVendamJogo", "mVenda_IDVenda");
            AddForeignKey("dbo.mProdutomVenda", "mVenda_IDVenda", "dbo.Vendas", "IDVenda", cascadeDelete: true);
            AddForeignKey("dbo.mProdutomVenda", "mProduto_IDProduto", "dbo.Produto", "IDProduto", cascadeDelete: true);
            AddForeignKey("dbo.mVendamJogo", "mJogo_IDJogo", "dbo.Jogo", "IDJogo", cascadeDelete: true);
            AddForeignKey("dbo.mVendamJogo", "mVenda_IDVenda", "dbo.Vendas", "IDVenda", cascadeDelete: true);
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Venda_Produto_Jogo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mVenda",
                c => new
                    {
                        IDVenda = c.Int(nullable: false, identity: true),
                        dVenda = c.DateTime(nullable: false),
                        rCliente = c.String(),
                        vValorTotal = c.Double(nullable: false),
                        vValorPago = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IDVenda);
            
            CreateTable(
                "dbo.mVendamJogo",
                c => new
                    {
                        mVenda_IDVenda = c.Int(nullable: false),
                        mJogo_IDJogo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.mVenda_IDVenda, t.mJogo_IDJogo })
                .ForeignKey("dbo.mVenda", t => t.mVenda_IDVenda, cascadeDelete: true)
                .ForeignKey("dbo.Jogo", t => t.mJogo_IDJogo, cascadeDelete: true)
                .Index(t => t.mVenda_IDVenda)
                .Index(t => t.mJogo_IDJogo);
            
            CreateTable(
                "dbo.mProdutomVenda",
                c => new
                    {
                        mProduto_IDProduto = c.Int(nullable: false),
                        mVenda_IDVenda = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.mProduto_IDProduto, t.mVenda_IDVenda })
                .ForeignKey("dbo.Produto", t => t.mProduto_IDProduto, cascadeDelete: true)
                .ForeignKey("dbo.mVenda", t => t.mVenda_IDVenda, cascadeDelete: true)
                .Index(t => t.mProduto_IDProduto)
                .Index(t => t.mVenda_IDVenda);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mProdutomVenda", "mVenda_IDVenda", "dbo.mVenda");
            DropForeignKey("dbo.mProdutomVenda", "mProduto_IDProduto", "dbo.Produto");
            DropForeignKey("dbo.mVendamJogo", "mJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.mVendamJogo", "mVenda_IDVenda", "dbo.mVenda");
            DropIndex("dbo.mProdutomVenda", new[] { "mVenda_IDVenda" });
            DropIndex("dbo.mProdutomVenda", new[] { "mProduto_IDProduto" });
            DropIndex("dbo.mVendamJogo", new[] { "mJogo_IDJogo" });
            DropIndex("dbo.mVendamJogo", new[] { "mVenda_IDVenda" });
            DropTable("dbo.mProdutomVenda");
            DropTable("dbo.mVendamJogo");
            DropTable("dbo.mVenda");
        }
    }
}

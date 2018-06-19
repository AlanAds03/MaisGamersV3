namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajusteVendaProduto : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.VendaProduto", name: "Produto_IDProduto", newName: "mProduto_IDProduto");
            RenameIndex(table: "dbo.VendaProduto", name: "IX_Produto_IDProduto", newName: "IX_mProduto_IDProduto");
            AddColumn("dbo.VendaProduto", "IDOrigem", c => c.Int(nullable: false));
            AddColumn("dbo.VendaProduto", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VendaProduto", "Descricao");
            DropColumn("dbo.VendaProduto", "IDOrigem");
            RenameIndex(table: "dbo.VendaProduto", name: "IX_mProduto_IDProduto", newName: "IX_Produto_IDProduto");
            RenameColumn(table: "dbo.VendaProduto", name: "mProduto_IDProduto", newName: "Produto_IDProduto");
        }
    }
}

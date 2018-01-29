namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trocandotabela : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.mVenda", newName: "Vendas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Vendas", newName: "mVenda");
        }
    }
}

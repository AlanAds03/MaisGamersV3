namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locacao", "StatusLocacao_IDStatusLocacao", "dbo.StatusLocacao");
            RenameColumn(table: "dbo.Locacao", name: "StatusLocacao_IDStatusLocacao", newName: "StatusLocacao_IDStatus");
            RenameIndex(table: "dbo.Locacao", name: "IX_StatusLocacao_IDStatusLocacao", newName: "IX_StatusLocacao_IDStatus");
            DropPrimaryKey("dbo.StatusLocacao");
            AddColumn("dbo.Jogo", "SenhaPSN", c => c.String());
            AddColumn("dbo.StatusLocacao", "IDStatus", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StatusLocacao", "IDStatus");
            AddForeignKey("dbo.Locacao", "StatusLocacao_IDStatus", "dbo.StatusLocacao", "IDStatus");
            DropColumn("dbo.StatusLocacao", "IDStatusLocacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StatusLocacao", "IDStatusLocacao", c => c.Int(nullable: false));
            DropForeignKey("dbo.Locacao", "StatusLocacao_IDStatus", "dbo.StatusLocacao");
            DropPrimaryKey("dbo.StatusLocacao");
            DropColumn("dbo.StatusLocacao", "IDStatus");
            DropColumn("dbo.Jogo", "SenhaPSN");
            AddPrimaryKey("dbo.StatusLocacao", "IDStatusLocacao");
            RenameIndex(table: "dbo.Locacao", name: "IX_StatusLocacao_IDStatus", newName: "IX_StatusLocacao_IDStatusLocacao");
            RenameColumn(table: "dbo.Locacao", name: "StatusLocacao_IDStatus", newName: "StatusLocacao_IDStatusLocacao");
            AddForeignKey("dbo.Locacao", "StatusLocacao_IDStatusLocacao", "dbo.StatusLocacao", "IDStatusLocacao");
        }
    }
}

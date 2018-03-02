namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class anotacao : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Anotacao", newName: "mAnotacao");
            CreateTable(
                "dbo.mStatusAnotacao",
                c => new
                    {
                        ID_StatusAnotacao = c.Int(nullable: false, identity: true),
                        StatusAnotacao = c.String(),
                    })
                .PrimaryKey(t => t.ID_StatusAnotacao);
            
            AddColumn("dbo.mAnotacao", "DataAnotacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.mAnotacao", "Descricao", c => c.String());
            AddColumn("dbo.mAnotacao", "StatusAnotacao_ID_StatusAnotacao", c => c.Int());
            CreateIndex("dbo.mAnotacao", "StatusAnotacao_ID_StatusAnotacao");
            AddForeignKey("dbo.mAnotacao", "StatusAnotacao_ID_StatusAnotacao", "dbo.mStatusAnotacao", "ID_StatusAnotacao");
            DropColumn("dbo.mAnotacao", "Nome");
            DropColumn("dbo.mAnotacao", "Observacao");
            DropColumn("dbo.mAnotacao", "DataObservacao");
            DropColumn("dbo.mAnotacao", "StatusAnotacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.mAnotacao", "StatusAnotacao", c => c.Int(nullable: false));
            AddColumn("dbo.mAnotacao", "DataObservacao", c => c.String());
            AddColumn("dbo.mAnotacao", "Observacao", c => c.String());
            AddColumn("dbo.mAnotacao", "Nome", c => c.String());
            DropForeignKey("dbo.mAnotacao", "StatusAnotacao_ID_StatusAnotacao", "dbo.mStatusAnotacao");
            DropIndex("dbo.mAnotacao", new[] { "StatusAnotacao_ID_StatusAnotacao" });
            DropColumn("dbo.mAnotacao", "StatusAnotacao_ID_StatusAnotacao");
            DropColumn("dbo.mAnotacao", "Descricao");
            DropColumn("dbo.mAnotacao", "DataAnotacao");
            DropTable("dbo.mStatusAnotacao");
            RenameTable(name: "dbo.mAnotacao", newName: "Anotacao");
        }
    }
}

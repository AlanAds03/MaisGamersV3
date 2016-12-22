namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionaTipoJogo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoJogo",
                c => new
                    {
                        IDTipoJogo = c.Int(nullable: false, identity: true),
                        NomeTipoJogo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDTipoJogo);
            
            AlterColumn("dbo.Jogo", "IDTipoJogo_IDTipoJogo", c => c.Int());
            CreateIndex("dbo.Jogo", "IDTipoJogo_IDTipoJogo");
            AddForeignKey("dbo.Jogo", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo", "IDTipoJogo");
            DropColumn("dbo.Jogo", "IDTipoJogo_NomeTipoJogo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jogo", "IDTipoJogo_NomeTipoJogo", c => c.Int(nullable: false));
            DropForeignKey("dbo.Jogo", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo");
            DropIndex("dbo.Jogo", new[] { "IDTipoJogo_IDTipoJogo" });
            AlterColumn("dbo.Jogo", "IDTipoJogo_IDTipoJogo", c => c.Int(nullable: false));
            DropTable("dbo.TipoJogo");
        }
    }
}

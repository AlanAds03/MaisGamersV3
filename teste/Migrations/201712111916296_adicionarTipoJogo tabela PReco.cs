namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionarTipoJogotabelaPReco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", c => c.Int());
            CreateIndex("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo");
            AddForeignKey("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo", "IDTipoJogo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo");
            DropIndex("dbo.PrecoLocacao", new[] { "IDTipoJogo_IDTipoJogo" });
            DropColumn("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo");
        }
    }
}

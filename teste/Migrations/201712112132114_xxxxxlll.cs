namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xxxxxlll : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", c => c.Int());
            AlterColumn("dbo.ClienteLocacao", "DataExpedicao", c => c.DateTime());
            CreateIndex("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo");
            AddForeignKey("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo", "IDTipoJogo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo");
            DropIndex("dbo.PrecoLocacao", new[] { "IDTipoJogo_IDTipoJogo" });
            AlterColumn("dbo.ClienteLocacao", "DataExpedicao", c => c.DateTime(nullable: false));
            DropColumn("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraTipoJogo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TipoJogo", "NomeTipoJogo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoJogo", "NomeTipoJogo", c => c.Int(nullable: false));
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterarTipoNomeJogo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jogo", "NomeJogo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogo", "NomeJogo", c => c.Int(nullable: false));
        }
    }
}

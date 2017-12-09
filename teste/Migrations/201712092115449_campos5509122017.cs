namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campos5509122017 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jogo", "ValorVendaPrimaria", c => c.Double());
            AddColumn("dbo.Jogo", "ValorVendaSecundaria", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogo", "ValorVendaSecundaria");
            DropColumn("dbo.Jogo", "ValorVendaPrimaria");
        }
    }
}

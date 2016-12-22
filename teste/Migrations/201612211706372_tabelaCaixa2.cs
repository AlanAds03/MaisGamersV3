namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaCaixa2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Caixa", "Valor", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Caixa", "Valor", c => c.Double(nullable: false));
        }
    }
}

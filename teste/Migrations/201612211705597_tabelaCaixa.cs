namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaCaixa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caixa",
                c => new
                    {
                        IdCaixa = c.Int(nullable: false, identity: true),
                        TipoEntradas = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdCaixa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Caixa");
        }
    }
}

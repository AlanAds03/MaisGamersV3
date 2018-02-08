namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoPagamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoPagamento",
                c => new
                    {
                        IDTipoPagamento = c.Int(nullable: false),
                        TipoPagamento = c.String(),
                        Taxa = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IDTipoPagamento);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoPagamento");
        }
    }
}

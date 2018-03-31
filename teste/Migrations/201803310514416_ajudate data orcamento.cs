namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajudatedataorcamento : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orcamento", "Data_Retorno", c => c.DateTime());
            AlterColumn("dbo.Orcamento", "Data_Entrega", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orcamento", "Data_Entrega", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orcamento", "Data_Retorno", c => c.DateTime(nullable: false));
        }
    }
}

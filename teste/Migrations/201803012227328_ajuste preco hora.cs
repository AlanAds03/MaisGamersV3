namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajusteprecohora : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hora", "Descricao", c => c.String());
            AddColumn("dbo.Hora", "vPreco", c => c.Double(nullable: false));
            DropColumn("dbo.Hora", "vMeiaHora");
            DropColumn("dbo.Hora", "vUmaHora");
            DropColumn("dbo.Hora", "vDuasHoras");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hora", "vDuasHoras", c => c.Double(nullable: false));
            AddColumn("dbo.Hora", "vUmaHora", c => c.Double(nullable: false));
            AddColumn("dbo.Hora", "vMeiaHora", c => c.Double(nullable: false));
            DropColumn("dbo.Hora", "vPreco");
            DropColumn("dbo.Hora", "Descricao");
        }
    }
}

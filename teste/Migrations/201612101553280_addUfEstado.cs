namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUfEstado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estado", "UF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Estado", "UF");
        }
    }
}

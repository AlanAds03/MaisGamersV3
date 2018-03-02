namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajuste : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.mAnotacao", newName: "Anotacao");
            RenameTable(name: "dbo.mStatusAnotacao", newName: "StatusAnotacao");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.StatusAnotacao", newName: "mStatusAnotacao");
            RenameTable(name: "dbo.Anotacao", newName: "mAnotacao");
        }
    }
}

namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        cCidade = c.Int(nullable: false),
                        rCidade = c.String(),
                        cEstado_cEstado = c.Int(),
                    })
                .PrimaryKey(t => t.cCidade)
                .ForeignKey("dbo.Estado", t => t.cEstado_cEstado)
                .Index(t => t.cEstado_cEstado);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        cEstado = c.Int(nullable: false),
                        rEstado = c.String(),
                    })
                .PrimaryKey(t => t.cEstado);
            
            CreateTable(
                "dbo.ClienteLocacao",
                c => new
                    {
                        idClienteLocacao = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        RG = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Rua = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        CEP = c.String(),
                        NomeFilho = c.String(),
                        CPFFilho = c.String(),
                        RGFilho = c.String(),
                        Cidade_cCidade = c.Int(),
                        Estado_cEstado = c.Int(),
                    })
                .PrimaryKey(t => t.idClienteLocacao)
                .ForeignKey("dbo.Cidade", t => t.Cidade_cCidade)
                .ForeignKey("dbo.Estado", t => t.Estado_cEstado)
                .Index(t => t.Cidade_cCidade)
                .Index(t => t.Estado_cEstado);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClienteLocacao", "Estado_cEstado", "dbo.Estado");
            DropForeignKey("dbo.ClienteLocacao", "Cidade_cCidade", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "cEstado_cEstado", "dbo.Estado");
            DropIndex("dbo.ClienteLocacao", new[] { "Estado_cEstado" });
            DropIndex("dbo.ClienteLocacao", new[] { "Cidade_cCidade" });
            DropIndex("dbo.Cidade", new[] { "cEstado_cEstado" });
            DropTable("dbo.ClienteLocacao");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
        }
    }
}

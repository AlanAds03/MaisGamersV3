namespace teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bancoinicial : DbMigration
    {
        public override void Up()
        {
            
            
           
            
            
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecoLocacao", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo");
            DropForeignKey("dbo.PrecoLocacao", "IDConsole_IDConsole", "dbo.Console");
            DropForeignKey("dbo.LocacaoJogo", "IDLocacao_IDLocacao", "dbo.Locacao");
            DropForeignKey("dbo.LocacaoJogo", "IDJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.Locacao", "StatusLocacao_IDStatus", "dbo.StatusLocacao");
            DropForeignKey("dbo.Locacao", "IDClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao");
            DropForeignKey("dbo.Vendas", "mJogo_IDJogo", "dbo.Jogo");
            DropForeignKey("dbo.VendaProduto", "Venda_IDVenda", "dbo.Vendas");
            DropForeignKey("dbo.Jogo", "IDTipoJogo_IDTipoJogo", "dbo.TipoJogo");
            DropForeignKey("dbo.Jogo", "IDConsole_IDConsole", "dbo.Console");
            DropForeignKey("dbo.Hora", "Console_IDConsole", "dbo.Console");
            DropForeignKey("dbo.FotosOrcamento", "IDOrcamento_IDOrcamento", "dbo.Orcamento");
            DropForeignKey("dbo.Orcamento", "StatusOrcamento_IDStatusOrcamento", "dbo.StatusOrcamento");
            DropForeignKey("dbo.Caixa", "ClienteLocacao_idClienteLocacao", "dbo.ClienteLocacao");
            DropForeignKey("dbo.ClienteLocacao", "TipoCliente_IDTipoCliente", "dbo.TipoCliente");
            DropForeignKey("dbo.ClienteLocacao", "StatusCliente_ID_StatusCliente", "dbo.mStatusCliente");
            DropForeignKey("dbo.ClienteLocacao", "Estado_cEstado", "dbo.Estado");
            DropForeignKey("dbo.ClienteLocacao", "Cidade_cCidade", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "cEstado_cEstado", "dbo.Estado");
            DropForeignKey("dbo.Anotacao", "StatusAnotacao_ID_StatusAnotacao", "dbo.StatusAnotacao");
            DropIndex("dbo.PrecoLocacao", new[] { "IDTipoJogo_IDTipoJogo" });
            DropIndex("dbo.PrecoLocacao", new[] { "IDConsole_IDConsole" });
            DropIndex("dbo.LocacaoJogo", new[] { "IDLocacao_IDLocacao" });
            DropIndex("dbo.LocacaoJogo", new[] { "IDJogo_IDJogo" });
            DropIndex("dbo.Locacao", new[] { "StatusLocacao_IDStatus" });
            DropIndex("dbo.Locacao", new[] { "IDClienteLocacao_idClienteLocacao" });
            DropIndex("dbo.VendaProduto", new[] { "Venda_IDVenda" });
            DropIndex("dbo.Vendas", new[] { "mJogo_IDJogo" });
            DropIndex("dbo.Jogo", new[] { "IDTipoJogo_IDTipoJogo" });
            DropIndex("dbo.Jogo", new[] { "IDConsole_IDConsole" });
            DropIndex("dbo.Hora", new[] { "Console_IDConsole" });
            DropIndex("dbo.Orcamento", new[] { "StatusOrcamento_IDStatusOrcamento" });
            DropIndex("dbo.FotosOrcamento", new[] { "IDOrcamento_IDOrcamento" });
            DropIndex("dbo.Cidade", new[] { "cEstado_cEstado" });
            DropIndex("dbo.ClienteLocacao", new[] { "TipoCliente_IDTipoCliente" });
            DropIndex("dbo.ClienteLocacao", new[] { "StatusCliente_ID_StatusCliente" });
            DropIndex("dbo.ClienteLocacao", new[] { "Estado_cEstado" });
            DropIndex("dbo.ClienteLocacao", new[] { "Cidade_cCidade" });
            DropIndex("dbo.Caixa", new[] { "ClienteLocacao_idClienteLocacao" });
            DropIndex("dbo.Anotacao", new[] { "StatusAnotacao_ID_StatusAnotacao" });
            DropTable("dbo.TipoPagamento");
            DropTable("dbo.Produto");
            DropTable("dbo.PrecoLocacao");
            DropTable("dbo.LocacaoJogo");
            DropTable("dbo.StatusLocacao");
            DropTable("dbo.Locacao");
            DropTable("dbo.VendaProduto");
            DropTable("dbo.Vendas");
            DropTable("dbo.TipoJogo");
            DropTable("dbo.Jogo");
            DropTable("dbo.Hora");
            DropTable("dbo.StatusOrcamento");
            DropTable("dbo.Orcamento");
            DropTable("dbo.FotosOrcamento");
            DropTable("dbo.Console");
            DropTable("dbo.TipoCliente");
            DropTable("dbo.mStatusCliente");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
            DropTable("dbo.ClienteLocacao");
            DropTable("dbo.Caixa");
            DropTable("dbo.StatusAnotacao");
            DropTable("dbo.Anotacao");
        }
    }
}

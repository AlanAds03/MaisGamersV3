using MaisGamers.DAL.Cadastro;
using MaisGamers.Model.Cadastro;
using MaisGamers.Model.Locacao;
using MaisGamers.Model.Orcamento;
using MaisGamers.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model
{
    public class Contexto : DbContext
    {
        public DbSet<mClienteLocacao> ClienteLocacao { get; set; }

        public DbSet<mEstado> Estado { get; set; }

        public DbSet<mCidade> Cidade { get; set; }

        public DbSet<mConsole> Console { get; set; }

        public DbSet<mJogo> Jogo { get; set; }

        public DbSet<mTipoCliente> TipoCliente{ get; set; }

        public DbSet<mTipoJogo> TipoJogo { get; set; }

        public DbSet<mVenda> Vendas { get; set; }

        public DbSet<mCaixa> Caixa { get; set; }

        public DbSet<mLocacao> Locacao { get; set; }

        public DbSet<mLocacaoJogos> LocacaoJogos { get; set; }

        public DbSet<mStatusLocacao> StatusLocacao { get; set; }

        public DbSet<mAnotacao> Anotacao { get; set; }

        public DbSet<mStatusCliente> StatusCliente { get; set; }

        public DbSet<mProduto> Produtos { get; set; }

        public DbSet<mTipoOrcamento> TipoOrcamento { get; set; }

        public DbSet<mTipoOrcamentoStatus> TipoOrcamentoStatus { get; set; }

        public DbSet<mPrecoLocacao> PrecoLocacao { get; set; }

        public DbSet<mVendaProduto> VendaProduto { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}

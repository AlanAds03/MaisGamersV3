﻿using MaisGamers.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaisGamers.DLL;
using MaisGamers.Model.Cadastro;
using Frameworks.Componentes;
using MaisGamers.DLL.Cadastro;
using MaisGamers.DLL.Cadastro.Cadastro;
using static MaisGamers.Modulos.util;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmPesquisaJogo : Form
    {
        public util.ModoTela modo_tela;
        public int idJogo;
        public frmPesquisaJogo()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            //util.CentralizaGrupo(grpBotoes);
            //util.CentralizaTab(tabControl1);

            CarregaComboConsole(cmbConsolePesquisa);
            
        }

        private void CarregaComboConsole(SuperComboBox combo)
        {
            try
            {
                bConsole _bConsole = new bConsole();

                    List<mConsole> console = new List<mConsole>();

                    console = _bConsole.CarregaConsole();
                    combo.CarregaCombo(console, "idConsole", "NomeConsole", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CarregaComboTipoJogo(SuperComboBox combo)
        {
            try
            {
                bTipoJogo _bTipo = new bTipoJogo();

                List<mTipoJogo> Tipo = new List<mTipoJogo>();

                Tipo = _bTipo.CarregaTipoJogo();
                combo.CarregaCombo(Tipo, "IDTipoJogo", "NomeTipoJogo", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo_tela = util.ModoTela.NOVO;
            atualizaTela();
        }


        private void atualizaTela()
        {
            if (modo_tela == util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";

                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());


            }
            else if (modo_tela == util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

                bJogo _bJogo = new bJogo();
                mJogo _mJogo = new mJogo();

                _mJogo = _bJogo.PesquisaJogoID(idJogo);

                


            }

            else if (modo_tela == util.ModoTela.NOVO)
            {
                LimpaCampos();
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

            }
        }

        private void LimpaCampos()
        {
            idJogo = 0;
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
                this.Close();
                this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                bJogo _bJogo = new bJogo();
                mJogo jogo = new mJogo();

                

                if(idJogo != 0)
                {
                    jogo.IDJogo = idJogo;
                }
                
                
                
                if (_bJogo.InserirJogo(jogo))
                {
                    if(idJogo != 0)
                    {
                        Mensagem("Jogo alterado com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                    }
                    else
                    {
                        Mensagem("Jogo inserido com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                    }
                    
                    modo_tela = ModoTela.CONSULTA;
                    atualizaTela();
                }
                else
                {
                    Mensagem("Jogo inserido com erro", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            

            PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());
        }


        private void PesquisaGrid(string NomeJogo, string Console)
        {


            bJogo _bJogo = new bJogo();
            mJogo jogo = new mJogo();
            List<mJogo> Jogos = new List<mJogo>();
            string json;

            try
            {
                

                if (!string.IsNullOrEmpty(NomeJogo))
                {
                    jogo.NomeJogo = NomeJogo;
                }

                if (!string.IsNullOrEmpty(Console))
                {
                    jogo.cIdConsole = Convert.ToInt32(Console);
                }

                    lvPesquisa.CarregaListaView<mJogo>(_bJogo.PesquisaJogo(jogo, "Nome"));
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        private void cmbConsolePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsolePesquisa.Carregado == true)
            {
                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());
            }

        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked == true)
            {
                idJogo = lvPesquisa.ObterChave();

            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = util.ModoTela.ALTERACAO;
            atualizaTela();
        }
    
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class TelaPrincipal : Form
    {
        // Variavel global.
        string idUsuario = "";
        // bandeira para sinalizar quando o editar ou o apagar podem ser invocados:
        bool podeEditarApagar = false;

        public TelaPrincipal()
        {
            InitializeComponent();
        }


        // Preenche a fonte do DGV com os dados da tabela.
        public void atualizaTabela()
        {
            dgvUserList.DataSource = db.UsuarioDAO.listar();
        }

        // Ao carregar a tela a tabela é preenchida.
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            atualizaTabela();
        }

        // Fecha a janela atual.
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Seleciona um usuário específico.
        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                // Declarar um DataTable para obter a resposta de um consulta:
                DataTable dt = new DataTable();
                // Obter o id do usuário selecionado:
                idUsuario = dgv.SelectedRows[0].Cells[1].Value.ToString();
                MessageBox.Show(idUsuario + "");
                // Buscar o usuário com base no ID:
                // Obter o resultado da consulta no nosso datatable local:
                dt = db.UsuarioDAO.buscarUsuario(idUsuario);
                // obter linha 0:
                var linha = dt.Rows[0];
                // Preencher os campos do editar:
                txbNome.Text = linha.Field<string>("Nome").ToString();
                txbEmail.Text = linha.Field<string>("Email").ToString();
                txbDataNasc.Text = linha.Field<string>("Nascimento").ToString();
                txbSenha.Text = linha.Field<string>("Senha").ToString();
                podeEditarApagar = true;
            }
        }

        // Remove o usuário selecionado.
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (podeEditarApagar)
            {
                // Instanciar o objeto Funcionario.
                Usuario user = new Usuario();
                // Inserir os dados dos campos nos atributos do obj.
                
                user.Email = txbEmail.Text;
                user.Senha = txbSenha.Text;
                user.Nome = txbNome.Text;
                user.Data = txbDataNasc.Text;
                // ID é armazenado em idUsuario (global)
                if (db.UsuarioDAO.excluir(idUsuario))
                {
                    txbNome.Clear();
                    txbSenha.Clear();
                    txbEmail.Clear();
                    txbDataNasc.Clear();
                    atualizaTabela();
                }
                else
                {
                    MessageBox.Show("Erro! Verifique os dados informados!");
                }
            }
            else
            {
                MessageBox.Show("Erro! Não existem dados a serem editados!");
            }
        }
    }
}


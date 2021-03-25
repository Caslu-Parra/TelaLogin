﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Email = txbEmail.Text;
            user.Senha = txbSenha.Text;


            txbEmail.Clear();
            txbSenha.Clear();

            DataTable resultado = new DataTable();
            resultado = db.UsuarioDAO.login(user);

            try
            {
                var linha = resultado.Rows[0];

                if (linha.Field<string>("Senha") != user.Senha || linha.Field<string>("Email") != user.Email)
                {
                    MessageBox.Show("Usuário ou/e senha incorretos");
                }
                else
                {
                    MessageBox.Show("Usuário show");
                }
            }
            catch
            {
                MessageBox.Show("Usuário ou/e senha incorretos");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroJanela janelaCad = new CadastroJanela();

            this.Hide();
            janelaCad.ShowDialog();
            this.Show();
        }
    }
}

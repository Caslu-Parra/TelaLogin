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

            if (db.UsuarioDAO.login(user))
            {
                MessageBox.Show("User Válido");
            }
            else { 
                MessageBox.Show("User Inválido");
            }
        }
    }
}
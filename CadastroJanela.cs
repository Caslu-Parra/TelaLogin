using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;



namespace TelaLogin
{
    public partial class CadastroJanela : Form
    {
        public CadastroJanela()
        {
            InitializeComponent();
        }

        // Botao de cadastro de novo usuário.
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Email = txbEmail.Text;
            user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text);
            user.Nome = txbNome.Text;
            user.Data = txbDataNasc.Text;


            txbEmail.Clear();
            txbSenha.Clear();

            if (db.UsuarioDAO.cadastrar(user))
            {
                MessageBox.Show(user.Nome + " foi cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar o cadastro, verifique os dados informados!");
            }
        }
    }
}

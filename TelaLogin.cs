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
    public partial class FormLogin : Form
    {
        // Janela de cadastro
        CadastroJanela janelaCad = new CadastroJanela();
        // Janela Home do Usuário
        TelaPrincipal janelaUserList = new TelaPrincipal();
        public FormLogin()
        {
            InitializeComponent();
        }

        // Botão para verificação de login.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Email = txbEmail.Text;
            user.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenha.Text);


            txbEmail.Clear();
            txbSenha.Clear();

            DataTable resultado = new DataTable();
            resultado = db.UsuarioDAO.login(user);

            bool continuar = false;
            DataRow linha = null;
            try
            {
                linha = resultado.Rows[0];
                continuar = true;
            }catch
            {
                MessageBox.Show("Usuário ou/e senha incorretos");
            }

            if (continuar)
            {
                if (linha.Field<string>("Senha") != user.Senha || linha.Field<string>("Email") != user.Email)
                {
                    MessageBox.Show("Usuário ou/e senha incorretos");
                }
                else
                {
                    this.Hide();
                    janelaUserList.ShowDialog();
                    this.Show();
                }
            }
            
        }

       // Abre a janela de cadastro de novos usuários.
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroJanela janelaCad = new CadastroJanela();

            this.Hide();
            janelaCad.ShowDialog();
            this.Show();
        }
    }
}

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
        private string SHA256(string valor)
        {
             UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA256Managed SHhash = new SHA256Managed();
            string strHex = "";

           HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
               {
                 strHex += String.Format("{0:x2}", b);
               }
           return strHex;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string ShaSenha = SHA256(txbSenha.Text);
            MessageBox.Show(ShaSenha);
            Usuario user = new Usuario();

            user.Email = txbEmail.Text;
            user.Senha = txbSenha.Text;
            user.Nome = txbEmail.Text;
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

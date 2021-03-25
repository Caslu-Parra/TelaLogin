
namespace TelaLogin
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxUsuarios = new System.Windows.Forms.GroupBox();
            this.gbxAlteracao = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbDataNasc = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gbxUsuarios.SuspendLayout();
            this.gbxAlteracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(167, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 42);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tela Principal";
            // 
            // gbxUsuarios
            // 
            this.gbxUsuarios.Controls.Add(this.dgvUserList);
            this.gbxUsuarios.ForeColor = System.Drawing.Color.White;
            this.gbxUsuarios.Location = new System.Drawing.Point(39, 83);
            this.gbxUsuarios.Name = "gbxUsuarios";
            this.gbxUsuarios.Size = new System.Drawing.Size(536, 190);
            this.gbxUsuarios.TabIndex = 2;
            this.gbxUsuarios.TabStop = false;
            this.gbxUsuarios.Text = "Usuarios Cadastrados";
            // 
            // gbxAlteracao
            // 
            this.gbxAlteracao.Controls.Add(this.btnRemover);
            this.gbxAlteracao.Controls.Add(this.txbDataNasc);
            this.gbxAlteracao.Controls.Add(this.txbSenha);
            this.gbxAlteracao.Controls.Add(this.txbEmail);
            this.gbxAlteracao.Controls.Add(this.btnSair);
            this.gbxAlteracao.Controls.Add(this.txbNome);
            this.gbxAlteracao.Controls.Add(this.lblDataNasc);
            this.gbxAlteracao.Controls.Add(this.lblSenha);
            this.gbxAlteracao.Controls.Add(this.lblEmail);
            this.gbxAlteracao.Controls.Add(this.lblNome);
            this.gbxAlteracao.Controls.Add(this.btnModificar);
            this.gbxAlteracao.ForeColor = System.Drawing.Color.White;
            this.gbxAlteracao.Location = new System.Drawing.Point(39, 279);
            this.gbxAlteracao.Name = "gbxAlteracao";
            this.gbxAlteracao.Size = new System.Drawing.Size(536, 165);
            this.gbxAlteracao.TabIndex = 3;
            this.gbxAlteracao.TabStop = false;
            this.gbxAlteracao.Text = "Alteração";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkRed;
            this.btnModificar.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(408, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 37);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(139, 51);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(313, 29);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Gerenciamento de Usuarios";
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(0, 13);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.Size = new System.Drawing.Size(536, 177);
            this.dgvUserList.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(419, 112);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 43);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(23, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(148, 24);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(63, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(55, 88);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 24);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblDataNasc.Location = new System.Drawing.Point(41, 124);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(95, 24);
            this.lblDataNasc.TabIndex = 6;
            this.lblDataNasc.Text = "Data Nasc";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.DarkRed;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.Color.Khaki;
            this.txbNome.Location = new System.Drawing.Point(188, 14);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(192, 31);
            this.txbNome.TabIndex = 6;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.DarkRed;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.Khaki;
            this.txbEmail.Location = new System.Drawing.Point(188, 51);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(192, 31);
            this.txbEmail.TabIndex = 7;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.DarkRed;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.ForeColor = System.Drawing.Color.Khaki;
            this.txbSenha.Location = new System.Drawing.Point(188, 88);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(192, 31);
            this.txbSenha.TabIndex = 8;
            // 
            // txbDataNasc
            // 
            this.txbDataNasc.BackColor = System.Drawing.Color.DarkRed;
            this.txbDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataNasc.ForeColor = System.Drawing.Color.Khaki;
            this.txbDataNasc.Location = new System.Drawing.Point(188, 125);
            this.txbDataNasc.Name = "txbDataNasc";
            this.txbDataNasc.Size = new System.Drawing.Size(192, 31);
            this.txbDataNasc.TabIndex = 9;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(408, 62);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(106, 37);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.gbxAlteracao);
            this.Controls.Add(this.gbxUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.gbxUsuarios.ResumeLayout(false);
            this.gbxAlteracao.ResumeLayout(false);
            this.gbxAlteracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxUsuarios;
        private System.Windows.Forms.GroupBox gbxAlteracao;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbDataNasc;
        private System.Windows.Forms.Button btnRemover;
    }
}
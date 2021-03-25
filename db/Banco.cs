using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace TelaLogin.db
{
    class Banco
    {
        // Obj de conexão SQL.
        public SQLiteConnection conexao;

        // Construtor de conexão.
        public Banco()
        {
            // Aponta onde está o arquivo ".sql".
            conexao = new SQLiteConnection("Data Source=C:/Users/renat/AppData/Local/AtividadeSQL-DAO/banco.sqlite3");

            // Definir o caminho
            string caminhoLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string caminho = caminhoLocalAppData + "/AtividadeSQL-DAO";

            // Verificar se o arquivo banco.sqlite3 NÃO existe:
            if (!File.Exists(caminho + "/banco.sqlite3"))
            {
                // Criar a pasta no caminho
                Directory.CreateDirectory(caminho);

                // Criar o arquivo de banco de dados:
                SQLiteConnection.CreateFile(caminho + "/banco.sqlite3");

                // COMANDOS SQL PARA CRIAR A ESTRUTURA PADRÃO DO BANCO:
                // Será executado apenas na primeira vez que o código rodar:
                // Conectar com o banco:
                this.Conectar();
                var cmd = this.conexao.CreateCommand();
                // Comando SQL:
                cmd.CommandText = "CREATE TABLE 'Usuarios' (" +
                "'Nascimento'    TEXT NOT NULL," +
                "'Email' TEXT NOT NULL," +
                "'Senha' TEXT NOT NULL," +
                "'Nome'  TEXT NOT NULL," +
                "PRIMARY KEY('Email'));";

                // Executar o comando:
                cmd.ExecuteNonQuery();
                // Desconectar:
                this.Desconectar();
            }
        }
        
        
        // Classe para conectar.
        public void Conectar()
        {
            // Se conexão não estiver Open irá conectar, caso contrário não irá.
            if (conexao.State != ConnectionState.Open)
            {
                conexao.Open();
            }
        }
        
        
        // Classe para desconectar.
        public void Desconectar()
        {
            // Se conexão estiver Open irá desconectar.
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}

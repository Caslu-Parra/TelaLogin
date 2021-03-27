using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.db
{
    static class UsuarioDAO
    {

        // Validação de login.
        public static DataTable login(Usuario user)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:

            // Definir qual comando DML (Insert - Delete - Update) será executado:
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Email = '" + user.Email + "' and Senha = '" + user.Senha + "'";

            DataTable resultado = new DataTable();
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            da.Fill(resultado);
            // Desconectar:
            banco.Desconectar();
            return resultado;
        }

        // Cadastra um novo usuário.
        public static bool cadastrar(Usuario user)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            try
            {
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO Usuarios (Nome, Email, Nascimento, Senha) values" +
                    "(@nome, @email, @data, @senha)";

                cmd.Parameters.AddWithValue("@nome", user.Nome);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@data", user.Data);
                cmd.Parameters.AddWithValue("@senha", user.Senha);
                // Executar:
                cmd.ExecuteNonQuery();

                // Desconectar
                banco.Desconectar();
                return true;
            }
            catch
            {
                banco.Desconectar();
                return false;
            }
        }

        // Retorna toda a tabela 'Usuarios' sempre que invocado.
        public static DataTable listar()
        {
            // Instanciando a classe de conexão ao bando de dados.
            db.Banco banco = new db.Banco();

            // Cria uma tabela.
            DataTable tabela = new DataTable();

            // Conecta do Banco.
            banco.Conectar();

            // Variável de comandos SQL.
            var cmd = banco.conexao.CreateCommand();
            // Comando SQL à ser exectado.
            cmd.CommandText = "SELECT * FROM Usuarios";
            // Executar e obter dadoas de uma consulta.
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Preencher uma "tabela" com o resultado da consulta no banco armazenado em "da".
            da.Fill(tabela);
            // Desconecta do Banco.
            banco.Desconectar();
            return tabela;
        }

        // Busca um usuário especifico no bd com PK.
        public static DataTable buscarUsuario(string id)
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Email = '" + id + "'";
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            banco.Desconectar();
            return tabela;
        }

        // Exclui um usuário
        public static bool excluir(string email)
        {
            // Instanciar e conectar ao banco:
            db.Banco banco = new db.Banco();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            try
            {
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "DELETE FROM Usuarios WHERE Email = @email;";

                cmd.Parameters.AddWithValue("@email", email);
                // Executar:
                cmd.ExecuteNonQuery();

                // Desconectar
                banco.Desconectar();
                return true;
            }
            catch
            {
                banco.Desconectar();
                return false;
            }
        }

        public static bool editar(Usuario user)
        {
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "UPDATE Usuarios SET Nome='" + user.Nome + "'," +
                    " Email='" + user.Email+ "'," +
                    " Senha= '" + user.Senha + "'," +
                    " Nascimento= '" + user.Data + "'" +
                    " WHERE Email= '" + user.Email + "';";
                
                // Definir a substituição dos parametros:
                cmd.ExecuteNonQuery();

            // Executar:
            // Desconectar
            banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
               return false;
            }
        }
    }


}


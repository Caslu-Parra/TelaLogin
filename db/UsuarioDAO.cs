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

        // Static Class UsuarioDAO;
        public static DataTable login(Usuario user)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:

            // Definir qual comando DML (Insert - Delete - Update) será executado:
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Email = '"+ user.Email+"' and Senha = '"+ user.Senha +"'";

            DataTable resultado = new DataTable();
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            da.Fill(resultado);
            // Desconectar:
            banco.Desconectar();
            return resultado;
        }

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
    }
}

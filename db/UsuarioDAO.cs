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
        public static bool login(Usuario user) {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:

            try
            {
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "SELECT * FROM Usuarios WHERE Email = '@email' AND Senha = '@senha'";

                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@senha", user.Senha);
                // Executar:
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            // Desconectar:

            banco.Desconectar();

        }
    }
}

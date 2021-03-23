using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.db
{
    class UsuarioDAO
    {
        public bool login(string email,string senha) {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            // Instanciar e conectar ao banco:
            
            Banco banco = new Banco();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM Funcionarios WHERE id = " + id;
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            // Desconectar:
            banco.Desconectar();
            return true;
        }
    }
}

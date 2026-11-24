using System;
using System.Data.OleDb;
using System.IO;

namespace Cadastro_de_Alunos___LTP_BD
{
    public class Conexao
    {
        private static string caminho = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "CadastroAlunos.accdb"
        );

        private static string conexao =
            $@"Provider=Microsoft.ACE.OLEDB.12.0;
               Data Source={caminho};
               Persist Security Info=False;";

        public static OleDbConnection Conectar()
        {
            return new OleDbConnection(conexao);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Automoveis_Forms.Class
{
    public class ClassConexao
    {
        public static SqlConnection Conexao;
        public static SqlCommand Comando;
        public static SqlDataAdapter Adapter;
        public static DataTable Table;

        public static string StrConexao, StrComando;

        public static void Conectando()
        {
            StrComando = "Server=DESKTOP-FOBFM43\\SQLEXPRESS;Database=Automoveis;User Id=usuario;Password=123456;";
            Conexao = new SqlConnection(StrComando);
            Conexao.Open();
        }

        public static void Modificando()
        {
            Comando = new SqlCommand(StrConexao, Conexao);
            Comando.ExecuteReader();
            Conexao.Close();
        }

        public static void Verificando()
        {
            Adapter = new SqlDataAdapter(StrConexao, Conexao);
            Table = new DataTable();
            Adapter.Fill(Table);
            Conexao.Close();
        }
    }
}

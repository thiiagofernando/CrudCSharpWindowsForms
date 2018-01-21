using System.Configuration;
using System.Data.SqlClient;
using CadCliente.Negocios;

namespace CadCliente.Persistencia
{
    class ClienteDados
    {
        private static string stringConexao =
            ConfigurationManager.ConnectionStrings["ConexaoBDLoja"].ConnectionString;

        public static void Incluir(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string commando = "INSERT INTO [dbo].[Cliente]" +
                              "([CPF],[Nome],[Telefone])" +
                              " Values('" + cliente.CPF.ToString() + "','" + cliente.Nome.ToString() + "','" +
                              cliente.Telefone.ToString() + "')";
            conexao.Open();
            SqlCommand sql = new SqlCommand(commando,conexao);
            sql.ExecuteNonQuery();
            conexao.Close();
        }

        public static void Alterar(Cliente cliente,string cpf)
        {
            SqlConnection conexao=
                new SqlConnection(stringConexao);
            string commando = "UPDATE [dbo].[Cliente] Set" +
                              " CPF='" + cliente.CPF + "'," +
                              "Nome='" + cliente.Nome + "',"+
                              "Telefone='"+cliente.Telefone+"'"+
                              "Where CPF='"+cpf+"'";
            conexao.Open();
            SqlCommand sql = new SqlCommand(commando,conexao);
            sql.ExecuteNonQuery();
            conexao.Close();

        }

        public static void Excluir(string cliente)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            string commando = "DELETE FROM [dbo].[Cliente] " +
                              "WHERE CPF='" + cliente + "'";
            conexao.Open();
            SqlCommand sql = new SqlCommand(commando,conexao);
            sql.ExecuteNonQuery();
            conexao.Close();
        }

        public static Cliente Pesquisar(string cpf)
        {
            Cliente cliente= new Cliente();
            SqlConnection conexao = new SqlConnection(stringConexao);
            string commando = @"SELECT [CPF],[Nome],[Telefone]
                              FROM [Loja].[dbo].[Cliente]
                               Where CPF = '" + cpf + "'";
            SqlCommand sql = new SqlCommand(commando,conexao);
            conexao.Open();
            SqlDataReader rs = sql.ExecuteReader();
            rs.Read();
            if (rs.HasRows)
            {
                cliente.CPF = rs.GetString(0);
                cliente.Nome = rs.GetString(1);
                cliente.Telefone = rs.GetString(2);
            }
            rs.Close();
            conexao.Close();
            return (cliente);
        }
    }
}

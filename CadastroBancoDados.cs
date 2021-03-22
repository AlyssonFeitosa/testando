using MySqlConnector;
using deliveryfast.Models;
namespace deliveryfast.Models
{
    public class CadastroBancoDados
    {
        private const string dadosConexao = "Database = paodeliveryfast; Data Source = localhost; User Id = root; Password = ";

        public void Insert(Cadastro novoCadastro)
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Conexao.Open();
            string query = "insert into Cadastro(Nome, Endereco, Telefone, tipopao, Quantidade) values(@Nome, @Endereco, @Telefone, @tipopao, @Quantidade)";
            
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.AddWithValue("@Nome", novoCadastro.Nome);
            comando.Parameters.AddWithValue("@Endereco", novoCadastro.Endereco);
            comando.Parameters.AddWithValue("@Telefone", novoCadastro.Telefone);
            comando.Parameters.AddWithValue("@tipopao", novoCadastro.tipopao);
            comando.Parameters.AddWithValue("@Quantidade", novoCadastro.Quantidade);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
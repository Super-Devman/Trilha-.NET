using System.Data.SqlClient;

namespace ModelagemEstrelaDaMorte.Dao
{
    public abstract class DaoBase : IDisposable
    {
        protected readonly SqlConnection conn;

        protected DaoBase()
        {
            // Instância da classe SqlConnection que recebe a string de conexão
            conn = new SqlConnection(@"Data Source=LAPTOP-094KOGAJ;Initial Catalog=EstrelaDaMorte;Integrated Security=True;Connect Timeout=30");
        }

        protected async Task Insert(string comando)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            await cmd.ExecuteNonQueryAsync();
            conn.Close();
        }

        protected async Task Select(string comando, Action<SqlDataReader> tratamentoLeitura)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(comando, conn);
            SqlDataReader dr = await cmd.ExecuteReaderAsync();
            tratamentoLeitura(dr);
            conn.Close();

        }

        public void Dispose()
        {
            conn?.Close();
            conn?.Dispose();
        }
    }
}

using System.Data.SqlClient;

namespace ModelagemEstrelaDaMorte.Extensions
{
    public static class ValorExtension
    {
        public static T ObterValorOuPadrao<T>(this SqlDataReader reader, string campo)
        {
            try
            {
                return (T)reader[campo];
            }
            catch
            {

                return default(T);
            }
        }
    }
}

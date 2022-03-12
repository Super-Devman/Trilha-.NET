using ModelagemEstrelaDaMorte.Entities;
using ModelagemEstrelaDaMorte.Extensions;

namespace ModelagemEstrelaDaMorte.Dao
{
    public class DaoNave : DaoBase
    {
        public async Task InserirNaves(List<Nave> naves)
        {
            if (!naves.Any())
                return;

            var check = "if (not exists(select 1 from Naves where IdNave = {0}))\n";
            var insert = "insert Naves (IdNave, Nome, Modelo, Passageiros, Carga, Classe) values ({0}, '{1}', {2}, {3}, {4}, '{5}');\n";
            var comandosSQL = naves.Select(nave => string.Format(check, nave.IdNave) + string.Format(insert, nave.IdNave, nave.Nome, nave.Modelo, nave.Passageiros, nave.Carga, nave.Classe));

            await Insert(string.Join('\n', comandosSQL));
        }

        public async Task<List<Nave>> ObterNome(string nome)
        {
            var naves = new List<Nave>();
            var comandoSQL = $"select * from Naves where nome like '%{nome.Replace(' ', '%')}%'";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    naves.Add(new Nave
                    {
                        IdNave = resultadoSQL.ObterValorOuPadrao<int>("IdNave"),
                        Nome = resultadoSQL.ObterValorOuPadrao<string>("Nome")
                    });
                }
            });
            return naves;
        }

        public async Task<Nave> ObterPorId(int idNave)
        {
            Nave nave = null;
            var comandoSQL = $@"
                            select t1.*
                            from Naves t1
                            where t1.IdNave = {idNave}";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    nave = new Nave
                    {
                        IdNave = resultadoSQL.ObterValorOuPadrao<int>("IdNave"),
                        Nome = resultadoSQL.ObterValorOuPadrao<string>("Nome"),
                        Modelo = resultadoSQL.ObterValorOuPadrao<string>("Modelo"),
                        Passageiros = resultadoSQL.ObterValorOuPadrao<int>("Passageiros"),
                        Carga = resultadoSQL.ObterValorOuPadrao<double>("Carga"),
                        Classe = resultadoSQL.ObterValorOuPadrao<string>("Classe"),
                    };
                }
            });

            return nave;
        }

        public async Task<int?> ObterPiloto(int idNave)
        {
            int? idPiloto = null;
            var comandoSQL = $"select IdPiloto from HistoricoViagens t1 where t1.IdNave = {idNave} and t1.DtChegada is null";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    idPiloto = resultadoSQL.ObterValorOuPadrao<int>("IdPiloto");
                }
            });

            return idPiloto;
        }
    }
}

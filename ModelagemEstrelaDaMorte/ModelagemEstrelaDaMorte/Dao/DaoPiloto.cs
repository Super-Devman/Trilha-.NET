using ModelagemEstrelaDaMorte.Entities;
using ModelagemEstrelaDaMorte.Extensions;
using System.Text;

namespace ModelagemEstrelaDaMorte.Dao
{
    public class DaoPiloto : DaoBase
    {
        public async Task InserirPilotos(List<Piloto> pilotos)
        {
            if (!pilotos.Any())
                return;

            var check = "if (not exists(select 1 from Pilotos where IdPiloto = {0}))\n";
            var insert = "insert Pilotos (IdPiloto, Nome, AnoNascimento, IdPlaneta) values ({0}, '{1}', '{2}', {3});\n";
            var comandos = pilotos.Select(piloto => string.Format(check, piloto.IdPiloto) + string.Format(insert, piloto.IdPiloto, piloto.Nome, piloto.AnoNascimento, piloto.IdPlaneta));

            await Insert(string.Join('\n', comandos));
        }

        public async Task RegistrarInicioViagem(int idPiloto, int idNave)
        {
            StringBuilder comandoSQL = new StringBuilder();
            comandoSQL.AppendLine($"if (not exists(select 1 from HistoricoViagens where IdPiloto = {idPiloto} and DtChegada is null");
            comandoSQL.AppendLine($"begin");
            comandoSQL.AppendLine($"   insert HistoricoViagens (IdNave, IdPiloto, DtSaida) Values({idNave}, {idPiloto}, GetDate());");
            comandoSQL.AppendLine($"end");

            await Insert(string.Join('\n', comandoSQL.ToString()));
        }

        public async Task RegistrarFimViagem(int idPiloto, int idNave)
        {
            StringBuilder comandoSQL = new StringBuilder();
            comandoSQL.AppendLine($"update HistoricoViagens set DtChegada = GetDate() where IdPiloto = {idPiloto} and IdNave = {idNave} and DtChegada is null");

            await Insert(string.Join('\n', comandoSQL.ToString()));
        }

        public async Task InserirNavesDosPilotos(List<Piloto> pilotos)
        {
            if (!pilotos.Any())
                return;

            var check = "if (not exists(select 1 from PilotosNaves where IdPiloto = {0} and IdNave = {1}))\n";
            var insert = "insert PilotosNaves(IdPiloto, IdNave) values({0}, {1});\n";
            var comandosSQL = pilotos.SelectMany(piloto => piloto.Naves.Select(nave => string.Format(check, piloto.IdPiloto, nave.IdNave) + string.Format(insert, piloto.IdPiloto, nave.IdNave)));

            await Insert(string.Join('\n', comandosSQL));
        }

        public async Task<bool> PilotoViajando(int idPiloto)
        {
            bool viajando = false;

            var comandoSQL = $"select convert(bit, case when count(DtSaida) <> count(DtChegada) then 1 else 0 end) Viajando from HistoricoViagens where IdPiloto = {idPiloto}";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    viajando = resultadoSQL.ObterValorOuPadrao<bool>("Viajando");
                }
            });

            return viajando;
        }

        public async Task<List<Piloto>> ObterNome(string nome)
        {
            var pilotos = new List<Piloto>();
            var comandoSQL = $"select * from Pilotos where nome like '%{nome.Replace(' ', '%')}%'";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    pilotos.Add(new Piloto
                    {
                        IdPiloto = resultadoSQL.ObterValorOuPadrao<int>("IdPiloto"),
                        Nome = resultadoSQL.ObterValorOuPadrao<string>("Nome")
                    });
                }
            });
            return pilotos;
        }

        public async Task<Piloto> ObterPorId(int idPiloto)
        {
            Piloto piloto = null;
            var comandoSQL = $@"
                            select p1.IdPiloto,
                                   p1.Nome,
                                   p1.AnoNascimento,
                                   p2.IdPlaneta,
                                   p2.Nome NomePlaneta
                                   p2.Orbita,
                                   p2.Diametro,
                                   p2.Clima,
                                   p2.Populacao
                            from Pilotos p1
                            inner join Planetas p2
                            on p1.IdPlaneta = p2.IdPlaneta
                            where IdPiloto = {idPiloto}";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    piloto = new Piloto
                    {
                        IdPiloto = resultadoSQL.ObterValorOuPadrao<int>("IdPiloto"),
                        Nome = resultadoSQL.ObterValorOuPadrao<string>("Nome"),
                        AnoNascimento = resultadoSQL.ObterValorOuPadrao<string>("AnoNascimento"),
                        IdPlaneta = resultadoSQL.ObterValorOuPadrao<int>("IdPlaneta"),
                        Planeta = new Planeta
                        {
                            IdPlaneta = resultadoSQL.ObterValorOuPadrao<int>("IdPlaneta"),
                            Nome = resultadoSQL.ObterValorOuPadrao<string>("NomePlaneta"),
                            Rotacao = resultadoSQL.ObterValorOuPadrao<double>("Rotacao"),
                            Orbita = resultadoSQL.ObterValorOuPadrao<double>("Orbita"),
                            Diametro = resultadoSQL.ObterValorOuPadrao<double>("Diametro"),
                            Clima = resultadoSQL.ObterValorOuPadrao<string>("Clima"),
                            Populacao = resultadoSQL.ObterValorOuPadrao<int>("Populacao")
                        }
                    };
                }
            });

            piloto.Naves = new List<Nave>();
            comandoSQL = @$"
                                select n.*
                                from PilotosNaves p
                                inner join Naves n
                                on p.IdNave = n.IdNave
                                where p.FlagAutorizado = 1
                                and p.IdPiloto = {idPiloto}";

            await Select(comandoSQL, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    piloto.Naves.Add(new Nave
                    {
                        IdNave = resultadoSQL.ObterValorOuPadrao<int>("IdNave"),
                        Nome = resultadoSQL.ObterValorOuPadrao<string>("Nome"),
                        Modelo = resultadoSQL.ObterValorOuPadrao<string>("Modelo"),
                        Passageiros = resultadoSQL.ObterValorOuPadrao<int>("Passageiros"),
                        Carga = resultadoSQL.ObterValorOuPadrao<double>("Carga"),
                        Classe = resultadoSQL.ObterValorOuPadrao<string>("Classe")
                    });
                }
            });

            return piloto;
        }
    }
}

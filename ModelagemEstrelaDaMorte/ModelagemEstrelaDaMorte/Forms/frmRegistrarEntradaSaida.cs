using ModelagemEstrelaDaMorte.Dao;
using ModelagemEstrelaDaMorte.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelagemEstrelaDaMorte.Forms
{
    public partial class frmRegistrarEntradaSaida : Form
    {
        private Piloto _piloto;
        private Piloto _pilotoComandante;
        private Nave _nave;
        private int _idNave;
        private int _idPiloto;
        private bool _chegada;
        private bool _pilotoViajando;

        public frmRegistrarEntradaSaida(int idNave, int idPiloto, bool chegada)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _idNave = idNave;
            _idPiloto = idPiloto;
            _chegada = chegada;
            InitializeComponent();
        }

        private async void frmRegistrarEntradaSaida_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? idPilotoComandante;
            using (var daoNave = new DaoNave())
            {
                _nave = await daoNave.ObterPorId(_idNave);
                idPilotoComandante = await daoNave.ObterPiloto(_idNave);
            }

            using (var daoPiloto = new DaoPiloto())
            {
                _piloto = await daoPiloto.ObterPorId(_idPiloto);
                _pilotoViajando = await daoPiloto.PilotoViajando(_idPiloto);

                if (idPilotoComandante.HasValue)
                    _pilotoComandante = await daoPiloto.ObterPorId(idPilotoComandante.Value);
            }

            lvAlertas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            PreencherDadosNave();
        }

        private void PreencherDadosNave()
        {
            lblNomeNave.Text = _nave.Nome;
            lblModelo.Text = _nave.Modelo;
            lblClasse.Text = _nave.Classe;
        }

        private void PreencherDadosPiloto()
        {
            lblNomePiloto.Text = _piloto.Nome;
            lblAnoNascimento.Text = _piloto.AnoNascimento;
            lblPlaneta.Text = _piloto.Planeta.Nome;
        }

        private bool Valido()
        {
            bool valido = PilotoValido();
            valido = NaveValida() && valido;

            return valido;
        }

        private bool PilotoValido()
        {
            bool valido = true;

            // Saindo
            if (!_chegada)
            {
                if (_pilotoViajando)
                {
                    valido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - PILOTO AINDA NÃO CHEGOU DE VIAGEM, DEVE SER UM IMPOSTOR"));
                }

                if (!_piloto.Naves.Any(nave => nave.IdNave == _nave.IdNave))
                {
                    valido = false;
                    lvAlertas.Items.Add(new ListViewItem("Este piloto não está habilitado para esta nave"));
                }

                // Chegando
                if (_chegada && !_pilotoViajando)
                {
                    valido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - PILOTO AINDA NÃO CHEGOU DE VIAGEM, DEVE SER UM IMPOSTOR"));
                }
            }

            return valido;
        }

        private bool NaveValida()
        {
            bool valido = true;

            // Saindo
            if (!_chegada && _pilotoComandante != null)
            {
                valido = false;
                lvAlertas.Items.Add(new ListViewItem("Nave já está em viagem"));
            }

            // Chegando
            if (_chegada)
            {
                if (_pilotoComandante == null)
                {
                    valido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - NAVE NÃO SAIU, PODE SER UMA NAVE IMPOSTORA"));
                }

                if (_pilotoComandante != null && _pilotoComandante.IdPiloto != _piloto.IdPiloto)
                {
                    valido = false;
                    lvAlertas.Items.Add(new ListViewItem($"PERIGO - PILOTO QUE RETIROU A NAVE FOI '{_pilotoComandante.Nome.ToUpper()}'"));
                }
            }

            return valido;
        }

        private void frmRegistrarEntradaSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_chegada)
                await RegistrarEntrada();
            else
                await RegistrarSaida();
        }

        private async Task RegistrarEntrada()
        {
            using (var daoPiloto = new DaoPiloto())
                await daoPiloto.RegistrarFimViagem(_idPiloto, _idNave);
        }

        private async Task RegistrarSaida()
        {
            using (var daoPilogo = new DaoPiloto())
                await daoPilogo.RegistrarInicioViagem(_idPiloto, _idNave);
        }

    }

}

using ModelagemEstrelaDaMorte.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelagemEstrelaDaMorte.Extensions;

namespace ModelagemEstrelaDaMorte.Forms
{
    public partial class frmControleNaves : Form
    {
        private readonly DaoPiloto _daoPiloto;
        private readonly DaoNave _daoNave;

        public frmControleNaves()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _daoPiloto = new DaoPiloto();
            _daoNave = new DaoNave();
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (!rbChegando.Checked && !rbSaindo.Checked)
            {
                MessageBox.Show("É preciso informar se a nave está chegando ou saindo da Estrela da Morte!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvNaves.Rows.Count == 0 || dgvNaves.Rows.ObterQuantidadeLinhasVerificadas(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas um piloto da nave!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idPiloto = int.Parse(dgvPilotos.Rows[dgvPilotos.Rows.ObterPrimeiroIndiceVerificado(1)].Cells[0].Value.ToString());
            var idNave = int.Parse(dgvNaves.Rows[dgvNaves.Rows.ObterPrimeiroIndiceVerificado(1)].Cells[0].Value.ToString());
            // var frm = new frmRegistrarEntradaSaida(idNave, idPiloto, rbChegando.Checked);
        }

        private void frmControleNaves_FormClosing(object sender, FormClosingEventArgs e)
        {
            _daoNave?.Dispose();
            _daoPiloto?.Dispose();
            Dispose();
        }

        private async void btnBuscarNave_Click(object sender, EventArgs e)
        {
            dgvNaves.Rows.Clear();
            dgvNaves.Columns.Clear();

            if (string.IsNullOrEmpty(txtNomeNave.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idNaveColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nomeNaveColumn = new DataGridViewTextBoxColumn();

            idNaveColumn.Visible = false;

            idNaveColumn.ReadOnly = true;
            checkBoxColumn.ReadOnly = false;
            nomeNaveColumn.ReadOnly = true;

            nomeNaveColumn.Width = 500;

            dgvNaves.RowHeadersVisible = false;
            dgvNaves.ColumnHeadersVisible = false;
            dgvNaves.Columns.Add(idNaveColumn);
            dgvNaves.Columns.Add(checkBoxColumn);
            dgvNaves.Columns.Add(nomeNaveColumn);

            var naves = await _daoNave.ObterNome(txtNomeNave.Text);
            foreach (var nave in naves)
            {
                dgvNaves.Rows.Add(nave.IdNave, false, nave.Nome);

                /* Força o controle a aplicar uma lógica de layout a 
                 * todos os seus controles filho */
                dgvNaves.PerformLayout();
                /* Cursors - Fornece uma coleção de objetos Cursor 
                   para ser usado por um Windows Form Application */
                Cursor = Cursors.Default;
            }
        }

        private async void btnBuscarPiloto_Click(object sender, EventArgs e)
        {
            dgvPilotos.Rows.Clear();
            dgvPilotos.Columns.Clear();

            if (string.IsNullOrEmpty(txtNomePiloto.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idPilotoColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkPilotoColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nomePilotoColumn = new DataGridViewTextBoxColumn();

            idPilotoColumn.Visible = false;

            idPilotoColumn.ReadOnly = true;
            checkPilotoColumn.ReadOnly = false;
            nomePilotoColumn.ReadOnly = true;

            nomePilotoColumn.Width = 500;

            dgvPilotos.RowHeadersVisible = false;
            dgvPilotos.ColumnHeadersVisible = false;
            dgvPilotos.Columns.Add(idPilotoColumn);
            dgvPilotos.Columns.Add(checkPilotoColumn);
            dgvPilotos.Columns.Add(nomePilotoColumn);

            var pilotos = await _daoPiloto.ObterNome(txtNomePiloto.Text);
            foreach (var piloto in pilotos)
            {
                dgvPilotos.Rows.Add(piloto.IdPiloto, false, piloto.Nome);

                dgvNaves.PerformLayout();
                Cursor = Cursors.Default;
            }

        }
    }
}

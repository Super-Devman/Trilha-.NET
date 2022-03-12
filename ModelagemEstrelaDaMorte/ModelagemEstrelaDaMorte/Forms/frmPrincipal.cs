using ModelagemEstrelaDaMorte.Services;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            var sincronizador = new SincronizadorServico();

            Cursor = Cursors.WaitCursor;
            await sincronizador.Sincronizar();
            Cursor = Cursors.Default;

            MessageBox.Show("Sincronização finalizada com sucesso", "Sincronização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            var frmControle = new frmControleNaves();
            frmControle.ShowDialog();
        }
    }
}

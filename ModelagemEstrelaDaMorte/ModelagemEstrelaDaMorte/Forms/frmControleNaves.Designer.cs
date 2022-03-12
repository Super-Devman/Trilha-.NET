namespace ModelagemEstrelaDaMorte.Forms
{
    partial class frmControleNaves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNave = new System.Windows.Forms.Label();
            this.txtNomeNave = new System.Windows.Forms.TextBox();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.dgvNaves = new System.Windows.Forms.DataGridView();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.txtNomePiloto = new System.Windows.Forms.TextBox();
            this.btnBuscarPiloto = new System.Windows.Forms.Button();
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            this.rbChegando = new System.Windows.Forms.RadioButton();
            this.rbSaindo = new System.Windows.Forms.RadioButton();
            this.btnAvancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNave
            // 
            this.lblNave.AutoSize = true;
            this.lblNave.Location = new System.Drawing.Point(12, 22);
            this.lblNave.Name = "lblNave";
            this.lblNave.Size = new System.Drawing.Size(37, 15);
            this.lblNave.TabIndex = 0;
            this.lblNave.Text = "Nave:";
            // 
            // txtNomeNave
            // 
            this.txtNomeNave.Location = new System.Drawing.Point(55, 19);
            this.txtNomeNave.Name = "txtNomeNave";
            this.txtNomeNave.Size = new System.Drawing.Size(629, 23);
            this.txtNomeNave.TabIndex = 1;
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.Location = new System.Drawing.Point(690, 18);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNave.TabIndex = 2;
            this.btnBuscarNave.Text = "Buscar";
            this.btnBuscarNave.UseVisualStyleBackColor = true;
            this.btnBuscarNave.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // dgvNaves
            // 
            this.dgvNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaves.Location = new System.Drawing.Point(55, 48);
            this.dgvNaves.Name = "dgvNaves";
            this.dgvNaves.RowTemplate.Height = 25;
            this.dgvNaves.Size = new System.Drawing.Size(710, 159);
            this.dgvNaves.TabIndex = 3;
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.Location = new System.Drawing.Point(8, 229);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(41, 15);
            this.lblPiloto.TabIndex = 4;
            this.lblPiloto.Text = "Piloto:";
            // 
            // txtNomePiloto
            // 
            this.txtNomePiloto.Location = new System.Drawing.Point(55, 226);
            this.txtNomePiloto.Name = "txtNomePiloto";
            this.txtNomePiloto.Size = new System.Drawing.Size(629, 23);
            this.txtNomePiloto.TabIndex = 5;
            // 
            // btnBuscarPiloto
            // 
            this.btnBuscarPiloto.Location = new System.Drawing.Point(690, 226);
            this.btnBuscarPiloto.Name = "btnBuscarPiloto";
            this.btnBuscarPiloto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPiloto.TabIndex = 6;
            this.btnBuscarPiloto.Text = "Buscar";
            this.btnBuscarPiloto.UseVisualStyleBackColor = true;
            this.btnBuscarPiloto.Click += new System.EventHandler(this.btnBuscarPiloto_Click);
            // 
            // dgvPilotos
            // 
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilotos.Location = new System.Drawing.Point(55, 255);
            this.dgvPilotos.Name = "dgvPilotos";
            this.dgvPilotos.RowTemplate.Height = 25;
            this.dgvPilotos.Size = new System.Drawing.Size(710, 159);
            this.dgvPilotos.TabIndex = 7;
            // 
            // rbChegando
            // 
            this.rbChegando.AutoSize = true;
            this.rbChegando.Location = new System.Drawing.Point(305, 440);
            this.rbChegando.Name = "rbChegando";
            this.rbChegando.Size = new System.Drawing.Size(80, 19);
            this.rbChegando.TabIndex = 8;
            this.rbChegando.TabStop = true;
            this.rbChegando.Text = "Chegando";
            this.rbChegando.UseVisualStyleBackColor = true;
            // 
            // rbSaindo
            // 
            this.rbSaindo.AutoSize = true;
            this.rbSaindo.Location = new System.Drawing.Point(424, 440);
            this.rbSaindo.Name = "rbSaindo";
            this.rbSaindo.Size = new System.Drawing.Size(61, 19);
            this.rbSaindo.TabIndex = 9;
            this.rbSaindo.TabStop = true;
            this.rbSaindo.Text = "Saindo";
            this.rbSaindo.UseVisualStyleBackColor = true;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(672, 440);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(93, 30);
            this.btnAvancar.TabIndex = 10;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // frmControleNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.rbSaindo);
            this.Controls.Add(this.rbChegando);
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.btnBuscarPiloto);
            this.Controls.Add(this.txtNomePiloto);
            this.Controls.Add(this.lblPiloto);
            this.Controls.Add(this.dgvNaves);
            this.Controls.Add(this.btnBuscarNave);
            this.Controls.Add(this.txtNomeNave);
            this.Controls.Add(this.lblNave);
            this.Name = "frmControleNaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControleNaves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControleNaves_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNave;
        private TextBox txtNomeNave;
        private Button btnBuscarNave;
        private DataGridView dgvNaves;
        private Label lblPiloto;
        private TextBox txtNomePiloto;
        private Button btnBuscarPiloto;
        private DataGridView dgvPilotos;
        private RadioButton rbChegando;
        private RadioButton rbSaindo;
        private Button btnAvancar;
    }
}
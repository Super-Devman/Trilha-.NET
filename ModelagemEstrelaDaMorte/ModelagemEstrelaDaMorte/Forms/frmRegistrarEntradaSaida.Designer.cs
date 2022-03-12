namespace ModelagemEstrelaDaMorte.Forms
{
    partial class frmRegistrarEntradaSaida
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
            this.gpbNave = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeNave = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gpbPiloto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomePiloto = new System.Windows.Forms.Label();
            this.gpbAlertas = new System.Windows.Forms.GroupBox();
            this.lvAlertas = new System.Windows.Forms.ListView();
            this.chAlertas = new System.Windows.Forms.ColumnHeader();
            this.gpbNave.SuspendLayout();
            this.gpbPiloto.SuspendLayout();
            this.gpbAlertas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNave
            // 
            this.gpbNave.Controls.Add(this.label3);
            this.gpbNave.Controls.Add(this.lblClasse);
            this.gpbNave.Controls.Add(this.label2);
            this.gpbNave.Controls.Add(this.lblModelo);
            this.gpbNave.Controls.Add(this.label1);
            this.gpbNave.Controls.Add(this.lblNomeNave);
            this.gpbNave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbNave.Location = new System.Drawing.Point(12, 69);
            this.gpbNave.Name = "gpbNave";
            this.gpbNave.Size = new System.Drawing.Size(372, 129);
            this.gpbNave.TabIndex = 0;
            this.gpbNave.TabStop = false;
            this.gpbNave.Text = "Nave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "...";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(10, 88);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(50, 19);
            this.lblClasse.TabIndex = 4;
            this.lblClasse.Text = "Classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "...";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(4, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 19);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "...";
            // 
            // lblNomeNave
            // 
            this.lblNomeNave.AutoSize = true;
            this.lblNomeNave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeNave.Location = new System.Drawing.Point(6, 29);
            this.lblNomeNave.Name = "lblNomeNave";
            this.lblNomeNave.Size = new System.Drawing.Size(49, 19);
            this.lblNomeNave.TabIndex = 0;
            this.lblNomeNave.Text = "Nome:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(682, 27);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 27);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gpbPiloto
            // 
            this.gpbPiloto.Controls.Add(this.label6);
            this.gpbPiloto.Controls.Add(this.lblPlaneta);
            this.gpbPiloto.Controls.Add(this.label5);
            this.gpbPiloto.Controls.Add(this.lblAnoNascimento);
            this.gpbPiloto.Controls.Add(this.label4);
            this.gpbPiloto.Controls.Add(this.lblNomePiloto);
            this.gpbPiloto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbPiloto.Location = new System.Drawing.Point(403, 69);
            this.gpbPiloto.Name = "gpbPiloto";
            this.gpbPiloto.Size = new System.Drawing.Size(372, 129);
            this.gpbPiloto.TabIndex = 2;
            this.gpbPiloto.TabStop = false;
            this.gpbPiloto.Text = "Piloto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "...";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(6, 91);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(57, 19);
            this.lblPlaneta.TabIndex = 4;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "...";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(6, 62);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(73, 19);
            this.lblAnoNascimento.TabIndex = 3;
            this.lblAnoNascimento.Text = "Ano Nasc.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "...";
            // 
            // lblNomePiloto
            // 
            this.lblNomePiloto.AutoSize = true;
            this.lblNomePiloto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomePiloto.Location = new System.Drawing.Point(6, 31);
            this.lblNomePiloto.Name = "lblNomePiloto";
            this.lblNomePiloto.Size = new System.Drawing.Size(49, 19);
            this.lblNomePiloto.TabIndex = 1;
            this.lblNomePiloto.Text = "Nome:";
            // 
            // gpbAlertas
            // 
            this.gpbAlertas.Controls.Add(this.lvAlertas);
            this.gpbAlertas.Location = new System.Drawing.Point(12, 253);
            this.gpbAlertas.Name = "gpbAlertas";
            this.gpbAlertas.Size = new System.Drawing.Size(763, 225);
            this.gpbAlertas.TabIndex = 3;
            this.gpbAlertas.TabStop = false;
            this.gpbAlertas.Text = "Alertas";
            // 
            // lvAlertas
            // 
            this.lvAlertas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAlertas});
            this.lvAlertas.Location = new System.Drawing.Point(6, 22);
            this.lvAlertas.Name = "lvAlertas";
            this.lvAlertas.Size = new System.Drawing.Size(751, 197);
            this.lvAlertas.TabIndex = 0;
            this.lvAlertas.UseCompatibleStateImageBehavior = false;
            // 
            // chAlertas
            // 
            this.chAlertas.Name = "chAlertas";
            this.chAlertas.Width = 650;
            // 
            // frmRegistrarEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 490);
            this.Controls.Add(this.gpbAlertas);
            this.Controls.Add(this.gpbPiloto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gpbNave);
            this.Name = "frmRegistrarEntradaSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarEntradaSaida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistrarEntradaSaida_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistrarEntradaSaida_Load);
            this.gpbNave.ResumeLayout(false);
            this.gpbNave.PerformLayout();
            this.gpbPiloto.ResumeLayout(false);
            this.gpbPiloto.PerformLayout();
            this.gpbAlertas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpbNave;
        private Label label2;
        private Label lblModelo;
        private Label label1;
        private Label lblNomeNave;
        private Button btnRegistrar;
        private GroupBox gpbPiloto;
        private Label lblClasse;
        private Label label3;
        private Label label6;
        private Label lblPlaneta;
        private Label label5;
        private Label lblAnoNascimento;
        private Label label4;
        private Label lblNomePiloto;
        private GroupBox gpbAlertas;
        private ListView lvAlertas;
        private ColumnHeader chAlertas;
    }
}
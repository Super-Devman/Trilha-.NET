namespace ModelagemEstrelaDaMorte.Forms
{
    partial class frmPrincipal
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
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Location = new System.Drawing.Point(12, 11);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(105, 41);
            this.btnSincronizar.TabIndex = 0;
            this.btnSincronizar.Text = "Sincronizar";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // btnControle
            // 
            this.btnControle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnControle.Location = new System.Drawing.Point(123, 11);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(105, 40);
            this.btnControle.TabIndex = 1;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 64);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.btnSincronizar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSincronizar;
        private Button btnControle;
    }
}
namespace gestionDashboard.views
{
    partial class frmListePaiements
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPaiements = new System.Windows.Forms.DataGridView();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnCompletePaiment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaiements)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1078, 37);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(38, 38);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtRecherche.Location = new System.Drawing.Point(632, 40);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(438, 31);
            this.txtRecherche.TabIndex = 8;
            this.txtRecherche.Text = "Rechercher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paiements";
            // 
            // dgPaiements
            // 
            this.dgPaiements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgPaiements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaiements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgPaiements.Location = new System.Drawing.Point(40, 235);
            this.dgPaiements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgPaiements.Name = "dgPaiements";
            this.dgPaiements.RowHeadersWidth = 62;
            this.dgPaiements.Size = new System.Drawing.Size(1067, 489);
            this.dgPaiements.TabIndex = 33;
            // 
            // btnImprimer
            // 
            this.btnImprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnImprimer.Image = global::gestionDashboard.Properties.Resources.icons8_payer_24;
            this.btnImprimer.Location = new System.Drawing.Point(40, 134);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(138, 52);
            this.btnImprimer.TabIndex = 41;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnCompletePaiment
            // 
            this.btnCompletePaiment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnCompletePaiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletePaiment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCompletePaiment.Image = global::gestionDashboard.Properties.Resources.icons8_doigt_24;
            this.btnCompletePaiment.Location = new System.Drawing.Point(254, 134);
            this.btnCompletePaiment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompletePaiment.Name = "btnCompletePaiment";
            this.btnCompletePaiment.Size = new System.Drawing.Size(138, 52);
            this.btnCompletePaiment.TabIndex = 42;
            this.btnCompletePaiment.Text = "Complter Paiement";
            this.btnCompletePaiment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCompletePaiment.UseVisualStyleBackColor = true;
            this.btnCompletePaiment.Click += new System.EventHandler(this.btnCompletePaiment_Click);
            // 
            // frmListePaiements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1148, 762);
            this.Controls.Add(this.btnCompletePaiment);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.dgPaiements);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListePaiements";
            this.Text = "frmListePaiements";
            this.Load += new System.EventHandler(this.frmListePaiements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaiements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPaiements;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnCompletePaiment;
    }
}
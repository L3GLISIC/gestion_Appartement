namespace gestionDashboard.views
{
    partial class FrmModifierPaiement
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
            this.btnEnregistrerPaiement = new System.Windows.Forms.Button();
            this.btnSupprimerLocation = new System.Windows.Forms.Button();
            this.cbModePaiement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.duMontantPaiement = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRestant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnregistrerPaiement
            // 
            this.btnEnregistrerPaiement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerPaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerPaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerPaiement.Image = global::gestionDashboard.Properties.Resources.icons8_payer_24;
            this.btnEnregistrerPaiement.Location = new System.Drawing.Point(58, 220);
            this.btnEnregistrerPaiement.Name = "btnEnregistrerPaiement";
            this.btnEnregistrerPaiement.Size = new System.Drawing.Size(92, 34);
            this.btnEnregistrerPaiement.TabIndex = 44;
            this.btnEnregistrerPaiement.Text = "Valider";
            this.btnEnregistrerPaiement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnregistrerPaiement.UseVisualStyleBackColor = true;
            this.btnEnregistrerPaiement.Click += new System.EventHandler(this.btnEnregistrerLocation_Click);
            // 
            // btnSupprimerLocation
            // 
            this.btnSupprimerLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimerLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimerLocation.Image = global::gestionDashboard.Properties.Resources.icons8_annuler_25;
            this.btnSupprimerLocation.Location = new System.Drawing.Point(173, 220);
            this.btnSupprimerLocation.Name = "btnSupprimerLocation";
            this.btnSupprimerLocation.Size = new System.Drawing.Size(92, 34);
            this.btnSupprimerLocation.TabIndex = 45;
            this.btnSupprimerLocation.Text = "Annuler";
            this.btnSupprimerLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimerLocation.UseVisualStyleBackColor = true;
            this.btnSupprimerLocation.Click += new System.EventHandler(this.btnSupprimerLocation_Click);
            // 
            // cbModePaiement
            // 
            this.cbModePaiement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbModePaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModePaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbModePaiement.FormattingEnabled = true;
            this.cbModePaiement.Items.AddRange(new object[] {
            "Selectionner"});
            this.cbModePaiement.Location = new System.Drawing.Point(58, 165);
            this.cbModePaiement.Name = "cbModePaiement";
            this.cbModePaiement.Size = new System.Drawing.Size(207, 21);
            this.cbModePaiement.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(58, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mode Paiement";
            // 
            // duMontantPaiement
            // 
            this.duMontantPaiement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.duMontantPaiement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duMontantPaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.duMontantPaiement.Location = new System.Drawing.Point(58, 116);
            this.duMontantPaiement.Name = "duMontantPaiement";
            this.duMontantPaiement.Size = new System.Drawing.Size(207, 16);
            this.duMontantPaiement.TabIndex = 41;
            this.duMontantPaiement.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(58, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Montant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(58, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Restant :";
            // 
            // lblRestant
            // 
            this.lblRestant.AutoSize = true;
            this.lblRestant.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblRestant.Location = new System.Drawing.Point(131, 51);
            this.lblRestant.Name = "lblRestant";
            this.lblRestant.Size = new System.Drawing.Size(0, 17);
            this.lblRestant.TabIndex = 47;
            // 
            // FrmModifierPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(330, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lblRestant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnregistrerPaiement);
            this.Controls.Add(this.btnSupprimerLocation);
            this.Controls.Add(this.cbModePaiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duMontantPaiement);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModifierPaiement";
            this.Text = "FrmModifierPaiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrerPaiement;
        private System.Windows.Forms.Button btnSupprimerLocation;
        private System.Windows.Forms.ComboBox cbModePaiement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown duMontantPaiement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRestant;
    }
}
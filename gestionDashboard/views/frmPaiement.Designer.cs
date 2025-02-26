﻿namespace gestionDashboard.views
{
    partial class frmPaiement
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
            this.duMontantPaiement = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModePaiement = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerLocation = new System.Windows.Forms.Button();
            this.btnSupprimerLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // duMontantPaiement
            // 
            this.duMontantPaiement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.duMontantPaiement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duMontantPaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.duMontantPaiement.Location = new System.Drawing.Point(37, 57);
            this.duMontantPaiement.Name = "duMontantPaiement";
            this.duMontantPaiement.Size = new System.Drawing.Size(207, 16);
            this.duMontantPaiement.TabIndex = 35;
            this.duMontantPaiement.Text = "0";
            this.duMontantPaiement.SelectedItemChanged += new System.EventHandler(this.duMontantPaiement_SelectedItemChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(37, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Montant";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mode Paiement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbModePaiement
            // 
            this.cbModePaiement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbModePaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbModePaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbModePaiement.FormattingEnabled = true;
            this.cbModePaiement.Items.AddRange(new object[] {
            "Selectionner"});
            this.cbModePaiement.Location = new System.Drawing.Point(37, 106);
            this.cbModePaiement.Name = "cbModePaiement";
            this.cbModePaiement.Size = new System.Drawing.Size(207, 21);
            this.cbModePaiement.TabIndex = 37;
            this.cbModePaiement.SelectedIndexChanged += new System.EventHandler(this.cbModePaiement_SelectedIndexChanged);
            // 
            // btnEnregistrerLocation
            // 
            this.btnEnregistrerLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerLocation.Image = global::gestionDashboard.Properties.Resources.icons8_payer_24;
            this.btnEnregistrerLocation.Location = new System.Drawing.Point(37, 161);
            this.btnEnregistrerLocation.Name = "btnEnregistrerLocation";
            this.btnEnregistrerLocation.Size = new System.Drawing.Size(92, 34);
            this.btnEnregistrerLocation.TabIndex = 38;
            this.btnEnregistrerLocation.Text = "Valider";
            this.btnEnregistrerLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnregistrerLocation.UseVisualStyleBackColor = true;
            this.btnEnregistrerLocation.Click += new System.EventHandler(this.btnEnregistrerLocation_Click);
            // 
            // btnSupprimerLocation
            // 
            this.btnSupprimerLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimerLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimerLocation.Image = global::gestionDashboard.Properties.Resources.icons8_annuler_25;
            this.btnSupprimerLocation.Location = new System.Drawing.Point(152, 161);
            this.btnSupprimerLocation.Name = "btnSupprimerLocation";
            this.btnSupprimerLocation.Size = new System.Drawing.Size(92, 34);
            this.btnSupprimerLocation.TabIndex = 39;
            this.btnSupprimerLocation.Text = "Annuler";
            this.btnSupprimerLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimerLocation.UseVisualStyleBackColor = true;
            this.btnSupprimerLocation.Click += new System.EventHandler(this.btnSupprimerLocation_Click);
            // 
            // frmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(283, 225);
            this.Controls.Add(this.btnEnregistrerLocation);
            this.Controls.Add(this.btnSupprimerLocation);
            this.Controls.Add(this.cbModePaiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duMontantPaiement);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaiement";
            this.Text = "frmPaiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown duMontantPaiement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModePaiement;
        private System.Windows.Forms.Button btnEnregistrerLocation;
        private System.Windows.Forms.Button btnSupprimerLocation;
    }
}
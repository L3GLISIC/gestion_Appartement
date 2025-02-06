namespace gestionDashboard.views
{
    partial class frmLocation
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
            this.dgLocation = new System.Windows.Forms.DataGridView();
            this.cbAppartement = new System.Windows.Forms.ComboBox();
            this.Capacité = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.duMontant = new System.Windows.Forms.DomainUpDown();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.cbLocataire = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnChoisirLocation = new System.Windows.Forms.Button();
            this.btnModifierLocation = new System.Windows.Forms.Button();
            this.btnEnregistrerLocation = new System.Windows.Forms.Button();
            this.btnSupprimerLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(718, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtRecherche.Location = new System.Drawing.Point(420, 29);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(292, 20);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.Text = "Rechercher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Locations";
            // 
            // dgLocation
            // 
            this.dgLocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgLocation.Location = new System.Drawing.Point(263, 116);
            this.dgLocation.Name = "dgLocation";
            this.dgLocation.Size = new System.Drawing.Size(492, 443);
            this.dgLocation.TabIndex = 32;
            // 
            // cbAppartement
            // 
            this.cbAppartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbAppartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAppartement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbAppartement.FormattingEnabled = true;
            this.cbAppartement.Items.AddRange(new object[] {
            "Selectionner"});
            this.cbAppartement.Location = new System.Drawing.Point(23, 377);
            this.cbAppartement.Name = "cbAppartement";
            this.cbAppartement.Size = new System.Drawing.Size(207, 21);
            this.cbAppartement.TabIndex = 6;
            // 
            // Capacité
            // 
            this.Capacité.AutoSize = true;
            this.Capacité.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacité.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Capacité.Location = new System.Drawing.Point(23, 349);
            this.Capacité.Name = "Capacité";
            this.Capacité.Size = new System.Drawing.Size(84, 17);
            this.Capacité.TabIndex = 25;
            this.Capacité.Text = "Appartement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(23, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Statut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date Debut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(23, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Montant";
            // 
            // duMontant
            // 
            this.duMontant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.duMontant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duMontant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.duMontant.Location = new System.Drawing.Point(23, 144);
            this.duMontant.Name = "duMontant";
            this.duMontant.Size = new System.Drawing.Size(207, 16);
            this.duMontant.TabIndex = 33;
            this.duMontant.Text = "0";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(23, 199);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 34;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(23, 258);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(23, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date Fin";
            // 
            // cbStatut
            // 
            this.cbStatut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Selectionner",
            "Disponible",
            "Indisponible"});
            this.cbStatut.Location = new System.Drawing.Point(23, 317);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(207, 21);
            this.cbStatut.TabIndex = 37;
            // 
            // cbLocataire
            // 
            this.cbLocataire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbLocataire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocataire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbLocataire.FormattingEnabled = true;
            this.cbLocataire.Items.AddRange(new object[] {
            "Selectionner"});
            this.cbLocataire.Location = new System.Drawing.Point(23, 437);
            this.cbLocataire.Name = "cbLocataire";
            this.cbLocataire.Size = new System.Drawing.Size(207, 21);
            this.cbLocataire.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(23, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Locataire";
            // 
            // btnPayer
            // 
            this.btnPayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnPayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnPayer.Image = global::gestionDashboard.Properties.Resources.icons8_payer_24;
            this.btnPayer.Location = new System.Drawing.Point(367, 76);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(74, 34);
            this.btnPayer.TabIndex = 40;
            this.btnPayer.Text = "Payer";
            this.btnPayer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPayer.UseVisualStyleBackColor = true;
            this.btnPayer.Click += new System.EventHandler(this.btnPayer_Click);
            // 
            // btnChoisirLocation
            // 
            this.btnChoisirLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btnChoisirLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoisirLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btnChoisirLocation.Image = global::gestionDashboard.Properties.Resources.icons8_doigt_24;
            this.btnChoisirLocation.Location = new System.Drawing.Point(263, 76);
            this.btnChoisirLocation.Name = "btnChoisirLocation";
            this.btnChoisirLocation.Size = new System.Drawing.Size(74, 34);
            this.btnChoisirLocation.TabIndex = 10;
            this.btnChoisirLocation.Text = "Choisir";
            this.btnChoisirLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChoisirLocation.UseVisualStyleBackColor = true;
            this.btnChoisirLocation.Click += new System.EventHandler(this.btnChoisirLocation_Click);
            // 
            // btnModifierLocation
            // 
            this.btnModifierLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(5)))));
            this.btnModifierLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(5)))));
            this.btnModifierLocation.Image = global::gestionDashboard.Properties.Resources.icons8_modifier_24;
            this.btnModifierLocation.Location = new System.Drawing.Point(138, 477);
            this.btnModifierLocation.Name = "btnModifierLocation";
            this.btnModifierLocation.Size = new System.Drawing.Size(92, 34);
            this.btnModifierLocation.TabIndex = 8;
            this.btnModifierLocation.Text = "Modifier";
            this.btnModifierLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModifierLocation.UseVisualStyleBackColor = true;
            this.btnModifierLocation.Click += new System.EventHandler(this.btnModifierLocation_Click);
            // 
            // btnEnregistrerLocation
            // 
            this.btnEnregistrerLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerLocation.Image = global::gestionDashboard.Properties.Resources.icons8_sauvegarder_24;
            this.btnEnregistrerLocation.Location = new System.Drawing.Point(23, 477);
            this.btnEnregistrerLocation.Name = "btnEnregistrerLocation";
            this.btnEnregistrerLocation.Size = new System.Drawing.Size(92, 34);
            this.btnEnregistrerLocation.TabIndex = 7;
            this.btnEnregistrerLocation.Text = "Enregistrer";
            this.btnEnregistrerLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnregistrerLocation.UseVisualStyleBackColor = true;
            this.btnEnregistrerLocation.Click += new System.EventHandler(this.btnEnregistrerLocation_Click);
            // 
            // btnSupprimerLocation
            // 
            this.btnSupprimerLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimerLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimerLocation.Image = global::gestionDashboard.Properties.Resources.icons8_poubelle_24__1_;
            this.btnSupprimerLocation.Location = new System.Drawing.Point(23, 522);
            this.btnSupprimerLocation.Name = "btnSupprimerLocation";
            this.btnSupprimerLocation.Size = new System.Drawing.Size(207, 34);
            this.btnSupprimerLocation.TabIndex = 9;
            this.btnSupprimerLocation.Text = "Supprimer";
            this.btnSupprimerLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimerLocation.UseVisualStyleBackColor = true;
            this.btnSupprimerLocation.Click += new System.EventHandler(this.btnSupprimerLocation_Click);
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.ControlBox = false;
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.cbLocataire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatut);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.duMontant);
            this.Controls.Add(this.btnChoisirLocation);
            this.Controls.Add(this.dgLocation);
            this.Controls.Add(this.btnModifierLocation);
            this.Controls.Add(this.btnEnregistrerLocation);
            this.Controls.Add(this.btnSupprimerLocation);
            this.Controls.Add(this.cbAppartement);
            this.Controls.Add(this.Capacité);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocation";
            this.Text = "frmLocation";
            this.Load += new System.EventHandler(this.frmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoisirLocation;
        private System.Windows.Forms.DataGridView dgLocation;
        private System.Windows.Forms.Button btnModifierLocation;
        private System.Windows.Forms.Button btnEnregistrerLocation;
        private System.Windows.Forms.Button btnSupprimerLocation;
        private System.Windows.Forms.ComboBox cbAppartement;
        private System.Windows.Forms.Label Capacité;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown duMontant;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.ComboBox cbLocataire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPayer;
    }
}
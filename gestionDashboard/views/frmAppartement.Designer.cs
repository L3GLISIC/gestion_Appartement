namespace gestionDashboard.views
{
    partial class frmAppartement
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.rtbAdresse = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Capacité = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProprietaire = new System.Windows.Forms.ComboBox();
            this.dgAppartement = new System.Windows.Forms.DataGridView();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEnregistrerA = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.nudNbrPiece = new System.Windows.Forms.NumericUpDown();
            this.nudCapacite = new System.Windows.Forms.NumericUpDown();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbrPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appartements";
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercher.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtRechercher.Location = new System.Drawing.Point(428, 29);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(292, 20);
            this.txtRechercher.TabIndex = 0;
            this.txtRechercher.Text = "Rechercher";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(726, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(23, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse";
            // 
            // txtSurface
            // 
            this.txtSurface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSurface.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurface.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurface.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSurface.Location = new System.Drawing.Point(23, 249);
            this.txtSurface.Multiline = true;
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(207, 20);
            this.txtSurface.TabIndex = 3;
            // 
            // rtbAdresse
            // 
            this.rtbAdresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.rtbAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rtbAdresse.Location = new System.Drawing.Point(23, 114);
            this.rtbAdresse.Name = "rtbAdresse";
            this.rtbAdresse.Size = new System.Drawing.Size(207, 88);
            this.rtbAdresse.TabIndex = 2;
            this.rtbAdresse.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(23, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surface";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(23, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de Piece";
            // 
            // Capacité
            // 
            this.Capacité.AutoSize = true;
            this.Capacité.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacité.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.Capacité.Location = new System.Drawing.Point(23, 347);
            this.Capacité.Name = "Capacité";
            this.Capacité.Size = new System.Drawing.Size(58, 17);
            this.Capacité.TabIndex = 0;
            this.Capacité.Text = "Capacité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(23, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Propriétaire";
            // 
            // cbProprietaire
            // 
            this.cbProprietaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProprietaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbProprietaire.FormattingEnabled = true;
            this.cbProprietaire.Items.AddRange(new object[] {
            "Selectionner"});
            this.cbProprietaire.Location = new System.Drawing.Point(23, 442);
            this.cbProprietaire.Name = "cbProprietaire";
            this.cbProprietaire.Size = new System.Drawing.Size(207, 21);
            this.cbProprietaire.TabIndex = 6;
            // 
            // dgAppartement
            // 
            this.dgAppartement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgAppartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppartement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgAppartement.Location = new System.Drawing.Point(259, 122);
            this.dgAppartement.Name = "dgAppartement";
            this.dgAppartement.Size = new System.Drawing.Size(492, 443);
            this.dgAppartement.TabIndex = 17;
            // 
            // btnChoisir
            // 
            this.btnChoisir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btnChoisir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoisir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btnChoisir.Image = global::gestionDashboard.Properties.Resources.icons8_doigt_24;
            this.btnChoisir.Location = new System.Drawing.Point(259, 82);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(74, 34);
            this.btnChoisir.TabIndex = 10;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(5)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(176)))), ((int)(((byte)(5)))));
            this.btnModifier.Image = global::gestionDashboard.Properties.Resources.icons8_modifier_24;
            this.btnModifier.Location = new System.Drawing.Point(138, 486);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(92, 34);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnEnregistrerA
            // 
            this.btnEnregistrerA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btnEnregistrerA.Image = global::gestionDashboard.Properties.Resources.icons8_sauvegarder_24;
            this.btnEnregistrerA.Location = new System.Drawing.Point(23, 486);
            this.btnEnregistrerA.Name = "btnEnregistrerA";
            this.btnEnregistrerA.Size = new System.Drawing.Size(92, 34);
            this.btnEnregistrerA.TabIndex = 7;
            this.btnEnregistrerA.Text = "Enregistrer";
            this.btnEnregistrerA.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnregistrerA.UseVisualStyleBackColor = true;
            this.btnEnregistrerA.Click += new System.EventHandler(this.btnEnregistrerA_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSupprimer.Image = global::gestionDashboard.Properties.Resources.icons8_poubelle_24__1_;
            this.btnSupprimer.Location = new System.Drawing.Point(23, 531);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(207, 34);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // nudNbrPiece
            // 
            this.nudNbrPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.nudNbrPiece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudNbrPiece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nudNbrPiece.Location = new System.Drawing.Point(23, 316);
            this.nudNbrPiece.Name = "nudNbrPiece";
            this.nudNbrPiece.Size = new System.Drawing.Size(204, 16);
            this.nudNbrPiece.TabIndex = 4;
            // 
            // nudCapacite
            // 
            this.nudCapacite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.nudCapacite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCapacite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nudCapacite.Location = new System.Drawing.Point(23, 379);
            this.nudCapacite.Name = "nudCapacite";
            this.nudCapacite.Size = new System.Drawing.Size(204, 16);
            this.nudCapacite.TabIndex = 5;
            // 
            // frmAppartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.ControlBox = false;
            this.Controls.Add(this.nudCapacite);
            this.Controls.Add(this.nudNbrPiece);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.dgAppartement);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEnregistrerA);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbProprietaire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Capacité);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbAdresse);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppartement";
            this.Text = "frmAppartement";
            this.Load += new System.EventHandler(this.frmAppartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbrPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.RichTextBox rtbAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Capacité;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProprietaire;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEnregistrerA;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgAppartement;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.NumericUpDown nudNbrPiece;
        private System.Windows.Forms.NumericUpDown nudCapacite;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}
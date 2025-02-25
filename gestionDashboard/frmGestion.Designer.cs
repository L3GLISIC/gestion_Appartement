namespace gestionDashboard
{
    partial class frmGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPaiements = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnLocataire = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnProprietaire = new System.Windows.Forms.Button();
            this.btnAppartement = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInterface = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnPaiements);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnDeconnexion);
            this.panel1.Controls.Add(this.btnLocataire);
            this.panel1.Controls.Add(this.btnLocation);
            this.panel1.Controls.Add(this.btnProprietaire);
            this.panel1.Controls.Add(this.btnAppartement);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::gestionDashboard.Properties.Resources.icons8_paramètres_24;
            this.btnSettings.Location = new System.Drawing.Point(0, 455);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Paramètres";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUsers.Image = global::gestionDashboard.Properties.Resources.icons8_utilisateur_30;
            this.btnUsers.Location = new System.Drawing.Point(0, 413);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(186, 42);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Utilisateurs";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.Leave += new System.EventHandler(this.btnUsers_Leave);
            // 
            // btnPaiements
            // 
            this.btnPaiements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaiements.FlatAppearance.BorderSize = 0;
            this.btnPaiements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaiements.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaiements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPaiements.Image = global::gestionDashboard.Properties.Resources.icons8_payer_24__1_;
            this.btnPaiements.Location = new System.Drawing.Point(0, 371);
            this.btnPaiements.Name = "btnPaiements";
            this.btnPaiements.Size = new System.Drawing.Size(186, 42);
            this.btnPaiements.TabIndex = 3;
            this.btnPaiements.Text = "Paiements";
            this.btnPaiements.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPaiements.UseVisualStyleBackColor = true;
            this.btnPaiements.Click += new System.EventHandler(this.btnPaiements_Click);
            this.btnPaiements.Leave += new System.EventHandler(this.btnPaiements_Leave);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 140);
            this.pnlNav.TabIndex = 2;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDeconnexion.Image = global::gestionDashboard.Properties.Resources.icons8_déconnexion_24;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 535);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(186, 42);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnLocataire
            // 
            this.btnLocataire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocataire.FlatAppearance.BorderSize = 0;
            this.btnLocataire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocataire.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocataire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLocataire.Image = global::gestionDashboard.Properties.Resources.icons8_personne_à_la_maison_30;
            this.btnLocataire.Location = new System.Drawing.Point(0, 329);
            this.btnLocataire.Name = "btnLocataire";
            this.btnLocataire.Size = new System.Drawing.Size(186, 42);
            this.btnLocataire.TabIndex = 1;
            this.btnLocataire.Text = "Locataires";
            this.btnLocataire.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLocataire.UseVisualStyleBackColor = true;
            this.btnLocataire.Click += new System.EventHandler(this.btnLocataire_Click);
            this.btnLocataire.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnLocation
            // 
            this.btnLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocation.FlatAppearance.BorderSize = 0;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLocation.Image = global::gestionDashboard.Properties.Resources.icons8_72_0_74070_accueil_icônes_populaires_24;
            this.btnLocation.Location = new System.Drawing.Point(0, 287);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(186, 42);
            this.btnLocation.TabIndex = 1;
            this.btnLocation.Text = "Location";
            this.btnLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            this.btnLocation.Leave += new System.EventHandler(this.btnLocation_Leave);
            // 
            // btnProprietaire
            // 
            this.btnProprietaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProprietaire.FlatAppearance.BorderSize = 0;
            this.btnProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProprietaire.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProprietaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProprietaire.Image = global::gestionDashboard.Properties.Resources.icons8_propriété_30;
            this.btnProprietaire.Location = new System.Drawing.Point(0, 245);
            this.btnProprietaire.Name = "btnProprietaire";
            this.btnProprietaire.Size = new System.Drawing.Size(186, 42);
            this.btnProprietaire.TabIndex = 1;
            this.btnProprietaire.Text = "Propriétaire";
            this.btnProprietaire.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProprietaire.UseVisualStyleBackColor = true;
            this.btnProprietaire.Click += new System.EventHandler(this.btnProprietaire_Click);
            this.btnProprietaire.Leave += new System.EventHandler(this.btnProprietaire_Leave);
            // 
            // btnAppartement
            // 
            this.btnAppartement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppartement.FlatAppearance.BorderSize = 0;
            this.btnAppartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppartement.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppartement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAppartement.Image = global::gestionDashboard.Properties.Resources.icons8_immeuble_24;
            this.btnAppartement.Location = new System.Drawing.Point(0, 203);
            this.btnAppartement.Name = "btnAppartement";
            this.btnAppartement.Size = new System.Drawing.Size(186, 42);
            this.btnAppartement.TabIndex = 1;
            this.btnAppartement.Text = "Appartements";
            this.btnAppartement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAppartement.UseVisualStyleBackColor = true;
            this.btnAppartement.Click += new System.EventHandler(this.btnAppartement_Click);
            this.btnAppartement.Leave += new System.EventHandler(this.btnAppartement_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = global::gestionDashboard.Properties.Resources.icons8_disposition_du_tableau_de_bord_24;
            this.btnDashboard.Location = new System.Drawing.Point(0, 161);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 161);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some User Text Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(48, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlInterface
            // 
            this.pnlInterface.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInterface.Location = new System.Drawing.Point(186, 0);
            this.pnlInterface.Name = "pnlInterface";
            this.pnlInterface.Size = new System.Drawing.Size(765, 577);
            this.pnlInterface.TabIndex = 1;
            this.pnlInterface.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.ControlBox = false;
            this.Controls.Add(this.pnlInterface);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnLocataire;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnProprietaire;
        private System.Windows.Forms.Button btnAppartement;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlInterface;
        private System.Windows.Forms.Button btnPaiements;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSettings;
    }
}
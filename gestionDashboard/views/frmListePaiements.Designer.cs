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
            ((System.ComponentModel.ISupportInitialize)(this.dgPaiements)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(719, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 25);
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
            this.txtRecherche.Location = new System.Drawing.Point(421, 26);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(292, 20);
            this.txtRecherche.TabIndex = 8;
            this.txtRecherche.Text = "Rechercher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paiements";
            // 
            // dgPaiements
            // 
            this.dgPaiements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgPaiements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaiements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgPaiements.Location = new System.Drawing.Point(27, 67);
            this.dgPaiements.Name = "dgPaiements";
            this.dgPaiements.Size = new System.Drawing.Size(717, 473);
            this.dgPaiements.TabIndex = 33;
            // 
            // frmListePaiements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.dgPaiements);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}
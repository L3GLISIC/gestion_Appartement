using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;

namespace gestionDashboard.views
{
    public partial class frmProprietaire : Form
    {
        public frmProprietaire()
        {
            InitializeComponent();
        }

        BdLocationContext db = new BdLocationContext();

        private void ResetForm()
        {
            txtPrenom.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCNI.Text = string.Empty;
            txtNinea.Text = string.Empty;
            txtRccm.Text = string.Empty;
            var proprietaires = db.proprietaires
                      .Select(p => new
                      {
                          Nom = p.Prenom,
                          Prenom = p.Nom,
                          Email = p.Email,
                          Telephone = p.Telephone,
                          CNI = p.CNI,
                          Ninea = p.Ninea,
                          RCCM = p.Rccm
                      })
                      .ToList();
            dgProprietaire.DataSource = proprietaires;
            txtPrenom.Focus();

        }

        private Boolean check(string prenom, string nom, string email, string telephone, string cni, string ninea, string rccm)
        {

            if (string.IsNullOrWhiteSpace(prenom)) return false;
            if (string.IsNullOrWhiteSpace(nom)) return false;
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@gmail\.com$")) return false;
            if (string.IsNullOrWhiteSpace(telephone) || !Regex.IsMatch(telephone, @"^(77|78|76|75|70)\d{7}$")) return false;
            if (string.IsNullOrWhiteSpace(cni) || cni.Length != 13 || !Regex.IsMatch(cni, @"^\d{13}$")) return false;
            if (string.IsNullOrWhiteSpace(ninea) || !Regex.IsMatch(ninea, @"^\d{9}$")) return false;
            if (string.IsNullOrWhiteSpace(rccm)) return false;

            return true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {

                string prenom = txtPrenom.Text.Trim();
                string nom = txtNom.Text.Trim();
                string email = txtEmail.Text.Trim();
                string telephone = txtTel.Text.Trim();
                string cni = txtCNI.Text.Trim();
                string ninea = txtNinea.Text.Trim();
                string rccm = txtRccm.Text.Trim();

                Boolean verif = check(prenom, nom, email, telephone, cni, ninea, rccm);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                Proprietaire p = new Proprietaire();
                p.Nom = nom;
                p.Prenom = prenom;
                p.Email = email;
                p.Telephone = telephone;
                p.CNI = cni;
                p.Ninea = ninea;
                p.Rccm = rccm;

                db.proprietaires.Add(p);
                db.SaveChanges();
                ResetForm();

                MessageBox.Show("Propriétaire ajouté avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
            }
        }

        private void frmProprietaire_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string prenom = txtPrenom.Text.Trim();
            string nom = txtNom.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telephone = txtTel.Text.Trim();
            string cni = txtCNI.Text.Trim();
            string ninea = txtNinea.Text.Trim();
            string rccm = txtRccm.Text.Trim();

            Boolean verif = check(prenom, nom, email, telephone, cni, ninea, rccm);

            if (!verif)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                return;
            }

            int id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            p.Nom = txtNom.Text;
            p.Prenom = txtPrenom.Text;
            p.Email = txtEmail.Text;
            p.Telephone = txtTel.Text;
            p.CNI = txtCNI.Text;
            p.Ninea = txtNinea.Text;
            p.Rccm = txtRccm.Text;
            db.SaveChanges();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            db.proprietaires.Remove(p);
            db.SaveChanges();
            ResetForm();
        }
    }
}

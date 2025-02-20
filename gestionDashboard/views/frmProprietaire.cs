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
using gestionDashboard.Models;

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
            txtNinea.Text = string.Empty;
            txtRccm.Text = string.Empty;
            var proprietaires = db.proprietaires
                      .Select(p => new
                      {
                          Id = p.IdPersonne,
                          Nom = p.Nom,
                          Prenom = p.Prenom,
                          Email = p.Email,
                          Telephone = p.Telephone,
                          Ninea = p.Ninea,
                          RCCM = p.Rccm
                      })
                      .ToList();
            dgProprietaire.DataSource = proprietaires;
            txtPrenom.Focus();

        }

        private Erreur check(string prenom, string nom, string email, string telephone, string ninea, string rccm)
        {

            if (string.IsNullOrWhiteSpace(prenom)) return new Erreur("Veuillez remplir le prénom", false); ;
            if (string.IsNullOrWhiteSpace(nom)) return new Erreur("Veuillez remplir le nom", false); ;
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@gmail\.com$")) return new Erreur("L'email n'est pas valide", false);
            if (string.IsNullOrWhiteSpace(telephone) || !Regex.IsMatch(telephone, @"^(77|78|76|75|70)\d{7}$")) return new Erreur("Le numéro de téléphone n'est pas valide (77|78|76|75|700000000)", false);
            //if (string.IsNullOrWhiteSpace(cni) || cni.Length != 13 || !Regex.IsMatch(cni, @"^\d{13}$")) return false;
            if (string.IsNullOrWhiteSpace(ninea) || !Regex.IsMatch(ninea, @"^\d{3}$")) return new Erreur("Le ninea doit contenir au moins 3 caracteres", false); ;
            if (string.IsNullOrWhiteSpace(rccm)) return new Erreur("Le rccm ne doit pas etre vide", false); ;

            return new Erreur("Ok", true); ;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {

                string prenom = txtPrenom.Text.Trim();
                string nom = txtNom.Text.Trim();
                string email = txtEmail.Text.Trim();
                string telephone = txtTel.Text.Trim();
                string ninea = txtNinea.Text.Trim();
                string rccm = txtRccm.Text.Trim();

                Erreur verif = check(prenom, nom, email, telephone, ninea, rccm);

                if (!verif.Valeur)
                {
                    MessageBox.Show(verif.Message);
                    return;
                }

                Proprietaire p = new Proprietaire();
                p.Nom = nom;
                p.Prenom = prenom;
                p.Email = email;
                p.Telephone = telephone;
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
            string ninea = txtNinea.Text.Trim();
            string rccm = txtRccm.Text.Trim();

            Erreur verif = check(prenom, nom, email, telephone, ninea, rccm);

            if (!verif.Valeur)
            {
                MessageBox.Show(verif.Message);
                return;
            }

            int id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            p.Nom = txtNom.Text;
            p.Prenom = txtPrenom.Text;
            p.Email = txtEmail.Text;
            p.Telephone = txtTel.Text;
            p.Ninea = txtNinea.Text;
            p.Rccm = txtRccm.Text;
            db.SaveChanges();
            ResetForm();
            MessageBox.Show("Propriétaire modifié avec succès !");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProprietaire.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            db.proprietaires.Remove(p);
            db.SaveChanges();
            ResetForm();
            MessageBox.Show("Propriétaire supprimé avec succès !");
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgProprietaire.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgProprietaire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgProprietaire.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgProprietaire.CurrentRow.Cells[4].Value.ToString();
            txtNinea.Text = dgProprietaire.CurrentRow.Cells[5].Value.ToString();
            txtRccm.Text = dgProprietaire.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmPrintListeProprietaire f = new frmPrintListeProprietaire();
            f.Show();
            this.Enabled = false;
        }

        public void Activer()
        {
            this.Enabled = true;
        }
    }
}

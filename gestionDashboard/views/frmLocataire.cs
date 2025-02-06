using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;

namespace gestionDashboard.views
{
    public partial class frmLocataire : Form
    {
        public frmLocataire()
        {
            InitializeComponent();
        }

        BdLocationContext db = new BdLocationContext();

        private Boolean check(string prenom, string nom, string email, string telephone, string cni)
        {

            if (string.IsNullOrWhiteSpace(prenom)) return false;
            if (string.IsNullOrWhiteSpace(nom)) return false;
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@gmail\.com$")) return false;
            if (string.IsNullOrWhiteSpace(telephone) || !Regex.IsMatch(telephone, @"^(77|78|76|75|70)\d{7}$")) return false;
            if (string.IsNullOrWhiteSpace(cni) || cni.Length != 13 || !Regex.IsMatch(cni, @"^\d{13}$")) return false;
            

            return true;
        }

        private void ResetForm()
        {
            txtPrenom.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCNI.Text = string.Empty;
            var locataires = db.locataires
                      .Select(l => new
                      {
                          Id = l.IdPersonne,
                          Nom = l.Nom,
                          Prenom = l.Prenom,
                          Email = l.Email,
                          Telephone = l.Telephone,
                          Cni = l.CNI,
                      })
                      .ToList();
            dgLocataire.DataSource = locataires;
            txtPrenom.Focus();

        }

        
        

        private void frmLocataire_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        

        

       

        private void btnEnregistrerLocataire_Click(object sender, EventArgs e)
        {
            try
            {
                string prenom = txtPrenom.Text.Trim();
                string nom = txtNom.Text.Trim();
                string email = txtEmail.Text.Trim();
                string telephone = txtTel.Text.Trim();
                string cni = txtCNI.Text.Trim();

                Boolean verif = check(prenom, nom, email, telephone, cni);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                Locataire locataire = new Locataire();
                locataire.Prenom = prenom;
                locataire.Nom = nom;
                locataire.Email = email;
                locataire.Telephone = telephone;
                locataire.CNI = cni;
                locataire.IdLocation = null;

                var validationResults = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(locataire, new ValidationContext(locataire), validationResults, true);
                if (!isValid)
                {
                    string errorMessage = "";
                    foreach (var validationResult in validationResults)
                    {
                        errorMessage += $"Propriété : {validationResult.MemberNames.First()}, Erreur : {validationResult.ErrorMessage}\n";
                    }
                    MessageBox.Show($"Erreur de validation :\n{errorMessage}");
                    return;
                }

                db.locataires.Add(locataire);
                db.SaveChanges();
                ResetForm();
                MessageBox.Show("Locataire ajouté avec succès !");
            }
            catch (DbEntityValidationException ex)
            {
                // Afficher les erreurs de validation détaillées
                string errorMessage = "";
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        errorMessage += $"Propriété : {error.PropertyName}, Erreur : {error.ErrorMessage}\n";
                    }
                }
                MessageBox.Show($"Erreur lors de l'ajout :\n{errorMessage}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
            }
        }

        private void btnSupprimerLocataire_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
            var p = db.locataires.Find(id);
            db.locataires.Remove(p);
            db.SaveChanges();
            ResetForm();
            MessageBox.Show("Locataire supprimé avec succès !");
        }

        private void btnModifierLocataire_Click(object sender, EventArgs e)
        {
            try
            {
                string prenom = txtPrenom.Text.Trim();
                string nom = txtNom.Text.Trim();
                string email = txtEmail.Text.Trim();
                string telephone = txtTel.Text.Trim();
                string cni = txtCNI.Text.Trim();

                Boolean verif = check(prenom, nom, email, telephone, cni);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                int id = int.Parse(dgLocataire.CurrentRow.Cells[0].Value.ToString());
                var l = db.locataires.Find(id);
                l.Nom = txtNom.Text;
                l.Prenom = txtPrenom.Text;
                l.Email = txtEmail.Text;
                l.Telephone = txtTel.Text;
                l.CNI = txtCNI.Text;
                db.SaveChanges();
                ResetForm();
                MessageBox.Show("Locataire modifié avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
            }
        }

        private void btnChoisirLocataire_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgLocataire.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgLocataire.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgLocataire.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgLocataire.CurrentRow.Cells[4].Value.ToString();
            txtCNI.Text = dgLocataire.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

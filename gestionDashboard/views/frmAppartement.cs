using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;

namespace gestionDashboard.views
{
    public partial class frmAppartement : Form
    {
        public frmAppartement()
        {
            InitializeComponent();
        }

        BdLocationContext db = new BdLocationContext();

        private Boolean check(string adresse, float surface, int nbrPiece, int capacite)
        {
            if (string.IsNullOrWhiteSpace(adresse)) return false;
            if (surface <= 0) return false;
            if (nbrPiece <= 0) return false;
            if (capacite <= 0) return false;

            return true;
        }

        private void ResetForm()
        {
            rtbAdresse.Text = string.Empty;
            txtSurface.Text = string.Empty;
            nudNbrPiece.Value = 0;
            nudCapacite.Value = 0;
            cbProprietaire.SelectedIndex = 0;
            var appartement = db.appartements
                      .Select(a => new
                      {
                          adresse = a.AdresseAppartement,
                          surface = a.Surface,
                          nbrPiece = a.NombrePiece,
                          capacite = a.Capacite,
                          proprietaire = a.Proprietaire.Prenom + " " + a.Proprietaire.Nom
                      })
                      .ToList();
            dgAppartement.DataSource = appartement;
            proprietaire_load();
            rtbAdresse.Focus();

        }

        

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                string adresse = rtbAdresse.Text.Trim();
                float surface = float.Parse(txtSurface.Text.Trim());
                int nbrPiece = int.Parse(nudNbrPiece.Text.Trim());
                int capacite = int.Parse(nudCapacite.Text.Trim());
                Proprietaire proprietaire = cbProprietaire.SelectedItem as Proprietaire;

                Boolean verif = check(adresse, surface, nbrPiece, capacite);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                int id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
                var a = db.appartements.Find(id);
                a.AdresseAppartement = adresse;
                a.Surface = surface;
                a.NombrePiece = nbrPiece;
                a.Capacite = capacite;
                a.IdProprietaire = proprietaire.IdPersonne;
                db.SaveChanges();
                ResetForm();
                MessageBox.Show("Appartement modifié avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            rtbAdresse.Text = dgAppartement.CurrentRow.Cells[1].Value.ToString();
            txtSurface.Text = dgAppartement.CurrentRow.Cells[2].Value.ToString();
            nudNbrPiece.Text = dgAppartement.CurrentRow.Cells[3].Value.ToString();
            nudCapacite.Text = dgAppartement.CurrentRow.Cells[4].Value.ToString();
            cbProprietaire.Text = dgAppartement.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var p = db.proprietaires.Find(id);
            db.proprietaires.Remove(p);
            db.SaveChanges();
            ResetForm();
        }

        

        private void proprietaire_load()
        {
            var proprietaires = db.proprietaires
                                  .Select(p => new
                                  {
                                      Id = p.IdPersonne,
                                      FullName = p.Prenom + " " + p.Nom
                                  })
                                  .ToList();

            cbProprietaire.DataSource = proprietaires;
            cbProprietaire.DisplayMember = "FullName";
            cbProprietaire.ValueMember = "Id";
        }

        private void frmAppartement_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnEnregistrerA_Click(object sender, EventArgs e)
        {
            try
            {

                string adresse = rtbAdresse.Text.Trim();
                float surface = float.Parse(txtSurface.Text.Trim());
                int nbrPiece = int.Parse(nudNbrPiece.Text.Trim());
                int capacite = int.Parse(nudCapacite.Text.Trim());
                Proprietaire proprietaire = cbProprietaire.SelectedItem as Proprietaire;

                Boolean verif = check(adresse, surface, nbrPiece, capacite);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                Appartement a = new Appartement();
                a.AdresseAppartement = adresse;
                a.Surface = surface;
                a.NombrePiece = nbrPiece;
                a.Capacite = capacite;
                a.IdProprietaire = (int)cbProprietaire.SelectedValue;




                db.appartements.Add(a);
                db.SaveChanges();
                ResetForm();

                MessageBox.Show("Appartement ajouté avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
            }
        }
    }
}

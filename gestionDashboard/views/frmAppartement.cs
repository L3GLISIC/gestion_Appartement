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
using gestionDashboard.Models;



namespace gestionDashboard.views

{
    
public partial class frmAppartement : Form
    {
        public frmAppartement()
        {
            InitializeComponent();
        }

        BdLocationContext db = new BdLocationContext();



        private Erreur check(string adresse, float surface, int nbrPiece, int capacite)
        {
            if (string.IsNullOrWhiteSpace(adresse)) return new Erreur("l'adresse ne doit pas être nulle.", false );
            if (surface <= 0) return new Erreur("la surface ne doit pas etre inférieure ou égale à 0", false);
            if (nbrPiece <= 0) return new Erreur("le nombre de piece ne doit pas etre inférieure ou égale à 0", false);
            if (capacite <= 0) return new Erreur("la capacité ne doit pas etre inférieure ou égale à 0", false);

            return new Erreur("Ok", true); ;
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
                          id = a.IdAppartement,
                          adresse = a.AdresseAppartement,
                          surface = a.Surface,
                          nbrPiece = a.NombrePiece,
                          capacite = a.Capacite,
                          proprietaire = a.Proprietaire.Prenom + " " + a.Proprietaire.Nom,
                          idProprietaire = a.IdProprietaire
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
                int idProprietaire = (int)cbProprietaire.SelectedValue;

                Erreur verif = check(adresse, surface, nbrPiece, capacite);

                if (!verif.Valeur)
                {
                    MessageBox.Show(verif.Message);
                    return;
                }

                int id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
                var a = db.appartements.Find(id);
                a.AdresseAppartement = adresse;
                a.Surface = surface;
                a.NombrePiece = nbrPiece;
                a.Capacite = capacite;
                a.IdProprietaire = idProprietaire;
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
            cbProprietaire.SelectedValue = dgAppartement.CurrentRow.Cells[6].Value;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAppartement.CurrentRow.Cells[0].Value.ToString());
            var a = db.appartements.Find(id);
            db.appartements.Remove(a);
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

                Erreur verif = check(adresse, surface, nbrPiece, capacite);

                if (!verif.Valeur)
                {
                    MessageBox.Show(verif.Message);
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

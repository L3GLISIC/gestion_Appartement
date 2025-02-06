using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;

namespace gestionDashboard.views
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }
        BdLocationContext db = new BdLocationContext();

        private void ResetForm()
        {
            duMontant.Text = string.Empty;
            dtpDateDebut.Value = DateTime.Now;
            dtpDateFin.Value = DateTime.Now;
            cbStatut.SelectedIndex = 0;
            cbAppartement.SelectedIndex = 0;
            var location = db.locations
                      .Select(a => new
                      {
                          id = a.IdLocation,
                          numero = a.NumeroLocation,
                          locataire = a.Locataire.Prenom + " " + a.Locataire.Nom,
                          appartement = a.Appartement.AdresseAppartement,
                          montant = a.MontantLocation,
                          dateDebut = a.DateDebut,
                          dateFin = a.DateFin,
                          statut = a.Statut,
                          idLocataire = a.IdLocataire,
                          idAppartement = a.IdAppartement
                      })
                      .ToList();
            dgLocation.DataSource = location;
            Appartement_Load();
            Locataire_Load();
            duMontant.Focus();

        }

        private Boolean check(int montant, DateTime debut, DateTime fin)
        {
            if (montant <= 0)
            {
                return false;
            }

            if (debut >= fin)
            {
                return false;
            }

      

            return true;
        }


        private void Appartement_Load()
        {
            var appartementsDisponibles = db.appartements
                                     .Where(a => a.Disponiblite == true)
                                     .ToList();

            cbAppartement.DataSource = appartementsDisponibles;
            cbAppartement.DisplayMember = "Libelle";
            cbAppartement.ValueMember = "IdAppartement";
        }

        private void Locataire_Load()
        {
            var dateActuelle = DateTime.Now;

            var locatairesSansLocationEnCours = db.locataires
                .Where(l => !l.Locations.Any(loc => loc.DateDebut <= dateActuelle &&
                                                    (loc.DateFin == null || loc.DateFin >= dateActuelle)))
                .ToList();

            // Supposons que vous avez une DataGridView nommée dgvAppartements
            cbLocataire.DataSource = locatairesSansLocationEnCours;
            cbLocataire.DisplayMember = "Nom";
            cbLocataire.ValueMember = "IdPersonne";
        }

        public static string GenererNumeroLocation()
        {
            // Partie aléatoire (4 lettres majuscules)
            var randomPart = new string(Enumerable.Range(0, 4)
                .Select(_ => (char)('A' + new Random().Next(0, 26)))
                .ToArray());
            string datePart = DateTime.Now.ToString("yyMMddHHmmss");
            datePart = datePart.Substring(datePart.Length - 6);

            return randomPart + datePart;
        }


        private void frmLocation_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnModifierLocation_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(duMontant.Text.Trim());
                DateTime debut = DateTime.Parse(dtpDateDebut.Text);
                DateTime fin = DateTime.Parse(dtpDateFin.Text);
                bool statut = cbStatut.Text == "Disponible" ? true : false;
                int idAppartement = (int)cbAppartement.SelectedValue;


                Boolean verif = check(montant, debut, fin);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                int id = int.Parse(dgLocation.CurrentRow.Cells[0].Value.ToString());
                var l = db.locations.Find(id);
                l.MontantLocation = montant;
                l.DateDebut = debut;
                l.DateFin = fin;
                l.Statut = statut;
                l.IdAppartement = idAppartement;

                db.SaveChanges();
                ResetForm();
                MessageBox.Show("Location modifié avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }

        private void btnEnregistrerLocation_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(duMontant.Text.Trim());
                DateTime debut = DateTime.Parse(dtpDateDebut.Text);
                DateTime fin = DateTime.Parse(dtpDateFin.Text);
                DateTime dateCreation = DateTime.Now;
                bool statut = cbStatut.Text == "Disponible" ? true : false;
                int idAppartement = (int)cbAppartement.SelectedValue;
                string numeroLocation = GenererNumeroLocation();
                int idLocataire = (int)cbLocataire.SelectedValue;


                Boolean verif = check(montant, debut, fin);

                if (!verif)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !");
                    return;
                }

                Location l = new Location();
                l.NumeroLocation = numeroLocation;
                l.MontantLocation = montant;
                l.DateDebut = debut;
                l.DateFin = fin;
                l.DateCreation = dateCreation;
                l.Statut = statut;
                l.IdAppartement = idAppartement;
                l.IdLocataire = idLocataire;
                var appartement = db.appartements.Find(idAppartement);
                
                if (appartement.nbrLocataire >= appartement.Capacite)
                {
                    appartement.Disponiblite = false;
                    MessageBox.Show("Capacité maximale atteinte !");
                    return;
                }
                db.locations.Add(l);
                appartement.nbrLocataire += 1;
                db.SaveChanges();
                ResetForm();
                MessageBox.Show("Location ajouté avec succès !"); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }

        private void btnSupprimerLocation_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgLocation.CurrentRow.Cells[0].Value.ToString());
            var a = db.locations.Find(id);
            db.locations.Remove(a);
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisirLocation_Click(object sender, EventArgs e)
        {   
            duMontant.Text = dgLocation.CurrentRow.Cells[4].Value.ToString();
            dtpDateDebut.Text = dgLocation.CurrentRow.Cells[5].Value.ToString();
            dtpDateFin.Text = dgLocation.CurrentRow.Cells[6].Value.ToString();
            cbStatut.SelectedValue = dgLocation.CurrentRow.Cells[7].Value.ToString();
            cbLocataire.SelectedValue = dgLocation.CurrentRow.Cells[8].Value.ToString();
            cbAppartement.SelectedValue = dgLocation.CurrentRow.Cells[9].Value.ToString();

            cbLocataire.Enabled = false;

        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            frmPaiement petiteFenetre = new frmPaiement(this);
            petiteFenetre.ShowDialog();
        }

        public string GetMontantSelectionne()
        {
            return dgLocation.CurrentRow?.Cells[4].Value?.ToString() ?? "0"; // Évite les erreurs null
        }

        public string GetIdLocationSelectionne()
        {
            return dgLocation.CurrentRow?.Cells[0].Value?.ToString() ?? "0"; // Évite les erreurs null
        }
    }
}

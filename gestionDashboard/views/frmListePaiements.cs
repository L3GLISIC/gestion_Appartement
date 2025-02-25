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
using gestionDashboard.Models;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace gestionDashboard.views
{
    public partial class frmListePaiements : Form
    {
        public frmListePaiements()
        {
            InitializeComponent();
        }

        BdLocationContext db = new BdLocationContext();

        private void frmListePaiements_Load(object sender, EventArgs e)
        {
            var paiements = db.paiements
                      .Select(a => new
                      {
                          id = a.IdPaiement,
                          Numero_Facture = a.NumeroFacture,
                          Date_Paiement = a.DatePaiement,
                          Montant = a.MontantPaiement,
                          Statut = a.Statut ? "Valide" : "En attente",
                          Locataire = a.Location.Locataire.Prenom + " " + a.Location.Locataire.Nom,
                          Mode_Paiement = a.ModePaiement.LibelleModePaiement,
                      })
                      .ToList();
            dgPaiements.DataSource = paiements;
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

        private void btnCompletePaiment_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dgPaiements.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du paiement sélectionné
                int idPaiement = Convert.ToInt32(dgPaiements.SelectedRows[0].Cells["id"].Value);

                // Récupérer le paiement depuis la base de données
                Paiement paiement = db.paiements.Find(idPaiement);

                if (paiement == null)
                {
                    MessageBox.Show("Paiement introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Vérifier si le paiement est déjà complété
                if (paiement.Statut)
                {
                    MessageBox.Show("Le paiement est déjà complété !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Afficher le modal pour compléter le paiement
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Montant à payer : {paiement.Location.MontantLocation -  paiement.MontantPaiement}\nSaisissez le montant :",
                    "Compléter le paiement",
                    "0"
                );

                if (int.TryParse(input, out int montantSaisi) && montantSaisi > 0)
                {
                    if (montantSaisi == (paiement.Location.MontantLocation - paiement.MontantPaiement))
                    {
                        // Si le montant est égal au montant à payer
                        paiement.Statut = true;
                        MessageBox.Show("Paiement complété avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Le montant saisi ne correspond pas au montant total à payer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Enregistrer les modifications dans la base de données
                    db.SaveChanges();

                    // Rafraîchir la liste des paiements
                    frmListePaiements_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Montant invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un paiement à compléter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

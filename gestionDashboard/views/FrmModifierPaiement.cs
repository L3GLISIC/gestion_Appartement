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

namespace gestionDashboard.views
{
    public partial class FrmModifierPaiement : Form
    {
        private Paiement paiement;
        BdLocationContext db = new BdLocationContext();
        public FrmModifierPaiement(Paiement paiement)
        {
                InitializeComponent();
                 this.paiement = paiement;
                lblRestant.Text = (paiement.Location.MontantLocation - paiement.MontantPaiement).ToString();
                ModePaiement_Load();
        }

        private void ModePaiement_Load()
        {
            var modespaiements = db.modepaiements
                                     .Select(m => new
                                     {
                                         Id = m.IdModePaiement,
                                         libelle = m.LibelleModePaiement.ToString(),
                                     })
                                  .ToList();

            cbModePaiement.DataSource = modespaiements;
            cbModePaiement.DisplayMember = "libelle";
            cbModePaiement.ValueMember = "Id";
        }

        private void btnEnregistrerLocation_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(duMontantPaiement.Text);
                int restant = paiement.Location.MontantLocation - paiement.MontantPaiement;

                if (montant <= 0 || montant > restant)
                {
                    MessageBox.Show("Le montant doit être compris entre 1 et " + restant);
                    return;
                }
                int idModePaiement = int.Parse(cbModePaiement.SelectedValue.ToString());
                bool Statut = false;
                if(montant >= restant)
                {
                    Statut = true;
                }

                var p = db.paiements.Find(paiement.IdPaiement);

                p.MontantPaiement += montant;
                p.Statut = Statut;


                db.SaveChanges();
                MessageBox.Show("Paiement modifié avec succès !");
                frmListePaiements frm = new frmListePaiements();

                // Appeler la méthode RefreshPaiements du formulaire parent (frmListePaiements)
                foreach (Form form in Application.OpenForms)
                {
                    if (form is frmListePaiements listePaiementForm)
                    {
                        listePaiementForm.RefreshPaiements(); 
                        break;
                    }
                }


                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimerLocation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

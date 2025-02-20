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
using gestionDashboard.Utils;

namespace gestionDashboard.views
{
    public partial class frmPaiement : Form
    {
        private frmLocation parentForm;
        public frmPaiement(frmLocation form)
        {
            InitializeComponent();
            parentForm = form;
            duMontantPaiement.Text = parentForm.GetMontantSelectionne();
            ModePaiement_Load();
        }

        BdLocationContext db = new BdLocationContext();


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

        public string GenererNumeroFacture()
        {
            string prefixe = "FACT";

            string date = DateTime.Now.ToString("yyyyMMdd");

            string identifiantUnique = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

            string numeroFacture = $"{prefixe}-{date}-{identifiantUnique}";

            if (numeroFacture.Length > 50)
            {
                numeroFacture = numeroFacture.Substring(0, 50);
            }

            return numeroFacture;
        }

        private void btnEnregistrerLocation_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(duMontantPaiement.Text);
                if (montant <= 0) {
                    MessageBox.Show("Le montant doit être supérieur à 0");
                    return;
                }
                int idModePaiement = int.Parse(cbModePaiement.SelectedValue.ToString());
                DateTime datePaiement = DateTime.Now;
                string numeroFacture = GenererNumeroFacture();
                int idLocation = int.Parse(parentForm.GetIdLocationSelectionne());
                bool statut = true;
                if(montant != int.Parse(parentForm.GetMontantSelectionne()))
                {
                    statut = false;
                }

                Paiement paiement = new Paiement
                {
                    DatePaiement = datePaiement,
                    MontantPaiement = montant,
                    NumeroFacture = numeroFacture,
                    Statut = statut,
                    IdLocation = idLocation,
                    IdModePaiement = idModePaiement
                };

                db.paiements.Add(paiement);
                db.SaveChanges();
                Location loc = db.locations.Find(idLocation);
                string Message = "";
                Message = "Date : " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " à " + DateTime.Now.Hour + "h:" + DateTime.Now.Minute + "mn" + ",vous avez effectuez un paiement de " + montant + " FCFA votre la location.";
                if (statut == true)
                {
                    Message += "Statut: Complet.";
                }
                else
                {
                    Message += "Statut: IncompletRestant = " + (loc.MontantLocation - paiement.MontantPaiement) + " FCFA";
                }
                MessageBox.Show("Paiement enregistré avec succès !");
                GMailer.sendMail(loc.Locataire.Email, "Confirmation Paiement", Message);
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }

        private void btnSupprimerLocation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

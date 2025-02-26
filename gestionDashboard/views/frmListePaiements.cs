﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace gestionDashboard.views
{
    public partial class frmListePaiements : Form
    {
        public frmListePaiements()
        {
            InitializeComponent();
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

        BdLocationContext db = new BdLocationContext();


        public void RefreshPaiements()
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


        private void frmListePaiements_Load(object sender, EventArgs e)
        {
            RefreshPaiements();
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

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(dgPaiements.CurrentRow.Cells[0].Value.ToString());
            var paiement = db.paiements
                .Where(p => p.IdPaiement == id)
                .FirstOrDefault();
            if (paiement != null)
            {
                if (paiement.Location.MontantLocation - paiement.MontantPaiement >= 0)
                {
                    
                    FrmModifierPaiement f = new FrmModifierPaiement(paiement);
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Le paiement est déjà complet");
                }
            }
                

        }

        private void dgPaiements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

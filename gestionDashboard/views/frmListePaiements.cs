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
    }
}

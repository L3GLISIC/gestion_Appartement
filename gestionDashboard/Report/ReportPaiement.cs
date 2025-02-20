using System;
using gestionDashboard.Models;
using Gestion.Model;

namespace gestionDashboard.Report
{
    public class ReportPaiement
    {
        public int IdPaiement { get; set; }

        public DateTime? DatePaiement { get; set; } = null;
        public string DatePaiementDisplay => DatePaiement?.ToString("dd/MM/yyyy") ?? "N/A";

        public int MontantPaiement { get; set; }

        public string NumeroFacture { get; set; }

        public bool Statut { get; set; }

        public int? IdLocataire { get; set; } = null;
        public string LocationDisplay => Locataire?.Nom ?? "Non défini";

        public virtual Locataire Locataire { get; set; }



        public int? IdModePaiement { get; set; } = null;
        public string ModePaiementDisplay => ModePaiement?.LibelleModePaiement ?? "Non défini";

        public virtual ModePaiement ModePaiement { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Gestion.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionDashboard.Models
{
    public class Paiement
    {
        [Key]
        public int IdPaiement { get; set; }

        
        public DateTime? DatePaiement { get; set; }

        [Required]
        public int MontantPaiement { get; set; }

        [Required, MaxLength(50)]
        public string NumeroFacture { get; set; }

        [Required]
        public bool Statut { get; set; }

        public int? IdLocation { get; set; }

        [ForeignKey("IdLocation")]
        public virtual Location Location { get; set; }

        public int? IdModePaiement { get; set; }

        [ForeignKey("IdModePaiement")]
        public virtual ModePaiement ModePaiement { get; set; }


    }
}

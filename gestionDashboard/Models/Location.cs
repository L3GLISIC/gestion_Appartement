using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using gestionDashboard.Models;

namespace Gestion.Model
{
    public class Location
    {
        [Key]
        public int IdLocation { get; set; }

        [Required]
        public string NumeroLocation { get; set; }

        [Required]
        public int MontantLocation { get; set; }

        [Required]
        public DateTime DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        [Required]
        public DateTime DateCreation { get; set; } = DateTime.Now;

        [Required]
        public bool Statut { get; set; } = true;

        public int? IdAppartement { get; set; }

        [ForeignKey("IdAppartement")]
        public virtual Appartement Appartement { get; set; }

        public int? IdLocataire { get; set; }

        [ForeignKey("IdLocataire")]
        public virtual Locataire Locataire { get; set; }

        public virtual ICollection<Paiement> Paiements { get; set; }


    }
}

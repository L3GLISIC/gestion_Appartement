using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Model
{
    public class Location
    {
        [Key]
        public int IdLocation { get; set; }

        [Required]
        public int MontantLoyer { get; set; }

        [Required]
        public DateTime DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        [Required]
        public DateTime dateCreation { get; set; } = DateTime.Now;


        [Required]
        public bool Statut { get; set; } = true;

        public int? IdAppartement { get; set; }

        [ForeignKey("IdAppartement")]
        public virtual Appartement Appartement { get; set; } = new Appartement();

        public virtual ICollection<Locataire> Locataires { get; set; }

        
    }
}

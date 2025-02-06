using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace gestionDashboard.Models
{
    public class ModePaiement
    {
        [Key]
        public int IdModePaiement { get; set; }
        [Required, MaxLength(20)]
        public string LibelleModePaiement { get; set; }
        public virtual ICollection<Paiement> Paiements { get; set; } = new List<Paiement>();
    }
}

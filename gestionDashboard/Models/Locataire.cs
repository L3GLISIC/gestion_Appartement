using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Model
{
    public class Locataire:Personne
    {
        public int? IdLocation { get; set; }

        [Required, MaxLength(13)]
        public string CNI { get; set; }

        public virtual ICollection<Location> Locations { get; set; }

    }
}

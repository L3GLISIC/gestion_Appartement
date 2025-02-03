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

        [ForeignKey("IdLocation")]
        public virtual Location Location { get; set; } = new Location();

    }
}

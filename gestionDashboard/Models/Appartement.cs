using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Model
{
    public class Appartement
    {
        [Key]
        public int IdAppartement { get; set; }

        [Required, MaxLength(100)]
        public string AdresseAppartement { get; set; }

        public float? Surface {  get; set; }

        public int? NombrePiece { get; set; }

        [Required]
        public int Capacite { get; set; }
        public int? IdProprietaire { get; set; }

        [ForeignKey("IdProprietaire")]

        public virtual Proprietaire Proprietaire { get; set; }

        public virtual ICollection<Location> Locations { get; set; }





    }
}

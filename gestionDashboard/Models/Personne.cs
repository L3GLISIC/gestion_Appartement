using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestion.Model
{
    public class Personne
    {
        [Key]
        public int IdPersonne { get; set; }

        [Required, MaxLength(20)]
        public string Nom { get; set; }

        [Required, MaxLength(50)]
        public string Prenom { get; set; }

        [Required, MaxLength(13)]
        public string Telephone { get; set; }
        [Required, MaxLength(80), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(13)]
        public string CNI { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion.Model;
using System.ComponentModel.DataAnnotations;

namespace gestionDashboard.Models
{
    public class Utilisateur : Personne
    {
        [Required, MaxLength(20)]
        public string Identifiant { get; set; }

        [Required, MaxLength(20)]
        public string MotDePasse { get; set; }

        [Required]
        public bool Statut { get; set; } = true;




    }
}

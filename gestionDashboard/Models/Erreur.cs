using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDashboard.Models
{
    public class Erreur
    {
        public string Message { get; set; }
        public bool Valeur { get; set; }

        public Erreur(string message, bool valeur)
        {
            Message = message;
            Valeur = valeur;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using Gestion.Model;
using gestionDashboard.Models;

namespace Gestion.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class BdLocationContext : DbContext
    {
        public BdLocationContext() : base("bdLocationContext") { }
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }
        public DbSet<Locataire> locataires { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Gestionnaire> gestionnaires { get; set; }
        public DbSet<Administrateur> administrateurs { get; set; }
        public DbSet<Appartement> appartements { get; set; }
        public DbSet<Location> locations { get; set; }
        public object Locations { get; internal set; }
        public DbSet<Paiement> paiements { get; set; }
        public DbSet<ModePaiement> modepaiements { get; set; }
        public DbSet<Td_Erreur> td_Erreurs { get; set; }





    }
}

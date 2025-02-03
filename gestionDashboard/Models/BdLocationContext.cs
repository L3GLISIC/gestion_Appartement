using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using Gestion.Model;

namespace Gestion.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class BdLocationContext : DbContext
    {
        public BdLocationContext() : base("bdLocationContext") { }

        public DbSet<Appartement> appartements { get; set; }
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Locataire> locataires { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }
    }
}

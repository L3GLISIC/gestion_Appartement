using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;
using gestionDashboard.Models;
using gestionDashboard.Utils;
using gestionDashboard.views;

namespace gestionDashboard
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
            //Application.Run(new frmGestion());
            

        }

        static void CreateAdmin()
        {
            BdLocationContext db = new BdLocationContext();
            var admin = db.utilisateurs.Where(user => user.profil == "Admin").FirstOrDefault();
            
            if (admin != null)
            {
                
            }
            else
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    var ad = new Administrateur();
                    ad.Nom = "Administrateur";
                    ad.Prenom = "Administrateur";
                    ad.Telephone = "+221765432345";
                    ad.Identifiant = "Admin";
                    ad.profil = "Admin";
                    ad.MotDePasse = CryptApp.GetMd5Hash(md5Hash, "Admin");
                    ad.Email = "admin@yopmail.com";
                    db.administrateurs.Add(ad);
                    db.SaveChanges();
                    MessageBox.Show("Admin crée avec succés");
                }
            }

            


        }
    }
}

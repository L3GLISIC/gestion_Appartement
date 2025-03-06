using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;
using gestionDashboard.Utils;

namespace gestionDashboard.views
{
    public partial class frmMotDePasseOublie : Form
    {
        public frmMotDePasseOublie()
        {
            InitializeComponent();
        }
        BdLocationContext db = new BdLocationContext();

        private string generePwd(int length)
        {
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "@#";

            Random random = new Random();

            // Assurer au moins un de chaque type de caractère
            char[] password = new char[length];
            password[0] = upperCase[random.Next(upperCase.Length)];
            password[1] = lowerCase[random.Next(lowerCase.Length)];
            password[2] = digits[random.Next(digits.Length)];
            password[3] = specialChars[random.Next(specialChars.Length)];

            // Remplir le reste avec des caractères aléatoires
            string allChars = upperCase + lowerCase + digits + specialChars;
            for (int i = 4; i < length; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            // Mélanger les caractères pour éviter un motif prévisible
            return new string(password.OrderBy(x => random.Next()).ToArray());

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var leuser = db.utilisateurs.Where(a => a.Email == txtEmail.Text).FirstOrDefault();
            using (MD5 md5Hash = MD5.Create())
            {
                if (leuser != null)
                {
                    string password = generePwd(8).ToString();
                    leuser.MotDePasse = CryptApp.GetMd5Hash(md5Hash,password);
                    leuser.Statut = null;
                    MessageBox.Show("Consulter votre boite mail");
                    txtEmail.Text = "";
                    db.SaveChanges();
                    string message = $@"
                    Bonjour {leuser.Prenom} {leuser.Nom},

                    Votre mot de passe a été modifié avec succès.

                    Identifiant : {leuser.Identifiant}
                    Mot de passe : {password}

                    Veuillez changer votre mot de passe lors de votre première connexion.

                    Cordialement,
                    L'équipe de gestion
                    ";

                    GMailer.sendMail(leuser.Email, "Mot de passe oublié", message);
                    this.Close();
                    frmConnexion f = new frmConnexion();
                    f.Show();


                }
                else
                {
                    MessageBox.Show("Compte introuvable");
                }
            }
                
        }
    }
}

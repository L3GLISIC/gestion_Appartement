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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        BdLocationContext db = new BdLocationContext();

        public  string idUser;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtConfirmePwd.Text == txtPwd.Text)
            {
                if (!CryptApp.ValidatePassword(txtPwd.Text)) 
                {
                    return; 
                }

                if (int.TryParse(idUser, out int userId)) 
                {
                    var leUser = db.utilisateurs.Find(userId);

                    if (leUser != null)
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {
                            leUser.MotDePasse = CryptApp.GetMd5Hash(md5Hash, txtPwd.Text);
                            leUser.Statut = "Enabled";
                            db.SaveChanges();
                        }

                        frmGestion f = new frmGestion();
                        f.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : l'ID utilisateur est invalide.");
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne sont pas identiques.");
            }
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

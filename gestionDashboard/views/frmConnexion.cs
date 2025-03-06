using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;
using gestionDashboard.Models;
using gestionDashboard.Utils;

namespace gestionDashboard.views
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        public static Utilisateur userConnecte;

        BdLocationContext db = new BdLocationContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                var leuser = db.utilisateurs.Where(a => a.Identifiant.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();

                if (leuser != null) {

                    string hash = leuser.MotDePasse;

                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (CryptApp.VerifyMd5Hash(md5Hash, txtPwd.Text, hash) || leuser.MotDePasse == null)
                        {

                            if (leuser.Statut == null)
                            {
                                frmResetPassword f = new frmResetPassword();
                                f.idUser = leuser.IdPersonne.ToString();
                                f.Show();
                                this.Hide();
                            }
                            else if (leuser.Statut == "Enabled")
                            {
                                userConnecte = leuser;
                                frmGestion f = new frmGestion();
                                var le = db.utilisateurs.Find(leuser.IdPersonne);
                                f.Show();
                                this.Hide();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou Mot de passe incorrect");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Identifiant ou Mot de passe incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPwdOublie_Click(object sender, EventArgs e)
        {
            frmMotDePasseOublie f = new frmMotDePasseOublie();
            f.Show();
            this.Hide();

        }
    }
}

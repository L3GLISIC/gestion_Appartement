using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Model;
using gestionDashboard.Models;
using gestionDashboard.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace gestionDashboard.views
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
            ResetForm();

            // Ajouter l'événement SelectionChanged au DataGridView
            dgUtilisateur.SelectionChanged += DgUtilisateur_SelectionChanged;
        }
        BdLocationContext db = new BdLocationContext();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private string generateUniqueUsername(string nom, string prenom)
        {
            string processedNom = CapitalizeFirstLetter(nom);
            string processedPrenom = CapitalizeFirstLetter(prenom);

            int userCount = db.utilisateurs.Count(); // Nombre d'utilisateurs dans la base de données
            int currentSeconds = DateTime.Now.Second; // Nombre de secondes actuelles (0-59)

            // Concaténation du username
            return $"{processedNom}{processedPrenom}{userCount + currentSeconds}";
        }

        private Erreur check(string nom, string prenom, string email, string tel, string identifiant)
        {
            var Utilisateur = db.utilisateurs.Where(u => u.Identifiant == identifiant);
            if (Utilisateur.Count() > 0)
            {
                return new Erreur("L'identifiant existe déjà", false);
            }
            if (identifiant.Length > 20)
            {
                return new Erreur("L'identifiant ne doit pas dépasser 20 caractères.", false);
            }

            if (string.IsNullOrEmpty(nom))
            {
                return new Erreur("le nom ne doit pas etre vide", false);
            }
            if (string.IsNullOrEmpty(prenom))
            {
                return new Erreur("le prenom ne doit pas etre vide", false);
            }
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@gmail\.com$"))
            {
                return new Erreur("L'email n'est pas valide", false);
            }
            if (string.IsNullOrEmpty(tel) || !Regex.IsMatch(tel, @"^(77|78|76|75|70)\d{7}$"))
            {
                return new Erreur("Le numéro de téléphone n'est pas valide (77|78|76|75|700000000)", false);
            }
            return new Erreur("Ok", true);
        }

        static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        private void ResetForm()
        {
            txtEmail.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtIdentifiant.Text = "";
            btnBloquerUtilisateur.Visible = false;
            dgUtilisateur.DataSource = db.utilisateurs.Select(u => new
            {
                Id = u.IdPersonne,
                identifiant = u.Identifiant,
                nom = u.Nom,
                prenom = u.Prenom,
                email = u.Email,
                telephone = u.Telephone,
                statut = u.Statut
            }).ToList();
            txtPrenom.Focus();
        }

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

        private async void btnEnregistrerUtilisateur_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                Erreur err = check(txtNom.Text, txtPrenom.Text, txtEmail.Text, txtTel.Text, txtIdentifiant.Text);
                if (!err.Valeur)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
                string pwd = generePwd(8).ToString();
                Utilisateur ut = new Utilisateur();
                ut.Nom = txtNom.Text;
                ut.Prenom = txtPrenom.Text;
                ut.Email = txtEmail.Text;
                ut.profil = "Gestionnaire";
                ut.Telephone = "+221" + txtTel.Text;
                ut.Identifiant = txtIdentifiant.Text;
                ut.Statut = "Enabled"; // Ajouter le statut par défaut lors de la création

                ut.MotDePasse = CryptApp.GetMd5Hash(md5Hash, pwd);
                db.utilisateurs.Add(ut);
                db.SaveChanges();
                MessageBox.Show("Compte crée avec succes");
                ResetForm();
                string message = $@"
                    Bonjour {ut.Prenom} {ut.Nom},

                    Votre compte a été créé avec succès.

                    Identifiant : {ut.Identifiant}
                    Mot de passe : {pwd}

                    Veuillez changer votre mot de passe lors de votre première connexion.

                    Cordialement,
                    L'équipe de gestion
                    ";

                GMailer.sendMail(ut.Email, "Création de compte", message);
                await Whatsapp.SendWhatsappMessage(ut.Telephone, message);

            }

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text.Length != 0 && txtPrenom.Text.Length != 0)
            {
                txtIdentifiant.Text = generateUniqueUsername(txtNom.Text, txtPrenom.Text).ToString().ToLower();
            }

        }

        private void btnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dgUtilisateur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPersonne = Convert.ToInt32(dgUtilisateur.SelectedRows[0].Cells["Id"].Value);

            // Chercher l'utilisateur dans la base de données
            Utilisateur utilisateur = db.utilisateurs.FirstOrDefault(u => u.IdPersonne == idPersonne);

            if (utilisateur == null)
            {
                MessageBox.Show("Utilisateur introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier les données entrées
            Erreur err = check(txtNom.Text, txtPrenom.Text, txtEmail.Text, txtTel.Text, txtIdentifiant.Text);
            if (!err.Valeur)
            {
                MessageBox.Show(err.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mettre à jour les informations de l'utilisateur
            utilisateur.Nom = txtNom.Text;
            utilisateur.Prenom = txtPrenom.Text;
            utilisateur.Email = txtEmail.Text;
            utilisateur.Telephone = "+221" + txtTel.Text;
            utilisateur.Identifiant = txtIdentifiant.Text;

            // Sauvegarder les modifications
            db.SaveChanges();

            MessageBox.Show("Utilisateur modifié avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Rafraîchir la liste et réinitialiser le formulaire
            ResetForm();
        }

        private void btnBloquerUtilisateur_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dgUtilisateur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPersonne = Convert.ToInt32(dgUtilisateur.SelectedRows[0].Cells["Id"].Value);

            // Chercher l'utilisateur dans la base de données
            Utilisateur utilisateur = db.utilisateurs.FirstOrDefault(u => u.IdPersonne == idPersonne);

            if (utilisateur == null)
            {
                MessageBox.Show("Utilisateur introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Changer le statut de l'utilisateur en fonction de son statut actuel
            if (utilisateur.Statut == "Enabled")
            {
                utilisateur.Statut = "Disabled";
                MessageBox.Show("L'utilisateur a été bloqué avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                utilisateur.Statut = "Enabled";
                MessageBox.Show("L'utilisateur a été débloqué avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Sauvegarder les modifications
            db.SaveChanges();

            // Rafraîchir la liste et réinitialiser le formulaire
            ResetForm();

            // Mettre à jour le texte du bouton et sa visibilité
            UpdateBlockButtonVisibility();
        }

        private void DgUtilisateur_SelectionChanged(object sender, EventArgs e)
        {
            UpdateBlockButtonVisibility();

            // Optionnel: Remplir les champs du formulaire avec les données de l'utilisateur sélectionné
            if (dgUtilisateur.SelectedRows.Count > 0)
            {
                txtNom.Text = dgUtilisateur.SelectedRows[0].Cells["nom"].Value.ToString();
                txtPrenom.Text = dgUtilisateur.SelectedRows[0].Cells["prenom"].Value.ToString();
                txtEmail.Text = dgUtilisateur.SelectedRows[0].Cells["email"].Value.ToString();
                string telephone = dgUtilisateur.SelectedRows[0].Cells["telephone"].Value.ToString();
                txtTel.Text = telephone.Replace("+221", "");
                txtIdentifiant.Text = dgUtilisateur.SelectedRows[0].Cells["identifiant"].Value.ToString();
            }
        }

        private void UpdateBlockButtonVisibility()
        {
            if (dgUtilisateur.SelectedRows.Count == 0)
            {
                btnBloquerUtilisateur.Visible = false;
                return;
            }

            int idPersonne = Convert.ToInt32(dgUtilisateur.SelectedRows[0].Cells["Id"].Value);
            Utilisateur utilisateur = db.utilisateurs.FirstOrDefault(u => u.IdPersonne == idPersonne);

            if (utilisateur == null)
            {
                btnBloquerUtilisateur.Visible = false;
                return;
            }

            btnBloquerUtilisateur.Visible = true;

            if (utilisateur.Statut == "Enabled")
            {
                btnBloquerUtilisateur.Text = "Bloquer";
                btnBloquerUtilisateur.FlatAppearance.BorderColor = Color.Red;
                btnBloquerUtilisateur.ForeColor = Color.Red;
            }
            else
            {
                btnBloquerUtilisateur.Text = "Débloquer";
                btnBloquerUtilisateur.FlatAppearance.BorderColor = Color.Green;
                btnBloquerUtilisateur.ForeColor = Color.Green;
            }
        }
    }
}
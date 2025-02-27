using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion.Model;
using gestionDashboard.Models;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Security;

namespace gestionDashboard.Utils
{
    public static class CryptApp
    {
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            
        }

         public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères.");
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Le mot de passe doit contenir au moins une lettre majuscule.");
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Le mot de passe doit contenir au moins un chiffre.");
                return false;
            }

            return true;
        }

    }
    public class Helper
    {
        BdLocationContext db = new BdLocationContext();
        /// <summary>
        /// cette méthode permet de logger les erreurs dans la table td_Erreur
        /// </summary>
        /// <param name="TitreErreur">titre erreur</param>
        /// <param name="erreur">erreur</param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 2000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.td_Erreurs.Add(log);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        public static void WriteLogSystem(string erreur, string libelle)
        {
            string source = "Gestion Location";
            string logName = "Application";

            try
            {
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, logName);
                }

                using (EventLog eventLog = new EventLog(logName))
                {
                    eventLog.Source = source;
                    eventLog.WriteEntry(
                        string.Format("Date: {0}, Libelle: {1}, Description: {2}", DateTime.Now, libelle, erreur),
                        EventLogEntryType.Information,
                        101,
                        1);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show("Erreur de permissions : exécutez l'application en tant qu'administrateur.\nDétails : " + ex.Message);
            }
        }


    }
}

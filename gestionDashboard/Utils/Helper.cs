using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion.Model;
using gestionDashboard.Models;

namespace gestionDashboard.Utils
{
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
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Gestion Location";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description: {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}

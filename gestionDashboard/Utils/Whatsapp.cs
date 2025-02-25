using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace gestionDashboard.Utils
{
    public class Whatsapp
    {
        private static readonly HttpClient client = new HttpClient();
        private const string API_URL = "https://api.wassenger.com/v1/messages?key1=b7535b056462fc0dbd7f23ca7fffe5464f8e9c906e80283204160f598ead4a0791f0a77a527e0634";
        private const string TOKEN = "5f91227656bada4cfb95b3e1681616ad716fd0f00817f96d056ebfa71d67ec57aa51209df836399c";

        public static async Task SendWhatsappMessage(string phoneNumber, string message)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(API_URL));

                // Ajout du header Token
                request.Headers.Add("Token", TOKEN);

                // Construction du JSON avec JsonSerializer
                var jsonContent = new
                {
                    phone = phoneNumber,
                    message = message
                };

                var jsonString = JsonConvert.SerializeObject(jsonContent);

                // Envoi de la requête
                request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                // Lecture de la réponse
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Réponse API : " + body);
            }
            catch (Exception ex)
            {
                Helper.WriteLogSystem(ex.ToString(), "Whatsapp-SendWhatsappMessage");
                Console.WriteLine("Erreur lors de l'envoi du message WhatsApp : " + ex.Message);
            }
        }
    }
}

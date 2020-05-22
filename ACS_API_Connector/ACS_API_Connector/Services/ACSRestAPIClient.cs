using ACS_API_Connector.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ACS_API_Connector.Services
{
    public class ACSRestAPIClient 
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly string URI = "https://webservices.acscourier.net/ACSRestServices/api/ACSAutoRest"; 
        private static HttpContent _content;
        public ACSRestAPIClient() {
            string ACSApiKey = "632af1620f2f4b839676043d954f3017";
            _client.DefaultRequestHeaders.Add("ACSApiKey", ACSApiKey);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public ACSRestAPIClient(string ACSApiKey)
        {
            _client.DefaultRequestHeaders.Add("ACSApiKey", ACSApiKey);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> Request(string content)
        {
            try
            {
                _content = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(URI, _content);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }   
        }

    }
}

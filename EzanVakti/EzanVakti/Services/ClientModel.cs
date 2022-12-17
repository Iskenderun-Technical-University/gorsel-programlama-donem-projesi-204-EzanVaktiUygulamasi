using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System;

namespace Picasso.Services
{
    public class CLientModel
    {
        private readonly HttpClient client;

        public CLientModel()
        {
            client = new HttpClient();
        }
        public async Task<T> ProcessApi<T>(string url)
        {
            var uri = new Uri(url);
            T result;
            using var streamTask = await client.GetStreamAsync(uri);
            T data = default(T);

            data = await JsonSerializer.DeserializeAsync<T>(streamTask);
            result = data;
            return result;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Http
{
    internal class Http_Request_Await
    {
        static async Task MakeRequestAsync(int id)
        {
            string targetUrl = $"https://jsonplaceholder.typicode.com/users/{id}";

            var client = new HttpClient();
            var response = await client.GetAsync(targetUrl);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }

        static async Task Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                await MakeRequestAsync(i);
            }
        }
    }
}

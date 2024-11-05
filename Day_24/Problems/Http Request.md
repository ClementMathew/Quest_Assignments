# Http Request

#### Discussed about :

    Concepts of HTTP Request.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Http
{
    internal class Http_Request
    {
        static void MakeRequest()
        {
            string targetUrl = "https://jsonplaceholder.typicode.com/users";

            var client = new HttpClient();
            var response = client.GetAsync(targetUrl).Result;
            response.EnsureSuccessStatusCode();

            var responseClient = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseClient);
        }

        static void Main(string[] args)
        {
            MakeRequest();
        }
    }
}

```

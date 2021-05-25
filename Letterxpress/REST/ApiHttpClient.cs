#region COPYRIGHT

// (c) 2021 Code Astronauts Agyekum und Kleinert GbR
// All rights reserved.
// 
// Contact: hello@codeastronauts.net

#endregion

#region Usings

using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

#endregion

namespace Letterxpress.REST
{
    public class ApiHttpClient
    {
        private static readonly HttpClient client = new();

        public ApiHttpClient(Letterxpress.Library instance)
        {
            Instance = instance;
        }

        internal Letterxpress.Library Instance { get; }

        public async Task<object> SendRequestAsync(HttpMethod method, string endpoint, params Parameter[] parameters)
        {
            var url = Instance.Sandbox ? "https://sandbox.letterxpress.de/v1/" : "https://api.letterxpress.de/v1/";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "CSharpLib");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("auth", JsonConvert.SerializeObject(Instance.Auth));

            var request = new HttpRequestMessage(method, $"{url}{endpoint}")
            {
                Content = new StringContent($"{{ \"auth\": {JsonConvert.SerializeObject(Instance.Auth)}}}",
                    Encoding.UTF8,
                    "application/json")
            };

            var result = string.Empty;

            await client.SendAsync(request)
                .ContinueWith(async responseTask =>
                {
                    using var streamResult = new StreamReader(await responseTask.Result.Content.ReadAsStreamAsync(),
                        Encoding.UTF8);
                    result = streamResult.ReadToEnd();
                    //result = responseTask.Result;
                });

            return result;
        }
    }
}
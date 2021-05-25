#region COPYRIGHT

// (c) 2021 Code Astronauts Agyekum und Kleinert GbR
// All rights reserved.
// 
// Contact: hello@codeastronauts.net

#endregion

using System.Net.Http;
using Letterxpress.REST.Result;
using Newtonsoft.Json;

namespace Letterxpress.EndPoints
{
    public class Pricing
    {
        public Pricing(Library instance)
        {
            Instance = instance;
        }

        internal Library Instance { get; }

        public string GetBalance(bool withCurrency = false)
        {
            var response = Instance.HttpClient.SendRequestAsync(HttpMethod.Get, "getBalance").Result;
            var deserialized = JsonConvert.DeserializeObject<RootBalance>((string) response);
            if (deserialized != null)
                return withCurrency
                    ? $"{deserialized.Balance.Value} {deserialized.Balance.Currency}"
                    : deserialized.Balance.Value;
            return "";
        }
    }
}
#region COPYRIGHT

// (c) 2021 Code Astronauts Agyekum und Kleinert GbR
// All rights reserved.
// 
// Contact: hello@codeastronauts.net

#endregion

#region Usings

using Newtonsoft.Json;

#endregion

namespace Letterxpress.REST.Result
{
    public class Auth
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("user")] public string User { get; set; }

        [JsonProperty("status")] public string Status { get; set; }
    }

    public class Balance
    {
        [JsonProperty("value")] public string Value { get; set; }

        [JsonProperty("currency")] public string Currency { get; set; }
    }

    public class RootBalance
    {
        [JsonProperty("auth")] public Auth Auth { get; set; }

        [JsonProperty("balance")] public Balance Balance { get; set; }

        [JsonProperty("status")] public int Status { get; set; }

        [JsonProperty("message")] public string Message { get; set; }
    }
}
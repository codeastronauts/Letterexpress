#region COPYRIGHT

// (c) 2021 Code Astronauts Agyekum und Kleinert GbR
// All rights reserved.
// 
// Contact: hello@codeastronauts.net

#endregion

#region Usings

using Newtonsoft.Json;

#endregion

namespace Letterxpress.REST.Custom
{
    public class Auth
    {
        [JsonProperty("apikey")] public string Apikey;

        [JsonProperty("username")] public string Username;
    }
}
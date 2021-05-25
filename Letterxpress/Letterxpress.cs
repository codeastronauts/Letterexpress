#region COPYRIGHT

// (c) 2021 Code Astronauts Agyekum und Kleinert GbR
// All rights reserved.
// 
// Contact: hello@codeastronauts.net

#endregion

#region Usings

using Letterxpress.EndPoints;
using Letterxpress.REST.Custom;
using Library.REST;

#endregion

namespace Letterxpress
{
    public class Library
    {
        internal Auth Auth { get; private set; }
        internal bool Sandbox { get; private set; }
        internal Library Instance { get; private set; }
        internal ApiHttpClient HttpClient { get; private set; }
        public Pricing Pricing { get; private set; }

        public void Init(string username, string api, bool useSandbox)
        {
            Instance = this;
            Sandbox = useSandbox;
            Auth = new Auth {Apikey = api, Username = username};
            HttpClient = new ApiHttpClient(Instance);
            Pricing = new Pricing(Instance);
        }
    }
}
using System.Configuration;

namespace MailChimpSharp.FunctionalFacts
{
    public abstract class FunctionalFactsBase
    {
        protected FunctionalFactsBase()
        {
            TestAPIKey = ConfigurationManager.AppSettings["apiKey"];
        }

        protected static string TestAPIKey { get; set; }
    }
}
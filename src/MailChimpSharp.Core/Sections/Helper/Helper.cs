namespace MailChimpSharp.Core.Sections.Helper
{
    public class Helper : IHelper
    {
        private readonly IMailChimpConnector _connector;

        internal Helper(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
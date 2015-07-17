namespace MailChimpSharp.Core.Helper
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
namespace MailChimpSharp.Core.Sections.Ecomm
{
    public class Ecomm : IEcomm
    {
        private readonly IMailChimpConnector _connector;

        internal Ecomm(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
using System;

namespace MailChimpSharp.Core
{
    public class MailChimpFactory : IMailChimpFactory
    {
        public IMailChimp Create(string apiKey)
        {
            var mailChimpConnector = new MailChimpConnector(apiKey);
            return Create(mailChimpConnector);
        }

        public IMailChimp Create(string accessToken, string dataCentrePrefix)
        {
            var mailChimpConnector = new MailChimpConnector(accessToken, dataCentrePrefix);
            return Create(mailChimpConnector);
        }

        private IMailChimp Create(IMailChimpConnector connector)
        {
            throw new NotImplementedException();
        }
    }
}
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

        private static IMailChimp Create(IMailChimpConnector connector)
        {
            return new MailChimp(
                new Automations.Automations(connector), 
                new Campaigns.Campaigns(connector), 
                new Conversations.Conversations(connector), 
                new Ecomm.Ecomm(connector), 
                new Folders.Folders(connector), 
                new Gallery.Gallery(connector), 
                new Goal.Goal(connector), 
                new Helper.Helper(connector), 
                new Lists.Lists(connector), 
                new Reports.Reports(connector), 
                new Templates.Templates(connector), 
                new Users.Users(connector), 
                new Vip.Vip(connector));
        }
    }
}
using MailChimpSharp.Core.Sections.Automations;
using MailChimpSharp.Core.Sections.Campaigns;
using MailChimpSharp.Core.Sections.Conversations;
using MailChimpSharp.Core.Sections.Ecomm;
using MailChimpSharp.Core.Sections.Folders;
using MailChimpSharp.Core.Sections.Gallery;
using MailChimpSharp.Core.Sections.Goal;
using MailChimpSharp.Core.Sections.Helper;
using MailChimpSharp.Core.Sections.Lists;
using MailChimpSharp.Core.Sections.Reports;
using MailChimpSharp.Core.Sections.Templates;
using MailChimpSharp.Core.Sections.Users;
using MailChimpSharp.Core.Sections.Vip;

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
                new Automations(connector), 
                new Campaigns(connector), 
                new Conversations(connector), 
                new Ecomm(connector), 
                new Folders(connector), 
                new Gallery(connector), 
                new Goal(connector), 
                new Helper(connector), 
                new Lists(connector), 
                new Reports(connector), 
                new Templates(connector), 
                new Users(connector), 
                new Vip(connector));
        }
    }
}
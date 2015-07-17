namespace MailChimpSharp.Core.Campaigns
{
    public class Campaigns : ICampaigns
    {
        private readonly IMailChimpConnector _connector;

        internal Campaigns(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
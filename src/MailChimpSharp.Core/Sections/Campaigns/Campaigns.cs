using System.Threading;
using System.Threading.Tasks;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class Campaigns : ICampaigns
    {
        private const string ContentAction = "campaigns/content";
        private readonly IMailChimpConnector _connector;

        internal Campaigns(IMailChimpConnector connector)
        {
            _connector = connector;
        }

        public MailChimpCampaignContent GetContent(string campaignId, CampaignContentOptions options = null)
        {
            const string Action = ContentAction;

            return _connector.Execute<MailChimpCampaignContent>(Action,
                new
                {
                    cid = campaignId,
                    options
                });
        }

        public Task<MailChimpCampaignContent> GetContentAsync(string campaignId, CampaignContentOptions options = null, CancellationToken cancellationToken = new CancellationToken())
        {
            const string Action = ContentAction;

            return _connector.ExecuteAsync<MailChimpCampaignContent>(Action,
                new
                {
                    cid = campaignId,
                    options
                },
                cancellationToken);
        }
    }
}
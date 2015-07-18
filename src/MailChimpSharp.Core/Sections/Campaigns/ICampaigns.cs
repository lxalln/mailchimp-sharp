using System.Threading;
using System.Threading.Tasks;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public interface ICampaigns
    {
        MailChimpCampaignContent GetContent(string campaignId, CampaignContentOptions options = null);

        Task<MailChimpCampaignContent> GetContentAsync(
            string campaignId, 
            CampaignContentOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken));

        MailChimpCampaign Create(MailChimpCampaign.CampaignType type, CampaignCreateOptions options);
    }
}
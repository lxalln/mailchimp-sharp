using System.Collections.Generic;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateOptions
    {
        public CampaignCreateOptions()
        {
            Authenticate = false;
            AutoFooter = false;
            InlineCss = false;
            GenerateText = false;
            AutoTweet = false;
            AutoFacebookPost = new List<string>();
            FacebookComments = true;
            Timewarp = false;
        }

        public string ListId { get; internal set; }

        public string Subject { get; internal set; }

        public string FromEmail { get; internal set; }

        public string FromName { get; internal set; }

        public string ToName { get; internal set; }

        public int? TemplateId { get; internal set; }

        public int? GalleryTemplateId { get; internal set; }

        public int? BaseTemplateId { get; internal set; }

        public int? FolderId { get; internal set; }

        // todo: tracking

        public string Title { get; internal set; }

        public bool Authenticate { get; internal set; }

        // todo: analytics

        public bool AutoFooter { get; internal set; }

        public bool InlineCss { get; internal set; }

        public bool GenerateText { get; internal set; }

        public bool AutoTweet { get; internal set; }

        public List<string> AutoFacebookPost { get; private set; } 

        public bool FacebookComments { get; internal set; }

        public bool Timewarp { get; internal set; }

        public bool Ecomm360 { get; internal set; }

        // todo: crm_tracking
    }
}
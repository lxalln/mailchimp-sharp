namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateContentOptionsBuilder
    {
        public CampaignCreateContentOptionsBuilder()
        {
            Options = new CampaignCreateContentOptions();
        }

        private CampaignCreateContentOptions Options { get; set; }

        public static implicit operator CampaignCreateContentOptions(CampaignCreateContentOptionsBuilder builder)
        {
            return builder.Options;
        }

        public CampaignCreateContentOptionsBuilder AsArchive(string archiveContent)
        {
            Options.Url = null;
            Options.Archive = archiveContent;
            return this;
        }

        public CampaignCreateContentOptionsBuilder FromUrl(string url)
        {
            Options = new CampaignCreateContentOptions { Url = url };
            return this;
        }

        public CampaignCreateContentOptionsBuilder UsingSection(string key, string value)
        {
            Options.Url = null;
            Options.Sections.Add(key, value);
            return this;
        }

        public CampaignCreateContentOptionsBuilder WithArchiveType(CampaignCreateContentOptions.ArchiveTypeOption archiveType)
        {
            Options.ArchiveType = archiveType;
            return this;
        }

        public CampaignCreateContentOptionsBuilder WithHtml(string html)
        {
            Options.Url = null;
            Options.Html = html;
            return this;
        }

        public CampaignCreateContentOptionsBuilder WithText(string text)
        {
            Options.Url = null;
            Options.Text = text;
            return this;
        }
    }
}
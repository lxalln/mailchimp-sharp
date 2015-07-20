using System.Collections.Generic;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateContentOptions
    {
        public CampaignCreateContentOptions()
        {
            Sections = new Dictionary<string, string>();
        }

        public enum ArchiveTypeOption
        {
            Zip, 
            TarGz, 
            TarBz2, 
            Tar, 
            Tgz, 
            Tbz
        }

        public string Archive { get; internal set; }

        public ArchiveTypeOption ArchiveType { get; internal set; }

        public string Html { get; internal set; }

        public IDictionary<string, string> Sections { get; private set; }

        public string Text { get; internal set; }

        public string Url { get; internal set; }
    }

    public class CampaignCreateContentOptionsBuilder
    {
        private readonly CampaignCreateContentOptions _options;

        public CampaignCreateContentOptionsBuilder()
        {
            _options = new CampaignCreateContentOptions();
        }

        protected CampaignCreateContentOptions Options
        {
            get { return _options; }
        }

        public CampaignCreateContentOptionsBuilder WithHtml(string html)
        {
            Options.Html = html;
            return this;
        }

        public CampaignCreateContentOptionsBuilder UsingSection(string key, string value)
        {
            Options.Sections.Add(key, value);
            return this;
        }        
    }
}
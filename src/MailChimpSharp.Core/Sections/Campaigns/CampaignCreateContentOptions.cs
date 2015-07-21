using System.Collections.Generic;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateContentOptions
    {
        internal CampaignCreateContentOptions()
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
}
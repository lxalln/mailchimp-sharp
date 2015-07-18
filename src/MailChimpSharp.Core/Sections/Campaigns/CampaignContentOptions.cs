namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignContentOptions
    {
        internal CampaignContentOptions()
        {
        }

        public enum ContentView
        {
            Archive, 
            Preview, 
            Raw
        }

        public MailChimpEmail Email { get; internal set; }

        public ContentView View { get; internal set; }
    }
}
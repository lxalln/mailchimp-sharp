using System;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateOptionsBuilder
    {
        private readonly CampaignCreateOptions _options;

        public CampaignCreateOptionsBuilder()
        {
            _options = new CampaignCreateOptions();
        }

        public static implicit operator CampaignCreateOptions(CampaignCreateOptionsBuilder builder)
        {
            return builder._options;
        }

        public CampaignCreateOptionsBuilder SendToList(string listId)
        {
            if (string.IsNullOrWhiteSpace(listId))
            {
                throw new ArgumentException("Invalid listId");
            }
            
            _options.ListId = listId;
            return this;
        }

        public CampaignCreateOptionsBuilder WithSubject(string subject)
        {
            _options.Subject = subject;
            return this;
        }

        public CampaignCreateOptionsBuilder WithFromEmail(string fromEmail)
        {
            _options.FromEmail = fromEmail;
            return this;
        }

        public CampaignCreateOptionsBuilder WithFromName(string fromName)
        {
            _options.FromName = fromName;
            return this;
        }

        public CampaignCreateOptionsBuilder WithToName(string toName)
        {
            _options.ToName = toName;
            return this;
        }

        public CampaignCreateOptionsBuilder UsingTemplate(int templateId)
        {
            _options.TemplateId = templateId;
            return this;
        }

        public CampaignCreateOptionsBuilder UsingGalleryTemplate(int galleryTemplateId)
        {
            _options.GalleryTemplateId = galleryTemplateId;
            return this;
        }

        public CampaignCreateOptionsBuilder UsingBaseTemplate(int baseTemplateId)
        {
            _options.BaseTemplateId = baseTemplateId;
            return this;
        }

        public CampaignCreateOptionsBuilder InFolder(int folderId)
        {
            _options.FolderId = folderId;
            return this;
        }

        public CampaignCreateOptionsBuilder WithTitle(string title)
        {
            _options.Title = title;
            return this;
        }

        public CampaignCreateOptionsBuilder Authenticate()
        {
            _options.Authenticate = true;
            return this;
        }

        public CampaignCreateOptionsBuilder AutoGenerateFooter()
        {
            _options.AutoFooter = true;
            return this;
        }

        public CampaignCreateOptionsBuilder InlineCss()
        {
            _options.InlineCss = true;
            return this;
        }

        public CampaignCreateOptionsBuilder GenerateText()
        {
            _options.GenerateText = true;
            return this;
        }

        public CampaignCreateOptionsBuilder AutoTweet()
        {
            _options.AutoTweet = true;
            return this;
        }

        public CampaignCreateOptionsBuilder PostToFacebookPages(params string[] pageIds)
        {
            _options.AutoFacebookPost.AddRange(pageIds);
            return this;
        }

        public CampaignCreateOptionsBuilder DisableFacebookComments()
        {
            _options.FacebookComments = false;
            return this;
        }

        public CampaignCreateOptionsBuilder EnableTimewarp()
        {
            _options.Timewarp = true;
            return this;
        }

        public CampaignCreateOptionsBuilder EnableEcomm360()
        {
            _options.Ecomm360 = true;
            return this;
        }
    }
}
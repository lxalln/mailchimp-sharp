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

        protected CampaignCreateOptions Options
        {
            get { return _options; }
        }

        public static implicit operator CampaignCreateOptions(CampaignCreateOptionsBuilder builder)
        {
            return builder.Options;
        }

        public CampaignCreateOptionsBuilder Authenticate()
        {
            Options.Authenticate = true;
            return this;
        }

        public CampaignCreateOptionsBuilder AutoGenerateFooter()
        {
            Options.AutoFooter = true;
            return this;
        }

        public CampaignCreateOptionsBuilder AutoTweet()
        {
            Options.AutoTweet = true;
            return this;
        }

        public CampaignCreateOptionsBuilder DisableFacebookComments()
        {
            Options.FacebookComments = false;
            return this;
        }

        public CampaignCreateOptionsBuilder DisableHtmlClickTracking()
        {
            Options.Tracking.HtmlClicks = false;
            return this;
        }

        public CampaignCreateOptionsBuilder DisableOpenTracking()
        {
            Options.Tracking.Opens = false;
            return this;
        }

        public CampaignCreateOptionsBuilder EnableEcomm360()
        {
            Options.Ecomm360 = true;
            return this;
        }

        public CampaignCreateOptionsBuilder EnableTextClickTracking()
        {
            Options.Tracking.TextClicks = true;
            return this;
        }

        public CampaignCreateOptionsBuilder EnableTimewarp()
        {
            Options.Timewarp = true;
            return this;
        }

        public CampaignCreateOptionsBuilder GenerateText()
        {
            Options.GenerateText = true;
            return this;
        }

        public CampaignCreateOptionsBuilder InFolder(int folderId)
        {
            Options.FolderId = folderId;
            return this;
        }

        public CampaignCreateOptionsBuilder InlineCss()
        {
            Options.InlineCss = true;
            return this;
        }

        public CampaignCreateOptionsBuilder PostToFacebookPages(params string[] pageIds)
        {
            Options.AutoFacebookPost.AddRange(pageIds);
            return this;
        }

        public CampaignCreateOptionsBuilder PushCampaignToHighRise()
        {
            EnsureHighRiseOptionsInitialised();

            Options.CrmTracking.Highrise.Campaign = true;
            return this;
        }

        public CampaignCreateOptionsBuilder PushCampaignToSalesForce()
        {
            EnsureSalesForceOptionsInitialised();

            Options.CrmTracking.SalesForce.Campaign = true;
            return this;
        }

        public CampaignCreateOptionsBuilder PushNotesToCapsule()
        {
            EnsureCapsuleOptionsInitialised();

            Options.CrmTracking.Capsule.Notes = true;
            return this;
        }

        public CampaignCreateOptionsBuilder PushNotesToHighRise()
        {
            EnsureHighRiseOptionsInitialised();

            Options.CrmTracking.Highrise.Notes = true;
            return this;
        }

        public CampaignCreateOptionsBuilder PushNotesToSalesForce()
        {
            EnsureSalesForceOptionsInitialised();

            Options.CrmTracking.SalesForce.Notes = true;
            return this;
        }

        public CampaignCreateOptionsBuilder SendToList(string listId)
        {
            if (string.IsNullOrWhiteSpace(listId))
            {
                throw new ArgumentException("Invalid listId");
            }

            Options.ListId = listId;
            return this;
        }

        public CampaignCreateOptionsBuilder UsingBaseTemplate(int baseTemplateId)
        {
            Options.BaseTemplateId = baseTemplateId;
            return this;
        }

        public CampaignCreateOptionsBuilder UsingGalleryTemplate(int galleryTemplateId)
        {
            Options.GalleryTemplateId = galleryTemplateId;
            return this;
        }

        public CampaignCreateOptionsBuilder UsingTemplate(int templateId)
        {
            Options.TemplateId = templateId;
            return this;
        }

        public CampaignCreateOptionsBuilder WithClickTaleTag(string tag)
        {
            EnsureAnalyticsOptionsInitialised();

            Options.Analytics.ClickTale = tag;
            return this;
        }

        public CampaignCreateOptionsBuilder WithFromEmail(string fromEmail)
        {
            Options.FromEmail = fromEmail;
            return this;
        }

        public CampaignCreateOptionsBuilder WithFromName(string fromName)
        {
            Options.FromName = fromName;
            return this;
        }

        public CampaignCreateOptionsBuilder WithGoalTag(string tag)
        {
            EnsureAnalyticsOptionsInitialised();

            Options.Analytics.Goal = tag;
            return this;
        }

        public CampaignCreateOptionsBuilder WithGoogleAnalyticsTag(string tag)
        {
            EnsureAnalyticsOptionsInitialised();

            Options.Analytics.Google = tag;
            return this;
        }

        public CampaignCreateOptionsBuilder WithSubject(string subject)
        {
            Options.Subject = subject;
            return this;
        }

        public CampaignCreateOptionsBuilder WithTitle(string title)
        {
            Options.Title = title;
            return this;
        }

        public CampaignCreateOptionsBuilder WithToName(string toName)
        {
            Options.ToName = toName;
            return this;
        }

        private void EnsureAnalyticsOptionsInitialised()
        {
            if (Options.Analytics == null)
            {
                Options.Analytics = new CampaignCreateOptions.AnalyticsOptions();
            }
        }

        private void EnsureCapsuleOptionsInitialised()
        {
            EnsureCrmTrackingOptionsInitialised();

            if (Options.CrmTracking.Capsule == null)
            {
                Options.CrmTracking.Capsule = new CampaignCreateOptions.CrmTrackingOptions.CapsuleOptions();
            }
        }

        private void EnsureCrmTrackingOptionsInitialised()
        {
            if (Options.CrmTracking == null)
            {
                Options.CrmTracking = new CampaignCreateOptions.CrmTrackingOptions();
            }
        }

        private void EnsureHighRiseOptionsInitialised()
        {
            EnsureCrmTrackingOptionsInitialised();

            if (Options.CrmTracking.Highrise == null)
            {
                Options.CrmTracking.Highrise = new CampaignCreateOptions.CrmTrackingOptions.HighriseOptions();
            }
        }

        private void EnsureSalesForceOptionsInitialised()
        {
            EnsureCrmTrackingOptionsInitialised();

            if (Options.CrmTracking.SalesForce == null)
            {
                Options.CrmTracking.SalesForce = new CampaignCreateOptions.CrmTrackingOptions.SalesForceOptions();
            }
        }
    }
}
using System;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignContentOptionsBuilder
    {
        private CampaignContentOptions _campaignContentOptions;

        public static implicit operator CampaignContentOptions(CampaignContentOptionsBuilder builder)
        {
            return builder._campaignContentOptions;
        }

        public CampaignContentOptions Build()
        {
            _campaignContentOptions = new CampaignContentOptions();
            return _campaignContentOptions;
        }

        public CampaignContentOptionsBuilder WithEmailAddress(string emailAddress)
        {
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Email address is null or empty");
            }

            _campaignContentOptions.Email = new MailChimpEmail
            {
                EmailAddress = emailAddress
            };

            return this;
        }

        public CampaignContentOptionsBuilder WithEmailUniqueId(string emailUniqueId)
        {
            if (string.IsNullOrWhiteSpace(emailUniqueId))
            {
                throw new ArgumentException("Email address is null or empty");
            }

            _campaignContentOptions.Email = new MailChimpEmail
            {
                EmailUniqueId = emailUniqueId
            };

            return this;
        }

        public CampaignContentOptionsBuilder WithListEmailId(string listEmailId)
        {
            if (string.IsNullOrWhiteSpace(listEmailId))
            {
                throw new ArgumentException("Email address is null or empty");
            }

            _campaignContentOptions.Email = new MailChimpEmail
            {
                ListEmailId = listEmailId
            };

            return this;
        }

        public CampaignContentOptionsBuilder WithView(CampaignContentOptions.ContentView view)
        {
            _campaignContentOptions.View = view;
            return this;
        }
    }
}
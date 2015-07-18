using System;
using MailChimpSharp.Core;
using Xunit;

namespace MailChimpSharp.FunctionalFacts
{
    public class CampaignFacts : FunctionalFactsBase
    {
        [Fact]
        public void CreatesAndGetsSuccessfully()
        {
            // Arrange
            var mailChimp = new MailChimpFactory().Create(TestAPIKey);

            // Act
            // mailChimp.Campaigns.GetContent()

            // Assert
        }
    }
}

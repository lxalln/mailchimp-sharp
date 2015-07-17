using System;
using MailChimpSharp.Core;
using Xunit;

namespace MailChimpSharp.Facts
{
    public class MailChimpConnectorFacts
    {
        public class TheConstructor
        {
            [Theory]
            [InlineData("test-2", "test", "2")]
            [InlineData("a-3", "a", "3")]
            [InlineData("3-12", "3", "12")]
            public void CorrectlyParsesApiKey(string apiKey, string expectedAccessToken, string expectedDataCentrePrefix)
            {
                var mailChimpConnector = new MailChimpConnector(apiKey);

                Assert.Equal(expectedAccessToken, mailChimpConnector.AccessToken);
                Assert.Equal(expectedDataCentrePrefix, mailChimpConnector.DataCentrePrefix);
            }

            [Theory]
            [InlineData("test")]
            [InlineData("-2")]
            [InlineData("test-2-test")]
            public void ThrowsOnInvalidApiKey(string invalidApiKey)
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    // ReSharper disable once ObjectCreationAsStatement
                    new MailChimpConnector(invalidApiKey);
                });
            }
        }
    }
}

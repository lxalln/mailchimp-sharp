namespace MailChimpSharp.Core
{
    internal class MailChimpConnector : IMailChimpConnector
    {
        private readonly string _accessToken;
        private readonly string _dataCentrePrefix;

        public MailChimpConnector(string accessToken, string dataCentrePrefix)
        {
            _accessToken = accessToken;
            _dataCentrePrefix = dataCentrePrefix;
        }

        public TResult Execute<TResult>(string action, object args)
        {
            throw new System.NotImplementedException();
        }
    }
}
namespace MailChimpSharp.Core.Reports
{
    public class Reports : IReports
    {
        private readonly IMailChimpConnector _connector;

        internal Reports(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
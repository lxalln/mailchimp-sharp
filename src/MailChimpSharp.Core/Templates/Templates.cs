namespace MailChimpSharp.Core.Templates
{
    public class Templates : ITemplates
    {
        private readonly IMailChimpConnector _connector;

        internal Templates(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
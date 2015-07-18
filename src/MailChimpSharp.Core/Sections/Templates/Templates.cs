namespace MailChimpSharp.Core.Sections.Templates
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
namespace MailChimpSharp.Core.Sections.Automations
{
    public class Automations : IAutomations
    {
        private readonly IMailChimpConnector _connector;

        internal Automations(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
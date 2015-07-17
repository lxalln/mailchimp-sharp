namespace MailChimpSharp.Core.Automations
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
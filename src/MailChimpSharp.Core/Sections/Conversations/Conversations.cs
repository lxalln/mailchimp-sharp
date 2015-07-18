namespace MailChimpSharp.Core.Sections.Conversations
{
    public class Conversations : IConversations
    {
        private readonly IMailChimpConnector _connector;

        internal Conversations(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
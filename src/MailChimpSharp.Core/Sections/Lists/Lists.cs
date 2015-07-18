namespace MailChimpSharp.Core.Sections.Lists
{
    public class Lists : ILists
    {
        private readonly IMailChimpConnector _connector;

        internal Lists(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
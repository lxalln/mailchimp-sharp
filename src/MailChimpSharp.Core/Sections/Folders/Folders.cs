namespace MailChimpSharp.Core.Sections.Folders
{
    public class Folders : IFolders
    {
        private readonly IMailChimpConnector _connector;

        internal Folders(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
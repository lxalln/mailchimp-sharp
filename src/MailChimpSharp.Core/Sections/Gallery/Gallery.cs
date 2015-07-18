namespace MailChimpSharp.Core.Sections.Gallery
{
    public class Gallery : IGallery
    {
        private readonly IMailChimpConnector _connector;

        internal Gallery(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
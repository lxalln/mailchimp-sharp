namespace MailChimpSharp.Core.Gallery
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
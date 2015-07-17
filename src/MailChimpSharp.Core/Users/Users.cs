namespace MailChimpSharp.Core.Users
{
    public class Users : IUsers
    {
        private readonly IMailChimpConnector _connector;

        internal Users(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
namespace MailChimpSharp.Core
{
    internal interface IMailChimpConnector
    {
        TResult Execute<TResult>(string action, object args);
    }
}
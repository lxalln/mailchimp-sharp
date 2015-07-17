namespace MailChimpSharp.Core
{
    public interface IMailChimpFactory
    {
        IMailChimp Create(string apiKey);

        IMailChimp Create(string accessToken, string dataCentrePrefix);
    }
}
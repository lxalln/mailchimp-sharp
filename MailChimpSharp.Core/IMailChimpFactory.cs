namespace MailChimpSharp.Core
{
    public interface IMailChimpFactory
    {
        IMailChimp Create(string apikey);

        IMailChimp Create(string accessToken, string dataCentrePrefix);
    }
}
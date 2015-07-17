using System.Threading.Tasks;

namespace MailChimpSharp.Core
{
    internal interface IMailChimpConnector
    {
        TResult Execute<TResult>(string action, object args) where TResult : new();

        Task<TResult> ExecuteAsync<TResult>(string action, object args) where TResult : new();
    }
}
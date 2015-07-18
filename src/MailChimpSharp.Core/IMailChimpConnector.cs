using System.Threading;
using System.Threading.Tasks;

namespace MailChimpSharp.Core
{
    internal interface IMailChimpConnector
    {
        TResult Execute<TResult>(string action, object args) where TResult : new();

        Task<TResult> ExecuteAsync<TResult>(string action, object args, CancellationToken cancellationToken) where TResult : new();
    }
}
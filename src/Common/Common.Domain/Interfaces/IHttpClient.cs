using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IHttpClient 
    {
        Task<string> GetAsJsonAsync(string requestUri);
    }
}

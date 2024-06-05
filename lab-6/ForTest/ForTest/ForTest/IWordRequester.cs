using System.Threading.Tasks;

namespace ForTest
{
    internal interface IWordRequester
    {
        Task<string> GetRandomWordAsync();
    }
}

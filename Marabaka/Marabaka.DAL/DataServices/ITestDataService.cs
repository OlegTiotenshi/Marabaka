using Marabaka.DAL.DataObjects;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Marabaka.DAL.DataServices
{
    [Headers("Content-Type: application/json")]
    public interface ITestDataService
    {
        [Get("/todos/1")]
        Task<TestResponse> GetTestRequest(CancellationToken cts);
    }
}

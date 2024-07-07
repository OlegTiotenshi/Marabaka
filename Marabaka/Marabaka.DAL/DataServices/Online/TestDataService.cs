using Marabaka.DAL.DataObjects;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Marabaka.DAL.DataServices.Online
{
    public class TestDataService : BaseDataService<ITestDataService>, ITestDataService
    {
        public async Task<TestResponse> GetTestRequest(CancellationToken cts)
        {
            try
            {
                return await InstanceInterface.GetTestRequest(cts);
            }
            catch (Exception ex)
            {
                TrackError(ex);
                return null;
            }
        }
    }
}

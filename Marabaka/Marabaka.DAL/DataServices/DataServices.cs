using Marabaka.DAL.DataServices.Online;

namespace Marabaka.DAL.DataServices
{
    public class DataServices
    {
        public static void Init()
        {
            Tests = new TestDataService();
        }

        public static ITestDataService Tests { get; private set; }
    }
}

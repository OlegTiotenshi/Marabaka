using Refit;
using System;
using System.Net.Http;

namespace Marabaka.DAL.DataServices.Online
{
    public class BaseDataService
    {
        protected static string host = "https://jsonplaceholder.typicode.com/";

        static readonly Lazy<HttpClient> _httpClient = new Lazy<HttpClient>(() => new HttpClient()
        {
            BaseAddress = new Uri(host)
        });

        protected static HttpClient HttpClient => _httpClient.Value;

        protected void TrackError(Exception ex)
        {
            //Microsoft.AppCenter.Crashes.Crashes.TrackError(ex);
        }
    }

    public class BaseDataService<T> : BaseDataService
    {
        protected T InstanceInterface => RestService.For<T>(HttpClient);
    }
}

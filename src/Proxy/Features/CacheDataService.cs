using Proxy.Services;

namespace Proxy.Features
{
    public class CacheDataService : IDataService
    {
        private readonly RemoteDataService _remoteDataService;
        private string _cachedData;

        public CacheDataService(RemoteDataService remoteDataService, string? cachedData = null)
        {
            _remoteDataService = remoteDataService;
            _cachedData = cachedData!;
        }

        public string GetData()
        {
            if (_cachedData == null)
            {
                Console.WriteLine("Cache miss. Fetching data...");
                _cachedData = _remoteDataService.GetData();
            }
            else
            {
                Console.WriteLine("Cache hit. Returning cached data...");
            }
            return _cachedData;
        }
    }
}

namespace Proxy.Services
{
    public class RemoteDataService : IDataService
    {
        public string GetData()
        {
            // Simulate a network call to fetch data
            Console.WriteLine("Fetching data from remote service...");
            return "Data from remote service";
        }
    }
}

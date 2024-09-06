using CommandService.Models;
using System.Collections.Generic;

namespace CommandServices.SyncDataServices.Grpc
{
    public class PlatformDataClient : IPlatformDataClient
    {
        public PlatformDataClient()
        {
        }

        public IEnumerable<Platform> ReturnAllPlatforms()
        {
            throw new System.NotImplementedException();
        }
    }
}

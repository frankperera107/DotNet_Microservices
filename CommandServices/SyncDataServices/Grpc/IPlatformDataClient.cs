using CommandService.Models;
using System.Collections.Generic;

namespace CommandServices.SyncDataServices.Grpc
{
    public interface IPlatformDataClient
    {
        IEnumerable<Platform> ReturnAllPlatforms();
    }

}

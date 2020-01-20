using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Dhgms.AspNetCoreContrib.Example.WebMvcApp.Hubs
{
    /// <summary>
    /// Fake SignalR Hub.
    /// </summary>
    public class FakeHub : Hub<IFakeHubClient>
    {
    }


}

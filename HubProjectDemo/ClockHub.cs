using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace HubProjectDemo
{
    public class ClockHub : Hub<IClock>
    {
        public async Task SendTimeToClients(DateTime dateTime)
        {
            await Clients.All.ShowTime(dateTime);
        }
    }
}

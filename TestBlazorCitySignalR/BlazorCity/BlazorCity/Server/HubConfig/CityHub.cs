using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCity.Server.HubConfig
{
    public class CityHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("RecieveMessage");
        }
    }
}

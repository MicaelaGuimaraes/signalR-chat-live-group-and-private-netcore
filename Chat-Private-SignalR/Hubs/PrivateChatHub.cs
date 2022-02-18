using Chat_Private_SignalR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Private_SignalR.Hubs
{
    public class PrivateChatHub : Hub
    {
        public string GetConnectionId() => Context.ConnectionId;
        public async Task SendMessagePrivate([FromBody] PrivateChatHubModels dataPrivateChatHub)
        {
            await Clients.All.SendAsync("ReceiveMessage",
                dataPrivateChatHub.UserLogged,
                dataPrivateChatHub.Message,
                dataPrivateChatHub.UserReceive,
                dataPrivateChatHub.ConnectionId);
        }

    }
}

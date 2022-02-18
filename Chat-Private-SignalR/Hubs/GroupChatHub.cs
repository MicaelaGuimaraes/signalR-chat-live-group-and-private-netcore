using Chat_Private_SignalR.Hubs.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Private_SignalR.Hubs
{
    public class GroupChatHub : Hub<IGroupChatHub>, IGroupChatHub
    {
        private const string GROUP_CHAT = "GroupChatHub";

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, GROUP_CHAT);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, GROUP_CHAT);
        }

        public async Task OnEnterChatAsync(string idUser)
        {
            await Clients.Groups(GROUP_CHAT).OnEnterChatAsync(idUser);
        }

        public async Task OnExitChatAsync(string idUser)
        {
            await Clients.OthersInGroup(GROUP_CHAT).OnExitChatAsync(idUser);
        }

        public async Task OnNewMessageAsync(string idUser, string message)
        {
            await Clients.OthersInGroup(GROUP_CHAT).OnNewMessageAsync(idUser, message);
        }
    }
}

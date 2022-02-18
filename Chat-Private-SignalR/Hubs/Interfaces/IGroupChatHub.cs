using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Private_SignalR.Hubs.Interfaces
{
    public interface IGroupChatHub
    {
        Task OnExitChatAsync(string idUser);
        Task OnEnterChatAsync(string idUser);
        Task OnNewMessageAsync(string idUser, string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Private_SignalR.Models
{
    public class PrivateChatHubModels
    {
        public string ConnectionId { get; set; }
        public string UserLogged { get; set; }
        public string UserReceive { get; set; }
        public string Message { get; set; }
    }
}

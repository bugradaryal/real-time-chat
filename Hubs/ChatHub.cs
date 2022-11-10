using Microsoft.AspNetCore.SignalR;
using real_time_chat.Models;
using System.Threading.Tasks;

namespace real_time_chat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("receiveMEssage", message);
    }
}

using AngularSignalR.DataStorage;
using AngularSignalR.Hubs;
using AngularSignalR.TimerFeatures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AngularSignalR.Controllers
{
    public class ChatController : ControllerBase
    {
        private IHubContext<ChatHub> _chat;

        public ChatController(IHubContext<ChatHub> chat)
        {
            _chat = chat;
        }

        public IActionResult Get()
        {
            var broadcaster = new TimerManager(() =>
                _chat.Clients.All.SendAsync("transferchartdata", DataManager.GetMessages()));

            return new OkResult();
        }
    }
}